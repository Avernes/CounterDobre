namespace Counter1;

public partial class MainPage : ContentPage
{
    private int _counterIndex = 1;

    public MainPage()
    {
        InitializeComponent();
    }
    private void OnAddCounterClicked(object sender, EventArgs e)//Metoda obsługująca kliknięcie przycisku dodającego licznik"
    {
        var counterLayout = new VerticalStackLayout { Padding = 10 };

        var counterName = $"Licznik {_counterIndex++}";//Dodane automatyczne nazywanie liczników

        var nameLabel = new Label { Text = counterName, FontSize = 20, HorizontalOptions = LayoutOptions.Center };//label wyświetlający nazwy użytkownika

        var counterLabel = new Label { Text = "0", FontSize = 25, HorizontalOptions = LayoutOptions.Center };//label wyświetlający wartość licznika

        var minusButton = new Button { Text = "-" };//plus

        var plusButton = new Button { Text = "+" };//minus

        int counterValue = 0;

        minusButton.Clicked += (s, e) =>//zmniejszanie wartości licznikqa po kliknieciu
        {
            counterValue--;
            counterLabel.Text = counterValue.ToString();
        };

        plusButton.Clicked += (s, e) => //zwiększanie wartości licznika po kliknieciu
        {
            counterValue++;
            counterLabel.Text = counterValue.ToString();
        };

        counterLayout.Children.Add(nameLabel);//dodanie labela z nazwą licznika do układu
        counterLayout.Children.Add(counterLabel);//dodanie labela z wartością licznika do układu
        counterLayout.Children.Add(new HorizontalStackLayout { Children = { minusButton, plusButton } });
        CountersStack.Children.Add(counterLayout); //dodanie układu licznika
    }
}
