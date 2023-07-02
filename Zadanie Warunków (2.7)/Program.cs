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
                Console.WriteLine("Wprowadź numer Zadania od 1 do 13 albo 14.Wyjście ");
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
                        Console.WriteLine("Podaj liczbę:");
                        int number2;
                        if (!int.TryParse(Console.ReadLine(), out number2))
                        {
                            Console.WriteLine("Nieprawidłowa liczba.");
                            continue;
                        }

                        if (number2 % 2 == 0)
                        {
                            Console.WriteLine("Podana liczba jest parzysta.");
                        }
                        else
                        {
                            Console.WriteLine("Podana liczba jest nieparzysta.");
                        }
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("Napisz program w C#, który sprawdzi czy podana przez użytkownika liczba jest dodatnia czy ujemna.");
                        Console.WriteLine("Podaj liczbę:");
                        float number3;
                        if (!float.TryParse(Console.ReadLine(), out number3))
                        {
                            Console.WriteLine("Nieprawidłowa liczba.");
                            continue;
                        }

                        if (number3 > 0)
                        {
                            Console.WriteLine("Podana liczba jest dodatnia.");
                        }
                        else if (number3 < 0)
                        {
                            Console.WriteLine("Podana liczba jest ujemna.");
                        }
                        else
                        {
                            Console.WriteLine("Podana liczba jest równa zero.");
                        }

                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("Napisz program w C#, który sprawdzi czy podany przez użytkownika rok jest rokiem przestępnym.");
                        Console.WriteLine("Podaj rok:");
                        int year;
                        if (!int.TryParse(Console.ReadLine(), out year) || year <= 0)
                        {
                            Console.WriteLine("Nieprawidłowy rok.");
                            continue;
                        }

                        bool isLeapYear = false;

                        if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
                        {
                            isLeapYear = true;
                        }

                        if (isLeapYear)
                        {
                            Console.WriteLine($"{year} jest rokiem przestępnym.");
                        }
                        else
                        {
                            Console.WriteLine($"{year} nie jest rokiem przestępnym.");
                        }
                        break;
                    case "5":
                        Console.Clear();
                        Console.WriteLine("Napisz program w C#, który sprawdzi czy podany przez użytkownika wiek uprawnia go do ubiegania się o stanowisko posła, premiera, sentarora,Prezydenta");
                        Console.WriteLine("Podaj swój wiek:");
                        int age;
                        if (!int.TryParse(Console.ReadLine(), out age) || age < 0)
                        {
                            Console.WriteLine("Nieprawidłowy wiek.");
                            continue;
                        }

                        if (age >= 21)
                        {
                            Console.WriteLine("Możesz ubiegać się o stanowisko posła.");
                        }

                        if (age >= 35)
                        {
                            Console.WriteLine("Możesz ubiegać się o stanowisko premiera.");
                            Console.WriteLine("Możesz ubiegać się o stanowisko prezydenta.");
                        }

                        if (age >= 30)
                        {
                            Console.WriteLine("Możesz ubiegać się o stanowisko senatora.");
                        }
                        break;
                    case "6":
                        Console.Clear();
                        Console.WriteLine("Napisz program w C#, który pobierze wzrost użytkownika i przypisze mu wymyśloną kategorię wzrostu.");
                        Console.WriteLine("Wprowadź swój wzrost w cm:");
                        float height;
                        if (!float.TryParse(Console.ReadLine(), out height) || height <= 0)
                        {
                            Console.WriteLine("Nieprawidłowy wzrost.");
                            continue;
                        }

                        if (height >= 50 && height <= 140)
                        {
                            Console.WriteLine($"Twój wzrost: {height}cm mieści się w zakresie dziecka!");
                        }
                        else if (height >= 141 && height <= 190)
                        {
                            Console.WriteLine($"Twój wzrost: {height}cm mieści się w zakresie dorosłego człowieka!");
                        }
                        else if (height >= 191 && height <= 230)
                        {
                            Console.WriteLine($"Twój wzrost: {height}cm mieści się w zakresie dużego człowieka!");
                        }
                        else
                        {
                            Console.WriteLine("Podany wzrost nie mieści się w żadnym zakresie!");
                        }
                        break;
                    case "7":
                        Console.Clear();
                        Console.WriteLine("Napisz program w C#, który pobierze 3 liczby od użytkownika i sprawdzi, która jest największa");
                        Console.WriteLine("Wprowadź pierwszą liczbę:");
                        if (!float.TryParse(Console.ReadLine(), out float num1))
                        {
                            Console.WriteLine("Nieprawidłowa wartość dla pierwszej liczby. Spróbuj ponownie.");
                            continue;
                        }

                        Console.WriteLine("Wprowadź drugą liczbę:");
                        if (!float.TryParse(Console.ReadLine(), out float num2))
                        {
                            Console.WriteLine("Nieprawidłowa wartość dla drugiej liczby. Spróbuj ponownie.");
                            continue;
                        }

                        Console.WriteLine("Wprowadź trzecią liczbę:");
                        if (!float.TryParse(Console.ReadLine(), out float num3))
                        {
                            Console.WriteLine("Nieprawidłowa wartość dla trzeciej liczby. Spróbuj ponownie.");
                            continue;
                        }

                        float resultFinal = Math.Max(num1, Math.Max(num2, num3));
                        Console.WriteLine($"Największa liczba to: {resultFinal}");
                        break;
                    case "8":
                        Console.Clear();
                        Console.WriteLine("Napisz program, który sprawdzi, czy kandydat może ubiegać się o miejsce na studiach wg. Następujących kryteriów:");
                        Console.WriteLine("Kryteria przyjmowania na studia:");
                        Console.WriteLine("\r\nWyniki Matematyka - 70%" + "\r\nWynik Fizyka - 55%" + "\r\nWynik Chemia - 45%" + "\r\nŁączny wynik z 3 przemiotów powyżej 180% albo wynik Matematyka + jeden przedmiot = 150%");
                        Console.WriteLine("Wprowadź wyniki procentowe z przedmiotów:");
                        Console.WriteLine("Podaj wynik z matematyki:");
                        int matematyka;
                        if (!int.TryParse(Console.ReadLine(), out matematyka) || matematyka < 0 || matematyka > 100)
                        {
                            Console.WriteLine("Nieprawidłowy wynik z matematyki. Podaj liczbę z zakresu 0-100.");
                            continue;
                        }

                        Console.WriteLine("Podaj wynik z fizyki:");
                        int fizyka;
                        if (!int.TryParse(Console.ReadLine(), out fizyka) || fizyka < 0 || fizyka > 100)
                        {
                            Console.WriteLine("Nieprawidłowy wynik z fizyki. Podaj liczbę z zakresu 0-100.");
                            continue;
                        }

                        Console.WriteLine("Podaj wynik z chemii:");
                        int chemia;
                        if (!int.TryParse(Console.ReadLine(), out chemia) || chemia < 0 || chemia > 100)
                        {
                            Console.WriteLine("Nieprawidłowy wynik z chemii. Podaj liczbę z zakresu 0-100.");
                            continue;
                        }

                        int suma = matematyka + fizyka + chemia;

                        if ((matematyka >= 150 && (fizyka > 55 || chemia > 45)) || suma >= 180)
                        {
                            Console.WriteLine("Kandydat dopuszczony do rekrutacji.");
                        }
                        else
                        {
                            Console.WriteLine("Kandydat nie spełnia warunków rekrutacji.");
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
                        double sideA = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Podaj długość drugiego boku:");
                        double sideB = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Podaj długość trzeciego boku:");
                        double sideC = Convert.ToDouble(Console.ReadLine());

                        if (sideA > 0 && sideB > 0 && sideC > 0 && sideA + sideB > sideC && sideB + sideC > sideA && sideC + sideA > sideB)
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
                            default:
                                Console.WriteLine("Nieprawidłowy ocena!");
                                break;
                        }
                        break;
                    case "12":
                        Console.Clear();
                        Console.WriteLine("Napisz program, który pobierze numer dnia tygodnia i wyświetli jego nazwę");
                        Console.WriteLine("Wprowadź numer/nazwę dnia tygodnia: ");
                        string userWeekday = Console.ReadLine();

                        if (int.TryParse(userWeekday, out int weekdayNumber))
                        {
                            switch (weekdayNumber)
                            {
                                case 1:
                                    Console.WriteLine("Dzień pierwszy - Poniedziałek");
                                    break;
                                case 2:
                                    Console.WriteLine("Dzień drugi - Wtorek");
                                    break;
                                case 3:
                                    Console.WriteLine("Dzień trzeci - Środa");
                                    break;
                                case 4:
                                    Console.WriteLine("Dzień czwarty - Czwartek");
                                    break;
                                case 5:
                                    Console.WriteLine("Dzień piąty - Piątek");
                                    break;
                                case 6:
                                    Console.WriteLine("Dzień szósty - Sobota");
                                    break;
                                case 7:
                                    Console.WriteLine("Dzień siódmy - Niedziela");
                                    break;
                                default:
                                    Console.WriteLine("Nieprawidłowy numer dnia tygodnia!");
                                    break;
                            }
                        }
                        else
                        {
                            switch (userWeekday.ToLower())
                            {
                                case "poniedziałek":
                                    Console.WriteLine("Dzień pierwszy - Poniedziałek");
                                    break;
                                case "wtorek":
                                    Console.WriteLine("Dzień drugi - Wtorek");
                                    break;
                                case "środa":
                                    Console.WriteLine("Dzień trzeci - Środa");
                                    break;
                                case "czwartek":
                                    Console.WriteLine("Dzień czwarty - Czwartek");
                                    break;
                                case "piątek":
                                    Console.WriteLine("Dzień piąty - Piątek");
                                    break;
                                case "sobota":
                                    Console.WriteLine("Dzień szósty - Sobota");
                                    break;
                                case "niedziela":
                                    Console.WriteLine("Dzień siódmy - Niedziela");
                                    break;
                                default:
                                    Console.WriteLine("Nieprawidłowy dzień tygodnia!");
                                    break;
                            }
                        }

                        break;
                    case "13":
                        Console.Clear();
                        Console.WriteLine(". Napisz program, który będzie posiadał proste menu (wg. Wzoru poniżej) I będzie prostym kalkulatorem ");

                        Console.WriteLine("Podaj pierwszą liczbę:");
                        if (!float.TryParse(Console.ReadLine(), out float firstNum))
                        {
                            Console.WriteLine("Nieprawidłowa wartość dla pierwszej liczby.");
                            continue;
                        }

                        Console.WriteLine("Podaj drugą liczbę:");
                        if (!float.TryParse(Console.ReadLine(), out float secondNum))
                        {
                            Console.WriteLine("Nieprawidłowa wartość dla drugiej liczby.");
                            continue;
                        }

                        Console.WriteLine("Podaj numer operacji do wykonania:");
                        Console.WriteLine("\r\n 1.Dodawanie" + "\r\n 2.Odejmowanie" + "\r\n 3.Mnożenie" + "\r\n 4.Dzielenie \r\n");

                        string numOperation = Console.ReadLine();
                        switch (numOperation)
                        {
                            case "1":
                                Console.WriteLine($"= {firstNum + secondNum}");
                                break;
                            case "2":
                                Console.WriteLine($"= {firstNum - secondNum}");
                                break;
                            case "3":
                                Console.WriteLine($"= {firstNum * secondNum}");
                                break;
                            case "4":
                                if (secondNum == 0)
                                {
                                    Console.WriteLine("Nie można dzielić przez zero.");
                                }
                                else
                                {
                                    Console.WriteLine($"= {firstNum / secondNum}");
                                }
                                break;
                            default:
                                Console.WriteLine("Nieprawidłowy numer operacji.");
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

