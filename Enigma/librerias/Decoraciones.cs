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
				Console.WriteLine("#########################################################################################");
				PausaCargas();
				Console.WriteLine("##########                                                                     ##########");
				PausaCargas();
				Console.WriteLine("##########               Bienvenido a Enigma	                               ##########");
				PausaCargas();
				Console.WriteLine("##########                                                                     ##########");
				PausaCargas();
				Console.WriteLine("#########################################################################################");
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
				Console.WriteLine("#########################################################################################");
				PausaCargas();
				Console.WriteLine("##########                                                                     ##########");
				PausaCargas();
				Console.WriteLine("##########               Muchas gracias por tu tiempo                          ##########");
				PausaCargas();
				Console.WriteLine("##########                                                                     ##########");
				PausaCargas();
				Console.WriteLine("##########              ¡Que tengas un día maravilloso!                   _    ##########");
				PausaCargas();
				Console.WriteLine("##########                                                     |\\__/,|   (`\\   ##########");
				PausaCargas();
				Console.WriteLine("##########                                                   _.|o o  |_   ) )  ##########");
				PausaCargas();
				Console.WriteLine("############################################################(((###(((####################");
				PausaCargas();
				Console.WriteLine("");
			}

		#endregion	
	}
}