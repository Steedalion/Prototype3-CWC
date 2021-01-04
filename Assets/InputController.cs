// GENERATED AUTOMATICALLY FROM 'Assets/InputController.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputController : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputController()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputController"",
    ""maps"": [
        {
            ""name"": ""PlayerWalking"",
            ""id"": ""85974b88-86ba-4164-827f-750dccfdf2bd"",
            ""actions"": [
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""7fd15442-e752-4340-b51e-cb785c250f99"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""7be2bd22-07c1-45f1-a232-37456bc77a8a"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""PlayerControl1"",
            ""id"": ""a83f77f6-6649-4238-86c2-f47e5d6d281b"",
            ""actions"": [
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""ef3306a5-8304-4fa1-97f1-8bf1a9e3332f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""66488928-0638-430b-a00a-60ebb4ef8fe9"",
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
        // PlayerWalking
        m_PlayerWalking = asset.FindActionMap("PlayerWalking", throwIfNotFound: true);
        m_PlayerWalking_Jump = m_PlayerWalking.FindAction("Jump", throwIfNotFound: true);
        // PlayerControl1
        m_PlayerControl1 = asset.FindActionMap("PlayerControl1", throwIfNotFound: true);
        m_PlayerControl1_Jump = m_PlayerControl1.FindAction("Jump", throwIfNotFound: true);
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

    // PlayerWalking
    private readonly InputActionMap m_PlayerWalking;
    private IPlayerWalkingActions m_PlayerWalkingActionsCallbackInterface;
    private readonly InputAction m_PlayerWalking_Jump;
    public struct PlayerWalkingActions
    {
        private @InputController m_Wrapper;
        public PlayerWalkingActions(@InputController wrapper) { m_Wrapper = wrapper; }
        public InputAction @Jump => m_Wrapper.m_PlayerWalking_Jump;
        public InputActionMap Get() { return m_Wrapper.m_PlayerWalking; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerWalkingActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerWalkingActions instance)
        {
            if (m_Wrapper.m_PlayerWalkingActionsCallbackInterface != null)
            {
                @Jump.started -= m_Wrapper.m_PlayerWalkingActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerWalkingActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerWalkingActionsCallbackInterface.OnJump;
            }
            m_Wrapper.m_PlayerWalkingActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
            }
        }
    }
    public PlayerWalkingActions @PlayerWalking => new PlayerWalkingActions(this);

    // PlayerControl1
    private readonly InputActionMap m_PlayerControl1;
    private IPlayerControl1Actions m_PlayerControl1ActionsCallbackInterface;
    private readonly InputAction m_PlayerControl1_Jump;
    public struct PlayerControl1Actions
    {
        private @InputController m_Wrapper;
        public PlayerControl1Actions(@InputController wrapper) { m_Wrapper = wrapper; }
        public InputAction @Jump => m_Wrapper.m_PlayerControl1_Jump;
        public InputActionMap Get() { return m_Wrapper.m_PlayerControl1; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerControl1Actions set) { return set.Get(); }
        public void SetCallbacks(IPlayerControl1Actions instance)
        {
            if (m_Wrapper.m_PlayerControl1ActionsCallbackInterface != null)
            {
                @Jump.started -= m_Wrapper.m_PlayerControl1ActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerControl1ActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerControl1ActionsCallbackInterface.OnJump;
            }
            m_Wrapper.m_PlayerControl1ActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
            }
        }
    }
    public PlayerControl1Actions @PlayerControl1 => new PlayerControl1Actions(this);
    public interface IPlayerWalkingActions
    {
        void OnJump(InputAction.CallbackContext context);
    }
    public interface IPlayerControl1Actions
    {
        void OnJump(InputAction.CallbackContext context);
    }
}
