using EFixInterface.Interfaces;

namespace EFixInterface.Services
{
    class Paypal : IPaymentInstallment
    {
        private const double FeePercentage = 0.02;
        private const double MonthlyInterest = 0.01;
        public double Tax(double amount, int quote)
        {
            return (amount * MonthlyInterest * quote);
        }
        public double SimpleInterest(double amount)
        {
            return (amount * FeePercentage);
        }
    }
}