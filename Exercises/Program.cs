namespace Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ex13();
        }

        public static void Ex1()
        {
            int a = 5;
            int b = 5;

            if (a == b)
                Console.WriteLine("equals");
            else
                Console.WriteLine("not equals");
        }

        public static void Ex2()
        {
            Console.Write("Podaj liczbe: ");
            int input = int.Parse(Console.ReadLine());

            Console.WriteLine(input % 2 == 1 ? "Nieparzysta" : "Parzysta");
        }

        public static void Ex3()
        {
            Console.Write("Podaj liczbe: ");
            int input = int.Parse(Console.ReadLine());

            Console.WriteLine(input >= 0 ? "Nieujemna" : "Ujemna");
        }

        public static void Ex4()
        {
            Console.Write("Podaj rok: ");
            long input = long.Parse(Console.ReadLine());

            if ((input / 4 == 0 && input / 100 == 0) || input/400==0)
                Console.WriteLine("Rok przestepny");
            else
                Console.WriteLine("Nieprzestepny");
        }

        public static void Ex5()
        {
            Console.Write("Podaj wiek: ");
            int input = int.Parse(Console.ReadLine());
            string answer = "Możesz zostać ";

            if (input >= 21)
            {
                if (input >= 21) answer += "posłem";
                if (input >= 30) answer += ", senatorem ";
                if (input >= 35) answer += ", prezydentem";

                Console.WriteLine(answer);
            }
            else
                Console.WriteLine("Nie możesz zostać nikim ;(");

        }

        public static void Ex6()
        {
            Console.Write("Podaj wzrost: ");
            int input = int.Parse(Console.ReadLine());
            string answer = "Jesteś ";

            if (input == 0)
            {
                Console.WriteLine("nie istniejesz");
            }
            else
            {
                answer += input switch
                {
                    < 100 => "dzieckiem lub krasnoludem",
                    < 140 => "niziutki",
                    < 170 => "dosyć niski",
                    < 180 => "przecietnego wzrostu",
                    < 190 => "doysc wysoki",
                    < 200 => "bardzo wysoki",
                    _ => "gigantem"
                };

                Console.WriteLine(answer);
            }
        }

        public static void Ex7()
        {
            int input1 = int.Parse(Console.ReadLine());
            int input2= int.Parse(Console.ReadLine());
            int input3 = int.Parse(Console.ReadLine());

            int max = input1;

            if(input2 >= input1 && input2 >= input3)
                max = input2;
            else if(input3 >= input1 && input3 >= input2)
                max = input3;

            Console.WriteLine(max);
        }

        public static void Ex8()
        {
            Console.Write("Matematyka: ");
            int math = int.Parse(Console.ReadLine());
            Console.Write("Fizyka: ");
            int physics = int.Parse(Console.ReadLine());
            Console.Write("chemia: ");
            int chemistry = int.Parse(Console.ReadLine());

            int sumMathPlusPhysics = math + physics;
            int sumMathPlusChemistry  = math + chemistry;
            int sumAll = math + chemistry + physics;



            if(sumMathPlusPhysics > 150 || sumMathPlusChemistry>150 || sumAll > 180)
                Console.WriteLine("Kandydat dopuszczony do rekrutacji");
            else
                Console.WriteLine("Nieptrzyjęty");

        }

        public static void Ex9()
        {
            int temp = 41;

            string descriptionOfWeather = temp switch
            {
                < 0 => "Cholernie piździ",
                < 10 => "zimno",
                < 20 => "chłodno",
                < 30 => "w sam raz",
                < 40 => "zaczyna być słabo, bo gorąco",
                < 50 => "a weź wyprowadzam się na Alaskę.",
                _ => "coś poszło nie tak"
            };
            Console.WriteLine(descriptionOfWeather);
        }

        public static void Ex10()
        {
            int segment1 = 40;
            int segment2 = 55;
            int segment3 = 65;
            int max = segment1;
            string possibility;

            if (segment2 >= segment1 && segment2 >= segment3)
                max = segment2;
            else if (segment3 >= segment1 && segment3 >= segment2)
                max = segment3;


            if (segment1 == max)
            {
                Console.WriteLine(segment2 + segment3 > max ? "ok" : "nie ok");
            }
            else if (segment2 == max)
            {
                Console.WriteLine(segment3 + segment1 > max ? "ok" : "nie ok");
            }
            else
                Console.WriteLine(segment1 + segment2 > max ? "ok" : "nie ok");

        }

        public static void Ex11()
        {
            int intMark = 3;
            string stringMark;

            stringMark = intMark switch
            {
                1 => "Niedostateczny",
                2 => "Dopuszczający",
                3 => "Dostateczny",
                4 => "Dobry",
                5 => "Bardzo dobry",
                6 => "Celujący",
                _ => "Coś nie teges"
            };

            Console.WriteLine(stringMark);
        }

        public static void Ex12()
        {
            int intDayOfTheWeek = 3;
            string stringDayfTheWeek;

            stringDayfTheWeek = intDayOfTheWeek switch
            {
                1 => "Poniedziałek",
                2 => "Wtorek",
                3 => "Środa",
                4 => "Czwartek",
                5 => "Piątek",
                6 => "Sobota",
                7 => "Niedziela",
                _ => "Coś nie teges"
            };

            Console.WriteLine(stringDayfTheWeek);
        }

        public static void Ex13()
        {
            Console.Write("Podaj pierwaszą liczbę: ");
            double firstNumb = double.Parse(Console.ReadLine());
            Console.Write("Podaj drugą liczbę: ");
            double secondNumb = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj numer operacji do wykonania:");
            Console.WriteLine("1. Dodawanie");
            Console.WriteLine("2. Odejmowanie");
            Console.WriteLine("3. Mnożenie");
            Console.WriteLine("4. Dzielenie");
            int chosenOperator = int.Parse(Console.ReadLine());

            double score;

            score = chosenOperator switch
            {
                1 => firstNumb + secondNumb,
                2 => firstNumb - secondNumb,
                3 => firstNumb * secondNumb,
                4 => firstNumb / secondNumb,
                _ => throw new Exception()
            };

            Console.WriteLine(score);
        }
    }
}