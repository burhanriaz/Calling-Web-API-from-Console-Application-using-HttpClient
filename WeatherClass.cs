using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Calling_Web_API_from_Console_Application_using_HttpClient
{
    [DataContract]
    public  class RootObject
    {
        [DataMember]
        public coord coord { get; set; }
        [DataMember]
        public sys sys { get; set; }
        [DataMember]
        public main main { get; set; }
        [DataMember]
        public wind wind { get; set; }
        [DataMember]
        public List<weather>  weather { get; set; }

        [DataMember]
        public string @base { get; set; }
        [DataMember]
        public string visibility { get; set; }
        [DataMember]
        public string clouds { get; set; }
        [DataMember]
        public string dt { get; set; }
        [DataMember]
        public string timezone { get; set; }
        [DataMember]
        public string id { get; set; }
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public string cod { get; set; }

    }

    [DataContract]
    public class coord
    {
        [DataMember]
        public int lon { get; set; }
        [DataMember]
        public int lat { get; set; }

    }
    [DataContract]

    public class weather
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string main { get; set; }
        [DataMember]
        public string description { get; set; }
        [DataMember]
        public string icon { get; set; }

    }
    [DataContract]

    public class main
    {
        [DataMember]
        public string temp { get; set; }
        [DataMember]
        public string feels_like { get; set; }
        [DataMember]
        public string temp_min { get; set; }
        [DataMember]
        public string temp_max { get; set; }
        [DataMember]
        public string pressure { get; set; }
        [DataMember]
        public string humidity { get; set; }


    }
    [DataContract]

    public class wind
    {
        [DataMember]
        public string speed { get; set; }
        [DataMember]
        public string deg { get; set; }
        [DataMember]
        public string gust { get; set; }
    }

    [DataContract]
    public class sys
    {
        [DataMember]
        public string type { get; set; }
        [DataMember]
        public string id { get; set; }
        [DataMember]
        public string country { get; set; }
        [DataMember]
        public string sunrise { get; set; }
        [DataMember]
        public string sunset { get; set; }
    }



}
