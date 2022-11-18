using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Petshop.Borders.Dtos.Repositories.Endereco;
using Petshop.Borders.Dtos.Repositories.Endereco;
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
    public class EnderecoRepository : BaseRepository, IEnderecoRepository
    {
        private IMapper _mapper;
        public EnderecoRepository(IMapper mapper)
        {
            _mapper = mapper;
        }

        private Endereco _GetEntityById(int id)
        {
            return Contexto.Endereco.Where(a => a.Id == id)
                                    .Include(b => b.IdPessoaNavigation)
                                    .Include(b => b.IdCidadeNavigation)
                                    .Include(c => c.IdCidadeNavigation.IdEstadoNavigation)
                                    .First();
        }
        public int CreateEndereco(int idPessoa, CreateEnderecoDto createEnderecoDto)
        {
            Endereco Endereco = _mapper.Map<Endereco>(createEnderecoDto);
            Endereco.IdPessoa = idPessoa;
            Create(Endereco);
            return Endereco.Id;
        }
        public void DeleteEndereco(int idEndereco)
        {
            Endereco? entity = GetById<Endereco>(idEndereco);

            if (entity == null)
            {
                throw new Exception("Endereco não encontrada");
            }

            Delete(entity!);
        }
        public ReadEnderecoDto GetEndereco(int idEndereco)
        {
            var entity = _GetEntityById(idEndereco);
            if (entity != null)
            {
                return entity.toReadEnderecoDto();
            }

            return null!;
        }
        public List<ReadEnderecoDto> GetListEnderecos(int idPessoa)
        {
            var listEntitys = Contexto.Endereco.Where(a=>a.IdPessoa == idPessoa)
                                    .Include(b => b.IdPessoaNavigation)
                                    .Include(b => b.IdCidadeNavigation)
                                    .Include(c => c.IdCidadeNavigation.IdEstadoNavigation).ToList();

            if (listEntitys != null)
            {
                return listEntitys.Select(a => a.toReadEnderecoDto()).ToList();
            }

            return null!;
        }
        public void UpdateEndereco(int idEndereco, UpdateEnderecoDto updateEnderecoDto)
        {
            Endereco? entity = GetById<Endereco>(idEndereco);

            if (entity == null)
            {
                throw new Exception("Endereco não encontrada");
            }
            entity.Logradouro = updateEnderecoDto.Logradouro;
            entity.IdCidade = updateEnderecoDto.IdCidade;
            entity.Bairro = updateEnderecoDto.Bairro;
            entity.Numero = updateEnderecoDto.Numero;
            entity.Cep = updateEnderecoDto.Cep;
            entity.Complemento = updateEnderecoDto.Complemento;

            Edit(entity);
        }
    }
}