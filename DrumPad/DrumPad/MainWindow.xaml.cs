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

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace DrumPad
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
        }

        private void pad_clicked(object sender, RoutedEventArgs e)
        {

            var installedPath = Windows.ApplicationModel.Package.Current.InstalledLocation.Path;
            var soundFile = Path.Join(installedPath, "Assets", "rim.wav");

            SoundPlayer player = new System.Media.SoundPlayer(soundFile);
            player.Play();
        }

        private void pad2_clicked(object sender, RoutedEventArgs e)
        {

            var installedPath = Windows.ApplicationModel.Package.Current.InstalledLocation.Path;
            var soundFile = Path.Join(installedPath, "Assets", "crash.wav");

            SoundPlayer player = new System.Media.SoundPlayer(soundFile);
            player.Play();
        }

        private void pad3_clicked(object sender, RoutedEventArgs e)
        {

            var installedPath = Windows.ApplicationModel.Package.Current.InstalledLocation.Path;
            var soundFile = Path.Join(installedPath, "Assets", "elec1.wav");

            SoundPlayer player = new System.Media.SoundPlayer(soundFile);
            player.Play();
        }

        private void pad4_clicked(object sender, RoutedEventArgs e)
        {

            var installedPath = Windows.ApplicationModel.Package.Current.InstalledLocation.Path;
            var soundFile = Path.Join(installedPath, "Assets", "high_snare.wav");

            SoundPlayer player = new System.Media.SoundPlayer(soundFile);
            player.Play();
        }

        private void pad5_clicked(object sender, RoutedEventArgs e)
        {

            var installedPath = Windows.ApplicationModel.Package.Current.InstalledLocation.Path;
            var soundFile = Path.Join(installedPath, "Assets", "high_snare2.wav");

            SoundPlayer player = new System.Media.SoundPlayer(soundFile);
            player.Play();
        }

        private void pad6_clicked(object sender, RoutedEventArgs e)
        {

            var installedPath = Windows.ApplicationModel.Package.Current.InstalledLocation.Path;
            var soundFile = Path.Join(installedPath, "Assets", "kick.wav");

            SoundPlayer player = new System.Media.SoundPlayer(soundFile);
            player.Play();
        }

        private void pad7_clicked(object sender, RoutedEventArgs e)
        {

            var installedPath = Windows.ApplicationModel.Package.Current.InstalledLocation.Path;
            var soundFile = Path.Join(installedPath, "Assets", "trash.wav");

            SoundPlayer player = new System.Media.SoundPlayer(soundFile);
            player.Play();
        }

        private void pad8_clicked(object sender, RoutedEventArgs e)
        {

            var installedPath = Windows.ApplicationModel.Package.Current.InstalledLocation.Path;
            var soundFile = Path.Join(installedPath, "Assets", "snare.wav");

            SoundPlayer player = new System.Media.SoundPlayer(soundFile);
            player.Play();
        }

        private void pad9_clicked(object sender, RoutedEventArgs e)
        {

            var installedPath = Windows.ApplicationModel.Package.Current.InstalledLocation.Path;
            var soundFile = Path.Join(installedPath, "Assets", "tom.wav");

            SoundPlayer player = new System.Media.SoundPlayer(soundFile);
            player.Play();
        }



    }
}
