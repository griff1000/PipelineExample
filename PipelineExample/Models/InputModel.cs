namespace PipelineExample.Models
{
    /// <summary>
    /// Data the pipeline needs as input to start its processing
    /// </summary>
    internal class InputModel
    {
        public string Postcode { get; set; }
        public int Age { get; set; }
        public string VehicleRegistrationNumber { get; set; }
        public int Mileage { get; set; }
        public int YearsNoClaimsBonus { get; set; }
        public bool NcbCurrentlyProtected { get; set; }

    }
}
