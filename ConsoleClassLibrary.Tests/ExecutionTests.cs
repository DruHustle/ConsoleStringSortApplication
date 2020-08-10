using Autofac.Extras.Moq;
using Moq;
using System;
using System.IO;
using System.Threading.Tasks;
using Xunit;

namespace ConsoleClassLibrary.Tests
{
    public class ExecutionTests
    {

        [Fact]
        public void Pause_WhenCalled_ShouldRunWithNoError()
        {
            using (var mock = AutoMock.GetLoose())
            {               
                var task = Task.Run(() =>
                {
                    //Act
                    var cls = mock.Create<Execution>();
                    cls.Pause();
                });

                bool isCompletedSuccessfully = task.Wait(TimeSpan.FromMilliseconds(2000));
                Assert.False(isCompletedSuccessfully);                  
            }
        }           

    }
}
