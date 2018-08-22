# Seleção de pessoa Desenvolvedora .Net Core
Se você chegou ate aqui é porque se interessou em ser um softplayer. 
Como temos muitas oportunidades para você colocar a mão na massa, queremos ver como você se sai com o cenário abaixo, que conseguiremos avaliar várias de suas competências.

## A demanda
Você deverá criar uma API com dois endpoints:

###  1) Calcula Juros
A primeira reponde pelo path relativo "/calculajuros"

Ela faz um cálculo em memória, de juros compostos, conforme abaixo:
Valor Final = Valor Inicial * (1 + juros) ^ Tempo

Valor inicial é um decimal recebido como parâmetro
Juros é 1% ou 0,01 (fixo no código)
Tempo é um inteiro, que representa meses, também recebido como parâmetro
^ representa a operação de potência
Resultado final deve ser truncado (sem arredondamento) em duas casas decimais

Exemplo: /calculajuros?valorinicial=100&meses=5
Resultado esperado: 105,10

### 2) Show me the code
Este responde pelo path relativo /showmethecode
Deverá retornar a url de onde encontra-se o fonte no github

Esperamos que a entrega tenha
1) Código fonte em asp.net core no github (Mostrar conhecimento básico de git)
2) Teste unitários (Mostrar conhecimento de testes unitários, se possível TDD)

## Extras
1) Teste de integração em linguagem de sua preferência
2) Utilização de Docker
3) O ideal é este código rodar em algum servidor seu, podemos combinar tempo que irá funcionar. Se não tiver avise o entrevistador.
4) Utilizar swagger

## Prazo e retorno
Isso será combinado com quem você fez a entrevista. Você terá tempo para entender o cenário e nos retornar um prazo.
Lembre-se: Prazo dado é prazo cumprido.

Boa sorte!