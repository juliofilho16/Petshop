using Petshop.Borders.Dtos.Repositories.Funcionario;
using Petshop.Borders.Repositories.Contracts;
using Petshop.Borders.Shared;
using Petshop.Borders.UseCase.Funcionario;

namespace Petshop.UseCases.Funcionario
{
    public class GetFuncionarioUseCase : IGetFuncionarioUseCase
    {
        private readonly IFuncionarioRepository _FuncionarioRepository;

        public GetFuncionarioUseCase(IFuncionarioRepository FuncionarioRepository)
        {
            _FuncionarioRepository = FuncionarioRepository;
        }

        public UseCaseResponse<ReadFuncionarioDto> Execute(UseCaseRequest<int> request)
        {
            var response = new UseCaseResponse<ReadFuncionarioDto>();

            try
            {
                if (request == null)
                    throw new ArgumentNullException(nameof(request));

                var FuncionarioResult = _FuncionarioRepository.GetFuncionario(request.RequestValue);
                response.SetResult(FuncionarioResult);
            }
            catch (Exception ex)
            {
                response.SetError(ex.Message, null);
            }

            return response;
        }
    }
}
