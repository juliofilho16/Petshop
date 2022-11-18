using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Petshop.Borders.Dtos.Repositories.Funcionario;
using Petshop.Borders.Dtos.Repositories.Pessoa;
using Petshop.Borders.Repositories.Contracts;
using Petshop.Entities.EntitiesContext;
using Petshop.Repositories.ConfigBase;
using System.Transactions;

namespace Petshop.Repositories
{
    public class FuncionarioRepository : BaseRepository, IFuncionarioRepository
    {
        private IMapper _mapper;
        private readonly IPessoaRepository _pessoaRepository;
        public FuncionarioRepository(IMapper mapper, IPessoaRepository pessoaRepository)
        {
            _mapper = mapper;
            _pessoaRepository = pessoaRepository;
        }

        private Funcionario GetEntityById(int id)
        {
            return Contexto.Funcionario.Where(a => a.Id == id).Include(b => b.IdPessoaNavigation).First();
        }
        public int CreateFuncionario(CreateFuncionarioDto createFuncionarioDto)
        {
            try
            {
                int id = 0;
                using (var scope = new TransactionScope(TransactionScopeOption.RequiresNew))
                {
                    CreatePessoaDto pessoa = _mapper.Map<CreatePessoaDto>(createFuncionarioDto);
                    int idPessoa = _pessoaRepository.CreatePessoa(pessoa);
                    Funcionario Funcionario = _mapper.Map<Funcionario>(createFuncionarioDto);
                    Funcionario.IdPessoa = idPessoa;
                    Create(Funcionario);
                    scope.Complete();
                    id = Funcionario.Id;
                }
                return id;

            }
            catch (Exception)
            {
                throw;
            }
        }
        public ReadFuncionarioDto GetFuncionario(int idFuncionario)
        {
            var entity = GetEntityById(idFuncionario);
            if (entity != null)
            {
                return entity.toReadFuncionarioDto();
            }

            return null!;
        }
        public List<ReadFuncionarioDto> GetListFuncionarios()
        {
            var listEntitys = Contexto.Funcionario.Include(b => b.IdPessoaNavigation).ToList();

            if (listEntitys != null)
            {
                return listEntitys.Select(a => a.toReadFuncionarioDto()).ToList();
            }

            return null!;
        }
        public void UpdateFuncionario(int idFuncionario, UpdateFuncionarioDto updateFuncionarioDto)
        {
            Funcionario entity = GetEntityById(idFuncionario);

            if (entity == null)
            {
                throw new Exception("Funcionario não encontrada");
            }

            using (var scope = new TransactionScope(TransactionScopeOption.RequiresNew))
            {
                UpdatePessoaDto pessoa = _mapper.Map<UpdatePessoaDto>(updateFuncionarioDto);
                _pessoaRepository.UpdatePessoa(entity.IdPessoa, pessoa);

                _mapper.Map(updateFuncionarioDto, entity);
                Edit(entity);
                scope.Complete();
            }
        }
    }

}