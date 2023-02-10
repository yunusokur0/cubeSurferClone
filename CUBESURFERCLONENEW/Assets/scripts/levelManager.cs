using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class levelManager : MonoBehaviour
{
    public TextMeshPro loingtext;

    public void Start()
    {
        
    }
    public IEnumerator lodingbar()
    {
        while(true)
        {
            loingtext.text = "loading".ToString();
            yield return new WaitForSecondsRealtime(0.5f);
            loingtext.text = "loading.".ToString();
            yield return new WaitForSecondsRealtime(0.5f);
            loingtext.text = "loading..".ToString();
            yield return new WaitForSecondsRealtime(0.5f);
            loingtext.text = "loading...".ToString();
           
        }
    }
}
