
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
    public class DeletePlugin : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            var context = serviceProvider.Get<IPluginExecutionContext>();
            //comment 
            Guid id = Guid.Empty;
            if (context.InputParameters.Contains("Target") && context.InputParameters["Target"] is EntityReference)
            {
                EntityReference entityRef = (EntityReference)context.InputParameters["Target"];
                id = entityRef.Id;
                //change the table name below to the source table name you have created 
                //string cmdString = "DELETE VETicket WHERE TicketID=@TicketID";
                //SqlConnection connection = Connection.GetConnection();
                //using (SqlCommand command = connection.CreateCommand())
                //{
                //    command.CommandText = cmdString; command.Parameters.AddWithValue("@TicketID", id);
                //    connection.Open();
                //    try
                //    {
                //        var numRecords = command.ExecuteNonQuery();
                //        Console.WriteLine("deleted {0} records", numRecords);
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
