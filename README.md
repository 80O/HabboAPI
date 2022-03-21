# HabboAPI - C# Wrapper for Habbo Hotel APIs

### About
Trying to make it easier for people to query the Habbo servers, this API is a work in progress to include various public endpoints.
For feature requests & ideas, contact me on discord: tdid#5193

### Installation
Using .NET CLI: `dotnet add package HabboAPI`  
Or via Nuget https://www.nuget.org/packages/HabboAPI/

### Usage

```
var api = new HabboAPI(Hotel.COM);
var user = await api.GetUser("Macklebee");
var fullProfile = await api.GetUserProfile(user.UniqueId);
```

### Features:
- Achievements
  - Available Achievements
  - User Progress
- Groups
  - Group Information
  - Members (+ pagination)
- User Info
  - Basic Information
  - Selected Badges
  - Online Status 
- User Profile
  - Friends
  - Groups
  - Rooms
  - Badges
  - Photos
- Rooms
  - Rooms Per User
- Furniture
  - Furnidata
- Photos
  - Last 200 Published Photos
  - Photos Per User
