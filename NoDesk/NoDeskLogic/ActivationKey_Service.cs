using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NoDeskDAL;
using NoDeskModels;

namespace NoDeskLogic
{
    public class ActivationKey_Service
    {
        private ActivationKey_DAL _ActivationKey_DAL;

        public ActivationKey_Service()
        {
            _ActivationKey_DAL = new ActivationKey_DAL();
        }

        public void InsertActivationKey(ActivationKey activationKey)
        {
            _ActivationKey_DAL.InsertActivationKey(activationKey);
        }

        public List<ActivationKey> GetActivationKeys()
        {
            return _ActivationKey_DAL.GetActivationKeys();
        }

        public void UpdateStatusActivationKey(ActivationKey activationKey)
        {
            _ActivationKey_DAL.UpdateStatusActivationKey(activationKey);
        }

        public void DeleteActivationKeyByKey(ActivationKey activationKey)
        {
            _ActivationKey_DAL.DeleteActivationKeyByKey(activationKey);
        }
    }
}
