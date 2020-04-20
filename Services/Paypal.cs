using EFixInterface.Interfaces;

namespace EFixInterface.Services
{
    class Paypal : IPaymentInstallment
    {
        public double Tax(double amount, int quote)
        {
            return (amount * 0.01 * quote);
        }
        public double SimpleInterest(double amount)
        {
            return (amount * 0.02);
        }
    }
}