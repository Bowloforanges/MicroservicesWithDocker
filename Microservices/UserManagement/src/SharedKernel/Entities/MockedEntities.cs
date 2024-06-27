namespace Entities;

public static class MockedEntities
{
    public static User SingleUser()
    {
        return new User()
        {
            Guid = Guid.NewGuid(),
            Username = "Mocked_username",
            Email = "mocked@email.com",
            CreatedAt = DateTime.MinValue,
        };
    }

    public static User UpdatedSingleUser(Guid guid)
    {
        return new User()
        {
            Guid = guid,
            Username = "Mocked_updated_username",
            Email = "mocked_updated@email.com",
            CreatedAt = DateTime.MinValue,
        };
    }

    public static User DeletedSingleUser(Guid guid)
    {
        return new User()
        {
            Guid = guid,
            Username = "deleted_username",
            Email = "deleted_updated@email.com",
            CreatedAt = DateTime.MinValue,
        };
    }

    public static List<User> MultipleUsers()
    {
        User user1 = new User()
        {
            Username = "Mocked_username1",
            Email = "mocked1@email.com",
            CreatedAt = DateTime.MinValue,
        };

        User user2 = new User()
        {
            Username = "Mocked_username2",
            Email = "mocked2@email.com",
            CreatedAt = DateTime.MinValue,
        };
        User user3 = new User()
        {
            Username = "Mocked_username3",
            Email = "mocked3@email.com",
            CreatedAt = DateTime.MinValue,
        };

        List<User> users = [user1, user2, user3];

        return users;
    }
}
