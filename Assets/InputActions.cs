// GENERATED AUTOMATICALLY FROM 'Assets/Liminality/Modules/InputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputActions"",
    ""maps"": [
        {
            ""name"": ""Player (Gamepad)"",
            ""id"": ""4b3c270a-fb3b-45f4-b8d0-982369e1227d"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""d60bbf54-ed5b-4498-b0eb-16d81ebf4eb1"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""32abd6d0-5665-49e7-bac3-e3bb69910f55"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Aim"",
                    ""type"": ""Value"",
                    ""id"": ""9e73f93d-4002-474d-8bab-54a8f52bc41d"",
                    ""expectedControlType"": ""Analog"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Melee"",
                    ""type"": ""Button"",
                    ""id"": ""4595de28-24f3-48c5-bb50-2f89111ff260"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""01f4efdd-26ea-4426-91ed-4eafa8e670d2"",
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
                    ""id"": ""309ca2d0-7077-4300-ab54-155301ca1626"",
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
                    ""id"": ""ee189aa3-5d9d-4fa2-9605-0611ffb9f264"",
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
                    ""id"": ""4957dbc2-2424-43c5-9dc4-ac079410d1ed"",
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
                    ""id"": ""8b6b6217-6874-4429-898a-1379d80ec6ac"",
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
                    ""id"": ""8ff2a882-3a20-4658-a8da-b2f9dae20020"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""D-Pad"",
                    ""id"": ""966cc9c6-996b-4e65-b74f-8803fd17340c"",
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
                    ""id"": ""deed6702-997d-4bbb-a330-226452f874d2"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""b3aa40e2-8e46-4335-b074-8f415d03fe5d"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""9c4c705e-5a35-412f-aeb3-c5c992fb87fa"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""8f9709fb-41ff-4c41-ace1-2316efed9af3"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""abd59b50-a1fc-42cb-be00-075f1516f9ab"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""aac0ba63-01a8-44b5-8d46-e46d50b6cb15"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""afe1da87-f460-495f-860f-10f591366606"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c3fdc454-03dc-4c75-b726-64101551dccc"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7e073334-5e0f-42be-9557-36545f62f46e"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Melee"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""84b48ef1-1b4b-4b4a-92ec-a0c0cb456978"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Melee"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Player (KVM)"",
            ""id"": ""e690057b-97c4-4fab-a95c-912e2531e723"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""2446e137-a3c2-4cfb-8eec-fb6cff8b0f43"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""4c6a8228-2fb3-4bad-99cb-cd2ed02f3e94"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Aim"",
                    ""type"": ""Value"",
                    ""id"": ""0ccc675f-81b9-4703-865b-de8cb2cf7103"",
                    ""expectedControlType"": ""Analog"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Melee"",
                    ""type"": ""Button"",
                    ""id"": ""ea0cd1a8-c439-4244-b3d5-10d15ed68da7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""63e9a329-0812-4e29-acce-2ebf761f6a78"",
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
                    ""id"": ""2b99ca10-8d67-499b-8807-727ef490f567"",
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
                    ""id"": ""4827f0c6-4d6a-47fe-b967-ac7cfdf350a8"",
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
                    ""id"": ""9e8391e7-f734-44a7-a649-d8d0ec42f5e3"",
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
                    ""id"": ""b3969fea-5d67-488d-96af-cdae302374bb"",
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
                    ""id"": ""9e8aa18d-cd82-42da-8157-845add775dba"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""aa8c257a-4a43-4872-92be-e83e7fe56f46"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3a7e616a-bdc9-4cee-b6d2-86462f5fc279"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Melee"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player (Gamepad)
        m_PlayerGamepad = asset.FindActionMap("Player (Gamepad)", throwIfNotFound: true);
        m_PlayerGamepad_Movement = m_PlayerGamepad.FindAction("Movement", throwIfNotFound: true);
        m_PlayerGamepad_Jump = m_PlayerGamepad.FindAction("Jump", throwIfNotFound: true);
        m_PlayerGamepad_Aim = m_PlayerGamepad.FindAction("Aim", throwIfNotFound: true);
        m_PlayerGamepad_Melee = m_PlayerGamepad.FindAction("Melee", throwIfNotFound: true);
        // Player (KVM)
        m_PlayerKVM = asset.FindActionMap("Player (KVM)", throwIfNotFound: true);
        m_PlayerKVM_Movement = m_PlayerKVM.FindAction("Movement", throwIfNotFound: true);
        m_PlayerKVM_Jump = m_PlayerKVM.FindAction("Jump", throwIfNotFound: true);
        m_PlayerKVM_Aim = m_PlayerKVM.FindAction("Aim", throwIfNotFound: true);
        m_PlayerKVM_Melee = m_PlayerKVM.FindAction("Melee", throwIfNotFound: true);
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

    // Player (Gamepad)
    private readonly InputActionMap m_PlayerGamepad;
    private IPlayerGamepadActions m_PlayerGamepadActionsCallbackInterface;
    private readonly InputAction m_PlayerGamepad_Movement;
    private readonly InputAction m_PlayerGamepad_Jump;
    private readonly InputAction m_PlayerGamepad_Aim;
    private readonly InputAction m_PlayerGamepad_Melee;
    public struct PlayerGamepadActions
    {
        private @InputActions m_Wrapper;
        public PlayerGamepadActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_PlayerGamepad_Movement;
        public InputAction @Jump => m_Wrapper.m_PlayerGamepad_Jump;
        public InputAction @Aim => m_Wrapper.m_PlayerGamepad_Aim;
        public InputAction @Melee => m_Wrapper.m_PlayerGamepad_Melee;
        public InputActionMap Get() { return m_Wrapper.m_PlayerGamepad; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerGamepadActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerGamepadActions instance)
        {
            if (m_Wrapper.m_PlayerGamepadActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_PlayerGamepadActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PlayerGamepadActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PlayerGamepadActionsCallbackInterface.OnMovement;
                @Jump.started -= m_Wrapper.m_PlayerGamepadActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerGamepadActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerGamepadActionsCallbackInterface.OnJump;
                @Aim.started -= m_Wrapper.m_PlayerGamepadActionsCallbackInterface.OnAim;
                @Aim.performed -= m_Wrapper.m_PlayerGamepadActionsCallbackInterface.OnAim;
                @Aim.canceled -= m_Wrapper.m_PlayerGamepadActionsCallbackInterface.OnAim;
                @Melee.started -= m_Wrapper.m_PlayerGamepadActionsCallbackInterface.OnMelee;
                @Melee.performed -= m_Wrapper.m_PlayerGamepadActionsCallbackInterface.OnMelee;
                @Melee.canceled -= m_Wrapper.m_PlayerGamepadActionsCallbackInterface.OnMelee;
            }
            m_Wrapper.m_PlayerGamepadActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Aim.started += instance.OnAim;
                @Aim.performed += instance.OnAim;
                @Aim.canceled += instance.OnAim;
                @Melee.started += instance.OnMelee;
                @Melee.performed += instance.OnMelee;
                @Melee.canceled += instance.OnMelee;
            }
        }
    }
    public PlayerGamepadActions @PlayerGamepad => new PlayerGamepadActions(this);

    // Player (KVM)
    private readonly InputActionMap m_PlayerKVM;
    private IPlayerKVMActions m_PlayerKVMActionsCallbackInterface;
    private readonly InputAction m_PlayerKVM_Movement;
    private readonly InputAction m_PlayerKVM_Jump;
    private readonly InputAction m_PlayerKVM_Aim;
    private readonly InputAction m_PlayerKVM_Melee;
    public struct PlayerKVMActions
    {
        private @InputActions m_Wrapper;
        public PlayerKVMActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_PlayerKVM_Movement;
        public InputAction @Jump => m_Wrapper.m_PlayerKVM_Jump;
        public InputAction @Aim => m_Wrapper.m_PlayerKVM_Aim;
        public InputAction @Melee => m_Wrapper.m_PlayerKVM_Melee;
        public InputActionMap Get() { return m_Wrapper.m_PlayerKVM; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerKVMActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerKVMActions instance)
        {
            if (m_Wrapper.m_PlayerKVMActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_PlayerKVMActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PlayerKVMActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PlayerKVMActionsCallbackInterface.OnMovement;
                @Jump.started -= m_Wrapper.m_PlayerKVMActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerKVMActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerKVMActionsCallbackInterface.OnJump;
                @Aim.started -= m_Wrapper.m_PlayerKVMActionsCallbackInterface.OnAim;
                @Aim.performed -= m_Wrapper.m_PlayerKVMActionsCallbackInterface.OnAim;
                @Aim.canceled -= m_Wrapper.m_PlayerKVMActionsCallbackInterface.OnAim;
                @Melee.started -= m_Wrapper.m_PlayerKVMActionsCallbackInterface.OnMelee;
                @Melee.performed -= m_Wrapper.m_PlayerKVMActionsCallbackInterface.OnMelee;
                @Melee.canceled -= m_Wrapper.m_PlayerKVMActionsCallbackInterface.OnMelee;
            }
            m_Wrapper.m_PlayerKVMActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Aim.started += instance.OnAim;
                @Aim.performed += instance.OnAim;
                @Aim.canceled += instance.OnAim;
                @Melee.started += instance.OnMelee;
                @Melee.performed += instance.OnMelee;
                @Melee.canceled += instance.OnMelee;
            }
        }
    }
    public PlayerKVMActions @PlayerKVM => new PlayerKVMActions(this);
    public interface IPlayerGamepadActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnAim(InputAction.CallbackContext context);
        void OnMelee(InputAction.CallbackContext context);
    }
    public interface IPlayerKVMActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnAim(InputAction.CallbackContext context);
        void OnMelee(InputAction.CallbackContext context);
    }
}
