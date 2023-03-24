namespace FluentBuilder.Interfaces
{
    // Disponibiliza o metodo para escolha do modelo e força para que a próxima escolha seja a cor
    public interface IEscolheModelo
    {
        IEscolheCor EscolheModelo(string modelo);
    }
}
