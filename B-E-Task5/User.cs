using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_E_Task5
{
    class User
    {
        public string Name;
        public string Password;
        public bool IsPasswordValid()
        {
            bool isNum = false, isName = false, isLeng = false;
            if (Password.Length > 6) isLeng = true;
            foreach (char c in Password)
            {
                if(c >= '0' && c <= '9')
                {
                    isNum = true;
                    break;
                }
            }
            isName = !Password.ToLower().Contains(Name.ToLower());

            return isLeng && isName && isNum;
        }
    }
}
