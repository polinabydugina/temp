using System;

        while (true)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            if (n > 3)
            {
                int[] temps = new int[n];
                for (int i = 0; i < n; i++)
                {
                temps[i] = Convert.ToInt32(Console.ReadLine());
                }

                for (int i = 1; i < n - 1; i++)
                {
                    if (temps[i] > temps[i - 1] && temps[i] > temps[i + 1])
                    {
                    Console.WriteLine("day {0} : {1} (max)", i + 1, temps[i]);
                    }
                    if (temps[i] < temps[i - 1] && temps[i] < temps[i + 1])
                    {
                        Console.WriteLine("day {0} : {1} (min)", i + 1, temps[i]);
                    }
                }
            }
            else
            {
                Console.WriteLine("Число дней не должно быть меньше 3");
            }
        }