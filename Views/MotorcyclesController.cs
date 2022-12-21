using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using records;

namespace motofix
{
    [ApiController]
    [Route("motorcycles")]
    [ApiExplorerSettings(GroupName = "motorcycles")]
    public class MotorcyclesController : ControllerBase
    {

        MotorcyclesBLL BLL = new MotorcyclesBLL();

        [HttpPut]
        [Route("add_new")]
        public void AddMotorcycle(string model, int mileage)
        {
            BLL.AddNewMotorcycle(model, mileage);
        }

        [HttpGet]
        [Route("get_all")]
        public List<Motorcycle>? GetAllMotorcycles()
        {
            return BLL.GetAllMotorcycles();
        }

        [HttpGet]
        [Route("get_by_id")]
        public Motorcycle? GetMotorcycleByID(int motorcycleID)
        {
            return BLL.GetMotorcycleByID(motorcycleID);
        }

        [HttpGet]
        [Route("get_by_model")]
        public List<Motorcycle>? GetMotorcyclesByModel(string model)
        {
            return BLL.GetMotorcyclesByModel(model);
        }

        [HttpPatch]
        [Route("update_passport")]
        public void UpdateMotorcycleMileage(int motorcycleID, int newMileage)
        {
            BLL.UpdateMotorcycleMileage(motorcycleID, newMileage);
        }

        [HttpDelete]
        [Route("delete_by_id")]
        public void DeleteMotorcycleByID(int motorcycleID)
        {
            BLL.DeleteMotorcycleByID(motorcycleID);
        }

    }
}
