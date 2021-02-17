/*
 Desafio
    O Governador do Estado quer saber sobre as taxas de crescimento das cidades. De acordo com 
 dados da população e a taxa de crescimento de duas cidades quaisquer (A e B), ele quer que você 
 calcule quantos anos levará para que a cidade menor (A) cresça mais em população que a cidade 
 maior (B).

    Claro que o Governador quer saber apenas para as cidades cuja taxa de crescimento da cidade 
 A é maior do que a taxa de crescimento da cidade B, portanto, previamente já separou para você 
 apenas os casos de teste que tem a taxa de crescimento maior para a cidade A.

    Desenvolva um programa que apresente o tempo, em anos, para cada caso.

    Porém, em alguns casos o tempo pode ser muito grande, e o Governador não se interessa em saber 
 exatamente o tempo para estes casos, já que ele pode não estar mais eleito. Basta que você informe, 
 nesta situação, a mensagem "Mais de 1 século.".

 Entrada
    A primeira linha da entrada contém um único inteiro T, indicando o número de casos de teste 
 (1 ≤ T ≤ 3000). Cada caso de teste contém 4 números: dois inteiros PA e PB (100 ≤ PA < 1000000, 
 PA < PB ≤ 1000000) indicando respectivamente a população de A e B, e dois valores G1 e G2 
 (0.1 ≤ G1 ≤ 10.0, 0.0 ≤ G2 ≤ 10.0, G2 < G1) com um digito após o ponto decimal cada, indicando 
 respectivamente o crescimento populacional de A e B (em percentual).

    Atenção: A população é sempre um valor inteiro, portanto, um crescimento de 2.5 % sobre uma 
 população de 100 pessoas resultará em 102 pessoas, e não 102.5 pessoas, enquanto um crescimento 
 de 2.5% sobre uma população de 1000 pessoas resultará em 1025 pessoas. Além disso, não utilize 
 variáveis de precisão simples para as taxas de crescimento.

 Saída
    Imprima, para cada caso de teste, quantos anos levará para que a cidade A ultrapasse a cidade 
 B em número de habitantes. Obs.: se o tempo for mais do que 100 anos o programa deve apresentar 
 a mensagem: Mais de 1 seculo. Neste caso, é melhor interromper o programa imediatamente após 
 passar de 100 anos, caso contrário você poderá receber como resposta da submissão deste problema 
 "Time Limit Exceeded".
*/

using System; 

class CrescimentoPopulacional {
    static void Main(string[] args) {
     Console.WriteLine("Digite Qunatas vezes Deseja Repetir:");
      int vT = Convert.ToInt32(Console.ReadLine());
      
      int vPa, vPb;
      int vAnos;
      
      double[] VArrayList = new double[4];
      double vCpa, vCpb;

      for (int i = 0; i < vT; i++)
      {
        vAnos = 0;
        Console.WriteLine("Digite o Valor Das Cidades:");
        string[] Vvalores = Console.ReadLine().Split();
        
        vPa = int.Parse(Vvalores[0]);
        vPb = int.Parse(Vvalores[1]);

        vCpa = double.Parse(Vvalores[2]);
        vCpb = double.Parse(Vvalores[3]);

        while (vPa <= vPb && vAnos < 101)
        {
          vPa += (int)((vPa*vCpa)/100);
          vPb += (int)((vPb*vCpb)/100);
          
          vAnos++;

            if (vAnos > 100)
            {
               Console.WriteLine("Mais de 1 seculo.");
            }
        }

        if (vAnos <= 100)
        {
           Console.WriteLine(vAnos + " anos.");
        }
    }   
  }
}
