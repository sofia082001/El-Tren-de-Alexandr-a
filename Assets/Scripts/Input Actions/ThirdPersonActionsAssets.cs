//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/Scripts/Input Actions/ThirdPersonActionsAssets.inputactions
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

public partial class @ThirdPersonActionsAssets : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @ThirdPersonActionsAssets()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""ThirdPersonActionsAssets"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""8ac7bbd5-1e6f-46a6-ac84-acdd0e8f768d"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""96c09700-c96d-4ac1-b842-bee5eb68c54a"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""a433233d-022a-4188-b73c-8b78680e602c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ThrowObject"",
                    ""type"": ""Button"",
                    ""id"": ""f0ab0399-dab8-48f9-ab8c-4ccb606a3ae1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""4fe950bc-8dfc-4e6e-9787-9adbee0eae6b"",
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
                    ""id"": ""8cac92c0-e749-4f92-8735-45e18377fe3f"",
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
                    ""id"": ""dbb9479a-f80e-4b96-9fe2-62411d887dc9"",
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
                    ""id"": ""5303bf62-cfae-44d8-ad60-4e1c59b00056"",
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
                    ""id"": ""b929659a-8d72-45a2-8fa7-ced87601283c"",
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
                    ""id"": ""4a86e5f1-d543-4874-904f-4de236a4032f"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8171d06d-502c-44a4-bb08-b9e01d65e863"",
                    ""path"": ""<Keyboard>/t"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ThrowObject"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Analize"",
            ""id"": ""c6958ffc-ea15-4f7c-9f39-95acf8b5a543"",
            ""actions"": [
                {
                    ""name"": ""Rotate"",
                    ""type"": ""Button"",
                    ""id"": ""e50d2645-7d49-4b3e-8301-6625b42559a2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ClickObjects"",
                    ""type"": ""Button"",
                    ""id"": ""981153bb-d175-49d5-b493-ed44795c20de"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""DeltaMouse"",
                    ""type"": ""Value"",
                    ""id"": ""68c13d22-39b2-4d6b-aaf0-409cfcc85aca"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Zoom"",
                    ""type"": ""Value"",
                    ""id"": ""19e7fb99-5b56-4e98-9092-3c43dd31c400"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""76f45627-2027-46c8-a454-69a9c95668c5"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""493738e1-444e-43ed-81c8-83727636c546"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""ClickObjects"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fc084112-a38c-45a1-94c1-db750232d27d"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""DeltaMouse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""518406b8-9e1a-4354-a283-89c6955074c2"",
                    ""path"": ""<Mouse>/scroll/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PC"",
                    ""action"": ""Zoom"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""PC"",
            ""bindingGroup"": ""PC"",
            ""devices"": []
        }
    ]
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Move = m_Player.FindAction("Move", throwIfNotFound: true);
        m_Player_Interact = m_Player.FindAction("Interact", throwIfNotFound: true);
        m_Player_ThrowObject = m_Player.FindAction("ThrowObject", throwIfNotFound: true);
        // Analize
        m_Analize = asset.FindActionMap("Analize", throwIfNotFound: true);
        m_Analize_Rotate = m_Analize.FindAction("Rotate", throwIfNotFound: true);
        m_Analize_ClickObjects = m_Analize.FindAction("ClickObjects", throwIfNotFound: true);
        m_Analize_DeltaMouse = m_Analize.FindAction("DeltaMouse", throwIfNotFound: true);
        m_Analize_Zoom = m_Analize.FindAction("Zoom", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Move;
    private readonly InputAction m_Player_Interact;
    private readonly InputAction m_Player_ThrowObject;
    public struct PlayerActions
    {
        private @ThirdPersonActionsAssets m_Wrapper;
        public PlayerActions(@ThirdPersonActionsAssets wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Player_Move;
        public InputAction @Interact => m_Wrapper.m_Player_Interact;
        public InputAction @ThrowObject => m_Wrapper.m_Player_ThrowObject;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Interact.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteract;
                @ThrowObject.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnThrowObject;
                @ThrowObject.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnThrowObject;
                @ThrowObject.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnThrowObject;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
                @ThrowObject.started += instance.OnThrowObject;
                @ThrowObject.performed += instance.OnThrowObject;
                @ThrowObject.canceled += instance.OnThrowObject;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);

    // Analize
    private readonly InputActionMap m_Analize;
    private IAnalizeActions m_AnalizeActionsCallbackInterface;
    private readonly InputAction m_Analize_Rotate;
    private readonly InputAction m_Analize_ClickObjects;
    private readonly InputAction m_Analize_DeltaMouse;
    private readonly InputAction m_Analize_Zoom;
    public struct AnalizeActions
    {
        private @ThirdPersonActionsAssets m_Wrapper;
        public AnalizeActions(@ThirdPersonActionsAssets wrapper) { m_Wrapper = wrapper; }
        public InputAction @Rotate => m_Wrapper.m_Analize_Rotate;
        public InputAction @ClickObjects => m_Wrapper.m_Analize_ClickObjects;
        public InputAction @DeltaMouse => m_Wrapper.m_Analize_DeltaMouse;
        public InputAction @Zoom => m_Wrapper.m_Analize_Zoom;
        public InputActionMap Get() { return m_Wrapper.m_Analize; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(AnalizeActions set) { return set.Get(); }
        public void SetCallbacks(IAnalizeActions instance)
        {
            if (m_Wrapper.m_AnalizeActionsCallbackInterface != null)
            {
                @Rotate.started -= m_Wrapper.m_AnalizeActionsCallbackInterface.OnRotate;
                @Rotate.performed -= m_Wrapper.m_AnalizeActionsCallbackInterface.OnRotate;
                @Rotate.canceled -= m_Wrapper.m_AnalizeActionsCallbackInterface.OnRotate;
                @ClickObjects.started -= m_Wrapper.m_AnalizeActionsCallbackInterface.OnClickObjects;
                @ClickObjects.performed -= m_Wrapper.m_AnalizeActionsCallbackInterface.OnClickObjects;
                @ClickObjects.canceled -= m_Wrapper.m_AnalizeActionsCallbackInterface.OnClickObjects;
                @DeltaMouse.started -= m_Wrapper.m_AnalizeActionsCallbackInterface.OnDeltaMouse;
                @DeltaMouse.performed -= m_Wrapper.m_AnalizeActionsCallbackInterface.OnDeltaMouse;
                @DeltaMouse.canceled -= m_Wrapper.m_AnalizeActionsCallbackInterface.OnDeltaMouse;
                @Zoom.started -= m_Wrapper.m_AnalizeActionsCallbackInterface.OnZoom;
                @Zoom.performed -= m_Wrapper.m_AnalizeActionsCallbackInterface.OnZoom;
                @Zoom.canceled -= m_Wrapper.m_AnalizeActionsCallbackInterface.OnZoom;
            }
            m_Wrapper.m_AnalizeActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Rotate.started += instance.OnRotate;
                @Rotate.performed += instance.OnRotate;
                @Rotate.canceled += instance.OnRotate;
                @ClickObjects.started += instance.OnClickObjects;
                @ClickObjects.performed += instance.OnClickObjects;
                @ClickObjects.canceled += instance.OnClickObjects;
                @DeltaMouse.started += instance.OnDeltaMouse;
                @DeltaMouse.performed += instance.OnDeltaMouse;
                @DeltaMouse.canceled += instance.OnDeltaMouse;
                @Zoom.started += instance.OnZoom;
                @Zoom.performed += instance.OnZoom;
                @Zoom.canceled += instance.OnZoom;
            }
        }
    }
    public AnalizeActions @Analize => new AnalizeActions(this);
    private int m_PCSchemeIndex = -1;
    public InputControlScheme PCScheme
    {
        get
        {
            if (m_PCSchemeIndex == -1) m_PCSchemeIndex = asset.FindControlSchemeIndex("PC");
            return asset.controlSchemes[m_PCSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
        void OnThrowObject(InputAction.CallbackContext context);
    }
    public interface IAnalizeActions
    {
        void OnRotate(InputAction.CallbackContext context);
        void OnClickObjects(InputAction.CallbackContext context);
        void OnDeltaMouse(InputAction.CallbackContext context);
        void OnZoom(InputAction.CallbackContext context);
    }
}
