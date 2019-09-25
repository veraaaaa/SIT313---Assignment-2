using System;
using XamForms.Controls;

namespace Assignment2
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
        public string email { get; set; }
        public string PassWord { get; set; }
        public string Age { get; set; }
        public string CycleDay { get; set; }
        public string MenstrualDay { get; set; }
        public DateTime LmenstrualDay { get; set; }
    }
    public class RecordDetails
    {
        public bool sex { get; set; }
        public bool dysmenorrha { get; set; }
        public bool headache { get; set; }
        public bool dizziness { get; set; }
        public DateTime SpecificDate { get; set; }
    }
    public class Post
    {
        public string posttitle = null;
        public string postcontent = null;
        public string PostTitle
        {
            get { return posttitle; }
            set { posttitle = value; }
        }

        public string PostContent
        {
            get { return postcontent; }
            set { postcontent = value; }
        }
    }
}