using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
using DataAccess.DAO;

namespace DataAccess.Repository
{
    public class MemberRepository : IMemberRepository
    {
        public IEnumerable<MemberObject> GetMembers() => MemberDAO.GetMembers();
        public MemberObject LoginMember(String email, String password) => MemberDAO.Instance.Login(email, password);

    }
}
