using System.Collections.ObjectModel;
using UnitsNet;

namespace MAUI.Mauiverter.MVVM.ViewModels
{
    public class ConverterViewModel
    {
        public string? QuantityName { get; set; }
        public ObservableCollection<string>? FromMeasures { get; set; }
        public ObservableCollection<string>? ToMeasures { get; set; }
        public string? CurrentFromMeasure { get; set; }
        public string? CurrentToMeasure { get; set; }

        public ConverterViewModel()
        {
            QuantityName = "Length";
            FromMeasures = LoadMeasures();
            ToMeasures = LoadMeasures();

            CurrentFromMeasure = "Meter";
            CurrentToMeasure = "Centimeter";
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
