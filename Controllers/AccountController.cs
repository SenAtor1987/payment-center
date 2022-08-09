using payment_center_3.Data.Repositories;
using payment_center_3.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;



namespace payment_center_3.Controllers
{
    public class AccountController : Controller
    {


        private readonly UserRepository _userRepository;
        public AccountController(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Registration()
        {
            return View();
        }

        [HttpPost]

        public async Task<IActionResult> Login(LoginViewModel loginVM)
        {
            if (!ModelState.IsValid)
            {
                return View(loginVM);
            }

            var user = await _userRepository.GetAsync(loginVM.Login);

            if (user == null)
            {
                return View(loginVM);
            }


            if (loginVM.Password == user.Password)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.Login),
                    new Claim(ClaimTypes.Role, user.Role),
                };
                var claimIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimIdentity));
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("Password", "Incorrect password");
                return View(loginVM);
            }
        }

        [Authorize]
        public async Task<IActionResult> Exit()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction(nameof(Login));
        }
    }
}