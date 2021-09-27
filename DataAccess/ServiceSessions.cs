using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesModels
{
    public class ServiceSessions
    {
        public string Id { get; set; }
        public string SerivceId { get; set; }
        public Service Service { get; set; }
        public string SessionId { get; set; }
        public string HiddenUrl { get; set; }
        public string XPing { get; set; }
        [BsonElement("expireAt")]
        public DateTime ExpireAt { get; set; }
    }
}
