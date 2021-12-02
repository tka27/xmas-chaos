using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Highlited : MonoBehaviour
{
    function OnModifyLocalization(loc: Localize)
    {
        Debug.Log('LocalizationCallback.CallBackTerm: ' + Localize.CallBackTerm);
        var translation: String = ScriptLocalization.Get(Localize.CallBackTerm + " p", false) as String;
        if (translation == null)
            return;
        var highlightedSpritePath: String = Regex.Replace(translation, '\\[.*', '');
        var highlightedSprite: Sprite = Resources.Load.< Sprite > (highlightedSpritePath);

        var spriteState: SpriteState = new SpriteState();
        spriteState.highlightedSprite = highlightedSprite;
        var button: Button = GetComponent.< Button > ();
        button.spriteState = spriteState;
    }
}
