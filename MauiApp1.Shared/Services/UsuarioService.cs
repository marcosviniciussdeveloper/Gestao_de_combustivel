using Supabase;
using Supabase.Postgrest;
using MauiApp1.Shared.Models;
using static Supabase.Postgrest.Constants;
using Client = Supabase.Client;
using MauiApp1.Shared.Services.Interface;


namespace MauiApp1.Shared.Services;
public class UsuarioService(Supabase.Client _supabase) : IUsuarioService
{




    public async Task<List<Usuario>> ObterTodos()
    {
        var response = await _supabase.From<Usuario>().Get();
        return response.Models;
    }

    public async Task<Usuario?> ObterPorId(Guid id)
    {
        var response = await _supabase
            .From<Usuario>()
            .Filter("id", Operator.Equals, id)
            .Get();

        return response.Models.FirstOrDefault();
    }

    public async Task<Usuario?> ObterPorCpf(string cpf)
    {
        var response = await _supabase
            .From<Usuario>()
            .Filter("cpf", Operator.Equals, cpf)
            .Get();

        return response.Models.FirstOrDefault();
    }

    public async Task<bool> Registrar(Usuario usuario)
    {
        var response = await _supabase.From<Usuario>().Insert(usuario);
        return response.Models.Count > 0;
    }

    public async Task<bool> Atualizar(Usuario usuario)
    {
        var response = await _supabase
            .From<Usuario>()
            .Filter("id", Operator.Equals, usuario.Id)
            .Update(usuario);

        return response.Models.Count > 0;
    }

    public async Task<bool> Excluir(Guid id)
    {
        try
        {
            var response = await _supabase
                .Rpc("deleteUsuario", new { p_id = id.ToString() });

            return response != null;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao excluir Usuário: {ex.Message}");
            return false;
        }
    }
}

