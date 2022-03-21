using HabboAPI.Users;

namespace HabboAPI.Utils.MiscEndpoints.Photos
{
    public static class PhotosEndpoints
    {
        public static Task<List<Photo>> GetPhotos(this HabboAPI api) => api.Get<List<Photo>>("extradata/public/photos").ContinueWith(r => r.Result ?? new());

        public static Task<List<Photo>> GetUserPhotos(this HabboAPI api, UniqueUserId userId) => api.Get<List<Photo>>($"extradata/public/users/{userId}/photos").ContinueWith(r => r.Result ?? new());
    }
}
