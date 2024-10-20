using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using MD5Hash;

namespace Multilevel
{
    public class Library: Form
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
    }

}
