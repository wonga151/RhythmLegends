using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Progress : MonoBehaviour
{
    public Transform LoadingBar;

    private float currentProgress;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        LoadingBar.GetComponent<Image>().fillAmount = GameManager.instance.getCurrentSongProgress();
    }
}
