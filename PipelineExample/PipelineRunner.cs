namespace PipelineExample
{
    using PipelineExample.Models;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// Class to run the pipeline components.  You don't really need a dedicated runner, I just needed something
    /// into which I could inject the IEnumberable of IPipelineComponents and then iterate through them.  Any 
    /// class at an appropriate point in your processing would do.
    internal class PipelineRunner : IPipelineRunner<InputModel,IndicativePrice>
    {
        private readonly IEnumerable<IPipelineComponent<InputModel, PricingModel>> _pipelineComponents;
        
        public PipelineRunner(IEnumerable<IPipelineComponent<InputModel, PricingModel>> pipelineComponents)
        {
            // All the IPipelineComponents<InputModel, PricingModel> that were configured in the Program.cs
            // will be in this IEnumerable, IN THE ORDER THEY WERE CONFIGURED
            _pipelineComponents = pipelineComponents;
        }

        public async Task<IndicativePrice> RunPipeline(InputModel input)
        {
            var outputModel = new PricingModel();

            foreach (var pipelineComponent in _pipelineComponents)
            {
                await pipelineComponent.RunComponent(input, outputModel);
            }

            return outputModel.PriceDetails;
        }
    }
}
