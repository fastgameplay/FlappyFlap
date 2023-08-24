using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathManager : PlayerBase
{
    [SerializeField] GameObject _deathPanel;
    [SerializeField] FloatVariable _movementScale;
    bool _isDead;

    protected override void Awake(){
        base.Awake();
        _isDead = false;
        _movementScale.Value = 1;
    }

    void OnDeath(){
        _movementScale.Value = 0;
        _isDead = true;
        _deathPanel.SetActive(true);
    }

    void OnTap(){
        if(_isDead){
            ReloadCurrentScene();
        }
    }

    public void ReloadCurrentScene(){
        SceneManager.LoadScene(1);
    }

    void OnEnable(){
        player.Data.Events.OnDeath += OnDeath;
        player.Data.Events.OnTap += OnTap;
    }

    void OnDisable(){
        player.Data.Events.OnDeath -= OnDeath;
        player.Data.Events.OnTap -= OnTap;
    }

}