using System;
class AireAcondicionado{
    private string marca;
    private string estado;
    private int temperatura = 0;
    private int velocidadFan = 0;
    public void setMarca(string marca){
        if (marca.Equals("SAMSUNG")|marca.Equals("HAIER")|marca.Equals("NEDOCA")){
            this.marca = marca;
        }else{
            Console.WriteLine("\nERROR: Las marcas soportadas son SAMSUNG, HAIER y NEDOCA");
            this.marca = null;
        }
    }
    public void setEstado(string estado){
        if (estado.Equals("Encendido")){
            temperatura = 17;
            velocidadFan = 1;
            Console.WriteLine("\n*********ESTADO DEL AIRE*********");
            Console.WriteLine("\nEl aire esta encendido!");
            Console.WriteLine("Temperatura: {0}", temperatura);
            Console.WriteLine("Velocidad de fan: {0}", velocidadFan);
            this.estado = estado;
        }else if(estado.Equals("Apagado")){
            Console.WriteLine("\nEl aire ya esta apagado!");
            this.estado = estado;
        }else{
            Console.WriteLine("\nERROR: Los unicos estados son Encendido y");
            this.estado = null;
        }
    }
    public void setSubirTemperatura(int temperatura){
        temperatura = temperatura + 1;
        Console.WriteLine("\nNueva temperatura: {0}", temperatura);
    }
    public void setBajarTemperatura(int temperatura){
        if (temperatura <= 0){
            Console.WriteLine("\nNo puedes bajar mas la termperatura");
        }else{
            temperatura = temperatura - 1;
        }
    }
    public void setSubirFan(int velocidadFan){
        if (velocidadFan <=1 && velocidadFan <= 3){
            velocidadFan = velocidadFan + 1;
        }else{
            Console.WriteLine("\nEl abanico del aire tiene solo cuatro velocidades");
        }
    }
    public void setBajarFan(int velocidadFan){
        if (velocidadFan <=2 && velocidadFan <= 4){
            velocidadFan = velocidadFan - 1;
        }
    }
    public string getMarca(){
        return this.marca;
    }
    public string getEstado(){
        return this.estado;
    }
    public int getSubirTemperatura(){
        temperatura = temperatura + 1;
        return this.temperatura;
    }
    public int getBajarTemperatura(){
        if (temperatura <= 0){
            Console.WriteLine("\nNo puedes bajar mas la termperatura");
        }else{
            temperatura = temperatura - 1;
        }
        return this.temperatura;
    }
    public int getSubirVelocidadFan(){
        if (velocidadFan >=1 && velocidadFan <= 3){
            velocidadFan = velocidadFan + 1;
        }else{
            Console.WriteLine("\nEl abanico del aire tiene solo cuatro velocidades");
        }
        return this.velocidadFan;
    }
     public int getBajarVelocidadFan(){
        if (velocidadFan >=2 && velocidadFan <= 4){
            velocidadFan = velocidadFan - 1;
        }else{
            Console.WriteLine("\nEl abanico del aire esta en lo minimo!");
        }
        return this.velocidadFan;
    }
    public void subirTemp(){
        Console.WriteLine("\n*********TEMPERATURA*********");
        Console.WriteLine("\nNueva temperatura: " + getSubirTemperatura());
    }
    public void bajarTemp(){
        Console.WriteLine("\n*********TEMPERATURA*********");
        Console.WriteLine("\nNueva temperatura: " + getBajarTemperatura());
    }
    public void subirFan(){
        Console.WriteLine("\n*********FAN*********");
        Console.WriteLine("\nNueva velocidad de fan: " + getSubirVelocidadFan());
    }
    public void bajarFan(){
        Console.WriteLine("\n*********FAN*********");
        Console.WriteLine("\nNueva velocidad de fan: " + getBajarVelocidadFan());
    }
    public void Apagar(){
        Console.WriteLine("\nEl aire se puso en Stand-by!");
    }
    public void datos(){
        Console.WriteLine("\n*********DATOS*********");
        Console.WriteLine("Marca: " + getMarca());
        Console.WriteLine("Estado: " + getEstado());
        Console.WriteLine("Temperatura: " + temperatura);
        Console.WriteLine("Velocidad del fan: " + velocidadFan);
    }
}

class TesterClass{
    public static void Main(){
        string marca, estado;
        int op; 
        Console.WriteLine("\n*********AIRE ACONDICIONADO*********");
        Console.Write("\nMarca(SAMSUNG, HAIER o NEDOCA): "); marca = Console.ReadLine();
        Console.Write("Estado(Encendido o Apagado): "); estado = Console.ReadLine();
        AireAcondicionado  miAire = new AireAcondicionado ();
        miAire.setMarca (marca);
        miAire.setEstado (estado);
        inicio:
        Console.WriteLine("\n*********AIRE ACONDICIONADO*********");
        Console.WriteLine("\nQue desea hacer?");
        Console.WriteLine("1. Subir temperatura");
        Console.WriteLine("2. Bajar Temperatura");
        Console.WriteLine("3. Subir velocidad del fan");
        Console.WriteLine("4. Bajar temperatura del fan");
        Console.WriteLine("5. Apagar aire");
        Console.WriteLine("6. Ver datos");
        Console.Write("\nOpcion: "); op = int.Parse(Console.ReadLine());
        
        switch(op){
            case 1:
                miAire.subirTemp();
                goto inicio;
            case 2:
                miAire.bajarTemp();
                goto inicio;
            case 3:
                miAire.subirFan();
                goto inicio;
            case 4:
                miAire.bajarFan();
                goto inicio;
            case 5:
                miAire.Apagar();
            break;
            case 6:
                miAire.datos();
                goto inicio;
            default:
                Console.WriteLine("\nSolo son 6 opciones!"); goto inicio;
        }
    }
}