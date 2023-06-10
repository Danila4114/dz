// задача 2
Console.WriteLine("Введите первое число: ");
            int num_A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число: ");
            int num_B = Convert.ToInt32(Console.ReadLine());

            if (num_A > num_B)
            {
                Console.WriteLine("Первое число " + num_A + " больше чем второе " + num_B);
            }
            else
            {
                Console.WriteLine("Второе число " + num_B + " больше чем первое " + num_A);
            }

// задача 4
Console.WriteLine("Введите 3 числа:");
            int num_1 = Convert.ToInt32(Console.ReadLine());
            int num_2 = Convert.ToInt32(Console.ReadLine());
            int num_3 = Convert.ToInt32(Console.ReadLine());

            int max = num_1;

            if (num_2 > max)
            {
                max = num_2;
            }

            if (num_3 > max)
            {
                max = num_3;
            }

            Console.WriteLine("Наибольшее из введённых чисел -> " + max);

//задача 6
Console.WriteLine("Введите число:");
            num_1 = Convert.ToInt32(Console.ReadLine());

            if (num_1 % 2 == 1)
            {
                Console.WriteLine("Число " + num_1 + " является: НЕЧЁТНЫМ");
            }
            else
            {
                Console.WriteLine("Число " + num_2 + "является: ЧЁТНЫМ");
            }
//задача 8
 int i = 1;
            bool not = true;

            Console.WriteLine("Введите число:");
            num_1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Чётные числа от 1 до " + num_1);
            while (i <= num_2)
            {
                if (i % 2 != 1)
                {
                    Console.Write(i + ", ");
                    not = false;
                }
                i++;
            }

            if (not)
            {
                Console.WriteLine("Нет чётных чисел!");
            }
