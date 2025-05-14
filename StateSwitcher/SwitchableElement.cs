using UnityEngine;

namespace UIStateSwitcher
{
    public abstract class SwitchableElement : MonoBehaviour
    {
        public abstract void Switch(string state);
    }
}