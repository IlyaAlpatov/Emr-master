using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Emr.Database;
using Emr.Database.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Emr.Identity
{
    public class ClientStore : IUserRoleStore<Client>
    {
        private readonly DatabaseContext _context;

        public ClientStore(DatabaseContext context)
        {
            _context = context;
        }

        /// <inheritdoc />
        public void Dispose()
        {
        }

        /// <inheritdoc />
        public async Task<string> GetUserIdAsync(Client Client, CancellationToken cancellationToken)
        {
            return Client.ClientGuid.ToString();
        }

        /// <inheritdoc />
        public async Task<string> GetUserNameAsync(Client Client, CancellationToken cancellationToken)
        {
            return Client.Mail.ToLower();
        }

        /// <inheritdoc />
        public async Task SetUserNameAsync(Client Client, string ClientName, CancellationToken cancellationToken)
        {
        }

        /// <inheritdoc />
        public async Task<string> GetNormalizedUserNameAsync(Client Client, CancellationToken cancellationToken)
        {
            return Client.Mail.ToUpper();
        }

        /// <inheritdoc />
        public async Task SetNormalizedUserNameAsync(Client Client, string normalizedName, CancellationToken cancellationToken)
        {
        }

        /// <inheritdoc />
        public async Task<IdentityResult> CreateAsync(Client Client, CancellationToken cancellationToken)
        {
            return null;
        }

        /// <inheritdoc />
        public async Task<IdentityResult> UpdateAsync(Client Client, CancellationToken cancellationToken)
        {
            return null;
        }

        /// <inheritdoc />
        public async Task<IdentityResult> DeleteAsync(Client Client, CancellationToken cancellationToken)
        {
            return null;
        }

        /// <inheritdoc />
        public async Task<Client> FindByIdAsync(string ClientId, CancellationToken cancellationToken)
        {
            var result = await _context.Clients.SingleAsync(x => x.ClientGuid == Guid.Parse(ClientId), cancellationToken: cancellationToken);
            return result;
        }

        /// <inheritdoc />
        public async Task<Client> FindByNameAsync(string normalizedClientName, CancellationToken cancellationToken)
        {
            var result = await _context.Clients.SingleAsync(x => x.Mail.ToUpper() == normalizedClientName.ToUpper(), cancellationToken: cancellationToken);
            return null;
        }

        /// <inheritdoc />
        public async Task AddToRoleAsync(Client Client, string roleName, CancellationToken cancellationToken)
        {
        }

        /// <inheritdoc />
        public async Task RemoveFromRoleAsync(Client Client, string roleName, CancellationToken cancellationToken)
        {
        }

        /// <inheritdoc />
        public async Task<IList<string>> GetRolesAsync(Client Client, CancellationToken cancellationToken)
        {
            var result = await _context.Clients.Include(x=>x.Role).SingleAsync(x => x.ClientGuid == Client.ClientGuid);

            return new List<string> {result.Role.Name};
        }

        /// <inheritdoc />
        public async Task<bool> IsInRoleAsync(Client Client, string roleName, CancellationToken cancellationToken)
        {
            var result = await _context.Clients.SingleAsync(x => x.ClientGuid == Client.ClientGuid);
            if (result.Role.Name == roleName)
                return true;
            return false;
        }

        /// <inheritdoc />
        public async Task<IList<Client>> GetUsersInRoleAsync(string roleName, CancellationToken cancellationToken)
        {
            return null;
        }

        /// <inheritdoc />
        public Task<DateTimeOffset?> GetLockoutEndDateAsync(Client Client, CancellationToken cancellationToken)
        {
            DateTimeOffset? result = null;
            return Task.FromResult(result);
        }

        /// <inheritdoc />
        public async Task SetLockoutEndDateAsync(Client Client, DateTimeOffset? lockoutEnd, CancellationToken cancellationToken)
        {
        }

        /// <inheritdoc />
        public async Task<int> IncrementAccessFailedCountAsync(Client Client, CancellationToken cancellationToken)
        {
            return 0;
        }

        /// <inheritdoc />
        public async Task ResetAccessFailedCountAsync(Client Client, CancellationToken cancellationToken)
        {
        }

        /// <inheritdoc />
        public async Task<int> GetAccessFailedCountAsync(Client Client, CancellationToken cancellationToken)
        {
            return 0;
        }

        /// <inheritdoc />
        public async Task<bool> GetLockoutEnabledAsync(Client Client, CancellationToken cancellationToken)
        {
            return false;
        }

        /// <inheritdoc />
        public async Task SetLockoutEnabledAsync(Client Client, bool enabled, CancellationToken cancellationToken)
        {
        }
    }
}
