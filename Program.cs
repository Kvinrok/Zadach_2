Console.WriteLine("Введите первое число: ");
            int num_A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число: ");
            int num_B = Convert.ToInt32(Console.ReadLine());

            if (num_A > num_B)
            {
                Console.WriteLine("Первое число большее " + num_A + "  второе число меньшее " + num_B);
            }
            else
            {
                Console.WriteLine("Второе число большее " + num_B + " первое число меньшее " + num_A);
            }