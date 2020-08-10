using Autofac.Extras.Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ConsoleClassLibrary.Tests
{
    public class MapStringTests
    {    
        [Theory]
        [InlineData("HELLO","hello" )]
        [InlineData("MAMAMIA", "mamamia")]
        [InlineData("THECRAZYDOGJUMPEDOVERTHELAZYFOX", "thecrazydogjumpedoverthelazyfox")]
        public void ToLowerCase_WhenAllUpperCaseCharsArePassed_LowerCaseCharsReturned(string s, string p)
        {
            using (var mock = AutoMock.GetLoose())
            {
                //Arrange
                string expected = p;

                //Act
                var cls = mock.Create<MapString>();
                string actual = cls.ToLowerCase(s);

                //Assert 
                Assert.Equal(expected, actual);
            }

        }

        [Theory]
        [InlineData("HeLlO", "hello")]
        [InlineData("MAmAMiA", "mamamia")]
        [InlineData("THeCrAzYDoGJuMPeDoveRtheLAzyFOX", "thecrazydogjumpedoverthelazyfox")]
        public void ToLowerCase_WhenSomeUpperCaseCharsArePassed_LowerCaseCharsReturned(string s, string p)
        {
            using (var mock = AutoMock.GetLoose())
            {
                //Arrange
                string expected = p;

                //Act
                var cls = mock.Create<MapString>();
                string actual = cls.ToLowerCase(s);

                //Assert 
                Assert.Equal(expected, actual);
            }

        }
    }
}
