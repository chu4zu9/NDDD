using NDDD.WinForm.ViewModels;
using NDDD.Infrastructure.Fake;
using System.Windows.Forms;
using NDDD.Infrastructure;

namespace NDDD.WinForm.Views
{
    public partial class LatestView : Form
    {
        private readonly LatestViewModel _viewModel
            = new LatestViewModel(Factories.CreateMeasure());
        public LatestView()
        {
            InitializeComponent();
            AreaIDTextBox.DataBindings.Add(
                "Text",
                _viewModel,
                nameof(_viewModel.AreaIDText));
            MeasureDateTextBox.DataBindings.Add(
                "Text",
                _viewModel,
                nameof(_viewModel.MeasureDateText));
            MeasureValueTextBox.DataBindings.Add(
                "Text",
                _viewModel,
                nameof(_viewModel.MeasureValueText));
        }

        private void SearchButton_Click(object sender, System.EventArgs e)
        {
            _viewModel.Search();
        }
    }
}
