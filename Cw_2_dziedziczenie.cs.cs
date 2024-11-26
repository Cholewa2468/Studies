// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public class Osoba
    {
        //private string imie;
        protected string imie;
        //private string nazwisko;
        protected string nazwisko;
        
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
        
        public Osoba()
        {
            this.imie = "";
            this.nazwisko = "";
        }
        
        public Osoba(string imie, string nazwisko)
        {
            UstawImie(imie);
            UstawNazwisko(nazwisko);
        }
    }
    
    public class Student : Osoba
    {
        public Student()
        {
            imie = "Tomasz";
            nazwisko = "Zawadzki";
        }
        
        public Student(string imie, string nazwisko) : base (imie, nazwisko)
        {
            //UstawImie(imie);
            //UstawNazwisko(nazwisko);
        }
    }
    
    public class Pracownik : Osoba
    {
        private int wiek;
        
        public Pracownik()
        {
            imie = "Robert";
            nazwisko = "Jankowski";
        }
        
        public Pracownik(string imie, string nazwisko) : base (imie, nazwisko)
        {
            //UstawImie(imie);
            //UstawNazwisko(nazwisko);
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
        
        
        //Console.WriteLine(prac.imie);
        Console.WriteLine(prac.PobierzImie());
        Console.WriteLine(prac.PobierzNazwisko());
        
        Student stud2 = new Student();
        //stud2.imie = ("Anna");
        //stud2.imie = stud2.UstawImie("Anna");
        stud2.UstawImie("Anna");
        //stud2.nazwisko = "Jagoda";
        stud2.UstawNazwisko("Jagoda");
        //Console.WriteLine(stud2.imie);
        Console.WriteLine(stud2.PobierzImie());
        Console.WriteLine(stud2.PobierzNazwisko());
        
        Student stud3 = new Student("Jacek","Misiak");
        Pracownik prac3 = new Pracownik("Hubert","Wackowski");
        
        Console.WriteLine(stud3.PobierzImie());
        Console.WriteLine(stud3.PobierzNazwisko());
        
        Console.WriteLine(prac3.PobierzImie());
        Console.WriteLine(prac3.PobierzNazwisko());
        
         //Student stud4 = new Osoba("Jacek","Misiak");
         //Console.WriteLine(stud4.PobierzImie());
         
        //Console.WriteLine ("Hello Mono World");
        //Console.ReadLine();
    }
}