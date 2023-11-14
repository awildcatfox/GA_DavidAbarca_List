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

namespace GA_DavidAbarca_List
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        List<string> studentNames = new List<string>();

        public MainWindow()
        {
            InitializeComponent();
            studentNames.Add("Will");
            studentNames.Add("Dylan");
            studentNames.Add("Hannah");
            studentNames.Add("Kristyn");
            studentNames.Add("Samantha");

            DisplayStudents();
        }

        private void DisplayStudents()
        {

            rtbDisplay.Text = "";
            for (int i = 0; i < studentNames.Count; i++)
            {

                rtbDisplay.Text += $"{i} - {studentNames[i]}\n";



            }

            lblCount.Content = $"Student Count: {studentNames.Count}";

        }

        private void btnAssStudent_Click(object sender, RoutedEventArgs e)
        {
            studentNames.Add(txtStudentName.Text);
            DisplayStudents();
        }

        private void btnDisplayStudent_Click(object sender, RoutedEventArgs e)
        {
            // Validate Value
            int index = -1;
            bool isANumber = int.TryParse(txtIndex.Text, out index);

            // Check if the number is between 0 and the last index in the list
            if (isANumber && index >= 0 && index < studentNames.Count)
            {
                MessageBox.Show(studentNames[index]);
            }
            else
            {
                MessageBox.Show("Invalid index");
            }
        }

        private void btnRemoveByIndex_Click(object sender, RoutedEventArgs e)
        {
            // Validate Value
            int index = -1;
            bool isANumber = int.TryParse(txtIndex.Text, out index);

            // Check if the number is between 0 and the last index in the list
            if (isANumber && index >= 0 && index < studentNames.Count)
            {
                studentNames.RemoveAt(index);
                DisplayStudents();
            }
            else
            {
                MessageBox.Show("Invalid index");
            }
        }

        private void btnAddAtIndex_Click(object sender, RoutedEventArgs e)
        {
            // Validate Value
            int index = -1;
            bool isANumber = int.TryParse(txtIndex.Text, out index);

            // Check if the number is between 0 and the last index in the list
            if (isANumber && index >= 0 && index < studentNames.Count)
            {
                studentNames.Insert(index, txtStudentName.Text);
                DisplayStudents();
            }
            else
            {
                MessageBox.Show("Invalid index");
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            studentNames.Clear();
            DisplayStudents();
        }
    }
}
