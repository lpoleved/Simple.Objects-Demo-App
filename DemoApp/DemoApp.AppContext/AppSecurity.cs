using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
//using System.Management;
using Simple.AppContext;
using Simple.Security;

namespace DemoApp.AppContext
{
    public class AppSecurity
    {
        // TODO: Change this KEY!!!!!!!!!!!!!!!!!
        private byte[] cryptoKey = { 158, 161, 88, 129, 252, 217, 162, 229, 24, 193, 47, 69, 162, 198, 159, 183, 26, 13, 61, 105, 81, 168, 218, 84, 113, 42, 46, 181, 160, 34, 144, 150 };
        private byte[] cryptoIV = { 251, 250, 243, 218, 144, 170, 103, 221, 113, 16, 141, 167, 55, 164, 9, 68 };

        public AppSecurity(AppContextBase appContext)
        {
            this.AppContext = appContext;
            
            RijndaelManaged rijndael = new RijndaelManaged();

            rijndael.Key = this.cryptoKey;
            rijndael.IV = this.cryptoIV;
            this.CryptoBlockSize = rijndael.BlockSize;

            this.Encryptor = rijndael.CreateEncryptor();
            this.Decryptor = rijndael.CreateDecryptor();
        }

        public AppContextBase AppContext { get; private set; }
        public ICryptoTransform Encryptor { get; private set; }
        public ICryptoTransform Decryptor { get; private set; }
        public int CryptoBlockSize { get; private set; }
    }
}
