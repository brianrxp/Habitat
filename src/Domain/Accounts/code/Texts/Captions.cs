﻿namespace Habitat.Accounts.Texts
{
  using Habitat.Framework.SitecoreExtensions.Repositories;

  public static class Captions
  {
    public static string Email => DictionaryRepository.Get("/Accounts/Captions/Email", "E-mail");
    public static string Login => DictionaryRepository.Get("/Accounts/Captions/Login", "Login");
    public static string Logout => DictionaryRepository.Get("/Accounts/Captions/Logout", "Logout");
    public static string Password => DictionaryRepository.Get("/Accounts/Captions/Password", "Password");
    public static string ConfirmPassword => DictionaryRepository.Get("/Accounts/Captions/ConfirmPassword", "Confirm password");
    public static string Register => DictionaryRepository.Get("/Accounts/Captions/Register", "Register");
    public static string ResetPassword => DictionaryRepository.Get("/Accounts/Captions/ResetPassword", "Reset password");
    public static string ResetPasswordInfo => DictionaryRepository.Get("/Accounts/Captions/ResetPasswordInfo", "The new password will be sent to your e-mail.");
    public static string ResetPasswordSuccess => DictionaryRepository.Get("/Accounts/Captions/ResetPasswordSuccess", "Your password has been reset.");
    public static string RegisterSuccess => DictionaryRepository.Get("/Accounts/Captions/RegisterSuccess", "Registration was successfully completed");
    public static string RememberMe => DictionaryRepository.Get("/Accounts/Captions/RememberMe", "Remember me");
    public static string ForgotYourPassword => DictionaryRepository.Get("/Accounts/Captions/ForgotYourPassword", "Forgot your password?");
    public static string Cancel => DictionaryRepository.Get("/Accounts/Captions/Cancel", "Cancel");
    public static string EditDetail => DictionaryRepository.Get("/Accounts/Captions/EditDetails", "Edit details");
    public static string RegisterTitle => DictionaryRepository.Get("/Accounts/Captions/Register Title", "Register");
    public static string LoginTitle => DictionaryRepository.Get("/Accounts/Captions/Login Title", "Login");
    public static string LoginRegisterLink => DictionaryRepository.Get("/Accounts/Captions/Signup on Login", "Don't have an account yet? Sign up now.");
  }
}