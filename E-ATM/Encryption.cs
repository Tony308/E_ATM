using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Net.Sockets;
using System.IO;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace E_ATM
{
    class Encryption
    {
        private SqlConnection con;
        private DataTable dt;

        public void Encryption_Load(object sender, EventArgs e)
        {   

        }

        public void updatePIN(string pin)
        {

            try
            {
                con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbConn"].ConnectionString);
                SqlCommand cmd = new SqlCommand("dbo.updateClient", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@RFID", "1");
                cmd.Parameters.AddWithValue("@PIN", hashPIN(pin));
                con.Open();
                cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        public Boolean getClient(string pin)
        {

            try
            {
                con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbConn"].ConnectionString);
                SqlCommand cmd = new SqlCommand("dbo.selectClient", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@RFID", "1");
                cmd.Parameters.AddWithValue("@PIN", hashPIN(pin));

                con.Open();
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                con.Close();
                da.Dispose();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }

        }

        public string hashPIN(string e)
        {

            byte[] salt;

            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);

            var pbkdf2 = new Rfc2898DeriveBytes(e, salt, 10000);
            byte[] hash = pbkdf2.GetBytes(20);

            byte[] hashBytes = new byte[36];
            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);

            string result = Convert.ToBase64String(hashBytes);

            return result;
        }
        
        public void unhashPIN()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbConn"].ConnectionString);
            SqlCommand cmd = new SqlCommand("dbo.selectClient1", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID",);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            con.Close();
            da.Dispose();

            string pin = dt.Rows[0][2].ToString();

            byte[] hashBytes = Convert.FromBase64String(pin);
            /* Get the salt */
            byte[] salt = new byte[16];
            Array.Copy(hashBytes, 0, salt, 0, 16);
            /* Compute the hash on the password the user entered */
            var pbkdf2 = new Rfc2898DeriveBytes(pin, salt, 10000);
            byte[] hash = pbkdf2.GetBytes(20);
            Console.WriteLine(hash);
            /* Compare the results */
            for (int i = 0; i < 20; i++)
                if (hashBytes[i + 16] != hash[i]) 
                    throw new UnauthorizedAccessException();
        }

        public void insertClient()
        {
            
        }
        public void GenKey_SaveinContainer(string containerName)
        {
            // Create the CspParameters object and set the key container   
            // name used to store the RSA key pair.  
            CspParameters cp = new CspParameters();
            cp.KeyContainerName = containerName;

            // Create a new instance of RSACryptoServiceProvider that accesses  
            // the key container MyKeyContainerName.  
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(cp);

            // Display the key information to the console.  
            Console.WriteLine("Key added to container: \n  {0}", rsa.ToXmlString(true));

        }

        public void GetKeyFromContainer(string ContainerName)
        {
            // Create the CspParameters object and set the key container   
            // name used to store the RSA key pair.  
            CspParameters cp = new CspParameters();
            cp.KeyContainerName = ContainerName;

            // Create a new instance of RSACryptoServiceProvider that accesses  
            // the key container MyKeyContainerName.  
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(cp);

            // Display the key information to the console.  
            Console.WriteLine("Key retrieved from container : \n {0}", rsa.ToXmlString(true));
        }

        public void DeleteKeyFromContainer(string ContainerName)
        {
            // Create the CspParameters object and set the key container   
            // name used to store the RSA key pair.  
            CspParameters cp = new CspParameters();
            cp.KeyContainerName = ContainerName;

            // Create a new instance of RSACryptoServiceProvider that accesses  
            // the key container.  
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(cp);

            // Deletes the key entry in the container.  
            rsa.PersistKeyInCsp = false;

            // Call Clear to release resources and delete the key from the container.  
            rsa.Clear();

            Console.WriteLine("Key deleted.");
        }

        public void encrypt(String containerName, String PIN)
        {
            //Initialize the byte arrays to the public key information.  
            byte[] PublicKey = {214,46,220,83,160,73,40,39,201,155,19,202,3,11,191,178,56,
            74,90,36,248,103,18,144,170,163,145,87,54,61,34,220,222,
            207,137,149,173,14,92,120,206,222,158,28,40,24,30,16,175,
            108,128,35,230,118,40,121,113,125,216,130,11,24,90,48,194,
            240,105,44,76,34,57,249,228,125,80,38,9,136,29,117,207,139,
            168,181,85,137,126,10,126,242,120,247,121,8,100,12,201,171,
            38,226,193,180,190,117,177,87,143,242,213,11,44,180,113,93,
            106,99,179,68,175,211,164,116,64,148,226,254,172,147};

            byte[] Exponent = { 1, 0, 1 };

            //Create values to store encrypted symmetric keys.  
            byte[] EncryptedSymmetricKey;
            byte[] EncryptedSymmetricIV;

            // Create the CspParameters object and set the key container   
            // name used to store the RSA key pair.  
            CspParameters cp = new CspParameters();
            cp.KeyContainerName = containerName;

            // Create a new instance of RSACryptoServiceProvider that accesses  
            // the key container MyKeyContainerName.  
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider(cp);


            //Create a new instance of the RSAParameters structure.  
            RSAParameters RSAKeyInfo = new RSAParameters();

            //Set RSAKeyInfo to the public key values.   
            RSAKeyInfo.Modulus = PublicKey;
            RSAKeyInfo.Exponent = Exponent;

            //Import key parameters into RSA.  
            RSA.ImportParameters(RSAKeyInfo);

            //Create a new instance of the RijndaelManaged class.  
            RijndaelManaged RM = new RijndaelManaged();

            //Encrypt the symmetric key and IV.  
            EncryptedSymmetricKey = RSA.Encrypt(RM.Key, false);
            EncryptedSymmetricIV = RSA.Encrypt(RM.IV, false);
        }

    }

   
}
