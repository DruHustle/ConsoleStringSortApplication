using Autofac.Extras.Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ConsoleClassLibrary.Tests
{
    public class ValidationTests
    {
        [Theory]
        [InlineData("HeLlo!", true)]
        [InlineData("mamA, Mia4?",false )]
        [InlineData("Chamhembe", true)]
        [InlineData("Chamhembe:", true)]
        [InlineData("Chamhembe.", true)]
        [InlineData("Chamhembe;", true)]
        [InlineData("Chamhembe'", true)]
        [InlineData("Chamhembe\"", true)]
        [InlineData("Chamhembe\\",false)]
        [InlineData("Chamhembe2", false)]
        [InlineData("Cham3hembe", false)]
        [InlineData("Chamhembe%", false)]
        [InlineData("Chamhembe*", false)]
        [InlineData("Cham~hembe", false)]
        [InlineData("Ch#amhembe", false)]
        [InlineData("Chamh$embe", false)]
        [InlineData("Chamhembe^", false)]
        [InlineData("Ch&amhembe", false)]
        [InlineData("Chamhembe|", false)]
        [InlineData("< Chamhembe", false)]
        [InlineData("Chamh > embe", false)]
        [InlineData("Chigutiro, tamba!?", true)]
        [InlineData("Zimu 123 Soro", false)]
        [InlineData("",false )]
        [InlineData(null, false)]
        [InlineData("Contrary to popular belief, the pink unicorn flies east.", true)]
        public void ValidateString_ShouldNotValidate_Digits_SpecialCharacters_NullValues_WhiteSpaces(string s,bool p)
        {
            using (var mock = AutoMock.GetLoose())
            {
                //Arrange                
                bool expected = p;

                //Act
                var cls = mock.Create<Validation>();
                bool actual = cls.ValidateString(s);

                //Assert 
                Assert.Equal(expected, actual);
            }

        }
    }
}
