using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoCRUD.Context.Menu
{
    public class Excluir
    {
        public static void Executar(int tabela, int id)
        {
            if (tabela == 1)
            {
                ExcluirFuncionario(id);
            }
            else if (tabela == 2)
            {
                ExcluirPatrimonio(id);
            }
            else if (tabela == 3)
            {
                ExcluirCD(id);
            }

        }
        public static void ExcluirFuncionario(int id)
        {
            var context = new DistribuicaoContext();


            var funcionario = context.Funcionarios.FirstOrDefault(q => q.Id == id);
            if (funcionario != null)
            {
                context.Funcionarios.Remove(funcionario);
                Console.Write($"Funcionário {id} excluido com sucesso! ");
            }


            else
                Console.WriteLine("Este código não existe");

            context.SaveChanges();
        }
        public static void ExcluirPatrimonio(int id)
        {
            var context = new DistribuicaoContext();

            var patrimonio = context.Patrimonios.FirstOrDefault(q => q.Id == id);
            if (patrimonio != null)
            {

                context.Patrimonios.Remove(patrimonio);
                Console.Write($"Patrimonio {id} excluido com sucesso! ");
            }
            else
                Console.WriteLine("Este código não existe");

            context.SaveChanges();
        }
        public static void ExcluirCD(int id)
        {
            Console.Write($"O que você deseja fazer com os funcionários e patrimonios associados ao codigo {id}?");
            Console.Write($"1 - Para excluir \n2 - Para alterar \n..");
            var excluir = Convert.ToInt32(Console.ReadLine());
            if (excluir == 1)
            {
                var context = new DistribuicaoContext();

                var cd = context.CentrosDistribuicao.FirstOrDefault(q => q.Id == id);
                if (cd != null)
                {
                    var funcionario = context.Funcionarios.FirstOrDefault(q => q.Id == id);
                    if (funcionario != null)
                        context.Funcionarios.Remove(funcionario);
                    var patrimonio = context.Patrimonios.FirstOrDefault(q => q.Id == id);
                    if (patrimonio != null)
                        context.Patrimonios.Remove(patrimonio);

                    context.CentrosDistribuicao.Remove(cd);
                    Console.Write($"Patrimonio {id} excluido com sucesso! ");
                }
                else
                    Console.WriteLine("Este código não existe");
                context.SaveChanges();
            }
            else if(excluir==2)
            {
                // escrever codigo de alterar aqui
            }

        }
    }
}
