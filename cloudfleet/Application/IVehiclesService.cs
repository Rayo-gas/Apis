namespace cloudfleet.Application
{
	public interface IVehiclesService
	{
        List<String> GetVehicles();
		List<String> GetDuments();
        List<String> GetParts();
        List<String> GetWorkOrders();
    }
}

