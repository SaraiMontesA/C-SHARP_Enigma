// ###################################################################################
// ########## 	Proyecto:		Cifrados.cs									##########
// ########## 	Developer:		Sarai Montes								##########
// ########## 	Descripción:	Librería de cifrado de textos				##########
// ###################################################################################

// ###################################################################################
// ########## 	Librerias utilizadas										##########
// ###################################################################################
using System.IO;
using SpaceDecoraciones;

// ###################################################################################
// ########## 	Funciones relacionadas con archivos							##########
// ###################################################################################

namespace SpaceCifrados	// <-- Aquí declaramos el nombre del namespace
{

	public static class Cifrados     // <-- Aquí declaramos la clase
	{
		// ##############################################################
		// ##### Variables globales de Cifrados						#####
		// ##############################################################


		// ##############################################################
		// ##### Funciones de Cifrados								#####
		// ##############################################################

		public static string CifradosSaltosSustituir(bool Depuracion, string TextoOriginal)
		{
			//Variables
			// Lógica para sustituir saltos de línea en un texto
			string TextoModificado = TextoOriginal.Replace("\r\n", "%");	// Sustituir saltos de línea por espacios
			Decoraciones.Sangria(2);	// Añadimos la sangría

			if (Depuracion)	// Mensajes de depuración
			{
				Console.WriteLine("Sustituyendo saltos de línea en el texto");
				Console.WriteLine($"{TextoModificado}");	// Mostrar el contenido del string
			}
			else	// Mensajes de producción
				Console.WriteLine("Realizando paso 1. ");

			//Console.WriteLine("\n");	// Mensaje de salto de línea
			return TextoModificado;	// Devolver el texto modificado
		}

		public static string CifradosSaltosRestaurar(bool Depuracion, string TextoModificado)
		{
			//Variables
			// Lógica para restaurar saltos de línea en un texto
			string TextoOriginal = TextoModificado.Replace("%", "\r\n");	// Restaurar saltos de línea
			Decoraciones.Sangria(2);	// Añadimos la sangría

			if (Depuracion)
			{
				Console.WriteLine("Restaurando saltos de línea en el texto");
				Console.WriteLine($"{TextoOriginal}");	// Mostrar el contenido del string
			}
			else
				Console.WriteLine("Revirtiendo paso 1.");

			Console.WriteLine("\n");	// Mensaje de salto de línea
			return TextoOriginal;	// Devolver el texto original
		}
	
		public static string CifrarArchivo(bool Depuracion, string TextoOriginal)
		{
			// Variables
			string Texto = TextoOriginal;

			Decoraciones.Sangria(1);	// Añadimos la sangría
			Console.WriteLine("Cifrando el archivo...");		// Mensaje de cifrado

			//	Paso 1: Sustituir saltos de linea por %
			Texto = CifradosSaltosSustituir(Depuracion, Texto);

			// Devolvemos el resultado
			return Texto;
		}

		public static string DescifrarArchivo(bool Depuracion, string TextoCifrado)
		{
			// Variables
			string Texto = TextoCifrado;

			Decoraciones.Sangria(1);	// Añadimos la sangría
			Console.WriteLine("Descifrando el archivo...");		// Mensaje de descifrado

			//	Paso 1: Restaurar saltos de linea
			Texto = CifradosSaltosRestaurar(Depuracion, Texto);

			// Devolvemos el resultado
			return Texto;
		}
	}
}