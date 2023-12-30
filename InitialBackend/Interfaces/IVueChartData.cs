using InitialBackend.DataObjects;

namespace InitialBackend.Interfaces
{
    public interface IVueChartData
    {
        List<string> Labels { get; set; }
        List<Dictionary<string, float>> Datasets { get; set; }
    }
}
