using System;
using Xamarin.Forms;

namespace DevTalksBlazorNative
{
    public static class Styles
    {
        public static readonly Color PrimaryColor = Color.FromHex("#7d34eb");
        public static readonly Color PrimaryTextColor = Color.White;

        public static void ApplyButtonStyles(this Microsoft.MobileBlazorBindings.Elements.Button button)
        {
            var nativeButton = button.NativeControl;
            nativeButton.BackgroundColor = PrimaryColor;
            nativeButton.TextColor = PrimaryTextColor;
            nativeButton.FontAttributes = FontAttributes.Bold;
        }

        public static void ApplyCheckBoxStyle(this Microsoft.MobileBlazorBindings.Elements.CheckBox checkBox)
        {
            var nativeCheckBox = checkBox.NativeControl;
            nativeCheckBox.Color = PrimaryColor;
        }
    }
}
