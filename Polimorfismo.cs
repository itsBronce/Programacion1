using System;

abstract class Animales{
    public void legs(){}
    public void walk(){}
    public abstract void comer();
}

class Spider : Animales{
    public void araña(){Console.WriteLine("\n*******CLASE SPIDER*******");}
    public void walk(){Console.WriteLine("Las arañas caminan");}
    public override void comer(){
        Console.WriteLine("Las arañas comen");
    }
}
interface Pet{
    void getName();
    void setName();
    void play();
}
class Cat : Animales, Pet{
    public void gato(){Console.WriteLine("\n*******CLASE CAT*******");}
    public void setName(){Console.WriteLine("El gato se llama Nicolax");}
    public void getName(){}
    public void play(){Console.WriteLine("El gato juega");}
    public void walk(){Console.WriteLine("El gato camina");}
    public override void comer(){
        Console.WriteLine("El gato come");
    }
}
class Fish : Animales, Pet{
    public void pez(){Console.WriteLine("\n*******CLASE FISH*******");}
    public void setName(){Console.WriteLine("El pez se llama Luciano");}
    public void getName(){}
    public void play(){Console.WriteLine("El pez juega");}
    public void walk(){Console.WriteLine("El pez nada");}
    public override void comer(){
        Console.WriteLine("El pez come");
    }
}

class PolimorfismoTest{
    static void Main(){
        Animales spider = new Spider();
        Spider arana = new Spider();
        arana.araña();
        arana.walk();
        spider.comer();
        

        Animales cat = new Cat();
        Cat catt = new Cat();
        Pet gato = new Cat();
        catt.gato();
        gato.setName();
        gato.play();
        catt.walk();
        cat.comer();
 
        Animales fish = new Fish();
        Fish fis = new Fish();
        Pet pez = new Fish();
        fis.pez();
        pez.setName();
        pez.play();
        fis.walk();
        fish.comer();
    }
}