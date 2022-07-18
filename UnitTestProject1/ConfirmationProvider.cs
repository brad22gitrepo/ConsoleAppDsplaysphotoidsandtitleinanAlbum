using System;
using System.IO;

namespace UnitTestProject1
{
    internal class ConfirmationProvider
    {
        private StringReader stringReader;
        private TextWriter @out;

        public ConfirmationProvider(StringReader stringReader, TextWriter @out)
        {
            this.stringReader = stringReader;
            this.@out = @out;
        }

        internal bool Confirm(string v)
        {
            throw new NotImplementedException();
        }
    }
}