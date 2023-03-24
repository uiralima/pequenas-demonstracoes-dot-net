namespace FluentBuilder.Interfaces
{
    // Disponibiliza o metodo para escolha do motor e retorna o construtor do carro uma vez que tudo já foi escolhido
    public interface IEscolheMotor
    {
        IMontarCarro EscolheMotor(string motor);
    }
}
