using api_filmes_senai.Context;
using api_filmes_senai.Domains;
using api_filmes_senai.Interface;

namespace api_filmes_senai.Repositories
{
    /// <summary>
    /// Classe que vai implementar a interface IGeneroRepository
    /// Ou seja, vfamos implementar os metodos, toda a logica dos metodos
    /// </summary>

    public class GeneroRepository : IGeneroRepository
    {
        /// <summary>
        /// Classe que vai implementar a interface IGeneroRepository
        /// Ou seja, vfamos implementar os metodos, toda a logica dos metodos
        /// </summary>

        private readonly Filmes_Context _context;

            /// <summary>
            /// Construtor do repositorio
            /// Aqui toda vez que o construtor for chamado, os dados do contexto estaram disponiveis
            /// </summary>
            /// <param name="contexto">Dados do contexto</param>
        public GeneroRepository(Filmes_Context contexto)
        {
            _context = contexto;
        }

        public void Atualizar(Guid id, Genero genero)
        {
            throw new NotImplementedException();
        }

        public Genero BuscarPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Genero novoGenero)
        {
            try
            {
                //Adiciona um novo genero na tabela Generos(BD)
                _context.Genero.Add(novoGenero);

                //Apos o cadastro, salva as alteraçoes(BD)
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Deletar(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Genero> Listar()
        {
            try
            {
                List<Genero> listaGenero = _context.Genero.ToList();

                return listaGenero;
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
