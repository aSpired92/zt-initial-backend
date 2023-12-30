using InitialBackend.DataObjects;

namespace InitialBackend.Interfaces
{
    public interface IStatisticsRepository
    {
        int OrdersToday();
        int OrdersThisWeek();
        IVueChartData OrdersTodayLine();
        IVueChartData OrdersThisWeekLine();

        int ProductsToday();
        int ProductsThisWeek();
        IVueChartData ProductsTodayLine();
        IVueChartData ProductsThisWeekLine();
    }
}
