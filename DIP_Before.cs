namespace DIP.Before
{
    public class Copy
    {
        KeyboardReader _keyboardReader;
        PrinterWriter _printerWriter;

        public Copy()
        {
            _keyboardReader = new KeyboardReader();
            _printerWriter = new PrinterWriter();
        }
        public void CopyTo()
        {    
            string copyText = _keyboardReader.ReadKeyboard();
            _printerWriter.WritePrinter(copyText);
        }
    }

    public class KeyboardReader
    {
        public string ReadKeyboard()
        {   
            // ....
            string dummy = "ABC";
            return dummy; 
        }
    }

    public class PrinterWriter
    {
        public void WritePrinter(string msg)
        {   
            // ....             
        }
    }

}
