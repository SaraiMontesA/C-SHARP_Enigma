// See https://aka.ms/new-console-template for more information

// ###################################################################################
// ########## 	Proyecto:		Enigma   									##########
// ########## 	Developer:		Sarai Montes								##########
// ########## 	Descripción:	Programa de cifrado y descifrado			##########
// ###################################################################################

// ###################################################################################
// ########## 	Librerias													##########
// ###################################################################################
using SpaceArchivos;
using SpaceCifrados;
using SpaceDecoraciones;

// ###################################################################################
// ########## 	Funcion principal											##########
// ###################################################################################

// Programa principal
static void ProgramaPrincipal()
{
	// ##############################################################
	// ##### Variables 											#####
	// ##############################################################
	bool Depuracion = false; // Modo producción o depuración
	string NombreArchivo = "OK.txt";	// Variable para almacenar el nombre del archivo
	bool ArchivoExiste = false;	// Variable para almacenar si el archivo existe
	string ContenidoArchivo = "";	// Variable para almacenar el contenido del archivo
	string ContenidoModificado = "";	// Variable para almacenar el contenido modificado
	
	//Aqui sabemos si estamos compilando en Depuración o en producción
	#if DEBUG
		Depuracion = true;
	#else
		Depuracion = false;
	#endif

	// Llamada a la cabecera
	Decoraciones.Cabecera();
	// Comprobar si el archivo existe
	ArchivoExiste = Archivos.ArchivoComprobar(Depuracion, NombreArchivo);
	
	if (ArchivoExiste)
	{	
		// Leer el archivo
		ContenidoArchivo = Archivos.ArchivoLeer(Depuracion, NombreArchivo);

		//Cifrar el contenido del archivo
		ContenidoModificado = Cifrados.CifrarArchivo(Depuracion, ContenidoArchivo);
		
		//Guardar el archivo modificado
		Archivos.ArchivoGuardar(Depuracion, "Cifrado_" + NombreArchivo, ContenidoModificado);

		//Descifrar el contenido del archivo
		ContenidoModificado = Cifrados.DescifrarArchivo(Depuracion, ContenidoArchivo);

	}

	// Llamada al pie del gato
	Decoraciones.PieGato();	
}



// Llamada al programa principal
ProgramaPrincipal();