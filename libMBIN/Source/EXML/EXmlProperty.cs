using System.Xml.Serialization;

namespace libMBIN
{
    [XmlType("Property")]
    public class EXmlProperty : EXmlBase
    {
        [XmlAttribute("value")]
        public string Value { get; set; }
        [XmlAttribute("linked")]
        public string Linked {get; set; }

        public override string ToString()
        {
            string result = "<";
            if (this.Name != null) {
                result += $"name=\"{this.Name}\"";
            }
            if (this.Value != null) {
                result += $" value=\"{this.Value}\"";
            }
            if (this.Linked != null) {
                result += $" linked=\"{this.Linked}\"";
            }
            result += ">";
            return result;
        }
    }
}