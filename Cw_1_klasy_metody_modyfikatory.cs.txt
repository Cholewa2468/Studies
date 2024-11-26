// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public class Student 
    {
        private string imie;
        private string nazwisko;
        
        public string Imie
        {
            get => this.imie;
            set => this.imie = value;
        }
        
        public string Nazwisko
        {
            get => this.nazwisko;
            set => this.nazwisko = value;
        }
        
        public void UstawImie(string imie) //Set
        {
            this.imie = imie;    
        }
        
        public string PobierzImie() //Get
        {
            return this.imie;
        }
        
        public void UstawNazwisko(string nazwisko) //Set
        {
            this.nazwisko = nazwisko;    
        }
        
        public string PobierzNazwisko() //Get
        {
            return this.nazwisko;
        }
        
        public Student()
        {
            imie = "Tomasz";
            nazwisko = "Zawadzki";
        }
    }
    
    public class Pracownik 
    {
        public string imie;
        public string nazwisko;
        public int wiek;
        
        public Pracownik()
        {
            imie = "Robert";
            nazwisko = "Jankowski";
        }
    }
    public static void Main(string[] args)
    {
        Pracownik prac = new Pracownik();
        Student stud = new Student();
        //Console.WriteLine(stud.imie);
        Console.WriteLine(stud.PobierzImie());
        Console.WriteLine(stud.PobierzNazwisko());
        Console.WriteLine(stud.Imie);
        Console.WriteLine(stud.Nazwisko);
        
        
        Console.WriteLine(prac.imie);
        Console.WriteLine(prac.nazwisko);
        
        Student stud2 = new Student();
        //stud2.imie = ("Anna");
        //stud2.imie = stud2.UstawImie("Anna");
        stud2.UstawImie("Anna");
        //stud2.nazwisko = "Jagoda";
        stud2.UstawNazwisko("Jagoda");
        //Console.WriteLine(stud2.imie);
        Console.WriteLine(stud2.PobierzImie());
        Console.WriteLine(stud2.PobierzNazwisko());
        
        //Console.WriteLine ("Hello Mono World");
        //Console.ReadLine();
    }
}