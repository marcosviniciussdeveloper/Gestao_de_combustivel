using Microsoft.Extensions.Logging;


namespace MauiApp1.Shared.Services
{
    public class AuthService
    {
        private readonly Supabase.Client _supabase;
        private readonly ILogger<AuthService> _logger;

        public AuthService(Supabase.Client supabase, ILogger<AuthService> logger)
        {
            _supabase = supabase;
            _logger = logger;
        }

        public async Task<bool> Register(string email, string senha)
        {
            try
            {
                var response = await _supabase.Auth.SignUp(email, senha);
                _logger.LogInformation("Usuário registrado com sucesso: {Email}", email);
                return response?.User != null;
            }
            catch (Exception ex)
            {
                _logger.LogError("Erro ao registrar usuário: {Message}", ex.Message);
                return false;
            }
        }
    }
}
