namespace FluentBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var carro1 = new CarroBuilderFluent()
                //.DaMarca("Fiat")
                //.EscolheModelo("Uno")
                //.EcolheCor("Vermelho")
                //.EscolheMotor("1.0")
                .Montar();
            Console.WriteLine(carro1);

            var carro2 = CarroBuilderForcaMarca
                .DaMarca("Fiat")
                //.EscolheModelo("Uno")
                .EcolheCor("Vermelho")
                .EscolheMotor("1.0")
                .Montar();
            Console.WriteLine(carro2);

            var carro3 = CarroBuilderOrdenado
                .DaMarca("Fiat")
                .EscolheModelo("Uno")
                .EcolheCor("Vermelho")
                .EscolheMotor("1.0")
                .Montar();
            Console.WriteLine(carro3);

            Console.ReadKey();
        }
    }
}