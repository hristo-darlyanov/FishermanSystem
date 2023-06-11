using FishermanSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishermanSystem.Controller
{
    internal class FishingSessionController
    {
        public List<Fishing_Session> ReadAllFishingSessions()
        {
            using (FishermanSystemDBEntities db = new FishermanSystemDBEntities())
            {
                return db.Fishing_Session.ToList();
            }
        }
        public void RemoveFishingSession(int id)
        {
            using (FishermanSystemDBEntities db = new FishermanSystemDBEntities())
            {
                var fishingSessionToDelete = db.Fishing_Session.Where(x => x.id == id).FirstOrDefault();
                db.Fishing_Session.Remove(fishingSessionToDelete);
                db.SaveChanges();
            }
        }
    }
}
