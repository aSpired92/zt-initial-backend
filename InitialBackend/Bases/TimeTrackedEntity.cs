using InitialBackend.Interfaces;

namespace InitialBackend
{
    public class TimeTrackedEntity
    {
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
