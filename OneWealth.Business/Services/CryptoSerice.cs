using System;
using System.Security.Cryptography;

using OneWealth.Business.Interfaces;

namespace OneWealth.Business.Services;

public class CryptoSerice : ICryptoService
{
    private const int SaltSize = 16;
    private const int HashSize = 32;
    private const int Iterations = 100000;
    private readonly HashAlgorithmName Alogrithm = HashAlgorithmName.SHA512;
    public string SaltHash(string pass)
    {
        byte[] salt = RandomNumberGenerator.GetBytes(SaltSize);
        byte[] hash = Rfc2898DeriveBytes.Pbkdf2(pass, salt, Iterations, Alogrithm, HashSize);
        return $"{Convert.ToHexString(hash)}-{Convert.ToHexString(salt)}";
    }
    
    public bool VerifySaltHash(string inpPass, string saltedHash)
    {
        if (inpPass == null || saltedHash == null)
            return false;
        string[] parts = saltedHash.Split("-");
        byte[] salt = Convert.FromHexString(parts[1]);
        byte[] rawHash = Convert.FromHexString(parts[0]);

        byte[] inputHash = Rfc2898DeriveBytes.Pbkdf2(inpPass,salt,Iterations,Alogrithm,HashSize);

        return CryptographicOperations.FixedTimeEquals(rawHash,inputHash);
    }
}
