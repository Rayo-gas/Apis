
using cloudfleet.Infraestructure.Rest;
using cloudfleet.Infraestructure.Rest.Implementation;


namespace cloudfleet.Application.Vehicles
{
	public class VehiclesService : IVehiclesService
	{
        private readonly IFleetCloudV1RestService _vehiclesRest = new CouldFleetV1();

        public List<string> GetVehicles()
        {
            List<string>  value=  _vehiclesRest.GetVehiclesAsync("https://fleet.cloudfleet.com/api/v1/");
            return value;
        }      

        public List<string> GetDuments()
        {
            List<string> value = _vehiclesRest.GetVehiclesDocuments("https://fleet.cloudfleet.com/api/v1/vehicles");
            return value;
        }

        public List<string> GetParts()
        {
            List<string> value = _vehiclesRest.GetVehiclesParts("https://fleet.cloudfleet.com/api/v1/");
            return value;
        }

        public List<string> GetWorkOrders()
        {
            List<string> value = _vehiclesRest.GetVehiclesWorkOrders("https://fleet.cloudfleet.com/api/v2/");
            return value;
        }

    }
}
