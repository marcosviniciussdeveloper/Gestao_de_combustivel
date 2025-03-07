using MauiApp1.Shared.Models;
using Supabase;


namespace MauiApp1.Shared.Services
{
    public class MotoristaService(Supabase.Client _supabase) : IMotoristaService
    {
        public async Task<List<Motorista>> ObterTodos()
        {
            var response = await _supabase.From<Motorista>().Get();
            return response.Models;
        }

        public async Task<Motorista?> ObterPorId(Guid id)
        {
            var response = await _supabase
                .From<Motorista>()
                .Where(x => x.Id == id)
                .Get();

            return response.Models.FirstOrDefault();
        }

        public async Task<bool> Registrar(Motorista motorista)
        {
            var response = await _supabase.From<Motorista>().Insert(motorista);
            return response.Models.Count > 0;
        }

        public async Task<bool> Atualizar(Motorista motorista)
        {
            var response = await _supabase
                .From<Motorista>()
                .Where(x => x.Id == motorista.Id)
                .Update(motorista);

            return response.Models.Count > 0;
        }
        public async Task<bool> Excluir(Guid id)
        {
   
            var registro = await _supabase
                .From<Motorista>()
                .Where(x => x.Id == id)
                .Get();

            if (registro.Models.Count == 0)
            {
                throw new KeyNotFoundException("Motorista não encontrado para exclusão.");
            }
            await _supabase
                .From<Motorista>()
                .Where(x => x.Id == id)
                .Delete();

            return true; 
        }

    }
}
