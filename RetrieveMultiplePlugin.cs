
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
    public class RetrieveMultiplePlugin : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            var context = serviceProvider.Get<IPluginExecutionContext>();
            EntityCollection collection = new EntityCollection();
            
            List<Appointment> appointments = LoadAppointments();
       
            foreach (var appointment in appointments)
            {
               
                Entity e = new Entity("new_appointment");
                e.Attributes.Add("new_appointmentid", appointment.AppointmentID);
                e.Attributes.Add("new_name", appointment.Name);
                e.Attributes.Add("new_patientid", appointment.PatientID);
                e.Attributes.Add("new_date",appointment.Date);
                e.Attributes.Add("new_type",appointment.Type);
                e.Attributes.Add("new_reason",appointment.Reason);  
                e.Attributes.Add("new_channel", appointment.Channel);   
                e.Attributes.Add("new_provider", appointment.Provider);
                e.Attributes.Add("new_location", appointment.Location);
                e.Attributes.Add("new_status", appointment.Status);
                collection.Entities.Add(e);
            }
                    
            context.OutputParameters["BusinessEntityCollection"] = collection;
            
        }

        static List<Appointment> LoadAppointments()
        {
            string json = AppointmentsDB.jsonData;
            return JsonConvert.DeserializeObject<List<Appointment>>(json);
        }
    }
}
