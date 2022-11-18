using Petshop.Borders.Dtos.Repositories.Cliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petshop.Borders.Repositories.Contracts
{
    public interface IClienteRepository
    {
        List<ReadClienteDto> GetListClientes();
        ReadClienteDto GetCliente(int idCliente);
        int CreateCliente(CreateClienteDto createClienteDto);
        void UpdateCliente(int idCliente, UpdateClienteDto updateClienteDto);
    }
}
