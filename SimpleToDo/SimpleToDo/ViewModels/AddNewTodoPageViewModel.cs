using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace SimpleToDo.ViewModels
{
    public class AddNewTodoPageViewModel : BaseViewModel
    {
        public string Content { get; set; }
        public string Description { get; set; }

        private readonly INavigation _navigation;
        public ICommand SaveNewTodoCommand { get; private set; }

        public AddNewTodoPageViewModel(INavigation navigation)
        {
            this._navigation = navigation;
            BindCommands();
        }

        private void BindCommands()
        {
            SaveNewTodoCommand = new Command(SaveNewTodo);
        }

        private void SaveNewTodo()
        {

        }
    }
}
