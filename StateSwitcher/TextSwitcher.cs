using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace UIStateSwitcher
{
    public class TextSwitcher : SwitchableElement
    {
        [SerializeField] protected TextMeshProUGUI textElement;
        [SerializeField] protected List<SwitchableText> switchableTexts;

        public override void Switch(string state)
        {
            textElement.text = switchableTexts.Find(t => t.Key.Equals(state))?.Value;
        }
    }
}