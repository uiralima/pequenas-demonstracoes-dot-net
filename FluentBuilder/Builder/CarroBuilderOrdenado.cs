using FluentBuilder.Entidade;
using FluentBuilder.Interfaces;

namespace FluentBuilder.Builder
{
    public class CarroBuilderOrdenado : IEscolheModelo, IEscolheCor, IEscolheMotor, IMontarCarro
    {
        public static IEscolheModelo DaMarca(string marca)
        {
            return new CarroBuilderOrdenado(marca);
        }

        private string _cor;
        private string _modelo;
        private string _motor;
        private string _marca;

        private CarroBuilderOrdenado(string marca)
        {
            _marca = marca;
        }
        public IEscolheMotor EcolheCor(string cor)
        {
            _cor = cor;
            return this;
        }

        public IEscolheCor EscolheModelo(string modelo)
        {
            _modelo = modelo;
            return this;
        }

        public IMontarCarro EscolheMotor(string motor)
        {
            _motor = motor;
            return this;
        }

        public Carro Montar()
        {
            return new Carro()
            {
                Cor = _cor,
                Motor = _motor,
                Marca = _marca,
                Modelo = _modelo
            };
        }
    }
}
