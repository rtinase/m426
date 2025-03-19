public class UserService
{
    // Extract validation logic to separate methods
    private void ValidateUsername(string username)
    {
        if (string.IsNullOrEmpty(username))
            throw new ArgumentException("Username cannot be empty");
        if (username.Length < 3)
            throw new ArgumentException("Username must be at least 3 characters");
    }
    
    private void ValidateEmail(string email)
    {
        if (string.IsNullOrEmpty(email))
            throw new ArgumentException("Email cannot be empty");
        if (!email.Contains("@"))
            throw new ArgumentException("Email must contain @");
    }
    
    private void ValidatePassword(string password)
    {
        if (string.IsNullOrEmpty(password))
            throw new ArgumentException("Password cannot be empty");
        if (password.Length < 8)
            throw new ArgumentException("Password must be at least 8 characters");
    }
    
    // Validate all fields at once
    private void ValidateUserData(string username, string email, string password)
    {
        ValidateUsername(username);
        ValidateEmail(email);
        ValidatePassword(password);
    }
    
    public void RegisterUser(string username, string email, string password)
    {
        ValidateUserData(username, email, password);
        // Register the user...
    }
    
    public void UpdateUser(string username, string email, string password)
    {
        ValidateUserData(username, email, password);
        // Update the user...
    }
}