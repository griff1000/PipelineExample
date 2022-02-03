namespace PipelineExample.Models
{
    /// <summary>
    /// Data the pipeline will manipulate and calculate as it progresses
    /// </summary>
    internal class PricingModel
    {
        #region intermediate calculated data

        public int AgeSegment { get; set; }
        public int NcbSegment { get; set; }
        public int PostcodeSegment { get; set; }
        public int MileageSegment { get; set; }
        public int VehicleValueSegment { get; set; }

        #endregion

        #region final output

        /// <summary>
        ///  This is the ultimate output of the pipeline
        /// </summary>
        public IndicativePrice PriceDetails { get; set; } = new IndicativePrice();

        #endregion

    }
}
