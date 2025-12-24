// ###################################################################################
// ########## 	Proyecto:		Decoraciones.cs								##########
// ########## 	Developer:		Sarai Montes								##########
// ########## 	Descripción:	Libreria de decoraciones					##########
// ###################################################################################

// ###################################################################################
// ########## 	Librerias utilizadas										##########
// ###################################################################################

// ###################################################################################
// ########## 	Funciones de cabecera, sangría y pie						##########
// ###################################################################################

namespace SpaceDecoraciones	// <-- Aquí declaramos el nombre del namespace
{
	public static class Decoraciones     // <-- Aquí declaramos la clase
	{
		// ##############################################################
		// ##### Variables globales de Decoraciones 				#####
		// ##############################################################


		// ##############################################################
		// ##### Funciones de Decoraciones							#####
		// ##############################################################

		#region Cabeceras
			public static void PausaCargas()
			{
				int tiempo = 400;
				System.Threading.Thread.Sleep(tiempo);	// Bloquea el hilo actual durante 500 milisegundos
			}

			public static void Cabecera()
			{
				Console.Clear();	// Con esta línea limpiamos la pantalla
				// Escribir texto en color azul
				Console.ForegroundColor = ConsoleColor.Blue;
				Console.WriteLine("#########################################################################################");
				PausaCargas();
				Console.WriteLine("##########                                                                     ##########");
				PausaCargas();
				Console.Write("##########               ");
				// Escribir texto en color verde
				Console.ForegroundColor = ConsoleColor.Green;
				Console.Write("Bienvenido a Enigma");
				// Escribir texto en color azul
				Console.ForegroundColor = ConsoleColor.Blue;
				Console.WriteLine("	                               ##########");
				PausaCargas();
				Console.WriteLine("##########                                                                     ##########");
				PausaCargas();
				Console.WriteLine("#########################################################################################");
				Console.ResetColor();
				PausaCargas();
				Console.WriteLine("");
			}

			public static void CabeceraRapida()
			{
				Console.Clear();	// Con esta línea limpiamos la pantalla
				Console.WriteLine("#########################################################################################");
				Console.WriteLine("##########                                                                     ##########");
				Console.WriteLine("##########               Bienvenido a Enigma                                   ##########");
				Console.WriteLine("##########                                                                     ##########");
				Console.WriteLine("#########################################################################################");
				Console.WriteLine("");
			}

			public static void Sangria(int sencilla)
			{
				if (sencilla == 1)
					Console.Write("     ");

				if (sencilla == 2)
					Console.Write("          ");
			}

			public static void PieGato()
			{
				Console.WriteLine("");				
				Console.ForegroundColor = ConsoleColor.DarkBlue;	// Escribir texto en color azul
				Console.WriteLine("#########################################################################################");
				PausaCargas();
				Console.WriteLine("##########                                                                     ##########");
				PausaCargas();
				Console.Write("##########               ");
				Console.ForegroundColor = ConsoleColor.Green;
				Console.Write("Muchas gracias por tu tiempo");
				// Escribir texto en color azul
				Console.ForegroundColor = ConsoleColor.DarkBlue;
				Console.WriteLine("                          ##########");
				PausaCargas();
				Console.WriteLine("##########                                                                     ##########");
				PausaCargas();
				Console.Write("##########              ");				
				Console.ForegroundColor = ConsoleColor.Green;	// Escribir texto en color verde
				Console.Write("¡Que tengas un día maravilloso!");

				// Gato línea 1
				Console.ForegroundColor = ConsoleColor.DarkBlue;	// Escribir texto en color azul
				Console.Write("                   ");
				Console.ForegroundColor = ConsoleColor.Yellow;	// Escribir texto en color amarillo
				Console.Write("_");
				Console.ForegroundColor = ConsoleColor.DarkBlue;	// Escribir texto en color azul
				Console.WriteLine("    ##########");
				PausaCargas();

				// Gato línea 2
				Console.ForegroundColor = ConsoleColor.DarkBlue;	// Escribir texto en color azul
				Console.Write("##########                                                     ");
				Console.ForegroundColor = ConsoleColor.Yellow;	// Escribir texto en color amarillo
				Console.Write("|\\__/,|   (`\\");
				Console.ForegroundColor = ConsoleColor.DarkBlue;	// Escribir texto en color azul
				Console.WriteLine("   ##########");
				PausaCargas();

				// Gato línea 3
				Console.ForegroundColor = ConsoleColor.DarkBlue;	// Escribir texto en color azul
				Console.Write("##########                                                   ");
				Console.ForegroundColor = ConsoleColor.Yellow;	// Escribir texto en color amarillo   
				Console.Write("_.|o o  |_   ) )");
				Console.ForegroundColor = ConsoleColor.DarkBlue;	// Escribir texto en color azul
				Console.WriteLine("  ##########");
				PausaCargas();
				// Gato línea 4
				Console.ForegroundColor = ConsoleColor.DarkBlue;	// Escribir texto en color azul
				Console.Write("############################################################");
				Console.ForegroundColor = ConsoleColor.Yellow;	// Escribir texto en color amarillo
				Console.Write("(((");
				Console.ForegroundColor = ConsoleColor.DarkBlue;	// Escribir texto en color azul
				Console.Write("###");
				Console.ForegroundColor = ConsoleColor.Yellow;	// Escribir texto en color amarillo
				Console.Write("(((");
				Console.ForegroundColor = ConsoleColor.DarkBlue;	// Escribir texto en color azul
				Console.WriteLine("####################");
				Console.ResetColor();
				PausaCargas();
				Console.WriteLine("");
			}

		#endregion	
	}
}