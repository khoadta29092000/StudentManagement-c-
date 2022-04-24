using System;
using System.Collections.Generic;
using System.Linq;
using BusinessObject;
using Microsoft.Extensions.Configuration;
using System.IO;
using System.Linq;

namespace DataAccess.DAO
{
    public class MemberDAO
    {
      
        private static MemberDAO instance = null;
        private static readonly object instanceLock = new object();
        private MemberDAO() { }
        public static MemberDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new MemberDAO();
                    }
                    return instance;
                }
            }
        }
        public static List<MemberObject> GetMembers()
        {
            var members = new List<MemberObject>();

            try
            {
                using (var context = new MyDbContext())
                {             
                    members = context.Account.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return members;
        }
        public MemberObject Login(string email, string password)
        {
            IEnumerable<MemberObject> members = GetMembers();
            MemberObject member = members.SingleOrDefault(mb => mb.Email.Equals(email) && mb.Password.Equals(password));
            return member;
        }

    }
}
