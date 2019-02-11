using System.Text;

namespace Composite
{
    public abstract class Entry
    {
        internal Entry _parent;
        public abstract string GetName();
        public abstract int GetSize();

        public virtual Entry Add(Entry entry) 
        {
            throw new FileTreatmentException();
        }

        public void PrintList()
        {
            PrintList("");
        }

        internal abstract void PrintList(string prefix);

        public string GetFullName()
        {
            var builder = new StringBuilder();
            Entry entry = this;
            do
            {
                builder.Insert(0, $"/{entry.GetName()}");
                entry = entry._parent;
            } while (entry != null);
            return builder.ToString();
        }

        public override string ToString()
        {
            return GetName() + $" ({GetSize()})";
        }
    }
}