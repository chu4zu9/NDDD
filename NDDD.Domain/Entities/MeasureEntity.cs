using System;

namespace NDDD.Domain.Entities
{
    public sealed class MeasureEntity
    {
        public MeasureEntity(int areaID, DateTime measureDate, float measureValue)
        {
            AreaID = areaID;
            MeasureDate = measureDate;
            MeasureValue = measureValue;
        }

        public int AreaID { get; }
        public DateTime MeasureDate { get; }
        public float MeasureValue { get; }
    }
}
