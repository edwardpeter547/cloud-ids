using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.WebSockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using MD5Hash;
using static System.Reflection.Metadata.BlobBuilder;

namespace Multilevel
{
    public class Library : Base
    {

        public static void reset_text_fields(Form form)
        {
            foreach (var c in form.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }
            }
        }

        public static bool validate_email_address(string emailaddress)
        {
            try
            {
                MailAddress address = new MailAddress(emailaddress);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        public static List<TextBox> get_text_fields(Form form)
        {
            var Fields = new List<TextBox>();

            foreach (var c in form.Controls)
            {
                if (c is TextBox)
                {
                    Fields.Add(((TextBox)c));
                }
            }
            return Fields;
        }

        public static bool validate_compulsory_fields(List<TextBox> fields)
        {
            bool is_valid = true;
            var SortedFields = fields.OrderBy(f => f.TabIndex);
            foreach (var Field in SortedFields)
            {
                if (Field.Text == string.Empty)
                {
                    MessageBox.Show($"{Field.Tag} cannot be empty!", "compulsory field", MessageBoxButtons.OK);
                    Field.Focus();
                    is_valid = false;
                    break;
                }
            }
            return is_valid;
        }

        public static void reset_fields(Form form)
        {
            foreach (var c in form.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }
            }
        }

        public static string encrypt_password(string plain_password)
        {
            return plain_password.GetMD5(EncodingType.UTF8);
        }

        public static bool validate_ipaddress(string IPAddressString)
        {
            bool isIPValid = true;
            try
            {
                IPAddress iPAddress = IPAddress.Parse(IPAddressString);

                string[] splitValues = IPAddressString.Split(".");
                if (splitValues.Length != 4)
                {
                    isIPValid = false;
                }

                foreach (var splitValue in splitValues)
                {
                    if ((int.Parse(splitValue) < 0) || (int.Parse(splitValue) > 255))
                    {
                        isIPValid = false;
                        break;
                    }
                }
            }
            catch (Exception e)
            {
                isIPValid = false;
            }

            
            return isIPValid;
        }

        public static bool IsValidPort(int port_number)
        {
            // Port must be between 0 and 65535 (inclusive)
            return port_number >= 0 && port_number <= 65535;
        }

        public static bool is_matching(string first_string, string second_string)
        {
            if (String.IsNullOrEmpty(first_string) || String.IsNullOrEmpty(first_string))
                return false;
            else if (first_string != second_string)
                return false;
            else return true;
        }

        internal static Dictionary<string, MessageBoxButtons> get_button_type()
        {
            Dictionary<string, MessageBoxButtons> buttonType = new Dictionary<string, MessageBoxButtons>();
            buttonType.Add(MessageStatus.SUCCESS, MessageBoxButtons.OK);
            buttonType.Add(MessageStatus.ERROR, MessageBoxButtons.RetryCancel);
            return buttonType;
        }

        internal static Dictionary<string, MessageBoxIcon> get_icon_type()
        {
            Dictionary<string, MessageBoxIcon> iconType = new Dictionary<string, MessageBoxIcon>();
            iconType.Add(MessageStatus.SUCCESS, MessageBoxIcon.Information);
            iconType.Add(MessageStatus.ERROR, MessageBoxIcon.Error);
            return iconType;
        }

        public static void write_message(string message, string title, string message_type)
        {
            MessageBox.Show(message, title, get_button_type()[message_type], get_icon_type()[message_type]);
        }

        public void logout()
        {
            throw new NotImplementedException();
        }

        public static void writelog(LogEntry log)
        {
            throw new NotImplementedException();
        }
    }

    public static class Status
    {
        public const string CONNECTED = "CONNECTED";
        public const string DISCONNECTED = "DISCONNECTED";
        public const string CONNECT = "CONNECT";
        public const string DISCONNECT = "DISCONNECT";
    }

    public static class MessageStatus
    {
        public const string ERROR = "ERROR";
        public const string SUCCESS = "SUCCESS";
    }

    public class LogEntry
    {
        public DateTime Timestamp { get; set; }
        public string IPAddress { get; set; }
        public string Message { get; set; }
    }

    public class FileData
    {
        public string FileName { get; set; }
        public string Extension { get; set; }
    }
}
