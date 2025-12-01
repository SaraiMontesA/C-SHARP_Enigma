// ###################################################################################
// ########## 	Proyecto:		Archivos.cs									##########
// ########## 	Developer:		Sarai Montes								##########
// ########## 	Descripción:	Librería de manejo de archivos				##########
// ###################################################################################

// ###################################################################################
// ########## 	Librerias													##########
// ###################################################################################
using System.IO;
using SpaceDecoraciones;

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
			Decoraciones.Sangria(1);	// Añadimos la sangría
			Console.WriteLine($"Comprobando existencia del archivo: {NombreArchivo}");	// Mensaje de depuración
			ArchivoExiste = File.Exists(RutaCompleta);	// Comprobar si el archivo existe
			Decoraciones.Sangria(2);	// Añadimos la sangría
			Console.WriteLine($"¿Existe?: {ArchivoExiste}");	// Mensaje de depuración
			Console.WriteLine("\n");	// Mensaje de salto de línea
			return ArchivoExiste;	// Devolver el resultado de la comprobación
		}	

		// Leer archivo
		public static string ArchivoLeer(string NombreArchivo)
		{
			// Lógica para leer un archivo
			string RutaCompleta = Path.Combine(RutaArchivo, NombreArchivo);	// Construir la ruta completa del archivo
			string ContenidoArchivo = "";	// Variable para almacenar el contenido del archivo
			Decoraciones.Sangria(1);	// Añadimos la sangría
			Console.WriteLine($"Leyendo archivo: {NombreArchivo}");
			ContenidoArchivo = File.ReadAllText(RutaCompleta);	// Leer el contenido del archivo
			Decoraciones.Sangria(2);	// Añadimos la sangría
			Console.WriteLine("Contenido del archivo:");	// Mostrar el contenido del archivo
			//Decoraciones.Sangria(1);	// Añadimos la sangría
			Console.WriteLine("\n");	// Mensaje de salto de línea
			Console.WriteLine($"{ContenidoArchivo}");	// Mostrar el contenido del archivo
			Console.WriteLine("\n");	// Mensaje de salto de línea
			return ContenidoArchivo;	// Devolver el contenido del archivo
		}
	
		public static string StringSustituirSaltos(string TextoOriginal)
		{
			// Lógica para sustituir saltos de línea en un texto
			string TextoModificado = TextoOriginal.Replace("\r\n", "12345");	// Sustituir saltos de línea por espacios
			return TextoModificado;	// Devolver el texto modificado
		}
		}
	}
}