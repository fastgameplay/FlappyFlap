using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputHandler : PlayerBase
{
    private BasicInput _input;
    protected override void Awake(){
        base.Awake();
        _input = new BasicInput();
    }
    private void OnEnable(){
        _input.Enable();
        _input.Player.Jump.performed += OnTap;
    }
    private void OnDisable(){
        _input.Disable();
        _input.Player.Jump.performed -= OnTap;
    }
    public void OnTap(InputAction.CallbackContext value){
        player.Data.Events.OnTap?.Invoke();
    }
   
}
