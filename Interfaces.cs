using System;

class Animal{
    public void eat(){
        Console.WriteLine("Los animales pueden comer");
    }
}

interface Flyer{
    void takeOff();
    void land();
    void fly();
}

class Vehicle{}

class Airplane : Vehicle, Flyer{
    public void takeOff(){
        Console.WriteLine("Los aviones pueden despegar");
    }

    public void land(){
        Console.WriteLine("Los aviones pueden aterrizar");
    }

    public void fly(){
        Console.WriteLine("Los aviones pueden volar");
    }
}

class SeaPlane : Airplane{}

class Helicopter : Airplane{}

class Bird : Flyer{
    public void takeOff(){
        Console.WriteLine("Los pajaros pueden despegar");
    }

    public void land(){
        Console.WriteLine("Los pajaros pueden aterrizar");
    }

    public void fly(){
        Console.WriteLine("Los pajaros pueden volar");
    }

    public void buildNest(){
        Console.WriteLine("Los pajaros pueden construir su nido");
    }

    public void layEggs(){
        Console.WriteLine("Los pajaros pueden poner huevos");
    }

    public void eat(){
        Console.WriteLine("Los pajaros pueden comer");
    }
}

class Kryptonian : Animal{}

class Superman : Kryptonian, Flyer{
    public void takeOff(){
        Console.WriteLine("Superman puede despegar");
    }

    public void land(){
        Console.WriteLine("Superman puede aterrizar");
    }

    public void leapBuilding(){
        Console.WriteLine("Superman puede saltar edificaciones");
    }

    public void stopBullet(){
        Console.WriteLine("Superman puede parar balas");
    }

    public void fly(){
        Console.WriteLine("Superman puede volar");
    }

    public void eat(){
        Console.WriteLine("Superman puede comer\n");
    }
}

class ClaseTester{
    public static void Main(){
        Console.WriteLine("\n*********CLASE ANIMAL*********");
        Animal animal = new Animal();
        animal.eat();

        Console.WriteLine("\n*********CLASE AIRPLANE*********");
        Airplane airplane = new Airplane();
        airplane.takeOff();
        airplane.land();
        airplane.fly();

        Console.WriteLine("\n*********CLASE BIRD*********");
        Bird bird = new Bird();
        bird.takeOff();
        bird.land();
        bird.fly();
        bird.buildNest();
        bird.layEggs();
        bird.eat();

        Console.WriteLine("\n*********CLASE SUPERMAN*********");
        Superman superman = new Superman();
        superman.takeOff();
        superman.land();
        superman.fly();
        superman.leapBuilding();
        superman.stopBullet();
        superman.eat();
    }
}