using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// A product taken by mouth that contains a dietary ingredient intended to supplement the diet. Dietary ingredients may include vitamins, minerals, herbs or other botanicals, amino acids, and substances such as enzymes, organ tissues, glandulars and metabolites.
    /// </summary>
    [DataContract]
    public partial class DietarySupplement : Substance
    {

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "DietarySupplement";

        /// <summary>
        /// An active ingredient, typically chemical compounds and/or biologic substances.
        /// </summary>
        [DataMember(Name = "activeIngredient", Order = 306)]
        [JsonConverter(typeof(ValuesConverter))]
        public override Values<string>? ActiveIngredient { get; set; } 

        /// <summary>
        /// Descriptive information establishing a historical perspective on the supplement. May include the rationale for the name, the population where the supplement first came to prominence, etc.
        /// </summary>
        [DataMember(Name = "background", Order = 307)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? Background { get; set; } 

        /// <summary>
        /// True if this item's name is a proprietary/brand name (vs. generic name).
        /// </summary>
        [DataMember(Name = "isProprietary", Order = 308)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<bool>? IsProprietary { get; set; } 

        /// <summary>
        /// The drug or supplement's legal status, including any controlled substance schedules that apply.
        /// </summary>
        [DataMember(Name = "legalStatus", Order = 309)]
        [JsonConverter(typeof(ValuesConverter))]
        public override Values<ILegalStatus>? LegalStatus { get; set; } //DrugLegalStatus, MedicalEnumeration?, string

        /// <summary>
        /// Recommended intake of this supplement for a given population as defined by a specific recommending authority.
        /// </summary>
        [DataMember(Name = "maximumIntake", Order = 310)]
        [JsonConverter(typeof(ValuesConverter))]
        public override Values<MaximumDoseSchedule>? MaximumIntake { get; set; } 

        /// <summary>
        /// The specific biochemical interaction through which this drug or supplement produces its pharmacological effect.
        /// </summary>
        [DataMember(Name = "mechanismOfAction", Order = 311)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? MechanismOfAction { get; set; } 

        /// <summary>
        /// The generic name of this drug or supplement.
        /// </summary>
        [DataMember(Name = "nonProprietaryName", Order = 312)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? NonProprietaryName { get; set; } 

        /// <summary>
        /// Proprietary name given to the diet plan, typically by its originator or creator.
        /// </summary>
        [DataMember(Name = "proprietaryName", Order = 313)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? ProprietaryName { get; set; } 

        /// <summary>
        /// Recommended intake of this supplement for a given population as defined by a specific recommending authority.
        /// </summary>
        [DataMember(Name = "recommendedIntake", Order = 314)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<RecommendedDoseSchedule>? RecommendedIntake { get; set; } 

        /// <summary>
        /// Any potential safety concern associated with the supplement. May include interactions with other drugs and foods, pregnancy, breastfeeding, known adverse reactions, and documented efficacy of the supplement.
        /// </summary>
        [DataMember(Name = "safetyConsideration", Order = 315)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? SafetyConsideration { get; set; } 

        /// <summary>
        /// Characteristics of the population for which this is intended, or which typically uses it, e.g. 'adults'.
        /// </summary>
        [DataMember(Name = "targetPopulation", Order = 316)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? TargetPopulation { get; set; } 
    }
}
