using Autofac.Extras.Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ConsoleClassLibrary.Tests
{
    public class SortStringTests
    {
        [Theory]
        [InlineData("HeLlo!", "!HLelo")]
        [InlineData("mamA, Mia?", " ,?AMaaimm")]
        [InlineData("The lazy dog jumped over the lazt fox.", "       .Taaddeeeefghhjllmoooprttuvxyzz")]
        [InlineData("Contrary to popular belief, the pink unicorn flies east.", "        ,.Caaabceeeeeffhiiiiklllnnnnooooppprrrrssttttuuy")]
        public void Ascending_ShouldSortStringInAscenfingOrder(string s, string p)
        {
            using (var mock = AutoMock.GetLoose())
            {
                //Arrange                
                string expected = p;
                
                //Act
                var cls = mock.Create<SortString>();
                string actual = cls.Ascending(s);

                //Assert 
                Assert.Equal(expected, actual);
            }

        }
    }
}
