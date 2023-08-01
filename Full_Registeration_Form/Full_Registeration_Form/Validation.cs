using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Full_Registeration_Form
{
    class Validation
    {
        string _passs;
        #region First Name And Last Name  Validation
        public bool FirstName(string fna)
        {
            bool flage = false;
            string pattern = "^[A-Za-z]*$";
            if (Regex.IsMatch(fna, pattern))
            {
                if (!(fna == string.Empty || fna.Length <= 5))
                {
                    if (fna.Length > 5)
                    {
                        flage = true;
                    }
                }
            }
            if (flage == true) { return true; }
            else { return false; }
        }
        public string FirstnameError(string fnamee)
        {
            bool vali = FirstName(fnamee);
            if (!vali)
            {
                return "First Name Not Valid";
            }
            else
            {
                return "";
            }
        }
        public string LastnameError(string fnamee)
        {
            bool vali = FirstName(fnamee);
            if (!vali)
            {
                return "Last Name Not Valid";
            }
            else
            {
                return "";
            }
        }
        #endregion


        #region Email Validation
        public bool Email(string emaill)
        {
            bool flage = false;
            string pattern = @"^[A-Za-z0-9._%+-]+@gmail\.com$";
            if (Regex.IsMatch(emaill, pattern))
            {
                if (!(emaill == string.Empty))
                {
                    flage = true;
                }
            }
            if (flage == true) { return true; }
            else { return false; }
        }
        public string EmailError(string emailll)
        {
            bool vali = Email(emailll);
            if (!vali)
            {
                return "Email Not Valid";
            }
            else
            {
                return "";
            }
        }
        #endregion


        #region Password and Confirmation Password Validation
        public bool Password(string pass)
        {
            _passs = pass;
            bool flage = false;

            if (pass.Length>=8)
            {
                flage = true;
            }
            if (flage == true) { return true; }
            else { return false; }
        }
        public string passwoedError(string pass)
        {
            bool vali = Password(pass);
            if (!vali)
            {
                return "Password Not Valid";
            }
            else
            {
                return "";
            }
        }
        public string passwoedConfirmationError(string pass,string pass2)
        {
            bool vali = Password(pass);
            if (pass2 == pass && !(pass.Length<8))
            {
                return "";
            }
            else
            {
                return "Password con Not Valid";
            }
        }
        #endregion


        #region Mobile Validation
        public bool Molbile(string mob)
        {
            long x;
            bool flage = false;
            bool valid = long.TryParse(mob, out x);
            if (mob.Length==11 && valid)
            {
                flage = true;
            }
            if (flage == true) { return true; }
            else { return false; }
        }
        public string mobileError(string mobile)
        {
            bool vali = Molbile(mobile);
            if (!vali)
            {
                return "Monile Not Valid";
            }
            else
            {
                return "";
            }
        }
        #endregion


        #region Address Validation
        public bool Address(string add)
        {
            bool flage = false;

            if (!(add==string.Empty))
            {
                flage = true;
            }
            if (flage == true) { return true; }
            else { return false; }
        }
        public string AddressError(string mobile)
        {
            bool vali = Address(mobile);
            if (!vali)
            {
                return "Address Not Valid";
            }
            else
            {
                return "";
            }
        }
        #endregion


    }
}
