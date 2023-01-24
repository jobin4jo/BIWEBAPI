using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BIWEBAPI.DataContracts.Models
{
    [BsonIgnoreExtraElements]
    public  class SkipOn
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string?  _id { get; set; }
        [BsonElement("skipon")]
        public string Skipon { get; set; }
        [BsonElement("home")]
        public string home { get; set; }


        //[BsonElement("thrillers")]
        //[JsonPropertyName("thrillers")]
        //public List<string> thrillers { get; set; }
        //[BsonElement("quotes")]
        ////[JsonPropertyName("quotes")]
        //public List<Quotes> quotes { get; set; }
        [BsonElement("signin")]
        public string signin { get; set; }
        [BsonElement("join")]
        public string join { get; set; }    


    }
    public class Thrillers
    {
        public int T_id { get; set; }   
        public string T_name { get; set; }  
    }
    public class Quotes
    {
        public int Q_id { get; set; }   
        public string Q_name { get; set; }  
    }
}
