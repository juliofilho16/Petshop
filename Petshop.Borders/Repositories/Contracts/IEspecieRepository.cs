using Petshop.Borders.Dtos.Repositories.Especie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petshop.Borders.Repositories.Contracts
{
    public interface IEspecieRepository
    {
        List<ReadEspecieDto> GetListEspecies();
        ReadEspecieDto GetEspecie(int idEspecie);
        void CreateEspecie(CreateEspecieDto createEspecieDto);
        void UpdateEspecie(int idEspecie, UpdateEspecieDto updateEspecieDto);
    }
}
