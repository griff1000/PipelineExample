namespace PipelineExample.PipelineComponents
{
    using PipelineExample;
    using PipelineExample.Models;
    using System.Threading.Tasks;

    /// <summary>
    /// Dummy component to do stuff with the age
    /// </summary>
    internal class AgeComponent : IPipelineComponent<InputModel, PricingModel>
    {
        public AgeComponent()
        {
            // Could pull in other dependencies by constructor injection
        }

        /// <inheritdoc/>
        public Task RunComponent(InputModel input, PricingModel model)
        {
            if (input.Age < 20)
                model.AgeSegment = 4;
            else model.AgeSegment = 5;

            return Task.CompletedTask;
        }
    }
}
