using System;

    namespace aula004
    {
        class program
        {
            static void Main(string[] args)
            {
                //instanciar um objeto
                Pessoa p = new Pessoa();
                p.peso = 40;
                p.altura = 1.71;
                p.mensagem();
            }
        }
    }