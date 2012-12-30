using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NLite.Data;

namespace Scheduler
{
    [Table(Name = "tbAppointmentLabel")]
    public class AppointmentLabel
    {
        [Id(Name = "id", IsDbGenerated = true)]
        public int Id { get; set; }
        [Column(Name = "displaytext")]
        public string DisplayText { get; set; }
        [Column(Name = "displaycolor")]
        public string DisplayColor { get; set; }
    }

    [Table(Name = "tbAppointmentDisplay")]
    public class AppointmentDisplay
    {
        [Id(Name = "id", IsDbGenerated = true)]
        public int Id { get; set; }
        [Column(Name = "displaytext")]
        public string DisplayText { get; set; }
        [Column(Name = "displaycolor")]
        public string DisplayColor { get; set; }
    }

    [Table(Name = "tbAppointment")]
    public class Appointment
    {
        [Id(Name = "id", IsDbGenerated = true)]
        public int Id { get; set; }
        [Column(Name = "subject")]
        public string Subject { get; set; }
        [Column(Name = "location")]
        public string Location { get; set; }
        [Column(Name = "starttime")]
        public DateTime StartTime { get; set; }
        [Column(Name = "endtime")]
        public DateTime EndTime { get; set; }
        [Column(Name = "labelid")]
        public int LabelId { get; set; }
        [Column(Name = "displayid")]
        public int DisplayId { get; set; }
        [Column(Name = "description")]
        public string Description { get; set; }
        [Column(Name = "remindable")]
        public int Remindable { get; set; }
    }
}
