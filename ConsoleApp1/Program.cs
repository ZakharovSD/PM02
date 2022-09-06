namespace PM02
{
    internal class Program
    {
        const double StavkaBank = 0.08;

        private static double getProcent(double cash)
        {
            double dengi = 0;
            double stavka = 0;



            while (dengi <= cash)
            {



                if (dengi == 700000)
                {
                    stavka = 0.2;
                    dengi += 50000;
                    continue;
                }



                if (cash >= 700000 && cash <= 749999.99)
                {
                    stavka = 0.2;
                    break;
                }



                if (dengi < 750000)
                {
                    dengi += 49999.99;
                    stavka += 0.01;
                    dengi += 0.01;
                }



                else
                {
                    dengi += 49999.99;
                    stavka -= 0.01;
                    dengi += 0.01;
                }
            }



            return Math.Round(stavka, 2);



        }
    }
    private static double getMoney(double cash, double stavka, int years)
    {



        for (int i = 1; i <= years * 12; i++)
        {



            if (i % 3 == 0)
            {
                stavka += 0.005;
            }



            if (stavka - StavkaBank > 5)
            {
                cash += cash * stavka * 0.7;
            }



            else
            {
                cash += cash * stavka;
            }
        }



        return Math.Round(cash, 2);



    }
}