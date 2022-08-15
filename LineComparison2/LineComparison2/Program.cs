namespace LineComparison2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LenghthCalculation lenghth = new LenghthCalculation();
            lenghth.Calculation();

            CheckEquality check = new CheckEquality();
            check.Equality();

        }
    }
}
