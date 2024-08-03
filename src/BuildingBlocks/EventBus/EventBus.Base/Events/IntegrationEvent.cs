using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventBus.Base.Events
{
    public class IntegrationEvent
    {

        [JsonProperty]
        public Guid Id { get; set; } = Guid.NewGuid();
        [JsonProperty]
        public DateTime CreateDate { get; set; } = DateTime.Now;


    }
}
