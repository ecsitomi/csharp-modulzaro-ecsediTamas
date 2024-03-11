using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    public partial class Jatekos
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("entry")]
        public string Entry { get; set; }

        /*
         * [JsonPropertyName("entry")]
        public string EntryString { get; set; }

        [JsonIgnore]
        public DateTime Entry
        {
            get { return DateTime.Parse(EntryString).ToLocalTime(); }
            set { EntryString = value.ToUniversalTime().ToString("o"); }
        }
        */

        [JsonPropertyName("rating")]
        public int Rating { get; set; }

        [JsonPropertyName("fullname")]
        public string Fullname { get; set; }
        
        [JsonPropertyName("interest")]
        public string Interest { get; set; }

        public override string ToString()
        {
            return $"{Id}, {Fullname}, {Rating}, {Entry}, {Interest}";
        }
        public string Kiiratas
        {
            get { return $"{Fullname}"; }
        }

        public static Jatekos[] FromJson(string json) //beolvasás json-ből
        {
            return JsonSerializer.Deserialize<Jatekos[]>(json);
        }

        public string ToJson() //kiiratás json-be
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
