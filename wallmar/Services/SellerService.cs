using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using wallmar.Models;

namespace wallmar.Services
{
    //Essa é a classe responsavel por acessar a base de dados
    public class SellerService
    {
        //Cria uma propriedade (conexao com o banco de dados)
        private readonly wallmarContext _context;

        public SellerService(wallmarContext context ) {
            _context = context;
        }

        public List<Seller> FindAll() {
            /*Selecionar os Objetos da tabela Seller e Tranformar em uma lista.
             Por enquanto esse metodo está sincrono, ou seja quando essa operação
             for executada a aplicação vai ficar "parada/aguardando" um retorno*/
            return _context.Seller.ToList();

        }

    }
}
