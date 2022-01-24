using System.Runtime.Serialization;

namespace Dispatchers.Core.Model
{
    /// <summary>
    /// Описание шага выполнения заявки
    /// </summary>
    ///
    [DataContract]
    public class TicketCompleteAction
    {
        [DataMember(Order = 1)]
        public Guid Id { get; set; }

        /// <summary>
        /// Описание шага работ
        /// </summary>
        [DataMember(Order = 2)]
        public string Action { get; set; } = string.Empty;

        /// <summary>
        /// Дата события
        /// </summary>
        [DataMember(Order = 3)]
        public DateTimeOffset Date { get; set; }

        /// <summary>
        /// Пользователь
        /// </summary>
        [DataMember(Order = 4)]
        public User User { get; set; } = new();
    }
}