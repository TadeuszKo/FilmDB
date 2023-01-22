using System;
using System.Collections.Generic;


namespace JIPP5_powtorka
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pierwszy program - rozgrzewka
            //Zadanie 1-2
            //Console.WriteLine("Podaj swoje imię:");
            //var name = Console.ReadLine();
            //Console.WriteLine("Hello " + name);

            //Zadanie 3
            //int result = 5 + 9;
            //Console.WriteLine(result);
            //Przy próbie uruchomienia VS zwraca błąd CS1002 oczekiwanie średnika, znak zakończenia lini kodu
            //oraz ostrzerzenie CS0219 z informacją że zmienna result posiada wartość czyli zajmuje miejsce
            //w pamięci ale nie jest nigdzie używana. Dlatego zmienna zostala użyta i wyświetlona w konsoli

            //Operatory
            //Zadanie 1
            //int number = 10;
            //float money = 1.123456789f;
            //string text = "Przykladowy tekst";
            //bool isLogged = true;
            //char myChar = 'H';
            //decimal price = 0.1234567890123456789012345678901234567890m; 

            //Console.WriteLine(number);
            //Console.WriteLine(money);
            //Console.WriteLine(text);
            //Console.WriteLine(isLogged);
            //Console.WriteLine(myChar);
            //Console.WriteLine(price);

            //przy typach zmienno przecinkowuch przy wyświetlaniu wartosci można zauważyć zaokrąglenia podanych liczb
            //przez co wyniki obliczen mogą zawierac błędy. Można tez zauważyć ze typ decimal ma znacznie większą dokładnosć
            //jeśli chodzi o ilośc cyfr po przecinku 

            //Zadanie 2
            //string myAge = "Age: ";
            //int wifeAge = 18;
            //var resut = myAge + wifeAge;
            //Console.WriteLine(resut);

            //Przypisana wartość do zmiennej wifeAge przy wyświetlaniu zostaje przekonwertowana na typ string

            //Zadanie 3
            //bool isTrue = true;
            //bool isFalse = false;
            //bool isReallyTrue = true;
            //bool and = isTrue && isFalse;
            //bool or = isTrue || isReallyTrue;
            //bool negative =! isFalse;

            //Console.WriteLine("and = " + and + "\nor = " + or + "\nnegative = " + negative);

            //Zadanie 4
            //var a = 5;
            //var b = 12;

            //var add = a + b;
            //var sub = a - b;
            //var div = (float)a / b;
            //var mul = a * b;
            //var mod = a % b;

            //Console.WriteLine("add = " + add +
            //    "\nsub = " + sub +
            //    "\ndiv = " + div +
            //    "\nmul = " + mul +
            //    "\nmod = " + mod 
            //    );

            //Zadanie 5
            //string a, b, c;
            //a = "Ala ";
            //b = "ma ";
            //c = "kota. ";
            //var result = a + b + c;
            //Console.WriteLine(result);

            // to zo zauważyłem to sumowanie zmiennych zawierających ciagi znaków to wyświetlanie tych znakow w podanej kolejnosci
            // aby było to bardziej czytelne dla człowieka powinno się dodać na końcu znaku jakiś separator, np: spację

            //INSTRUKCJE STERUJĄCE I PĘTLE
            //Zadanie 1
            //int n1 = 10;
            //int n2 = 20;

            //if (n1 > n2)
            //    Console.WriteLine("n1 jest większe od n2");
            //if (n1 < n2)
            //    Console.WriteLine("n2 jest większe od n1");
            //if (n1 == n2)
            //    Console.WriteLine("n1 jest równe n2");


            //zadanie 2
            //int i = 0;
            //while (i < 10) 
            //{
            //    Console.Write("C# ");
            //    i++;
            //}

            //Console.WriteLine();

            //for(i=0;i<10;i++)
            //    Console.Write("C# ");

            //zadanie 3
            //var n = 10;

            //for (int i = 0; i < n + 1; i++) 
            //{
            //    if (i % 2 == 0)
            //        Console.WriteLine(i + " - Parzysta");
            //    if (i % 2 != 0) 
            //        Console.WriteLine(i + " - Nieparzysta");
            //}

            //Zadanie 4*

            //var n = 15;

            //for (int i = 0; i < n + 1; i++)
            //{                
            //    for (int j = 0; j < i; j++)
            //        Console.Write('*');

            //    Console.WriteLine();
            //}

            //zadanie 5*

            //string exam="";
            //int point;

            //Console.WriteLine("Zdobyte punkty: ");
            //point = int.Parse(Console.ReadLine());

            //if (point < 0 || point > 100)
            //    exam = "Wartość poza zakresem";

            //if (point >= 0 && point <= 39)
            //    exam = "Ocena Niedostateczna";
            //else if (point >= 40 && point <= 54)
            //    exam = "Ocena Dopuszczająca";
            //else if (point >= 55 && point <= 69)
            //    exam = "Ocena Dostateczna";
            //else if (point >= 70 && point <= 84 )
            //    exam = "Ocena Dobra";
            //else if (point >= 85 && point <= 98)
            //    exam = "Ocena Bardzo Dobra";
            //else if (point >= 99 && point <= 100)
            //    exam = "Ocena Celująca";


            //Console.WriteLine(exam);

            //KOLEKCJE
            //Zadanei 1 
            //string[] colors = new string[4];
            //colors[0] = "niebieski";
            //colors[1] = "fioletowy";
            //colors[2] = "szary";
            //colors[3] = "czerwony";

            //Console.WriteLine("Moj pierwszy kolor to: {0}\n" +
            //    "Mój ostatni kolor to: {1}", colors[0], colors[3]);

            //Zadanie 2
            //int[] tab = new int[10];

            //for (int i = 0; i < 10; i++)
            //    tab[i] = i;

            //for ( int i = 0; i < 10; i++)
            //    Console.WriteLine("Liczba: {0}",tab[i]);
            //Console.WriteLine();

            //foreach (int i in tab) 
            //{
            //    Console.WriteLine("Liczba: {0}", tab[i]);
            //}
            //Console.WriteLine();

            //int j = 0;
            //while ( j < 10) 
            //{
            //    Console.WriteLine("Liczba: {0}", tab[j]);
            //    j++;
            //}

            //zadanie 3
            //List<string> fruits = new List<string>();

            //fruits.Add("Pomidor");
            //fruits.Add("Jabłko");
            //fruits.Add("Gruszka");
            //fruits.Add("Czereśnia");

            //foreach (string ithem in fruits)
            //{
            //    Console.Write("{0}, ", ithem);
            //}

            //Console.WriteLine();

            //fruits.Remove("Pomidor");
            //fruits.RemoveAt(2);

            //foreach (string ithem in fruits)
            //{
            //    Console.Write("{0}, ", ithem);
            //}

            //Console.ReadKey();

        }
    }
}
