using System.Runtime.Serialization;

namespace Dispatchers.Core.Model
{
    /// <summary>
    /// Данные по исполнителю заявки
    /// </summary>
    [DataContract]
    public class TicketPerformer
    {
        [DataMember(Order = 1)]
        public Performer Performer { get; set; } = new();

        [DataMember(Order = 2)]
        public string PerformerFio { get; set; } = string.Empty;

        [DataMember(Order = 3)]
        public long TicketId { get; set; }
    }
}