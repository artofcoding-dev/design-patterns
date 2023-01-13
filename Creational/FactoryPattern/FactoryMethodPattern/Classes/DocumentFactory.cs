using FactoryMethodPattern.Interfaces;

namespace FactoryMethodPattern.Classes
{
    public abstract class DocumentFactory
    {
        protected abstract IDocument ReadDocument();

        public IDocument LoadDocument()
        {
            return this.ReadDocument();
        }
    }
}