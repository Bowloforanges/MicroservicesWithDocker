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

        List<User> users = [];

        users.Add(user1);
        users.Add(user2);
        users.Add(user3);

        return users;
    }
}
