using Autofac.Extras.Moq;
using Moq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ConsoleClassLibrary.Tests
{
    public class PrintOutputTests
    {
     
        [Theory]
        [InlineData("Hello")]
        [InlineData("mama Mia")]
        [InlineData("The lazy dog jumped over the lazt fox")]
        public void Message_ShouldPrintStringOnConsole(string s)
        {
            using (var mock = AutoMock.GetLoose())
            {
                //Arrange
                mock.Mock<IExecution>()
                    .Setup(x => x.Pause());

                var output = new StringWriter();
                Console.SetOut(output);

                //Act
                var cls = mock.Create<PrintOutput>();
                cls.Message(s);

                //Assert 
                Assert.Equal(s,output.ToString().Remove(output.ToString().Length-2, 2));
            }

        }

    }
}
