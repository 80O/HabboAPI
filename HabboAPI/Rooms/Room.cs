using HabboAPI.Users;

namespace HabboAPI.Rooms
{
    public class Room
    {
        public uint Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTimeOffset CreationTime { get; set; }
        public List<string> Tags { get; set; } = new(0);
        public uint MaximumVisitors { get; set; }
        public bool ShowOwnerName { get; set; }
        public string OwnerName { get; set; } = string.Empty;
        public UniqueUserId OwnerUniqueId { get; set; } = UniqueUserId.Empty;
        public List<string> Categories { get; set; } = new(0);
        public string ImageUrl { get; set; } = string.Empty;
        public int Rating { get; set; }
        public string ThumbnailUrl { get; set; } = string.Empty;
        /// <summary>
        /// Note: Information not available when requesting rooms through profile!
        /// </summary>
        public bool PublicRoom { get; set; }
        public DoorMode DoorMode { get; set; }
        public string UniqueId { get; set; } = string.Empty;
    }

    public enum DoorMode
    {
        Open,
        Closed,
        Password
    }
}

// profile/rooms
//"rooms": [
//{
//    "id": 64786513,
//    "name": "The Lions Den",
//    "description": "",
//    "creationTime": "2013-10-16T13:44:18.000+00:00",
//    "tags": [


//    ],
//    "maximumVisitors": 25,
//    "showOwnerName": true,
//    "ownerName": "Macklebee",
//    "ownerUniqueId": "hhus-bd299448daa60086cd1bc109b7374e19",
//    "categories": [
//    "navigator.flatcategory.global.CHAT"
//        ],
//    "imageUrl": "https://habbo-stories-content.s3.amazonaws.com/fullroom-photo/hhus/64786513.png",
//    "rating": 49,
//    "thumbnailUrl": "https://habbo-stories-content.s3.amazonaws.com/navigator-thumbnail/hhus/64786513.png",
//    "uniqueId": "r-hhus-9ec42c6610fc87345a97d415845dc131"
//},

//rooms/roomid
//{
//    "id": 64786513,
//    "name": "The Lions Den",
//    "description": "",
//    "creationTime": "2013-10-16T13:44:18.000+00:00",
//    "tags": [


//    ],
//    "maximumVisitors": 25,
//    "showOwnerName": true,
//    "ownerName": "Macklebee",
//    "ownerUniqueId": "hhus-bd299448daa60086cd1bc109b7374e19",
//    "categories": [
//    "navigator.flatcategory.global.CHAT"
//        ],
//    "imageUrl": "https://habbo-stories-content.s3.amazonaws.com/fullroom-photo/hhus/64786513.png",
//    "rating": 49,
//    "thumbnailUrl": "https://habbo-stories-content.s3.amazonaws.com/navigator-thumbnail/hhus/64786513.png",
//    "publicRoom": false,
//    "doorMode": "password",
//    "uniqueId": "r-hhus-9ec42c6610fc87345a97d415845dc131"
//}