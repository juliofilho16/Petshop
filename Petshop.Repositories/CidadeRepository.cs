using AutoMapper;
using Petshop.Borders.Dtos.Repositories.Cidade;
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
    public class CidadeRepository : BaseRepository, ICidadeRepository
    {
        private IMapper _mapper;
        public CidadeRepository(IMapper mapper)
        {
            _mapper = mapper;
        }

        public void CreateCidade(CreateCidadeDto createCidadeDto)
        {
            Cidade Cidade = _mapper.Map<Cidade>(createCidadeDto);
            Create(Cidade);
        }
        public ReadCidadeDto GetCidade(int idCidade)
        {
            var entity = GetById<Cidade>(idCidade);

            if (entity != null)
            {
                return _mapper.Map<ReadCidadeDto>(entity); ;
            }

            return null!;
        }
        public List<ReadCidadeDto> GetListCidades()
        {
            var listEntitys = Contexto.Cidade.ToList();

            if (listEntitys != null)
            {
                return _mapper.Map<List<ReadCidadeDto>>(listEntitys);
            }

            return null!;
        }

        public void UpdateCidade(int idCidade, UpdateCidadeDto updateCidadeDto)
        {
            Cidade? entity = GetById<Cidade>(idCidade);

            if (entity == null)
            {
                throw new Exception("Cidade não encontrada");
            }
            entity!.Nome = updateCidadeDto.Nome;
            Edit(entity);
        }
    }
}