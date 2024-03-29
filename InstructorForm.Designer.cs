﻿namespace AttendanceV2
{
    partial class InstructorForm
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
            this.label_currentTime = new System.Windows.Forms.Label();
            this.label_currentDate = new System.Windows.Forms.Label();
            this.Btn_logout = new System.Windows.Forms.Button();
            this.label_hello = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.TimePicker_end = new System.Windows.Forms.DateTimePicker();
            this.TimePicker_start = new System.Windows.Forms.DateTimePicker();
            this.Input_eventName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label_instructor = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_create = new System.Windows.Forms.Button();
            this.label_currentEvent = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.Grid_eventsList = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Selection_attendHistory = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.Grid_attendanceHistory = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_eventsList)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_attendanceHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_currentTime
            // 
            this.label_currentTime.AutoSize = true;
            this.label_currentTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_currentTime.Location = new System.Drawing.Point(38, 867);
            this.label_currentTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_currentTime.Name = "label_currentTime";
            this.label_currentTime.Size = new System.Drawing.Size(167, 31);
            this.label_currentTime.TabIndex = 17;
            this.label_currentTime.Text = "09:45:00 AM";
            // 
            // label_currentDate
            // 
            this.label_currentDate.AutoSize = true;
            this.label_currentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_currentDate.Location = new System.Drawing.Point(230, 867);
            this.label_currentDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_currentDate.Name = "label_currentDate";
            this.label_currentDate.Size = new System.Drawing.Size(311, 31);
            this.label_currentDate.TabIndex = 16;
            this.label_currentDate.Text = "Monday, 1 January 2024";
            // 
            // Btn_logout
            // 
            this.Btn_logout.BackColor = System.Drawing.Color.Red;
            this.Btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_logout.ForeColor = System.Drawing.Color.White;
            this.Btn_logout.Location = new System.Drawing.Point(1020, 858);
            this.Btn_logout.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_logout.Name = "Btn_logout";
            this.Btn_logout.Size = new System.Drawing.Size(105, 51);
            this.Btn_logout.TabIndex = 5;
            this.Btn_logout.Text = "Logout";
            this.Btn_logout.UseVisualStyleBackColor = false;
            this.Btn_logout.Click += new System.EventHandler(this.Btn_logout_Click);
            // 
            // label_hello
            // 
            this.label_hello.AutoSize = true;
            this.label_hello.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hello.Location = new System.Drawing.Point(38, 31);
            this.label_hello.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_hello.Name = "label_hello";
            this.label_hello.Size = new System.Drawing.Size(136, 31);
            this.label_hello.TabIndex = 14;
            this.label_hello.Text = "Hai, User!";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(36, 83);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1097, 761);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.TimePicker_end);
            this.tabPage1.Controls.Add(this.TimePicker_start);
            this.tabPage1.Controls.Add(this.Input_eventName);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label_instructor);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.Btn_create);
            this.tabPage1.Controls.Add(this.label_currentEvent);
            this.tabPage1.Location = new System.Drawing.Point(8, 43);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1081, 710);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Create Schedule";
            // 
            // TimePicker_end
            // 
            this.TimePicker_end.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimePicker_end.Location = new System.Drawing.Point(669, 211);
            this.TimePicker_end.Margin = new System.Windows.Forms.Padding(4);
            this.TimePicker_end.MaximumSize = new System.Drawing.Size(4, 30);
            this.TimePicker_end.MinimumSize = new System.Drawing.Size(319, 24);
            this.TimePicker_end.Name = "TimePicker_end";
            this.TimePicker_end.Size = new System.Drawing.Size(319, 30);
            this.TimePicker_end.TabIndex = 19;
            // 
            // TimePicker_start
            // 
            this.TimePicker_start.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimePicker_start.Location = new System.Drawing.Point(253, 211);
            this.TimePicker_start.Margin = new System.Windows.Forms.Padding(4);
            this.TimePicker_start.MaximumSize = new System.Drawing.Size(4, 30);
            this.TimePicker_start.MinimumSize = new System.Drawing.Size(319, 24);
            this.TimePicker_start.Name = "TimePicker_start";
            this.TimePicker_start.Size = new System.Drawing.Size(319, 30);
            this.TimePicker_start.TabIndex = 18;
            // 
            // Input_eventName
            // 
            this.Input_eventName.Location = new System.Drawing.Point(253, 136);
            this.Input_eventName.Margin = new System.Windows.Forms.Padding(4);
            this.Input_eventName.MinimumSize = new System.Drawing.Size(732, 30);
            this.Input_eventName.Name = "Input_eventName";
            this.Input_eventName.Size = new System.Drawing.Size(735, 35);
            this.Input_eventName.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(220, 281);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 31);
            this.label10.TabIndex = 17;
            this.label10.Text = ":";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(220, 211);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 31);
            this.label9.TabIndex = 16;
            this.label9.Text = ":";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(220, 136);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 31);
            this.label8.TabIndex = 15;
            this.label8.Text = ":";
            // 
            // label_instructor
            // 
            this.label_instructor.AutoSize = true;
            this.label_instructor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_instructor.Location = new System.Drawing.Point(263, 281);
            this.label_instructor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_instructor.MinimumSize = new System.Drawing.Size(333, 38);
            this.label_instructor.Name = "label_instructor";
            this.label_instructor.Size = new System.Drawing.Size(333, 38);
            this.label_instructor.TabIndex = 14;
            this.label_instructor.Text = "[Default instructor]";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(83, 281);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 31);
            this.label6.TabIndex = 13;
            this.label6.Text = "Instructor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(611, 211);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 31);
            this.label5.TabIndex = 12;
            this.label5.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(83, 211);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 31);
            this.label4.TabIndex = 11;
            this.label4.Text = "Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(83, 136);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 31);
            this.label3.TabIndex = 10;
            this.label3.Text = "Name";
            // 
            // Btn_create
            // 
            this.Btn_create.Location = new System.Drawing.Point(763, 339);
            this.Btn_create.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_create.MinimumSize = new System.Drawing.Size(227, 62);
            this.Btn_create.Name = "Btn_create";
            this.Btn_create.Size = new System.Drawing.Size(227, 62);
            this.Btn_create.TabIndex = 4;
            this.Btn_create.Text = "Create event";
            this.Btn_create.UseVisualStyleBackColor = true;
            this.Btn_create.Click += new System.EventHandler(this.Btn_create_Click);
            // 
            // label_currentEvent
            // 
            this.label_currentEvent.AutoSize = true;
            this.label_currentEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_currentEvent.Location = new System.Drawing.Point(405, 51);
            this.label_currentEvent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_currentEvent.Name = "label_currentEvent";
            this.label_currentEvent.Size = new System.Drawing.Size(326, 37);
            this.label_currentEvent.TabIndex = 5;
            this.label_currentEvent.Text = "Create an Schedule:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.Grid_eventsList);
            this.tabPage2.Location = new System.Drawing.Point(8, 43);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1081, 710);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "List of Schedule";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(965, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.MinimumSize = new System.Drawing.Size(107, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 44);
            this.button1.TabIndex = 16;
            this.button1.Text = "Export";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Grid_eventsList
            // 
            this.Grid_eventsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid_eventsList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Grid_eventsList.BackgroundColor = System.Drawing.Color.White;
            this.Grid_eventsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_eventsList.Location = new System.Drawing.Point(0, 72);
            this.Grid_eventsList.Margin = new System.Windows.Forms.Padding(4);
            this.Grid_eventsList.Name = "Grid_eventsList";
            this.Grid_eventsList.RowHeadersWidth = 62;
            this.Grid_eventsList.RowTemplate.Height = 28;
            this.Grid_eventsList.Size = new System.Drawing.Size(1087, 644);
            this.Grid_eventsList.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.Selection_attendHistory);
            this.tabPage4.Controls.Add(this.button2);
            this.tabPage4.Controls.Add(this.Grid_attendanceHistory);
            this.tabPage4.Location = new System.Drawing.Point(8, 43);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage4.Size = new System.Drawing.Size(1081, 710);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Schedule attendance history";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(255, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 31);
            this.label1.TabIndex = 20;
            this.label1.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 31);
            this.label2.TabIndex = 19;
            this.label2.Text = "Select an schedule";
            // 
            // Selection_attendHistory
            // 
            this.Selection_attendHistory.FormattingEnabled = true;
            this.Selection_attendHistory.Location = new System.Drawing.Point(290, 17);
            this.Selection_attendHistory.Margin = new System.Windows.Forms.Padding(4);
            this.Selection_attendHistory.Name = "Selection_attendHistory";
            this.Selection_attendHistory.Size = new System.Drawing.Size(307, 37);
            this.Selection_attendHistory.TabIndex = 18;
            this.Selection_attendHistory.SelectedIndexChanged += new System.EventHandler(this.Selection_attendHistory_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(965, 15);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.MinimumSize = new System.Drawing.Size(107, 44);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 44);
            this.button2.TabIndex = 17;
            this.button2.Text = "Export";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Grid_attendanceHistory
            // 
            this.Grid_attendanceHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid_attendanceHistory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Grid_attendanceHistory.BackgroundColor = System.Drawing.Color.White;
            this.Grid_attendanceHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_attendanceHistory.Location = new System.Drawing.Point(0, 72);
            this.Grid_attendanceHistory.Margin = new System.Windows.Forms.Padding(4);
            this.Grid_attendanceHistory.Name = "Grid_attendanceHistory";
            this.Grid_attendanceHistory.RowHeadersWidth = 62;
            this.Grid_attendanceHistory.RowTemplate.Height = 28;
            this.Grid_attendanceHistory.Size = new System.Drawing.Size(1087, 644);
            this.Grid_attendanceHistory.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AttendanceSystem.Properties.Resources.study;
            this.pictureBox1.Location = new System.Drawing.Point(1040, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // InstructorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1174, 931);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_currentTime);
            this.Controls.Add(this.label_currentDate);
            this.Controls.Add(this.Btn_logout);
            this.Controls.Add(this.label_hello);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "InstructorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Instructor Page";
            this.Load += new System.EventHandler(this.InstructorForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_eventsList)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_attendanceHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_currentTime;
        private System.Windows.Forms.Label label_currentDate;
        private System.Windows.Forms.Button Btn_logout;
        private System.Windows.Forms.Label label_hello;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Btn_create;
        private System.Windows.Forms.Label label_currentEvent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_instructor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Input_eventName;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView Grid_eventsList;
        private System.Windows.Forms.DateTimePicker TimePicker_start;
        private System.Windows.Forms.DateTimePicker TimePicker_end;
        private System.Windows.Forms.DataGridView Grid_attendanceHistory;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox Selection_attendHistory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}