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
    


    
     public void LoadLocale(string languageIdentifier)
         {
             LocalizationSettings settings = LocalizationSettings.Instance;
             LocaleIdentifier localeCode = new LocaleIdentifier(languageIdentifier);
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

             if(languageIdentifier =="en")
             {
                GameObject.Find("Button EN").transform.GetChild(0).GetComponent<Image>().color = new Color32 (55,55,55,255);
                
                Debug.Log(GameObject.Find("Button EN").transform.GetChild(0).GetComponent<Image>().color);
             }
             else
             {
                GameObject.Find("Button EN").transform.GetChild(0).GetComponent<Image>().color = new Color (55f,55f,55f,0f);
             }

             if(languageIdentifier =="de")
             {
                GameObject.Find("Button DE").transform.GetChild(0).GetComponent<Image>().color = new Color32 (55,55,55,255);

                Debug.Log(GameObject.Find("Button DE").transform.GetChild(0).GetComponent<Image>().color);
             }
             else
             {
                GameObject.Find("Button DE").transform.GetChild(0).GetComponent<Image>().color = new Color (55f,55f,55f,0f);
             }

             
         }


       
}
