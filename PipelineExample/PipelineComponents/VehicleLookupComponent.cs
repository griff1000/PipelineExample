namespace PipelineExample.PipelineComponents
{
    using PipelineExample;
    using PipelineExample.Models;
    using System.Threading.Tasks;

    /// <summary>
    /// Dummy component to do stuff with the Vehicle Lookup
    /// </summary>
    internal class VehicleLookupComponent : IPipelineComponent<InputModel, PricingModel>
    {
        public VehicleLookupComponent()
        {
            // Could pull in other dependencies by constructor injection
        }

        /// <inheritdoc/>
        public Task RunComponent(InputModel input, PricingModel output)
        {
            output.MileageSegment = 3;
            output.VehicleValueSegment = 1;
            return Task.CompletedTask;
        }
    }
}
