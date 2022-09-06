namespace PM02
{
    internal class Program
    {
        const double ProcBank = 0.08;

        private static double getProcent(double cash)
        {
            double money = 0;
            double procent = 0;
            while (money <= cash)
            {
                if (cash >= 700000 && cash <= 749999.99)
                {
                    procent = 0.2;
                    break;
                }

                if (money == 700000)
                {
                    procent = 0.2;
                    money += 50000;
                    continue;
                }