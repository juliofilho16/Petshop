using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Petshop.Borders.Dtos.Repositories.Cliente;
using Petshop.Borders.Dtos.Repositories.Pessoa;
using Petshop.Borders.Repositories.Contracts;
using Petshop.Entities.EntitiesContext;
using Petshop.Repositories.ConfigBase;
using System.Transactions;

namespace Petshop.Repositories
{
    public class ClienteRepository : BaseRepository, IClienteRepository
    {
        private IMapper _mapper;
        private readonly IPessoaRepository _pessoaRepository;
        public ClienteRepository(IMapper mapper, IPessoaRepository pessoaRepository)
        {
            _mapper = mapper;
            _pessoaRepository = pessoaRepository;
        }

        private Cliente _GetEntityById(int id)
        {
            return Contexto.Cliente.Where(a => a.Id == id).Include(b => b.IdPessoaNavigation).FirstOrDefault();
        }
        public int CreateCliente(CreateClienteDto createClienteDto)
        {
            try
            {
                int id = 0;
                using (var scope = new TransactionScope(TransactionScopeOption.RequiresNew))
                {
                    CreatePessoaDto pessoa = _mapper.Map<CreatePessoaDto>(createClienteDto);
                    int idPessoa = _pessoaRepository.CreatePessoa(pessoa);
                    Cliente cliente = _mapper.Map<Cliente>(createClienteDto);
                    cliente.IdPessoa = idPessoa;
                    Create(cliente);
                    scope.Complete();
                    id = cliente.Id;
                }
                return id;

            }
            catch (Exception)
            {
                throw;
            }
        }
        public ReadClienteDto GetCliente(int idCliente)
        {
            var entity = _GetEntityById(idCliente);
            if (entity != null)
            {
                return entity.toReadClienteDto();
            }

            return null!;
        }
        public List<ReadClienteDto> GetListClientes()
        {
            var listEntitys = Contexto.Cliente.Include(b => b.IdPessoaNavigation).ToList();

            if (listEntitys != null)
            {
                return listEntitys.Select(a => a.toReadClienteDto()).ToList();
            }

            return null!;
        }
        public void UpdateCliente(int idCliente, UpdateClienteDto updateClienteDto)
        {
            Cliente entity = _GetEntityById(idCliente);

            if (entity == null)
            {
                throw new Exception("Cliente não encontrada");
            }

            using (var scope = new TransactionScope(TransactionScopeOption.RequiresNew))
            {
                UpdatePessoaDto pessoa = _mapper.Map<UpdatePessoaDto>(updateClienteDto);
                _pessoaRepository.UpdatePessoa(entity.IdPessoa, pessoa);

                _mapper.Map(updateClienteDto, entity);
                Edit(entity);
                scope.Complete();
            }
        }
        public void DeleteCliente(int idCliente)
        {
            Cliente entity = _GetEntityById(idCliente);
            var pessoa = Contexto.Cliente.Where(a => a.Id == entity.IdPessoa).FirstOrDefault();

            if (entity == null || pessoa == null)
            {
                throw new Exception("Cliente não encontrado");
            }

            using (var scope = new TransactionScope(TransactionScopeOption.RequiresNew))
            {
                Delete(pessoa!);
                Delete(entity!);
                scope.Complete();
            }

        }
    }

}