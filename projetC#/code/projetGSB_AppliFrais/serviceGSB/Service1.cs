using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using projetGSB_AppliFrais;

namespace serviceGSB
{
    public partial class serviceGsb : ServiceBase
    {
        private Timer t = null;

        public serviceGsb()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            t = new Timer(30000); // Timer de 30 secondes.
            t.Elapsed += new ElapsedEventHandler(t_Elapsed);
            t.Start();

        }

        protected override void OnStop()
        {
        }

        protected override void OnShutdown()
        {
            base.OnShutdown();
        }

        protected override void OnPause()
        {
            base.OnPause();
        }

        protected override void OnContinue()
        {
            base.OnContinue();
        }

        protected void t_Elapsed(object sender, EventArgs e)
        {
            projetGSB_AppliFrais.Program.Main();
        }
    }


}


