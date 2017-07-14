using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidaCpf2._0
{
    public class validaCpf
    {
        public static bool validaDig(string cpf)
        {
            

            cpf = cpf.Replace(",", "").Replace(" ", "").Replace("-", "").Replace(".", "");
            string cpf_result = cpf;
            if(cpf.Length != 11)
            {
                
               
                return false;
            }

         
            cpf = cpf.Substring(0, 9);

            int contador = 2, soma = 0, resto=0 ;
            string cpfv ="", result="";
            int[] dig1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] dig2 = new int[10] { 11,10, 9, 8, 7, 6, 5, 4, 3, 2 };
            

            // este for preenche meu array com meus 9 digitos
            for(int i = 0; i < cpf.Length; i++)
            {
                dig1[i] = int.Parse(cpf[i].ToString());

            }
            // decremento para pegar o CPF de tras para frente e fazer a soma 
            for(int i = cpf.Length - 1; i>0; i--)
            {
                soma = soma + dig1[i] * contador;
                contador = contador +1;
            }

            resto = soma % 11;

            if(resto < 2)
            {
                resto = 0;
                cpfv = cpf + resto;
            }
            else
            {
                resto = 11 - resto;
                cpfv = cpf + resto;
            }
            soma = 0;
            resto = 0;
            contador = 2;
            // alimentando meu segundo arry com o dig ja calculado
            for (int i = 0; i < cpfv.Length; i++)
            {
                dig2[i] = int.Parse(cpfv[i].ToString());
            }
            // fazendo a soma dos digitos
            for(int i = cpfv.Length - 1; i>0; i--)
            {
                soma = soma + dig2[i] * contador;
                contador = contador + 1;
            }
            resto = soma % 11;

            if(resto < 2)
            {
                resto = 0;
                result = cpfv + resto;
              
            }
            else
            {
                resto = 11 - resto;
                result = cpfv + resto;
     
            }
            if(result.Equals(cpf_result))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}