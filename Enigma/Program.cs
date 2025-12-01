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
		string NombreArchivo = "OK.txt";	// Variable para almacenar el nombre del archivo
		string ContenidoArchivo = "";	// Variable para almacenar el contenido del archivo
		// Llamada a la cabecera
		Decoraciones.Cabecera();
		// Comprobar si el archivo existe
		Archivos.ArchivoComprobar(NombreArchivo);
		// Leer el archivo
		ContenidoArchivo = Archivos.ArchivoLeer(NombreArchivo);

		//Sustituir Saltos de linea
		ContenidoArchivo = Archivos.StringSaltosSustituir(ContenidoArchivo);
		ContenidoArchivo = Archivos.StringSaltosRestaurar(ContenidoArchivo);

		// TODO cifrar/descifrar contenido
		// TODO guardar archivo cifrado/descifrado
		// TODO Cerrar al archivo original
		Decoraciones.PieGato();
		
	}
#endregion


// Llamada al programa principal
ProgramaPrincipal();