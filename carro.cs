using System;
using System.Collections.Generic;
using System.Text;

namespace exercicio_sabado
{
    class carro
    {
        public string marca, modelo, paisdeOrigem;
       
        public carro(string marca1,string modelo1,string paisdeOrigem1)
         
        {
            marca = marca1;
            modelo = modelo1;
            paisdeOrigem = paisdeOrigem1;

        }
        public int qtdPortas() => 2;
        public double capacidadeTanque() => 95;
        public double autonomiaporLitro() => 5.5;
        public bool Flex() => false;
        public double distanciaPercorrida() => 100;      
        public double gastocombustivel() => (capacidadeTanque() * autonomiaporLitro());

        //  quantidadedeLitros = distancia * marcadodocarro;

        // mediacosumo = distanciapercorrida / combustivelgasto;
    }

}

