using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace motofix
{
    public class MotorcyclesDAL
    {
        ApplicationContext db = new ApplicationContext();

        public void AddNewMotorcycle(Motorcycle motorcycle)
        {
            db.Motorcycles.Add(motorcycle);
        }

        public int GetLastID()
        {
            int? id = db.Motorcycles.Max(s => s.ID);
            if (id == null) { return 1; }
            else { return (int)id; }
        }

        public List<Motorcycle>? GetAllMotorcycles()
        {
            List<Motorcycle>? motorcycles = db.Motorcycles.ToList();
            return motorcycles;
        }

        public Motorcycle? GetMotorcycleByID(int motorcycleID)
        {
            Motorcycle? motorcycle = (from s in db.Motorcycles where s.ID == motorcycleID select s).FirstOrDefault();
            return motorcycle;
        }

        public List<Motorcycle>? GetMotorcyclesByModel(string model)
        {
            List<Motorcycle>? motorcycles = (from s in db.Motorcycles where s.Model.Contains(model) select s).ToList();
            return motorcycles;
        }

        public void UpdateMotorcycleMileage(int motorcycleID, int newMileage)
        {
            Motorcycle? motorcycle = (from s in db.Motorcycles where s.ID == motorcycleID select s).FirstOrDefault();
            if (motorcycle != null)
            {
                motorcycle.Mileage = newMileage;
                db.SaveChanges();
            }
        }

        public void DeleteMotorcycleByID(int motorcycleID)
        {
            Motorcycle? motorcycle = (from s in db.Motorcycles where s.ID == motorcycleID select s).FirstOrDefault();
            if (motorcycle != null)
            {
                db.Motorcycles.Remove(motorcycle);
            }
        }
    }
}
