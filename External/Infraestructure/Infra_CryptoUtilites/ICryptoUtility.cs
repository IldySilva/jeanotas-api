namespace Infraestructure.Infra_CryptoUtilites;

public interface ICryptoUtility
{
        string Encrypt(string text);
        string Decrypt(string cipherText);
}