using FishermanSystem.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishermanSystem.Controller
{
    internal class DatabaseController
    {
        public void CreateRegister(User user)
        {
            using (FishermanSystemDBEntities db = new FishermanSystemDBEntities())
            {
                db.User.Add(user);
                db.SaveChanges();
            }
        }

        public List<User> ReadAllUsers()
        {
            using (FishermanSystemDBEntities db = new FishermanSystemDBEntities())
            {
                return db.User.ToList();
            }
        }
    }
}
