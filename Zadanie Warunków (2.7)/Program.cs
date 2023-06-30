using System;
using System.ComponentModel.Design;

namespace Zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("\nZadania Warunków");
                Console.WriteLine("Wprowadź numer Zadania od 1 do 13: ");
                Console.Write("14.Wyjście \n");
                var operation = Console.ReadLine();
                Console.WriteLine();

                switch (operation)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Pierwsze Zadanie");
                        Console.WriteLine("Napisz program w C#, który stworzy dwie zmienne int i sprawdzi czy są one równe czy nie.\r");
                        int a = 5;
                        int b = 5;
                        Console.WriteLine($"Pierwsza liczba: {a}");
                        Console.WriteLine($"Druga liczba: {b}");
                        if (a == b)
                        {
                            Console.WriteLine("Wynik: Liczby są równe sobie!");
                        }
                        else
                        {
                            Console.WriteLine("Wynik: Liczby nie są równe! ");
                        }
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Napisz program w C#, który sprawdzi czy podana przez użytkownika liczba jest parzysta czy nieparzysta.");
                        Console.WriteLine("Wprowadź liczbę!");
                        float number = float.Parse(Console.ReadLine());
                        if (number % 2 == 0)
                        {
                            Console.WriteLine($"Liczba {number} jest parzysta!");
                        }
                        else
                        {
                            Console.WriteLine($"Liczba {number} jest nieparzysta!");
                        }
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("Napisz program w C#, który sprawdzi czy podana przez użytkownika liczba jest dodatnia czy ujemna.");
                        Console.WriteLine("Wprowadź liczbę!");
                        float number1 = float.Parse(Console.ReadLine());
                        if (number1 >= 0)
                        {
                            Console.WriteLine($"Liczba {number1} jest dodatnia!");
                        }
                        else
                        {
                            Console.WriteLine($"Liczba {number1} jest ujemna");
                        }

                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("Napisz program w C#, który sprawdzi czy podany przez użytkownika rok jest rokiem przestępnym.");
                        Console.WriteLine("Wprowadź Rok!");
                        float number2 = float.Parse(Console.ReadLine());
                        if (number2 % 4 == 0)
                        {
                            Console.WriteLine($"Rok {number2} Jest rokiem przystępnym");
                        }
                        else
                        {
                            Console.WriteLine($"Rok {number2} nie jest rokiem przystępnym");
                        }
                        break;
                    case "5":
                        Console.Clear();
                        Console.WriteLine("Napisz program w C#, który sprawdzi czy podany przez użytkownika wiek uprawnia go do ubiegania się o stanowisko posła, premiera, sentarora,Prezydenta");
                        Console.WriteLine("Wprowadź swój wiek:");
                        float age = float.Parse(Console.ReadLine());
                        if (age >= 21 && age <= 29)
                        {
                            Console.WriteLine("Twój wiek uprawnia cię do zostania Posłem!");
                            return;
                        }
                        else if (age >= 30 && age <= 34)
                        {
                            Console.WriteLine("Twój wiek uprawnia cię do zostania Senatorem");
                            return;
                        }
                        else if (age >= 35 && age <= 64)
                        {
                            Console.WriteLine("Twój wiek uprawnia cię do zostania Prezydentem albo premierem");
                            return;
                        }
                        else if (age >= 65)
                        {
                            Console.WriteLine("W tym wieku juz niestety emeryturka");
                        }
                        else
                        {
                            Console.WriteLine("Twój Wiek Jest nie odpowiedni!");
                        }
                        break;
                    case "6":
                        Console.Clear();
                        Console.WriteLine("Napisz program w C#, który pobierze wzrost użytkownika i przypisze mu wymyśloną kategorię wzrostu.");
                        Console.WriteLine("Wprowadź swój wzrost w cm:");
                        float height = float.Parse(Console.ReadLine());
                        if (height >= 20 && height <= 140)
                        {
                            Console.WriteLine($"Twój wzrost: {height}cm mieści sie w zakresie dziecka!");
                        }
                        else if (height >= 141 && height <= 190)
                        {
                            Console.WriteLine($"Twój wzrost: {height}cm mieści sie w zakresie dorosłego człowieka!");
                        }
                        else if (height >= 191 && height <= 230)
                        {
                            Console.WriteLine($"Twój wzrost: {height}cm mieści się w zakresie dużego człowieka!");
                        }
                        else
                        {
                            Console.WriteLine("Dane są nie prawiedłowe!");
                        }
                        break;
                    case "7":
                        Console.Clear();
                        Console.WriteLine("Napisz program w C#, który pobierze 3 liczby od użytkownika i sprawdzi, która jest największa");
                        Console.WriteLine("Wprowadź pierwszą liczbę:");
                        float num1 = float.Parse(Console.ReadLine());
                        Console.WriteLine("Wprowadź drugą liczbę:");
                        float num2 = float.Parse(Console.ReadLine());
                        Console.WriteLine("Wprowadź trzecią liczbę:");
                        float num3 = float.Parse(Console.ReadLine());
                        float result = Math.Max(num1, num2);
                        float resultfinal = Math.Max(result, num3);
                        Console.WriteLine($"Największa liczba to: {resultfinal}");
                        break;
                    case "8":
                        Console.Clear();
                        Console.WriteLine("Napisz program, który sprawdzi, czy kandydat może ubiegać się o miejsce na studiach wg. Następujących kryteriów:");
                        Console.WriteLine("Kryteria przyjmowania na studia:");
                        Console.WriteLine("\r\nWyniki Matematyka - 70%" + "\r\nWynik Fizyka - 55%" + "\r\nWynik Chemia - 45%" + "\r\nŁączny wynik z 3 przemiotów powyżej 180% albo wynik Matematyka + jeden przedmiot = 150%");
                        Console.WriteLine("Wprowadź wyniki procentowe z przedmiotów:");
                        Console.WriteLine("Matematyka:"); float Mathematics = float.Parse(Console.ReadLine());
                        if (Mathematics < 70)
                        {
                            Console.WriteLine("Wynik nie mieści się w wymaganych kryteriach!");
                            break;
                        }
                        Console.WriteLine("Fizyka:"); float Physics = float.Parse(Console.ReadLine());
                        Console.WriteLine("Chemia:"); float Chemistry = float.Parse(Console.ReadLine());
                        float Totalresult = Mathematics + Physics + Chemistry;
                        if (Mathematics >= 70 && Physics >= 55 && Chemistry >= 45)
                        {
                            Console.WriteLine($"Kandydat dopuszczony do rekrutacji z wynikiem całkowitym: {Totalresult}% !");
                        }
                        else if (Mathematics + Physics + Chemistry >= 180)
                        {
                            Console.WriteLine($"Kandydat dopuszczony do rekrutacji z wynikiem całkowitym: {Totalresult}% !");
                        }
                        else if (Mathematics + Physics >= 150)
                        {
                            Console.WriteLine("Kandydat dopuszczony do rekrutacji z wynikami:");
                            Console.WriteLine($"Matematyka: {Mathematics}%");
                            Console.WriteLine($"Fizyka: {Physics}%");
                            Console.WriteLine($"Wynik całkowity: {Totalresult - Chemistry}%");
                        }
                        else if (Mathematics + Chemistry >= 150)
                        {
                            Console.WriteLine("Kandydat dopuszczony do rekrutacji z wynikami:");
                            Console.WriteLine($"Matematyka: {Mathematics}%");
                            Console.WriteLine($"Chemia: {Chemistry}%");
                            Console.WriteLine($"Wynik całkowity: {Totalresult - Physics}%");
                        }
                        else
                        {
                            Console.WriteLine("Kandydat nie dopuszczony do rekrutacji");
                        }
                        break;
                    case "9":
                        Console.Clear();
                        Console.WriteLine("Napisz program, który odczyta temperaturę I zwróci nazwę jak w poniższych kryteriach\n");

                        Console.Write("Podaj temperaturę: ");
                        double temp = Convert.ToDouble(Console.ReadLine());

                        string name = DownloadtemperatureName(temp);

                        Console.WriteLine("Nazwa temperatury: " + name);
                        static string DownloadtemperatureName(double temp)
                        {
                            if (temp < 0)
                            {
                                return "Mroźno";
                            }
                            else if (temp >= 0 && temp < 10)
                            {
                                return "Zimno";
                            }
                            else if (temp >= 10 && temp < 20)
                            {
                                return "Chłodno";
                            }
                            else if (temp >= 20 && temp < 30)
                            {
                                return "Ciepło";
                            }
                            else
                            {
                                return "Gorąco";
                            }
                        }
                        break;
                    case "10":
                        Console.Clear();
                        Console.WriteLine("Napisz program, który sprawdzi, czy z 3 podanych długości można stworzyć trójkąt\n");
                        Console.WriteLine("Podaj długość pierwszego boku:");
                        double A = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Podaj długość drugiego boku:");
                        double B = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Podaj długość trzeciego boku:");
                        double c = Convert.ToDouble(Console.ReadLine());

                        if (A > 0 && B > 0 && c > 0 && A + B > c && B + c > A && c + A > B)
                        {
                            Console.WriteLine("Z podanych długości boków można stworzyć trójkąt.");
                        }
                        else
                        {
                            Console.WriteLine("Z podanych długości boków nie można stworzyć trójkąta.");
                        }
                        break;
                    case "11":
                        Console.Clear();
                        Console.WriteLine("Napisz program, który zmieni ocenę ucznia na jej opis wg podanej tabeli:");
                        Console.WriteLine("Wprowadź Ocenę: ");
                        var Assessment = Console.ReadLine();
                        switch (Assessment)
                        {
                            case "1":
                                Console.WriteLine("Niedostateczny!");
                                break;
                            case "2":
                                Console.WriteLine("Dopuszczający!");
                                break;
                            case "3":
                                Console.WriteLine("Dostateczny!");
                                break;
                            case "4":
                                Console.WriteLine("Dobry!");
                                break;
                            case "5":
                                Console.WriteLine("Bardzo dobry!");
                                break;
                            case "6":
                                Console.WriteLine("Celujący!");
                                break;
                        }
                        break;
                    case "12":
                        Console.Clear();
                        Console.WriteLine("Napisz program, który pobierze numer dnia tygodnia i wyświetli jego nazwę");
                        Console.WriteLine("Wprowadź numer dnia tygonia: ");
                        var Weekday = Console.ReadLine();
                        switch (Weekday)
                        {
                            case "1":
                                Console.WriteLine("Dzień pierwszy - Poniedziałek");
                                break;
                            case "2":
                                Console.WriteLine("Dzień drugi - Wtorek");
                                break;
                            case "3":
                                Console.WriteLine("Dzień trzeci - Środa");
                                break;
                            case "4":
                                Console.WriteLine("Dzień czwarty - Czwartek");
                                break;
                            case "5":
                                Console.WriteLine("Dzień piąty - Piątek");
                                break;
                            case "6":
                                Console.WriteLine("Dzień szósty - Sobota");
                                break;
                            case "7":
                                Console.WriteLine("Dzień siódmy - Niedziela");
                                break;
                        }
                        break;
                    case "13":
                        Console.Clear();
                        Console.WriteLine(". Napisz program, który będzie posiadał proste menu (wg. Wzoru poniżej) I będzie prostym kalkulatorem ");
                        Console.WriteLine("Podaj pierwszą liczbę:");
                        float firstnum = float.Parse(Console.ReadLine());
                        Console.WriteLine("Podaj drugą liczbę:");
                        float secondnum = float.Parse(Console.ReadLine());
                        Console.WriteLine("Podaj numer operacji do wykonania:");
                        Console.WriteLine("\r\n 1.Dodawanie" + "\r\n 2.Odejmowanie" + "\r\n 3.Mnożenie" + "\r\n 4.Dzielenie \r\n");
                        var numOperation = Console.ReadLine();
                        switch (numOperation)
                        {
                            case "1":
                                Console.WriteLine($"= {firstnum + secondnum}");
                                break;
                            case "2":
                                Console.WriteLine($"= {firstnum - secondnum}");
                                break;
                            case "3":
                                Console.WriteLine($"= {firstnum * secondnum}");
                                break;
                            case "4":
                                Console.WriteLine($"= {firstnum / secondnum}");
                                break;
                        }
                        break;
                    case "14":
                        Console.Clear();
                        Console.WriteLine("\n" + "Do zobaczenia!");
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Nieprawidłowa opcja. Spróbuj ponownie.");
                        break;
                }
            }
        }
    }
}

