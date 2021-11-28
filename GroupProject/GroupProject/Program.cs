using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupProject
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ConnectionManager conMan = new ConnectionManager(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = PrimaryData; Integrated Security = True; Persist Security Info = False; Pooling = False; MultipleActiveResultSets = False; Connect Timeout = 60; Encrypt = False; TrustServerCertificate = False");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SeasonView dv = new SeasonView(conMan);

            Application.Run(dv);
        }
    }
}
