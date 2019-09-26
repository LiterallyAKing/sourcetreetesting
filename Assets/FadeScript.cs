using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeScript : MonoBehaviour
{
    Image myimage;
    public bool fadeIn;
    // Start is called before the first frame update
    void Start()
    {
     myimage = GetComponent<Image>();   
    }

    // Update is called once per frame
    void Update()
    {
        if(fadeIn){
            Color newcolor = myimage.color;

            newcolor.a = Mathf.Lerp(1f,0,Time.time / 1f);
            myimage.color = newcolor;

        }
    }
}
