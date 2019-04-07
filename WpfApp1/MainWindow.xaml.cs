using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Data;
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
using System.Configuration;
using WpfApp1.Models;
using System.Data.Entity;
using System.Globalization;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string selectedValue = null;
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
        public MainWindow()
        {
            InitializeComponent();
            Start();
        }

        private void Start()
        {
            SqlDataAdapter da = new SqlDataAdapter(" Select * from Students inner join  Grades on Grades.Gradebook_Number=Students.Gradebook_Number", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            docGrid.ItemsSource = dt.DefaultView;
            SqlDataAdapter da1 = new SqlDataAdapter(" select DISTINCT  Groups from Students ", con);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);

            foreach (DataRow dr in dt1.Rows)
            {
                GroupList.Items.Add(dr["Groups"].ToString());
            }
        }

        private void ComboBox_Selected(object sender, RoutedEventArgs e)
        {
            selectedValue = ((string)GroupList.SelectedValue);
           
        }

        private void Search(object sender, RoutedEventArgs e)
        {
            string temp = txtName.Text;
            temp.Replace(' ', '_');
            int min;
            int max;
            SqlDataAdapter da;
            if (int.TryParse(Minvalue.Text, out min) && int.TryParse(Maxvalue.Text, out max))
            {

            }
            else
            {
                min = 0;
                max = 100;
            }
            if (selectedValue == null)
            {
                da = new SqlDataAdapter("Select * from Students inner join  Grades on Grades.Gradebook_Number=Students.Gradebook_Number where Name like '%" + temp + "%' and Literature BETWEEN '" + min + "' and '" + max + "' and Drawing BETWEEN '" + min + "' and '" + max + "' and Maths BETWEEN '" + min + "' and '" + max + "'", con);
            }
            else
            {
                da = new SqlDataAdapter("Select * from Students inner join  Grades on Grades.Gradebook_Number=Students.Gradebook_Number where Name like '%" + temp + "%' and Groups='" + selectedValue + "' and Literature BETWEEN '" + min + "' and '" + max + "' and Drawing BETWEEN '" + min + "' and '" + max + "' and Maths BETWEEN '" + min + "' and '" + max + "'", con);
               
            }
            DataTable dt = new DataTable();
            da.Fill(dt);
            docGrid.ItemsSource = dt.DefaultView;

        }

        private void Clear(object sender, RoutedEventArgs e)
        {
            txtName.Text = null;
            Minvalue.Text = null;
            Maxvalue.Text = null;
            GroupList.SelectedValue =-1;
            Start();
        }
        
    }

    public class IdToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
                    return (int)value >= 90 ?
                        new SolidColorBrush(Colors.Green)
                        : new SolidColorBrush(Colors.White);
                
            }
            catch
            {
                return new SolidColorBrush(Colors.White);
            }
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new Exception("The method or operation is not implemented.");
        }
    }

}
