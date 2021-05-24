using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alarm
{
    public partial class Alarm : Form
    {
        public Alarm()
        {
            InitializeComponent();
            alarm_timer.Start();
            txt_alarm.Text = DateTime.Now.ToString("hh:mm:ss");
        }
        string alarm_sound = "";

        bool[] arr_days = new bool[7];

        SoundPlayer player = new SoundPlayer();

        private void txt_now_TextChanged(object sender, EventArgs e)
        {


        }

        private void btn_set_Click(object sender, EventArgs e)
        {
            if (cb_onetime.Checked == true || cb_monday.Checked == true || cb_tuesday.Checked == true || cb_wednesday.Checked == true
                || cb_thursday.Checked == true || cb_friday.Checked == true || cb_saturday.Checked == true || cb_sunday.Checked == true)
            {
                int yoxla = 0;
                if (cb_beepbeep.Checked == true)
                {
                    alarm_sound="bepbep.wav";
                    yoxla++;

                }

                else if (cb_siren.Checked == true)
                {
                    alarm_sound="Siren.wav";
                    yoxla++;
                }
                else if (cb_nature.Checked == true)
                {
                    alarm_sound="Nature.wav";
                    yoxla++;
                }
                else
                {
                    MessageBox.Show("Please select alarm sound");
                }
                if (yoxla!=0)
                {
                    timer_set.Start();
                    MessageBox.Show("Alarm Set");
                }
                
            }
            else
            {
                MessageBox.Show("Please select at least 1 day");
            }
        }

        private void alarm_timer_Tick(object sender, EventArgs e)
        {
            txt_now.Text = DateTime.Now.ToString("hh:mm:ss");
            
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            player.Stop();
        }

        private void btn_days_Click(object sender, EventArgs e)
        {

        }

        private void btn_sound_Click(object sender, EventArgs e)
        {
            
        }

        private void uc_days2_Load(object sender, EventArgs e)
        {

        }

        private void timer_set_Tick(object sender, EventArgs e)
        {
            if (txt_now.Text == txt_alarm.Text)
            {
                int say = 0;
                if (cb_onetime.Checked == true)
                {
                    say++;
                }
                else
                {
                    
                    switch (DateTime.Today.DayOfWeek.ToString())
                    {
                        case "Monday":
                            if (cb_monday.Checked == true)
                            {
                                say++;
                            }
                            break;
                        case "Tuesday":
                            if (cb_tuesday.Checked == true)
                            {
                                say++;
                            }
                            break;
                        case "Wednesday":
                            if (cb_wednesday.Checked == true)
                            {
                                say++;
                            }
                            break;
                        case "Thursday":
                            if (cb_thursday.Checked == true)
                            {
                                say++;
                            }
                            break;
                        case "Friday":
                            if (cb_friday.Checked == true)
                            {
                                say++;
                            }
                            break;
                        case "Saturday":
                            if (cb_saturday.Checked == true)
                            {
                                say++;
                            }
                            break;
                        case "Sunday":
                            if (cb_sunday.Checked == true)
                            {
                                
                            }
                            break;
                        default:
                            break;
                    }
                }
                
                
                if (say==1)
                {
                    player.SoundLocation = alarm_sound;
                    if (cb_power.Checked==true)
                    {
                        player.PlayLooping();
                    }
                    else
                    {
                        player.Play();
                    }
                    
                }
            }

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_wednesday.Checked==true)
            {
                cb_onetime.Checked = false;
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_sunday.Checked==true)
            {
                cb_onetime.Checked = false;
            }
        }

        private void cb_monday_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_monday.Checked==true)
            {
                cb_onetime.Checked = false;
            }
            
        }

        private void cb_tuesday_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_tuesday.Checked==true)
            {
                cb_onetime.Checked = false;
            }

        }

        private void cb_thursday_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_thursday.Checked==true)
            {
                cb_onetime.Checked = false;            }
        }

        private void cb_friday_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_friday.Checked==true)
            {
                cb_onetime.Checked = false;
            }
        }

        private void cb_saturday_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_saturday.Checked==true)
            {
                cb_onetime.Checked = false;
            }
        }

        private void cb_onetime_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_onetime.Checked==true)
            {
                cb_monday.Checked = false;
                cb_tuesday.Checked = false;
                cb_wednesday.Checked = false;
                cb_thursday.Checked = false;
                cb_friday.Checked = false;
                cb_saturday.Checked = false;
                cb_sunday.Checked = false;
            }
        }



        private void cb_beepbeep_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cb_beepbeep.Checked == true)
            {

                cb_nature.Checked = false;
                cb_siren.Checked = false;
            }
        }

        private void cb_nature_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_nature.Checked == true)
            {
                cb_beepbeep.Checked = false;
                cb_siren.Checked = false;
            }
        }

        private void cb_siren_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cb_siren.Checked == true)
            {
                cb_nature.Checked = false;
                cb_beepbeep.Checked = false;
            }
        }
    }
}
