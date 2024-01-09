namespace LibraryInteractionTest
{
    public class Class1
    {
        private readonly string[] _contents;
        private int _index;
        public Class1(params string[] args)
        {
            _contents = args;
            _index = 0;
        }

        public string? OutputText()
        {
            if (_index < _contents.Length)
            {
                _index++;
                return _contents[_index - 1];
            }
            else
            {
                _index = 0;
                return null;
            }
        }

    }
}
