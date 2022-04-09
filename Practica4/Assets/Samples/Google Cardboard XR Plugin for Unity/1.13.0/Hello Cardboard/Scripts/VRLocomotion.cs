using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRLocomotion : GazeInteractable
{
    public Vector3 playerHeightOffset = new Vector3(0,1.0f,0);

    public override void OnPointerEnter()
    {
         base.OnPointerEnter();
    }

    public override void OnPointerExit()
    {
         base.OnPointerExit();
    }

    public override void OnPointerClick()
    {
        base.OnPointerClick();
        //teletransportar al jugador a las coordenadas de este objeto
        Transform player = GameObject.FindGameObjectWithTag("Player").transform;
        player.position = transform.position + playerHeightOffset;

    }
}
