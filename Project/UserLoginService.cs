namespace Project;

public class UserLoginService : IUserLoginService
{
    #region Implementation of IUserLoginService

    /// <exception cref="ArgumentNullException">
    /// Thrown if Argument is null
    /// </exception>
    /// <inheritdoc />
    public string GreetUser(string userName)
    {
        if (string.IsNullOrEmpty(userName))
            throw new ArgumentNullException(nameof(userName) + " Should not be null");
        if (userName.Length == 0)
            throw new ArgumentException("userName cannot be empty");

        return $"Hello {userName}!";
    }

    #endregion
}