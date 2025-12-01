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
			string RutaCompleta = Path.Combine(RutaArchivo, NombreArchivo);
			bool ArchivoExiste = false;
			Console.WriteLine($"Comprobando existencia del archivo: {NombreArchivo}");
			ArchivoExiste = File.Exists(RutaCompleta);			
			Console.WriteLine($"¿Existe?: {ArchivoExiste}");
			return ArchivoExiste;
		}	



		// Leer archivo
		public static void ArchivoLeer(string NombreArchivo)
		{
			// Lógica para leer un archivo
			Console.WriteLine($"Leyendo archivo: {NombreArchivo}");
		}
	}
}