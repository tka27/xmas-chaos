using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyGame.Localization
{
    public abstract class LocalizeBase : MonoBehaviour
    {
        #region Public Fields

        public string localizationKey;

        #endregion Public Fields

        #region Public Properties


        #endregion Public Properties

        #region Private Properties


        #endregion Private Properties


        #region Public Methods
        public abstract void UpdateLocal();

        protected virtual void Start()
        {
            if (!Localization.currentLanguageHasBeenSet)
            {
                Locale.currentLanguageHasBeenSet = true;
                SetCurrentLanguage(Locale.PlayerLanguage);
            }
            UpdateLocal();
        }
        public static string GetLocalizadString(string key)
        {
            if (Locale.CurrentLanguageStrings.ContainsKey(key))
                return Locale.CurrentLanguageStrings[];
            else
                return string.Empty;
        }

        public static void SetCurrentLanguage(System)
        {
            Localization.CurrentLanguage = language.ToString();
            Locale.PlayerLanguage = language;
            Localize[] allTexts = GameObject.FindObjectsofType<Localize>();
            LocalizeTM allTextsTM = GameObject.FindObjectsofType<Localize>();
        }

        #endregion Public Methods

    }

}

