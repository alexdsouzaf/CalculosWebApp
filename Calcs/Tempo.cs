namespace CalculosWebApp.Calcs
{
    /// <summary>
    /// Get{retorno}{parametro}
    /// </summary>
    public class Tempo
    {
        const int Const_60 = 60;
        const int Const_3600 = 3600;

        /// <summary>
        /// Minutos para hora
        /// </summary>
        /// <param name="pMinuto"></param>
        /// <returns></returns>
        public async Task<double> GetHoraMinuto(double pMinuto) => await Task.FromResult(pMinuto / Const_60);

        /// <summary>
        /// segundos para hora
        /// </summary>
        /// <param name="pSegundo"></param>
        /// <returns></returns>
        public async Task<double> GetHoraSegundo(double pSegundo) => await Task.FromResult(pSegundo / Const_3600);


        /// <summary>
        /// horas para minutos
        /// </summary>
        /// <param name="pHora"></param>
        /// <returns></returns>
        public async Task<double> GetMinutoHora(double pHora) => await Task.FromResult(pHora * Const_60);

        /// <summary>
        /// segundos para minutos
        /// </summary>
        /// <param name="pSegundo"></param>
        /// <returns></returns>
        public async Task<double> GetMinutoSegundo(double pSegundo) => await Task.FromResult(pSegundo / Const_60);


        /// <summary>
        /// minutos para segundos
        /// </summary>
        /// <param name="pMinuto"></param>
        /// <returns></returns>
        public async Task<double> GetSegundoMinuto(double pMinuto) => await Task.FromResult(pMinuto * Const_60);

        /// <summary>
        /// horas para segundos
        /// </summary>
        /// <param name="pHora"></param>
        /// <returns></returns>
        public async Task<double> GetSegundoHora(double pHora) => await Task.FromResult(pHora * Const_3600);

    }
}
