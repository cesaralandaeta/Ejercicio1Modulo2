using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EjercicioClase1Modulo2
{
    internal class RedSocialEjer1
    {

        [JsonPropertyName("usuario")]
        public string Usuario { get; set; }
        [JsonPropertyName("amigos_usuario")]
        public List<string> Amigos { get; set; }
        [JsonPropertyName("notificaciones_usuario")]
        public bool Notificacion { get; set; }
    }
}
