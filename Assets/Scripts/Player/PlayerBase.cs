using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBase : MonoBehaviour
{
    protected Player player;
    protected virtual void Awake(){
        player = transform.root.GetComponent<Player>();
    }
}
