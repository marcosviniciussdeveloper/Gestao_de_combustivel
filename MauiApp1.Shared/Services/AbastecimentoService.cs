using MauiApp1.Shared.Models;
using MauiApp1.Shared.Services.Interface;
using Supabase;

namespace MauiApp1.Shared.Services
{
    public class AbastecimentoService : IAbastecimentoService
    {
        private readonly Client _supabase;

        public AbastecimentoService(Client supabase)
        {
            _supabase = supabase;
        }

        public async Task<bool> Registrar(Abastecimento abastecimento)
        {
            var response = await _supabase.From<Abastecimento>().Insert(abastecimento);
            return response.Models.Count > 0;
        }

        public async Task<List<Abastecimento>> ObterTodos()
        {
            var response = await _supabase.From<Abastecimento>().Get();
            return response.Models;
        }


        public async Task<List<Abastecimento>> ObterPorVeiculo(Guid veiculoId)
        {
            var response = await _supabase
                .From<Abastecimento>()
                .Where(x => x.VeiculoId == veiculoId)
                .Get();

            return response.Models;
        }

        public async Task<List<Abastecimento>> ObterPorData(DateTime startDate, DateTime endDate)
        {
            var response = await _supabase
                .From<Abastecimento>()
                .Where(x => x.Data >= startDate && x.Data <= endDate)
                .Get();

            return response.Models;
        }
        public async Task<bool> Atualizar(Abastecimento abastecimento)
        {
            var response = await _supabase
                .From<Abastecimento>()
                .Where(x => x.Id == abastecimento.Id)
                .Update(abastecimento);

            return response.Models.Count > 0;
        }


        public async Task<bool> Excluir(Guid id)
        {

            var registro = await _supabase
                .From<Abastecimento>()
                .Where(x => x.Id == id)
                .Get();

            if (registro.Models.Count == 0)
            {
                throw new KeyNotFoundException("Abastecimento não encontrado para exclusão.");
            }

            await _supabase
                .From<Abastecimento>()
                .Where(x => x.Id == id)
                .Delete();

            return true;
        }
    }
}