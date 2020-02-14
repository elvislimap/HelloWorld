using Xunit;

namespace HelloWorld.Presentation.ConsoleApp.Tests
{
    public class ProgramTest
    {
        [Fact]
        public void RetornarHelloWorld_Ok()
        {
            // Arrange & Act
            var retorno = Program.RetornarHelloWorld();

            // Assert
            Assert.NotNull(retorno);
            Assert.Equal("Hello World!", retorno);
        }
    }
}
