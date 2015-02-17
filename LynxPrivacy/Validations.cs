using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LynxPrivacy
{
    public class Validations
    {
        public bool FirstNameValid(string data)
        {
            bool valid = false;
            if (!string.IsNullOrEmpty(data))
                valid = true;
            return valid;
        }
        public bool SurnameValid(string data)
        {
            bool valid = false;
            if (!string.IsNullOrEmpty(data))
                valid = true;
            return valid;
        }
        public bool EmailValid(string data)
        {
            bool valid = false;
            if (!string.IsNullOrEmpty(data)) {
                if (data.Contains("@")) {
                    data = data.Substring(data.IndexOf("@") + 1);
                    if (!data.Contains("@")) {
                        if (data.Substring(2, data.Length - 4).Contains("."))
                        valid = true;
                    }
                }
            }
            return valid;
        }
    }
}
