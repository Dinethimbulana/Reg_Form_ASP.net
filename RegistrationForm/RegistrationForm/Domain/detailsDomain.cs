using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RegistrationForm.Domain
{
    public class detailsDomain
    {
        #region Values

        private string fName;

        private string lName;

        private string email;

        private string gender;

        private string address;

        private string pNo;

        private string password;

        private string confirmPassword;

        #endregion

        #region Details

        public string FName
        {
            get { return fName; }
            set { fName = value; }
        }

        public string LName
        {
            get { return lName; }
            set { lName = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string PNo
        {
            get { return pNo; }
            set { pNo = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string ConfirmPassword
        {
            get { return confirmPassword; }
            set { confirmPassword = value; }
        }


        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        #endregion
    }
}