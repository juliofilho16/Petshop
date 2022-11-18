using Petshop.Borders.Dtos.Repositories.Funcionario;
using Petshop.Borders.Repositories.Contracts;
using Petshop.Borders.Shared;
using Petshop.Borders.UseCase.Funcionario;

namespace Petshop.UseCases.Funcionario
{
    public class CreateFuncionarioUseCase : ICreateFuncionarioUseCase
    {
        private readonly IFuncionarioRepository _FuncionarioRepository;

        public CreateFuncionarioUseCase(IFuncionarioRepository FuncionarioRepository)
        {
            _FuncionarioRepository = FuncionarioRepository;
        }

        public UseCaseResponse<int> Execute(UseCaseRequest<CreateFuncionarioDto> request)
        {
            var response = new UseCaseResponse<int>();

            try
            {
                if (request == null || request.RequestValue == null)
                    throw new ArgumentNullException(nameof(request));

                var IdFuncionario = _FuncionarioRepository.CreateFuncionario(request.RequestValue!);
                response.SetResult(IdFuncionario);
            }
            catch (Exception ex)
            {
                response.SetError(ex.Message, null);
            }

            return response;

        }
    }
}
