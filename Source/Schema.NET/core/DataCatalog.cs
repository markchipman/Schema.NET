using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// A collection of datasets.
    /// </summary>
    [DataContract]
    public partial class DataCatalog : CreativeWork
    {
        public interface IMeasurementTechnique : IWrapper { }
        public interface IMeasurementTechnique<T> : IMeasurementTechnique { new T Data { get; set; } }
        public class MeasurementTechniquestring : IMeasurementTechnique<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public MeasurementTechniquestring () { }
            public MeasurementTechniquestring (string data) { Data = data; }
            public static implicit operator MeasurementTechniquestring (string data) { return new MeasurementTechniquestring (data); }
        }

        public class MeasurementTechniqueUri : IMeasurementTechnique<Uri>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Uri) value; } }
            public virtual Uri Data { get; set; }
            public MeasurementTechniqueUri () { }
            public MeasurementTechniqueUri (Uri data) { Data = data; }
            public static implicit operator MeasurementTechniqueUri (Uri data) { return new MeasurementTechniqueUri (data); }
        }


        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "DataCatalog";

        /// <summary>
        /// A dataset contained in this catalog.
        /// </summary>
        [DataMember(Name = "dataset", Order = 206)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Dataset>? Dataset { get; set; } 

        /// <summary>
        /// A technique or technology used in a &lt;a class="localLink" href="http://schema.org/Dataset"&gt;Dataset&lt;/a&gt; (or &lt;a class="localLink" href="http://schema.org/DataDownload"&gt;DataDownload&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/DataCatalog"&gt;DataCatalog&lt;/a&gt;),
        /// corresponding to the method used for measuring the corresponding variable(s) (described using &lt;a class="localLink" href="http://schema.org/variableMeasured"&gt;variableMeasured&lt;/a&gt;). This is oriented towards scientific and scholarly dataset publication but may have broader applicability; it is not intended as a full representation of measurement, but rather as a high level summary for dataset discovery.&lt;/p&gt;
        /// &lt;p&gt;For example, if &lt;a class="localLink" href="http://schema.org/variableMeasured"&gt;variableMeasured&lt;/a&gt; is: molecule concentration, &lt;a class="localLink" href="http://schema.org/measurementTechnique"&gt;measurementTechnique&lt;/a&gt; could be: "mass spectrometry" or "nmr spectroscopy" or "colorimetry" or "immunofluorescence".&lt;/p&gt;
        /// &lt;p&gt;If the &lt;a class="localLink" href="http://schema.org/variableMeasured"&gt;variableMeasured&lt;/a&gt; is "depression rating", the &lt;a class="localLink" href="http://schema.org/measurementTechnique"&gt;measurementTechnique&lt;/a&gt; could be "Zung Scale" or "HAM-D" or "Beck Depression Inventory".&lt;/p&gt;
        /// &lt;p&gt;If there are several &lt;a class="localLink" href="http://schema.org/variableMeasured"&gt;variableMeasured&lt;/a&gt; properties recorded for some given data object, use a &lt;a class="localLink" href="http://schema.org/PropertyValue"&gt;PropertyValue&lt;/a&gt; for each &lt;a class="localLink" href="http://schema.org/variableMeasured"&gt;variableMeasured&lt;/a&gt; and attach the corresponding &lt;a class="localLink" href="http://schema.org/measurementTechnique"&gt;measurementTechnique&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "measurementTechnique", Order = 207)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IMeasurementTechnique>? MeasurementTechnique { get; set; } //string, Uri
    }
}
