using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace DocspiderWebAutomation.Utils.StringFormatter
{
    public static class Json
    {
        public static string JsonPrettify(string json)
        {
            using var stringReader = new StringReader(json);
            using var stringWriter = new StringWriter();
            var jsonReader = new JsonTextReader(stringReader);
            var jsonWriter = new JsonTextWriter(stringWriter) { Formatting = Formatting.Indented };
            jsonWriter.WriteToken(jsonReader);
            return stringWriter.ToString();
        }

        public static string SerializeIndented_Escaping(object obj)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                Encoder = System.Text.Encodings.Web.JavaScriptEncoder.Default

            };
            return System.Text.Json.JsonSerializer.Serialize(obj, options);
        }

        public static string LeitorJson(string path)
        {
            return File.ReadAllText(path);
        }
    }
}
