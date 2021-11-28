using System.Runtime.Serialization;

namespace Dispatchers.Core.Model
{
    [DataContract]
    public class TicketEditLog
    {
        [DataMember(Order = 1)]
        public Guid Id { get; set; }

        [DataMember(Order = 2)]
        public DateTimeOffset Date { get; set; }

        [DataMember(Order = 3)]
        public string LogAction { get; set; } = string.Empty;

        [DataMember(Order = 4)]
        public User User { get; set; } = new();
    }
}
