using System.Runtime.Serialization;

namespace Dispatchers.Core.Model
{
    /// <summary>
    /// Данные Абонента
    /// </summary>
    [DataContract]
    public class AbonentData
    {
        [DataMember(Order = 1)]
        public string Name { get; set; } = string.Empty;

        [DataMember(Order = 2)]
        public string PhoneNumber { get; set; } = string.Empty;
    }
}