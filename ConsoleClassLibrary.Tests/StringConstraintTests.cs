using Autofac.Extras.Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ConsoleClassLibrary.Tests
{
    public class StringConstraintTests
    {
        [Theory]
        [InlineData("HeLlo!", "HeLlo")]
        [InlineData("mamA, Mia?", "mamA Mia")]
        [InlineData("The lazy dog jumped over the lazt fox.", "The lazy dog jumped over the lazt fox")]
        [InlineData("Contrary to popular belief, the pink unicorn flies east.", "Contrary to popular belief the pink unicorn flies east")]
        public void IgnorePanctuation_ShouldRemovePanctuationMarksFromString(string s, string p)
        {
            using (var mock = AutoMock.GetLoose())
            {
                //Arrange                
                string expected = p;

                //Act
                var cls = mock.Create<StringConstraint>();
                string actual = cls.IgnorePanctuation(s);

                //Assert 
                Assert.Equal(expected, actual);
            }

        }
    }
}
