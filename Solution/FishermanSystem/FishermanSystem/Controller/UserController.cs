using FishermanSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishermanSystem.Controller
{
    internal class UserController
    {
        public void RemoveUser(int id)
        {
            using (FishermanSystemDBEntities db = new FishermanSystemDBEntities())
            {
                var userToDelete = db.User.Where(x => x.register_id == id).FirstOrDefault();
                var fishingSessionToDelete = db.Fishing_Session.Where(x => x.register_id == id).ToList();
                var boatToDelete = db.Boat.Where(x => x.register_id == id).ToList();
                foreach (var item in fishingSessionToDelete)
                {
                    db.Fishing_Session.Remove(item);
                }
                foreach (var item in boatToDelete)
                {
                    db.Boat.Remove(item);
                }
                db.User.Remove(userToDelete);
                db.SaveChanges();
            }
        }

        public void CreateUser(User user)
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
