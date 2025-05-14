using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UIStateSwitcher
{
    public class EnabledSwitcher : SwitchableElement
    {
        [SerializeField] private List<MonoBehaviour> targetElements;
        [SerializeField] private List<SwitchableEnabled> switchableList;

        public override void Switch(string state)
        {
            var value = switchableList.Find(s => s.Key.Equals(state))?.Value;
            if (value.HasValue)
                targetElements.ForEach(e => e.enabled = value.Value);
        }
    }
}