using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Screenshot : MonoBehaviour {

    public void TakeScreenshot() {

        StartCoroutine("CaptureShot");

    }
    IEnumerator CaptureShot()
    {
        string timestamp = System.DateTime.Now.ToString("dd-MM-YYYY-HH-mm-ss");
        string fileName = "Screenshot" + timestamp + ".png";
        string pathToSave = fileName;

        ScreenCapture.CaptureScreenshot(pathToSave);

        yield return new WaitForEndOfFrame();

        Debug.Log(Application.persistentDataPath);
       
    }
    
}
