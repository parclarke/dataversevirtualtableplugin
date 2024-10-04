using System;

namespace AppointmentProvider
{
    public class Appointment
    {
        public Guid AppointmentID { get; set; }
        public string PatientID { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Type { get; set; }
        public string Reason { get; set; }
        public string Channel { get; set; }
        public string Provider { get; set; }
        public string Location { get; set; }
        public string Status { get; set; }
    }
}
