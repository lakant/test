using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        // private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();
        private static readonly NLog.Logger Logger = NLog.LogManager.GetLogger("MyTest");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                var o = WindowsIdentity.GetCurrent().User.Value;

                Logger.Trace("My Trace");
                Logger.Debug("My Debug");
                Logger.Info("My Info");
                Logger.Error("My Error");
                Logger.Warn("My Warn");


                throw new Exception("My Error");

                // System.Console.ReadKey();
            }
            catch (Exception ex)
            {
                Logger.Error(ex, "Goodbye cruel world");
            }
            // NLog.LogManager.Shutdown();
        }

        private DateTime _dt = DateTime.Now.AddDays(-10);
        private void timer1_Tick(object sender, EventArgs e)
        {
            var sp = DateTime.Now - _dt;
            this.toolStripStatusLabel1.Text = sp.ToString("d' days, 'hh':'mm':'ss");
        }
    }
}


// targetes, layouts
// https://nlog-project.org/config/?tab=targets