using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleToDo.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SimpleToDo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddNewTodoPage : ContentPage
    {
        public AddNewTodoPage()
        {
            InitializeComponent();
            BindingContext = new AddNewTodoPageViewModel(Navigation);
        }
    }
}