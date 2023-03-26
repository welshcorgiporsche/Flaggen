using Data;
using Flaggen.Methods;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;
namespace Flaggen.ViewModels;



public class QuizViewModel : INotifyPropertyChanged
{

    private List<string> _options;
    private int _score;



    public event PropertyChangedEventHandler PropertyChanged;

    public QuizViewModel()
    {
        // Initialize the score and load the first question
        _score = 0;
        LoadQuestion();
    }


    public List<string> Options
    {
        get { return _options; }
        set
        {
            _options = value;
            OnPropertyChanged(nameof(Options));
        }
    }

    public int Score
    {
        get { return _score; }
        set
        {
            _score = value;
            OnPropertyChanged(nameof(Score));
        }
    }

    private Flag _currentFlag;
    public Flag CurrentFlag
    {
        get { return _currentFlag; }
        set
        {
            _currentFlag = value;
            OnPropertyChanged(nameof(CurrentFlag));
        }
    }


    public ICommand NextQuestionCommand => new Command(LoadQuestion);

    public void LoadQuestion()
    {



        // Create an instance of the FlagData class
        FlagData flagData = new FlagData();
        Flag[] flags = FlagData.flags;

        // Get a random flag from the flags array
        CurrentFlag = flagData.GetRandomFlag(flags);


        // Create a list of options containing the correct answer and three other random flags
        Options = new List<string>
            {
                CurrentFlag.CorrectAnswer,
                flagData.GetRandomFlag(flags).CorrectAnswer,
                flagData.GetRandomFlag(flags).CorrectAnswer,
                flagData.GetRandomFlag(flags).CorrectAnswer
            }; Options.Shuffle();
    }


    public bool CheckAnswer(string selectedOption)
    {
        bool isCorrect = selectedOption == CurrentFlag.CorrectAnswer;
        if (isCorrect)
        {
            Score++;
        }
        return isCorrect;
    }
  
    public ICommand CheckAnswerCommand => new Command<string>((selectedOption) =>
    {
        bool isCorrect = CheckAnswer(selectedOption);
        if (isCorrect)
        {
            LoadQuestion();
        }
    });



    protected virtual void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}

