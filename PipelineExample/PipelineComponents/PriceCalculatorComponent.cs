namespace PipelineExample.PipelineComponents
{
    using PipelineExample;
    using PipelineExample.Models;
    using System.Threading.Tasks;

    /// <summary>
    /// Last one in the chain to work on all the input or intermediate model data and calculate the price for output
    /// </summary>
    internal class PriceCalculatorComponent : IPipelineComponent<InputModel, PricingModel>
    {
        public PriceCalculatorComponent()
        {
            // Could pull in other dependencies by constructor injection
        }

        /// <inheritdoc/>
        public Task RunComponent(InputModel input, PricingModel model)
        {
            // Random gibberish calculations - can be whatever is needed at this point
            model.PriceDetails.ConfidenceLevel = (model.NcbSegment + model.AgeSegment + model.MileageSegment) / 3;
            model.PriceDetails.MinimumPremium = 155 * model.VehicleValueSegment + model.PostcodeSegment * model.AgeSegment;
            model.PriceDetails.MaximumPremium = 2 * model.PriceDetails.MinimumPremium;
            model.PriceDetails.AveragePremium = (model.PriceDetails.MinimumPremium + model.PriceDetails.MaximumPremium) / 2;

            return Task.CompletedTask;
        }
    }
}
