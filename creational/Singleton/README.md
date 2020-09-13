## Problema

Implementar uma classe Impressora a qual pertence a uma empresa. Os atributos dessa
impressora são: marca, endereço IP e número da porta. Sabe-se que nessa empresa os
funcionários só tem permissão de imprimir em uma impressora única, cuja marca é “HP
Deskjet F300 Series” e endereço de IP é “10.211.55.1” e porta é “9100”.
Nesta empresa tem 3 funcionários. Os atributos dos funcionários são matricula e nome.
Estes funcionários frequentemente solicitam impressões na empresa, acessando o método
“print()” contido em Impressora. Este método tem como parâmetro a matricula do
funcionário.
Quando um funcionário deseja fazer uma impressão, uma nova variável do tipo Impressora
é declarada. Contudo, a instância em memória deve ser a única impressora que os
funcionários podem utilizar.
Ao solicitar uma impressão, neste exercício, deve-se imprimir no console (e.g.,
System.out.println( ) ) a matricula do funcionário que solicitou, o endereço de memória da
instância da impressora, também imprime o nome, endereço IP e a porta da impressora.