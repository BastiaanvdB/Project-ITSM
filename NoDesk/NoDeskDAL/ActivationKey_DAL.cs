using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using NoDeskModels;
namespace NoDeskDAL
{
    public class ActivationKey_DAL : Base
    {
        public void InsertActivationKey(ActivationKey activationKey)
        {
            InsertRecord("ActivationKeys", activationKey);
        }

        public List<ActivationKey> GetActivationKeys()
        {
            return LoadRecords<ActivationKey>("ActivationKeys");
        }

        public void UpdateStatusActivationKey(ActivationKey activationKey)
        {
            var update = Builders<ActivationKey>.Update
                .Set(P => P.UsedStatus, activationKey.UsedStatus);
            UpdateRecordById("ActivationKeys", activationKey.Key, update);
        }

        public void DeleteActivationKeyByKey(ActivationKey activationKey)
        {
            DeleteRecordById<ActivationKey>("ActivationKeys", activationKey.Key);
        }
    }
}
