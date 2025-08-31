using minimal_api.Dominio.Enuns;

namespace minimal_api.Dominio.ModelViews;

public record AdministradorLogado
{

    public String Email { get; set; } = default!;
    public string Perfil { get; set; } = default!;
    public string Token { get; set; } = default!;
}