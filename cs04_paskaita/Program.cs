using System;
using System.Collections.Generic;
using System.Threading;

namespace cs04_paskaita
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("cs04_PASKAITA!");

            #region TEORIJA - Ciklas FOR

            ////for (int i = (iteracijos pradžia; i < (iki kiek iteracija bus vykdoma); (kokiais žingsniais eis))
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine($"i rekšmė yra {i}");
            //}
            //// For cikle atliekame veiksmus žinomą kiekį kartų;
            //// Kintamojo vardas "i" - tai sandartas
            //// Ciklas prasideda nuo "0"
            //// Cikslas "suksis" tol kol "i" yra mažesnis už 10
            //for (int i = 20; i > 0; i--)
            //{
            //    Console.WriteLine($"i reikšmė yra {i}");
            //}

            //string name = "name1";
            //for (int i = 0; i < name.Length; i++)
            //{
            //    Console.WriteLine(name[i]);
            //}

            //Console.WriteLine("Loading: ");
            //for (int i = 0; i < 10; i++)
            //{
            //    Thread.Sleep(100);  // <-- using System.Threading;
            //    Console.Write("#");
            //}

            #endregion

            #region TEORIJA - Ciklas WHILE
            // While pagrinde yra bool
            //Console.WriteLine("");
            //Console.WriteLine("Teorija while");
            //bool isAlive = false;
            //int counter = 0;

            //while (!isAlive)
            //{
            //    if(counter == 10)
            //    {
            //        isAlive = true;
            //        Console.WriteLine("Service woke up!");
            //    }
            //    else
            //    {
            //        counter++;
            //        Console.WriteLine($"Number of waking up tries: {counter}");
            //    }
            //}
            #endregion

            #region TEORIJA - KOLEKCIJOS
            //// Kurdamas nustatai kokio tipo, tipas, kurio paskirtis
            //// grupuoti duomenis

            //// Rūšys Masybas, sąrašas ir žodynas
            //// Kuriant masyvą reikia nurodyti jo dydį, pavyzdžiui
            //var array = new int[5];
            //array[0] = 10;
            //array[1] = 11;
            //array[2] = 12;
            //array[3] = 13;
            //array[4] = 14;

            //var array2 = new int[5]
            //{
            //    1,2,3,4,5
            //};
            //// Dydžio pakeisti negalima
            //// iteravimas:
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine(array[i]);
            //}

            //// Masyvo elementai skaičiuojami nuo 0
            //// .NET masyvai apsaugoti nuo perindeksavimo

            #endregion

            #region TEORIJA - FOREACH, RANDOM
            //string[] weekDays =
            //{
            //    "monday",
            //    "tuesday",
            //    "wednesday",
            //    "thursday",
            //    "friday",
            //    "saturday",
            //    "sunday"
            //};

            //foreach (var day in weekDays)
            //{
            //    Console.WriteLine(day);
            //}

            //// random
            //int[] numbers = new int[10];
            //var random = new Random();
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    numbers[i] = random.Next(1, 100);
            //}
            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}
            //// daugiamačiai masyvai

            //var matrix = new int[5, 4]
            //{
            //    {1, 1, 1, 1},
            //    {1, 1, 1, 1},
            //    {1, 1, 1, 1},
            //    {1, 1, 1, 1},
            //    {1, 1, 1, 1}
            //};

            //for (int i = 0; i < matrix.GetUpperBound(0); i++)
            //{
            //    for (int j = 0; j < matrix.GetUpperBound(1); j++)
            //    {
            //        Console.Write(matrix[i, j]);
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region TEORIJA - LIST<T> ir METODAI

            //// Mandras masyvas, kuris operuojamas "mandromis" funkcijomis
            //var numbers = new List<int>(); // <-- using System.Collections.Generic
            //numbers.Add(6);
            //numbers.Add(8);
            //numbers.Add(11);
            //numbers.Add(89);
            //numbers.Add(4);

            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("");
            //numbers.Insert(3, 9);

            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}

            //// tinka mažiems sąrašams
            //// Metodai: https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.add?view=netframework-4.8

            //// list kuriamas tuščias, pildomas po to
            //// naudojamas .Count (ne .Length, kaip array)

            //int index = numbers.FindIndex(x => x == 5); // <-- x arrow (foreach in x in numbers)
            //var number = numbers[index];

            //// arba
            //Console.WriteLine("");
            //numbers.Sort(); // <-- didėjimo tvarka susortin'a
            //numbers.ForEach(x => Console.WriteLine(x)); // <-- foreach'as

            //Console.WriteLine("");
            //numbers.Sort((a, b) => b.CompareTo(a));
            //numbers.ForEach(x => Console.WriteLine(x)); // <-- Tupla, bet čia jau per mandra pradžiai

            #endregion

            //Assignment1();
            //Assignment2();
            //Assignment3();
            //Assignment4();

            //Assignment5();
            //Assignment6();
            //Assignment7();
            //Assignment8();
            //Assignment9();
            //Assignment10();
            //Assignment11();
            //Assignment12();

            //Assignment13();
            Assignment14();
            //Assignment15();
            //Assignment16();
        }

        public static void Assignment1()
        {
            Console.WriteLine("Enter an integer: ");
            int inputNumber = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= inputNumber; i++)
            {
                Console.Write($"{i}, ");
                sum += i;
            }
            Console.WriteLine("---");
            Console.WriteLine($"Suma yra: {sum}");
        }

        public static void Assignment2()
        {
            Console.WriteLine("Enter an integer: ");
            int inputNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i <= inputNumber; i++)
            {
                if (i%2 == 0)
                {
                    Console.Write($"{i} ");
                }
            }
            Console.WriteLine("");
        }

        public static void Assignment3()
        {
            Console.WriteLine("Enter a string: ");
            string input = Console.ReadLine();

            for (int i = input.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(input[i]);
            }
        }

        public static void Assignment4()
        {
            bool Continue = true;
            while (true)
            {
                Console.WriteLine("Enter an integer: ");
                int inputNumber = int.Parse(Console.ReadLine());

                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"{inputNumber} * {i} = {inputNumber * i}");
                }
                Console.WriteLine("Wanna continue? y/n");
                var input = Console.ReadLine();

                if (input.Trim().ToLower() == "n")
                {
                    Console.WriteLine("Bye!");
                    Continue = false; // <-- arba tiesiog break;
                }
            }
        }

        public static void Assignment5()
        {
            // Išvesti skaičių sumą nuo 1 iki pasirinkto didelio skaičiaus.
            // Parodyti skaičiavimo progresą
            Console.WriteLine("Enter an integer: ");
            var input = int.Parse(Console.ReadLine());
            string glueString = "";
            string progressString = "";
            float counter = 0;
            for (int i = 0; i < input; i++)
            {
                glueString += i.ToString();
                progressString += "#";
                Console.WriteLine(glueString);
                Console.WriteLine(progressString);
                Console.WriteLine($"{(counter++)/input*100}%");
                Thread.Sleep(150);
                Console.Clear();
            }
            Console.WriteLine(glueString);
            Console.WriteLine(progressString);
            Console.WriteLine($"{counter/input*100}%");

        }

        public static void Assignment6()
        {
            Console.WriteLine("How tall will be the piramid? ");
            var input = int.Parse(Console.ReadLine());

            for (int i = 0; i < input; i++)
            {
                Console.WriteLine($"");
            }
        }

        public static void Assignment7()
        {
            Console.WriteLine("Enter a sequence of strings");
            string input = Console.ReadLine();

           // for (int i = 0; i < input.Length – 1; i++)
            {
             //   if 
                {

                }
            }
        }

        public static void Assignment8()
        {
            while (true)
            {
                Console.WriteLine("Enter integer X");
                float x = float.Parse(Console.ReadLine());

                Console.WriteLine("Enter integer Y");
                float y = float.Parse(Console.ReadLine());

                Console.WriteLine("Enter operator");
                Console.WriteLine("Enter operator + - * /");
                string o = Console.ReadLine();

                switch (o)
                {
                    case "+":
                        Console.WriteLine($"{y} + {x} = {y + x}");
                        break;
                    case "-":
                        Console.WriteLine($"{y} - {x} = {y - x}");
                        break;
                    case "*":
                        Console.WriteLine($"{y} * {x} = {y * x}");
                        break;
                    case "/":
                        Console.WriteLine($"{y} / {x} = {y / x}");
                        break;
                }
                Console.WriteLine("More calculations? y/n");
                var input = Console.ReadLine();
                //if input.ToLower = 
            }
        }

        public static void Assignment9()
        {
            var input = new int[5];
            Console.WriteLine("Enter 5 intgers: ");
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = int.Parse(Console.ReadLine());
            }
            Array.Reverse(input);
            foreach (var item in input)
            {
                Console.WriteLine(item);
            }

        }

        public static void Assignment10()
        {
            int sum = 0;
            //foreach (int i in Assignment9().input)
            {

            }
        }

        public static void Assignment11()
        {
            //int[] newArray = input.Clone();
        }

        public static void Assignment12() // Bubble sor
        {
            int[] numbers = new int[10];
            var random = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(1, 100);
            }
            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}

            //int smallestElement = 1000;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (smallestElement > numbers[i])
            //        smallestElement = numbers[i];
            //}
            //Console.WriteLine(smallestElement);

            //bubble sort

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {

                    var temp = numbers[j];
                    numbers[j] = numbers[i];
                    numbers[i] = temp;
                }
            }
        }

        public static void Assignment13()
        {
            //Užpildyti sąrašą atsitiktiniais skaičiais.
            //Išvesti visus lyginius skaičius.
            var listuk = new List<int>();
            var Random = new Random();
            var counter = 1;
            

            Console.WriteLine("List size? Enter int: ");
            var input = int.Parse(Console.ReadLine());

            for (int i = 0; i < input; i++)
            {
                var randomRandom = Random.Next(1, 25);
                listuk.Add(randomRandom);
            }
            Console.WriteLine("Your randomized list: ");
            foreach (var item in listuk)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine(" "); // <-- sitaksinis cukrus
            Console.WriteLine(" ");
            Console.WriteLine("%2: ");
            foreach (var item in listuk)
            {
                counter++;
                if (item % 2 == 0) Console.WriteLine($"Lits index {counter} divedeable by 2 is printed: {item}");
            }
            
        }

        public static void Assignment14()
        {
            // Padaryti vieną studentų sąrašą.
            // Padaryti antrą vėliau atvykusių studentų sąrašą.
            // Sujungti abu sąrašus, surūšiuti ir išvesti.

            var studentsL1 = new List<string>();
            

            studentsL1.Add("Jonas");
            studentsL1.Add("Petras");
            studentsL1.Add("Giedrius");

            var studentsL2 = new List<string>() { "Aivaras", "Marius", "Vytautas"};

            for (int i = 0; i < studentsL2.Count; i++)
            {
                studentsL1.Add(studentsL2[i]);
            }
            Console.WriteLine("Full list: ");
            foreach (var item in studentsL1)
            {
                Console.WriteLine(item);
            }

            studentsL1.Sort();
            Console.WriteLine("Sorted List:");
            foreach (var item in studentsL1)
            {
                Console.WriteLine(item);
            }
        }

        public static void Assignment15()
        {

        }

        public static void Assignment16()
        {

        }
    }
}

