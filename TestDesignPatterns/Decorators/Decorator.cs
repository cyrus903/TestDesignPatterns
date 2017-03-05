using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;
using System.Security.Cryptography;


namespace TestDesignPatterns
{
    class Decorator
    {
        string path = @"c:\temp\MyTest.txt";

        DESCryptoServiceProvider cryptic = new DESCryptoServiceProvider();           

        public Decorator()
        {
            cryptic.Key = ASCIIEncoding.ASCII.GetBytes("ABCDEFGH");
            cryptic.IV = ASCIIEncoding.ASCII.GetBytes("ABCDEFGH");
        }

        public void Write()
        {  
            // Delete the file if it exists.
            if (File.Exists(path))
            {
                File.Delete(path);
            }

            FileStream fs = new FileStream(path, FileMode.OpenOrCreate);  
            CryptoStream cs = new CryptoStream(fs, cryptic.CreateEncryptor(), CryptoStreamMode.Write);
            BinaryWriter bw = new BinaryWriter(cs);

            //BinaryWriter.Write () Writes a length-prefixed string to this stream
            //BinaryWriter.Write () => call Stream.Write() //Stream.Write() recursive for cs and fs
            bw.Write("TEST");//format, encrypted, write to file

            bw.Close();
            cs.Close();
            fs.Close();
        }

        public string Read()
        {
            if (File.Exists(path))
            {
                FileStream fs = new FileStream(path, FileMode.Open);
                CryptoStream cs = new CryptoStream(fs, cryptic.CreateDecryptor(), CryptoStreamMode.Read);
                BinaryReader br = new BinaryReader(cs);                

                //BinaryReader.ReadXXX() calls Stream.Read()
                //BinaryReader.ReadString Method () => Reads a string from the current stream.
                //Stream.ReadXXX() recursive for cs and fs
                string output = br.ReadString();

                br.Close();
                cs.Close();
                fs.Close();

                return output;
            }
            return string.Empty;
        }



    }
}
