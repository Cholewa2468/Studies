using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld2
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello, World 2!");
		
			string nazwa_grupy = string.Empty;
			while (nazwa_grupy == string.Empty)
			{
                Console.WriteLine("Podaj nazwe grupy:");
                nazwa_grupy = Console.ReadLine();
			}
			
			GrupaDydaktyczna gd = new GrupaDydaktyczna();
			gd.NazwaGrupy = nazwa_grupy;
			Console.WriteLine("Nazwa grupy: " + gd.NazwaGrupy);
			
			//Wykladowca wyk1 = new Wykladowca();
			//wyk1.imie = "Tomasz";
			//wyk1.nazwisko = "Zawadzki";
			//wyk1.stopien_naukowy = "dr inż";
			
			Wykladowca wyk1 = new Wykladowca("dr inz.", "Tomasz", "Zawadzki");
		  
		  //Stworzyc nowy, podobny, konstruktor w klasie Student i zmienic 
		  //sposob tworzenia obiektow typu student wykorzystujac 
		  //ten konstruktor oraz minimalizujac liczbe linii kodu programu
			
			/*
			Student stud1 = new Student();
			stud1.imie = "Maciej";
			stud1.nazwisko = "ALEKSANDROWICZ";
			stud1.nr_albumu = 36475;
			*/
			Student stud1 = new Student("Maciej", "Aleksandrowicz", 36475);
			/*
			Student stud2 = new Student();
			stud2.imie = "Konrad";
			stud2.nazwisko = "KUBIAK";
			stud2.nr_albumu = 35669;
			*/
			Student stud2 = new Student("Konrad", "Kubiak", 35669);
			/*
		    Student stud3 = new Student();
			stud3.imie = "Żaneta";
			stud3.nazwisko = "LUBIŃSKA";
			stud3.nr_albumu = 35900;
			*/
			Student stud3 = new Student("Zaneta", "Lubinska", 35900);
			/*
			Student stud4 = new Student();
			stud4.imie = "Krzysztof";
			stud4.nazwisko = "WRZESIEŃ";
			stud4.nr_albumu = 35678;
			*/
			Student stud4 = new Student("Krzysztof", "Wrzesien", 35678);
		    /*
			Console.WriteLine(stud1.nr_albumu + " " + stud1.imie + " " + stud1.nazwisko);
			Console.WriteLine(stud2.nr_albumu + " " + stud2.imie + " " + stud2.nazwisko);
			Console.WriteLine(stud3.nr_albumu + " " + stud3.imie + " " + stud3.nazwisko);
			Console.WriteLine(stud4.nr_albumu + " " + stud4.imie + " " + stud4.nazwisko);
			Console.WriteLine(wyk1.stopien_naukowy + " " + wyk1.imie + " " + wyk1.nazwisko);
			*/
			
			stud1.WyswietlDane();
			stud2.WyswietlDane();
			stud3.WyswietlDane();
			stud4.WyswietlDane();
			
			wyk1.WyswietlDane();
			
			Console.WriteLine("Linia 62");
			gd.Wykladowca = wyk1;
			Console.WriteLine("Linia 64");
			gd.DodajStudenta(stud1);
			gd.DodajStudenta(stud2);
			gd.DodajStudenta(stud3);
			gd.DodajStudenta(stud4);
			
			Console.WriteLine("Linia 66");
			try{
			    gd.WyswietlDane();
			}
			catch(Exception ex)
			{
			    Console.WriteLine(ex.Message);
			}
		}
	}
	
	public class Student : Osoba
	{
	  //public string imie;
	  //public string nazwisko;
	  private int nr_albumu;
	  
	  public Student(string imie, string nazwisko, int nr_albumu)
	  {
	    this.imie = imie;
	    this.nazwisko = nazwisko;
	    this.nr_albumu = nr_albumu;
	  }
	  public Student()
	  {
	      
	  }
	  public void WyswietlDane()
	  {
	       base.WyswietlDane();
	       Console.WriteLine(" | Numer albumu: "+nr_albumu);
	  }
	}
	  
	public class Wykladowca : Osoba
	{
	  //string imie;
	  //string nazwisko;
	  private string stopien_naukowy;
	  
	  public Wykladowca()
	  {
	    
	  }
	  
	  public Wykladowca(string stopien_naukowy, string imie, string nazwisko)
	  {
	    this.imie = imie;
	    this.nazwisko = nazwisko;
	    this.stopien_naukowy = stopien_naukowy;
	  }
	  public void WyswietlDane()
	  {
	      base.WyswietlDane();
	      Console.WriteLine(" | Stopien naukowy: "+stopien_naukowy);
	  }
	}
	
	public class Osoba
	{
	  protected string imie;
	  public string Imie
	    { 
	        get => char.ToUpper(imie[0]) + imie.Substring(1);
	        set => imie = value;
	    }
	  protected string nazwisko;
	  public string Nazwisko
	    { 
	        get => nazwisko.ToUpper(); 
	        set => nazwisko = value;
	    }
	  
	  public Osoba()
	  {
	    
	  }
	  public void WyswietlDane()
	  {
	      Console.Write(" Imie: "+ Imie + " | Nazwisko: "+Nazwisko);
	  }
	}
	
	class GrupaDydaktyczna
	{
	    private string nazwa_grupy;
	    public string NazwaGrupy
	    { 
	        get => nazwa_grupy; 
	        set => nazwa_grupy = value;
	    }
	    
	    private Wykladowca wykladowca;
	    public Wykladowca Wykladowca 
	    {
	        get => wykladowca; 
	        set=>wykladowca=value;
	    }
	    
	    private List<Student> studenci = new List<Student>(); 
	    
	    private void WyswietlNazweGrupy()
	    {
	        Console.WriteLine("Nazwa grupy: "+ this.NazwaGrupy);
	    }
	    
	    private void WyswietlWykladowce()
	    {
	        Console.WriteLine("--- Wykladowca: ---");
	        this.Wykladowca.WyswietlDane();    
	    }
	    
	    public void DodajStudenta(Student student)
	    {
	        //Console.WriteLine("Linia 124");
	        studenci.Add(student);
	        //Console.WriteLine("Linia 126");
	    }
	   public void WyswietlListeStudentow()
	    {
	        int i = 0;
	        foreach(Student s in studenci)
	        {
	            i++;
	            Console.WriteLine("--- Student nr "+i+": ---");
	            s.WyswietlDane();
	        }
	    }
	    
	    public void WyswietlDane()
	    {
	        this.WyswietlNazweGrupy();
	        this.WyswietlWykladowce();
	        this.WyswietlListeStudentow();
	    }
	}
}
