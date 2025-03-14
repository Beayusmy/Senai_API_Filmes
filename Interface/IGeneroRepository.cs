﻿using api_filmes_senai.Domains;

namespace api_filmes_senai.Interface
{
    /// <summary>
    /// Interface para genero : Contrato 
    /// Toda classe que herdar(implementar) essa interface, davera implementar todos os metodos definidos aqui dentro
    /// </summary>
    public interface IGeneroRepository
    {
        //CRUD: Metodos
        //C: Create : Listar todos os objetos
        //U: Update : Alterar um objeto
        //D: Delete : Deleto ou excluo um objeto

        //Metodo = TipoDeRetorno NomeDoMetodo(Argumentos)

        void Cadastrar(Genero novoGenero);

        List<Genero> Listar();

        void Atualizar(Guid id, Genero genero);

        void Deletar(Guid id);

        Genero BuscarPorId(Guid id);
    }
}
