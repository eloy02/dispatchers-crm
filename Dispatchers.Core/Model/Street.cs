using System.Runtime.Serialization;

namespace Dispatchers.Core.Model
{
    /// <summary>
    /// Улица
    /// </summary>
    [DataContract]
    public class Street
    {
        [DataMember(Order = 0)]
        public string FiasGuid { get; set; } = string.Empty;

        [DataMember(Order = 1)]
        public string Name { get; set; } = string.Empty;
    }
}