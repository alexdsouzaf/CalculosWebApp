namespace CalculosWebApp.Calcs
{
    public class Temperatura
    {
        //são o ponto 0 para a (Temp)eratura Celsius
        const double TempKelvin = 273.15;
        const double TempFahrenheit = 32;

        //constantes auxiliares das formulas
        const double ConstKelvin = 5 / 9;
        const double ConstFahrenheit = 1.8;

        public async Task<double> GetCelsiusKelvin(double pKelvin) => await Task.FromResult(pKelvin - TempKelvin);

        public async Task<double> GetCelsiusFahrenheit(double pFahrenheit) => await Task.FromResult((pFahrenheit / ConstFahrenheit) - TempFahrenheit);


        public async Task<double> GetKelvinCelsius(double pCelsius) => await Task.FromResult(pCelsius + TempKelvin);


        public async Task<double> GetFahrenheitKelvin(double pFahrenheit) => await Task.FromResult((pFahrenheit - TempFahrenheit) * ConstKelvin + TempKelvin); //(0 K − 273,15) × 9/5 + 32


        public async Task<double> GetKelvinFahrenheit(double pKelvin) => await Task.FromResult((pKelvin - TempKelvin) * ConstKelvin + TempFahrenheit);


        public async Task<double> GetFahrenheitCelsius(double pCelsius) => await Task.FromResult((pCelsius * ConstFahrenheit) + TempFahrenheit);
    }
}
