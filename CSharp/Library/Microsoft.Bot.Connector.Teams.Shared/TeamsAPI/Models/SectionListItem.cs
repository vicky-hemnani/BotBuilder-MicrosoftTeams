// <auto-generated /> Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Bot.Connector.Teams.Models
{
    using System.Linq;

    public partial class SectionListItem : ListItemBase
    {
        /// <summary>
        /// Initializes a new instance of the SectionListItem class.
        /// </summary>
        public SectionListItem() { }

        /// <summary>
        /// Initializes a new instance of the SectionListItem class.
        /// </summary>
        /// <param name="type">Type of the item</param>
        /// <param name="id">Id of the item</param>
        /// <param name="title">Title of the item</param>
        /// <param name="subtitle">Subtitle of the item</param>
        public SectionListItem(string type = default(string), string id = default(string), string title = default(string), string subtitle = default(string), CardAction tap = default(CardAction))
            : base(type, id, title, subtitle, tap)
        {
        }

    }
}