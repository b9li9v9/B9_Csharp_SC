using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SC_Forms
{
    internal static class FormsManager
    {
        private static Dictionary<string,Form> FormsDict = new Dictionary<string, Form>();
        //private static List<Form> openForms = new List<Form>();

        public static void AddForm(string key, Form form)
        {
            FormsDict[key] = form;
            FormsDict[key].FormClosing += (object sender, FormClosingEventArgs e) =>
            {
                Application.Exit();
            };
        }

        public static void RemoveForm(string key)
        {
            FormsDict.Remove(key);
        }

        public static Form GetForm(string key)
        {
            try
            {
                return FormsDict[key];
            }
            catch
            {
                Debug.WriteLine($"FormsDict[{key}] is null");
                throw;
            }
        }

        public static void ShowSingleForm(string key)
        {
            foreach (var kvp in FormsDict)
            {
                if (kvp.Key == key) kvp.Value.Show();
                else kvp.Value.Hide();
            }
        }
    }
}
