using System;
using XamForms.Controls;

namespace TrialAss2
{
    public class ListItem
    {
        public string ItemName { get; set; }
        public string ItemImage { get; set; }
        public string CheckboxImage { get; set; }
    }
    public class WeeklyDates
    {
        public DateTime Today { get; set; }
        public DateTime SecondDay { get; set; }
        public DateTime ThirdDay { get; set; }
        public DateTime FourthDay { get; set; }
        public DateTime FifthDay { get; set; }
        public DateTime SixthDay { get; set; }
        public DateTime Sevenday { get; set; }
    }
    public class CustomerInfo
    {
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public string Age { get; set; }
        public string CycleDay { get; set; }
        public string MenstrualDay { get; set; }
        public DateTime LmenstrualDay { get; set; }
    }
    public class RecordDetails
    {
        public bool breakfast { get; set; }
        public DateTime SpecificDate { get; set; }
    }
}
