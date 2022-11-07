using System;

    class Pessoa
    {
        // Atributos
        public double peso;
        public double altura;

        //Método
        public double calculo()
        {
            return peso /(altura * altura);

        }
        // Situação
        
        public string situacao(double imc)
        {
            // Variavel
            string retorno;

            // Condicional
            if(imc <18.5)
            {
             retorno = "Abaixo do peso";
            }
            else if (imc < 25)
            retorno = "Peso Normal";

            else if(imc < 30)
            {
             retorno = "Acima do peso";
            }
            else if (imc < 35)
            retorno = "Obsidade I";

            else if(imc < 40)
            {
             retorno = "Obesidade II";
            }
            else
            {
                retorno = "Obesidade III";
            }
            //Retorno
            return retorno;
        }
        public void mensagem()
        {
            // Obter o cálculo
            double ObterCalculo = calculo();

            // Obter Situação
            string obterSituacao = situacao(ObterCalculo);

            // Exibir Mensagem
            Console.WriteLine("Seu IMC é de "+ObterCalculo);
            Console.WriteLine("Sua situação é "+obterSituacao);
        }

    }