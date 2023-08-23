using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Collider2D))]
public class PlayerCollision : PlayerBase
{
    private void OnCollisionEnter2D(Collision2D other){
        if(other.gameObject.CompareTag("DeathZone")){
            player.Data.Events.OnDeath?.Invoke();
        }
    }
    private void OnTriggerEnter2D(Collider2D other){
        if(other.CompareTag("ScoreZone")){
            player.Data.Events.OnScoreIncrement?.Invoke();
        }
    }
}
