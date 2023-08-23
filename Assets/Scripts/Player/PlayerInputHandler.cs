using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputHandler : PlayerBase
{
    private PlayerInputs _input;
    protected override void Awake(){
        base.Awake();
        _input = new PlayerInputs();
    }
    private void OnEnable(){
        _input.Enable();
        _input.Player.Tap.performed += OnTap;
    }
    private void OnDisable(){
        _input.Player.Tap.performed -= OnTap;
        _input.Disable();
    }
    private void OnTap(InputAction.CallbackContext value){
        player.Data.Events.OnTap?.Invoke();
    }
}
