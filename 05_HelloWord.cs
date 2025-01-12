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
			//Console.WriteLine("Nazwa grupy: " + gd.NazwaGrupy);
			
			//Wykladowca wyk1 = new Wykladowca();
			//wyk1.imie = "Tomasz";
			//wyk1.nazwisko = "Zawadzki";
			//wyk1.stopien_naukowy = "dr inż";
			
			Wykladowca wyk1 = new Wykladowca("dr", "Tomasz", "Zawadzki");
		  
		  //Stworzyc nowy, podobny, konstruktor w klasie Student i zmienic 
		  //sposob tworzenia obiektow typu student wykorzystujac 
		  //ten konstruktor oraz minimalizujac liczbe linii kodu programu
			
			/*Student stud1 = new Student();
			stud1.imie = "Maciej";
			stud1.nazwisko = "ALEKSANDROWICZ";
			stud1.nr_albumu = 36475;*/
			
			Student stud1 = new Student("Maciej", "ALEKSANDROWICZ", 36475);
			
			/*Student stud2 = new Student();
			stud2.imie = "Konrad";
			stud2.nazwisko = "KUBIAK";
			stud2.nr_albumu = 35669;*/
			
			Student stud2 = new Student("Konrad", "KUBIAK", 35669);
			
		    /*Student stud3 = new Student();
			stud3.imie = "Wiktoria";
			stud3.nazwisko = "JADCZAK";
			stud3.nr_albumu = 35900;*/
			
			Student stud3 = new Student("Wiktoria", "JADCZAK", 35900);
			
			/*Student stud4 = new Student();
			stud4.imie = "Krzysztof";
			stud4.nazwisko = "OLEJNIK";
			stud4.nr_albumu = 35678;*/
		
		    Student stud4 = new Student("Krzysztof", "OLEJNIK", 35678);
		   /* stud1.WyswietlDane();
		    stud2.WyswietlDane();
		    stud3.WyswietlDane();
		    stud4.WyswietlDane();
		    wyk1.WyswietlDane();*/
		    
/*			Console.WriteLine(stud1.nr_albumu + " " + stud1.imie + " " + stud1.nazwisko);
			Console.WriteLine(stud2.nr_albumu + " " + stud2.imie + " " + stud2.nazwisko);
			Console.WriteLine(stud3.nr_albumu + " " + stud3.imie + " " + stud3.nazwisko);
			Console.WriteLine(stud4.nr_albumu + " " + stud4.imie + " " + stud4.nazwisko);
			Console.WriteLine(wyk1.stopien_naukowy + " " + wyk1.imie + " " + wyk1.nazwisko);*/
			
			//Console.WriteLine("Linia 62");
			gd.Wykladowca = wyk1;
			//Console.WriteLine("Linia 64");
			gd.DodajStudenta(stud1);
			gd.DodajStudenta(stud2);
			gd.DodajStudenta(stud3);
			gd.DodajStudenta(stud4);
			//Console.WriteLine("Linia 66");
			
			//zmodyfiukuj program tak, aby wyswietlic dane grupy wykladowe za pomoca pojedynczej metody, tj. GrupaDydaktyczna.WyswietlDane()
			
			try
			{
			    gd.WyswietlDaneZWyjatkiem();
			}
			catch (Exception ex)
			{
			     Console.WriteLine(ex.Message);
			}
			finally
			{
			    Console.WriteLine("Kontynuacja programu z wyjatkiem");
			}
			
			try
			{
			    gd.WyswietlDane();
			}
			catch (Exception ex)
			{
			     Console.WriteLine(ex.Message);
			}
			finally
			{
			    Console.WriteLine("Kontynuacja programu bez wyjatku");
			}
			
			//gd.WyswietlDane();
			
			Console.WriteLine("Test");
		}
	}
	
	public class Student : Osoba
	{
	  //public string imie;
	  //public string nazwisko;
	  //public int nr_albumu;
	  private int nr_albumu;
	  
	  public Student(string imie, string nazwisko, int nr_albumu)
	  {
	    this.imie = imie;
	    this.nazwisko = nazwisko;
	    this.nr_albumu = nr_albumu;
	  }
	  
	  public void WyswietlDane()
	  {
	      //Console.WriteLine("To jest metoda WyswietlDane w klasie Student");
	      base.WyswietlDane();
	      //zmodyfikowac cialo metody, aby dodatkowo wystwietlic nr_albumu
	      Console.WriteLine("Nr albumu="+nr_albumu);
	  }
	  
	  public Student()
	  {
	    
	  }
	}
	  
	public class Wykladowca : Osoba
	{
	  //string imie;
	  //string nazwisko;
	  //public string stopien_naukowy;
	  private string stopien_naukowy;
	  
	  //dodac metode WyswietlDane(), wyświetlającą dodatkowo stopien naukowy wykladowcy
	  
	  
	  public void WyswietlDane()
	  {
	      //Console.WriteLine("To jest metoda WyswietlDane w klasie Student");
	      base.WyswietlDane();
	      //zmodyfikowac cialo metody, aby dodatkowo wystwietlic nr_albumu
	      Console.WriteLine("Stopien naukowy="+stopien_naukowy);
	  }
	  
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
	  //public string imie;
	  //public string nazwisko;
	    
	  /*private string imie;
	  private string nazwisko;*/
	  
	  protected string imie;
	  protected string nazwisko;
	  
      public void WyswietlDane()
      {
          Console.WriteLine("Imie="+imie+", Nazwisko="+nazwisko);
      }
	  
	  public Osoba()
	  {
	    
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
            set => wykladowca = value;
        }
	    
	    private List<Student> studenci = new List<Student>(); 
	    
	    public void DodajStudenta(Student student)
	    {
	        //Console.WriteLine("Linia 124");
	        studenci.Add(student);
	        //Console.WriteLine("Linia 126");
	    }
	    
	    public void WyswietlDaneZWyjatkiem()
	    {
	        throw new NotImplementedException();
	    }
	    
	    private void WyswietlNazweGrupy()
	    {
	        Console.WriteLine("Nazwa grupy: "+ this.NazwaGrupy);
	    }
	    
	    private void WyswietlWykladowce()
	    {
	        Console.WriteLine("--- Wykladowca: ---");
	        this.Wykladowca.WyswietlDane();    
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
	        //Zadanie: zaimplementowac ciało metody
	        this.WyswietlNazweGrupy();
	        this.WyswietlWykladowce();
	        this.WyswietlListeStudentow();
	    }
	}
}
