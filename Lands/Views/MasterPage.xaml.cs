﻿namespace Lands.Views
{
    using System;
    using System.Collections.Generic;

    using Xamarin.Forms;

    public partial class MasterPage : MasterDetailPage
    {
        public MasterPage()
        {
            InitializeComponent();
            App.Navigator = Navigator;
        }
    }
}
