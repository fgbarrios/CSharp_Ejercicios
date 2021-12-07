using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Xml.Serialization;

namespace Clase15_Serializacion
{
    class Program
    {
        /*
        static void Main(string[] args)
        {
            string rutaEscritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string rutaArchivo = Path.Combine(rutaEscritorio, "personaje.xml");

            //Personaje mago = new Mago(100, "Mario Bross", 200);
            //Personaje guerrero = new Guerrero(100, "Mario Bross", 300);

            //List<Personaje> personajes = new List<Personaje>()
            //{ 
            //    mago, 
            //    guerrero
            //};

            //SerializarAXMl(rutaArchivo, personajes);

            // DESERIALIZAR

            //Personaje personaje = DeSerializarAXMl<Personaje>(rutaArchivo);
            //Console.WriteLine(personaje);

            // para listas de objetos
           
            List<Personaje> personajes = DeSerializarAXMl<List<Personaje>>(rutaArchivo);
            foreach (Personaje item in personajes)
            {
                Console.WriteLine(item);
            }         

        }

        private static void SerializarAXMl<T>(string ruta, T objeto)
        {
            using (StreamWriter streamWriter = new StreamWriter(ruta))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));

                xmlSerializer.Serialize(streamWriter, objeto);

            }
        }

        private static T DeSerializarAXMl<T>(string ruta)
            where T : class
        {
            using (StreamReader streamReader = new StreamReader(ruta))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));

                // casteo el retorno (ya que no se hace automaticamente)
                //T objeto = (T) xmlSerializer.Deserialize(streamReader);

                // otra forma de hacerlo es poniendo "as T"
                // (lo que nos obliga a incluir where T : class)
                // esto devuelve null en caso de no poder castearlo, la otra forma tira una excepcion
                T objeto = xmlSerializer.Deserialize(streamReader) as T;

                return objeto;
            }
        }
        */

        // ---------------------------------------------------SERIALIZACION JSON

        static void Main(string[] args)
        {
            string rutaEscritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string rutaArchivo = Path.Combine(rutaEscritorio, "personaje.json");

            Personaje personaje = new Personaje(50, "Carpincho");

            Personaje mago = new Mago(100, "Mario Bross", 200);
            Personaje guerrero = new Guerrero(100, "Mario Bross", 300);

            List<Personaje> nuevosPersonajes = new List<Personaje>()
            {
                mago,
                guerrero
            };

            //Serializar
            SerializarAJson(rutaArchivo, nuevosPersonajes);

            //Deserializar
            //Personaje personaje = DeserializarDesdeJson<Personaje>(rutaArchivo);
            //Console.WriteLine(personaje);

            /*
            List<Personaje> personajes = DeserializarDesdeJson<List<Personaje>>(rutaArchivo);
            foreach (Personaje item in personajes)
            {
                Console.WriteLine(item);
            }
            */
        }

        private static void SerializarAJson<T>(string ruta, T objeto)
        {
            // opciones para indentar el archivo json
            JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions();
            jsonSerializerOptions.WriteIndented = true;


            string objetoJson = JsonSerializer.Serialize(objeto, jsonSerializerOptions);

            File.WriteAllText(ruta, objetoJson);

        }

        private static T DeserializarDesdeJson<T>(string ruta)
        {
            string objetoJson = File.ReadAllText(ruta);

            T objeto = JsonSerializer.Deserialize<T>(objetoJson);

            return objeto;
        }

    }
}
