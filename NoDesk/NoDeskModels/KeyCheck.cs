using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoDeskModels
{
    public class KeyCheck
    {
        private Encryption _encryption;
        private static readonly string secretKeyProduct = "NoDesk2021BBJL";
        private static readonly string secretKeyInvite = "&NoDesk2021BBJL";
        public string CompanyName { get; set; }
        public string CompanyID { get; set; }

        public KeyCheck()
        {
            _encryption = new Encryption();
        }

        public string CreateActivationKey(string companyName)
        {
            return _encryption.Encrypt(companyName + ":" + secretKeyProduct);
        }

        public string CreateInviteKey(string CompanyId)
        {
            return _encryption.Encrypt(CompanyId + ":" + secretKeyInvite);
        }

        public bool EnterActivationKey(string key)
        {
            key = DecryptKey(key);
            return CheckActivationKey(key);
        }

        public bool EnterInviteKey(string key)
        {
            key = DecryptKey(key);
            return CheckInviteKey(key);
        }
        private string DecryptKey(string key)
        {
            return _encryption.Decrypt(key);
        }

        private string[] SplitKey(string key)
        {
            return key.Split(':', 2);
        }

        private bool CheckActivationKey(string key)
        {
            string[] keys = new string[2];
            try
            {
                keys = SplitKey(key);
                if (keys[1] == secretKeyProduct)
                {
                    CompanyName = keys[0];
                    return true;
                }
                else
                {
                    throw new Exception("Enter valid invite key!");
                }
            }
            catch (Exception)
            {
                throw new Exception("Enter valid activation key!");
            }
        }

        private bool CheckInviteKey(string key)
        {
            string[] keys = new string[2];
            try
            {
                keys = SplitKey(key);
                if (keys[1] == secretKeyInvite)
                {
                    CompanyID = keys[0];
                    return true;
                }
                else
                {
                    throw new Exception("Enter valid invite key!");
                }
            }
            catch (Exception)
            {
                throw new Exception("Enter valid invite key!");
            }
            
        }
    }
}
