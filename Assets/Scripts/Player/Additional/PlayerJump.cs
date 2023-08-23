using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
public class PlayerJump : PlayerBase
{
    private float JumpForce => player.Data.JumpForce;
    private Rigidbody2D _rb;
    protected override void Awake(){
        base.Awake();
        _rb = GetComponent<Rigidbody2D>();
    }
    void OnEnable(){
        player.Data.Events.OnTap += Jump;
    }
    void OnDisable(){
        player.Data.Events.OnTap -= Jump;
    }

    private void Jump(){
        _rb.velocity = Vector2.up * JumpForce;
    }
}