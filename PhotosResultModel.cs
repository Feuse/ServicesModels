using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesModels
{
    public class PhotosResultModel
    {
        [JsonProperty("photo_id")]
        public string PhotoId { get; set; }
        [JsonProperty("photo_url")]
        public string PhotoUrl { get; set; }
    }
}
