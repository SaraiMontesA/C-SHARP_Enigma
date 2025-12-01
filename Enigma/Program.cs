// See https://aka.ms/new-console-template for more information

// ###################################################################################
// ########## 	Proyecto:		Enigma   									##########
// ########## 	Developer:		Sarai Montes								##########
// ########## 	Descripción:	Programa de cifrado y descifrado			##########
// ###################################################################################

// ###################################################################################
// ########## 	Librerias													##########
// ###################################################################################
using SpaceDecoraciones;
using SpaceArchivos;

// ###################################################################################
// ########## 	Funcion principal											##########
// ###################################################################################
#region ProgramaPrincipal
	// Programa principal
	static void ProgramaPrincipal()
	{
		// Llamada a la cabecera
		Decoraciones.Cabecera();
		Archivos.ArchivoComprobar("OK.txt");
		// TODO abrir archivo
		// TODO leer archivo
		// TODO cifrar/descifrar contenido
		// TODO guardar archivo cifrado/descifrado
		// TODO Cerrar al archivo original
		Decoraciones.PieGato();
		
	}
#endregion


// Llamada al programa principal
ProgramaPrincipal();