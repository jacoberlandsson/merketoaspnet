using merketoaspnet.Helpers.Repositories;
using merketoaspnet.Models.Entities;
using merketoaspnet.Models.ViewModels;
using Microsoft.AspNetCore.Connections;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace merketoaspnet.Helpers.Services
{
    public class AuthenticationService
    {

        private readonly UserManager<UserEntity> _userManager;
        private readonly SignInManager<UserEntity> _signInManager;
        private readonly AddressService _addressService;

        public AuthenticationService(UserManager<UserEntity> userManager, SignInManager<UserEntity> signInManager, AddressService addressService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _addressService = addressService;
        }

        public async Task<bool> RegisterAsync(RegisterViewModel viewModel)
        {
            try
            {
                var createUser = await _userManager.CreateAsync(viewModel, viewModel.Password);
                if(createUser.Succeeded)
                {
                    var user = await _userManager.Users.FirstOrDefaultAsync(x => x.Email == viewModel.Email);
                    await _userManager.AddToRoleAsync(user!, "user");

                    var createAddress = await _addressService.GetOrCreateAddressAsync(viewModel);
                    
                    return await _addressService.AddUserAddresses(user!.Id, createAddress.Id);
                        
                }
            }
            catch (Exception ex) { Debug.WriteLine(ex.Message); }
            return false;
        }

        public async Task<bool> LoginAsync(LoginViewModel viewModel)
        {
            try
            {
                var result = await _signInManager.PasswordSignInAsync(viewModel.Email, viewModel.Password, viewModel.RememberMe, false);
                return result.Succeeded;

            }
            catch (Exception ex) { Debug.WriteLine(ex.Message); }
            return false;
        }

        public async Task<bool> LogoutAsync()
        {
            try
            {
                await _signInManager.SignOutAsync();
                return true;
            }
            catch (Exception ex) { Debug.WriteLine(ex.Message); }
            return false;
        }
    }
}

   
