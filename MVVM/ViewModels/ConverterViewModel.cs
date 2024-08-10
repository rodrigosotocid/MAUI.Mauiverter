using PropertyChanged;
using System.Collections.ObjectModel;
using System.Windows.Input;
using UnitsNet;

namespace MAUI.Mauiverter.MVVM.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class ConverterViewModel
    {
        public string QuantityName { get; set; }
        public ObservableCollection<string>? FromMeasures { get; set; }
        public ObservableCollection<string>? ToMeasures { get; set; }
        public string CurrentFromMeasure { get; set; }
        public string CurrentToMeasure { get; set; }
        public double FromValue { get; set; } = 1;
        public double ToValue { get; set; }
        public ICommand ReturnCommand => new Command(Convert);

        public ConverterViewModel()
        {
            QuantityName = "Length";
            FromMeasures = LoadMeasures();
            ToMeasures = LoadMeasures();

            CurrentFromMeasure = "Meter";
            CurrentToMeasure = "Centimeter";

            Convert();
        }

        public void Convert()
        {
            ToValue =
                UnitConverter.ConvertByName(FromValue, QuantityName, CurrentFromMeasure, CurrentToMeasure);
        }

        private ObservableCollection<string>? LoadMeasures()
        {
            var types = Quantity.Infos?
                .FirstOrDefault(x => x.Name == QuantityName)?.UnitInfos
                .Select(u => u.Name).ToList();

            return (types is null) ? null : new ObservableCollection<string>(types);
        }
    }
}
