using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect
{
    class UserAccount
    {
        private uint clientId;
        private uint accountId;
        private string clientType;
        private string password;
        private string loginId;
        private string name;
        private string surname;
        private string CNP;
        private short age;
        private string address;
        private uint income;
        private string incomeCurrency;
        private char sex;
        private List<Credits> credit;

        public UserAccount(uint clientId, uint accountId, string loginId, string password, string clientType,
                             string name, string surname, string CNP, short age, string address,
                             uint income, string incomeCurrency, char sex,List<Credits> credit)
        {
            this.clientId = clientId;
            this.accountId = accountId;
            this.loginId = loginId;
            this.password = password;
            this.clientType = clientType;
            this.name = name;
            this.surname = surname;
            this.CNP = CNP;
            this.age = age;
            this.income = income;
            this.incomeCurrency = incomeCurrency;
            this.sex = sex;
            this.credit = credit;
        }
        public uint ClientId
        {
            get
            {
                return clientId;
            }

            set
            {
                clientId = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Surname
        {
            get
            {
                return surname;
            }

            set
            {
                surname = value;
            }
        }

        public string CNP1
        {
            get
            {
                return CNP;
            }

            set
            {
                CNP = value;
            }
        }

        public short Age
        {
            get
            {
                return age;
            }

            set
            {
                age = value;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public uint Income
        {
            get
            {
                return income;
            }

            set
            {
                income = value;
            }
        }

        public string IncomeCurrency
        {
            get
            {
                return incomeCurrency;
            }

            set
            {
                incomeCurrency = value;
            }
        }

        public string ClientType
        {
            get
            {
                return clientType;
            }

            set
            {
                clientType = value;
            }
        }

        public char Sex
        {
            get
            {
                return sex;
            }

            set
            {
                sex = value;
            }
        }

        public uint AccountId
        {
            get
            {
                return accountId;
            }

            set
            {
                accountId = value;
            }
        }

        public string LoginId
        {
            get
            {
                return loginId;
            }

            set
            {
                loginId = value;
            }
        }

    }
}
