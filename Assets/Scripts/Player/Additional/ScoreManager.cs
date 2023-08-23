using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : PlayerBase
{
    [SerializeField] ScoreStorage _scoreStorage;

    void OnEnable(){
        player.Data.Events.OnScoreIncrement += _scoreStorage.AddScore;
    }
    void OnDisable(){
        player.Data.Events.OnScoreIncrement -= _scoreStorage.AddScore;
    }
}