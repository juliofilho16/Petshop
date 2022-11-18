using Petshop.Borders.Dtos.Repositories.Raca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petshop.Borders.Repositories.Contracts
{
    public interface IRacaRepository
    {
        List<ReadRacaDto> GetListRacas();
        ReadRacaDto GetRaca(int idRaca);
        void CreateRaca(CreateRacaDto createRacaDto);
        void UpdateRaca(int idRaca, UpdateRacaDto updateRacaDto);
    }
}
