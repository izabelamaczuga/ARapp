using System.IO;
using UnityEngine;
using UnityEngine.UI;



public class Gallery : MonoBehaviour {

    public GameObject canvas;
    string[] files = null;
    int ScreenShot = 0;

    private void Start()
    {
        files = Directory.GetFiles(Application.persistentDataPath + "/", "*.png");
        if (files.Length > 0)
        {
            PictureDisplay();
        }
    }
    void PictureDisplay()
    {
        string pathToFile = files[ScreenShot];
        Texture2D texture = GetScreenshotImage(pathToFile);
        Sprite sp = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height),
            new Vector2(0.5f, 0.5f));
        canvas.GetComponent<Image>().sprite = sp;

    }

    Texture2D GetScreenshotImage(string filePath) {
        Texture2D texture = null;
        byte[] fileBytes;

        if (File.Exists(filePath)) {
            fileBytes = File.ReadAllBytes(filePath);
            texture = new Texture2D(2, 2, TextureFormat.RGB24, false);
            texture.LoadImage(fileBytes);

        }

        return texture;

    }

    public void NextPicture() {

        if (files.Length > 0) {
            ScreenShot += 1;
            if (ScreenShot > files.Length - 1)
                ScreenShot = 0;

            PictureDisplay();

        }
    }


    public void PreviousPicture() {
        if (files.Length > 0) {
            ScreenShot -= 1;
            if (ScreenShot < 0)
                ScreenShot = files.Length - 1;
            PictureDisplay();
                
        }
    }
}

