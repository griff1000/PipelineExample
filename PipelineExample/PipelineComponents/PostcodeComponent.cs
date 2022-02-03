namespace PipelineExample.PipelineComponents
{
    using PipelineExample;
    using PipelineExample.Models;
    using System.Threading.Tasks;

    /// <summary>
    /// Dummy component to do stuff with the Postcode
    /// </summary>
    internal class PostcodeComponent : IPipelineComponent<InputModel, PricingModel>
    {
        public PostcodeComponent()
        {
            // Could pull in other dependencies by constructor injection
        }

        /// <inheritdoc/>
        public Task RunComponent(InputModel input, PricingModel model)
        {
            model.PostcodeSegment = 2;
            return Task.CompletedTask;
        }
    }
}
