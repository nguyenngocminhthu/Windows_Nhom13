using LabManagement.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabManagement.Controllers
{
    class MemController
    {
        public static bool AddMem(Member mem)
        {
            try
            {
                using (var _context = new LabMangementEntities())
                {
                    _context.Members.Add(mem);
                    _context.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        public static Member getMem(string memcode)
        {
            using (var _context = new LabMangementEntities())
            {
                var mem = (from u in _context.Members
                           where u.memcode == memcode
                           select u).ToList();
                if (mem.Count == 1)
                {
                    return mem[0];
                }
                else
                {
                    return null;
                }
            }
        }
        public static List<Member> getlistMems()
        {
            using (var _context = new LabMangementEntities())
            {
                var mem = (from u in _context.Members.AsEnumerable()

                           select u).Select(x => new Member
                           {
                               memcode = x.memcode,
                               memname = x.memname,
                               gender = x.gender,
                               birthday = x.birthday,
                               address = x.address,
                               phonenum = x.phonenum,
                               email = x.email
                           }).ToList();
                return mem;
            }
        }

        public static bool UpdateMem(Member mem)
        {
            try
            {
                using (var _context = new LabMangementEntities())
                {
                    _context.Members.AddOrUpdate(mem);
                    _context.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }


        }
        public static bool DeleteMem(Member mem)
        {

            try
            {
                using (var _context = new LabMangementEntities())
                {
                    //Xoa danh sach cong viec
                    var dbmem = (from u in _context.Members
                                 where u.memcode == mem.memcode
                                 select u).SingleOrDefault();

                    foreach (var work in dbmem.Works)
                    {
                        foreach (var u in work.Members)
                        {
                            if (u.memcode == mem.memcode)
                            {
                                work.Members.Remove(u);
                                break;
                            }
                        }
                    }
                    _context.Members.Remove(dbmem);
                    _context.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }

        }
        public static List<Member> getListMems(string memcodesearch)
        {
            using (var _context = new LabMangementEntities())
            {
                var mem = (from u in _context.Members.AsEnumerable()
                           where u.memcode.Contains(memcodesearch)
                           select u)
                            .Select(x => new Member
                            {
                                memcode = x.memcode,
                                memname = x.memname,
                                gender = x.gender,
                                birthday = x.birthday,
                                address = x.address,
                                phonenum = x.phonenum,
                                email = x.email,

                            }).ToList();
                return mem;
            }
        }
    }
}
