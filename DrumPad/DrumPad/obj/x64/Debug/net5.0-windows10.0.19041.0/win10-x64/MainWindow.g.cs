#pragma checksum "C:\Users\Jingweizh\Desktop\GitDrumPad\DrumPad\DrumPad\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "CD54EF5B9321ADE208D074C2B8432325DD574F9D0CF0E546A50A5A0A44938753"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DrumPad
{
    partial class MainWindow : 
        global::Microsoft.UI.Xaml.Window, 
        global::Microsoft.UI.Xaml.Markup.IComponentConnector
    {

        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 1.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // MainWindow.xaml line 42
                {
                    this.Control1 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Grid>(target);
                }
                break;
            case 3: // MainWindow.xaml line 70
                {
                    global::Microsoft.UI.Xaml.Controls.Button element3 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Button>(target);
                    ((global::Microsoft.UI.Xaml.Controls.Button)element3).Click += this.pad_clicked;
                }
                break;
            case 4: // MainWindow.xaml line 34
                {
                    this.dark_switch = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.ToggleSwitch>(target);
                    ((global::Microsoft.UI.Xaml.Controls.ToggleSwitch)this.dark_switch).Toggled += this.ToggleSwitch_Toggled;
                    ((global::Microsoft.UI.Xaml.Controls.ToggleSwitch)this.dark_switch).Loaded += this.ToggleSwitch_Loaded;
                }
                break;
            case 5: // MainWindow.xaml line 27
                {
                    global::Microsoft.UI.Xaml.Controls.MenuFlyoutItem element5 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.MenuFlyoutItem>(target);
                    ((global::Microsoft.UI.Xaml.Controls.MenuFlyoutItem)element5).Click += this.SwtichPresenter_Default;
                }
                break;
            case 6: // MainWindow.xaml line 28
                {
                    global::Microsoft.UI.Xaml.Controls.MenuFlyoutItem element6 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.MenuFlyoutItem>(target);
                    ((global::Microsoft.UI.Xaml.Controls.MenuFlyoutItem)element6).Click += this.SwtichPresenter_CompOverlay;
                }
                break;
            case 7: // MainWindow.xaml line 29
                {
                    global::Microsoft.UI.Xaml.Controls.MenuFlyoutItem element7 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.MenuFlyoutItem>(target);
                    ((global::Microsoft.UI.Xaml.Controls.MenuFlyoutItem)element7).Click += this.SwtichPresenter_Fullscreen;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 1.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Microsoft.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Microsoft.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

