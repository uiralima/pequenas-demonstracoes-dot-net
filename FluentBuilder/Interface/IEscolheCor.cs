namespace FluentBuilder.Interfaces
{
    // Disponibiliza o metodo para escolha da cor e força para que a próxima escolha seja o motor
    public interface IEscolheCor
    {
        IEscolheMotor EcolheCor(string cor);
    }
}
