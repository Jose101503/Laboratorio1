using Laboratorio1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laboratorio1.Service
{
    public interface IOperacion
    {
        Double Porcentaje(Accion accion);
    }
}
