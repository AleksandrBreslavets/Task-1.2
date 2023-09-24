

namespace Task_1._2_2
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnShowNumberButtonClicked(object sender, EventArgs e)
        {
            string inputText = inputEntry.Text;
            int n;
            string result;
            if (inputText == "")
            {
                result = "Ви не ввели число!";
            }
            else
            {
                try
                {
                    n = int.Parse(inputText);
                    result = "Ви ввели ціле число " + n;
                }
                catch (Exception)
                {
                    result="Ви ввели не ціле число! Спробуйте ще раз.";
                }
            }
            outputLabel.Text = result;
        }
    }
}