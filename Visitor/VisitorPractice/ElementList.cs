using System.Collections.Generic;

namespace VisitorPractice
{
    public class ElementList : Element
    {
        private List<Entry> _entries = new List<Entry>();

        public void Add(Entry entry)
        {
            _entries.Add(entry);
        }

        public IEnumerable<Entry> List
        {
            get
            {
                foreach (var entry in _entries)
                {
                    yield return entry;
                }
            }
        }

        public void Accept(Visitor visit)
        {
            foreach (var entry in List)
            {
                var element = (Element)entry;
                element.Accept(visit);
            }
        }
    }
}