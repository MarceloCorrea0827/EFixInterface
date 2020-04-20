using System;
using System.Globalization;
using EFixInterface.Entities;
using EFixInterface.Services;

namespace EFixInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter contract data");
            System.Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            System.Console.Write("Date (dd/mm/yyyy): ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            System.Console.Write("Contract value: ");
            double amount = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            // Instanciando Contrato
            Contract contrato = new Contract(number, date, amount);
            
            System.Console.Write("Enter number of installments: ");
            int quotes = int.Parse(Console.ReadLine());
            // Instanciando ProcessContract
            ProcessContract processContract = new ProcessContract(quotes, new Paypal());
            // Criando as Parcelas dos Contratos
            processContract.processInstallments(contrato);

            System.Console.WriteLine("Installments:");
            Console.WriteLine(contrato);
        }
    }
}