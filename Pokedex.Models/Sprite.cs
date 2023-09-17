using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.Models
{
    public class Sprite
    {
        [JsonProperty("front_default")]
        public string Front { get; set; } = string.Empty;

        [JsonProperty("back_default")]
        public string Back { get; set; } = string.Empty;
    }
}
