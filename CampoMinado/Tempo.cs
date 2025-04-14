using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CampoMinado
{
    public class Tempo
    {
        public DateTime start;
        public DateTime finish;
        public double TempoJogo()
        {
            return (finish - start).TotalSeconds;
        }

    }
}
