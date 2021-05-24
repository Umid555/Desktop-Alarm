namespace Alarm
{
    partial class Alarm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txt_now = new System.Windows.Forms.TextBox();
            this.btn_set = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.txt_alarm = new System.Windows.Forms.TextBox();
            this.alarm_timer = new System.Windows.Forms.Timer(this.components);
            this.timer_set = new System.Windows.Forms.Timer(this.components);
            this.cb_onetime = new System.Windows.Forms.CheckBox();
            this.cb_sunday = new System.Windows.Forms.CheckBox();
            this.cb_saturday = new System.Windows.Forms.CheckBox();
            this.cb_thursday = new System.Windows.Forms.CheckBox();
            this.cb_wednesday = new System.Windows.Forms.CheckBox();
            this.cb_tuesday = new System.Windows.Forms.CheckBox();
            this.cb_friday = new System.Windows.Forms.CheckBox();
            this.cb_monday = new System.Windows.Forms.CheckBox();
            this.gb_days = new System.Windows.Forms.GroupBox();
            this.gb_sound = new System.Windows.Forms.GroupBox();
            this.cb_beepbeep = new System.Windows.Forms.CheckBox();
            this.cb_siren = new System.Windows.Forms.CheckBox();
            this.cb_nature = new System.Windows.Forms.CheckBox();
            this.cb_power = new System.Windows.Forms.CheckBox();
            this.gb_days.SuspendLayout();
            this.gb_sound.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_now
            // 
            this.txt_now.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_now.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_now.Enabled = false;
            this.txt_now.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_now.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_now.Location = new System.Drawing.Point(45, 44);
            this.txt_now.Name = "txt_now";
            this.txt_now.Size = new System.Drawing.Size(215, 33);
            this.txt_now.TabIndex = 1;
            this.txt_now.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_now.TextChanged += new System.EventHandler(this.txt_now_TextChanged);
            // 
            // btn_set
            // 
            this.btn_set.FlatAppearance.BorderSize = 2;
            this.btn_set.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_set.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_set.Location = new System.Drawing.Point(45, 154);
            this.btn_set.Name = "btn_set";
            this.btn_set.Size = new System.Drawing.Size(215, 54);
            this.btn_set.TabIndex = 3;
            this.btn_set.Text = "Set Alarm";
            this.btn_set.UseVisualStyleBackColor = true;
            this.btn_set.Click += new System.EventHandler(this.btn_set_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_stop.FlatAppearance.BorderSize = 2;
            this.btn_stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stop.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_stop.ForeColor = System.Drawing.Color.Red;
            this.btn_stop.Location = new System.Drawing.Point(45, 234);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(215, 54);
            this.btn_stop.TabIndex = 4;
            this.btn_stop.Text = "Stop Alarm";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // txt_alarm
            // 
            this.txt_alarm.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_alarm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_alarm.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_alarm.Location = new System.Drawing.Point(45, 95);
            this.txt_alarm.Name = "txt_alarm";
            this.txt_alarm.Size = new System.Drawing.Size(215, 33);
            this.txt_alarm.TabIndex = 5;
            this.txt_alarm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // alarm_timer
            // 
            this.alarm_timer.Interval = 200;
            this.alarm_timer.Tick += new System.EventHandler(this.alarm_timer_Tick);
            // 
            // timer_set
            // 
            this.timer_set.Interval = 1000;
            this.timer_set.Tick += new System.EventHandler(this.timer_set_Tick);
            // 
            // cb_onetime
            // 
            this.cb_onetime.AutoSize = true;
            this.cb_onetime.Checked = true;
            this.cb_onetime.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_onetime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_onetime.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cb_onetime.Location = new System.Drawing.Point(17, 32);
            this.cb_onetime.Name = "cb_onetime";
            this.cb_onetime.Size = new System.Drawing.Size(137, 24);
            this.cb_onetime.TabIndex = 4;
            this.cb_onetime.Text = "Only one time";
            this.cb_onetime.UseVisualStyleBackColor = true;
            this.cb_onetime.CheckedChanged += new System.EventHandler(this.cb_onetime_CheckedChanged);
            // 
            // cb_sunday
            // 
            this.cb_sunday.AutoSize = true;
            this.cb_sunday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_sunday.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cb_sunday.Location = new System.Drawing.Point(16, 243);
            this.cb_sunday.Name = "cb_sunday";
            this.cb_sunday.Size = new System.Drawing.Size(88, 24);
            this.cb_sunday.TabIndex = 3;
            this.cb_sunday.Text = "Sunday";
            this.cb_sunday.UseVisualStyleBackColor = true;
            this.cb_sunday.CheckedChanged += new System.EventHandler(this.checkBox7_CheckedChanged);
            // 
            // cb_saturday
            // 
            this.cb_saturday.AutoSize = true;
            this.cb_saturday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_saturday.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cb_saturday.Location = new System.Drawing.Point(16, 213);
            this.cb_saturday.Name = "cb_saturday";
            this.cb_saturday.Size = new System.Drawing.Size(100, 24);
            this.cb_saturday.TabIndex = 2;
            this.cb_saturday.Text = "Saturday";
            this.cb_saturday.UseVisualStyleBackColor = true;
            this.cb_saturday.CheckedChanged += new System.EventHandler(this.cb_saturday_CheckedChanged);
            // 
            // cb_thursday
            // 
            this.cb_thursday.AutoSize = true;
            this.cb_thursday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_thursday.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cb_thursday.Location = new System.Drawing.Point(17, 153);
            this.cb_thursday.Name = "cb_thursday";
            this.cb_thursday.Size = new System.Drawing.Size(101, 24);
            this.cb_thursday.TabIndex = 1;
            this.cb_thursday.Text = "Thursday";
            this.cb_thursday.UseVisualStyleBackColor = true;
            this.cb_thursday.CheckedChanged += new System.EventHandler(this.cb_thursday_CheckedChanged);
            // 
            // cb_wednesday
            // 
            this.cb_wednesday.AutoSize = true;
            this.cb_wednesday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_wednesday.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cb_wednesday.Location = new System.Drawing.Point(16, 122);
            this.cb_wednesday.Name = "cb_wednesday";
            this.cb_wednesday.Size = new System.Drawing.Size(121, 24);
            this.cb_wednesday.TabIndex = 1;
            this.cb_wednesday.Text = "Wednesday";
            this.cb_wednesday.UseVisualStyleBackColor = true;
            this.cb_wednesday.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // cb_tuesday
            // 
            this.cb_tuesday.AutoSize = true;
            this.cb_tuesday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_tuesday.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cb_tuesday.Location = new System.Drawing.Point(16, 92);
            this.cb_tuesday.Name = "cb_tuesday";
            this.cb_tuesday.Size = new System.Drawing.Size(95, 24);
            this.cb_tuesday.TabIndex = 1;
            this.cb_tuesday.Text = "Tuesday";
            this.cb_tuesday.UseVisualStyleBackColor = true;
            this.cb_tuesday.CheckedChanged += new System.EventHandler(this.cb_tuesday_CheckedChanged);
            // 
            // cb_friday
            // 
            this.cb_friday.AutoSize = true;
            this.cb_friday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_friday.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cb_friday.Location = new System.Drawing.Point(17, 183);
            this.cb_friday.Name = "cb_friday";
            this.cb_friday.Size = new System.Drawing.Size(77, 24);
            this.cb_friday.TabIndex = 1;
            this.cb_friday.Text = "Friday";
            this.cb_friday.UseVisualStyleBackColor = true;
            this.cb_friday.CheckedChanged += new System.EventHandler(this.cb_friday_CheckedChanged);
            // 
            // cb_monday
            // 
            this.cb_monday.AutoSize = true;
            this.cb_monday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_monday.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cb_monday.Location = new System.Drawing.Point(16, 62);
            this.cb_monday.Name = "cb_monday";
            this.cb_monday.Size = new System.Drawing.Size(90, 24);
            this.cb_monday.TabIndex = 0;
            this.cb_monday.Text = "Monday";
            this.cb_monday.UseVisualStyleBackColor = true;
            this.cb_monday.CheckedChanged += new System.EventHandler(this.cb_monday_CheckedChanged);
            // 
            // gb_days
            // 
            this.gb_days.Controls.Add(this.cb_thursday);
            this.gb_days.Controls.Add(this.cb_onetime);
            this.gb_days.Controls.Add(this.cb_friday);
            this.gb_days.Controls.Add(this.cb_sunday);
            this.gb_days.Controls.Add(this.cb_monday);
            this.gb_days.Controls.Add(this.cb_tuesday);
            this.gb_days.Controls.Add(this.cb_saturday);
            this.gb_days.Controls.Add(this.cb_wednesday);
            this.gb_days.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gb_days.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gb_days.Location = new System.Drawing.Point(275, 26);
            this.gb_days.Name = "gb_days";
            this.gb_days.Size = new System.Drawing.Size(178, 285);
            this.gb_days.TabIndex = 6;
            this.gb_days.TabStop = false;
            this.gb_days.Text = "Days";
            // 
            // gb_sound
            // 
            this.gb_sound.Controls.Add(this.cb_beepbeep);
            this.gb_sound.Controls.Add(this.cb_siren);
            this.gb_sound.Controls.Add(this.cb_nature);
            this.gb_sound.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gb_sound.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gb_sound.Location = new System.Drawing.Point(469, 26);
            this.gb_sound.Name = "gb_sound";
            this.gb_sound.Size = new System.Drawing.Size(174, 237);
            this.gb_sound.TabIndex = 7;
            this.gb_sound.TabStop = false;
            this.gb_sound.Text = "Sounds";
            // 
            // cb_beepbeep
            // 
            this.cb_beepbeep.AutoSize = true;
            this.cb_beepbeep.Checked = true;
            this.cb_beepbeep.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_beepbeep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_beepbeep.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cb_beepbeep.Location = new System.Drawing.Point(24, 32);
            this.cb_beepbeep.Name = "cb_beepbeep";
            this.cb_beepbeep.Size = new System.Drawing.Size(115, 24);
            this.cb_beepbeep.TabIndex = 4;
            this.cb_beepbeep.Text = "Beep beep";
            this.cb_beepbeep.UseVisualStyleBackColor = true;
            this.cb_beepbeep.CheckedChanged += new System.EventHandler(this.cb_beepbeep_CheckedChanged_1);
            // 
            // cb_siren
            // 
            this.cb_siren.AutoSize = true;
            this.cb_siren.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_siren.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cb_siren.Location = new System.Drawing.Point(23, 62);
            this.cb_siren.Name = "cb_siren";
            this.cb_siren.Size = new System.Drawing.Size(70, 24);
            this.cb_siren.TabIndex = 0;
            this.cb_siren.Text = "Siren";
            this.cb_siren.UseVisualStyleBackColor = true;
            this.cb_siren.CheckedChanged += new System.EventHandler(this.cb_siren_CheckedChanged_1);
            // 
            // cb_nature
            // 
            this.cb_nature.AutoSize = true;
            this.cb_nature.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_nature.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cb_nature.Location = new System.Drawing.Point(23, 92);
            this.cb_nature.Name = "cb_nature";
            this.cb_nature.Size = new System.Drawing.Size(82, 24);
            this.cb_nature.TabIndex = 1;
            this.cb_nature.Text = "Nature";
            this.cb_nature.UseVisualStyleBackColor = true;
            this.cb_nature.CheckedChanged += new System.EventHandler(this.cb_nature_CheckedChanged);
            // 
            // cb_power
            // 
            this.cb_power.AutoSize = true;
            this.cb_power.BackColor = System.Drawing.Color.Transparent;
            this.cb_power.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_power.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cb_power.Location = new System.Drawing.Point(517, 287);
            this.cb_power.Name = "cb_power";
            this.cb_power.Size = new System.Drawing.Size(126, 24);
            this.cb_power.TabIndex = 5;
            this.cb_power.Text = "Power Mode";
            this.cb_power.UseVisualStyleBackColor = false;
            // 
            // Alarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(655, 345);
            this.Controls.Add(this.cb_power);
            this.Controls.Add(this.gb_sound);
            this.Controls.Add(this.gb_days);
            this.Controls.Add(this.txt_alarm);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_set);
            this.Controls.Add(this.txt_now);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Alarm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alarm";
            this.gb_days.ResumeLayout(false);
            this.gb_days.PerformLayout();
            this.gb_sound.ResumeLayout(false);
            this.gb_sound.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_now;
        private System.Windows.Forms.Button btn_set;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.TextBox txt_alarm;
        private System.Windows.Forms.Timer alarm_timer;
        private System.Windows.Forms.Timer timer_set;
        private System.Windows.Forms.CheckBox cb_thursday;
        private System.Windows.Forms.CheckBox cb_wednesday;
        private System.Windows.Forms.CheckBox cb_tuesday;
        private System.Windows.Forms.CheckBox cb_friday;
        private System.Windows.Forms.CheckBox cb_monday;
        private System.Windows.Forms.CheckBox cb_sunday;
        private System.Windows.Forms.CheckBox cb_saturday;
        private System.Windows.Forms.CheckBox cb_onetime;
        private System.Windows.Forms.GroupBox gb_days;
        private System.Windows.Forms.GroupBox gb_sound;
        private System.Windows.Forms.CheckBox cb_beepbeep;
        private System.Windows.Forms.CheckBox cb_siren;
        private System.Windows.Forms.CheckBox cb_nature;
        private System.Windows.Forms.CheckBox cb_power;
    }
}

