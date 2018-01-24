using System.Collections.ObjectModel;
using System.Windows.Input;
using SimpleToDo.Models;
using SimpleToDo.Services;
using Xamarin.Forms;

namespace SimpleToDo.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        private readonly INavigation _navigation;
        public ICommand AddNewTodoCommand { get; private set; }
        private ObservableCollection<ToDoItem> _todos = new ObservableCollection<ToDoItem>();
        private readonly TodoWebService _service;

        public ObservableCollection<ToDoItem> Todos
        {
            get => _todos;
            set
            {
                if (_todos == value) return;
                _todos = value;
                OnPropertyChanged();
            }
        }

        public MainPageViewModel(INavigation navigation)
        {
            _navigation = navigation;
            _service = new TodoWebService();
            BindCommands();
            SeedCollection();
        }

        private void BindCommands()
        {
            AddNewTodoCommand = new Command(AddNewTodo);
        }

        private void AddNewTodo()
        {
            _navigation.PushModalAsync(new AddNewTodoPage());
        }

        private void SeedCollection()
        {
            
            var todos = _service.GetAllTodos().Result;
            foreach (var todo in todos)
            {
                _todos.Add(todo);
            }
        }
    }
}
