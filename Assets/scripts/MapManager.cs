using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MapManager : MonoBehaviour {

    public Image map;
    public Image pointer;
    public Text text;

    private float latitude = 0;
    private float longitude = 0;

    private const float DOWN_LATITUDE = 49.510028f;
    private const float LEFT_LONGITUDE = 18.356850f;

    private const float UP_LATITUDE = 53.508409f;
    private const float RIGHT_LONGITUDE = 22.749740f;

    private float minMapX;
    private float maxMapX;
    private float minMapY;
    private float maxMapY;

    IEnumerator Start () {
        while (true) { 
       
        Input.location.Start();

        int maxWait = 20;
        while (Input.location.status == LocationServiceStatus.Initializing && maxWait > 0)
        {
            yield return new WaitForSeconds(1);
            maxWait--;
        }
                text.text = "Pozycja: " + Input.location.lastData.latitude + " " + Input.location.lastData.longitude;
                latitude = Input.location.lastData.latitude;
                longitude = Input.location.lastData.longitude;
                UpdateCursorPosition();
            
            yield return new WaitForSeconds(1);
        }
    }

    private void Awake()
    {
        minMapX = map.rectTransform.rect.xMin;
        maxMapX = map.rectTransform.rect.xMax;
        minMapY = map.rectTransform.rect.yMin;
        maxMapY = map.rectTransform.rect.yMax;

    }

    // Update is called once per frame
    void Update () {

    }

    private void UpdateCursorPosition() {
        latitude = latitude - DOWN_LATITUDE;
        longitude = longitude - LEFT_LONGITUDE;

        float maxX = RIGHT_LONGITUDE - LEFT_LONGITUDE;
        float currentX = (longitude / maxX) * 1000 -500;

        float maxY = UP_LATITUDE - DOWN_LATITUDE;
        float currentY = (latitude / maxY) * 1000 - 500 ;
        currentY += pointer.rectTransform.rect.height *0.2f;
        pointer.rectTransform.localPosition = new Vector3(currentX, currentY, 0);
    }
}
