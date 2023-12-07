using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

namespace assignment_project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        EmployeeEntity db=new EmployeeEntity();
        public MainWindow()
        {
            InitializeComponent();
            DataGrid.ItemsSourceProperty=db.Employees.;

        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {

        }
        private void AddRecord(object sender, RoutedEventArgs e)
        {
            if(textBox3.Text!="")
            {
                MessageBox.Show("ID generted outomatically");
            }
            Employee e1= new Employee();
            e1.EmpName = TextBox1.Text;
            e1.EmpPosition=TextBox2.Text;
            
        }
     
    }
}
            