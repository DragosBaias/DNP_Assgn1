using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text.Json;
using System.Threading.Tasks;
using FileData;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.JSInterop;
using Models;

namespace FamilyManagerApp.Data {
    public class CustomAuthenticationStateProvider : AuthenticationStateProvider {
        private readonly IJSRuntime _jsRuntime;
        private readonly IUserService _userService;
        private User _user;

        public CustomAuthenticationStateProvider(IJSRuntime jsRuntime, IUserService userService) {
            this._jsRuntime = jsRuntime;
            this._userService = userService;
        }
        
        public override async Task<AuthenticationState> GetAuthenticationStateAsync() {
            var identity = new ClaimsIdentity();
            if (_user == null) {
                string userAsJson = await _jsRuntime.InvokeAsync<string>("sessionStorage.getItem", "currentUser");
                if (!string.IsNullOrEmpty(userAsJson)) {
                    User tmp = JsonSerializer.Deserialize<User>(userAsJson);
                    ValidateLogin(tmp.Username, tmp.Password);
                }
            } else {
                identity = SetupClaimsForUser(_user);
            }
            
            ClaimsPrincipal cachedClaimsPrincipal = new ClaimsPrincipal(identity);
            return await Task.FromResult(new AuthenticationState(cachedClaimsPrincipal));
        }

        public void ValidateLogin(string username, string password) {
            if (string.IsNullOrWhiteSpace(username)) throw new Exception("Please insert a username");
            if (string.IsNullOrWhiteSpace(password)) throw new Exception("Please insert a password");

            ClaimsIdentity identity;
            try {
                User user = _userService.ValidateUser(username, password);
                identity = SetupClaimsForUser(user);
                string serializedData = JsonSerializer.Serialize(user);
                _jsRuntime.InvokeVoidAsync("sessionStorage.setItem", "currentUser", serializedData);
                _user = user;
            }
            catch (Exception e) {
                throw e;
            }
            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(new ClaimsPrincipal(identity))));
        }

        public void ValidateRegister(string username, string password, string confirmationPassword) {
            if (string.IsNullOrWhiteSpace(username)) throw new Exception("Please specify a username");
            if (string.IsNullOrWhiteSpace(password)) throw new Exception("Please specify a password");
            if (string.IsNullOrWhiteSpace(confirmationPassword)) throw new Exception("Please confirm your password");
            
            if (!password.Equals(confirmationPassword))
                throw new Exception("Passwords do not match");
            
            List<User> users = _userService.GetUserList();
            if (users.FirstOrDefault(u => u.Username.Equals(username)) != null) {
                throw new Exception("Username is already used");
            }
            
            _userService.AddUser(new User() {
                Username = username,
                Password = password,
                Role = Role.User
            });
        }

        public void Logout() {
            _user = null;
            var user = new ClaimsPrincipal(new ClaimsIdentity());
            _jsRuntime.InvokeVoidAsync("sessionStorage.setItem", "currentUser", "");
            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(user)));
        }
        
        private ClaimsIdentity SetupClaimsForUser(User user) {
            List<Claim> claims = new List<Claim>();
            claims.Add(new Claim(ClaimTypes.Name, user.Username));
            claims.Add(new Claim(ClaimTypes.Role, user.Role.ToString()));
            ClaimsIdentity identity = new ClaimsIdentity(claims, "apiauth_type");
            return identity;
        }
    }
}