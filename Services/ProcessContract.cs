using System;
using EFixInterface.Entities;
using EFixInterface.Interfaces;

namespace EFixInterface.Services
{
    class ProcessContract
    {
        public int Quotes { get; set; }
        private IPaymentInstallment _paymentInstallment; // Interface

        public ProcessContract(int quotes, IPaymentInstallment paymentInstallment)
        {
            Quotes = quotes;
            _paymentInstallment = paymentInstallment;
        }

        public void processInstallments(Contract contract)
        {
            double basicQuote = (contract.Amount / Quotes);

            for (int quote=1; quote<=Quotes; quote++)
            {
                DateTime date = contract.Date.AddMonths(quote);
                double updateQuote = basicQuote + _paymentInstallment.Tax(basicQuote, quote);
                double fullQuote = updateQuote + _paymentInstallment.SimpleInterest(updateQuote);

                contract.addInstallment(new Installment(date, fullQuote));
            }
        }
    }
}