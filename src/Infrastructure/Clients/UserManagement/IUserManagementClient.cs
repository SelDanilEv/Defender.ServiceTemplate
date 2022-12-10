namespace Rentel.ServiceTemplate.Infrastructure.Clients.UserManagement;

public interface IUserManagementClient
{
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<LoginResponse> GoogleAsync(
        LoginGoogleCommand body = null,
        CancellationToken cancellationToken = default(CancellationToken));

    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <returns>Success</returns>
    /// <exception cref="ApiException">A server side error occurred.</exception>
    Task<UserDto> UserPUT2Async(
        UpdateAccountFromUserCommand body = null,
        CancellationToken cancellationToken = default(CancellationToken));

}