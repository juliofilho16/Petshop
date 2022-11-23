using AutoMapper;
using Petshop.Borders.Dtos.Repositories.Fornecedores;
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
    public class FornecedoresRepository : BaseRepository, IFornecedoresRepository
    {
        private IMapper _mapper;
        public FornecedoresRepository(IMapper mapper)
        {
            _mapper = mapper;
        }

        public int CreateFornecedor(CreateFornecedorDto createFornecedorDto)
        {
            Fornecedores Fornecedor = _mapper.Map<Fornecedores>(createFornecedorDto);
            Create(Fornecedor);
            return Fornecedor.Id;
        }
        public ReadFornecedoresDto GetFornecedor(int idFornecedor)
        {
            var entity = GetById<Fornecedores>(idFornecedor);

            if (entity != null)
            {
                return _mapper.Map<ReadFornecedoresDto>(entity); ;
            }

            return null!;
        }
        public List<ReadFornecedoresDto> GetListFornecedores()
        {
            var listEntitys = Contexto.Fornecedores.ToList();

            if (listEntitys != null)
            {
                return _mapper.Map<List<ReadFornecedoresDto>>(listEntitys);
            }

            return null!;
        }
        public List<ReadFornecedoresDto> GetFornecedoresProduto()
        {
            var listEntitys = Contexto.Fornecedores.ToList();

            if (listEntitys != null)
            {
                return _mapper.Map<List<ReadFornecedoresDto>>(listEntitys);
            }

            return null!;
        }
        public void UpdateFornecedor(int idFornecedor, UpdateFornecedorDto updateFornecedorDto)
        {
            Fornecedores? entity = GetById<Fornecedores>(idFornecedor);

            if (entity == null)
            {
                throw new Exception("Fornecedor não encontrada");
            }
            entity.fromUpdateFornecedoresDto(updateFornecedorDto);
            Edit(entity);
        }
        public void DeleteFornecedor(int idFornecedor)
        {
            Fornecedores? entity = GetById<Fornecedores>(idFornecedor);

            if (entity == null)
            {
                throw new Exception("Fornecedor não encontrado");
            }

            Delete(entity!);
        }
    }
}
