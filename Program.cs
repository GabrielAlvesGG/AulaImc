using System;

namespace AulaImc
{
    class Program
    {
        static void Main(string[] args)
        {
     
     
     
     
     
     
    // Tipos de Variaveis
     // strings = asjldfjalsjfldksajdlsajfkasljlss, 
     // int =  1 2 3 4 5 6 7 8 9 
    // 


     //      string                   NomeUsuario             =                       "Gabriel" ;
     // O tipo de variavel /   Assinatura / (Variável)    /    Atribuição     / valor da assinatura ou nome da variável  /
            Console.WriteLine("Bem-vindos Ao calculo de imc.");
            
            //Nome do Paciente
            Console.WriteLine("Digite o nome do paciente :");               // Fase 1 - Pegar o nome do paciente
            string NomePaciente = Console.ReadLine();
        
            

            //Altura do Paciente
            Console.WriteLine("Digite a sua altura : ");                    // Fase 2 - Pegar a altura do paciente.                
            double AlturaPaciente = double.Parse(Console.ReadLine());

            //Peso do Paciente
            Console.WriteLine("Digite seu peso: ");                         // Fase 3 - Pegar o peso do paciênte.
            double PesoPaciente = Convert.ToDouble(Console.ReadLine());


            double ImcPaciente =  PesoPaciente / ( AlturaPaciente * AlturaPaciente);    // Fase 4  -  Calculo do Imc do paciente 
            
            
            //Melhorias dos Resultados da " fase - 5 "
            string Resultado = "";
            if (ImcPaciente  < 18.5 )
            {
                Resultado = " Você tá o puro pó ";
            }
            else if(ImcPaciente  < 24  )
            {
                Resultado = " Você está em ótima forma parece o Thor !"  ;
            }
            else if(ImcPaciente < 29.9){
                Resultado = " Tá ficando gordão";
            }
            else if(ImcPaciente < 34.4){
                Resultado = "Cuidado que tá ficando obeso no grau 1 ";
            }
            else if( ImcPaciente < 39.9){
                Resultado = "Cuidado que o  barato tá louco e o clima tá tenso gordão vai passa mal"; 
            }
            else{
                Resultado = "cuidado daqui é muito perigoso, faça uma dieta grau 3 (morbida)";                
            }
              //Melhorias dos Resultados da " fase - 5 "
            
            
            
            Console.WriteLine("Nome: "  + NomePaciente  ); 
            Console.WriteLine( " altura :" + AlturaPaciente + "m" );            // Fase 5 - Mostrar o resultado (Melhorias, mostrar Classifição dos Pacientes).
            Console.WriteLine( " Peso : " + PesoPaciente + " kg");
            Console.WriteLine( " Imc do Paciente : " + ImcPaciente );
            Console.WriteLine(" status do paciente: " + Resultado);
            Console.ReadLine();







            
        }
    }
}
