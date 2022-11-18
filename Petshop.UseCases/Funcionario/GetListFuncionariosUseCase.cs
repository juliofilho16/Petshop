using Petshop.Borders.Dtos.Repositories.Funcionario;
using Petshop.Borders.Repositories.Contracts;
using Petshop.Borders.Shared;
using Petshop.Borders.UseCase.Funcionario;

namespace Petshop.UseCases.Funcionario
{
    public class GetListFuncionariosUseCase : IGetListFuncionariosUseCase
    {
        private readonly IFuncionarioRepository _FuncionarioRepository;

        public GetListFuncionariosUseCase(IFuncionarioRepository FuncionarioRepository)
        {
            _FuncionarioRepository = FuncionarioRepository;
        }

        public UseCaseResponse<List<ReadFuncionarioDto>> Execute(UseCaseRequest<int> request)
        {
            var response = new UseCaseResponse<List<ReadFuncionarioDto>>();

            try
            {
                if (request == null)
                    throw new ArgumentNullException(nameof(request));

                var list = _FuncionarioRepository.GetListFuncionarios();
                response.SetResult(list);
            }
            catch (Exception ex)
            {
                response.SetError(ex.Message, null);
            }

            return response;
        }
    }
}
