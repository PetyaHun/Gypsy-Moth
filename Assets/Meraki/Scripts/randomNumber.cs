using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AC;

public class randomNumber : MonoBehaviour
{
   
	public int theNumber;
	public string theNumberSTR;
   
	 public void Generator() 
    {
		theNumber = Random.Range (10000, 99999);
		theNumberSTR = theNumber.ToString();
		AC.GlobalVariables.SetStringValue(2, theNumberSTR);
		Debug.Log(theNumber);
    }

}
