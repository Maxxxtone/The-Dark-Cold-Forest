// GENERATED AUTOMATICALLY FROM 'Assets/Input/InputMaster.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputMaster : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputMaster()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputMaster"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""ff87bca8-e8c4-49ce-9b13-7d26a5ec0af0"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""7bd4e809-8bbf-4e2b-8bbc-62620f682624"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""50b3a6b1-189d-4bb2-81bf-0cc520674d27"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SwitchScene"",
                    ""type"": ""Button"",
                    ""id"": ""b7d5ec80-bab3-4005-bb61-8286c624a8fa"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""02f42cf6-7584-4700-acde-59af34fa3d53"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""74aaf9cf-fef5-4b98-9618-1013128a3e77"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""50fb6d4b-4e42-41d3-99b8-ae2a8c5945fa"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""a9791d10-2c35-4692-9ba7-f4f6488348bb"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""15096fc3-0c95-48da-b479-ec2f46f8d7e8"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""c539afa8-f6c6-4c68-8a47-213e8da98962"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""038e6d3b-55ef-4f3d-9147-129edab50fa3"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""eb0af3be-860c-4073-a02d-f43b2cecca70"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwitchScene"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Cursor"",
            ""id"": ""2c751af9-13e6-4f62-afe4-980fae5fab90"",
            ""actions"": [
                {
                    ""name"": ""MousePosition"",
                    ""type"": ""Value"",
                    ""id"": ""63bf89ce-fbe3-4347-89ff-b33cd5d14ac7"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""04389f64-1145-4cd9-9034-eeb3fdddba07"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MousePosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""PauseMenu"",
            ""id"": ""e7f5f572-883a-44e1-a61b-44a47ce78831"",
            ""actions"": [
                {
                    ""name"": ""Invoke"",
                    ""type"": ""Button"",
                    ""id"": ""f096a90e-a30f-4424-8545-1ccfac05794d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""13ab3650-1bf5-45af-9357-2279969ee0a0"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Invoke"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Movement = m_Player.FindAction("Movement", throwIfNotFound: true);
        m_Player_Attack = m_Player.FindAction("Attack", throwIfNotFound: true);
        m_Player_SwitchScene = m_Player.FindAction("SwitchScene", throwIfNotFound: true);
        // Cursor
        m_Cursor = asset.FindActionMap("Cursor", throwIfNotFound: true);
        m_Cursor_MousePosition = m_Cursor.FindAction("MousePosition", throwIfNotFound: true);
        // PauseMenu
        m_PauseMenu = asset.FindActionMap("PauseMenu", throwIfNotFound: true);
        m_PauseMenu_Invoke = m_PauseMenu.FindAction("Invoke", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Movement;
    private readonly InputAction m_Player_Attack;
    private readonly InputAction m_Player_SwitchScene;
    public struct PlayerActions
    {
        private @InputMaster m_Wrapper;
        public PlayerActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Player_Movement;
        public InputAction @Attack => m_Wrapper.m_Player_Attack;
        public InputAction @SwitchScene => m_Wrapper.m_Player_SwitchScene;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Attack.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAttack;
                @Attack.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAttack;
                @Attack.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAttack;
                @SwitchScene.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSwitchScene;
                @SwitchScene.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSwitchScene;
                @SwitchScene.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSwitchScene;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Attack.started += instance.OnAttack;
                @Attack.performed += instance.OnAttack;
                @Attack.canceled += instance.OnAttack;
                @SwitchScene.started += instance.OnSwitchScene;
                @SwitchScene.performed += instance.OnSwitchScene;
                @SwitchScene.canceled += instance.OnSwitchScene;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);

    // Cursor
    private readonly InputActionMap m_Cursor;
    private ICursorActions m_CursorActionsCallbackInterface;
    private readonly InputAction m_Cursor_MousePosition;
    public struct CursorActions
    {
        private @InputMaster m_Wrapper;
        public CursorActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @MousePosition => m_Wrapper.m_Cursor_MousePosition;
        public InputActionMap Get() { return m_Wrapper.m_Cursor; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CursorActions set) { return set.Get(); }
        public void SetCallbacks(ICursorActions instance)
        {
            if (m_Wrapper.m_CursorActionsCallbackInterface != null)
            {
                @MousePosition.started -= m_Wrapper.m_CursorActionsCallbackInterface.OnMousePosition;
                @MousePosition.performed -= m_Wrapper.m_CursorActionsCallbackInterface.OnMousePosition;
                @MousePosition.canceled -= m_Wrapper.m_CursorActionsCallbackInterface.OnMousePosition;
            }
            m_Wrapper.m_CursorActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MousePosition.started += instance.OnMousePosition;
                @MousePosition.performed += instance.OnMousePosition;
                @MousePosition.canceled += instance.OnMousePosition;
            }
        }
    }
    public CursorActions @Cursor => new CursorActions(this);

    // PauseMenu
    private readonly InputActionMap m_PauseMenu;
    private IPauseMenuActions m_PauseMenuActionsCallbackInterface;
    private readonly InputAction m_PauseMenu_Invoke;
    public struct PauseMenuActions
    {
        private @InputMaster m_Wrapper;
        public PauseMenuActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @Invoke => m_Wrapper.m_PauseMenu_Invoke;
        public InputActionMap Get() { return m_Wrapper.m_PauseMenu; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PauseMenuActions set) { return set.Get(); }
        public void SetCallbacks(IPauseMenuActions instance)
        {
            if (m_Wrapper.m_PauseMenuActionsCallbackInterface != null)
            {
                @Invoke.started -= m_Wrapper.m_PauseMenuActionsCallbackInterface.OnInvoke;
                @Invoke.performed -= m_Wrapper.m_PauseMenuActionsCallbackInterface.OnInvoke;
                @Invoke.canceled -= m_Wrapper.m_PauseMenuActionsCallbackInterface.OnInvoke;
            }
            m_Wrapper.m_PauseMenuActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Invoke.started += instance.OnInvoke;
                @Invoke.performed += instance.OnInvoke;
                @Invoke.canceled += instance.OnInvoke;
            }
        }
    }
    public PauseMenuActions @PauseMenu => new PauseMenuActions(this);
    public interface IPlayerActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnAttack(InputAction.CallbackContext context);
        void OnSwitchScene(InputAction.CallbackContext context);
    }
    public interface ICursorActions
    {
        void OnMousePosition(InputAction.CallbackContext context);
    }
    public interface IPauseMenuActions
    {
        void OnInvoke(InputAction.CallbackContext context);
    }
}
