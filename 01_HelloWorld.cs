using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");
			
			//Wykladowca wyk1 = new Wykladowca();
			//wyk1.imie = "Tomasz";
			//wyk1.nazwisko = "Zawadzki";
			//wyk1.stopien_naukowy = "dr inż";
			
			Wykladowca wyk1 = new Wykladowca("dr inż.", "Tomasz", "Zawadzki");
		  
		  //Stworzyc nowy, podobny, konstruktor w klasie Student i zmienic 
		  //sposob tworzenia obiektow typu student wykorzystujac 
		  //ten konstruktor oraz minimalizujac liczbe linii kodu programu
			
			Student stud1 = new Student();
			stud1.imie = "Maciej";
			stud1.nazwisko = "ALEKSANDROWICZ";
			stud1.nr_albumu = 36475;
			
			Student stud2 = new Student();
			stud2.imie = "Konrad";
			stud2.nazwisko = "KUBIAK";
			stud2.nr_albumu = 35669;
			
		  Student stud3 = new Student();
			stud3.imie = "Żaneta";
			stud3.nazwisko = "LUBIŃSKA";
			stud3.nr_albumu = 35900;
			
			Student stud4 = new Student();
			stud4.imie = "Krzysztof";
			stud4.nazwisko = "WRZESIEŃ";
			stud4.nr_albumu = 35678;
			
		
			Console.WriteLine(stud1.nr_albumu + " " + stud1.imie + " " + stud1.nazwisko);
			Console.WriteLine(stud2.nr_albumu + " " + stud2.imie + " " + stud2.nazwisko);
			Console.WriteLine(stud3.nr_albumu + " " + stud3.imie + " " + stud3.nazwisko);
			Console.WriteLine(stud4.nr_albumu + " " + stud4.imie + " " + stud4.nazwisko);
			Console.WriteLine(wyk1.stopien_naukowy + " " + wyk1.imie + " " + wyk1.nazwisko);
		}
	}
	
	public class Student : Osoba
	{
	  //public string imie;
	  //public string nazwisko;
	  public int nr_albumu;
	  
	  public Student()
	  {
	    
	  }
	}
	  
	public class Wykladowca : Osoba
	{
	  //string imie;
	  //string nazwisko;
	  public string stopien_naukowy;
	  
	  public Wykladowca()
	  {
	    
	  }
	  
	  public Wykladowca(string stopien_naukowy, string imie, string nazwisko)
	  {
	    this.imie = imie;
	    this.nazwisko = nazwisko;
	    this.stopien_naukowy = stopien_naukowy;
	  }
	}
	
	public class Osoba
	{
	  public string imie;
	  public string nazwisko;
	  
	  public Osoba()
	  {
	    
	  }
	}
}