namespace RestaurantApi1
{
    public interface IWeatherForecastService
    {
        IEnumerable<WeatherForecast> Get(int numberOfResults, int maxTemp, int minTemp);
    }
}