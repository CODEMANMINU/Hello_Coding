using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class Animal { 

    // Start is called before the first frame update

    public string name;
    public string sound;


    public void PlaySound()
    { 
    Debug.Log(name+ ":" + sound);
    }

}
