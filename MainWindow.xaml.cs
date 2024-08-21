using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

public class SmokingViewModel : INotifyPropertyChanged
{
    private SmokingModel _model;
    private string _agent;
    private string _agent2;

    public SmokingViewModel()
    {
        _model = new SmokingModel();
        StartCommand = new RelayCommand(Start);
    }

    public string Agent
    {
        get => _agent;
        set
        {
            _agent = value;
            OnPropertyChanged();
        }
    }

    public string Agent2
    {
        get => _agent2;
        set
        {
            _agent2 = value;
            OnPropertyChanged();
        }
    }

    public ICommand StartCommand { get; }

    private void Start()
    {
        // Логика для начала процесса
        Agent = "Посредник кладет на стол табак и бумагу";
        Agent2 = "Курильщик со спичками скручивает сигарету и курит";
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected void OnPropertyChanged([CallerMemberName] string name = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
