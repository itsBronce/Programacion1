using System;
class ELEVATORWELL{
    public static void Main(){
        int opc, piso;
        string d;
        inicio:
        Console.WriteLine("\nSelecione una opcion: 1)dia 2)noche ");
        Console.Write("Opcion: "); opc = int.Parse(Console.ReadLine());
        switch (opc)
        {
            case 1: 
                Console.WriteLine("\nBienvenido a ELEVATORWELL. Póngase cómodo y seleccione un piso hacia donde quiere ir");
                ascensor:
                Console.Write("Piso: "); piso = int.Parse(Console.ReadLine());
                if(piso >= 1 && piso <= 8){
                    Console.WriteLine("\n********Dirigiendose a su destino********");
                    Console.WriteLine("Ha llegado a su destino, piso: " + piso);
                    Console.Write("\nEl elevador esta en el piso " + piso + ", desea ir a otro destino? si/no "); d = Console.ReadLine();
                    if(d == "si"){
                        goto ascensor;
                    }else{
                        Console.WriteLine("\nPrograma finalizado!");
                    }
                }else{
                    Console.WriteLine("Los pisos van desde el 1er hasta el 8vo!\n");
                    goto ascensor;
                }
                
                break;
            case 2:
                Console.WriteLine("En las noches esta apagado");
                break;
            default:
                Console.WriteLine("Las opciones son 1 y 2!");
                goto inicio;
    }
    }
}