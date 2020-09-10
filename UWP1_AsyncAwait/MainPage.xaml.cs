using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UWP1_AsyncAwait
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void SyncButton_Click(object sender, RoutedEventArgs e)
        {
            ExecutionResult.Text = "";
            TimeResult.Text = "";
            var watch = Stopwatch.StartNew();

            RunExample(10);

            watch.Stop();
            TimeResult.Text = watch.ElapsedMilliseconds.ToString();
        }

        private async void ASyncButton_Click(object sender, RoutedEventArgs e)
        {
            ExecutionResult.Text = "";
            TimeResult.Text = "";
            var watch = Stopwatch.StartNew();

            await RunExampleAsync(10);

            watch.Stop();
            TimeResult.Text = watch.ElapsedMilliseconds.ToString();
        }



        private void RunExample(int seconds)
        {
            for (var i = 0; i < seconds; i++)
                ExecutionResult.Text += DoWork(i);

            ExecutionResult.Text += "Completed";
        }

        private async Task RunExampleAsync(int seconds)
        {
            for (var i = 0; i < seconds; i++)
                ExecutionResult.Text += await Task.Run(() => DoWork(i));

            ExecutionResult.Text += "Completed";
        }



        private string DoWork(int i)
        {
            Thread.Sleep(1000);
            return $"loop #{i + 1} {Environment.NewLine}";
        }

    }
}