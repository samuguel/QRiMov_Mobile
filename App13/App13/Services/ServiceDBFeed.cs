using App13.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace App13.Services
{
    class ServiceDBFeed
    {
        SQLiteConnection conn;
        public string Mensagem { get; set; }
        public ServiceDBFeed(string Caminho)
        {
            if (Caminho == "")
                Caminho = App.Caminho;

            conn = new SQLiteConnection(Caminho); // define o banco
            conn.CreateTable<ModelFeed>(); // cria tabela
        }

        public void Inserir(ModelFeed fav)
        {
            // Validacao para saber se tem titulo e dados

            try
            {
                /*if (string.IsNullOrEmpty(notas.Titulo))
                    throw new Exception("Titulo da Nota não Informado");
                if (string.IsNullOrEmpty(notas.Dados))
                    throw new Exception("Dados da Nota não Informado");*/
                int result = conn.Insert(fav);
                if (result != 0)
                {
                    this.Mensagem =
                    string.Format("{0} registro adicionado em favoritos", result);
                }
                else
                {
                    string.Format("0 registro(s) adicionado(s): Erro, entre em contato com a administração!");
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public List<ModelFeed> Listar()
        {
            List<ModelFeed> lista = new List<ModelFeed>();
            try
            {
                lista = conn.Table<ModelFeed>().ToList();
                this.Mensagem = "Listagem dos favoritos";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return lista;
        }

        /*public void Alterar(ModelFeed notas)
        {
            try
            {
                if (string.IsNullOrEmpty(notas.Titulo))
                    throw new Exception("Titulo da Nota não Informado");
                if (string.IsNullOrEmpty(notas.Dados))
                    throw new Exception("Dados da Nota não Informado");
                if (notas.Id <= 0)
                    throw new Exception("Id da Nota não Informado");
                int result = conn.Update(notas);
                Mensagem = string.Format(" {0} Registros Alterados.", result);

            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("Erro:  {0}", ex.Message));
            }
        }*/
        
        /*public void Excluir(int Id)
        {
            try
            {
                int result = conn.Table<ModelFeed>().Delete
                    (registro => registro.Id == Id);
                Mensagem = string.Format(" {0} Registros Deletados.", result);

            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("Erro:  {0}", ex.Message));
            }
        }*/

        /*public List<ModelFeed> Localizar(string titulo)
        {
            List<ModelFeed> lista = new List<ModelFeed>();
            try
            {
                var resp = from p in conn.Table<ModelFeed>()
                           where p.Titulo.ToLower().Contains(titulo.ToLower())
                           select p;

                lista = resp.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("Erro:  {0}", ex.Message));
            }
            return lista;
        }

        public ModelFeed PegarNota(int id)
        {
            ModelFeed m = new ModelFeed();
            try
            {
                m = conn.Table<ModelFeed>().First(n => n.Id == id);
                Mensagem = "Encontrou a Nota";
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("Erro:  {0}", ex.Message));
            }
            return m;
        }*/



    }
}