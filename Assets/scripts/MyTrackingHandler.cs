using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class MyTrackingHandler :  DefaultTrackableEventHandler {

    protected override void OnTrackingFound() {
        base.OnTrackingFound();
        switch (mTrackableBehaviour.TrackableName)
        {
            case "besiekiery":
                PlayerPrefs.SetInt("ShowCastleBesiekiery", 1);
                break;

            case "siewierz":
                PlayerPrefs.SetInt("ShowCastleSiewierz", 1);
                break;

            case "odrzykon":
                PlayerPrefs.SetInt("ShowCastleOdrzykon", 1);
                break;

            case "checiny":
                PlayerPrefs.SetInt("ShowCastleCheciny", 1);
                break;

            case "ogrodzieniec":
                PlayerPrefs.SetInt("ShowCastleOgrodzieniec", 1);
                break;
        }
       

    }	
}
