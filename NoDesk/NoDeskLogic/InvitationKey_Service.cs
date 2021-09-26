using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NoDeskModels;
using NoDeskDAL;
namespace NoDeskLogic
{
    public class InvitationKey_Service
    {
        private InvitationKey_DAL _InvitationKey_DAL;

        public InvitationKey_Service()
        {
            _InvitationKey_DAL = new InvitationKey_DAL();
        }

        public void InsertInvitationKey(InvitationKey invitationKey)
        {
            _InvitationKey_DAL.InsertInvitationKey(invitationKey);
        }

        public List<InvitationKey> GetInvitationKey()
        {
            return _InvitationKey_DAL.GetInvitationKey();
        }

        public void UpdateStatusInvitationKey(InvitationKey invitationKey)
        {
            _InvitationKey_DAL.UpdateStatusInvitationKey(invitationKey);
        }

        public void DeleteInvitationKeyByKey(InvitationKey invitationKey)
        {
            _InvitationKey_DAL.DeleteInvitationKeyByKey(invitationKey);
        }
    }
}
