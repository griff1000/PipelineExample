namespace PipelineExample.PipelineComponents
{
    using PipelineExample;
    using PipelineExample.Models;
    using System.Threading.Tasks;

    /// <summary>
    /// Dummy component to do stuff with the NCB
    /// </summary>
    internal class NcbComponent : IPipelineComponent<InputModel, PricingModel>
    {
        public NcbComponent()
        {
            // Could pull in other dependencies by constructor injection
        }

        /// <inheritdoc/>
        public Task RunComponent(InputModel input, PricingModel model)
        {
            if (input.NcbCurrentlyProtected)
                model.NcbSegment = 1;
            else
                model.NcbSegment = 2;

            return Task.CompletedTask;
        }
    }
}
