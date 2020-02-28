using System.Collections.Generic;

namespace TorneioDeLuta
{
    public class Fighter
    {
        public int id { get; set; }
        public string nome { get; set; }
        public int idade { get; set; }
        public List<string> artesMarciais { get; set; }
        public int lutas { get; set; }
        public int derrotas { get; set; }
        public int vitorias { get; set; }
    }
}