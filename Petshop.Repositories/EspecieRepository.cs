using AutoMapper;
using Petshop.Borders.Dtos.Repositories.Especie;
using Petshop.Borders.Repositories.Contracts;
using Petshop.Entities.EntitiesContext;
using Petshop.Repositories.ConfigBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petshop.Repositories
{
    public class EspecieRepository : BaseRepository, IEspecieRepository
    {
        private IMapper _mapper;
        public EspecieRepository(IMapper mapper)
        {
            _mapper = mapper;
        }

        public void CreateEspecie(CreateEspecieDto createEspecieDto)
        {
            Especie Especie = _mapper.Map<Especie>(createEspecieDto);
            Create(Especie);
        }
        public ReadEspecieDto GetEspecie(int idEspecie)
        {
            var entity = GetById<Especie>(idEspecie);

            if (entity != null)
            {
                return _mapper.Map<ReadEspecieDto>(entity); ;
            }

            return null!;
        }
        public List<ReadEspecieDto> GetListEspecies()
        {
            var listEntitys = Contexto.Especie.ToList();

            if (listEntitys != null)
            {
                return _mapper.Map<List<ReadEspecieDto>>(listEntitys);
            }

            return null!;
        }

        public void UpdateEspecie(int idEspecie, UpdateEspecieDto updateEspecieDto)
        {
            Especie? entity = GetById<Especie>(idEspecie);

            if (entity == null)
            {
                throw new Exception("Especie não encontrada");
            }
            entity!.Descricao = updateEspecieDto.Descricao;
            Edit(entity);
        }
    }
}