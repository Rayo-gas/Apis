using cloudfleet.Application;
using cloudfleet.Application.Vehicles;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace cloudfleet.Infraestructure.Controllers;

[ApiController]
[Route("[controller]")]
public class VehiclesController : ControllerBase
{
    private IVehiclesService _vehiclesService = new VehiclesService();

    [HttpGet]
    public IEnumerable<String> Get()
    {
        List<String> response = _vehiclesService.GetVehicles();
        return response;
    }

    [HttpGet]
    [Route("/docments")]
    public IEnumerable<String> GetDuments()
    {
        List<String> response = _vehiclesService.GetDuments();
        return response;
    }

    [HttpGet]
    [Route("/Parts")]
    public IEnumerable<String> GetParts()
    {
        List<String> response = _vehiclesService.GetParts();
        return response;
    }

    [HttpGet]
    [Route("/work-orders")]
    public IEnumerable<String> GetWorkOrders()
    {
        List<String> response = _vehiclesService.GetWorkOrders();
        return response;
    }
} 
