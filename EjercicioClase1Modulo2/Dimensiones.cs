using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EjercicioClase1Modulo2
{
    public class Dimensiones
    {
        [JsonPropertyName("alto")]
        public double Alto { get; set; }
        [JsonPropertyName("ancho")]
        public double Ancho { get; set; }
        [JsonPropertyName("profundidad")]
        public double Profundidad { get; set; }
    }
}
