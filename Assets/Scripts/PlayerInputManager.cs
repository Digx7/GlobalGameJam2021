using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInputManager : MonoBehaviour
{
    public Vector2Event HorizonatlMovement;
    public Vector2Event HorizontalMovementStopped;
    public FloatEvent VerticalMovement;
    public FloatEvent VerticalMovementStopped;
    public Vector2Event Rotation;

    private Controls controls;

    public void Awake() {
      controls = new Controls();

      setUpInputs();
    }

    private void setUpInputs(){
      controls.Fish.Move_H.performed += ctx => HorizonatlMovement.Invoke(ctx.ReadValue<Vector2>());
      controls.Fish.Move_H.canceled += ctx => HorizontalMovementStopped.Invoke(ctx.ReadValue<Vector2>());
      controls.Fish.Move_Up.performed += ctx => VerticalMovement.Invoke(ctx.ReadValue<float>());
      controls.Fish.Move_Up.canceled += ctx => VerticalMovementStopped.Invoke(ctx.ReadValue<float>());
      controls.Fish.Rotate.performed += ctx => Rotation.Invoke(ctx.ReadValue<Vector2>());
    }

    private void OnEnable() {
        controls.Enable();
    }

    private void OnDisable() {
        controls.Disable();
    }
}
