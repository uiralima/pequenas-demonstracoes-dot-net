namespace FluentBuilder.Entidade
{
    public class Carro
    {
        public string Motor { get; set; }
        public string Cor { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public override string ToString()
        {
            return $"Marca: {Marca}, Modelo: {Modelo}, Cor: {Cor}, Motor: {Motor}";
        }
    }
}
