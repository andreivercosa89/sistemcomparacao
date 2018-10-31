using System;
namespace sistemacomparacao
{
    public class Comparacao
    {
        public int numero1Tela{
            set;get;
        }

        public int numero2Tela
        {
            set; get;
        }

        public string comparar(){
            if(numero1Tela > numero2Tela){
                return "Primeiro numero maior que o segundo";
            }else if(numero2Tela > numero1Tela){
                return "Segundo numero maior que o primeiro";
            }else{
                return "Os numero sao iguais";
            }
        }

    }
}
