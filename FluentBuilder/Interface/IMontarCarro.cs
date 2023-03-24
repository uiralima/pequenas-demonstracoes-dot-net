using FluentBuilder.Entidade;

namespace FluentBuilder.Interfaces
{
    //Interface que todo construtor de carro deve implementar retorna uma instância de carro
    public interface IMontarCarro
    {
        Carro Montar();
    }
}
