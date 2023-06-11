using FishermanSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishermanSystem.Controller
{
    internal class BoatController
    {
        public List<Boat> ReadAllBoats()
        {
            using (FishermanSystemDBEntities db = new FishermanSystemDBEntities())
            {
                return db.Boat.ToList();
            }
        }

        public void RemoveBoat(int id)
        {
            using (FishermanSystemDBEntities db = new FishermanSystemDBEntities())
            {
                var boatToDelete = db.Boat.Where(x => x.id == id).FirstOrDefault();
                db.Boat.Remove(boatToDelete);
                db.SaveChanges();
            }
        }
    }
}
