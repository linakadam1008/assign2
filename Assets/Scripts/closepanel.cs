using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closepanel : MonoBehaviour
{
    public GameObject gameObject;
    bool active ;
    
    public void close()
    {
        if (active == true)
        {
            gameObject.transform.gameObject.SetActive(false);
            active = false;

           
        }
      else
         {
            gameObject.transform.gameObject.SetActive(false);
            active = true;
        }
    }

}
