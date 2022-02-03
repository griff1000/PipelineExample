namespace PipelineExample
{
    using System.Threading.Tasks;

    /// <summary>
    /// Component to actually run the pipeline
    /// </summary>
    /// <typeparam name="TInput">Type of input data (will match what the components use)</typeparam>
    /// <typeparam name="TOutput">Type of output data (may be completely different than what the components use)</typeparam>
    internal interface IPipelineRunner<TInput, TOutput>
    {
        Task<TOutput> RunPipeline(TInput input);
    }
}