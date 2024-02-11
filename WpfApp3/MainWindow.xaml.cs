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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {

        }
        /// <summary>
        /// open in menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("u open");
        }
        /// <summary>
        /// seve in menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("u seve");
        }
        /// <summary>
        /// close in menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// about in menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.Show();
        }
        /// <summary>
        /// seve in menu типа пометки при наведении
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItem_MouseEnter(object sender, MouseEventArgs e)
        {

        }
        /// <summary>
        /// рисование 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItem_Click_5(object sender, RoutedEventArgs e)
        {
            InkCanvas1.EditingMode = InkCanvasEditingMode.Ink;
        }
        /// <summary>
        /// ркдактор
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItem_Click_6(object sender, RoutedEventArgs e)
        {
            InkCanvas1.EditingMode = InkCanvasEditingMode.EraseByPoint;
        }
        /// <summary>
        /// удаление 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItem_Click_7(object sender, RoutedEventArgs e)
        {
            InkCanvas1.EditingMode = InkCanvasEditingMode.EraseByStroke;
        }

        private void MenuItem_Click_8(object sender, RoutedEventArgs e)
        {
            ///InkCanvas1.DefaultDrawingAttributes.Color = Color.;

        }
        /// <summary>
        /// red
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItem_Click_9(object sender, RoutedEventArgs e)
        {
            InkCanvas1.DefaultDrawingAttributes.Color = Colors.Red;
        }
        /// <summary>
        /// green
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItem_Click_10(object sender, RoutedEventArgs e)
        {
            InkCanvas1.DefaultDrawingAttributes.Color = Colors.Green;
        }
        /// <summary>
        /// blue
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItem_Click_11(object sender, RoutedEventArgs e)
        {
            InkCanvas1.DefaultDrawingAttributes.Color = Colors.Blue;
        }
        /// <summary>
        /// высота
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (Slider.ValueChangedEvent != null)
            {
                InkCanvas1.DefaultDrawingAttributes.Height = 10;
            }
            else
            {
                InkCanvas1.DefaultDrawingAttributes.Height = 1;
            }

        }
        /// <summary>
        /// ширина
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void wight_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (Slider.ValueChangedEvent != null)
            {
                InkCanvas1.DefaultDrawingAttributes.Width = 10;
            }
            else
            {
                InkCanvas1.DefaultDrawingAttributes.Width = 1;
            }
        }
    }
}