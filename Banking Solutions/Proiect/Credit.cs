using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSolutions
{
    class Credit
    { // ai venituri permanente? nu ai restante la alte credite,
        private string creditType;
        private string creditTypeOption;
        private uint creditAmount;
        private string creditCurrency;
        private uint creditDuration;
        private Boolean isEligible;
        
        private uint creditRate;
        private uint annualIntrest;


        public Credit(string creditType, string creditTypeOption, uint creditAmount, string creditCurrency, uint loanDuration)
        {
            this.creditType = creditType;
            this.creditTypeOption = creditTypeOption;
            this.creditAmount = creditAmount;
            this.creditCurrency = creditCurrency;
            this.creditDuration = loanDuration;

            
        }

        public void getEligiablility()
        {

        }

        

        
    }
}
