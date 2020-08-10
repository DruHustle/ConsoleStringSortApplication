using Autofac.Extras.Moq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ConsoleClassLibrary.Tests
{
    public class WorkSpaceTests
    {
        [Theory]
        [InlineData("Hello")]
        [InlineData("mama Mia")]
        [InlineData("The lazy dog jumped over the lazt fox")]
        [InlineData("12345678/*@#$%^&*")]
        [InlineData("HeLlo!")]
        [InlineData("mamA, Mia4?")]
        [InlineData("Chamhembe")]
        [InlineData("Chamhembe:")]
        [InlineData("Chamhembe.")]
        [InlineData("Chamhembe;")]
        [InlineData("Chamhembe'")]
        [InlineData("Chamhembe\"")]
        [InlineData("Chamhembe\\")]
        [InlineData("Chamhembe2")]
        [InlineData("Cham3hembe")]
        [InlineData("Chamhembe%")]
        [InlineData("Chamhembe*")]
        [InlineData("Cham~hembe")]
        [InlineData("Ch#amhembe")]
        [InlineData("Chamh$embe")]
        [InlineData("Chamhembe^")]
        [InlineData("Ch&amhembe")]
        [InlineData("Chamhembe|")]
        [InlineData("< Chamhembe")]
        [InlineData("Chamh > embe")]
        [InlineData("Chigutiro, tamba!?")]
        [InlineData("Zimu 123 Soro")]
        [InlineData("")]
        [InlineData("Contrary to popular belief, the pink unicorn flies east.")]
        public void StringValue_ShouldReadStringFromConsole(string s)
        {
            using (var mock = AutoMock.GetLoose())
            {
                //Arrange                
                var input = new StringReader(s);
                Console.SetIn(input);//print to console

                var output = new StringWriter();
                Console.SetOut(output);//read console display

                string expected = "";

                //Act
                var cls = mock.Create<WorkSpace>();
                cls.ClearConsole();

                //Assert 
                Assert.Equal(expected, output.ToString());
            }

        }
    }
}
