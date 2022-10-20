 int n = int.Parse(Console.ReadLine());
        int count = 0;
 
        for (int i = 1; i <= n; i++) {

            if (n % i == 0    ) {
                count++;
            }
            if (count >  n    ) {
                Console.WriteLine(false);
            }
        }
         Console.WriteLine(count == 3);