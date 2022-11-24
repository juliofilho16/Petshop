using Petshop.Borders.Dtos.Repositories.Funcionario;
using Petshop.Borders.Repositories.Contracts;
using Petshop.Borders.Shared;
using Petshop.Borders.UseCase.Funcionario;

namespace Petshop.UseCases.Funcionario
{
    public class DeleteFuncionarioUseCase : IDeleteFuncionarioUseCase
    {
        private readonly IFuncionarioRepository _FuncionarioRepository;

        public DeleteFuncionarioUseCase(IFuncionarioRepository FuncionarioRepository)
        {
            _FuncionarioRepository = FuncionarioRepository;
        }

        public UseCaseResponse<int?> Execute(UseCaseRequest<int> request)
        {
            var response = new UseCaseResponse<int?>();

            try
            {
                if (request == null)
                    throw new ArgumentNullException(nameof(request));

                _FuncionarioRepository.DeleteFuncionario(request.RequestValue);
                response.SetResult(null);
            }
            catch (Exception ex)
            {
                response.SetError(ex.Message, null);
            }

            return response;
        }
    }
}
