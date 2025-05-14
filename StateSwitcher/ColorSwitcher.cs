using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace UIStateSwitcher
{
    public class ColorSwitcher : SwitchableElement
    {
        [SerializeField] protected Graphic targetGraphic;
        [SerializeField] protected List<SwitchableColor> switchableColors;
        
        public override void Switch(string state)
        {
            var colorKey = switchableColors.Find(t => t.Key.Equals(state));
            if(colorKey != null)
                targetGraphic.color = colorKey.Value;
        }
    }
}