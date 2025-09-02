xusing System;

public class MainClass{
    
    public static void Main(string[] args){
        
        Dog dog = new Dog();
        Cat cat = new Cat();
        
        dog.Speak();
        cat.Speak();
    }
    
    

}
public class Animal{
    
    public virtual void Speak(){
        Console.WriteLine("Animal Makes Sound");
    }
    
}

public class Dog:Animal{
    
    public override void Speak(){
        Console.WriteLine("Dog goes woof");
    }

}


public class Cat:Animal{
    public override void Speak(){
        Console.WriteLine("Cat makes meow ");
    }
   
}