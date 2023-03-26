using System.Windows.Input;
using Xamarin.Forms;
using Flaggen.ViewModels;




namespace Flaggen.Views
{
    public partial class QuizPage : ContentPage
    {
        public QuizPage()
        {
            InitializeComponent();
        }

        private ICommand checkAnswerCommand;
        public ICommand CheckAnswerCommand
        {
            get
            {
                if (checkAnswerCommand == null)
                {
                    checkAnswerCommand = new Command<string>(async answer =>
                    {
                        bool isCorrect = (BindingContext as QuizViewModel).CheckAnswer(answer);
                        if (isCorrect)
                        {
                            await DisplayAlert("Correct", "You got it right!", "OK");
                        }
                        else
                        {
                            await DisplayAlert("Incorrect", "Sorry, that's not correct.", "OK");
                        }
                    });
                }
                return checkAnswerCommand;
            }
        }

        private ICommand nextQuestionCommand;
        public ICommand NextQuestionCommand
        {
            get
            {
                if (nextQuestionCommand == null)
                {
                    nextQuestionCommand = new Command(() =>
                    {
                        (BindingContext as QuizViewModel).LoadQuestion();
                    });
                }
                return nextQuestionCommand;
            }
        }
    }
}
