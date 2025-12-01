// ###################################################################################
// ########## 	Proyecto:		Archivos.cs									##########
// ########## 	Developer:		Sarai Montes								##########
// ########## 	Descripción:	Librería de manejo de archivos				##########
// ###################################################################################

// ###################################################################################
// ########## 	Librerias													##########
// ###################################################################################
using System.IO;

// ###################################################################################
// ########## 	Funciones relacionadas con archivos							##########
// ###################################################################################

namespace SpaceArchivos	// <-- Aquí declaramos el nombre del namespace
{	public static class Archivos     // <-- Aquí declaramos la clase
	{
		static string RutaArchivo = "archivos/";
		// Comprobar que archivo existe
		public static bool ArchivoComprobar(string NombreArchivo)
		{
			// Lógica para comprobar si un archivo existe
			string RutaCompleta = Path.Combine(RutaArchivo, NombreArchivo);	// Construir la ruta completa del archivo
			bool ArchivoExiste = false;	// Variable para almacenar el resultado de la comprobación
			Console.WriteLine($"Comprobando existencia del archivo: {NombreArchivo}");	// Mensaje de depuración
			ArchivoExiste = File.Exists(RutaCompleta);	// Comprobar si el archivo existe
			Console.WriteLine($"¿Existe?: {ArchivoExiste}");	// Mensaje de depuración
			return ArchivoExiste;	// Devolver el resultado de la comprobación
		}	

		// Leer archivo
		public static string ArchivoLeer(string NombreArchivo)
		{
			// Lógica para leer un archivo
			string RutaCompleta = Path.Combine(RutaArchivo, NombreArchivo);	// Construir la ruta completa del archivo
			string ContenidoArchivo = "";	// Variable para almacenar el contenido del archivo
			Console.WriteLine($"Leyendo archivo: {NombreArchivo}");
			ContenidoArchivo = File.ReadAllText(RutaCompleta);	// Leer el contenido del archivo
			Console.WriteLine("Contenido del archivo:");	// Mostrar el contenido del archivo
			Console.WriteLine($"{ContenidoArchivo}");	// Mostrar el contenido del archivo
			return ContenidoArchivo;	// Devolver el contenido del archivo
		}
	}
}