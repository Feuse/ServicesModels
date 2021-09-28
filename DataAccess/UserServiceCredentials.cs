using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesModels
{
    public class UserServiceCredentials 
    {
        [BsonId]
        public string UserServiceId { get; set; }
        public Service Service { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Hash { get; set; }

    }
}
