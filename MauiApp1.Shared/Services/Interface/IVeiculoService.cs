using MauiApp1.Shared.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MauiApp1.Shared.Services.Interface  
{
    public interface IVeiculoService
    {
        Task<List<Veiculo>> ObterTodos();  
        Task<Veiculo?> ObterPorId(Guid id);
        Task<Veiculo?> ObterPorPlaca(string placa);
        Task<bool> Registrar(Veiculo veiculo);
        Task<bool> Atualizar(Veiculo veiculo);
        Task<bool> Excluir(Guid id);
    }
}
