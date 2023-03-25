# FluentBuilder
Este reposit�rio tem o objetivo de apresentar um exemplo de implementa��o do padr�o de c�digo Fluent Builder.

## O que � o Fluent Builder?
O Fluent Builder � um padr�o de c�digo que tem como objetivo facilitar a cria��o de objetos complexos.

## Conte�do da demonstra��o
Mostrei nesse exemplo como criar um objeto complexo de forma simples e elegante passando por 3 exemplos:

### Builder/CarroBuilderFluente.cs
Nesse exemplo criei um objeto complexo de forma fluente, por�m possibilitando ao programador que utilizar� o builder escolher quais atributos ser�o utilizados na cria��o do objeto sem ser for�ado a utilizar nenhum deles.

### Builder/CarroBuilderForcaMarca.cs
Nesse exemplo forcei o programador a pelo menos informar a marca do carro, por�m ainda possibilitando que ele escolha quais outros atributos ser�o utilizados na cria��o do objeto.

### Builder/CarroBuilderOrdenado.cs
Nesse exemplo mostro como conseguir controlar a ordem de cria��o dos atributos do objeto, al�m de s� possibilitar que o programador crie a inst�ncia do objeto ap�s todos os atributos obrigat�rios terem sido informados. Utilizei uma cadeia de interfaces para tornar isso poss�vel.

