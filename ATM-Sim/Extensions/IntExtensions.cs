namespace ATM_Sim.Helpers
{
    public static class IntExtensions
    {
        public static double ConvertCentsToEuros(this int cents)
        {
            return (double)cents / 100;
        }
    }
}
