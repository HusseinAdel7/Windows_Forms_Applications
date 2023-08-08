using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Dealing_With_DataGridView
{
    class Validation
    {

        #region Id Validation
        public bool Id(string id)
        {
            int x;
            bool flage = false;
            bool valid = int.TryParse(id, out x);
            if (id.Length >= 1 && valid)
            {
                flage = true;
            }
            if (flage == true) { return true; }
            else { return false; }
        }
        public string IdError(string id)
        {
            bool vali = Id(id);
            if (!vali)
            {
                return "InValid Id";
            }
            else
            {
                return "";
            }
        }
        #endregion


        #region  Name Validation
        public bool Name(string name)
        {
            bool flage = false;
            string pattern = "^[A-Za-z]*$";
            if (Regex.IsMatch(name, pattern))
            {
                if (!(name == string.Empty || name.Length <= 3))
                {
                    if (name.Length > 4)
                    {
                        flage = true;
                    }
                }
            }
            if (flage == true) { return true; }
            else { return false; }
        }
        public string NameError(string name)
        {
            bool vali = Name(name);
            if (!vali)
            {
                return "InValid Name";
            }
            else
            {
                return "";
            }
        }
        #endregion


        #region Age Validation
        public bool Age(string age)
        {
            int x;
            bool flage = false;
            bool valid = int.TryParse(age, out x);
            if (age.Length == 2 && valid)
            {
                flage = true;
            }
            if (flage == true) { return true; }
            else { return false; }
        }
        public string AgeError(string age)
        {
            bool vali = Age(age);
            if (!vali)
            {
                return "InValid Age";
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

            if (!(add == string.Empty))
            {
                if (add.Length >= 3)
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
                return "InValid Address";
            }
            else
            {
                return "";
            }
        }
        #endregion


        #region Salary Validation
        public bool Salary(string salary)
        {
            int x;
            bool flage = false;
            bool valid = int.TryParse(salary, out x);
            if (x >= 1000 && valid)
            {
                flage = true;
            }
            if (flage == true) { return true; }
            else { return false; }
        }
        public string SalaryError(string id)
        {
            bool vali = Salary(id);
            if (!vali)
            {
                return "InValid Salary";
            }
            else
            {
                return "";
            }
        }
        #endregion

    }
}
