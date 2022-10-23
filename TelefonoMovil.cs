using System;
class TelefonoMovil{

/* 

Atributos de clase.

Debajo se encuentran las definiciones de los atributos de la clase TelefonoMovil.
Realice los cambios en los atributos y metodos que sean necesarios para encapsular
la clase TelefonoMovil.

Nombre: Nicolax Junior Luciano Blanco              Matricula: 100589315       INF512-202220-SE12
  
*/

    private string marca;
    private string color;
    private string modelo;
    private float cantidadCamaras;
    private double size;
    private string estado;
/* 

Metodos de acceso: getters y setters.

En este espacio defina los metodos get y set que sean necesarios para 
encapsular la clase TelefonoMovil.
  
*/

    public bool marcar(){
        return true;
    }

    public bool llamar(string numeroTelefonoDestino){
        return true;
    }

    public void vibrar(){

    }

    public bool encender(){
        return true;
    }

    public bool apagar(){
        return true;
    }
    public void setMarca(string marca){
        this.marca = marca;
    }
    public void setModelo(string modelo){
        this.modelo = modelo;
    }
    public void setCantidadCamaras(float cantidadCamaras){
        if(cantidadCamaras <= 8){
            this.cantidadCamaras = cantidadCamaras;
        }else{
            Console.WriteLine("Cantidad maxima de camaras es 8");
        }
    }
    public void setSize(double size){
        if(size <= 7){
            this.size = size;
        }else{
            Console.WriteLine("El tamaño del teléfono móvil no puede exceder 7 pulgadas");
        }
    }
    public void setEstado(string estado){
       if (estado.Equals("Encendido") || estado.Equals("Suspendido") || estado.Equals("Apagado")){
            this.estado = estado;
        }else{
            Console.WriteLine("Los estados de un teléfono móvil son: encendido, suspendido y apagado.");
            this.estado = null;
        }
    }
    public void setColor(string color){
       if (color.Equals("Blanco")){
            this.color = color;
        }else{
            Console.WriteLine("Una condición única adicional: solo puede ser de color Blanco");
            this.color = null;
        }
    }
    public string getMarca(){
        return this.marca;
    }
    public string getModelo(){
        return this.modelo;
    }
    public float getCantidadCamaras(){
        return this.cantidadCamaras;
    }
    public double getSize(){
        return this.size;
    }
    public string getEstado(){
        return this.estado;
    }
    public string getColor(){
        return this.color;
    }
    public void desplegarInformacion(){
        Console.WriteLine("MARCA: " + getMarca());
        Console.WriteLine("COLOR: " + getColor());
        Console.WriteLine("MODELO: " + getModelo());
        Console.WriteLine("CANTIDAD DE CAMARAS: " + getCantidadCamaras());
        Console.WriteLine("PULGADAS: " + getSize());
        Console.WriteLine("ESTADO DEL TELEÉFONO: " + getEstado());
        
    }
}

class TelefonoMovilTest{
    public static void Main(){
        TelefonoMovil miCelular = new TelefonoMovil();
        miCelular.setMarca ("Iphone");
        miCelular.setColor ("Blanco");
        miCelular.setModelo ("X");
        miCelular.setCantidadCamaras (2);
        miCelular.setSize (5.85);
        miCelular.setEstado ("Encendido");
        
        Console.WriteLine("\n*** Salida ***\n");
        miCelular.desplegarInformacion();    
    }
}
