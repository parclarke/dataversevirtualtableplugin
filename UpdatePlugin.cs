
using Microsoft.Xrm.Sdk.Extensions;
using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotreSantePlugIns
{
    public class UpdatePlugin : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            var context = serviceProvider.Get<IPluginExecutionContext>();
            Guid id = Guid.Empty;
            if (context.InputParameters.Contains("Target") && context.InputParameters["Target"] is Entity)
            {
                Entity entity = (Entity)context.InputParameters["Target"];
                //change the table name below to the source table name you have created  
                //string cmdString = "UPDATE VETicket SET {0} WHERE TicketID=@TicketID";
                //SqlConnection connection = Connection.GetConnection();
                //using (SqlCommand command = connection.CreateCommand())
                //{
                //    command.Parameters.AddWithValue("@TicketID", entity["new_ticketid"]);
                //    List<string> setList = new List<string>();
                //    if (entity.Attributes.Contains("new_name"))
                //    {
                //        command.Parameters.AddWithValue("@Name", entity["new_name"]);
                //        setList.Add("Name=@Name");
                //    }
                //    if (entity.Attributes.Contains("new_severity"))
                //    {
                //        command.Parameters.AddWithValue("@Severity", entity["new_severity"]);
                //        setList.Add("Severity=@Severity");
                //    }
                //    command.CommandText = string.Format(cmdString, string.Join(",", setList)); connection.Open();
                //    try
                //    {
                //        var numRecords = command.ExecuteNonQuery();
                //        Console.WriteLine("updated {0} records", numRecords);
                //    }
                //    finally
                //    {
                //        connection.Close();
                //    }
                //    // other codes. 
                //}
            }
        }
    }
}
