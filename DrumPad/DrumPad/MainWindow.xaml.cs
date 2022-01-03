using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

using System.Media; // to play sounds

using WinRT;
// Needed for WindowId
using Microsoft.UI;
// Needed for AppWindow
using Microsoft.UI.Windowing;
// Needed for XAML hwnd interop
using WinRT.Interop;
using Windows.Storage;


// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace DrumPad
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {

        AppWindow m_appWindow;

        public MainWindow()
        {
            this.InitializeComponent();
            m_appWindow = GetAppWindowForCurrentWindow();
        }

        private void pad_clicked(object sender, RoutedEventArgs e)
        {
            // This gives you the installed location path
            var installedPath = Windows.ApplicationModel.Package.Current.InstalledLocation.Path;

            // Final path to the sound file
            var soundFile = Path.Join(installedPath, "Assets", "rim.wav");

            SoundPlayer player = new System.Media.SoundPlayer(soundFile);
            player.Play();
        }

        private AppWindow GetAppWindowForCurrentWindow()
        {
            IntPtr hWnd = WinRT.Interop.WindowNative.GetWindowHandle(this);
            WindowId myWndId = Microsoft.UI.Win32Interop.GetWindowIdFromWindow(hWnd);
            return AppWindow.GetFromWindowId(myWndId);
        }

        private void SwitchPresenter(object sender, RoutedEventArgs e)
        {

            m_appWindow.SetPresenter(AppWindowPresenterKind.CompactOverlay);

        }

        private void SwitchPresenterDefault(object sender, RoutedEventArgs e)
        {

            m_appWindow.SetPresenter(AppWindowPresenterKind.Default);

        }

        private void SwitchPresenterFullScreen(object sender, RoutedEventArgs e)
        {

            m_appWindow.SetPresenter(AppWindowPresenterKind.FullScreen);

        }

        private void SwitchPresenter_Updated(object sender, RoutedEventArgs e)
        {
            // Bail out if we don't have an AppWindow object.
            if (m_appWindow != null)
            {

                AppWindowPresenterKind newPresenterKind;
                switch (sender.As<MenuFlyoutItem>().Name)
                {
                    case "CompactoverlaytBtn":
                        newPresenterKind = AppWindowPresenterKind.CompactOverlay;
                        break;

                    case "FullscreenBtn":
                        newPresenterKind = AppWindowPresenterKind.FullScreen;
                        break;

                    case "OverlappedBtn":
                        newPresenterKind = AppWindowPresenterKind.Overlapped;
                        break;

                    default:
                        newPresenterKind = AppWindowPresenterKind.Default;
                        break;
                }

                // If the same presenter button was pressed as the mode we're in, toggle the window back to Default.
                if (newPresenterKind == m_appWindow.Presenter.Kind)
                {
                    m_appWindow.SetPresenter(AppWindowPresenterKind.Default);
                }
                else
                {
                    // else request a presenter of the selected kind to be created and applied to the window.
                    m_appWindow.SetPresenter(newPresenterKind);
                }
            }
        }

        private void ToggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            ToggleSwitch toggleSwitch = sender as ToggleSwitch;
            if (toggleSwitch != null)
            {
                if (toggleSwitch.IsOn == true)
                {
                    if (this.Content is FrameworkElement frameworkElement)
                    {
                        frameworkElement.RequestedTheme = ElementTheme.Dark;
                    }
                }
                else
                {
                    if (this.Content is FrameworkElement frameworkElement)
                    {
                        frameworkElement.RequestedTheme = ElementTheme.Light;
                    }
                }
            }

            ApplicationData.Current.LocalSettings.Values["themeSetting"] =
                                                     ((ToggleSwitch)sender).IsOn ? 0 : 1;
        }

        private void ToggleSwitch_Loaded(object sender, RoutedEventArgs e)
        {
            if (ApplicationData.Current.LocalSettings.Values.TryGetValue("themeSetting", out object themeSetting) && (int)themeSetting == 0)
            {
                dark_switch.IsOn = true;
            } else
            {
                dark_switch.IsOn = false;
            }
        }
    }
}


