﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Surface;
using Microsoft.Surface.Presentation;
using Microsoft.Surface.Presentation.Controls;

namespace PagesLivre.Book
{
    /// <summary>
    /// Interaction logic for imgFNAIM.xaml
    /// </summary>
    public partial class imgFNAIM : SurfaceUserControl
    {
        public bool ShowTitre
        {
            get { return this.titre.Visibility == Visibility.Visible; }
            set
            {
                if (value) { this.titre.Visibility = Visibility.Visible; }
                else { this.titre.Visibility = Visibility.Hidden; }
            }
        }

        public imgFNAIM()
        {
            InitializeComponent();
        }
    }
}
