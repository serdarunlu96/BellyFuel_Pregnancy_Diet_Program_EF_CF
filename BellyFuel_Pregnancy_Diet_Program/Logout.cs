using BellyFuel_Pregnancy_Diet_Program.Context;
using BellyFuel_Pregnancy_Diet_Program.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace BellyFuel_Pregnancy_Diet_Program
{
    public partial class Logout : Form
    {
        BellyFuelDbContext db = new BellyFuelDbContext();
        private readonly User user;
        public Logout(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void Logout_Load(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Interval = 1500; // 1.5 saniye
            timer.Enabled = true;
            timer.Tick += timer1_Tick;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }





}
