using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace PuntoDeVenta
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool _isMouseDown = false;
        private Point mouseDown;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Principal_PreviewKeyDown(object sender, KeyEventArgs e)
        {
          
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();

        }

        private void btnCerrar_Click(object sender, RoutedEventArgs e)
        {

            MessageBoxResult result = MessageBox.Show("Seguro que deseas salir?","Pregunta", MessageBoxButton.YesNo);
            if(result == MessageBoxResult.Yes)
            {
                this.Close();
            }            
        }

        private void btnMinimizar_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Header_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            _isMouseDown = true;
            this.DragMove();
           
        }

        private void Header_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            _isMouseDown = false;
            this.Top = PointToScreen(e.GetPosition(this)).Y - mouseDown.Y;           
        }

        private void Header_MouseMove(object sender, MouseEventArgs e)
        {         
            
            // if we are dragging and Maximized, retore window
           if(_isMouseDown && this.Top <= 0)
            {
                _isMouseDown = false;
                this.WindowState = System.Windows.WindowState.Maximized;
            }
        }

        private void btnRestauar_Click(object sender, RoutedEventArgs e)
        {
            maximizarRestaurar();
        }

        private void maximizarRestaurar()
        {          
            if (this.WindowState == WindowState.Maximized)
            {
                this.WindowState = System.Windows.WindowState.Normal;
            }
            else
            {
                this.WindowState = System.Windows.WindowState.Maximized;
            }
        }

        private void Header_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount == 2 && e.ChangedButton == MouseButton.Left)
            {
                maximizarRestaurar();
            }
        }
    }
}
