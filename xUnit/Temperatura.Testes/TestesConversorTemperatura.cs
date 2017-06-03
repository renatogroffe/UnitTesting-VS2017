using Xunit;

namespace Temperatura.Testes
{
    public class TestesConversorTemperatura
    {
        [Fact]
        public void TesteConversaoTemperatura1()
        {
            double valorCalculado =
                ConversorTemperatura.FahrenheitParaCelsius(32);
            Assert.Equal(0, valorCalculado);
        }

        [Fact]
        public void TesteConversaoTemperatura2()
        {
            double valorCalculado =
                ConversorTemperatura.FahrenheitParaCelsius(86);
            Assert.Equal(30, valorCalculado);
        }

        [Fact]
        public void TesteConversaoTemperatura3()
        {
            double valorCalculado =
                ConversorTemperatura.FahrenheitParaCelsius(90.5);
            Assert.Equal(32.5, valorCalculado);
        }

        [Fact]
        public void TesteConversaoTemperatura4()
        {
            double valorCalculado =
                ConversorTemperatura.FahrenheitParaCelsius(212);
            Assert.Equal(100, valorCalculado);
        }
    }
}