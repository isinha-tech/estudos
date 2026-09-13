using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudos.Controllers
{
    public class PessoaController
    {
        private List<Pessoa> pessoas = new List<Pessoa>();
        
        public void Inserir(Pessoa pessoa)
        {
            pessoas.Add(pessoa);
        }

        public bool Apagar(string nome)
        { 
            Pessoa pessoa = pessoas.FirstOrDefault(p => p.Nome == nome);
            if (pessoa != null)
            {
                pessoas.Remove(pessoa);
                return true;
            }
            return false;
        }

        public bool AlterarIdade(string nome, int novaIdade)
        {
            Pessoa pessoa = pessoas.FirstOrDefault(p => p.Nome == nome);
            if (pessoa != null)
            {
                pessoa.Idade = novaIdade;
                return true;
            }
            return false;
        }

        public List<Pessoa> Listar()
        {
            return pessoas;
        }

        public Pessoa Consultar(string nome)
        {
            return pessoas.FirstOrDefault(p => p.Nome == nome);
        }
    }
}
