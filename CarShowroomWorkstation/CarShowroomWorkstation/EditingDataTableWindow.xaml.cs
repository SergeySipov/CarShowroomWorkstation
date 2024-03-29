﻿using CarShowroomWorkstation.MVVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CarShowroomWorkstation
{
    /// <summary>
    /// Interaction logic for EditingDataTableWindow.xaml
    /// </summary>
    public partial class EditingDataTableWindow : Window
    {
        public EditingDataTableWindow()
        {
            InitializeComponent();
            EditingDataTableViewModel tableViewModel = new EditingDataTableViewModel();
            DataContext = tableViewModel;
            if (tableViewModel.CloseAction == null)
                tableViewModel.CloseAction = new Action(this.Close);
        }
    }
}
