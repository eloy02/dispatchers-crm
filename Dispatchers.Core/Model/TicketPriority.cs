using System.Runtime.Serialization;

namespace Dispatchers.Core.Model
{
    /// <summary>
    /// Приоритет заявки
    /// </summary>
    [DataContract]
    public class TicketPriority
    {
        [DataMember(Order = 1)]
        public int Id { get; set; }

        [DataMember(Order = 2)]
        public string Name { get; set; } = string.Empty;
    }
}
