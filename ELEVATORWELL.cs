using System;
class ELEVATORWELL{
    
    private string marca;
    private string estado;
    private int cantidadPiso;
    private int piso;

    public void setMarca(string marca){
        if (marca.Equals("ELEVATORWELL")){
            this.marca = marca;
        }else{
            Console.WriteLine("\nERROR: La unica marca es ELEVATORWELL");
            this.marca = null;   
        }
    }
    public string getMarca(){
        return this.marca;
    }

    public void setEstado(string estado){
        if(estado.Equals("Encendido")){
            this.estado = estado;
        }else if (estado.Equals("Apagado")){
            Console.WriteLine("\nERROR: Si esta apagado no puede utilizar el elevador!");
            this.estado = null;
        }else{
            Console.WriteLine("\nERROR: Los estados del elevador son Encendido y Apagado");
            this.estado = null;
        }
    }

    public string getEstado(){
        return this.estado;
    }

    public void setCantidadPiso(int cantidadPiso){
        if(cantidadPiso >= 1 || cantidadPiso <= 8){
            this.cantidadPiso = cantidadPiso;
        }else{
            Console.WriteLine("\nERROR: El ascensor va desde el 1er hasta el 8vo piso");
        }
    }

    public int getCantidadPiso(){
        return this.cantidadPiso;
    }

    public void setPiso(int piso){
        if(piso >=1 && piso <=8){
            this.piso = piso;
        }else{
            Console.WriteLine("\nERROR: La cantidad de piso va desde el 1er hasta el 8vo piso!");
        }
    }
    public int getPiso(){
        return this.piso;
    }

    public void desplegarInformacion(){
        Console.WriteLine("\n*********Salida*********");
        Console.WriteLine("\nMarca: " + getMarca());
        Console.WriteLine("Estado del ascensor: " + getEstado());
        Console.WriteLine("Cantidad de pisos: " + getCantidadPiso());
        Console.WriteLine("Piso: " + getPiso());
    }    
}

class ELEVATORWELL_Test{
    public static void Main(){
        string marca, estado;
        int CantidadPisos, piso;
        
        Console.WriteLine("\nBienvenido a ELEVATORWELL. Póngase cómodo y seleccione un piso hacia donde quiere ir");
        Console.Write("Marca: "); marca = Console.ReadLine();
        Console.Write("Estado: Encendido/Apagado "); estado = Console.ReadLine();
        Console.Write("Cantidad de pisos: "); CantidadPisos = int.Parse(Console.ReadLine());
        Console.Write("Piso al que va: "); piso = int.Parse(Console.ReadLine());

        ELEVATORWELL miELEVATORWELL = new ELEVATORWELL();
        miELEVATORWELL.setMarca (marca);
        miELEVATORWELL.setEstado (estado);
        miELEVATORWELL.setCantidadPiso(CantidadPisos);
        miELEVATORWELL.setPiso(piso);

        miELEVATORWELL.desplegarInformacion();    
    }
}