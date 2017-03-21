using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using E_learning.Models;
using System.Collections.ObjectModel;
using Windows.UI.Popups;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace E_learning
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SubjectsPage : Page
    {
        private List<Subject> Subjects = new List<Subject>();

        public SubjectsPage()
        {
            this.InitializeComponent();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            //Vakken
            lbSubjects.Items.Add(new Subject { Id = 1, Name = "Rekenen" }.Name);
            lbSubjects.Items.Add(new Subject { Id = 2, Name = "Aardrijkskunde" }.Name);
            lbSubjects.Items.Add(new Subject { Id = 3, Name = "Nederlands" }.Name);

            //Assignments
            lvTodo.Items.Add(new Assignment { Id = 1, Name = "(18-3-2017) Optellen 3" }.Name);
            lvTodo.Items.Add(new Assignment { Id = 2, Name = "(18-3-2017) Optellen 3" }.Name);
            lvTodo.Items.Add(new Assignment { Id = 3, Name = "(18-3-2017) Optellen 3" }.Name);
            lvTodo.Items.Add(new Assignment { Id = 4, Name = "(18-3-2017) Optellen 3" }.Name);
            lvTodo.Items.Add(new Assignment { Id = 5, Name = "(18-3-2017) Optellen 3" }.Name);

            lvDone.Items.Add(new Assignment { Id = 6, Name = "(18-3-2017) Optellen 3" }.Name);

        }


    }
}
