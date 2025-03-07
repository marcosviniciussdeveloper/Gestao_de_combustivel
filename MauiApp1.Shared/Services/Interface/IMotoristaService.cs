using MauiApp1.Shared.Models;

public interface IMotoristaService
{
    Task<List<Motorista>> ObterTodos();
    Task<Motorista?> ObterPorId(Guid id);
    Task<bool> Registrar(Motorista motorista);
    Task<bool> Atualizar(Motorista motorista);
    Task<bool> Excluir(Guid id);
}
