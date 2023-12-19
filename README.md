# Stopwatch Console App

Este é um simples aplicativo de console que permite configurar um temporizador de contagem regressiva em segundos ou minutos. Quando o temporizador atinge zero, ele exibe uma mensagem "Stop Stopwatch". O usuário pode interagir com o programa por meio de um sistema de menu.

## Como Usar

1. Execute o aplicativo.
2. Escolha o formato da duração:
   - Digite o tempo em segundos: `10s` para 10 segundos.
   - Digite o tempo em minutos: `1m` para 1 minuto.
   - Digite `0` para sair do aplicativo.
3. O programa fornecerá uma contagem regressiva com uma sequência "Pronto", "Preparar" e "Iniciar" antes de iniciar o temporizador.
4. O temporizador contará até zero, e uma mensagem "Stop Stopwatch" será exibida.

## Estrutura do Código

### `Menu()`

- Limpa o console.
- Exibe a mensagem de boas-vindas e as instruções.
- Recebe a entrada do usuário para a duração desejada.
- Analisa a entrada para determinar o tempo e o tipo (segundos/minutos).
- Chama `PreStart()` ou sai do aplicativo com base na entrada do usuário.

### `PreStart(int time)`

- Limpa o console.
- Exibe uma sequência "Pronto", "Preparar" e "Iniciar" com atrasos de 1 segundo.
- Chama `Start(int time)` para iniciar a contagem regressiva.

### `Start(int time)`

- Executa um loop para contar regressivamente a partir do tempo especificado.
- Limpa o console e exibe o valor atual da contagem regressiva.
- Pausa por 1 segundo entre cada contagem.
- Exibe uma mensagem "Stop Stopwatch" quando a contagem regressiva atinge zero.

## Como Compilar

Compile o código usando um compilador C# (por exemplo, o comando `csc` ou um ambiente de desenvolvimento integrado).

```bash
WELCOME:
 S = Seconds => 10s = 10Seconds
 M = Minutes => 1m = 1 Minutes
 0 = To go out
How long do you want to count?

