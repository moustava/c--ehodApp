﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;

namespace EhodBoutiqueEnLigne.Models.Services
{
    public class LanguageService : ILanguageService
    {
        /// <summary>
        /// Set the UI language
        /// </summary>
        public void ChangeUiLanguage(HttpContext context, string language)
        {
            string culture = SetCulture(language);
            UpdateCultureCookie(context, culture);
        }

        /// <summary>
        /// Set the culture
        /// </summary>
        public string SetCulture(string language)
        {
            string culture;
            switch (language)
            {
                case ("English"):
                    culture = "en";
                    break;
                case ("French"):
                    culture = "fr";
                    break;
                case ("Arabe"):
                    culture = "ar";
                    break;
                default:
                    culture = "ar";
                    break;
            }
            
            return culture;
        }

        /// <summary>
        /// Update the culture cookie
        /// </summary>
        public void UpdateCultureCookie(HttpContext context, string culture)
        {
            context.Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)));
        }
    }
}
