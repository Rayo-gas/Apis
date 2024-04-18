
namespace cloudfleet.Infraestructure.Rest
{
	public interface IFleetCloudV1RestService
	{
        List<String> GetVehiclesAsync(String url);
        List<String> GetVehiclesDocuments(String url);
        List<String> GetVehiclesParts(String url);
        List<String> GetVehiclesWorkOrders(String url);
    }
}

