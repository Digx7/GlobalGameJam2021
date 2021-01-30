// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Controls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""Fish"",
            ""id"": ""31c9fc80-5aee-4a49-968d-3543fcc5f97d"",
            ""actions"": [
                {
                    ""name"": ""Move_H"",
                    ""type"": ""Value"",
                    ""id"": ""8222b225-f226-47b7-813f-bcfef153d298"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move_Up"",
                    ""type"": ""Value"",
                    ""id"": ""fcab9c0a-d074-4c3b-ad6b-a4f2a540f71e"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Rotate"",
                    ""type"": ""Value"",
                    ""id"": ""48638060-1d07-4b1b-9bad-99f9f474e6f0"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""575c0c60-36a4-4b52-9c98-243915de3a5f"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move_H"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""2a07ebe6-b5f0-4f9b-870d-5709b059ee66"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move_H"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""93fc07d7-c77c-4b64-9344-3d22ef2dd346"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move_H"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""cd7e695a-9e97-4063-9861-a5e1385a816b"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move_H"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""4f7be9e9-8fd6-4df1-828b-9e8cb0f33acd"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move_H"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""bd3a5a76-f4a5-4f7a-943e-6655ad8a08c4"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move_H"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""GamePad"",
                    ""id"": ""cf3e1c14-4e58-41a6-a047-50da7c8e9249"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move_Up"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""eb670434-f5bc-4b2f-85d7-260e25afb186"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move_Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""3bac1ed9-8e9e-4b2c-9be1-6b145e10d435"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move_Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""6f85ebfc-fbac-4866-b44f-4e0356042c11"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move_Up"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""bdcfffb0-ad5a-4276-8ad5-39953582da13"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move_Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""655f4389-eb2a-47f2-82d9-115099da1fdf"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move_Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""81d9bacb-027d-42cf-8fc3-59e3e41e77be"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6cd58451-9436-4f7f-84f0-5ad3303a7dfa"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Fish
        m_Fish = asset.FindActionMap("Fish", throwIfNotFound: true);
        m_Fish_Move_H = m_Fish.FindAction("Move_H", throwIfNotFound: true);
        m_Fish_Move_Up = m_Fish.FindAction("Move_Up", throwIfNotFound: true);
        m_Fish_Rotate = m_Fish.FindAction("Rotate", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Fish
    private readonly InputActionMap m_Fish;
    private IFishActions m_FishActionsCallbackInterface;
    private readonly InputAction m_Fish_Move_H;
    private readonly InputAction m_Fish_Move_Up;
    private readonly InputAction m_Fish_Rotate;
    public struct FishActions
    {
        private @Controls m_Wrapper;
        public FishActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move_H => m_Wrapper.m_Fish_Move_H;
        public InputAction @Move_Up => m_Wrapper.m_Fish_Move_Up;
        public InputAction @Rotate => m_Wrapper.m_Fish_Rotate;
        public InputActionMap Get() { return m_Wrapper.m_Fish; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(FishActions set) { return set.Get(); }
        public void SetCallbacks(IFishActions instance)
        {
            if (m_Wrapper.m_FishActionsCallbackInterface != null)
            {
                @Move_H.started -= m_Wrapper.m_FishActionsCallbackInterface.OnMove_H;
                @Move_H.performed -= m_Wrapper.m_FishActionsCallbackInterface.OnMove_H;
                @Move_H.canceled -= m_Wrapper.m_FishActionsCallbackInterface.OnMove_H;
                @Move_Up.started -= m_Wrapper.m_FishActionsCallbackInterface.OnMove_Up;
                @Move_Up.performed -= m_Wrapper.m_FishActionsCallbackInterface.OnMove_Up;
                @Move_Up.canceled -= m_Wrapper.m_FishActionsCallbackInterface.OnMove_Up;
                @Rotate.started -= m_Wrapper.m_FishActionsCallbackInterface.OnRotate;
                @Rotate.performed -= m_Wrapper.m_FishActionsCallbackInterface.OnRotate;
                @Rotate.canceled -= m_Wrapper.m_FishActionsCallbackInterface.OnRotate;
            }
            m_Wrapper.m_FishActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move_H.started += instance.OnMove_H;
                @Move_H.performed += instance.OnMove_H;
                @Move_H.canceled += instance.OnMove_H;
                @Move_Up.started += instance.OnMove_Up;
                @Move_Up.performed += instance.OnMove_Up;
                @Move_Up.canceled += instance.OnMove_Up;
                @Rotate.started += instance.OnRotate;
                @Rotate.performed += instance.OnRotate;
                @Rotate.canceled += instance.OnRotate;
            }
        }
    }
    public FishActions @Fish => new FishActions(this);
    public interface IFishActions
    {
        void OnMove_H(InputAction.CallbackContext context);
        void OnMove_Up(InputAction.CallbackContext context);
        void OnRotate(InputAction.CallbackContext context);
    }
}
