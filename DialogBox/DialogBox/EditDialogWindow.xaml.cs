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

namespace DialogBox {
  /// <summary>
  /// Interaction logic for EditDialogWindow.xaml
  /// </summary>
  public partial class EditDialogWindow : Window {

    public EditDialogWindow() {
      InitializeComponent();
      
    }

    

    public Animal TheNewAnimal {
      get {
        // recover the animal instance from the resources dictionnary
        // of the actual window , normally after updating it with valid data 
        return (Animal)(this.Resources["AnimalInstance"]);
      }
    }

    // Handlers 

    private void OK_Button_Click(object sender, RoutedEventArgs e) {
      this.DialogResult = true; // close the dialog box 
    }






  }

}
