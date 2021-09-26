using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoDeskModels
{
    public class KeyCheck
    {
        private static readonly string secretKeyProduct = "NoDesk2021BBJL";
        private static readonly string secretKeyInvite = "&NoDesk2021BBJL";



        private string[] SplitKey(string key)
        {
            return key.Split(':', 2);
        }

        public bool CheckActivationKey(string key)
        {
            string[] keys = new string[2];
            try
            {
                keys = SplitKey(key);
                if (keys[1] == secretKeyProduct)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                throw new Exception("Enter valid activation key!");
            }
        }

        public bool CheckInviteKey(string key)
        {
            string[] keys = new string[2];
            try
            {
                keys = SplitKey(key);
                if (keys[1] == secretKeyInvite)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                throw new Exception("Enter valid invite key!");
            }
            
        }
    }
}
