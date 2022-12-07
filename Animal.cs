using System;

class Animal{
    public void eat(){
        Console.WriteLine("\n************Todos los animales pueden comer************");
    }
}

class Kryptonian : Animal {}

class Supermam : Kryptonian{
    public void takeOff(){
        Console.WriteLine("Con la kryptonian no tiene superpoderes");
    }

    public void land(){
        Console.WriteLine("Puede planear");

    }

    public void fly(){
        Console.WriteLine("Puede volar");
    }

    public void leapBuilding(){
        Console.WriteLine("Puede saltar edificaciones");
    }

    public void stopBullet(){
        Console.WriteLine("Puede parar balas");
    }

    public void eat(){
        Console.WriteLine("Puede comer");
    }
}

class Bird : Animal {
    public void takeOff(){
        Console.WriteLine("Puede despegar");
    }

    public void land(){
        Console.WriteLine("Tiene tierra");
    }

    public void fly(){
        Console.WriteLine("Puede volar");
    }

    public void buildNest(){
        Console.WriteLine("Puede construir su nido");
    }

    public void layEggs(){
        Console.WriteLine("Puede poner huevos.");
    }   

    public void eat(){
        Console.WriteLine("Puede comer");
    } 
}

class testerClass{
    public static void Main(){
        Kryptonian UnAnimal = new Supermam();

        UnAnimal.eat();

       Supermam s = new Supermam();
       Console.WriteLine("\n************SUPERMAN************");
       s.takeOff();
       s.land();
       s.fly();
       s.leapBuilding();
       s.stopBullet();
       s.eat();

        Bird a = new Bird();
        Console.WriteLine("\n************PAJARO************");
        a.takeOff();
        a.land();
        a.fly();
        a.buildNest();
        a.layEggs();
        a.eat();
    }
}