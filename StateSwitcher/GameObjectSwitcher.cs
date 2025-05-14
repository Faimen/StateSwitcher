using System;
using System.Collections.Generic;
using UnityEngine;
using Utils;

namespace UIStateSwitcher
{
    public class GameObjectSwitcher : SwitchableElement
    {
        [Tooltip("GameObject'ы, которые будут включаться и выключаться.")]
        [SerializeField] private List<GameObject> _targetGameObjects;
        [Tooltip("Ключи состояний и значения для активации целевых GameObject'ов в этих состояниях.")]
        [SerializeField] private List<SwitchableGameObject> _stateSettings;

        public override void Switch(string stateKey)
        {
            var stateSettings = _stateSettings.Find(s => s.Key.Equals(stateKey))?.Value;
            if (!stateSettings.HasValue) return;
            
            foreach(var targetGameObject in _targetGameObjects)
            {
                targetGameObject.SetActive(stateSettings.Value);
            }
        }
    }

    [Serializable]
    public class SwitchableGameObject : SerializableKeyValuePair<string, bool>
    {
    }
}