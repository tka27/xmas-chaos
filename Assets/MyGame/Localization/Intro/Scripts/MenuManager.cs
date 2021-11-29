using UnityEngine;
using MyGame.Localization;

public class MenuManager : MonoBehaviour
{
    #region Public Methods

    public void SetEnglish()
    {
        Localize.SetCurrentLanguage(SystemLanguage.English);
    }

    public void SetRussian()
    {
        Localize.SetCurrentLanguage(SystemLanguage.Russian);
    }
    #endregion Public Methods
}
