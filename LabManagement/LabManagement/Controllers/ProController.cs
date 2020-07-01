using LabManagement.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabManagement.Controllers
{
    class ProController
    {
        public static bool AddPro(Project pro)
        {
            try
            {
                using (var _context = new LabMangementEntities())
                {
                    _context.Projects.Add(pro);
                    _context.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        public static Project getPro(string procode)
        {
            using (var _context = new LabMangementEntities())
            {
                var pro = (from u in _context.Projects
                           where u.procode == procode
                           select u).ToList();
                if (pro.Count == 1)
                {
                    return pro[0];
                }
                else
                {
                    return null;
                }
            }
        }
        public static List<Project> getlistPros()
        {
            using (var _context = new LabMangementEntities())
            {
                var pro = (from u in _context.Projects.AsEnumerable()

                           select u).Select(x => new Project
                           {
                               procode = x.procode,
                               proname = x.proname,
                               description=x.description,
                               fromdate=x.fromdate,
                               todate=x.todate,
                           }).ToList();
                return pro;
            }
        }

        public static bool UpdatePro(Project pro)
        {
            try
            {
                using (var _context = new LabMangementEntities())
                {
                    _context.Projects.AddOrUpdate(pro);
                    _context.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }


        }
        public static bool DeletePro(Project pro)
        {

            try
            {
                using (var _context = new LabMangementEntities())
                {
                    //Xoa danh sach cong viec
                    var dbpro = (from u in _context.Projects
                                 where u.procode == pro.procode
                                 select u).SingleOrDefault();

                    foreach (var work in dbpro.Works)
                    {
                        foreach (var u in work.Projects)
                        {
                            if (u.procode == pro.procode)
                            {
                                work.Projects.Remove(u);
                                break;
                            }
                        }
                    }
                    _context.Projects.Remove(dbpro);
                    _context.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }

        }
        public static List<Project> getListPros(string procodesearch)
        {
            using (var _context = new LabMangementEntities())
            {
                var pro = (from u in _context.Projects.AsEnumerable()
                           where u.procode.Contains(procodesearch)
                           select u)
                            .Select(x => new Project
                            {
                                procode = x.procode,
                                proname = x.proname,
                                description = x.description,
                                fromdate = x.fromdate,
                                todate = x.todate,

                            }).ToList();
                return pro;
            }
        }
    }
}
