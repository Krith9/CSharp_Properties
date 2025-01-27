using System;

public class UsernamePassowrd
{
    public static void Main(string[] args)
    {
        const string username = "user";
        const string password = "pw";
        Console.WriteLine ("Enter your username");
        string name = Console.ReadLine();
        if (name== ""){
            throw new Exception("username cannot be empty");
        }
        Console.WriteLine("Enter Your Password");
        string pw = Console.ReadLine();
        if (pw==""){
            throw new Exception("Password cannot be empty");
        }
        if (username == name && password==pw){
           Console.WriteLine($"Welcome {username}! You have successfully logged in.");
        }else{
            Console.WriteLine("Login Failed. Please Check username and password");
        }
    }
}