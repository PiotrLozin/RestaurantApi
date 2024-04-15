namespace RestaurantApi1
{
    public interface IWeatherForecastService
    {
        IEnumerable<WeatherForecast> Get();
    }
}