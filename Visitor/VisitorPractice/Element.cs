namespace VisitorPractice
{
    public interface Element
    {
       void Accept(Visitor v);
    }
}