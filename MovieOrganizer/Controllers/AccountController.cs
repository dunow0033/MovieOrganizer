﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MovieOrganizer.Models.ViewModels;

namespace MovieOrganizer.Controllers
{
    public class AccountController : Controller
    {
		private readonly UserManager<IdentityUser> userManager;
		private readonly SignInManager<IdentityUser> signInManager;

		public AccountController(UserManager<IdentityUser> userManager,
			SignInManager<IdentityUser> signInManager)
		{
			this.userManager = userManager;
			this.signInManager = signInManager;
		}

		[HttpGet]
        public IActionResult Register()
        {
            return View();
        }

		//[HttpPost]
		//public async Task<IActionResult> Register(RegisterViewModel registerViewModel)
		//{
		//    var identityUser = new IdentityUser
		//    {
		//        UserName = registerViewModel.Username,
		//        Email = registerViewModel.Email
		//    };

		//    var identityResult = await User.CreateAsync
		//}

		[HttpGet]
		public IActionResult Login()
		{
			return View();
		}


		[HttpPost]
		public async Task<IActionResult> Login(LoginViewModel loginViewModel)
		{
			if (!ModelState.IsValid)
			{
				return View();
			}

			var signInResult = await signInManager.PasswordSignInAsync(loginViewModel.Username,
				loginViewModel.Password, false, false);

			if (signInResult != null && signInResult.Succeeded)
			{
				//if (!string.IsNullOrWhiteSpace(loginViewModel.ReturnUrl))
				//{
				//	return Redirect(loginViewModel.ReturnUrl);
				//}

				return RedirectToAction("Index", "Movies");
			}

			ModelState.AddModelError(string.Empty, "Invalid username or password.");

			return View();
		}
	}
}
