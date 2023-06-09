//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/Scripts/Core/Control.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @Control : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Control()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Control"",
    ""maps"": [
        {
            ""name"": ""Snake"",
            ""id"": ""15994d6b-4345-4b11-af12-e7f0490af955"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""5c6eef24-ccae-461f-862c-8d646a0d5218"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""AD"",
                    ""id"": ""d66ac77a-a617-4224-b625-7b872149ebae"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""b9bf0f97-d027-4394-ab89-1a7102be65d3"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""d91c2017-8a88-441e-a892-94258c477a31"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""hax"",
            ""id"": ""5434e09b-caca-4b4c-b86d-e64705974120"",
            ""actions"": [
                {
                    ""name"": ""bodyadd"",
                    ""type"": ""Button"",
                    ""id"": ""1406c11c-1e7b-4769-b56b-66aa6c535ba7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""3b8db9a9-1a2e-4ae0-ac5b-af1975d55d4c"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""bodyadd"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Snake
        m_Snake = asset.FindActionMap("Snake", throwIfNotFound: true);
        m_Snake_Move = m_Snake.FindAction("Move", throwIfNotFound: true);
        // hax
        m_hax = asset.FindActionMap("hax", throwIfNotFound: true);
        m_hax_bodyadd = m_hax.FindAction("bodyadd", throwIfNotFound: true);
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
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Snake
    private readonly InputActionMap m_Snake;
    private ISnakeActions m_SnakeActionsCallbackInterface;
    private readonly InputAction m_Snake_Move;
    public struct SnakeActions
    {
        private @Control m_Wrapper;
        public SnakeActions(@Control wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Snake_Move;
        public InputActionMap Get() { return m_Wrapper.m_Snake; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(SnakeActions set) { return set.Get(); }
        public void SetCallbacks(ISnakeActions instance)
        {
            if (m_Wrapper.m_SnakeActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_SnakeActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_SnakeActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_SnakeActionsCallbackInterface.OnMove;
            }
            m_Wrapper.m_SnakeActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
            }
        }
    }
    public SnakeActions @Snake => new SnakeActions(this);

    // hax
    private readonly InputActionMap m_hax;
    private IHaxActions m_HaxActionsCallbackInterface;
    private readonly InputAction m_hax_bodyadd;
    public struct HaxActions
    {
        private @Control m_Wrapper;
        public HaxActions(@Control wrapper) { m_Wrapper = wrapper; }
        public InputAction @bodyadd => m_Wrapper.m_hax_bodyadd;
        public InputActionMap Get() { return m_Wrapper.m_hax; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(HaxActions set) { return set.Get(); }
        public void SetCallbacks(IHaxActions instance)
        {
            if (m_Wrapper.m_HaxActionsCallbackInterface != null)
            {
                @bodyadd.started -= m_Wrapper.m_HaxActionsCallbackInterface.OnBodyadd;
                @bodyadd.performed -= m_Wrapper.m_HaxActionsCallbackInterface.OnBodyadd;
                @bodyadd.canceled -= m_Wrapper.m_HaxActionsCallbackInterface.OnBodyadd;
            }
            m_Wrapper.m_HaxActionsCallbackInterface = instance;
            if (instance != null)
            {
                @bodyadd.started += instance.OnBodyadd;
                @bodyadd.performed += instance.OnBodyadd;
                @bodyadd.canceled += instance.OnBodyadd;
            }
        }
    }
    public HaxActions @hax => new HaxActions(this);
    public interface ISnakeActions
    {
        void OnMove(InputAction.CallbackContext context);
    }
    public interface IHaxActions
    {
        void OnBodyadd(InputAction.CallbackContext context);
    }
}
