﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quiron.LojaVirtual.Dominio.Entidades;

namespace Quiron.LojaVirtual.Dominio.Repositorio
{
    public class ProdutosRepositorio
    {
        private readonly EFDBContext _contexto = new EFDBContext();

        public IEnumerable<Produto> Produtos
        {
            get { return _contexto.Produtos; }
        }

    }
}
