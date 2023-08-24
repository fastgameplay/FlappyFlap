using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Animator))]
public class PlayerAnimation : PlayerBase
{
    Animator _animator;
    protected override void Awake(){
        base.Awake();
        _animator = GetComponent<Animator>();
    }
    void OnEnable(){
        player.Data.Events.OnDeath += OnDeath;
    }
    void OnDisable(){
        player.Data.Events.OnDeath -= OnDeath;
    }

    private void OnDeath(){
        _animator.speed = 0;
    }
}