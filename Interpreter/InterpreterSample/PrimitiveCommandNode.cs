namespace InterpreterSample
{
    // <primitive command> ::= go | right | left
    public class PrimitiveCommandNode : Node
    {
        private string _name;

        public override void Parse(Context context)
        {
            _name = context.CurrentToken();
            context.SkipToken(_name);
            if (!_name.Equals("go") && !_name.Equals("right") && !_name.Equals("left"))
            {
                throw new System.FormatException();
            }
        }

        public override string ToString()
        {
            return _name;
        }
    }
}