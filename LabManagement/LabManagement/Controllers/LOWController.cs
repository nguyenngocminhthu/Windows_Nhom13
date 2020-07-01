using LabManagement.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabManagement.Controllers
{
    class LOWController
    {
        public static int getNofromDB()
        {

            using (var _context = new LabMangementEntities())
            {


                var no = (from t in _context.ListOfWorks
                          select t.no).ToList();

                if (no.Count <= 0)
                {
                    return 1;
                }
                else
                {
                    int nos = 1;
                    while (true)
                    {
                        if (no.Contains(nos))
                        {
                            nos++;
                        }
                        else
                            return nos;
                    }
                }
            }

        }
        public static bool AddLOW(ListOfWork lows)
        {


            using (var _context = new LabMangementEntities())
            {

                foreach (var pro in lows.Projects)
                {
                    var prodb = (from u in _context.Projects
                                 where u.procode == pro.procode
                                 select u).Single();
                    prodb.ListOfWorks.Add(lows);
                }
                lows.Projects.Clear();
                _context.ListOfWorks.AddOrUpdate(lows);
                _context.SaveChanges();
                return true;

            }
        }
        public static List<ListOfWork> getAllLOWs()
        {

            using (var _context = new LabMangementEntities())
            {
                var lows = (from t in _context.ListOfWorks.AsEnumerable()
                            select new
                            {
                                no = t.no,
                                job = t.job,
                                status = t.status,
                                Projects=t.Projects
                            })
                             .Select(x => new ListOfWork
                             {
                                 no = x.no,
                                 job = x.job,
                                 status = x.status,
                                 Projects = x.Projects,
                             });
                return lows.ToList();

            }
        }
        public static bool UpdateLOW(ListOfWork low)
        {
            try
            {
                DeleteLOW(low.no);
                AddLOW(low);
                return true;
            }
            catch
            {
                return false;
            }

        }


        public static bool DeleteLOW(int no)
        {
            try
            {
                using (var _context = new LabMangementEntities())
                {
                    var dblow = (from t in _context.ListOfWorks
                                 where t.no == no
                                 select t).SingleOrDefault();

                    foreach (var low in dblow.Projects)
                    {
                        foreach (var t in low.ListOfWorks)
                        {
                            if (t.no == no)
                            {
                                low.ListOfWorks.Remove(t);
                                break;
                            }
                        }
                    }

                    _context.ListOfWorks.Remove(dblow);
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