namespace Arvore.Interface
{
    public interface IArvore<T>
    {
        public T Buscar(T valor);

        public bool Inserir(T valor);

        public void Remover(T valor);


    }
}
