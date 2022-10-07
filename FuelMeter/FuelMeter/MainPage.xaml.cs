namespace FuelMeter;

public partial class MainPage : ContentPage
{
    public MainPage()
	{
		InitializeComponent();
        multiRangesGauge.BindingContext = this;
	}

	private void NeedlePointer_ValueChanged(object sender, Syncfusion.Maui.Gauges.ValueChangedEventArgs e)
	{
        if (e.Value >= 0 && e.Value <= 10)
        {
            _onFirstRangeColorChanged();
        }
        else if (e.Value >= 10 && e.Value <= 20)
        {
            _onSecondRangeColorChanged();
        }
        else if (e.Value >= 20 && e.Value <= 30)
        {
            _onThirdRangeColorChanged();
        }
        else if (e.Value >= 30 && e.Value <= 40)
        {
            _onFourthRangeColorChanged();
        }
        else if (e.Value >= 40 && e.Value <= 50)
        {
            _onFifthRangeColorChanged();
        }
        else if (e.Value >= 50 && e.Value <= 60)
        {
            _onSixthRangeColorChanged();
        }
        else if (e.Value >= 60 && e.Value <= 70)
        {
            _onSeventhRangeColorChanged();
        }
        else if (e.Value >= 70 && e.Value <= 80)
        {
            _onEighthRangeColorChanged();
        }
        else if (e.Value >= 80 && e.Value <= 90)
        {
            _onNinethRangeColorChanged();
        }
        else if (e.Value >= 90 && e.Value <= 100)
        {
            _onTenthRangeColorChanged();
        }
    }

    void _onFirstRangeColorChanged()
    {
        range1.Fill = Colors.Red;
        range2.Fill = Colors.Black;
        range3.Fill = Colors.Black;
        range4.Fill = Colors.Black;
        range5.Fill = Colors.Black;
        range6.Fill = Colors.Black;
        range7.Fill = Colors.Black;
        range8.Fill = Colors.Black;
        range9.Fill = Colors.Black;
        range10.Fill = Colors.Black;
    }

    void _onSecondRangeColorChanged()
    {
        range1.Fill = Colors.Black;
        range2.Fill = Colors.Red;
        range3.Fill = Colors.Black;
        range4.Fill = Colors.Black;
        range5.Fill = Colors.Black;
        range6.Fill = Colors.Black;
        range7.Fill = Colors.Black;
        range8.Fill = Colors.Black;
        range9.Fill = Colors.Black;
        range10.Fill = Colors.Black;
    }

    void _onThirdRangeColorChanged()
    {
        range1.Fill = Colors.Black;
        range2.Fill = Colors.Black;
        range3.Fill = Colors.Red;
        range4.Fill = Colors.Black;
        range5.Fill = Colors.Black;
        range6.Fill = Colors.Black;
        range7.Fill = Colors.Black;
        range8.Fill = Colors.Black;
        range9.Fill = Colors.Black;
        range10.Fill = Colors.Black;
    }

    void _onFourthRangeColorChanged()
    {
        range1.Fill = Colors.Black;
        range2.Fill = Colors.Black;
        range3.Fill = Colors.Black;
        range4.Fill = Colors.Red;
        range5.Fill = Colors.Black;
        range6.Fill = Colors.Black;
        range7.Fill = Colors.Black;
        range8.Fill = Colors.Black;
        range9.Fill = Colors.Black;
        range10.Fill = Colors.Black;
    }

    void _onFifthRangeColorChanged()
    {
        range1.Fill = Colors.Black;
        range2.Fill = Colors.Black;
        range3.Fill = Colors.Black;
        range4.Fill = Colors.Black;
        range5.Fill = Colors.Red;
        range6.Fill = Colors.Black;
        range7.Fill = Colors.Black;
        range8.Fill = Colors.Black;
        range9.Fill = Colors.Black;
        range10.Fill = Colors.Black;
    }

    void _onSixthRangeColorChanged()
    {
        range1.Fill = Colors.Black;
        range2.Fill = Colors.Black;
        range3.Fill = Colors.Black;
        range4.Fill = Colors.Black;
        range5.Fill = Colors.Black;
        range6.Fill = Colors.Red;
        range7.Fill = Colors.Black;
        range8.Fill = Colors.Black;
        range9.Fill = Colors.Black;
        range10.Fill = Colors.Black;
    }

    void _onSeventhRangeColorChanged()
    {
        range1.Fill = Colors.Black;
        range2.Fill = Colors.Black;
        range3.Fill = Colors.Black;
        range4.Fill = Colors.Black;
        range5.Fill = Colors.Black;
        range6.Fill = Colors.Black;
        range7.Fill = Colors.Red;
        range8.Fill = Colors.Black;
        range9.Fill = Colors.Black;
        range10.Fill = Colors.Black;
    }

    void _onEighthRangeColorChanged()
    {
        range1.Fill = Colors.Black;
        range2.Fill = Colors.Black;
        range3.Fill = Colors.Black;
        range4.Fill = Colors.Black;
        range5.Fill = Colors.Black;
        range6.Fill = Colors.Black;
        range7.Fill = Colors.Black;
        range8.Fill = Colors.Red;
        range9.Fill = Colors.Black;
        range10.Fill = Colors.Black;
    }

    void _onNinethRangeColorChanged()
    {
        range1.Fill = Colors.Black;
        range2.Fill = Colors.Black;
        range3.Fill = Colors.Black;
        range4.Fill = Colors.Black;
        range5.Fill = Colors.Black;
        range6.Fill = Colors.Black;
        range7.Fill = Colors.Black;
        range8.Fill = Colors.Black;
        range9.Fill = Colors.Red;
        range10.Fill = Colors.Black;
    }

    void _onTenthRangeColorChanged()
    {
        range1.Fill = Colors.Black;
        range2.Fill = Colors.Black;
        range3.Fill = Colors.Black;
        range4.Fill = Colors.Black;
        range5.Fill = Colors.Black;
        range6.Fill = Colors.Black;
        range7.Fill = Colors.Black;
        range8.Fill = Colors.Black;
        range9.Fill = Colors.Black;
        range10.Fill = Colors.Red;
    }
}

