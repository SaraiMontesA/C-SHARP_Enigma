// ###################################################################################
// ########## 	Proyecto:		Archivos.cs									##########
// ########## 	Developer:		Sarai Montes								##########
// ########## 	Descripción:	Librería de manejo de archivos				##########
// ###################################################################################

// ###################################################################################
// ########## 	Librerias utilizadas										##########
// ###################################################################################
using System.IO;
using SpaceDecoraciones;

// ###################################################################################
// ########## 	Funciones relacionadas con archivos							##########
// ###################################################################################

namespace SpaceArchivos	// <-- Aquí declaramos el nombre del namespace
{	
	public static class Archivos     // <-- Aquí declaramos la clase
	{
		// ##############################################################
		// ##### Variables globales de Archivos						#####
		// ##############################################################
		static string RutaArchivo = "archivos/";
		
		// ##############################################################
		// ##### Funciones de Archivos								#####
		// ##############################################################
		
		// Comprobar que archivo existe
		public static bool ArchivoComprobar(bool Depuracion, string NombreArchivo, string Extension)
		{
			//Variables
			string RutaCompleta = Path.Combine(RutaArchivo, (NombreArchivo + Extension));	// Construir la ruta completa del archivo
			bool ArchivoExiste = false;	// Variable para almacenar el resultado de la comprobación
			
			// Lógica para comprobar si un archivo existe
			Decoraciones.Sangria(1);	// Añadimos la sangría
			Console.WriteLine($"Comprobando existencia del archivo: {NombreArchivo+Extension}");	// Mensaje de depuración
			ArchivoExiste = File.Exists(RutaCompleta);	// Comprobar si el archivo existe
			Decoraciones.Sangria(2);	// Añadimos la sangría

			if (Depuracion)	// Mensajes de depuración
				Console.WriteLine($"¿Existe?: {ArchivoExiste}");
			else	// Mensajes de producción
				if (ArchivoExiste)
					Console.WriteLine("El archivo existe");	
				else
					Console.WriteLine("El archivo no existe");	
			
			Console.WriteLine("\n");	// Mensaje de salto de línea
			return ArchivoExiste;	// Devolver el resultado de la comprobación
		}	

		// Leer archivo
		public static string ArchivoLeer(bool Depuracion, string NombreArchivo, string Extension)
		{
			//Variables
			string RutaCompleta = Path.Combine(RutaArchivo, (NombreArchivo + Extension));	// Construir la ruta completa del archivo
			string ContenidoArchivo = "";	// Variable para almacenar el contenido del archivo

			// Lógica para leer un archivo
			ContenidoArchivo = File.ReadAllText(RutaCompleta);	// Leer el contenido del archivo			
			Decoraciones.Sangria(1);	// Añadimos la sangría

			if (Depuracion)	// Mensajes de depuración
			{
				Console.WriteLine("Contenido del archivo:");	// Mostrar el contenido del archivo
				Console.WriteLine($"{ContenidoArchivo}");	// Mostrar el contenido del archivo
			}
			else	// Mensajes de producción
				Console.WriteLine("Archivo leído correctamente.");

			Console.WriteLine("\n");	// Mensaje de salto de línea
			return ContenidoArchivo;	// Devolver el contenido del archivo
		}
	
		// Crear archivo
		public static void ArchivoCifradoGuardar(bool Depuracion, string NombreArchivo, string Extension, string ContenidoArchivo)
		{
			//Variables
			string RutaCompleta = Path.Combine(RutaArchivo, (NombreArchivo + Extension));	// Construir la ruta completa del archivo

			// Lógica para crear un archivo
			File.WriteAllText(RutaCompleta, ContenidoArchivo);	// Crear el archivo con el contenido proporcionado
			Decoraciones.Sangria(1);	// Añadimos la sangría

			if (Depuracion)	// Mensajes de depuración
				Console.WriteLine($"Archivo {NombreArchivo} creado con el siguiente contenido:\n{ContenidoArchivo}");
			else	// Mensajes de producción
				Console.WriteLine("Archivo creado correctamente.");

			Console.WriteLine("\n");	// Mensaje de salto de línea
		}
	}
}