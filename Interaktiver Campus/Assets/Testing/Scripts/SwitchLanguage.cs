using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using UnityEngine.Localization;
 using UnityEngine.Localization.Settings;

public class SwitchLanguage : MonoBehaviour
{


    void Start()
    {
        Debug.Log (LocalizationSettings.AvailableLocales.Locales[0]);
        Debug.Log (LocalizationSettings.AvailableLocales.Locales[1]);
    }
    // Start is called before the first frame update


    // Update is called once per frame
     public void LoadLocale(string languageIdentifier)
         {
             LocalizationSettings settings = LocalizationSettings.Instance;
             LocaleIdentifier localeCode = new LocaleIdentifier(languageIdentifier);//can be "en" "de" "ja" etc.
             for(int i = 0; i < LocalizationSettings.AvailableLocales.Locales.Count; i++)
             {
                 Locale aLocale = LocalizationSettings.AvailableLocales.Locales[i];
                 LocaleIdentifier anIdentifier = aLocale.Identifier;
                 if(anIdentifier == localeCode)
                 {
                     LocalizationSettings.SelectedLocale = aLocale;
                     Debug.Log (aLocale);
                 }
             }

             
         }
}
