using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoCRUD.Context;
using TrabalhoCRUD.Context.Menu;

namespace TrabalhoCRUD
{
    class Program
    {
        static void Main()
        {
            Console.Write("Digite o numero da tabela:  \n 1 - Funcionário \n 2 - Patrimônio \n 3 - Centro de Distribuição");
            var tabela = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o código que deseja excluir: ");
            var id = Convert.ToInt32(Console.ReadLine());
            Excluir.Executar(tabela, id);
            
        }
    }
}
