﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace DevDiv_SnapView.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            SizeChanged += MainView_SizeChanged;
        }

        void MainView_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (ApplicationView.Value == ApplicationViewState.Filled)
            {
                MainFrame.Navigate(typeof(FillView));
            }
            else if (ApplicationView.Value == ApplicationViewState.Snapped)
            {
                MainFrame.Navigate(typeof(SnapView));
            }
            else if (ApplicationView.Value == ApplicationViewState.FullScreenLandscape)
            {
                MainFrame.Navigate(typeof(FullView));
            }
            else if (ApplicationView.Value == ApplicationViewState.FullScreenPortrait)
            {
            }
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }
    }
}
