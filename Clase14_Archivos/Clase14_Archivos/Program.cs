using System;
using System.IO;

namespace Clase14_Archivos
{
    class Program
    {
        static void Main(string[] args)
        {
            //VerificarSistemaOperativo();
            //ObtenerInformacionOS();
            //ObtenerInformacionAlmacenamiento();

            //CrearDirectorio();
            //TrabajarConRutasAbsolutasYRelativas();
            //TrabajarConRutas();

            try
            {
                LeerArchivoTextoConFile();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            

        }

        static void EscribirArchivoTextoConStreamWriterYFinally()
        {            
            StreamWriter streamWriter = null;

            try
            {
                string ruta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Archivos");
                if (!Directory.Exists(ruta)) //si no existe la carpeta, la creo
                {
                    Directory.CreateDirectory(ruta);
                }

                ruta = Path.Combine(ruta, "HolaMundo.txt"); // agrego el nombre del archivo a la ruta. Path.Combine NO CREA ARCHIVOS, solo crea la ruta para usarla despues

                streamWriter = new StreamWriter(ruta, true); // StreamWriter crea el archivo si no existe. No crea el directorio (por eso se usa CreateDirectory)

                // escribo en el archivo
                streamWriter.WriteLine("Hola Mundo");
                streamWriter.Write("Sentencia agregada al texto", true);
            }
            finally
            {
                if (streamWriter is not null)
                {
                    streamWriter.Close(); // cierra el archivo
                    streamWriter.Dispose(); // libera los recursos de streamwriter
                }
                
            }        

        }
        static void LeerArchivoTextoConStreamReaderYFinally()
        {
            StreamReader streamReader = null;

            try
            {
                string ruta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Archivos", "HolaMundo.txt");
                
                streamReader = new StreamReader(ruta);

                while (!streamReader.EndOfStream)
                {
                    string textoArchivo = streamReader.ReadLine();
                    Console.WriteLine(textoArchivo);
                }
            }
            finally
            {
                if (streamReader is not null)
                {
                    streamReader.Close(); // cierra el archivo
                    streamReader.Dispose(); // libera los recursos de streamwriter
                }

            }

        }

        static void EscribirArchivoTextoConStreamWriterYUsing()
        {           
            string ruta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), 
                "Archivos", "HolaMundo.txt");

            using (StreamWriter streamWriter = new StreamWriter(ruta))
            {
                // escribo en el archivo
                streamWriter.WriteLine("Texto agregado desde el metodo USING");
            }
                       
        }
        static void LeerArchivoTextoConStreamreaderYUsing()
        {
            string ruta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), 
                "Archivos", "HolaMundo.txt");

            using (StreamReader streamReader = new StreamReader(ruta))
            {
                //el metodo READTOEND lee hasta el final
                string textoArchivo = streamReader.ReadToEnd();
                Console.WriteLine(textoArchivo);                
            }

            //tambien se puede hacer el mismo codigo, pero de forma simplificada. Solo en comandos cortos.
            /*
            using StreamReader streamReader = new StreamReader(ruta);
            Console.WriteLine(streamReader.ReadToEnd());
            */
        }

        static void EscribirArchivoTextoConFile()
        {
            string ruta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                "Archivos", "HolaMundo.txt");

            if (File.Exists(ruta))
            {
                File.Delete(ruta);
            }
            // WriteAllText si no existe el archivo, lo crea.
            File.WriteAllText(ruta, "HOLA MUNDO EN C#");

            // Append agrega texto a ruta
            File.AppendAllText(ruta,"Comision 2 A");

            string rutaCopy = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                "Archivos", "copia.txt");

            File.Copy(ruta, rutaCopy);
            File.WriteAllText(rutaCopy, "Pise lo que tenia el texto anterior");

            string rutaNueva = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                "Archivos", "ChauMundo.txt");

            File.Move(ruta, rutaNueva);

        }
        static void LeerArchivoTextoConFile()
        {
            string rutaNueva = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                "Archivos", "ChauMundo.txt");
            if (File.Exists(rutaNueva))
            {
                Console.WriteLine(File.ReadAllText(rutaNueva));
            }
            
        }

        static void TrabajarConRutas()
        {
            //string ruta = Path.Combine("C:", @"\Users\PC\source\repos\Clase14_Archivos"); // el @ funciona como escape
            string rutaActual = Path.GetFullPath(".");
            Console.WriteLine($"Ruta Actual: {rutaActual}");

            Console.WriteLine($"Archivos en ruta actual:");
            string ruta = Path.Combine(".");
            string[] archivos = Directory.GetFiles(ruta);

            foreach (string item in archivos)
            {
                Console.WriteLine(item);
            }

            ruta = Path.Combine(".", "Clase14_Archivos.exe");

            string extension = Path.GetExtension(ruta);
            string nombreArchivoConExtension = Path.GetFileName(ruta);
            string nombreArchivoSinExtension = Path.GetFileNameWithoutExtension(ruta);

            bool tieneExtension = Path.HasExtension(ruta);
            Console.WriteLine("---------------------------------");
            Console.WriteLine(ruta);
            Console.WriteLine($"Extension del archivo: {extension}");
            Console.WriteLine($"Nombre del archivo CON extension: {nombreArchivoConExtension}");
            Console.WriteLine($"Nombre del archivo SIN extension: {nombreArchivoSinExtension}");
            Console.WriteLine($"Tiene extension?: {tieneExtension}");


        }

        static void TrabajarConRutasAbsolutasYRelativas()
        {
            string rutaAbsoluta = Path.GetFullPath(".");
            Console.WriteLine($"Ruta absoluta: {rutaAbsoluta}");

            string rutaEscritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            Console.WriteLine($"Ruta Escritorio: {rutaAbsoluta}");

            string rutaRelativa = Path.GetRelativePath(".", rutaEscritorio);
            Console.WriteLine($"Ruta relativa entre . y escritorio: {rutaRelativa}");

            string rutaRelativaAEscritorio = Path.GetRelativePath(rutaEscritorio, ".");
            Console.WriteLine($"Ruta relativa entre escritorio y .: {rutaRelativaAEscritorio}");

            // Ruta a Mis Documentos
            string rutaMisDocumentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            Console.WriteLine($"Ruta a Mis Documentos: {rutaMisDocumentos}");

            string rutaRelativaAMisDocumentos = Path.GetRelativePath(rutaMisDocumentos, ".");
            Console.WriteLine($"Ruta relativa entre Mis Documentos y . (donde esta la app): {rutaRelativaAMisDocumentos}");

            rutaRelativaAMisDocumentos = Path.GetRelativePath( ".", rutaMisDocumentos);
            Console.WriteLine($"Ruta relativa entre . (donde esta la app) y Mis Documentos: {rutaRelativaAMisDocumentos}");

        }

        static void CrearDirectorio()
        {
            string rutaEscritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            Console.WriteLine($"Ruta del directorio: {rutaEscritorio}");

            //Creo la nueva carpeta en el Escritorio
            string rutaNuevoDirectorio = Path.Combine(rutaEscritorio, "Prueba");
            Console.WriteLine($"Ruta del NUEVO directorio: {rutaNuevoDirectorio}");

            //Chequeo si existe, devuelve FALSE
            VerificarSiExisteDirectorio(rutaNuevoDirectorio);

            //Creo el directorio
            Console.WriteLine("Creo un directorio...");
            Directory.CreateDirectory(rutaNuevoDirectorio);
            //Chequeo si existe, ahora devuelve TRUE
            VerificarSiExisteDirectorio(rutaNuevoDirectorio);


            // el comando MOVE sirve para mover un directorio o cambiarle el nombre a uno
            string nuevoNombreRuta = Path.Combine(rutaEscritorio, "PruebaRenombrado");
            Console.WriteLine($"Ruta Renombrada: {nuevoNombreRuta}");

            VerificarSiExisteDirectorio(nuevoNombreRuta);

            Console.WriteLine("Muevo/Renombro...");
            Directory.Move(rutaNuevoDirectorio, nuevoNombreRuta);
            VerificarSiExisteDirectorio(rutaNuevoDirectorio);
            VerificarSiExisteDirectorio(nuevoNombreRuta);
        }

        static void VerificarSiExisteDirectorio(string path)
        {
            bool existeDirectorio = Directory.Exists(path);
            Console.WriteLine($"Existe Directorio?: {existeDirectorio}");
        }

        static void VerificarSistemaOperativo()
        {
            Console.WriteLine($"Es Linux? {OperatingSystem.IsLinux()}");
            Console.WriteLine($"Es Windows? {OperatingSystem.IsWindows()}");
        }
        static void ObtenerInformacionOS()
        {
            Console.WriteLine($"SIstema Operativo: {Environment.OSVersion}");
            Console.WriteLine($"Plataforma: {Environment.OSVersion.Platform}");
            Console.WriteLine($"Version: {Environment.OSVersion.Version}");
            Console.WriteLine($"CAntidad procesadores logicos: {Environment.ProcessorCount}");
            Console.WriteLine($"Es arquitectura de 64 bits?: {Environment.Is64BitProcess}");

            Console.WriteLine($"Usuario: {Environment.UserName}");
            Console.WriteLine($"salto de linea con Enviroment: {Environment.NewLine} texto por debajo");
        }

        static void ObtenerInformacionAlmacenamiento()
        {
            DriveInfo[] volumenes = DriveInfo.GetDrives();

            foreach (DriveInfo unidad in volumenes)
            {
                Console.WriteLine($"{unidad.Name}");
                Console.WriteLine($"{unidad.DriveType}");
                Console.WriteLine($"{unidad.DriveFormat}");
                Console.WriteLine($"{unidad.TotalSize}");
                Console.WriteLine($"Espacio Libre (en bits):{unidad.TotalFreeSpace}");
                Console.WriteLine($"---------------------------{Environment.NewLine}");
            }
        }

    }
}
