using System.Security.Cryptography;
using System.Text;
using Utils.Interfaces;

namespace Utils;

public class PasswordUtils : IPasswordManagement
{
    public const int KeySize = 32;
    public const int Iterations = 10000; // Increase iterations for stronger security
    private static readonly HashAlgorithmName HashAlgorithm = HashAlgorithmName.SHA512;

    public string HashAndSalt(string password, out byte[] salt)
    {
        string hashedPassword = password;
        salt = RandomNumberGenerator.GetBytes(KeySize);

        if (!string.IsNullOrEmpty(password))
        {
            using (
                var rfc2898DeriveBytes = new Rfc2898DeriveBytes(
                    password,
                    salt,
                    Iterations,
                    HashAlgorithm
                )
            )
            {
                var hash = rfc2898DeriveBytes.GetBytes(KeySize);
                hashedPassword = Convert.ToBase64String(hash);
            }
        }

        return hashedPassword;
    }

    public bool Verify(string password, string hash, byte[] salt)
    {
        using (
            var rfc2898DeriveBytes = new Rfc2898DeriveBytes(
                password,
                salt,
                Iterations,
                HashAlgorithm
            )
        )
        {
            var hashToCompare = rfc2898DeriveBytes.GetBytes(KeySize);
            return CryptographicOperations.FixedTimeEquals(
                hashToCompare,
                Convert.FromBase64String(hash)
            );
        }
    }
}
