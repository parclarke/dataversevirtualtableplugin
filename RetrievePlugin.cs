
using Microsoft.Xrm.Sdk.Extensions;
using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppointmentProvider;
using Newtonsoft.Json;
using System.IO;

namespace VotreSantePlugIns
{
    public class RetrievePlugin : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            var context = serviceProvider.Get<IPluginExecutionContext>();
            
            List<Appointment> appointments = LoadAppointments();

            Guid id = Guid.Empty;
            if (context.InputParameters.Contains("Target") && context.InputParameters["Target"] is EntityReference)
            {
                EntityReference entityRef = (EntityReference)context.InputParameters["Target"];
                id = entityRef.Id;
                Entity e = new Entity("new_appointment");

         
                Appointment appointment = GetAppointmentById(appointments, id);
                if (appointment != null)
                {
                    e.Attributes.Add("new_appointmentid", appointment.AppointmentID);
                    e.Attributes.Add("new_patientid", appointment.PatientID);
                    e.Attributes.Add("new_name", appointment.Name);
                    e.Attributes.Add("new_date", appointment.Date);
                    e.Attributes.Add("new_type", appointment.Type);
                    e.Attributes.Add("new_reason", appointment.Reason);
                    e.Attributes.Add("new_channel", appointment.Channel);
                    e.Attributes.Add("new_provider", appointment.Provider);
                    e.Attributes.Add("new_location", appointment.Location);
                    e.Attributes.Add("new_status", appointment.Status);
                }
                context.OutputParameters["BusinessEntity"] = e;
            }
        }

        static Appointment GetAppointmentById(List<Appointment> appointments, Guid id)
        {
            return appointments.Find(appt => appt.AppointmentID == id);
        }

        static List<Appointment> LoadAppointments()
        {
            
            string json = AppointmentsDB.jsonData;
            return JsonConvert.DeserializeObject<List<Appointment>>(json);
        }
        }
}
