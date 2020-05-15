using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeOnTimer : MonoBehaviour
{
  private float tickTime = 0f;
  public Material[] material;
  Renderer rend;



  void Start(){
    //uses render to set starting colors
    rend = GetComponent<Renderer>();
    rend.enabled= true;
    //change number to change preset color in array
    rend.sharedMaterial= material[0];


  }

  void Update(){

    rend = GetComponent<Renderer>();
    rend.enabled= true;

    tickTime += Time.deltaTime;


    //changes color after a set amounts of ticks
    if(tickTime >= 3.5f ){
      rend.sharedMaterial= material[1];
    }if(tickTime >= 6.5f){
      rend.sharedMaterial= material[2];
    }if(tickTime >= 9.5f){
      rend.sharedMaterial= material[0];
    }

  }
}
