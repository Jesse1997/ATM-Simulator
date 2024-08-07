namespace ATM_Sim.Extensions
{
    public static class DoubleExtensions
    {
        public static string EurosToString(this double value)
        {
            return value.ToString("0.00");
        }

        public static int EurosToCents(this double value)
        {
            return (int)(value * 100);
        }
    }
}
