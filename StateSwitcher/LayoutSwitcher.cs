using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace UIStateSwitcher
{
    public class LayoutSwitcher : SwitchableElement
    {
        [SerializeField] private HorizontalOrVerticalLayoutGroup layoutGroup;
        [SerializeField] private List<SwitchableLayoutSettings> switchableSettings;

        public override void Switch(string state)
        {
            var settings = switchableSettings.Find(s => s.Key.Equals(state))?.Value;
            if (settings != null)
            {
                layoutGroup.padding = settings.padding;
                layoutGroup.spacing = settings.spacing;
                layoutGroup.childAlignment = settings.childAlignment;
                layoutGroup.reverseArrangement = settings.reversAlignment;
            }
        }
    }
}