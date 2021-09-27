using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesModels
{
    public class Message 
    {
        public Guid MessageId { get; set; }

        public string UserId { get; set; }

        public int Likes { get; set; }

        public Service Service { get; set; }

        public DateTime Time { get; set; }
        public MessageType Type { get; set; }
        public object Price { get; set; }
        public int Repeat { get; set; }
    }
}
