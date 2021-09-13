# Desafios Bootcamp Decola Tech avanade
> Projeto baseado nos desafios propostos pelo Bootcamp Decola Tech avanade
<a name="ancora"></a>

|       Desafio                  |            Tema do Desafio               |  Nível do Desafio |                   Respostas                   |
|--------------------------------|------------------------------------------|-------------------|-----------------------------------------------|
|      [Desafio 1](#ancora1)     |     Primeiros desafios Matemáticos em C# |      Básico       |      [Resolução](src/desafios/desafio_1.cs)   |   
|      [Desafio 2](#ancora2)     |     Primeiros desafios Matemáticos em C# |      Básico       |      [Resolução](src/desafios/desafio-2.cs)   |   
|      [Desafio 3](#ancora3)     |     Múltiplos                            |      Básico       |      [Resolução](src/desafios/desafio_3.cs)   |
|      [Desafio 4](#ancora4)     |     Números Ímpares                      |      Básico       |      [Resolução](src/desafios/desafio_4.cs)   |
|      [Desafio 5](#ancora5)     |     Conversão de Tempo                   |      Básico       |      [Resolução](src/desafios/desafio_5.cs)   |
|      [Desafio 6](#ancora6)     |     Tempo do Dobby                       |      Básico       |      [Resolução](src/desafios/desafio_6.cs)   |

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