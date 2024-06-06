using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class PageGroupRepository : IPageGroupRepository
    {
        private MyCmsContext db = new MyCmsContext();
        public IEnumerable<PageGroup> GetAllGroups()
        {
            return db.PageGroups;
        }

        public PageGroup GetGroupById(int groupId)
        {
            return db.PageGroups.Find(groupId);
        }

        public bool InsertGroup(PageGroup pageGroup)
        {
            try
            {
                db.PageGroups.Add(pageGroup);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateGroup(PageGroup pageGroup)
        {
            try
            {
                db.Entry(pageGroup).State = EntityState.Modified;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteGroup(PageGroup pageGroup)
        {
            try
            {
                db.Entry(pageGroup).State = EntityState.Deleted;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteGroup(int groupId)
        {
            try
            {
                var group = GetGroupById(groupId);
                DeleteGroup(groupId);
                return true;
            }
            catch
            {
                return false;
            }
        }


        public void Save()
        {
            db.SaveChanges();
        }


    }
}
