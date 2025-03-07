using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MauiApp1.Shared.Models;

namespace MauiApp1.Shared.Services.Interface
{
    public interface IManutencaoService
    {
        Task<bool> Registrar(Manutencoes manutencao);
        Task<List<Manutencoes>> ObterTodas();
        Task<List<Manutencoes>> ObterPorVeiculo(Guid veiculoId);
        Task<Manutencoes?> ObterPorId(Guid id);
        Task<bool> Atualizar(Manutencoes manutencao);
        Task<bool> Excluir(Guid id);
    }
}
