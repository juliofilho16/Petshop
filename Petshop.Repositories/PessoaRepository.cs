using AutoMapper;
using Petshop.Borders.Dtos.Repositories.Pessoa;
using Petshop.Borders.Repositories.Contracts;
using Petshop.Entities.EntitiesContext;
using Petshop.Repositories.ConfigBase;

namespace Petshop.Repositories
{
    public class PessoaRepository : BaseRepository, IPessoaRepository
    {
        private IMapper _mapper;
        public PessoaRepository(IMapper mapper)
        {
            _mapper = mapper;
        }

        public int CreatePessoa(CreatePessoaDto createPessoaDto)
        {
            Pessoa Pessoa = _mapper.Map<Pessoa>(createPessoaDto);
            Create(Pessoa);
            return Pessoa.Id;
        }
        public ReadPessoaDto GetPessoa(int idPessoa)
        {
            var entity = GetById<Pessoa>(idPessoa);

            if (entity != null)
            {
                return _mapper.Map<ReadPessoaDto>(entity); ;
            }

            return null!;
        }
        public List<ReadPessoaDto> GetListPessoas()
        {
            var listEntitys = Contexto.Pessoa.ToList();

            if (listEntitys != null)
            {
                return _mapper.Map<List<ReadPessoaDto>>(listEntitys);
            }

            return null!;
        }
        public void UpdatePessoa(int idPessoa, UpdatePessoaDto updatePessoaDto)
        {
            Pessoa? entity = GetById<Pessoa>(idPessoa);

            if (entity == null)
            {
                throw new Exception("Pessoa não encontrada");
            }
            _mapper.Map(updatePessoaDto, entity);
            Edit(entity);
        }
    }
}