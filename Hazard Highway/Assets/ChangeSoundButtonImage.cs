using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeSoundButtonImage : MonoBehaviour
{
    public Image soundImage;
    public Sprite soundOnSprite;
    public Sprite soundOffSprite;
    public bool isSoundOn;

    public void ImageSwap()
    {
        if (isSoundOn)
        {
            soundImage.sprite = soundOffSprite;
            isSoundOn = false;
        }
        else
        {
            soundImage.sprite = soundOnSprite;
            isSoundOn = true;
        }

    }
    // Start is called before the first frame update
    void Start()
    {
        isSoundOn = false;
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
