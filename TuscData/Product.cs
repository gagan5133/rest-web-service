﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuscData
{
    [Serializable]
    public class Product
    {
        [JsonProperty("Id")]
        public int? Id;
        [JsonProperty("Name")]
        public string Name;
        [JsonProperty("Price")]
        public double Price;
        [JsonProperty("Quantity")]
        public int Quantity;
    }
}
