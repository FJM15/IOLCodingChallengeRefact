using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Services
{
    public interface ITraductor
    {
        string GetTraduccion(string llave);
    }
}
