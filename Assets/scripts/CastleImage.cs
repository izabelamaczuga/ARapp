using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CastleImage : MonoBehaviour {

    public Sprite Image;
    public string CastleName; 

    void OnEnable()
    {
        Debug.Log(CastleName);

        if (PlayerPrefs.GetInt(CastleName, 0) == 1)   
        {
            this.GetComponent<Image>().sprite = Image;
        };

    }


}
