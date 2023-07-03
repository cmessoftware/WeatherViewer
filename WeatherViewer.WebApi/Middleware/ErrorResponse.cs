namespace WeatherViewer.WebApi.Middleware
{
    public class ErrorResponse
    {
        public bool Success { get; set; }
        public bool Failed { get; set; }
        public string Message { get; internal set; }
    }
}