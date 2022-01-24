using System.Runtime.Serialization;

namespace Dispatchers.Core.Model
{
    /// <summary>
    /// Контракт для заявки
    /// </summary>
    [DataContract]
    public class Ticket
    {
        [DataMember(Order = 1)]
        public long Id { get; set; }

        /// <summary>
        /// Номер заявки
        /// </summary>
        [DataMember(Order = 2)]
        public string? TicketNumber { get; set; }

        /// <summary>
        /// Дата создания
        /// </summary>
        [DataMember(Order = 3)]
        public DateTimeOffset CreateDate { get; set; }

        /// <summary>
        /// Улица
        /// </summary>
        [DataMember(Order = 4)]
        public Street? Street { get; set; }

        /// <summary>
        /// Дом
        /// </summary>
        [DataMember(Order = 5)]
        public Building? Building { get; set; }

        /// <summary>
        /// Квартира
        /// </summary>
        [DataMember(Order = 6)]
        public string? FlatNumber { get; set; }

        /// <summary>
        /// Подъезд
        /// </summary>
        [DataMember(Order = 7)]
        public string? EntranceNumber { get; set; }

        /// <summary>
        /// Статус заявки
        /// </summary>
        [DataMember(Order = 8)]
        public TicketStatus? Status { get; set; }

        /// <summary>
        /// Тип заявки
        /// </summary>
        [DataMember(Order = 9)]
        public TicketType? Type { get; set; }

        /// <summary>
        /// Тема заявки
        /// </summary>
        [DataMember(Order = 10)]
        public TicketTopic? Topic { get; set; }

        /// <summary>
        /// Приоритет заявки
        /// </summary>
        [DataMember(Order = 11)]
        public TicketPriority? Priority { get; set; }

        /// <summary>
        /// Исполнитель заявки
        /// </summary>
        [DataMember(Order = 12)]
        public TicketPerformer? Performer { get; set; }

        /// <summary>
        /// Дата передачи исполнителю
        /// </summary>
        [DataMember(Order = 13)]
        public DateTimeOffset? SubmitToPerformer { get; set; }

        /// <summary>
        /// Дата передачи аварийной службе
        /// </summary>
        [DataMember(Order = 14)]
        public DateTimeOffset? SubmitToEmergencyDate { get; set; }

        /// <summary>
        /// Участок
        /// </summary>
        [DataMember(Order = 15)]
        public Subdivision? Subdivision { get; set; }

        /// <summary>
        /// Описание заявки
        /// </summary>
        [DataMember(Order = 16)]
        public string? Description { get; set; }

        /// <summary>
        /// Дата завершения заявки
        /// </summary>
        [DataMember(Order = 17)]
        public DateTimeOffset? CompleteDate { get; set; }

        /// <summary>
        /// Создатель заявки
        /// </summary>
        [DataMember(Order = 18)]
        public User? User { get; set; }

        /// <summary>
        /// До какого времени отложена заявка
        /// </summary>
        [DataMember(Order = 19)]
        public DateTimeOffset? DelayedTillDate { get; set; }

        /// <summary>
        /// Абонент
        /// </summary>
        [DataMember(Order = 20)]
        public AbonentData? AbonentData { get; set; }

        /// <summary>
        /// Шаги выполнения заявки
        /// </summary>
        [DataMember(Order = 21)]
        public List<TicketCompleteAction> CompleteActions { get; set; } = new();
    }
}