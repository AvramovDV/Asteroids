//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Scripts/InputSystem/AsteroidsControl.inputactions
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

namespace Avramov.Asteroids
{
    public partial class @AsteroidsControl: IInputActionCollection2, IDisposable
    {
        public InputActionAsset asset { get; }
        public @AsteroidsControl()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""AsteroidsControl"",
    ""maps"": [
        {
            ""name"": ""DefaultActionMap"",
            ""id"": ""38ece441-8c25-4c0e-8863-89063b8cc8fa"",
            ""actions"": [
                {
                    ""name"": ""Rotation"",
                    ""type"": ""Value"",
                    ""id"": ""cf471fae-3c72-49f7-861b-c783e77439be"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Acceleration"",
                    ""type"": ""Button"",
                    ""id"": ""eabe8352-5aee-4f61-9b04-ccb339f97ae6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""FireBullet"",
                    ""type"": ""Button"",
                    ""id"": ""850470e0-574e-4a3d-acc1-85b09b885412"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""FireLaser"",
                    ""type"": ""Button"",
                    ""id"": ""7047db57-9e27-46db-a2d0-6b1b1aae7a80"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Horizontal"",
                    ""id"": ""77fefa85-3259-4151-ac2a-03779bee29b4"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotation"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""736daa8d-842b-480c-85d3-0ccd11a5580a"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""9cce6ffd-fd88-4b63-aaf3-2aeaad1058fb"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""44cf6977-e05d-47a5-8739-0fe355cb7b5e"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Acceleration"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""659ddb54-eb4d-4b11-81cd-cd87a937dde7"",
                    ""path"": ""<Keyboard>/leftCtrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FireBullet"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7cec8731-5c69-4996-a6cd-efe0f254e85e"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FireLaser"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // DefaultActionMap
            m_DefaultActionMap = asset.FindActionMap("DefaultActionMap", throwIfNotFound: true);
            m_DefaultActionMap_Rotation = m_DefaultActionMap.FindAction("Rotation", throwIfNotFound: true);
            m_DefaultActionMap_Acceleration = m_DefaultActionMap.FindAction("Acceleration", throwIfNotFound: true);
            m_DefaultActionMap_FireBullet = m_DefaultActionMap.FindAction("FireBullet", throwIfNotFound: true);
            m_DefaultActionMap_FireLaser = m_DefaultActionMap.FindAction("FireLaser", throwIfNotFound: true);
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

        // DefaultActionMap
        private readonly InputActionMap m_DefaultActionMap;
        private List<IDefaultActionMapActions> m_DefaultActionMapActionsCallbackInterfaces = new List<IDefaultActionMapActions>();
        private readonly InputAction m_DefaultActionMap_Rotation;
        private readonly InputAction m_DefaultActionMap_Acceleration;
        private readonly InputAction m_DefaultActionMap_FireBullet;
        private readonly InputAction m_DefaultActionMap_FireLaser;
        public struct DefaultActionMapActions
        {
            private @AsteroidsControl m_Wrapper;
            public DefaultActionMapActions(@AsteroidsControl wrapper) { m_Wrapper = wrapper; }
            public InputAction @Rotation => m_Wrapper.m_DefaultActionMap_Rotation;
            public InputAction @Acceleration => m_Wrapper.m_DefaultActionMap_Acceleration;
            public InputAction @FireBullet => m_Wrapper.m_DefaultActionMap_FireBullet;
            public InputAction @FireLaser => m_Wrapper.m_DefaultActionMap_FireLaser;
            public InputActionMap Get() { return m_Wrapper.m_DefaultActionMap; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(DefaultActionMapActions set) { return set.Get(); }
            public void AddCallbacks(IDefaultActionMapActions instance)
            {
                if (instance == null || m_Wrapper.m_DefaultActionMapActionsCallbackInterfaces.Contains(instance)) return;
                m_Wrapper.m_DefaultActionMapActionsCallbackInterfaces.Add(instance);
                @Rotation.started += instance.OnRotation;
                @Rotation.performed += instance.OnRotation;
                @Rotation.canceled += instance.OnRotation;
                @Acceleration.started += instance.OnAcceleration;
                @Acceleration.performed += instance.OnAcceleration;
                @Acceleration.canceled += instance.OnAcceleration;
                @FireBullet.started += instance.OnFireBullet;
                @FireBullet.performed += instance.OnFireBullet;
                @FireBullet.canceled += instance.OnFireBullet;
                @FireLaser.started += instance.OnFireLaser;
                @FireLaser.performed += instance.OnFireLaser;
                @FireLaser.canceled += instance.OnFireLaser;
            }

            private void UnregisterCallbacks(IDefaultActionMapActions instance)
            {
                @Rotation.started -= instance.OnRotation;
                @Rotation.performed -= instance.OnRotation;
                @Rotation.canceled -= instance.OnRotation;
                @Acceleration.started -= instance.OnAcceleration;
                @Acceleration.performed -= instance.OnAcceleration;
                @Acceleration.canceled -= instance.OnAcceleration;
                @FireBullet.started -= instance.OnFireBullet;
                @FireBullet.performed -= instance.OnFireBullet;
                @FireBullet.canceled -= instance.OnFireBullet;
                @FireLaser.started -= instance.OnFireLaser;
                @FireLaser.performed -= instance.OnFireLaser;
                @FireLaser.canceled -= instance.OnFireLaser;
            }

            public void RemoveCallbacks(IDefaultActionMapActions instance)
            {
                if (m_Wrapper.m_DefaultActionMapActionsCallbackInterfaces.Remove(instance))
                    UnregisterCallbacks(instance);
            }

            public void SetCallbacks(IDefaultActionMapActions instance)
            {
                foreach (var item in m_Wrapper.m_DefaultActionMapActionsCallbackInterfaces)
                    UnregisterCallbacks(item);
                m_Wrapper.m_DefaultActionMapActionsCallbackInterfaces.Clear();
                AddCallbacks(instance);
            }
        }
        public DefaultActionMapActions @DefaultActionMap => new DefaultActionMapActions(this);
        public interface IDefaultActionMapActions
        {
            void OnRotation(InputAction.CallbackContext context);
            void OnAcceleration(InputAction.CallbackContext context);
            void OnFireBullet(InputAction.CallbackContext context);
            void OnFireLaser(InputAction.CallbackContext context);
        }
    }
}
