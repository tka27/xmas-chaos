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
            if (!Locale.currentLanguageHasBeenSet)
            {
                Locale.currentLanguageHasBeenSet = true;
                SetCurrentLanguage(Locale.PlayerLanguage);
            }
            UpdateLocal();
        }
        public static string GetLocalizedString(string key)
        {
            if (Locale.CurrentLanguageStrings.ContaintsKey(key))
                return Locale.CurrentLanguageStrings[key];
            else
                return string.Empty;
        }

        public static void SetCurrentLanguage(SystemLanguage language)
        {
            Localization.CurrentLanguage = language.ToString();
            Locale.PlayerLanguage = language;
            Localize[] allTexts = GameObjectd.FindObjectsofType<Localize>();
            for (int i = 0; i < allTexts.Length; i++)
            {
                allTexts[i].UpdateLocale();
            }
        }

        #endregion Public Methods

    }
}
