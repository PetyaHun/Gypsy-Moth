using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuItemScript : MonoBehaviour
{
    public GameObject description;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Select()
    {
        description.SetActive(true);
    }
    public void Deselect()
    {
        description.SetActive(false);
    }
}
