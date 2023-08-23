using System;
using UnityEngine;

public class ScoreStorage : MonoBehaviour
{
    public event Action<int> OnScoreChange;
    public int CurrentScore { 
        get {return _currentScore;} 
        private set{
            _currentScore = value;
            OnScoreChange?.Invoke(value);
        }   
    }    
    private int _currentScore;
    void Awake(){
        _currentScore = 0;
    }
    public void AddScore(){
        CurrentScore++;
    }
}
