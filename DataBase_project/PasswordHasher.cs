//using System;
//using System.Security.Cryptography;
//using System.Text;

//class PasswordHasher
//{
//    // Method to hash the password
//    public static string HashPassword(string password)
//    {
//        using (SHA256 sha256 = SHA256.Create())
//        {
//            // Convert the input string to bytes and compute the hash
//            byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));

//            // Convert the byte array to a hexadecimal string
//            StringBuilder hashedPassword = new StringBuilder();
//            foreach (byte b in hashedBytes)
//            {
//                hashedPassword.Append(b.ToString("x2")); // Convert to lowercase hexadecimal
//            }
//            return hashedPassword.ToString();
//        }
//    }
//}

//// Example usage
//class Program
//{
//    static void Main(string[] args)
//    {
//        string plainPassword = "MySecurePassword123!";
//        string hashedPassword = PasswordHasher.HashPassword(plainPassword);

//        Console.WriteLine("Plain Password: " + plainPassword);
//        Console.WriteLine("Hashed Password: " + hashedPassword);

//        // Now you can save `hashedPassword` in the database
//    }
//}
