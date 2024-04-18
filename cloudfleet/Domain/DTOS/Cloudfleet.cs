namespace cloudfleet.Domain.DTOS
{
    public class CloudfleetListaVehiculos
    {
        public int Id { get; set; }
        public string? Code { get; set; }
        public string? TypeName { get; set; }
        public string? BrandName { get; set; }
        public string? LineName { get; set; }
        public int? OdometerType { get; set; }
        public int? MainMeasurementType { get; set; }
        public Kilometros? Odometer { get; set; }
        public string? Hourmeter { get; set; }
        public string? Color { get; set; }
        public string? NamainFuelTypeme { get; set; }
        public string? AuxFuelType { get; set; }
        public string? Workload { get; set; }
        public string? MaxOdometerDay { get; set; }
        public string? AvgOdometerDay { get; set; }
        public string? MaxHourmeterDay { get; set; }
        public string? AvgHourmeterDay { get; set; }
        public Ciudad? City { get; set; }
        public CostCenter? CCenter { get; set; }
        public Group1? Gropo1 { get; set; }
        public Group2? Gropo2 { get; set; }
        public string? CommentGroupingData { get; set; }
        public string? AuxCode { get; set; }
        public string? Vin { get; set; }
        public string? ImeiGps { get; set; }
        public Owner? Dueno { get; set; }
        public string? Engine { get; set; }
        public WeightCapacity? Peso { get; set; }
        public string? ChassisNumber { get; set; }
        public string? SerialNumber { get; set; }
        public string? PurchaseDate { get; set; }
        public string? PurchaseOdometer { get; set; }
        public string? PurchaseHourmeter { get; set; }
        public decimal PurchasePrice { get; set; }
        public string? Seller { get; set; }
        public int SubaccountQty { get; set; }
        public Driver? Conductor { get; set; }
        public string? CreatedAt { get; set; }
        public CreatedBy? CreadoPor { get; set; }
    }

    public class CloudfleetListarDocumentosVehículos
    {
        public DocType? DocTipo { get; set; }
        public string? Vendor { get; set; }
        public string? VehicleCode { get; set; }
        public string? Cost { get; set; }
        public string? IssueDate { get; set; }
        public string? Comments { get; set; }
        public string? ValidFrom { get; set; }
        public string? ValidTo { get; set; }
        public CostCenter? Ccenter { get; set; }
        public bool? IsCurrent { get; set; }
        public string? Files { get; set; }
    }

    public class CloudfleetListarOrdenesTrabajo
    {
        public int Number { get; set; }
        public string? Name { get; set; }
    }


    public class Kilometros
    {
        public string? lastMeter { get; set; }
        public string? lastMeterAt { get; set; }
    }

    public class Ciudad
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Code { get; set; }
    }

    public class CostCenter
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Code { get; set; }
    }

    public class Group1
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Code { get; set; }
    }

    public class Group2
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Code { get; set; }
    }

    public class Owner
    {
        public int Id { get; set; }
        public string? Name { get; set; }
    }

    public class WeightCapacity
    {
        public int Value { get; set; }
        public string? Unit { get; set; }
    }

    public class Driver
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int personId { get; set; }
    }

    public class CreatedBy
    {
        public int Id { get; set; }
        public string? Name { get; set; }
    }

    public class DocType
    {
        public string? Name { get; set; }
        public string? Code { get; set; }
    }

}
