using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_E_Task5
{
    public class Transport
    {
        public short Year;
        public short MaxSpeed;
        public string Brend;
        public string Model;

    }

    public class TCar:Transport
    {
        public byte NumSeats;
    }
    public class TMotorcycle : Transport
    {
        public bool HasSidecar;
    }
}
