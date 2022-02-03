namespace PipelineExample
{
    using System.Threading.Tasks;

    /// <summary>
    /// Each pipeline component implements this, and they'll have the same TInput and TOutput types.  If we want to 
    /// super-simplify things, get rid of the generics all together and just hard-code the types in the interface
    /// </summary>
    /// <typeparam name="TInput">Type of intput data (should not be modified)</typeparam>
    /// <typeparam name="TModel">Type of intermediate and output data (can be modified)</typeparam>
    internal interface IPipelineComponent<TInput, TModel>
    {
        /// <summary>
        /// Runs the actual component
        /// </summary>
        /// <param name="input">Data passed into the pipeline - should not be modified</param>
        /// <param name="model">Data generated through and passed out of the pipeline - can be modified</param>
        Task RunComponent(TInput input, TModel model);
    }
}
