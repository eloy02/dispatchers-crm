using System.Runtime.Serialization;

namespace Dispatchers.Core.Model
{
    /// <summary>
    /// Здание
    /// </summary>
    ///
    [DataContract]
    public class Building
    {
        [DataMember(Order = 1)]
        public string FiasGuid { get; set; } = string.Empty;

        [DataMember(Order = 2)]
        public string Number { get; set; } = string.Empty;
    }
}