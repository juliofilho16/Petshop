using Petshop.Borders.Dtos.Repositories.Funcionario;
using Petshop.Borders.Dtos.UseCase.Common;
using Petshop.Borders.Repositories.Contracts;
using Petshop.Borders.Shared;
using Petshop.Borders.UseCase.Funcionario;

namespace Petshop.UseCases.Funcionario
{
    public class UpdateFuncionarioUseCase : IUpdateFuncionarioUseCase
    {
        private readonly IFuncionarioRepository _funcionarioRepository;

        public UpdateFuncionarioUseCase(IFuncionarioRepository FuncionarioRepository)
        {
            _funcionarioRepository = FuncionarioRepository;
        }

        public UseCaseResponse<int?> Execute(UpdateRequestBase<UpdateFuncionarioDto> request)
        {
            var response = new UseCaseResponse<int?>();

            try
            {
                if (request == null || request.Id == 0 || request.ModelValue == null)
                    throw new ArgumentNullException(nameof(request));

                _funcionarioRepository.UpdateFuncionario(request.Id,request.ModelValue!);
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
