using UnityEngine;
using UnityEngine.UI;
public class PauseManager : MonoBehaviour
{
    const int MAX_DIFFICULTY = 4;
    [SerializeField] GameObject PauseButton;
    [SerializeField] GameObject PausePanel;

    [SerializeField] Slider _difficultySlider;
    [SerializeField] FloatVariable _difficultyVariable;
    public void OnPause(){
        PauseButton.SetActive(false);
        PausePanel.SetActive(true);
        _difficultySlider.value = _difficultyVariable.Value * MAX_DIFFICULTY;
        Time.timeScale = 0;
    }
    public void OnResume(){
        PauseButton.SetActive(true);
        PausePanel.SetActive(false);
        _difficultyVariable.Value = _difficultySlider.value / MAX_DIFFICULTY;
        Time.timeScale = 1;
    }
}
