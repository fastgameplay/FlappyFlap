using UnityEngine;
using TMPro;
[RequireComponent(typeof(TextMeshProUGUI))]
public class ScoreUI : MonoBehaviour
{
    TextMeshProUGUI _scoreText;
    [SerializeField] ScoreStorage _scoreStorage;
    void Awake(){
        _scoreText = GetComponent<TextMeshProUGUI>();
    }
    void OnEnable(){
        _scoreStorage.OnScoreChange += OnScoreChange;
    }
    void OnDisable(){
        _scoreStorage.OnScoreChange -= OnScoreChange;
    }
    void OnScoreChange(int Value){
        _scoreText.text = Value.ToString();
    }
}
