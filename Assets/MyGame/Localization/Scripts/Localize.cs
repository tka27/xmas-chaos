using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace MyGame.Localization
{
   [RequireComponent(typeof(Text))]

   public class Localize : LocalizeBase
    {
        #region Private Fields

        private Text text;
        #endregion Private Fields

        #region Public Methods
        public override void UpdateLocale()
        {
            if (!text) return;
            if (!System.String.IsNullOrEmpty(localizationKey) && Locale.CurrentLanguageStrings.ContainsKey(localizationKey))
                text.text = Local.CurrentLanguageString[localizationKey].Replace(@"\n", "" + '\n');
        }
        
        #endregion Public Methods
        
        #region Private Methods

        protected override void Start()
        {
            text = GetComponent<Text>();
            base.Start();
        }

        #endregion Private Methods
    }

}
