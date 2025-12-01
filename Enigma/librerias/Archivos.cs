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
		public static bool ArchivoComprobar(bool Depuracion, string NombreArchivo)
		{
			// Lógica para comprobar si un archivo existe
			string RutaCompleta = Path.Combine(RutaArchivo, NombreArchivo);	// Construir la ruta completa del archivo
			bool ArchivoExiste = false;	// Variable para almacenar el resultado de la comprobación
			Decoraciones.Sangria(1);	// Añadimos la sangría
			Console.WriteLine($"Comprobando existencia del archivo: {NombreArchivo}");	// Mensaje de depuración
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
		public static string ArchivoLeer(bool Depuracion, string NombreArchivo)
		{
			// Lógica para leer un archivo
			string RutaCompleta = Path.Combine(RutaArchivo, NombreArchivo);	// Construir la ruta completa del archivo
			string ContenidoArchivo = "";	// Variable para almacenar el contenido del archivo
			Decoraciones.Sangria(1);	// Añadimos la sangría
			Console.WriteLine($"Leyendo archivo: {NombreArchivo}");
			Console.WriteLine("\n");	// Mensaje de salto de línea
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
	
		public static string StringSaltosSustituir(bool Depuracion, string TextoOriginal)
		{
			// Lógica para sustituir saltos de línea en un texto
			string TextoModificado = TextoOriginal.Replace("\r\n", "%");	// Sustituir saltos de línea por espacios
			Decoraciones.Sangria(1);	// Añadimos la sangría

			if (Depuracion)	// Mensajes de depuración
			{
				Console.WriteLine("Sustituyendo saltos de línea en el texto");
				Console.WriteLine($"{TextoModificado}");	// Mostrar el contenido del string
			}
			else	// Mensajes de producción
				Console.WriteLine("Saltos de línea sustituidos correctamente.");

			Console.WriteLine("\n");	// Mensaje de salto de línea
			return TextoModificado;	// Devolver el texto modificado
		}

		public static string StringSaltosRestaurar(bool Depuracion, string TextoModificado)
		{
			// Lógica para restaurar saltos de línea en un texto
			string TextoOriginal = TextoModificado.Replace("%", "\r\n");	// Restaurar saltos de línea
			Decoraciones.Sangria(1);	// Añadimos la sangría

			if (Depuracion)
			{
				Console.WriteLine("Restaurando saltos de línea en el texto");
				Console.WriteLine($"{TextoOriginal}");	// Mostrar el contenido del string
			}
			else
				Console.WriteLine("Saltos de línea restaurados correctamente.");

			Console.WriteLine("\n");	// Mensaje de salto de línea
			return TextoOriginal;	// Devolver el texto original
		}
	}
}