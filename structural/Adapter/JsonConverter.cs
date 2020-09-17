using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Formatting = Newtonsoft.Json.Formatting;

namespace Adapter
{
    public class JsonConverter
    {
        public IEnumerable<Manufacturer> _manufacturers;

        public JsonConverter(IEnumerable<Manufacturer> manufacturers)
        {
            _manufacturers = manufacturers;
        }

        public void ConvertToJson()
        {

            var jsonManufacturers = JsonConvert.SerializeObject(_manufacturers, Formatting.Indented);

            Console.WriteLine("\nPrinting JSON list\n");
            Console.WriteLine(jsonManufacturers);
        }
    }
}