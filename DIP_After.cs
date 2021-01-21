namespace DIP.After
{
    public class Copy
    {
        IReader _reader;
        IWriter _writer;

        public Copy(IReader reader, IWriter writer)
        {
            _reader = reader;
            _writer = writer;
        }
        public void CopyTo()
        {    
            string copyText = _reader.ReadFrom();
            _writer.WriteTo(copyText);
        }
    }

    public interface IReader
    {
        public string ReadFrom();
    }

    public interface IWriter
    {
        public void WriteTo(string msg);
    }

    public class KeyboardReader : IReader
    {
        public string ReadFrom()
        {
            return "ReadFrom() function";
        }
    }
    
    public class FileReader : IReader
    {
        public string ReadFrom()
        {
            return "ReadFrom() function";
        }
    }
    
    public class PrinterWriter : IWriter
    {
        public void WriteTo(string msg)
        {
            //...
        }
    }
    
    public class FileWriter : IWriter
    {
        public void WriteTo(string msg)
        {
            //...
        }
    }

}
