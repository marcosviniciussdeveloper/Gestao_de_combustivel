using MauiApp1.Shared.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MauiApp1.Shared.Services.Interface  
{
    public interface IAbastecimentoService
    {
        Task<List<Abastecimento>> ObterTodos();
        Task<List<Abastecimento>> ObterPorVeiculo(Guid veiculoId);
        Task<List<Abastecimento>> ObterPorData(DateTime startDate, DateTime endDate);  
        Task<bool> Registrar(Abastecimento abastecimento);
        Task<bool> Atualizar(Abastecimento abastecimento);
        Task<bool> Excluir(Guid id);
    }
}
