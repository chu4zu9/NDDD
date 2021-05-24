using NDDD.Domain.Entities;
using NDDD.Domain.Repositories;
using System;

namespace NDDD.WinForm.ViewModels
{
    public class LatestViewModel : ViewModelBase
    {
        private readonly IMeasureRepository _measureRepository;

        public LatestViewModel(IMeasureRepository measureRepository)
        {
            _measureRepository = measureRepository;
        }

        private string _areaIDText = string.Empty;
        public string AreaIDText
        {
            get { return _areaIDText; }
            set
            {
                SetProperty(ref _areaIDText, value);
            }
        }

        private string _measureDateText = string.Empty;
        public string MeasureDateText
        {
            get { return _measureDateText; }
            set
            {
                SetProperty(ref _measureDateText, value);
            }
        }

        private string _measureValueText = string.Empty;
        public string MeasureValueText
        {
            get { return _measureValueText; }
            set
            {
                SetProperty(ref _measureValueText, value);
            }
        }

        public void Search()
        {
            MeasureEntity entity = _measureRepository.GetLatest();
            AreaIDText = entity.AreaID.ToString().PadLeft(4, '0');
            MeasureDateText = entity.MeasureDate.ToString("yyyy/MM/dd hh:mm:ss");
            MeasureValueText = Math.Round(entity.MeasureValue, 2) + "℃";
        }
    }
}
