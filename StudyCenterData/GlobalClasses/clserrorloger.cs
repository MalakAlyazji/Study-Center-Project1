using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Security;
namespace StudyCenterData.GlobalClasses
{
    public class clserrorloger
    {
        public static void logerror(Exception ex)
        {
            string sourceName = "StudyCenterPresentation";

            try
            {
                if (!EventLog.SourceExists(sourceName))
                {
                    // Create the event source if it does not exist
                    EventLog.CreateEventSource(sourceName, "Application");
                }

                string errorMessage = $"Exception occurred in: {ex.Source}\n" +
                    $"Exception Message: {ex.Message}\n" +
                    $"Exception Type: {ex.GetType().Name}\n" +
                    $"Stack Trace: {ex.StackTrace}\n" +
                    $"Error Location: {ex.TargetSite.Name}\n";

                EventLog.WriteEntry(sourceName, errorMessage, EventLogEntryType.Error);
            }
            catch (SecurityException secEx)
            {
                Console.WriteLine("SecurityException: " + secEx.Message);
                // Log to a different location or handle accordingly
            }
            catch (Exception generalEx)
            {
                Console.WriteLine("Exception: " + generalEx.Message);
                // Handle other exceptions
            }
        }
    }
}
