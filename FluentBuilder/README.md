#FluentBuilder
Este repositório tem o objetivo de apresentar um exemplo de implementação do padrão de projeto Fluent Builder.

##O que é o Fluent Builder?
O Fluent Builder é um padrão de código que tem como objetivo facilitar a criação de objetos complexos.

##Conteúdo da demonstração
Mostrei nesse exemplo como criar um objeto complexo de forma simples e elegante passando por 3 exemplos:

###Builder/CarroBuilderFluente.cs
Nesse exemplo criei um objeto complexo de forma fluente, porém possibilitando ao programador que utilizará o builder escolher quais atributos serão utilizados na criação do objeto sem ser forçado a utilizare nenhum deles.

###Builder/CarroBuilderForcaMarca.cs
Nesse exemplo forcei o programador a pelo menos informar a marca do carro, porém ainda possibilitamos que ele escolha quais outros atributos serão utilizados na criação do objeto.

###Builder/CarroBuilderOrdenado.cs
Nesse exemplo mostro como conseguir controlar a ordem de criação dos atributos do objeto, além de só possibilitar que o programador crie a instância do objeto após todos os atributos obrigatórios terem sido informados. Utilizei uma cadeia de interfaces para tornar isso possível.

