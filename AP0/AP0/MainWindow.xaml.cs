using System;
using System.Collections.Generic;
using System.Collections;
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

namespace AP0 {
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window {
    public MainWindow() {
      InitializeComponent();
      Style s = new Style();

      
      
    }

    private void Window_Loaded(object sender, RoutedEventArgs e) {
      //this.toptexBlock.Text = DateTime.Now.ToShortDateString();
      currDateTextBlock.Text = DateTime.Now.ToString();
      
    }

    private void Button_Click(object sender, RoutedEventArgs e) {
      if (listBox1.SelectedIndex == -1) {
        MessageBox.Show("Choisiser une nationalité", "nationalité", MessageBoxButton.OK, MessageBoxImage.Error);
      }
      else {
        string resume = textBox2.Text + " " + textBox1.Text;
        resume += "de sexe " + (manRadioButton.IsChecked == true ? "homme" : "femme") +
          " né" + ((manRadioButton.IsChecked == true ? "" : "e")) + " en " + ((int)slider1.Value).ToString();
        resume += " de nationalité " + ((ListBoxItem)listBox1.SelectedItem).Content;
        MessageBox.Show(resume);
        
       }
      
    }

    private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e) { 
      if (MessageBox.Show("Voulez-vous réellement quitter?", "Fermeture", MessageBoxButton.YesNo) != MessageBoxResult.Yes)
        e.Cancel = true;
     
    }

    private void ShowDLGBox_Click(object sender, RoutedEventArgs e) {
      // test for creating a dlg box 
      // create instance of window 
      EditDialogBox dlg = new EditDialogBox("Edit Name");
      dlg.Width = 150;
      dlg.Height = 100;
      dlg.ShowDialog();

    }



  }
}
