using AxWMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoToBed
{
    public partial class Sexer : Form
    {


        public Sexer()
        {
            InitializeComponent();
            sexerPlayer.URL = "https://portalsam.net/wp-content/uploads/2022/03/ytp-sexer.mp4";
            sexerPlayer.Ctlcontrols.play();
            sexerPlayer.uiMode = "none";
            sexerPlayer.settings.setMode("loop", true);
        }

        private void sexerPlayer_Enter(object sender, EventArgs e)
        {

        }
    }
}
