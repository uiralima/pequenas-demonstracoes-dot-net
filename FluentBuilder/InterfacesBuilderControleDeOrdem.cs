namespace FluentBuilder
{
    public interface IMontarCarro
    {
        Carro Montar();
    }

    public interface IEscolheMotor
    {
        IMontarCarro EscolheMotor(string motor);
    }

    public interface IEscolheCor
    {
        IEscolheMotor EcolheCor(string cor);
    }

    public interface IEscolheModelo
    {
        IEscolheCor EscolheModelo(string modelo);
    }

    public class Carro
    {
        public string Motor { get; set; }
        public string Cor { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public override string ToString()
        {
            return $"Marca: {this.Marca}, Modelo: {this.Modelo}, Cor: {this.Cor}, Motor: {this.Motor}";
        }
    }

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
            this._marca = marca;
        }
        public IEscolheMotor EcolheCor(string cor)
        {
            this._cor = cor;
            return this;
        }

        public IEscolheCor EscolheModelo(string modelo) 
        {
            this._modelo = modelo; 
            return this;
        }

        public IMontarCarro EscolheMotor(string motor)
        {
            this._motor = motor;
            return this;
        }

        public Carro Montar()
        {
            return new Carro()
            {
                Cor = this._cor,
                Motor = this._motor,
                Marca = this._marca,
                Modelo = this._modelo
            };
        }
    }

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
            this._marca = marca;
        }
        public CarroBuilderForcaMarca EcolheCor(string cor)
        {
            this._cor = cor;
            return this;
        }

        public CarroBuilderForcaMarca EscolheModelo(string modelo)
        {
            this._modelo = modelo;
            return this;
        }

        public CarroBuilderForcaMarca EscolheMotor(string motor)
        {
            this._motor = motor;
            return this;
        }

        public Carro Montar()
        {
            return new Carro()
            {
                Cor = this._cor,
                Motor = this._motor,
                Marca = this._marca,
                Modelo = this._modelo
            };
        }
    }

    public class CarroBuilderFluent : IMontarCarro
    {
        private string _cor;
        private string _modelo;
        private string _motor;
        private string _marca;

        public CarroBuilderFluent DaMarca(string marca)
        {
            this._marca = marca;
            return this;
        }
        
        public CarroBuilderFluent EcolheCor(string cor)
        {
            this._cor = cor;
            return this;
        }

        public CarroBuilderFluent EscolheModelo(string modelo)
        {
            this._modelo = modelo;
            return this;
        }

        public CarroBuilderFluent EscolheMotor(string motor)
        {
            this._motor = motor;
            return this;
        }

        public Carro Montar()
        {
            return new Carro()
            {
                Cor = this._cor,
                Motor = this._motor,
                Marca = this._marca,
                Modelo = this._modelo
            };
        }
    }
}
