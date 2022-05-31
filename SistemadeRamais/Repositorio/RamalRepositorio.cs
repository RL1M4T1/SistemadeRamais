using SistemadeRamais.Data;
using SistemadeRamais.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemadeRamais.Repositorio
{
    public class RamalRepositorio : IRamalRepositorio
    {
        private readonly BancoContext _bancoContext;

        public RamalRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public List<CadastroModel> Buscartodos()
        {
            return _bancoContext.TAB_RAMAIS.ToList();
        }

        public CadastroModel Adicionar(CadastroModel cadastro)
        {

            //gravar no Banco de dados
            _bancoContext.TAB_RAMAIS.Add(cadastro);
            _bancoContext.SaveChanges();

            return cadastro;
        }

        public CadastroModel Editar(CadastroModel cadastro)
        {
            CadastroModel cadastroDB = ListarporId(cadastro.ID);

            if (cadastroDB == null)     
            {
                MostrarMensagemTela("Houve um erro na atualização do Cadastro!");                
            }
            cadastroDB.COLABORADOR_VC_RAMAL = cadastro.COLABORADOR_VC_RAMAL;
            cadastroDB.FILIAL_VC_RAMAL = cadastro.FILIAL_VC_RAMAL;
            cadastroDB.RAMAL_CH_RAMAL = cadastro.RAMAL_CH_RAMAL;
            cadastroDB.SETOR_VC_RAMAL = cadastro.SETOR_VC_RAMAL;

            _bancoContext.Update(cadastroDB);
            _bancoContext.SaveChanges();
            return cadastroDB;
        }

        public CadastroModel ListarporId(int id)
        {
            return _bancoContext.TAB_RAMAIS.FirstOrDefault(x => x.ID == id);
        }

        public CadastroModel Deletar(int id)
        {
            CadastroModel cadastroEx = ListarporId(id);
            if (cadastroEx == null)
                throw new System.Exception("Houve um erro na Exclusão do Cadastro!");

            _bancoContext.Remove(cadastroEx);
            _bancoContext.SaveChanges();

            return cadastroEx;
        }

        public CadastroModel MostrarMensagemTela(string pMensagem)
        {
            throw new System.Exception(pMensagem);
        }

        public CadastroModel Filtrar(string nome, string setor)
        {

            if (nome != null && setor != null)
                return MostrarMensagemTela("Não é permitida duas formas de pesquisa, selecione Colaborador ou Setor.");
            if (nome != null && setor == null)
                return _bancoContext.TAB_RAMAIS.FirstOrDefault(x => x.COLABORADOR_VC_RAMAL == nome);
            if (nome == null && setor != null)
                return _bancoContext.TAB_RAMAIS.FirstOrDefault(x => x.SETOR_VC_RAMAL == setor);
            else
                return MostrarMensagemTela("Nenhum dados encontrado.");

        }
    }
}
