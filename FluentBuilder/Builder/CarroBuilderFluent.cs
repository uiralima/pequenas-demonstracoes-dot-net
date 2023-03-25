using FluentBuilder.Entidade;
using FluentBuilder.Interfaces;

namespace FluentBuilder.Builder
{

    public class CarroBuilderFluent : IMontarCarro
    {
        private string _cor;
        private string _modelo;
        private string _motor;
        private string _marca;

        public CarroBuilderFluent DaMarca(string marca)
        {
            _marca = marca;
            return this;
        }

        public CarroBuilderFluent EcolheCor(string cor)
        {
            _cor = cor;
            return this;
        }

        public CarroBuilderFluent EscolheModelo(string modelo)
        {
            _modelo = modelo;
            return this;
        }

        public CarroBuilderFluent EscolheMotor(string motor)
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
