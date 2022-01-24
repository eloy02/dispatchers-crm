using System.Runtime.Serialization;

namespace Dispatchers.Core.Model
{
    /// <summary>
    /// Тема заявки
    /// </summary>
    [DataContract]
    public class TicketTopic
    {
        /// <summary>
        /// Id
        /// </summary>
        [DataMember(Order = 1)]
        public int Id { get; set; }

        /// <summary>
        /// Наименование
        /// </summary>
        [DataMember(Order = 2)]
        public string Name { get; set; } = string.Empty;
    }
}