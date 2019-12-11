﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace CarShowroomWorkstation.MVVM
{
    class CloseOrderViewModel : INotifyPropertyChanged
    {
        private CarShowroomEntities _carShowroomEntities = new CarShowroomEntities();

        private Orders selectedOrder;
        private string dateTextChanged;

        public ObservableCollection<Orders> Orders { get; set; }

        public ICommand AddCmd => new RelayCommand(o => SwitchOrderState((Collection<object>)o));
        public Action CloseAction { get; set; }

        private void SwitchOrderState(Collection<object> o)
        {
            foreach (var item in o.Cast<Orders>())
            {//TODO исправить ошибку со временем
                Orders order = _carShowroomEntities.Orders.First(x => x.ID_order.Equals(item.ID_order));
                order.IsCompleted = 1;
                order.DateOrderClosing = DateTime.Now;
                MessageBox.Show((order.DateOrderClosing.Value.AddHours(order.DateOfIssue.Hour)).ToString());
                order.LeadTime = TimeSpan.FromMinutes((order.DateOrderClosing - order.DateOfIssue).Value.TotalMinutes);
                foreach (var car in order.Cars)
                {
                    car.IsSold = 1;
                } 
            }
            _carShowroomEntities.SaveChanges();
            CloseAction();
        }

        public string DateTextChanged
        {
            get { return this.dateTextChanged; }
            set
            {
                if (this.dateTextChanged != value)
                {
                    this.dateTextChanged = value;
                    ObservableCollection<Orders> collection = new ObservableCollection<Orders>();
                    foreach (var item in _carShowroomEntities.Orders)
                    {
                        if (item.IsCompleted.Equals(0) && item.DateOfIssue.ToString("MM/dd/yyyy").Replace('.', '/').Contains(dateTextChanged))
                        {
                            collection.Add(item);
                        }
                    }
                    this.Orders = collection;
                    OnPropertyChanged("DateTextChanged");
                    OnPropertyChanged("Orders");
                }
            }
        }

        public Orders SelectedOrder
        {
            get { return selectedOrder; }
            set
            {
                selectedOrder = value;
                OnPropertyChanged("SelectedOrder");
            }
        }

        public CloseOrderViewModel()
        {
            Orders = new ObservableCollection<Orders>();

            foreach (var item in _carShowroomEntities.Orders)
                if (item.IsCompleted.Equals(0))
                    Orders.Add(item);
            try
            {
                selectedOrder = Orders.First();
            }
            catch
            {
                MessageBox.Show($"Нет открытых заказов", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
