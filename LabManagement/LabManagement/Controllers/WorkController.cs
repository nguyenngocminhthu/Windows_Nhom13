using LabManagement.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabManagement.Controllers
{
    class WorkController
    {
        public static int getIDfromDB()
        {

            using (var _context = new LabMangementEntities())
            {


                var id = (from t in _context.Works
                          select t.ID).ToList();

                if (id.Count <= 0)
                {
                    return 1;
                }
                else
                {
                    int ids = 1;
                    while (true)
                    {
                        if (id.Contains(ids))
                        {
                            ids++;
                        }
                        else
                            return ids;
                    }
                }
            }

        }
        public static bool AddWork(Work works)
        {


            using (var _context = new LabMangementEntities())
            {

                foreach (var mem in works.Members)
                {
                    var memdb = (from u in _context.Members
                                 where u.memcode == mem.memcode
                                 select u).Single();
                    memdb.Works.Add(works);
                }
                works.Members.Clear();
                foreach (var pro in works.Projects)
                {
                    var prodb = (from p in _context.Projects
                                 where p.procode == pro.procode
                                 select p).Single();
                    prodb.Works.Add(works);
                }
                works.Projects.Clear();
                _context.Works.AddOrUpdate(works);
                _context.SaveChanges();
                return true;

            }
        }
        public static List<Work> getAllWorks()
        {

            using (var _context = new LabMangementEntities())
            {
                var works = (from t in _context.Works.AsEnumerable()
                             select new
                             {
                                 ID = t.ID,                                                                  
                                 workingtime = t.workingtime,
                                 salary = t.salary,
                                 Members = t.Members,
                                 Projects=t.Projects
                             })
                             .Select(x => new Work
                             {
                                 ID = x.ID,                                                                 
                                 workingtime = x.workingtime,
                                 salary = x.salary,
                                 Members = x.Members,
                                 Projects = x.Projects,
                             });
                return works.ToList();

            }
        }
        public static bool UpdateWork(Work work)
        {
            try
            {
                DeleteWork(work.ID);
                AddWork(work);
                return true;
            }
            catch
            {
                return false;
            }

        }


        public static bool DeleteWork(int id)
        {
            try
            {
                using (var _context = new LabMangementEntities())
                {
                    var dbwork = (from t in _context.Works
                                  where t.ID == id
                                  select t).SingleOrDefault();

                    foreach (var mem in dbwork.Members)
                    {
                        foreach (var t in mem.Works)
                        {
                            if (t.ID == id)
                            {
                                mem.Works.Remove(t);
                                break;
                            }
                        }
                    }

                    _context.Works.Remove(dbwork);
                    _context.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}

