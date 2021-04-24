using System;
using System.Collections.Generic;

namespace ProjetoAPI.Core
{
    public interface ICargoService
    {
        List<Cargo> GetCargos();

        Cargo AddCargo(Cargo cargo);
    }
}
