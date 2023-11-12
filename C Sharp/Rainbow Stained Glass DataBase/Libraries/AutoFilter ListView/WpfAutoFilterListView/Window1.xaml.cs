using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Reflection;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using ScottLogic;
using ScottLogic.Controls;
using BaseWPFHelpers;

namespace ScottLogic
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        private IList<Employee> employees;
      

        public Window1()
        {
            InitializeComponent();

            employees = new List<Employee>();

            for (int i = 0; i < 300; i++)
            {
                employees.Add(createRandomEmployee());
            }

            this.DataContext = employees;
        }


        private Random rand = new Random();

        private static readonly String[] surnames = new String[]{"Aaberg", "Adams", "Hanif", "Akers", "Harris", "Andersen",
            "Alberts", "Hamlin", "Hee", "Peno", "Pfeiffer", null};

        private static readonly String[] forenames = new String[]{"Jesper", "Jonathan", "Kerim", "Kim", "Phyllis", "Elizabeth",
            "Amy", "Jay", "Gordon", "Lori", "Michael", null};
            
        private Employee createRandomEmployee()
        {
            return new Employee(surnames[rand.Next(surnames.Length)], forenames[rand.Next(forenames.Length)],
                rand.Next(100)*100, new DateTime(1975 + rand.Next(22), rand.Next(12)+1, rand.Next(28)+1));
        }

        private void tabControl1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ICollectionView employeeView = CollectionViewSource.GetDefaultView(employees);
        }

    }
}
