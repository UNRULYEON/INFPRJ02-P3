namespace Models
{
    using System;
    using System.Collections.Generic;
    using System.Net;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Root
    {
        [JsonProperty("odata.metadata")]
        public string OdataMetadata { get; set; }

        [JsonProperty("value")]
        public List<Value> Value { get; set; }
    }

    public partial class Value
    {
        [JsonProperty("ID")]
        public long Id { get; set; }

        [JsonProperty("Geslacht")]
        public string Geslacht { get; set; }

        [JsonProperty("Leeftijd")]
        public string Leeftijd { get; set; }

        [JsonProperty("Migratieachtergrond")]
        public string Migratieachtergrond { get; set; }

        [JsonProperty("Perioden")]
        public string Perioden { get; set; }

        [JsonProperty("BeroepsEnNietBeroepsbevolking_1")]
        public long? BeroepsEnNietBeroepsbevolking1 { get; set; }

        [JsonProperty("Beroepsbevolking_2")]
        public long? Beroepsbevolking2 { get; set; }

        [JsonProperty("WerkzameBeroepsbevolking_3")]
        public long? WerkzameBeroepsbevolking3 { get; set; }

        [JsonProperty("Werknemer_4")]
        public long? Werknemer4 { get; set; }

        [JsonProperty("WerknemerMetVasteArbeidsrelatie_5")]
        public long? WerknemerMetVasteArbeidsrelatie5 { get; set; }

        [JsonProperty("WerknemerMetFlexibeleArbeidsrelatie_6")]
        public long? WerknemerMetFlexibeleArbeidsrelatie6 { get; set; }

        [JsonProperty("Zelfstandige_7")]
        public long? Zelfstandige7 { get; set; }

        [JsonProperty("ZelfstandigeZonderPersoneelZzp_8")]
        public long? ZelfstandigeZonderPersoneelZzp8 { get; set; }

        [JsonProperty("ZelfstandigeMetPersoneel_9")]
        public long? ZelfstandigeMetPersoneel9 { get; set; }

        [JsonProperty("MeewerkendGezinslid_10")]
        public long? MeewerkendGezinslid10 { get; set; }

        [JsonProperty("PositieInDeWerkkringOnbekend_11")]
        public long? PositieInDeWerkkringOnbekend11 { get; set; }

        [JsonProperty("Deeltijd_12")]
        public long? Deeltijd12 { get; set; }

        [JsonProperty("MinderDan20UurPerWeek_13")]
        public long? MinderDan20UurPerWeek13 { get; set; }

        [JsonProperty("MinderDan12UurPerWeek_14")]
        public long? MinderDan12UurPerWeek14 { get; set; }

        [JsonProperty("k_12Tot20UurPerWeek_15")]
        public long? K12Tot20UurPerWeek15 { get; set; }

        [JsonProperty("k_20Tot35UurPerWeek_16")]
        public long? K20Tot35UurPerWeek16 { get; set; }

        [JsonProperty("k_20Tot28UurPerWeek_17")]
        public long? K20Tot28UurPerWeek17 { get; set; }

        [JsonProperty("k_28Tot35UurPerWeek_18")]
        public long? K28Tot35UurPerWeek18 { get; set; }

        [JsonProperty("Voltijd_19")]
        public long? Voltijd19 { get; set; }

        [JsonProperty("WerklozeBeroepsbevolking_20")]
        public long? WerklozeBeroepsbevolking20 { get; set; }

        [JsonProperty("Werkloosheidspercentage_21")]
        public double? Werkloosheidspercentage21 { get; set; }

        [JsonProperty("NietBeroepsbevolking_22")]
        public long? NietBeroepsbevolking22 { get; set; }

        [JsonProperty("BrutoArbeidsparticipatie_23")]
        public double? BrutoArbeidsparticipatie23 { get; set; }

        [JsonProperty("NettoArbeidsparticipatie_24")]
        public double? NettoArbeidsparticipatie24 { get; set; }
    }
    public partial class Value
    {
        public static Root FromJson(string json) =>JsonConvert.DeserializeObject<Root>(json);
    }
    
}