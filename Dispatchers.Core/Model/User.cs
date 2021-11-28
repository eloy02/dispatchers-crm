using System.Runtime.Serialization;

namespace Dispatchers.Core.Model
{
    /// <summary>
    /// Пользователь программы
    /// </summary>
    ///
    [DataContract]
    public class User
    {
        [DataMember(Order = 1)]
        public int Id { get; set; }

        /// <summary>
        /// Фио пользователя
        /// </summary>
        [DataMember(Order = 2)]
        public string Fio { get; set; } = string.Empty;

        [DataMember(Order = 3)]
        public bool IsActive { get; set; }

        /// <summary>
        /// Правило доступа - Возможность создавать заявки
        /// </summary>
        [DataMember(Order = 4)]
        public bool CanCreateTickets { get; set; }

        /// <summary>
        /// Правило доступа - Возможность редактировать заявки
        /// </summary>
        [DataMember(Order = 5)]
        public bool CanUpdateTickets { get; set; }

        /// <summary>
        /// Правило доступа - Возможность просматривать список заявок
        /// </summary>
        [DataMember(Order = 6)]
        public bool CanSeeTicketsList { get; set; }
    }
}