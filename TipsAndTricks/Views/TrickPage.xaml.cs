using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TipsAndTricks.Views
{
    public partial class TrickPage : ContentPage
    {
        public TrickPage()
        {
            InitializeComponent();
            BindingContext = new TrickPage();
        }
    }
}
