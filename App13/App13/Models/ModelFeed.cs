using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace App13.Models
{

    [Table("Feed")]
    class ModelFeed
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [NotNull]
        public String Nome { get; set; }
        [NotNull]
        public String Status { get; set; }
        [NotNull]
        public String Valor { get; set; }
        [NotNull]
        public String Rua { get; set; }
        [NotNull]
        public String Bairro { get; set; }
        [NotNull]
        public String Cidade { get; set; }
        [NotNull]
        public String Disponivel { get; set; }
        [NotNull]
        public String Sobre { get; set; }
        [NotNull]
        public String ImagemUrl { get; set; }
        [NotNull]
        public String VideoUrl { get; set; }

        public ModelFeed()
        {
            this.Id = 0;
            this.Nome = "";
            this.Status = "";
            this.Valor = "";
            this.Rua = "";
            this.Bairro = "";
            this.Cidade = "";
            this.Disponivel = "";
            this.Sobre = "";
            this.ImagemUrl = "";
            this.VideoUrl = "";
        }

        [Table("Favorito")]
        class ModelFavorito
        {
            [PrimaryKey, AutoIncrement]
            public int Id { get; set; }
            [NotNull]
            public String Nome { get; set; }
            [NotNull]
            public String Status { get; set; }
            [NotNull]
            public String Valor { get; set; }
            [NotNull]
            public String Rua { get; set; }
            [NotNull]
            public String Bairro { get; set; }
            [NotNull]
            public String Cidade { get; set; }
            [NotNull]
            public String Disponivel { get; set; }
            [NotNull]
            public String Sobre { get; set; }
            [NotNull]
            public String ImagemUrl { get; set; }
            [NotNull]
            public String VideoUrl { get; set; }


            public void favoritando()
            {
                this.Nome = Nome;
                this.Status = Status;
                this.Valor = Valor;
                this.Rua = Rua;
                this.Bairro = Bairro;
                this.Cidade = Cidade;
                this.Disponivel = Disponivel;
                this.Sobre = Sobre;
                //this.ImagemUrl = Imageurl;
                //this.VideoUrl = Videourl;
            }
        }
    }
}
