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
using Pruebas.BLL;
using Pruebas.Entidades;

namespace Pruebas
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

       private Actores actores= new Actores();

        public Actores Actores { get; private set; }
        public object Utilidades { get; private set; }

        private void GuardarButton_Click(object sender, RoutedEventArgs e){
        bool Guardo = ActoresBLL.Guardar(actores);

        if(Guardo==true)
            MessageBox.Show("Guardo Correctamente ✔");
        else
           MessageBox.Show("No Guardo Correctamente ❌");
       }
      private void BuscarButton_Click(object sender, RoutedEventArgs e){
         var Encontrado = ActoresBLL.Buscar(actores.ActorID);
         
          if(actores.ActorID>0)
            this.Actores= actores;
          else 
            this.actores= new Actores();
            this.DataContext= this.actores;
             
      }
     
    }
}

