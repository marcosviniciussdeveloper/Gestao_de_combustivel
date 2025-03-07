
using MauiApp1.Shared.Models;
using MauiApp1.Shared.Services.Interface;
using Supabase;
using static Supabase.Postgrest.Constants;

namespace MauiApp1.Shared.Services
{
  
 public class ManutencaoService(Supabase.Client _supabase) : IManutencaoService
{
     


        public async Task<bool> Registrar(Manutencoes manutencao)
        {
            var response = await _supabase.From<Manutencoes>().Insert(manutencao);
            return response.Models.Count > 0;
        }

        public async Task<List<Manutencoes>> ObterTodas()
        {
            var response = await _supabase.From<Manutencoes>().Get();
            return response.Models;
        }

        public async Task<Manutencoes?> ObterPorId(Guid id)
        {
            var response = await _supabase
                .From<Manutencoes>()
                .Filter("id", Operator.Equals, id)
                .Single();

            return response;
        }

        public async Task<List<Manutencoes>> ObterPorVeiculo(Guid veiculoId)
        {
            var response = await _supabase
                .From<Manutencoes>()
                .Filter("id_veiculo", Operator.Equals, veiculoId)
                .Get();

            return response.Models;
        }

        public async Task<bool> Atualizar(Manutencoes manutencao)
        {
            var response = await _supabase
                .From<Manutencoes>()
                .Filter("id", Operator.Equals, manutencao.Id)
                .Update(manutencao);

            return response.Models.Count > 0;
        }


   public async Task<bool> Excluir(Guid id)
        {
   
            var registro = await _supabase
                .From<Manutencoes>()
                .Where(x => x.Id == id)
                .Get();

            if (registro.Models.Count == 0)
            {
                throw new KeyNotFoundException("Não foi encontrada nenhuma manutenção para excluir.");
            }
            await _supabase
                .From<Manutencoes>()
                .Where(x => x.Id == id)
                .Delete();

            return true; 
        }

    }
}
