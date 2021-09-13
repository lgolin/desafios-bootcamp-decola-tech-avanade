# Desafios Bootcamp Decola Tech avanade
> Projeto baseado nos desafios propostos pelo Bootcamp Decola Tech avanade
<a name="ancora"></a>

|       Desafio                  |            Tema do Desafio               |  Nível do Desafio |                   Respostas                   |
|--------------------------------|------------------------------------------|-------------------|-----------------------------------------------|
|      [Desafio 1](#ancora1)       |     Soma Simples            |      Básico       |      [Resolução](src/desafios/desafio_1.cs)   |   
|      [Desafio 2](#ancora2)       |     DDD                     |      Básico       |      [Resolução](src/desafios/desafio-2.cs)   |   
|      [Desafio 3](#ancora3)       |     Múltiplos               |      Básico       |      [Resolução](src/desafios/desafio_3.cs)   |
|      [Desafio 4](#ancora4)       |     Números Ímpares         |      Básico       |      [Resolução](src/desafios/desafio_4.cs)   |
|      [Desafio 5](#ancora5)       |     Conversão de Tempo      |      Básico       |      [Resolução](src/desafios/desafio_5.cs)   |
|      [Desafio 6](#ancora6)       |     Tempo do Dobby          |      Básico       |      [Resolução](src/desafios/desafio_6.cs)   |
|      [Desafio 7](#ancora7)       |     Tipo de Combustível     |      Básico       |      [Resolução](src/desafios/desafio_7.cs)   |
|      [Desafio 8](#ancora8)       |     O Maior                 |      Básico       |      [Resolução](src/desafios/desafio_8.cs)   |
|      [Desafio 9](#ancora9)       |     Validação de Nota       |      Básico       |      [Resolução](src/desafios/desafio_9.cs)   |
|      [Desafio 10](#ancora10)     |     Tipos de Triângulos     |      Básico       |      [Resolução](src/desafios/desafio_10.cs)  |
|      [Desafio 11](#ancora11)     |     Sequência Lógica 2      |      Básico       |      [Resolução](src/desafios/desafio_11.cs)  |
|      [Desafio 12](#ancora12)     |     Coordenadas de um Ponto |      Básico       |      [Resolução](src/desafios/desafio_12.cs)  |

****
## <a id="ancora1"></a>[Desafio 1](#ancora)
Leia dois valores inteiros identificados como variáveis A e B. Calcule a soma entre elas e chame essa variável de SOMA.
A seguir escreva o valor desta variável.

### Entrada
O arquivo de entrada contém 2 valores inteiros.

### Saída
Imprima a variável SOMA com todas as letras maiúsculas, inserindo um espaço em branco antes e depois do símbolo de igualdade, seguido pelo valor correspondente à soma de A e B.

|  Exemplos de Entrada  |  Exemplos de Saída  |    
|-----------------------|---------------------|
|        10             |      Soma = 40      |    
|        30             |                     |
****
## <a id="ancora2"></a>[Desafio 2](#ancora2)
Leia um número inteiro que representa um código de DDD para discagem interurbana. Em seguida, informe à qual cidade o DDD pertence, considerando a tabela abaixo:
Se a entrada for qualquer outro DDD que não esteja presente na tabela acima, o programa deverá informar:
DDD nao cadastrado
****
### Entrada
A entrada consiste de um único valor inteiro.

### Saída
Imprima o nome da cidade correspondente ao DDD existente na entrada. Imprima DDD nao cadastrado caso não existir DDD correspondente ao número digitado.

|  Exemplos de Entrada  |  Exemplos de Saída  |    
|-----------------------|---------------------|
|        11             |    Sao Paulo        |    
****
## <a id="ancora3"></a>[Desafio 3](#ancora3)
Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao Multiplos", indicando se os valores lidos são múltiplos entre si.

### Entrada
A entrada contém valores inteiros.

### Saída
A saída deve conter uma das mensagens conforme descrito acima.

|  Exemplos de Entrada  |  Exemplos de Saída  |    
|-----------------------|---------------------|
|        6 24           |    Sao Multiplos    |    
|        6 25           |  Nao sao Multiplos  |    

****
## <a id="ancora4"></a>[Desafio 4](#ancora4)
Leia um valor inteiro X (1 <= X <= 1000). Em seguida mostre os ímpares de 1 até X, um valor por linha, inclusive o X, se for o caso.

### Entrada
O arquivo de entrada contém 1 valor inteiro qualquer.

### Saída
Imprima todos os valores ímpares de 1 até X, inclusive X, se for o caso.

|  Exemplos de Entrada  |  Exemplos de Saída  |    
|-----------------------|---------------------|
|        8              |    1 - 3 - 5 - 7    |

****
## <a id="ancora5"></a>[Desafio 5](#ancora5)
Você terá o desafio de ler um valor inteiro, que é o tempo de duração em segundos de um determinado evento em uma loja, e informe-o expresso no formato horas:minutos:segundos.

### Entrada
O arquivo de entrada contém um valor inteiro N.

### Saída
Imprima o tempo lido no arquivo de entrada (segundos), convertido para horas:minutos:segundos, conforme exemplo fornecido.

|  Exemplos de Entrada  |  Exemplos de Saída  |    
|-----------------------|---------------------|
|        556              |    0:9:16    |

****
## <a id="ancora6"></a>[Desafio 6](#ancora6)
Para dar conta de toda a fabricação dos presentes de Natal, por várias vezes os elfos precisam ficar até tarde trabalhando para que tudo possa ser terminado a tempo.

Para melhor gerenciar seus cronogramas, os elfos estipularam quantos minutos são necessários para fabricar cada presente.

Já está quase no final do expediente, e um dos elfos pediu sua ajuda.

Faltam N minutos para a hora de ir embora, e restam dois presentes para o elfo Dobby fabricar. Ajude-o a descobrir se ele conseguirá fabricar os dois ainda hoje, ou se deve deixar o trabalho para amanhã.

### Entrada
Cada caso de teste inicia com um inteiro N, indicando quantos minutos faltam para o final do expediente (2 <= N <= 100).

Em seguida haverá dois inteiros A e B, indicando quantos minutos são necessários para fabricar os dois presentes que Dobby precisa fabricar (1 <= A, B <= 100).

### Saída
Imprima uma linha, contendo a frase "Farei hoje!" caso seja possível fabricar os dois presentes antes do final do expediente, ou "Deixa para amanha!" caso contrário.

|  Exemplos de Entrada  |  Exemplos de Saída  |    
|-----------------------|---------------------|
|        20 15 6        |  Deixa para amanha! |

****
## <a id="ancora7"></a>[Desafio 7](#ancora7)
Você recebeu desafio para determinar qual dos produtos é o preferêncial dos clientes de um posto de abastecimento de combustível. Para isso você deve escrever um algoritmo para ler o tipo de combustível abastecido (codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel 4.Fim). Caso o usuário informe um código inválido (fora da faixa de 1 a 4) deve ser solicitado um novo código (até que seja válido). O programa será encerrado quando o código informado for o número 4.

### Entrada
A entrada contém apenas valores inteiros e positivos.

### Saída
Deve ser escrito a mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível, conforme exemplo.

|  Exemplos de Entrada  |  Exemplos de Saída  |    
|-----------------------|---------------------|
|       8    |  MUITO OBRIGADO     |
|        1       |  Alcool: 1          |
|       7       |  Gasolina: 2 |
|        2        |  Diesel: 3 |

****
## <a id="ancora8"></a>[Desafio 8](#ancora8)
Desenvolva um programa capaz de ler três valores e apresentar o maior deles e adicionar a mensagem “ eh o maior”. Use a seguinte forma como base:



Obs.: a fórmula apenas calcula o maior entre os dois primeiros (a e b). Um segundo passo, portanto é necessário para chegar no resultado esperado.

### Entrada
O arquivo de entrada contém três valores inteiros.

### Saída
Imprima o maior dos três valores seguido pela mensagem " eh o maior".

|  Exemplos de Entrada  |  Exemplos de Saída  |    
|-----------------------|---------------------|
|       7 14 106        | 106 eh o maior      |
|        217 14 6       |  217 eh o maior     |


****
## <a id="ancora9"></a>[Desafio 9](#ancora9)
Para ajudar a calcular as notas referentes às duas avaliações dos alunos, uma professora pediu para que você desenvolva um programa que calcule e imprima a média semestral. Faça com que o algoritmo só aceite notas válidas (uma nota válida deve pertencer ao intervalo [0,10]). Cada nota deve ser validada separadamente.

### Entrada
A entrada contém vários valores reais, positivos ou negativos. O programa deve ser encerrado quando forem lidas duas notas válidas.

### Saída
Se uma nota inválida  for lida, deve ser impressa a mensagem "nota invalida".
Quando duas notas válidas forem lidas, deve ser impressa a mensagem "media = " seguido do valor do cálculo. O valor deve ser apresentado com duas casas após o ponto decimal.

|  Exemplos de Entrada  |  Exemplos de Saída  |    
|-----------------------|---------------------|
|       -3.5            | Nota Invalida       |
|        11             |  media = 6.5        |


****
****
## <a id="ancora10"></a>[Desafio 10](#ancora10)
Leia 3 valores de ponto flutuante A, B e C e ordene-os em ordem decrescente, de modo que o lado A representa o maior dos 3 lados. A seguir, determine o tipo de triângulo que estes três lados formam, com base nos seguintes casos, sempre escrevendo uma mensagem adequada:

se A ≥ B+C, apresente a mensagem: NAO FORMA TRIANGULO
se A2 = B2 + C2, apresente a mensagem: TRIANGULO RETANGULO
se A2 > B2 + C2, apresente a mensagem: TRIANGULO OBTUSANGULO
se A2 < B2 + C2, apresente a mensagem: TRIANGULO ACUTANGULO
se os três lados forem iguais, apresente a mensagem: TRIANGULO EQUILATERO
se apenas dois dos lados forem iguais, apresente a mensagem: TRIANGULO ISOSCELES

### Entrada
A entrada contem três valores de ponto flutuante de dupla precisão A (0 < A) , B (0 < B) e C (0 < C).

### Saída
Imprima todas as classificações do triângulo especificado na entrada.

|  Exemplos de Entrada  |  Exemplos de Saída  |    
|-----------------------|---------------------|
|       7.0 5.0 7.0            | TRIANGULO ACUTANGULO <br> TRIANGULO ISOSCELES       |


****
## <a id="ancora11"></a>[Desafio 11](#ancora11)
Você terá desafio de escrever um programa que leia dois valores X e Y. A seguir, mostre uma sequência de 1 até Y, passando para a próxima linha a cada X números.

### Entrada
O arquivo de entrada contém dois valores inteiros, (1 < X < 20) e (X < Y < 100000).

### Saída
Cada sequência deve ser impressa em uma linha apenas, com 1 espaço em branco entre cada número, conforme exemplo abaixo. Não deve haver espaço em branco após o último valor da linha.

|  Exemplos de Entrada  |  Exemplos de Saída  |    
|-----------------------|---------------------|
|       3 99           | 1 2 3 <br> 4 5 6 <br> 7 8 9       |

****

## <a id="ancora12"></a>[Desafio 12](#ancora12)
Leia 2 valores com uma casa decimal (x e y), que devem representar as coordenadas de um ponto em um plano. A seguir, determine qual o quadrante ao qual pertence o ponto, ou se está sobre um dos eixos cartesianos ou na origem (x = y = 0).

Se o ponto estiver na origem, escreva a mensagem “Origem”.
Se o ponto estiver sobre um dos eixos escreva “Eixo X” ou “Eixo Y”, conforme for a situação.


### Entrada
A entrada contem as coordenadas de um ponto.

### Saída
A saída deve apresentar o quadrante em que o ponto se encontra.

|  Exemplos de Entrada  |  Exemplos de Saída  |    
|-----------------------|---------------------|
|      4.5 -2.2         | Q4                  |

****