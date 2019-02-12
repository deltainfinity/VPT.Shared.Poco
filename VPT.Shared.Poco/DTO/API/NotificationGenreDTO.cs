using VPT.Shared.Poco.Enum.API;
using VPT.Shared.Poco.Model.API;

namespace VPT.Shared.Poco.DTO.API
{
    public class NotificationGenreDTO : BaseDTO
    {
        public NotificationGenreDTO()
        { }

        public NotificationGenreDTO(NotificationGenre source)
        {
            NotificationID = source.NotificationID;
            TypeID = source.TypeID;
            Primarykey = source.Primarykey;
        }

        /// <summary>
        /// ID of Notification
        /// </summary>
        public int NotificationID { get; set; }

        /// <summary>
        /// ID of Notification Type
        /// </summary>
        public int TypeID { get; set; }

        /// <summary>
        /// Subject Action Step ID
        /// </summary>
        public int Primarykey { get; set; }
    }
}
