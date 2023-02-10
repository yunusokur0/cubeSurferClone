using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    public float rotationSpeed;
    public Image fillRateImage;
    public GameObject Player;
    public GameObject finishLine;
    public GameObject background;
    public GameObject success;
    public GameObject radialshine;
    public GameObject button;
    public GameObject coin100;
    public GameObject coinImage;
    void Start()
    {
        instance = this;
    }

    
    void Update()
    {
        radian();
        fillRateImage.fillAmount = (Player.transform.position.z) / (finishLine.transform.position.z);
    }
    public void fnish()
    {
        StartCoroutine(finishScreen());
    }
    public IEnumerator finishScreen()
    {
        yield return new WaitForSecondsRealtime(0.5f);
        success.SetActive(true);
        yield return new WaitForSecondsRealtime(0.6f);
        background.SetActive(true);
        yield return new WaitForSecondsRealtime(0.8f);
      
        radialshine.SetActive(true);
       
        yield return new WaitForSecondsRealtime(0.9f);
        coin100.SetActive(true);
        coinImage.SetActive(true);
        yield return new WaitForSecondsRealtime(1f);
        button.SetActive(true);
    }
    public void radian()
    {
        radialshine.transform.Rotate(new Vector3(0, 0, Time.deltaTime * rotationSpeed));
    }
}
