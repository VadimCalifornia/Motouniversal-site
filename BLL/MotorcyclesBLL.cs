using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace motofix
{
    [System.ComponentModel.DataObject]
    public class MotorcyclesBLL
    {
        private MotorcyclesDAL DAL = new MotorcyclesDAL();

        [System.ComponentModel.DataObjectMethodAttribute
        (System.ComponentModel.DataObjectMethodType.Select, true)]

        public void AddNewMotorcycle(string model, int mileage)
        {
            DAL.AddNewMotorcycle(new Motorcycle
            {
                ID = DAL.GetLastID() + 1,
                Model = model,
                Mileage = mileage
            });
        }

        public List<Motorcycle>? GetAllMotorcycles()
        {
            return DAL.GetAllMotorcycles();
        }

        public Motorcycle? GetMotorcycleByID(int motorcycleID)
        {
            return DAL.GetMotorcycleByID(motorcycleID);
        }

        public List<Motorcycle>? GetMotorcyclesByModel(string model)
        {
            return DAL.GetMotorcyclesByModel(model);
        }

        public void UpdateMotorcycleMileage(int motorcycleID, int newMileage)
        {
            DAL.UpdateMotorcycleMileage(motorcycleID, newMileage);
        }

        public void DeleteMotorcycleByID(int motorcycleID)
        {
            DAL.DeleteMotorcycleByID(motorcycleID);
        }
    }
}
