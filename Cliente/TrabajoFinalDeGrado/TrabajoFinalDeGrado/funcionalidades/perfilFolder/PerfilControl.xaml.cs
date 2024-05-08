﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using TrabajoFinalDeGrado.DAOS;

namespace TrabajoFinalDeGrado.funcionalidades.perfilFolder
{
    /// <summary>
    /// Lógica de interacción para PerfilControl.xaml
    /// </summary>
    public partial class PerfilControl : UserControl
    {
        private Usuario sesionAct;
        private ObservableCollection<Lista> listas;
       
        public PerfilControl(Usuario u)
        {

            InitializeComponent();
            this.sesionAct = u;
            this.listas = new ObservableCollection<Lista>();
            nombrelbl.Content= sesionAct.nombre;
           
            this.listas = sesionAct.getListas();
            
            ListViewListas.ItemsSource = listas;
        }

        private void eliminarButton_Click(object sender, RoutedEventArgs e)
        {
            Lista l  = ((Button)sender).Tag as Lista;
            sesionAct.removeLista(l);
        }

        private void verButton_Click(object sender, RoutedEventArgs e)
        {
            ListaWindow actual = new ListaWindow();
            actual.Show();
        }
        private void ListViewProducts_PreviewMouseWheel(object sender, MouseWheelEventArgs e) //para desviar los eventos del mousewheel que captura el listView al ScrollerView
        {
            if (!e.Handled)
            {
                e.Handled = true;
                var eventArg = new MouseWheelEventArgs(e.MouseDevice, e.Timestamp, e.Delta);
                eventArg.RoutedEvent = UIElement.MouseWheelEvent;
                eventArg.Source = sender;
                var parent = ((Control)sender).Parent as UIElement;
                parent.RaiseEvent(eventArg);
            }
        }
    }
}
