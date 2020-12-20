using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dischi
{
    class DVD
    {
        public List<Extra> x { get; set; }
        public List<Extra> GetExtra()
        {
            return x;
        }
    }
}
