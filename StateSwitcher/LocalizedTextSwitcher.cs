namespace UIStateSwitcher
{
    public class LocalizedTextSwitcher : TextSwitcher
    {
        public override void Switch(string state)
        {
            base.Switch(state);
            textElement.text = textElement.text.Localized();
        }
    }
}