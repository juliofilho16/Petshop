using AutoMapper;
using Petshop.Borders.Dtos.Repositories.Raca;
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
    public class RacaRepository : BaseRepository, IRacaRepository
    {
        private IMapper _mapper;
        public RacaRepository(IMapper mapper)
        {
            _mapper = mapper;
        }

        public void CreateRaca(CreateRacaDto createRacaDto)
        {
            Raca Raca = _mapper.Map<Raca>(createRacaDto);
            Create(Raca);
        }
        public ReadRacaDto GetRaca(int idRaca)
        {
            var entity = GetById<Raca>(idRaca);

            if (entity != null)
            {
                return _mapper.Map<ReadRacaDto>(entity); ;
            }

            return null!;
        }
        public List<ReadRacaDto> GetListRacas()
        {
            var listEntitys = Contexto.Raca.ToList();

            if (listEntitys != null)
            {
                return _mapper.Map<List<ReadRacaDto>>(listEntitys);
            }

            return null!;
        }

        public void UpdateRaca(int idRaca, UpdateRacaDto updateRacaDto)
        {
            Raca? entity = GetById<Raca>(idRaca);

            if (entity == null)
            {
                throw new Exception("Raca não encontrada");
            }
            entity!.Descricao = updateRacaDto.Descricao;
            Edit(entity);
        }
    }
}