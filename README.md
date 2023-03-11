
# Jogo da velha

Popular jogo da velha refeito para ser jogado em linhas de comando, feito para ser jogado com 2 jogadores.

## Guia básico de jogo da velha
<img src="https://user-images.githubusercontent.com/89887370/224200370-a36e5369-68db-4fab-b1d8-e48b7c42e66c.PNG" width="500" alt="Desenho de um tabuleiro de jogo da velha, as posições ainda estão vazias">

Dois jogadores competem pela vitória através de uma sequência de três caracteres iguais em uma linha, sendo ela horizontal, vertical ou diagonal.

Uma grade de quadrados 3X3 é desenhada na tela, os jogadores devem se decidir quem será o símbolo 'X' e qual será o 'O'

<img src="https://user-images.githubusercontent.com/89887370/224200464-b26632c9-a5d6-48b6-abc6-b933e0029d74.PNG" width="500" alt="Exemplo de vitória de jogador com o símbolo X através de uma sequência horizontal">

Se o tabuleiro for preenchido e não houver nenhum ganhador, temos o chamado de VELHA, em que há um empate e o jogo é encerrado.

<img src="https://user-images.githubusercontent.com/89887370/224200528-027ea535-4841-4ccb-a061-b61e502a0325.PNG" width="500" alt="Exemplo de jogo onde houve empate, nenhuma sequência por nenhum símbolo foi realizada">

## Como jogar
É muito simples de ser utilizado, ao rodar o executável, basta o jogador do símbolo atual escolher a posição desejada e teclar enter.

Após uma sucessão de jogadas, já é possível determinar se há uma vitória ou não, caso o tabuleiro seja totalmente preenchido sem um ganhador, teremos velha.

## Instalação

Baixe o arquivo .zip e o extraia. Procure a extensão .cs e abra o prompt de comando no diretório.

Insira o seguinte comando:
```cmd
  dotnet run
```
## Lógica de funcionamento

A lógica por trás do programa consiste em popular o tabuleiro 3X3 com um contador que vária de 1 à 9, após a escolha da posição pelo jogador, será feito um verificação se a posição é existente no tabuleiro e se é válida, caso negativo, ele deverá refazer a jogada.

Após cinco rodadas, já é possível verificar se há algum ganhador, caso positivo, será fim de jogo, do contrário, cada jogada posterior será verificada até uma vitória ou possível empate.

Com nove rodadas sem nenhum jogador vitorioso, o tabuleiro já estará completamente preenchido, resultando em empate, ou seja, fim de jogo.
Pronto!

![Diagrama da lógica do jogo da velha](https://user-images.githubusercontent.com/89887370/224202259-e6be7a1f-e1e6-4111-ae7d-82362d99ebd9.png)

## Autores
- [@LuisGuilherme](https://github.com/LuisGuilh3rme)
- [@SimoneSalvi](https://github.com/SimoneSalvi)
