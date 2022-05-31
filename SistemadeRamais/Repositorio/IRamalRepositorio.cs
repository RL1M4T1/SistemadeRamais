using SistemadeRamais.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemadeRamais.Repositorio
{
    public interface IRamalRepositorio
    {
        CadastroModel ListarporId(int id);
        List<CadastroModel> Buscartodos();
        CadastroModel Adicionar(CadastroModel cadastro);
        CadastroModel Editar(CadastroModel cadastro);
        CadastroModel Deletar(int id);
        CadastroModel MostrarMensagemTela(string pMensagem);
        CadastroModel Filtrar(string nome, string setor);
    }
}
