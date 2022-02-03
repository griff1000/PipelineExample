namespace PipelineExample.Models
{
    /// <summary>
    /// Ultimate output of the pipeline
    /// </summary>
    internal class IndicativePrice
    {
        public double MinimumPremium { get; set; }
        public double MaximumPremium { get; set; }
        public double AveragePremium { get; set; }
        public int ConfidenceLevel { get; set; }
    }
}
