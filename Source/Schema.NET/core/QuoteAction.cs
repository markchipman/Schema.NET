using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// An agent quotes/estimates/appraises an object/product/service with a price at a location/store.
    /// </summary>
    [DataContract]
    public partial class QuoteAction : TradeAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "QuoteAction";
    }
}
