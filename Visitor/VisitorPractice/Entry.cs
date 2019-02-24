using System.Collections;
using System.Text;
using VisitorPractice;

namespace Composite
{
    public abstract class Entry : Element, IEnumerable
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

        public virtual IEnumerator GetEnumerator()
        {
            throw new FileTreatmentException();
        }

        public virtual void Accept(Visitor v)
        {
            throw new FileTreatmentException();
        }
    }
}