using MauiApp1.Shared.Models;
using MauiApp1.Shared.Services.Interface;

namespace MauiApp1.Shared.Services;

public class VeiculoService(Supabase.Client _supabase) : IVeiculoService
{


    public async Task<List<Veiculo>> ObterTodos()
    {
        return (await _supabase.From<Veiculo>().Get()).Models;
    }


    public async Task<Veiculo?> ObterPorId(Guid id)
    {
        var response = await _supabase
            .From<Veiculo>()
            .Where(x => x.Id == id)
            .Single();

        return response;
    }

    public async Task<Veiculo?> ObterPorPlaca(string placa)
    {
        var response = await _supabase
            .From<Veiculo>()
            .Where(x => x.Placa == placa)
            .Single();

        return response;
    }


    public async Task<bool> Registrar(Veiculo veiculo)
    {
        return (await _supabase.From<Veiculo>().Insert(veiculo)).Models.Count > 0;
    }

    public async Task<bool> Atualizar(Veiculo veiculo)
    {
        return (await _supabase.From<Veiculo>()
            .Where(x => x.Id == veiculo.Id)
            .Set(x => x.Modelo, veiculo.Modelo)
            .Update()).Models.Count > 0;
    }

    public async Task<bool> Excluir(Guid id)
    {
        await _supabase.From<Veiculo>().Where(x => x.Id == id).Delete();
        return true;
    }

}
