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
    public class ReadInputTests
    {
        [Theory]
        [InlineData("Hello")]
        [InlineData("mama Mia")]
        [InlineData("The lazy dog jumped over the lazt fox")]
        [InlineData("12345678/*@#$%^&*")]
        public void StringValue_ShouldReadStringFromConsole(string s)
        {
            using (var mock = AutoMock.GetLoose())
            {
                //Arrange                
                var input = new StringReader(s);
                Console.SetIn(input);

                //Act
                var cls = mock.Create<ReadInput>();
                string actual = cls.StringValue();

                //Assert 
                Assert.Equal(s, actual);
            }

        }
    }
}
