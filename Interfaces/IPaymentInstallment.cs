namespace EFixInterface.Interfaces
{
    interface IPaymentInstallment
    {
        public double Tax(double amount, int quote);
        public double SimpleInterest(double amount);
    }
}