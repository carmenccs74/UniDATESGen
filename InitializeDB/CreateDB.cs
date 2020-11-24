
/*PROTECTED REGION ID(CreateDB_imports) ENABLED START*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using UniDATESGenNHibernate.EN.UniDATES;
using UniDATESGenNHibernate.CEN.UniDATES;
using UniDATESGenNHibernate.CAD.UniDATES;
using UniDATESGenNHibernate.Enumerated.UniDATES;
using UniDATESGenNHibernate.CP.UniDATES;

/*PROTECTED REGION END*/
namespace InitializeDB
{
public class CreateDB
{
public static void Create (string databaseArg, string userArg, string passArg)
{
        String database = databaseArg;
        String user = userArg;
        String pass = passArg;

        // Conex DB
        SqlConnection cnn = new SqlConnection (@"Server=(local)\sqlexpress; database=master; integrated security=yes");

        // Order T-SQL create user
        String createUser = @"IF NOT EXISTS(SELECT name FROM master.dbo.syslogins WHERE name = '" + user + @"')
            BEGIN
                CREATE LOGIN ["                                                                                                                                     + user + @"] WITH PASSWORD=N'" + pass + @"', DEFAULT_DATABASE=[master], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
            END"                                                                                                                                                                                                                                                                                    ;

        //Order delete user if exist
        String deleteDataBase = @"if exists(select * from sys.databases where name = '" + database + "') DROP DATABASE [" + database + "]";
        //Order create databas
        string createBD = "CREATE DATABASE " + database;
        //Order associate user with database
        String associatedUser = @"USE [" + database + "];CREATE USER [" + user + "] FOR LOGIN [" + user + "];USE [" + database + "];EXEC sp_addrolemember N'db_owner', N'" + user + "'";
        SqlCommand cmd = null;

        try
        {
                // Open conex
                cnn.Open ();

                //Create user in SQLSERVER
                cmd = new SqlCommand (createUser, cnn);
                cmd.ExecuteNonQuery ();

                //DELETE database if exist
                cmd = new SqlCommand (deleteDataBase, cnn);
                cmd.ExecuteNonQuery ();

                //CREATE DB
                cmd = new SqlCommand (createBD, cnn);
                cmd.ExecuteNonQuery ();

                //Associate user with db
                cmd = new SqlCommand (associatedUser, cnn);
                cmd.ExecuteNonQuery ();

                System.Console.WriteLine ("DataBase create sucessfully..");
        }
        catch (Exception ex)
        {
                throw ex;
        }
        finally
        {
                if (cnn.State == ConnectionState.Open) {
                        cnn.Close ();
                }
        }
}

public static void InitializeData ()
{
        /*PROTECTED REGION ID(initializeDataMethod) ENABLED START*/
        try
        {
                // Insert the initilizations of entities using the CEN classes
                CitaCEN citCEN = new CitaCEN ();
                UsuarioCEN usuCEN = new UsuarioCEN ();
                int usu_id = usuCEN.Registrarse ("Pepe", "Gonzalez", "AAAAAA", "pepe@gmail.com", 655768409, SexoEnum.hombre, OrientacionSexualEnum.heterosexual, "foto.jpg");
                int usu2_id = usuCEN.Registrarse ("Juanito", "Lopez", "BBBBBB", "juanito@gmail.com", 655768409, SexoEnum.hombre, OrientacionSexualEnum.heterosexual, "foto.jpg");
                int usu3_id = usuCEN.Registrarse ("Ismael", "Garcia", "CCCCCC", "ismael@gmail.com", 622324532, SexoEnum.hombre, OrientacionSexualEnum.bisexual, "foto.jpg");
                int usu4_id = usuCEN.Registrarse ("Paula", "Martinez", "DDDDDD", "paula@gmail.com", 674892364, SexoEnum.mujer, OrientacionSexualEnum.heterosexual, "foto.jpg");
                int usu5_id = usuCEN.Registrarse ("Rocío", "Benito", "EEEEEE", "rocio@gmail.com", 633285746, SexoEnum.otro, OrientacionSexualEnum.bisexual, "foto.jpg");
                usuCEN.BloquearUsuario (usu_id, usu2_id);


                int cita1_id = citCEN.New_ (ObjetivoEnum.ocio, usu_id, usu2_id, false);
                int cita2_id = citCEN.New_ (ObjetivoEnum.amor, usu5_id, usu3_id, false);
                int cita3_id = citCEN.New_ (ObjetivoEnum.sexo, usu4_id, usu2_id, false);
                citCEN.Aceptar (cita1_id, true);
                IList<CitaEN> citasSolicitadas = citCEN.DameChats (usu2_id);

                //Se recorren las citas que tiene Juanito (ya sea como solicitante o receptor)
                Console.WriteLine ("Citas solicitadas: ");
                foreach (CitaEN ci in citasSolicitadas) {
                        Console.WriteLine ("IDcita: " + ci.IdCita);
                        UsuarioEN usuEN = usuCEN.ReadOID (ci.UsuarioReceptor.IdUsuario);
                        UsuarioEN usu2EN = usuCEN.ReadOID (ci.UsuarioSolicitante.IdUsuario);
                        Console.WriteLine ("Solicitante: " + usu2EN.Nombre + " Receptor: " + usuEN.Nombre);
                }

                //Se recorren las citas que han solicitado a Juanito y todavía no las ha aceptado
                IList<CitaEN> citasPendientes = citCEN.DamePendientes (usu2_id);
                Console.WriteLine ("Citas pendientes: ");
                foreach (CitaEN ci in citasPendientes) {
                        Console.WriteLine ("IDcita: " + ci.IdCita);
                        UsuarioEN usuEN = usuCEN.ReadOID (ci.UsuarioReceptor.IdUsuario);
                        UsuarioEN usu2EN = usuCEN.ReadOID (ci.UsuarioSolicitante.IdUsuario);
                        Console.WriteLine ("Solicitante: " + usu2EN.Nombre + " Receptor: " + usuEN.Nombre);
                }


                //CREAR MENSAJE
                MensajeCEN menCEN = new MensajeCEN ();
                MensajeCP menCP = new MensajeCP ();
                MensajeEN menEN = null;

                menEN = menCP.New_ ("Hola", "", "", usu2_id, usu_id);
                if (menEN != null) {
                        Console.WriteLine ("Mensaje: " + menEN.Texto + " Enviado a: " + menEN.Receptor.Nombre + " por " + menEN.Emisor.Nombre);
                }
                else{
                        Console.WriteLine ("no se crea el mensaje");
                }

                //Creo un mensaje no válido porque no existe ninguna cita entre usu4 y usu5
                MensajeEN men2EN = menCP.New_ ("¿Que tal?", "", "", usu4_id, usu5_id);
                if (men2EN != null) {
                        Console.WriteLine ("Mensaje: " + men2EN.Texto + " Enviado a: " + men2EN.Receptor.Nombre + " por " + men2EN.Emisor.Nombre);
                }
                else{
                        //No lo crea porque  la cita no existe
                        Console.WriteLine ("no se crea el mensaje");
                }

                Console.WriteLine ("--------------------------------------------------------------");
                //RESTABLECER CONTRASEÑA
                int usu6_id = usuCEN.Registrarse ("Alejandra", "Sanchez Diaz", "contra1", "ale@gmail.com", 123456, SexoEnum.otro, OrientacionSexualEnum.homosexual, "foto.jpg");

                Console.WriteLine ("Contraseña inicial: " + usuCEN.ReadOID (usu6_id).Contraseña);

                usuCEN.RestablecerContraseña (usu6_id, "contra2");

                Console.WriteLine ("Contraseña final: " + usuCEN.ReadOID (usu6_id).Contraseña);

                Console.WriteLine ("--------------------------------------------------------------");
                //DENUNCIAR
                int usu7_id = usuCEN.Registrarse ("Manolo", "Perez Vaquero", "contraManolo", "mpv@gmail.com", 693325112, SexoEnum.hombre, OrientacionSexualEnum.heterosexual, "foto.jpg");

                Console.WriteLine ("Denunciado antes " + usu6_id + "?: " + usuCEN.ReadOID (usu6_id).Denunciado);
                Console.WriteLine ("Denunciado antes " + usu3_id + "?: " + usuCEN.ReadOID (usu3_id).Denunciado);


                AdministradorCEN adCEN = new AdministradorCEN ();
                int idAdmin = adCEN.Registrarse ("123456789", "admin1@gmail.com");
                usuCEN.Denunciar (usu7_id, usu6_id, DateTime.Today, MotivoIncidenciaEnum.cuentaSpam, idAdmin);
                usuCEN.Denunciar (usu7_id, usu3_id, DateTime.Today, MotivoIncidenciaEnum.comentarioInadecuado, idAdmin);

                Console.WriteLine ("Denunciado despues " + usu6_id + "?: " + usuCEN.ReadOID (usu6_id).Denunciado);
                Console.WriteLine ("Denunciado despues " + usu3_id + "?: " + usuCEN.ReadOID (usu3_id).Denunciado);

                Console.WriteLine ("--------------------------------------------------------------");

                //INCIDENCIAS
                IncidenciaCEN incidenciaCEN = new IncidenciaCEN ();
                int idInci = incidenciaCEN.New_ (MotivoIncidenciaEnum.cuentaSpam, new DateTime (2020, 10, 31), usu3_id, usu5_id, idAdmin);
                int idInci2 = incidenciaCEN.New_ (MotivoIncidenciaEnum.publicacionInadecuada, new DateTime (2020, 10, 31), usu4_id, usu5_id, idAdmin);

                incidenciaCEN.Resolver (idInci, "Resuelta");
                IncidenciaEN inciEN = incidenciaCEN.ReadOID (idInci);
                //AdministradorEN adminEN = adCEN.ReadOID ();
                Console.WriteLine ("Incidencia :" + inciEN.Resolucion);

                AdministradorEN adminEN = adCEN.ReadOID (idAdmin);

                Console.WriteLine ("Incidencias de " + adminEN.Email);
                IList<IncidenciaEN> listaIncidencia = incidenciaCEN.DameDenuncias (idAdmin);
                foreach (IncidenciaEN inci in listaIncidencia) {
                        Console.WriteLine ("Incidencia: " + inci.Motivo);
                }




                Console.WriteLine ("--------------------------------------------------------------");
                //BLOQUEAR USUARIO
                Console.WriteLine ("Bloqueado antes " + usu6_id + "?: " + usuCEN.ReadOID (usu6_id).Bloqueado);
                Console.WriteLine ("Bloqueados usu7 antes: " + usuCEN.ReadOID (usu7_id).UsuariosBloqueados);

                usuCEN.BloquearUsuario (usu7_id, usu6_id);

                Console.WriteLine ("Bloqueado despues " + usu6_id + "?: " + usuCEN.ReadOID (usu6_id).Bloqueado);
                Console.WriteLine ("Bloqueados usu7 despues: " + usuCEN.ReadOID (usu7_id).UsuariosBloqueados);


                Console.WriteLine ("--------------------------------------------------------------");
                //DESBLOQUEAR USUARIO
                Console.WriteLine ("Bloqueado antes " + usu6_id + "?: " + usuCEN.ReadOID (usu6_id).Bloqueado);
                Console.WriteLine ("Bloqueados usu7 antes: " + usuCEN.ReadOID (usu7_id).UsuariosBloqueados);

                usuCEN.DesbloquearUsuario (usu7_id, usu6_id);

                Console.WriteLine ("Bloqueado despues " + usu6_id + "?: " + usuCEN.ReadOID (usu6_id).Bloqueado);
                Console.WriteLine ("Bloqueados usu7 despues: " + usuCEN.ReadOID (usu7_id).UsuariosBloqueados);


                Console.WriteLine ("--------------------------------------------------------------");
                //BUSCAR USUARIO
                IList<UsuarioEN> listaUsuario = usuCEN.BuscarUsuario ("Pepe");
                foreach (UsuarioEN us in listaUsuario) {
                        Console.WriteLine ("Usuario buscado: " + us.Nombre + " " + us.Apellidos);
                }

                //DAME USUARIO POR FILTRO
                IList<UsuarioEN> listaUsuarios = usuCEN.DameUsuarioPorFiltro (SexoEnum.hombre, "", "", "", 2, ObjetivoEnum.amistad, GastronomiaEnum.italiano, OcioEnum.festival, GustosMusicalesEnum.reggaeton, DeportesEnum.hockey);
                foreach (UsuarioEN us in listaUsuarios) {
                        Console.WriteLine ("Usuario por filtro" +
                                ": " + us.Nombre + " " + us.Apellidos);
                }

                //DAME USUARIO BLOQUEADOS
                IList<UsuarioEN> listaUsuariosBloqueados = usuCEN.DameUsuariosBloqueados ();
                foreach (UsuarioEN us in listaUsuariosBloqueados) {
                        Console.WriteLine ("Usuario bloqueado: " + us.Nombre + " " + us.Apellidos);
                }

                //DAME USUARIO DENUNCIADOS
                IList<UsuarioEN> listaUsuariosDenunciados = usuCEN.DameUsuariosDenunciados ();
                foreach (UsuarioEN us in listaUsuariosDenunciados) {
                        Console.WriteLine ("Usuario denunciado: " + us.Nombre + " " + us.Apellidos);
                }

                //DAME USUARIO REGISTRADOS
                IList<UsuarioEN> listaUsuariosRegistrados = usuCEN.DameUsuariosRegistrados ();
                foreach (UsuarioEN us in listaUsuariosRegistrados) {
                        Console.WriteLine ("Usuario registrado: " + us.Nombre + " " + us.Apellidos);
                }

                //DAME USUARIO ELIMINADOS
                IList<UsuarioEN> listaUsuariosEliminados = usuCEN.DameUsuariosEliminados ();
                foreach (UsuarioEN us in listaUsuariosEliminados) {
                        Console.WriteLine ("Usuario eliminado: " + us.Nombre + " " + us.Apellidos);
                }

                Console.WriteLine ("--------------------------------------------------------------");
                //PLANES PREMIUM
                UsuarioCEN usuaCEN = new UsuarioCEN ();
                int idUsu = usuaCEN.Registrarse ("Pepe", "Garc�a V�zquez", "contrase�a", "pepe2@gmail.com", 123456, SexoEnum.hombre, OrientacionSexualEnum.bisexual, "foto.jpg");



                PlanesPremiumCP planpremCP = new PlanesPremiumCP ();
                planpremCP.Pagar (PlanesPremEnum.mes, 5, "descripcion", "mes", idUsu);
                planpremCP.Pagar(PlanesPremEnum.dia, 3, "desc", "dia", usu7_id);

                //hola


                /*PROTECTED REGION END*/
        }
        catch (Exception ex)
        {
                System.Console.WriteLine (ex.InnerException);
                throw ex;
        }
}
}
}
