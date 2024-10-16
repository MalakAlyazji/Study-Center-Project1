using System.Windows.Forms;

namespace StudyCenterPresentation
{
    public class clsShowMessage
    {
        public static DialogResult DeleteConfiirmation(string s)
        {
            return MessageBox.Show($"Are you sure you want to delete this {s}", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                 MessageBoxDefaultButton.Button2);
        }
        public static DialogResult SelectConfirmation(string s, int? Selectedvalue)
        {
            return MessageBox.Show($"Are you sure you want to Select this {s} with {Selectedvalue} ID ?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                 MessageBoxDefaultButton.Button2);
        }
        public static void ShowWrongCredentials()
        {
            MessageBox.Show("Invalid Username/Password.", "Wrong Credentials",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void ShowValidationErrorMessage(string errorMessage = "Some fields are not valid! Put the mouse over the red icon(s) to see the error.")
        {
            MessageBox.Show(errorMessage, "Validation Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void ShowMissingDataMessage(string entityType, int? entityID)
        {
            MessageBox.Show($"No {entityType} found with ID: {entityID}", "Missing Data",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        public static void IdNotFound(string message, int? ID)
        {
            MessageBox.Show($"No {message} Found with ID: {ID}", "Missing Data",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        public static void OperationFelid(string Operation)
        {
            MessageBox.Show($"Error: Data Is not {Operation} Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void OperationDoneSuccessfully(string Operation)
        {
            MessageBox.Show($"Data {Operation} Successfully.", $"{Operation}", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void ValidationErrorMessage()
        {
            MessageBox.Show("Some Fields are not Valid!, put the mouse over the red icon(s) to see the error", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void GeneralErrorMessage(string message)
        {
            MessageBox.Show(message, "Error",
             MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void alreadyexist(string message)
        {
            MessageBox.Show(message, "Already Exists!",
             MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void DeletedSuccessfuly(string whos)
        {
            MessageBox.Show($"The {whos} was successfully deleted.",
                          "Deletion Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
