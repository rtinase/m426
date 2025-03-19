public class UserService
{
    public void RegisterUser(string username, string email, string password)
    {
        // Validate username
        if (string.IsNullOrEmpty(username))
            throw new ArgumentException("Username cannot be empty");
        if (username.Length < 3)
            throw new ArgumentException("Username must be at least 3 characters");
            
        // Validate email
        if (string.IsNullOrEmpty(email))
            throw new ArgumentException("Email cannot be empty");
        if (!email.Contains("@"))
            throw new ArgumentException("Email must contain @");
            
        // Validate password
        if (string.IsNullOrEmpty(password))
            throw new ArgumentException("Password cannot be empty");
        if (password.Length < 8)
            throw new ArgumentException("Password must be at least 8 characters");
            
        // Register the user...
    }
    
    public void UpdateUser(string username, string email, string password)
    {
        // Duplicate validation code
        if (string.IsNullOrEmpty(username))
            throw new ArgumentException("Username cannot be empty");
        if (username.Length < 3)
            throw new ArgumentException("Username must be at least 3 characters");
            
        if (string.IsNullOrEmpty(email))
            throw new ArgumentException("Email cannot be empty");
        if (!email.Contains("@"))
            throw new ArgumentException("Email must contain @");
            
        if (string.IsNullOrEmpty(password))
            throw new ArgumentException("Password cannot be empty");
        if (password.Length < 8)
            throw new ArgumentException("Password must be at least 8 characters");
            
        // Update the user...
    }
}