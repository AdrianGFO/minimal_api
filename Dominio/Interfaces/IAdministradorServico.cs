using minimal_api.Dominio.Entidades;
using minimal_api.DTOs;

namespace minimal_api.Dominio.Interfaces;

public interface iAdministradorServico
{
    Administrador? Login(LoginDTO loginDTO);

    Administrador Incluir(Administrador administrador);

    List<Administrador> Todos(int? pagina);

    Administrador? BuscarPorId(int id);


}