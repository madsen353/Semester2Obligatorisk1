using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrioteretKaldsKoe
{
    class PrioriteretOpkald : Opkald
    {
        
        private int opkaldsID { get; set; }
        public PrioriteretOpkald(int id)
        {
            this.opkaldsID = id;
        }
        public PrioriteretOpkald()
        {
            
        }
    }
}
