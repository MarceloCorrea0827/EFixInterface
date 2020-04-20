using EFixInterface.Entities;

namespace EFixInterface.Services
{
    class ProcessContract
    {
        public int numberOfMonths { get; set; }

        public ProcessContract(int numberOfMonths)
        {
            this.numberOfMonths = numberOfMonths;
        }

        public void processInstallments(Contract contract)
        {

        }
    }
}
