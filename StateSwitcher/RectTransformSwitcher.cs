using System.Collections.Generic;
using UnityEngine;

namespace UIStateSwitcher
{
    public class RectTransformSwitcher : SwitchableElement
    {
        [SerializeField] private RectTransform targetRect;
        [SerializeField] private List<SwitchableRectTransform> switchableRects;
        
        public override void Switch(string state)
        {
            var rect = switchableRects.Find(r => r.Key.Equals(state))?.Value;
            if (rect != null)
            {
                targetRect.anchoredPosition = rect.AnchoredPosition;
                targetRect.sizeDelta = rect.SizeDelta;
            }
        }
    }
}
