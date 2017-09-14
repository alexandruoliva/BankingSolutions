using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect
{
    class Credits
    { // ai venituri permanente? nu ai restante la alte credite,
        private string creditType;
        private int creditAmount;
        private string creditCurrency;
        private int loanDuration;
        private Boolean isEligible;
        private UserAccount currentUser;


        public Credits(UserAccount currentUser, string creditType, int creditAmount, string creditCurrency, int loanDuration)
        {
            this.currentUser = currentUser;
            this.creditType = creditType;
            this.creditAmount = creditAmount;
            this.creditCurrency = creditCurrency;
            this.loanDuration = loanDuration;
        }

        public void getEligiablility()
        {

        }
    }
}
