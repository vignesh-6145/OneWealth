using System;

namespace OneWealth.Business.Interfaces;

public interface ICryptoService
{
    public string SaltHash(string pass);
    public bool VerifySaltHash(string inpPass, string saltedHash);
}
