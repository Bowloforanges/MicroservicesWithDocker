namespace Utils.Interfaces;

public interface IPasswordManagement
{
    public string HashAndSalt(string password, out byte[] salt);
    public bool Verify(string password, string hash, byte[] salt);
}
