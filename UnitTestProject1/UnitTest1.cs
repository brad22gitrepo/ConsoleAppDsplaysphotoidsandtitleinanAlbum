//using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Text;
using NUnit.Framework;
using Moq;
using ConsoleAppDsplaysphotoidsandtitleinanAlbum;

namespace UnitTestProject1
{
    public class ProgramTests
    {
        StringBuilder _ConsoleOutput;
        Mock<TextReader> _ConsoleInput;

        [SetUp]
        public void setup()
        {
            _ConsoleOutput = new StringBuilder();
            var consoleOutputWriter = new StringWriter(_ConsoleOutput);
            _ConsoleInput = new Mock<TextReader>();
            Console.SetOut(consoleOutputWriter);
            Console.SetIn(_ConsoleInput.Object);
        }

        private string RunMainAndGetConsoleOutput()
        {
            Program.Main(default);
            return _ConsoleOutput.ToString();
            //return _ConsoleOutput.ToString();

        }


        private MockSequence SetupUserResponses(params string[] userResponses)
        {
            var sequence = new MockSequence();
            foreach (var response in userResponses)
                _ConsoleInput.InSequence(sequence).Setup(x => x.ReadLine()).Returns(response);
            return sequence;
        }

        [Test]
        public void MainAskForInput_WhenExecuted()
        {
            SetupUserResponses("1", "3", "2", "10", "4", "5", "7", "6", "9", "8", "99");
            var expectedPrompt = ">photo-album ";
            var outputLines = RunMainAndGetConsoleOutput();
            NUnit.Framework.Assert.AreEqual(expectedPrompt, outputLines[0]);
        }

    }
}


