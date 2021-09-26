using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using NoDeskModels;

namespace NoDeskDAL
{
    public class InvitationKey_DAL : Base
    {
        public void InsertInvitationKey(InvitationKey invitationKey)
        {
            InsertRecord("InvitationKeys", invitationKey);
        }

        public List<InvitationKey> GetInvitationKey()
        {
            return LoadRecords<InvitationKey>("InvitationKeys");
        }

        public void UpdateStatusInvitationKey(InvitationKey invitationKey)
        {
            var update = Builders<InvitationKey>.Update
            .Set(P => P.UsedStatus, invitationKey.UsedStatus);
            UpdateRecordById("InvitationKeys", invitationKey.Key, update);
        }

        public void DeleteInvitationKeyByKey(InvitationKey invitationKey)
        {
            DeleteRecordById<ActivationKey>("InvitationKeys", invitationKey.Key);
        }
    }
}
