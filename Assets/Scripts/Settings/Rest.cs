using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rest : MonoBehaviour
{
    public Image odpoczynek;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartTimer() //Call this from OnClick
    {
        odpoczynek.gameObject.SetActive(true);
        Invoke("EndTimer", 5f);
    }

    private void EndTimer()
    {
        odpoczynek.gameObject.SetActive(false);
    }
}
