using MyMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyMVC.Services
{
    public static class MemberSvc
    {
        private static List<MemberViewModel> MemberInfo = new List<MemberViewModel>();
        
        public static List<MemberViewModel> GetMembers()
        {
            return MemberInfo;
        }

        public static void Add(MemberViewModel obj)
        {
            MemberInfo.Add(obj);
        }
    }
}