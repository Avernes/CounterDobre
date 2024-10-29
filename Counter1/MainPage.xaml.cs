namespace Counter1;

public partial class MainPage : ContentPage
{
    private int _counterIndex = 1;

    public MainPage()
    {
        InitializeComponent();
    }
    private void OnAddCounterClicked(object sender, EventArgs e)
    {
        var counterLayout = new VerticalStackLayout { Padding = 10 };

        var counterName = $"Licznik {_counterIndex++}";

        var nameLabel = new Label { Text = counterName, FontSize = 18, HorizontalOptions = LayoutOptions.Center };

        var counterLabel = new Label { Text = "0", FontSize = 20, HorizontalOptions = LayoutOptions.Center };

        var minusButton = new Button { Text = "-" };

        var plusButton = new Button { Text = "+" };

        int counterValue = 0;

        minusButton.Clicked += (s, e) =>
        {
            counterValue--;
            counterLabel.Text = counterValue.ToString();
        };

        plusButton.Clicked += (s, e) =>
        {
            counterValue++;
            counterLabel.Text = counterValue.ToString();
        };

        counterLayout.Children.Add(nameLabel);
        counterLayout.Children.Add(counterLabel);
        counterLayout.Children.Add(new HorizontalStackLayout { Children = { minusButton, plusButton } });
        CountersStack.Children.Add(counterLayout);
    }
}
