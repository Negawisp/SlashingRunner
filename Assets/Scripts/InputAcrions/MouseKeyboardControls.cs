// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/InputAcrions/MouseKeyboardControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @MouseKeyboardControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @MouseKeyboardControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""MouseKeyboardControls"",
    ""maps"": [
        {
            ""name"": ""MouseKeyboard"",
            ""id"": ""d9453d04-58c6-4519-af70-59b74234023b"",
            ""actions"": [
                {
                    ""name"": ""LMBPress"",
                    ""type"": ""PassThrough"",
                    ""id"": ""10712a12-8160-4c8a-a13d-470f023353a7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LMBRelease"",
                    ""type"": ""Button"",
                    ""id"": ""18b51f48-4fa2-497a-8c67-0f484bf3480a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""1710192d-d0ca-4a93-9156-dc5c66527d3e"",
                    ""path"": ""<Mouse>/press"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LMBPress"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""147a212f-b49d-4463-a6d3-2139f4785f9c"",
                    ""path"": ""<Mouse>/press"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LMBRelease"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // MouseKeyboard
        m_MouseKeyboard = asset.FindActionMap("MouseKeyboard", throwIfNotFound: true);
        m_MouseKeyboard_LMBPress = m_MouseKeyboard.FindAction("LMBPress", throwIfNotFound: true);
        m_MouseKeyboard_LMBRelease = m_MouseKeyboard.FindAction("LMBRelease", throwIfNotFound: true);
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

    // MouseKeyboard
    private readonly InputActionMap m_MouseKeyboard;
    private IMouseKeyboardActions m_MouseKeyboardActionsCallbackInterface;
    private readonly InputAction m_MouseKeyboard_LMBPress;
    private readonly InputAction m_MouseKeyboard_LMBRelease;
    public struct MouseKeyboardActions
    {
        private @MouseKeyboardControls m_Wrapper;
        public MouseKeyboardActions(@MouseKeyboardControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @LMBPress => m_Wrapper.m_MouseKeyboard_LMBPress;
        public InputAction @LMBRelease => m_Wrapper.m_MouseKeyboard_LMBRelease;
        public InputActionMap Get() { return m_Wrapper.m_MouseKeyboard; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MouseKeyboardActions set) { return set.Get(); }
        public void SetCallbacks(IMouseKeyboardActions instance)
        {
            if (m_Wrapper.m_MouseKeyboardActionsCallbackInterface != null)
            {
                @LMBPress.started -= m_Wrapper.m_MouseKeyboardActionsCallbackInterface.OnLMBPress;
                @LMBPress.performed -= m_Wrapper.m_MouseKeyboardActionsCallbackInterface.OnLMBPress;
                @LMBPress.canceled -= m_Wrapper.m_MouseKeyboardActionsCallbackInterface.OnLMBPress;
                @LMBRelease.started -= m_Wrapper.m_MouseKeyboardActionsCallbackInterface.OnLMBRelease;
                @LMBRelease.performed -= m_Wrapper.m_MouseKeyboardActionsCallbackInterface.OnLMBRelease;
                @LMBRelease.canceled -= m_Wrapper.m_MouseKeyboardActionsCallbackInterface.OnLMBRelease;
            }
            m_Wrapper.m_MouseKeyboardActionsCallbackInterface = instance;
            if (instance != null)
            {
                @LMBPress.started += instance.OnLMBPress;
                @LMBPress.performed += instance.OnLMBPress;
                @LMBPress.canceled += instance.OnLMBPress;
                @LMBRelease.started += instance.OnLMBRelease;
                @LMBRelease.performed += instance.OnLMBRelease;
                @LMBRelease.canceled += instance.OnLMBRelease;
            }
        }
    }
    public MouseKeyboardActions @MouseKeyboard => new MouseKeyboardActions(this);
    public interface IMouseKeyboardActions
    {
        void OnLMBPress(InputAction.CallbackContext context);
        void OnLMBRelease(InputAction.CallbackContext context);
    }
}
