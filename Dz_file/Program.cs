using System;
namespace Dz_File
{
    class Dz_file
    {
        static void Main()
        {
            while (true)
            {
                Console.Write("Введите номер задания: ");
                int num_zad = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                Console.WriteLine($"Задание #{num_zad}");
                typeof(Dz_file).GetMethod($"zad{num_zad}").Invoke(null, null);
                Console.Write("\nНажмите Enter для продолжения или напишите 1 для выхода: ");
                try
                {
                    int prod = Convert.ToInt32(Console.ReadLine());
                    return;
                }
                catch
                {
                    Console.Clear();
                    continue;
                }
            }
        }
        public static void zad1()
        {
            //Задание 1. Вывести на экран число e (основание натурального логарифма) с точностью до десятых.
            Console.WriteLine(string.Format("{0:F1}", Math.E));
        }
        public static void zad2()
        {
            //Задание 2. Вывести на экран числа 50 и 10 одно под другим.
            Console.WriteLine($"{50}\n{10}");

        }
        public static void zad3()
        {
            //Задание 3. Составить программу вывода на экран «столбиком» четырех любых чисел.
            Console.WriteLine($"{321}\n{44543}\n{127}\n{579}");
        }
        public static void zad4()
        {
            //Задание 4. Пользователь вводит число. Выведите на экран число, которое больше введенного на 10.
            Console.Write("Введите число: ");
            Console.WriteLine(Convert.ToSingle(Console.ReadLine()) + 10);
        }
        public static void zad5()
        {
            //Задание 5. Дана сторона квадрата. Найти его периметр.
            Console.Write("Укажите длину стороны квадрата: ");
            Console.WriteLine($"Периметр = {Convert.ToSingle(Console.ReadLine()) * 4}");
        }
        public static void zad6()
        {
            //Задание 6. Дан радиус окружности. Найти длину окружности и площадь круга.
            Console.Write("Введите радиус окружности: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Периметр = {2 * Math.PI * a}, Площадь = {Math.PI * Math.Pow(a, 2)}");
        }
        public static void zad7()
        {
            //Задание 7. Найти значение y=cos(x)
            Console.Write("Введите число x: ");
            Console.WriteLine(Math.Cos(Convert.ToDouble(Console.ReadLine()) * (Math.PI / 180)));
        }
        public static void zad8()
        {
            //Задание 8. Даны основания и высота равнобедренной трапеции. Найти ее периметр.
            Console.Write("Укажите длину первого основания: ");
            double a1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Укажите длину второго основания: ");
            double a2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Укажите высоту трапеции: ");
            double h = Convert.ToDouble(Console.ReadLine());
            double bokstrn = Math.Sqrt((Math.Pow(Convert.ToDouble(Math.Abs(a1 - a2)), 2) / 4) + Math.Pow(h, 2));
            Console.WriteLine($"Периметр = {a1 + a2 + bokstrn * 2}");
        }
        public static void zad9()
        {
            //Задание 9. Известна стоимость 1 кг конфет, печенья и яблок. Найти стоимость всей покупки, если купили x кг конфет, у кг печенья и z кг яблок.
            Console.Write("Укажите стоимость 1 кг конфет: ");
            double cen_kon = Convert.ToDouble(Console.ReadLine());
            Console.Write("Укажите стоимость 1 кг печенья: ");
            double cen_pech = Convert.ToDouble(Console.ReadLine());
            Console.Write("Укажите стоимость 1 кг яблок: ");
            double cen_yab = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите количество кг конфет: ");
            double kol_kon = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите количество кг печенья: ");
            double kol_pech = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите количество кг яблок: ");
            double kol_yab = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Стоимость всей покупки: {kol_kon * cen_kon + kol_pech * cen_pech + kol_yab * cen_yab}");
        }
        public static void zad10()
        {
            /*Задание 10. Напишите программу, выводит на экран три строки "Мир", "Труд" и "Май"
            (кавычки не нужны). Причём сделайте, чтобы выводилось сначала так:
            Мир Труд Май
            Затем так:
            Мир
                 Труд
                       Май*/

            Console.WriteLine("Мир Труд Май");
            Console.WriteLine("Мир\n\tТруд\n\t\tМай");
        }
        public static void zad11()
        {
            /*Задание 11. Программа просит пользователя ввести 2 числовые переменные. А после она
            меняет их местами и выводит результат на экран. Но, так как пользователь может
            ошибиться, необходимо предусмотреть тот факт, что пользователь может ввести,
            например, букву или строку, а так же учесть, что число может быть дробным, и для
            выделения её дробной части одни используют точку, другие – запятую.*/
            try
            {
                Console.Write("Введите первое число: ");
                double x = Convert.ToDouble(Console.ReadLine().Replace(".", ","));
                Console.Write("Введите второе число: ");
                double y = Convert.ToDouble(Console.ReadLine().Replace(".", ","));
                Console.WriteLine($"{y} {x}");
            }
            catch
            {
                Console.WriteLine("Число введено неправильно");
            }
        }
        public static void zad12()
        {
            /*Задание 12. Программа для подсчета периметра и площади фигур (треугольник,
            четырехугольник, круг). Пользователь выбирает фигуру, указывает, что программа
            будет считать – площадь или периметр. Задаётся все необходимые значения, а на
            основе полученных результатов, программа должна подсчитать, какими могли бы
            быть периметры или площади остальных фигур.*/
            Console.WriteLine("Выберите фигуру: \n 1.Треугольник \n 2.Прямоугольник \n 3.Круг");
            string ch1 = Console.ReadLine();
            Console.WriteLine("Выберите,что нужно считать: \n 1.Периметр \n 2.Площадь");
            string ch2 = Console.ReadLine();
            switch (ch1)
            {
                case "1":
                    if (ch2 == "1")
                    {
                        Console.Write("Введите длину 1-ой стороны: ");
                        double a1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Введите длину 2-ой стороны: ");
                        double b1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Введите длину 3-ей стороны: ");
                        double c1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"Периметр треугольника = {a1 + b1 + c1}");
                    }
                    else if (ch2 == "2")
                    {
                        Console.Write("Введите длину основания: ");
                        double a2 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Введите длину высоты: ");
                        double h2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"Площадь треугольника = {a2 * h2 / 2}");
                    }
                    break;
                case "2":
                    Console.Write("Введите длину 1-ой стороны: ");
                    double a3 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите длину 2-ой стороны: ");
                    double b3 = Convert.ToDouble(Console.ReadLine());
                    if (ch2 == "1")
                    {
                        Console.WriteLine($"Периметр прямоугольника = {(a3 + b3) * 2}");
                    }
                    else if (ch2 == "2")
                    {
                        Console.WriteLine($"Площадь прямоугольника = {a3 * b3}");
                    }
                    break;
                case "3":
                    Console.Write("Введите радиус окружности: ");
                    double r4 = Convert.ToDouble(Console.ReadLine());
                    if (ch2 == "1")
                    {
                        Console.WriteLine($"Длина окружности = {2 * r4 * Math.PI}");
                    }
                    else if (ch2 == "2")
                    {
                        Console.WriteLine($"Площадь круга = {r4 * r4 * Math.PI}");
                    }
                    break;
            }
        }
        public static void zad13()
        {
            /*Задание 13. Составить программу вывода на экран числа, вводимого с клавиатуры. Вводимому
            числу должно предшествовать сообщение «Вы ввели число».*/
            Console.Write("Введите число: ");
            Console.WriteLine($"Вы ввели число {Convert.ToDouble(Console.ReadLine())}");
        }
        public static void zad14()
        {
            /*Задание 14. Составить программу вывода на экран следующей информации:
            2 кг
            13 17.*/
            Console.WriteLine("2 кг \n13 17");
        }
        public static void zad15()
        {
            /*Задание 15. Составить программу вывода на экран «столбиком» четырех случайных чисел.*/
            Random rand_num = new Random();
            Console.WriteLine(rand_num.Next(1, 100));
            Console.WriteLine(rand_num.Next(1, 100));
            Console.WriteLine(rand_num.Next(1, 100));
            Console.WriteLine(rand_num.Next(1, 100));
        }
        public static void zad16()
        {
            /*Задание 16. Найти корни квадратного уравнения(коэффициента задаются пользователем с
            клавиатуры).*/
            Console.Write("Напишите первый коэффициент уравнения: ");
            double a4 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Напишите второй коэффициент уравнения: ");
            double b4 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Напишите третий коэффициент уравнения: ");
            double c4 = Convert.ToSingle(Console.ReadLine());
            double disc = (b4 * b4 - 4 * a4 * c4);
            if (disc < 0)
            {
                Console.WriteLine("Дискриминант меньше нуля, корней нет");
            }
            else
            {
                if (disc == 0)
                {
                    Console.WriteLine(-b4 / (2 * a4));
                }
                else
                {
                    Console.WriteLine((-b4 + Math.Pow(disc, 0.5)) / (2 * a4));
                    Console.WriteLine((-b4 - Math.Pow(disc, 0.5)) / (2 * a4));
                }

            }
        }
        public static void zad17()
        {
            /*Даны два целых числа. Найти: а) их среднее арифметическое; б) их среднее
            геометрическое.*/
            Console.Write("Введите первое число: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите второе число: ");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Среднее арифметическое = {(x + y) / 2}\nСреднее геометрическое = {Math.Sqrt(x * y)}");
        }
        public static void zad18()
        {
            /*Известны координаты на плоскости двух точек. Составить программу вычисления
            расстояния между ними.*/
            Console.Write("Введите координату x первой точки: ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите координату y первой точки: ");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите координату x второй точки: ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите координату y второй точки: ");
            double y2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Расстояние между ними = {Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2))}");
        }
        public static void zad19()
        {
            /*Задание 19. Составить программу обмена значениями трех переменных величин а, b, c по
            следующим двум схемам:
            а) b присвоить значение c, а присвоить значение b, с присвоить значение а;
            б) b присвоить значение а, с присвоить значение b, а присвоить значение с.*/
            Console.Write("Введите значение переменной а: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение переменной b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение переменной c: ");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"а)а = {b}, b = {c}, c = {a}");
            Console.WriteLine($"а)а = {c}, b = {a}, c = {b}");
        }
        public static void zad20()
        {
            /*Задание 20. С начала суток прошло n секунд. Определить:
            а) сколько полных часов прошло с начала суток;
            б) сколько полных минут прошло с начала очередного часа;
            в) сколько полных секунд прошло с начала очередной минуты.*/
            Console.Write("Введите сколько секунд прошло с начала суток: ");
            int sec = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"а)Прошло {sec / 3600} полных часов\nб)Прошло {sec % 3600 / 60} полных минут\nв)Прошло {sec % 3600 % 60} полных секунд");
        }
        public static void zad21()
        {
            /*Задание 21. Дан прямоугольник с размерами 543 х 130 мм. Сколько квадратов со стороной 130
            мм можно отрезать от него?*/
            Console.WriteLine($"От данного прямоугольника можно отрезать {543 / 130} квадратов");

        }
        public static void zad22()
        {
            /*Задание 22. Дано трехзначное число. В нем зачеркнули последнюю справа цифру и приписали
            ее в начале. Найти полученное число.*/
            Console.Write("Введите трехзначное число: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Результат: {n % 10}{n / 10}");
        }
        public static void zad23()
        {
            /*Задание 23. Дано натуральное число n (n > 999). Найти:
            а) число сотен в нем;
            б) число тысяч в нем.*/
            Console.Write("Введите число большее 999: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"а)Количество сотен: {n / 100}\n б) Количество тысяч: {n / 1000}");
        }
        public static void zad24()
        {
            /*Задание 24. Дано четырехзначное число. Найти:
            а) число, полученное при прочтении его цифр справа налево;
            б) число, образуемое при перестановке первой и второй, третьей и четвертой цифр
            заданного числа. Например, из числа 5434 получить 4543, из числа 7048 — 784;
            в) число, образуемое при перестановке второй и третьей цифр заданного числа.
            Например, из числа 5084 получить 5804;
            г) число, образуемое при перестановке двух первых и двух последних цифр
            заданного числа. Например, из числа 4566 получить 6645, из числа 7304 — 473.*/
            Console.Write("Введите четырехзначное число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"а){a % 10}{a % 100 / 10}{a % 1000 / 100}{a / 1000}\nб){Convert.ToInt32($"{a % 1000 / 100}{a / 1000}{a % 10}{a % 100 / 10}")}" +
                $"\nв){a / 1000}{a % 100 / 10}{a % 1000 / 100}{a % 10}\nг){Convert.ToInt32($"{a % 100 / 10}{a % 10}{a / 1000}{a % 1000 / 100}")}");
        }
        public static void zad25()
        {
            /*Задание 25. Из трехзначного числа x вычли его последнюю цифру. Когда результат разделили
            на 10, а к частному слева приписали последнюю цифру числа x, то получилось
            число n. Найти число x. Значение n вводится с клавиатуры, 100 ≤ n ≤ 999 и при этом
            число десятков в n не равно нулю.*/
            Console.Write("Введите трехзначное число: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{n % 100}{n / 100}");
        }
        public static void zad26()
        {
            /*Задание 26. Даны целые числа h, m, s (0 ≤ h ≤ 23, 0 ≤ m ≤ 59, 0 ≤ s ≤ 59), указывающие момент
            времени: «h часов, m минут, s секунд». Определить угол (в градусах) между
            положением часовой стрелки в начале суток и в указанный момент времени.*/
            Console.Write("Введите число часов(h): ");
            double h = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите число минут(m): ");
            double m = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите число секунд(s): ");
            double s = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Угол = {(((h + m / 60 + s / 3600) / 12) * 360)}");
        }
        public static void zad27()
        {
            /*27. Часовая стрелка образует угол y с лучом, проходящим через центр и через точку,
            соответствующую 12 часам на циферблате, 0 ≤ y ≤ 2 . Определить значение угла для
            минутной стрелки, а также количество полных часов и полных минут.*/
            Console.Write("Введите угол между минутной стрелкой и лучом: ");
            double hu = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Угол для минутной стрелки: {Convert.ToDouble(Math.Floor((((180 / Math.PI) * hu) / (360 / 12)) * 60)) % 60 / 60 * 360}" +
                $" \nПрошло {Math.Floor(((180 / Math.PI) * hu) / (360 / 12))} полных часов и {Math.Floor((((180 / Math.PI) * hu)/*паскхалка*/ / (360 / 12)) * 60)} минут");
        }
        public static void zad28()
        {
            /*Задание 28. Создать программу, которая будет выводить на экран меньшее по модулю из трёх
            введённых пользователем вещественных чисел */
            Console.Write("Введите первое число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите третье число: ");
            int c = Convert.ToInt32(Console.ReadLine());
            int[] d = { Math.Abs(a), Math.Abs(b), Math.Abs(c) };
            int min = d.Min();
            if (Math.Abs(a) == min)
            {
                Console.WriteLine(a);
            }
            if (Math.Abs(b) == min)
            {
                Console.WriteLine(b);
            }
            if (Math.Abs(c) == min)
            {
                Console.WriteLine(c);
            }
        }
        public static void zad29()
        {
            /*Задание 29. Найти сумму большего и меньшего из трёх заданных чисел*/
            Console.Write("Введите первое число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите третье число: ");
            int c = Convert.ToInt32(Console.ReadLine());
            int[] d = { a, b, c };
            Console.WriteLine(d.Max() + d.Min());
        }
        public static void zad30()
        {
            /*Задание 30. Подсчитать общее количество делителей натурального числа*/
            Console.Write("Введите натуральное число: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int res = 0;
            for (int j = 1; (j <= n); j += 1)
            {
                if (n % j == 0)
                {
                    res += 1;
                }
            }
            Console.WriteLine($"Количество делителей числа {n} = {res}");
        }
        public static void zad31()
        {
            /*Задание 31. Вася в школе изучил квадратные уравнения и понял, как они легко решаются путем
            вычисления дискриминанта. Но Петя поведал ему о методе решения кубических
            уравнений вида A*X3 + B*X2 + C*X + D = 0. На факультативе по математике Васе
            задали решить около ста уравнений как раз такого вида. Но, к сожалению, Вася
            забыл формулы, о которых рассказывал ему Петя. Но Васе было известно, что все
            корни уравнений – целые числа и находятся на отрезке [-100, 100]. Поэтому у Васи
            есть шанс найти их методом перебора, но для этого ему придется затратить уйму
            времени, т.к. возможно необходимо будет осуществить перебор нескольких тысяч
            значений. Помогите Васе написать программу, которая поможет ему найти корни
            кубических уравнений!*/
            Console.Write("Напишите коэффициент A: ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.Write("Напишите коэффициент B: ");
            int B = Convert.ToInt32(Console.ReadLine());
            Console.Write("Напишите коэффициент C: ");
            int C = Convert.ToInt32(Console.ReadLine());
            Console.Write("Напишите коэффициент D: ");
            int D = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Корни уравнения:");
            for (int i = -100; i <= 100; i++)
            {
                if ((A * Math.Pow(i, 3) + B * Math.Pow(i, 2) + C * i + D) == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        public static void zad32()
        {
            /*Задание 32. Заданы первый и второй элементы арифметической прогрессии. Требуется
            написать программу, которая вычислит элемент прогрессии по ее номеру.*/
            Console.Write("Напишите первый элемент прогрессии: ");
            int a1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Напишите второй элемент прогрессии: ");
            int a2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Напишите какой по номеру элемент необходим: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a1 + ((a2 - a1) * (n - 1)));
        }
        public static void zad33()
        {
            /*Задание 33. Если я пенсионер или студент и не трудоустроен, то получаю кредит, а если
            трудоустроен не получаю кредит. Ну а если я, и пенсионер и
            студент,(трудоустройство тут не имеет значения) то не должен получить.
            Необходимо вводить строки, содержащие информацию о том, студент, пенсионер
            или кто-то ещё. Вывести информацию: дадут кредит или нет.*/
            Console.Write("Вы студент(Да/Нет):");
            string isstd = Convert.ToString(Console.ReadLine());
            Console.Write("Вы пенсионер(Да/Нет):");
            string ispens = Convert.ToString(Console.ReadLine());
            Console.Write("Вы трудоустроен(Да/Нет):");
            string istrud = Convert.ToString(Console.ReadLine());
            if (isstd == "Да" || ispens == "Да" && istrud == "Нет" && ispens != isstd)
            {
                Console.WriteLine("Вам дадут кредит");
            }
            else if (isstd == "Нет" && ispens == "Нет")
            {
                Console.WriteLine("Вы не человек");/*пасхалка*/

            }
            else
            {
                Console.WriteLine("Вам не дадут кредит");
            }
        }
        public static void zad34()
        {
            /*Задание 34. Составить программу, которая:
            а) запрашивает имя человека и повторяет его на экране;
            б) запрашивает имя человека и повторяет его на экране с приветствием.*/
            Console.Write("Введите ваше имя: ");
            string name = Convert.ToString(Console.ReadLine());
            Console.WriteLine($"а){name}\nб)Привет,{name}");
        }
        public static void zad35()
        {
            /*Задание 35. Воспроизвести разговор Гарри и дневника Тома Реддла. Пользователь здоровается с
            консолью. Консоль спрашивает, как зовут пользователя. Пользователь называет
            имя. Консоль пишет: привет, <имя пользователя>. После этого пользователь
            спрашивает, знает ли консоль что-то о тайной комнате. Консоль отвечает «Да».
            После этого пользователь спрашивает, может ли рассказать. Консоль отвечает
            «Нет». Спустя 5 секунд консоль дополняет «но могу показать». Консоль меняет
            цвет на любой случайный цвет.*/
            Console.ReadLine();
            Console.WriteLine("Как тебя зовут?");
            string name = Convert.ToString(Console.ReadLine());
            Console.WriteLine($"Привет, {name}");
            Console.ReadLine();
            Console.WriteLine("Да");
            Console.ReadLine();
            Console.WriteLine("Нет");
            Thread.Sleep(5000);
            Console.WriteLine("Но могу показать");
            Thread.Sleep(1000);
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
        }
        public static void zad36()
        {
            /*Задание 36. Вычислить контрольную цифру штрихкода(EAN13).
            a. 12 цифр определяются случайным образом.
            b. 12 цифр вводит пользователь*/
            Console.Write("Введите 12 цифр штрихкода: ");
            var kod = Convert.ToString(Console.ReadLine()).ToList();
            int nechet_sum = 0;
            int chet_sum = 0;
            string kod2 = "";
            Random rand_kod = new Random();
            for (int i = 0; i <= 11; i++)
            {
                if (i % 2 == 0)
                {
                    nechet_sum += Convert.ToInt32(Convert.ToString(kod[i]));
                }
                else
                {
                    chet_sum += Convert.ToInt32(Convert.ToString(kod[i]));
                }
            }
            Console.WriteLine($"Контрольная цифра = {(10 - ((chet_sum * 3 + nechet_sum) % 10)) % 10}");
            for (int i = 0; i < 12; i++)
            {
                int digit = rand_kod.Next(0, 10);
                kod2 += Convert.ToString(digit);
            }
            var kod3 = kod2.ToList();
            int chet_sum_rand = 0;
            int nechet_sum_rand = 0;
            for (int i = 0; i <= 11; i++)
            {
                if (i % 2 == 0)
                {
                    nechet_sum_rand += Convert.ToInt32(Convert.ToString(kod3[i]));
                }
                else
                {
                    chet_sum_rand += Convert.ToInt32(Convert.ToString(kod3[i]));
                }
            }
            Console.WriteLine($"Контрольная цифра = {(10 - ((chet_sum_rand * 3 + nechet_sum_rand) % 10)) % 10} Для числа {kod2}");
        }
    }
}
