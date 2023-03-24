using FluentBuilder.Entidade;
using FluentBuilder.Interfaces;

namespace FluentBuilder.Builder
{
    public class CarroBuilderForcaMarca : IMontarCarro
    {
        public static CarroBuilderForcaMarca DaMarca(string marca)
        {
            return new CarroBuilderForcaMarca(marca);
        }

        private string _cor;
        private string _modelo;
        private string _motor;
        private string _marca;

        private CarroBuilderForcaMarca(string marca)
        {
            _marca = marca;
        }
        public CarroBuilderForcaMarca EcolheCor(string cor)
        {
            _cor = cor;
            return this;
        }

        public CarroBuilderForcaMarca EscolheModelo(string modelo)
        {
            _modelo = modelo;
            return this;
        }

        public CarroBuilderForcaMarca EscolheMotor(string motor)
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
