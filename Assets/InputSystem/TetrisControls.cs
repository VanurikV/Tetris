// GENERATED AUTOMATICALLY FROM 'Assets/InputSystem/TetrisControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @TetrisControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @TetrisControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""TetrisControls"",
    ""maps"": [
        {
            ""name"": ""KeyboardTetrisControl"",
            ""id"": ""95267536-c3d3-45b0-95b6-683689816abd"",
            ""actions"": [
                {
                    ""name"": ""MoveLeft"",
                    ""type"": ""Button"",
                    ""id"": ""cdc7e3be-6089-41d7-8612-10481f4f5670"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveRight"",
                    ""type"": ""Button"",
                    ""id"": ""dd466314-dff5-4882-aa3e-8274008584f6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Down"",
                    ""type"": ""Button"",
                    ""id"": ""343d0470-9c11-437e-83e2-a0c8453fa314"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RotateLeft"",
                    ""type"": ""Button"",
                    ""id"": ""0d5d7565-0421-4c0e-babb-c81c049066a7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RotateRight"",
                    ""type"": ""Button"",
                    ""id"": ""3dd7434c-fe89-4b40-9cd5-61198db5250f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""518f4875-33bd-4b96-8797-ef9633dbf775"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""MoveLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5dfea96d-d496-4dcb-affe-d8532238cf91"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""MoveLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""83900c13-b309-41ae-85fb-5c329c3c06f7"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""08bc6b37-2e2f-4dcb-8ef4-bd8be2767295"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""MoveRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""87e1417a-8ca8-436f-972d-40b57b6b1e81"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b1505e1b-0a77-4bf8-bac4-9857bd67ef7e"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""39dd65ef-add5-47f5-96dd-659d8564edb9"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a62fd486-3088-49b7-828c-6faf81647518"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""RotateLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e76338a5-68d3-4753-8542-75612b440d56"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Mouse"",
            ""id"": ""3172bf17-5114-46cc-8557-150bebb4e85c"",
            ""actions"": [
                {
                    ""name"": ""MousePos"",
                    ""type"": ""Value"",
                    ""id"": ""c0a78aaf-3236-46b9-af3e-261ad3726c73"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MouseL"",
                    ""type"": ""Button"",
                    ""id"": ""9436e806-d1d2-417f-bdfc-d5a3ce5a1f86"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MouseR"",
                    ""type"": ""Button"",
                    ""id"": ""33428ce7-c9bc-445d-b26a-89dc7911f6cc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""51feff5d-2c51-432b-a6ca-aea4ac186ba3"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MousePos"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9587c888-5ce9-4afe-ac37-6ae1c15520f2"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseL"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d32baa6b-94bd-4796-9ec0-3f6bb1846c99"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseR"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""New control scheme"",
            ""bindingGroup"": ""New control scheme"",
            ""devices"": [
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // KeyboardTetrisControl
        m_KeyboardTetrisControl = asset.FindActionMap("KeyboardTetrisControl", throwIfNotFound: true);
        m_KeyboardTetrisControl_MoveLeft = m_KeyboardTetrisControl.FindAction("MoveLeft", throwIfNotFound: true);
        m_KeyboardTetrisControl_MoveRight = m_KeyboardTetrisControl.FindAction("MoveRight", throwIfNotFound: true);
        m_KeyboardTetrisControl_Down = m_KeyboardTetrisControl.FindAction("Down", throwIfNotFound: true);
        m_KeyboardTetrisControl_RotateLeft = m_KeyboardTetrisControl.FindAction("RotateLeft", throwIfNotFound: true);
        m_KeyboardTetrisControl_RotateRight = m_KeyboardTetrisControl.FindAction("RotateRight", throwIfNotFound: true);
        // Mouse
        m_Mouse = asset.FindActionMap("Mouse", throwIfNotFound: true);
        m_Mouse_MousePos = m_Mouse.FindAction("MousePos", throwIfNotFound: true);
        m_Mouse_MouseL = m_Mouse.FindAction("MouseL", throwIfNotFound: true);
        m_Mouse_MouseR = m_Mouse.FindAction("MouseR", throwIfNotFound: true);
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

    // KeyboardTetrisControl
    private readonly InputActionMap m_KeyboardTetrisControl;
    private IKeyboardTetrisControlActions m_KeyboardTetrisControlActionsCallbackInterface;
    private readonly InputAction m_KeyboardTetrisControl_MoveLeft;
    private readonly InputAction m_KeyboardTetrisControl_MoveRight;
    private readonly InputAction m_KeyboardTetrisControl_Down;
    private readonly InputAction m_KeyboardTetrisControl_RotateLeft;
    private readonly InputAction m_KeyboardTetrisControl_RotateRight;
    public struct KeyboardTetrisControlActions
    {
        private @TetrisControls m_Wrapper;
        public KeyboardTetrisControlActions(@TetrisControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @MoveLeft => m_Wrapper.m_KeyboardTetrisControl_MoveLeft;
        public InputAction @MoveRight => m_Wrapper.m_KeyboardTetrisControl_MoveRight;
        public InputAction @Down => m_Wrapper.m_KeyboardTetrisControl_Down;
        public InputAction @RotateLeft => m_Wrapper.m_KeyboardTetrisControl_RotateLeft;
        public InputAction @RotateRight => m_Wrapper.m_KeyboardTetrisControl_RotateRight;
        public InputActionMap Get() { return m_Wrapper.m_KeyboardTetrisControl; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(KeyboardTetrisControlActions set) { return set.Get(); }
        public void SetCallbacks(IKeyboardTetrisControlActions instance)
        {
            if (m_Wrapper.m_KeyboardTetrisControlActionsCallbackInterface != null)
            {
                @MoveLeft.started -= m_Wrapper.m_KeyboardTetrisControlActionsCallbackInterface.OnMoveLeft;
                @MoveLeft.performed -= m_Wrapper.m_KeyboardTetrisControlActionsCallbackInterface.OnMoveLeft;
                @MoveLeft.canceled -= m_Wrapper.m_KeyboardTetrisControlActionsCallbackInterface.OnMoveLeft;
                @MoveRight.started -= m_Wrapper.m_KeyboardTetrisControlActionsCallbackInterface.OnMoveRight;
                @MoveRight.performed -= m_Wrapper.m_KeyboardTetrisControlActionsCallbackInterface.OnMoveRight;
                @MoveRight.canceled -= m_Wrapper.m_KeyboardTetrisControlActionsCallbackInterface.OnMoveRight;
                @Down.started -= m_Wrapper.m_KeyboardTetrisControlActionsCallbackInterface.OnDown;
                @Down.performed -= m_Wrapper.m_KeyboardTetrisControlActionsCallbackInterface.OnDown;
                @Down.canceled -= m_Wrapper.m_KeyboardTetrisControlActionsCallbackInterface.OnDown;
                @RotateLeft.started -= m_Wrapper.m_KeyboardTetrisControlActionsCallbackInterface.OnRotateLeft;
                @RotateLeft.performed -= m_Wrapper.m_KeyboardTetrisControlActionsCallbackInterface.OnRotateLeft;
                @RotateLeft.canceled -= m_Wrapper.m_KeyboardTetrisControlActionsCallbackInterface.OnRotateLeft;
                @RotateRight.started -= m_Wrapper.m_KeyboardTetrisControlActionsCallbackInterface.OnRotateRight;
                @RotateRight.performed -= m_Wrapper.m_KeyboardTetrisControlActionsCallbackInterface.OnRotateRight;
                @RotateRight.canceled -= m_Wrapper.m_KeyboardTetrisControlActionsCallbackInterface.OnRotateRight;
            }
            m_Wrapper.m_KeyboardTetrisControlActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MoveLeft.started += instance.OnMoveLeft;
                @MoveLeft.performed += instance.OnMoveLeft;
                @MoveLeft.canceled += instance.OnMoveLeft;
                @MoveRight.started += instance.OnMoveRight;
                @MoveRight.performed += instance.OnMoveRight;
                @MoveRight.canceled += instance.OnMoveRight;
                @Down.started += instance.OnDown;
                @Down.performed += instance.OnDown;
                @Down.canceled += instance.OnDown;
                @RotateLeft.started += instance.OnRotateLeft;
                @RotateLeft.performed += instance.OnRotateLeft;
                @RotateLeft.canceled += instance.OnRotateLeft;
                @RotateRight.started += instance.OnRotateRight;
                @RotateRight.performed += instance.OnRotateRight;
                @RotateRight.canceled += instance.OnRotateRight;
            }
        }
    }
    public KeyboardTetrisControlActions @KeyboardTetrisControl => new KeyboardTetrisControlActions(this);

    // Mouse
    private readonly InputActionMap m_Mouse;
    private IMouseActions m_MouseActionsCallbackInterface;
    private readonly InputAction m_Mouse_MousePos;
    private readonly InputAction m_Mouse_MouseL;
    private readonly InputAction m_Mouse_MouseR;
    public struct MouseActions
    {
        private @TetrisControls m_Wrapper;
        public MouseActions(@TetrisControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @MousePos => m_Wrapper.m_Mouse_MousePos;
        public InputAction @MouseL => m_Wrapper.m_Mouse_MouseL;
        public InputAction @MouseR => m_Wrapper.m_Mouse_MouseR;
        public InputActionMap Get() { return m_Wrapper.m_Mouse; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MouseActions set) { return set.Get(); }
        public void SetCallbacks(IMouseActions instance)
        {
            if (m_Wrapper.m_MouseActionsCallbackInterface != null)
            {
                @MousePos.started -= m_Wrapper.m_MouseActionsCallbackInterface.OnMousePos;
                @MousePos.performed -= m_Wrapper.m_MouseActionsCallbackInterface.OnMousePos;
                @MousePos.canceled -= m_Wrapper.m_MouseActionsCallbackInterface.OnMousePos;
                @MouseL.started -= m_Wrapper.m_MouseActionsCallbackInterface.OnMouseL;
                @MouseL.performed -= m_Wrapper.m_MouseActionsCallbackInterface.OnMouseL;
                @MouseL.canceled -= m_Wrapper.m_MouseActionsCallbackInterface.OnMouseL;
                @MouseR.started -= m_Wrapper.m_MouseActionsCallbackInterface.OnMouseR;
                @MouseR.performed -= m_Wrapper.m_MouseActionsCallbackInterface.OnMouseR;
                @MouseR.canceled -= m_Wrapper.m_MouseActionsCallbackInterface.OnMouseR;
            }
            m_Wrapper.m_MouseActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MousePos.started += instance.OnMousePos;
                @MousePos.performed += instance.OnMousePos;
                @MousePos.canceled += instance.OnMousePos;
                @MouseL.started += instance.OnMouseL;
                @MouseL.performed += instance.OnMouseL;
                @MouseL.canceled += instance.OnMouseL;
                @MouseR.started += instance.OnMouseR;
                @MouseR.performed += instance.OnMouseR;
                @MouseR.canceled += instance.OnMouseR;
            }
        }
    }
    public MouseActions @Mouse => new MouseActions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    private int m_NewcontrolschemeSchemeIndex = -1;
    public InputControlScheme NewcontrolschemeScheme
    {
        get
        {
            if (m_NewcontrolschemeSchemeIndex == -1) m_NewcontrolschemeSchemeIndex = asset.FindControlSchemeIndex("New control scheme");
            return asset.controlSchemes[m_NewcontrolschemeSchemeIndex];
        }
    }
    public interface IKeyboardTetrisControlActions
    {
        void OnMoveLeft(InputAction.CallbackContext context);
        void OnMoveRight(InputAction.CallbackContext context);
        void OnDown(InputAction.CallbackContext context);
        void OnRotateLeft(InputAction.CallbackContext context);
        void OnRotateRight(InputAction.CallbackContext context);
    }
    public interface IMouseActions
    {
        void OnMousePos(InputAction.CallbackContext context);
        void OnMouseL(InputAction.CallbackContext context);
        void OnMouseR(InputAction.CallbackContext context);
    }
}
