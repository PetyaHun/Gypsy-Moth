using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AC;

public class randomSound : MonoBehaviour
{

    public AudioSource _as;
    public AudioClip[] stepsWood;
    public AudioClip[] stepsConcrete;

    int[] randomSteps = {5,1,2,3,4,1,5,3,4,2,1,5,3,2};
    AudioClip[] footstepsArray;
    int n = 0;
    string surface = "wood";

    void Awake(){
        _as = GetComponent<AudioSource> ();
    }

   // Start is called before the first frame update
    void playSound()
    {
        surface     = AC.GlobalVariables.GetStringValue(0);

        switch(surface) {
            case "wood": 
                footstepsArray = stepsWood;
                break;
            case "concrete": 
                footstepsArray = stepsConcrete;
                break;
        }
        _as.clip = footstepsArray[randomSteps[n]-1];
        _as.PlayOneShot (_as.clip);
        n += 1;
      if (n>(randomSteps.Length-1)) { n = 0; }
       // Debug.Log(_as.clip);
       Debug.Log(surface);
    }

    // Update is called once per frame
    void Update()
    {

    }
}