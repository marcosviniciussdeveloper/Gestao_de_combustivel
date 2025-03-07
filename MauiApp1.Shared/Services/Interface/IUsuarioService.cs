using MauiApp1.Shared.Models;

namespace MauiApp1.Shared.Services.Interface
{


public interface IUsuarioService
{
    Task<List<Usuario>> ObterTodos();
    Task<Usuario?> ObterPorId(Guid id);
    Task<Usuario?> ObterPorCpf(string cpf);
    Task<bool> Registrar(Usuario usuario);
    Task<bool> Atualizar(Usuario usuario);
    Task<bool> Excluir(Guid id);
} 
    }
