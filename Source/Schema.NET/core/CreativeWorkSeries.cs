using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// A CreativeWorkSeries in schema.org is a group of related items, typically but not necessarily of the same kind. CreativeWorkSeries are usually organized into some order, often chronological. Unlike &lt;a class="localLink" href="http://schema.org/ItemList"&gt;ItemList&lt;/a&gt; which is a general purpose data structure for lists of things, the emphasis with CreativeWorkSeries is on published materials (written e.g. books and periodicals, or media such as tv, radio and games).&lt;/p&gt;
    /// &lt;p&gt;Specific subtypes are available for describing &lt;a class="localLink" href="http://schema.org/TVSeries"&gt;TVSeries&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/RadioSeries"&gt;RadioSeries&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/MovieSeries"&gt;MovieSeries&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/BookSeries"&gt;BookSeries&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/Periodical"&gt;Periodical&lt;/a&gt; and &lt;a class="localLink" href="http://schema.org/VideoGameSeries"&gt;VideoGameSeries&lt;/a&gt;. In each case, the &lt;a class="localLink" href="http://schema.org/hasPart"&gt;hasPart&lt;/a&gt; / &lt;a class="localLink" href="http://schema.org/isPartOf"&gt;isPartOf&lt;/a&gt; properties can be used to relate the CreativeWorkSeries to its parts. The general CreativeWorkSeries type serves largely just to organize these more specific and practical subtypes.&lt;/p&gt;
    /// &lt;p&gt;It is common for properties applicable to an item from the series to be usefully applied to the containing group. Schema.org attempts to anticipate some of these cases, but publishers should be free to apply properties of the series parts to the series as a whole wherever they seem appropriate.
    /// </summary>
    [DataContract]
    public partial class CreativeWorkSeries : CreativeWork
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "CreativeWorkSeries";

        /// <summary>
        /// The International Standard Serial Number (ISSN) that identifies this serial publication. You can repeat this property to identify different formats of, or the linking ISSN (ISSN-L) for, this serial publication.
        /// </summary>
        [DataMember(Name = "issn", Order = 206)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? Issn { get; set; } 

        /// <summary>
        /// The start date and time of the item (in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 date format&lt;/a&gt;).
        /// </summary>
        [DataMember(Name = "startDate", Order = 207)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DateTimeOffset>? StartDate { get; set; } 

        /// <summary>
        /// The end date and time of the item (in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 date format&lt;/a&gt;).
        /// </summary>
        [DataMember(Name = "endDate", Order = 208)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DateTimeOffset>? EndDate { get; set; } 
    }
}
