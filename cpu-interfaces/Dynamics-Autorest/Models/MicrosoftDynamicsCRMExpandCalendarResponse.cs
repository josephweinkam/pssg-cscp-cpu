// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Jag.VictimServices.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// ExpandCalendarResponse
    /// </summary>
    public partial class MicrosoftDynamicsCRMExpandCalendarResponse
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMExpandCalendarResponse class.
        /// </summary>
        public MicrosoftDynamicsCRMExpandCalendarResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMExpandCalendarResponse class.
        /// </summary>
        public MicrosoftDynamicsCRMExpandCalendarResponse(IList<MicrosoftDynamicsCRMTimeInfo> result = default(IList<MicrosoftDynamicsCRMTimeInfo>))
        {
            Result = result;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "result")]
        public IList<MicrosoftDynamicsCRMTimeInfo> Result { get; set; }

    }
}
