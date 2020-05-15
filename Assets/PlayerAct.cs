// GENERATED AUTOMATICALLY FROM 'Assets/PlayerAct.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerAct : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerAct()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerAct"",
    ""maps"": [
        {
            ""name"": ""PlatformAction"",
            ""id"": ""f3277c02-8200-4404-a664-75f9fe9dc409"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""002318d1-8b13-48b9-8bc8-b9daf55f89a7"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Value"",
                    ""id"": ""59eee94b-160a-4ab7-97c4-46a23218ceca"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""fe3d8284-79b0-415c-98c2-7c0c71c0076b"",
                    ""path"": ""<Gamepad>/dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""3c14ac8c-5f84-44c6-b0da-deab7264c393"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""bc408026-c333-420e-b4e4-2b80967a8cd0"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""75e1319d-0848-4917-b7c2-5581689bf443"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""8472c2b3-91ed-408f-84bb-4c81b0284bac"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""95fadfc2-6177-40b5-be5a-e6d9f618debb"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""6013379c-8813-4578-b4c8-be4d362b2ad6"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e2c55c02-b66c-40e4-9c63-c6eb58e14c12"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlatformAction
        m_PlatformAction = asset.FindActionMap("PlatformAction", throwIfNotFound: true);
        m_PlatformAction_Move = m_PlatformAction.FindAction("Move", throwIfNotFound: true);
        m_PlatformAction_Jump = m_PlatformAction.FindAction("Jump", throwIfNotFound: true);
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

    // PlatformAction
    private readonly InputActionMap m_PlatformAction;
    private IPlatformActionActions m_PlatformActionActionsCallbackInterface;
    private readonly InputAction m_PlatformAction_Move;
    private readonly InputAction m_PlatformAction_Jump;
    public struct PlatformActionActions
    {
        private @PlayerAct m_Wrapper;
        public PlatformActionActions(@PlayerAct wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_PlatformAction_Move;
        public InputAction @Jump => m_Wrapper.m_PlatformAction_Jump;
        public InputActionMap Get() { return m_Wrapper.m_PlatformAction; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlatformActionActions set) { return set.Get(); }
        public void SetCallbacks(IPlatformActionActions instance)
        {
            if (m_Wrapper.m_PlatformActionActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_PlatformActionActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlatformActionActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlatformActionActionsCallbackInterface.OnMove;
                @Jump.started -= m_Wrapper.m_PlatformActionActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlatformActionActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlatformActionActionsCallbackInterface.OnJump;
            }
            m_Wrapper.m_PlatformActionActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
            }
        }
    }
    public PlatformActionActions @PlatformAction => new PlatformActionActions(this);
    public interface IPlatformActionActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
    }
}
