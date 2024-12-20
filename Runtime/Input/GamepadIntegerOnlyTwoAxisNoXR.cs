//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/P/2024_04_07_PushGenericAsIntegerDate/Runtime/Input/GamepadIntegerOnlyTwoAxisNoXR.inputactions
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

namespace GenericInputIID
{
    public partial class @GamepadIntegerOnlyTwoAxisNoXR: IInputActionCollection2, IDisposable
    {
        public InputActionAsset asset { get; }
        public @GamepadIntegerOnlyTwoAxisNoXR()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""GamepadIntegerOnlyTwoAxisNoXR"",
    ""maps"": [
        {
            ""name"": ""GamepadTwoJoystick"",
            ""id"": ""81a4ca18-3d54-46e4-ac82-d65acdb1307c"",
            ""actions"": [
                {
                    ""name"": ""LeftJoystickHorizontal"",
                    ""type"": ""Value"",
                    ""id"": ""c8f2718c-985e-41b8-8f90-67908014e30e"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""LeftJoystickVertical"",
                    ""type"": ""Value"",
                    ""id"": ""0a87cbcb-176d-4206-b9ab-cc67577e6e93"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""RightJoystickHorizontal"",
                    ""type"": ""Value"",
                    ""id"": ""ccdc52a0-f0d3-4e88-82e0-43fa57b3688a"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""RightJoystickVertical"",
                    ""type"": ""Value"",
                    ""id"": ""254440a5-eabf-47e6-b15f-2e02d2e2242d"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""FireBullet"",
                    ""type"": ""Button"",
                    ""id"": ""5f13c674-f960-462f-b0d5-20f9b6e811e6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""a03d400d-5ee6-493d-878c-7d1a8bdcdbd1"",
                    ""path"": ""<Gamepad>/leftStick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftJoystickHorizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""5aada760-ae57-4c3b-ada0-6de5e73d85c1"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftJoystickHorizontal"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""9f276355-813d-495f-808c-8277760eeeeb"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftJoystickHorizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""0aab1ee6-c8b4-4408-b75a-a931ec577635"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftJoystickHorizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""22ba7532-e420-4554-80f9-1a0f5142e24e"",
                    ""path"": ""<Gamepad>/leftStick/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftJoystickVertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""8ee72226-466a-49f6-8a9d-35f24522146c"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftJoystickVertical"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""1c5a76ae-2b8a-4359-a827-2b03a0843ca6"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftJoystickVertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""ceec6a7b-8e09-486a-83cf-04a1fa24c5db"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftJoystickVertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""7049e989-12ee-426f-b1d9-ce67b9660af9"",
                    ""path"": ""<Gamepad>/rightStick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightJoystickHorizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""8aa9b92c-e4cb-4138-a772-73b1eb3fa8fa"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightJoystickHorizontal"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""4684e558-7ec8-4095-84f0-bd8533a71a26"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightJoystickHorizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""a0c9dc43-69b7-4b22-b8ba-e5f44eccd0b1"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightJoystickHorizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""8be2cd18-04ad-46a5-9274-9ebb189f427b"",
                    ""path"": ""<Gamepad>/rightStick/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightJoystickVertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""82f9d6d2-d667-4002-820b-529a85c0a3ab"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightJoystickVertical"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""0b615712-26a4-4567-9a14-48b78a211781"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightJoystickVertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""243ead81-4ff1-405e-9507-36af56750b9c"",
                    ""path"": ""<Keyboard>/4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightJoystickVertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""3a20c89e-5bf2-4cbd-bbf8-034bcd62d930"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FireBullet"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5ce179a6-e859-4bfd-8fcd-3922a358df78"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FireBullet"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7a898f33-6102-45c9-bc50-5e64c2007784"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FireBullet"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b61c7dd0-37fe-46ea-ad3b-4323d23f4a7d"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FireBullet"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""522148be-af3f-4367-a7b3-6b4d3de6a602"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FireBullet"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // GamepadTwoJoystick
            m_GamepadTwoJoystick = asset.FindActionMap("GamepadTwoJoystick", throwIfNotFound: true);
            m_GamepadTwoJoystick_LeftJoystickHorizontal = m_GamepadTwoJoystick.FindAction("LeftJoystickHorizontal", throwIfNotFound: true);
            m_GamepadTwoJoystick_LeftJoystickVertical = m_GamepadTwoJoystick.FindAction("LeftJoystickVertical", throwIfNotFound: true);
            m_GamepadTwoJoystick_RightJoystickHorizontal = m_GamepadTwoJoystick.FindAction("RightJoystickHorizontal", throwIfNotFound: true);
            m_GamepadTwoJoystick_RightJoystickVertical = m_GamepadTwoJoystick.FindAction("RightJoystickVertical", throwIfNotFound: true);
            m_GamepadTwoJoystick_FireBullet = m_GamepadTwoJoystick.FindAction("FireBullet", throwIfNotFound: true);
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

        // GamepadTwoJoystick
        private readonly InputActionMap m_GamepadTwoJoystick;
        private List<IGamepadTwoJoystickActions> m_GamepadTwoJoystickActionsCallbackInterfaces = new List<IGamepadTwoJoystickActions>();
        private readonly InputAction m_GamepadTwoJoystick_LeftJoystickHorizontal;
        private readonly InputAction m_GamepadTwoJoystick_LeftJoystickVertical;
        private readonly InputAction m_GamepadTwoJoystick_RightJoystickHorizontal;
        private readonly InputAction m_GamepadTwoJoystick_RightJoystickVertical;
        private readonly InputAction m_GamepadTwoJoystick_FireBullet;
        public struct GamepadTwoJoystickActions
        {
            private @GamepadIntegerOnlyTwoAxisNoXR m_Wrapper;
            public GamepadTwoJoystickActions(@GamepadIntegerOnlyTwoAxisNoXR wrapper) { m_Wrapper = wrapper; }
            public InputAction @LeftJoystickHorizontal => m_Wrapper.m_GamepadTwoJoystick_LeftJoystickHorizontal;
            public InputAction @LeftJoystickVertical => m_Wrapper.m_GamepadTwoJoystick_LeftJoystickVertical;
            public InputAction @RightJoystickHorizontal => m_Wrapper.m_GamepadTwoJoystick_RightJoystickHorizontal;
            public InputAction @RightJoystickVertical => m_Wrapper.m_GamepadTwoJoystick_RightJoystickVertical;
            public InputAction @FireBullet => m_Wrapper.m_GamepadTwoJoystick_FireBullet;
            public InputActionMap Get() { return m_Wrapper.m_GamepadTwoJoystick; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(GamepadTwoJoystickActions set) { return set.Get(); }
            public void AddCallbacks(IGamepadTwoJoystickActions instance)
            {
                if (instance == null || m_Wrapper.m_GamepadTwoJoystickActionsCallbackInterfaces.Contains(instance)) return;
                m_Wrapper.m_GamepadTwoJoystickActionsCallbackInterfaces.Add(instance);
                @LeftJoystickHorizontal.started += instance.OnLeftJoystickHorizontal;
                @LeftJoystickHorizontal.performed += instance.OnLeftJoystickHorizontal;
                @LeftJoystickHorizontal.canceled += instance.OnLeftJoystickHorizontal;
                @LeftJoystickVertical.started += instance.OnLeftJoystickVertical;
                @LeftJoystickVertical.performed += instance.OnLeftJoystickVertical;
                @LeftJoystickVertical.canceled += instance.OnLeftJoystickVertical;
                @RightJoystickHorizontal.started += instance.OnRightJoystickHorizontal;
                @RightJoystickHorizontal.performed += instance.OnRightJoystickHorizontal;
                @RightJoystickHorizontal.canceled += instance.OnRightJoystickHorizontal;
                @RightJoystickVertical.started += instance.OnRightJoystickVertical;
                @RightJoystickVertical.performed += instance.OnRightJoystickVertical;
                @RightJoystickVertical.canceled += instance.OnRightJoystickVertical;
                @FireBullet.started += instance.OnFireBullet;
                @FireBullet.performed += instance.OnFireBullet;
                @FireBullet.canceled += instance.OnFireBullet;
            }

            private void UnregisterCallbacks(IGamepadTwoJoystickActions instance)
            {
                @LeftJoystickHorizontal.started -= instance.OnLeftJoystickHorizontal;
                @LeftJoystickHorizontal.performed -= instance.OnLeftJoystickHorizontal;
                @LeftJoystickHorizontal.canceled -= instance.OnLeftJoystickHorizontal;
                @LeftJoystickVertical.started -= instance.OnLeftJoystickVertical;
                @LeftJoystickVertical.performed -= instance.OnLeftJoystickVertical;
                @LeftJoystickVertical.canceled -= instance.OnLeftJoystickVertical;
                @RightJoystickHorizontal.started -= instance.OnRightJoystickHorizontal;
                @RightJoystickHorizontal.performed -= instance.OnRightJoystickHorizontal;
                @RightJoystickHorizontal.canceled -= instance.OnRightJoystickHorizontal;
                @RightJoystickVertical.started -= instance.OnRightJoystickVertical;
                @RightJoystickVertical.performed -= instance.OnRightJoystickVertical;
                @RightJoystickVertical.canceled -= instance.OnRightJoystickVertical;
                @FireBullet.started -= instance.OnFireBullet;
                @FireBullet.performed -= instance.OnFireBullet;
                @FireBullet.canceled -= instance.OnFireBullet;
            }

            public void RemoveCallbacks(IGamepadTwoJoystickActions instance)
            {
                if (m_Wrapper.m_GamepadTwoJoystickActionsCallbackInterfaces.Remove(instance))
                    UnregisterCallbacks(instance);
            }

            public void SetCallbacks(IGamepadTwoJoystickActions instance)
            {
                foreach (var item in m_Wrapper.m_GamepadTwoJoystickActionsCallbackInterfaces)
                    UnregisterCallbacks(item);
                m_Wrapper.m_GamepadTwoJoystickActionsCallbackInterfaces.Clear();
                AddCallbacks(instance);
            }
        }
        public GamepadTwoJoystickActions @GamepadTwoJoystick => new GamepadTwoJoystickActions(this);
        public interface IGamepadTwoJoystickActions
        {
            void OnLeftJoystickHorizontal(InputAction.CallbackContext context);
            void OnLeftJoystickVertical(InputAction.CallbackContext context);
            void OnRightJoystickHorizontal(InputAction.CallbackContext context);
            void OnRightJoystickVertical(InputAction.CallbackContext context);
            void OnFireBullet(InputAction.CallbackContext context);
        }
    }
}
