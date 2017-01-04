namespace Visualization_of_Temperature_Flow
{
    partial class Form1
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
            this.Room = new BufferPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.OtherValuet = new System.Windows.Forms.TextBox();
            this.OtherValue = new System.Windows.Forms.Label();
            this.OtherRadio = new System.Windows.Forms.RadioButton();
            this.MessageHintRadio = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CellSide = new System.Windows.Forms.TextBox();
            this.Windowrd = new System.Windows.Forms.RadioButton();
            this.NormalCellrd = new System.Windows.Forms.RadioButton();
            this.ColodSourcerd = new System.Windows.Forms.RadioButton();
            this.HeatSourcerd = new System.Windows.Forms.RadioButton();
            this.Blockrd = new System.Windows.Forms.RadioButton();
            this.VisulazingSystembt = new System.Windows.Forms.Button();
            this.ExitSystem = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.NumThread = new System.Windows.Forms.TextBox();
            this.Therad = new System.Windows.Forms.Label();
            this.Parallel2 = new System.Windows.Forms.RadioButton();
            this.Parallel1 = new System.Windows.Forms.RadioButton();
            this.SequentialRadio = new System.Windows.Forms.RadioButton();
            this.ColorMapping1 = new Color_Mapping.UserControl1();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Room
            // 
            this.Room.Location = new System.Drawing.Point(6, 10);
            this.Room.Name = "Room";
            this.Room.Size = new System.Drawing.Size(800, 579);
            this.Room.TabIndex = 1;
            this.Room.Paint += new System.Windows.Forms.PaintEventHandler(this.Room_Paint);
            this.Room.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Room_MouseClick);
            this.Room.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Room_MouseMove);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OtherValuet);
            this.groupBox1.Controls.Add(this.OtherValue);
            this.groupBox1.Controls.Add(this.OtherRadio);
            this.groupBox1.Controls.Add(this.MessageHintRadio);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CellSide);
            this.groupBox1.Controls.Add(this.Windowrd);
            this.groupBox1.Controls.Add(this.NormalCellrd);
            this.groupBox1.Controls.Add(this.ColodSourcerd);
            this.groupBox1.Controls.Add(this.HeatSourcerd);
            this.groupBox1.Controls.Add(this.Blockrd);
            this.groupBox1.Location = new System.Drawing.Point(817, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 238);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cells";
            // 
            // OtherValuet
            // 
            this.OtherValuet.Location = new System.Drawing.Point(69, 183);
            this.OtherValuet.Name = "OtherValuet";
            this.OtherValuet.Size = new System.Drawing.Size(41, 20);
            this.OtherValuet.TabIndex = 14;
            // 
            // OtherValue
            // 
            this.OtherValue.AutoSize = true;
            this.OtherValue.Location = new System.Drawing.Point(3, 186);
            this.OtherValue.Name = "OtherValue";
            this.OtherValue.Size = new System.Drawing.Size(60, 13);
            this.OtherValue.TabIndex = 13;
            this.OtherValue.Text = "OtherValue";
            // 
            // OtherRadio
            // 
            this.OtherRadio.AutoSize = true;
            this.OtherRadio.Location = new System.Drawing.Point(6, 134);
            this.OtherRadio.Name = "OtherRadio";
            this.OtherRadio.Size = new System.Drawing.Size(68, 17);
            this.OtherRadio.TabIndex = 12;
            this.OtherRadio.TabStop = true;
            this.OtherRadio.Text = "OtherCell";
            this.OtherRadio.UseVisualStyleBackColor = true;
            // 
            // MessageHintRadio
            // 
            this.MessageHintRadio.AutoSize = true;
            this.MessageHintRadio.Location = new System.Drawing.Point(6, 157);
            this.MessageHintRadio.Name = "MessageHintRadio";
            this.MessageHintRadio.Size = new System.Drawing.Size(87, 17);
            this.MessageHintRadio.TabIndex = 11;
            this.MessageHintRadio.TabStop = true;
            this.MessageHintRadio.Text = "MessageHint";
            this.MessageHintRadio.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(85, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Side";
            // 
            // CellSide
            // 
            this.CellSide.Location = new System.Drawing.Point(38, 210);
            this.CellSide.Name = "CellSide";
            this.CellSide.Size = new System.Drawing.Size(41, 20);
            this.CellSide.TabIndex = 5;
            // 
            // Windowrd
            // 
            this.Windowrd.AutoSize = true;
            this.Windowrd.Location = new System.Drawing.Point(6, 111);
            this.Windowrd.Name = "Windowrd";
            this.Windowrd.Size = new System.Drawing.Size(64, 17);
            this.Windowrd.TabIndex = 4;
            this.Windowrd.TabStop = true;
            this.Windowrd.Text = "Window";
            this.Windowrd.UseVisualStyleBackColor = true;
            // 
            // NormalCellrd
            // 
            this.NormalCellrd.AutoSize = true;
            this.NormalCellrd.Location = new System.Drawing.Point(6, 88);
            this.NormalCellrd.Name = "NormalCellrd";
            this.NormalCellrd.Size = new System.Drawing.Size(77, 17);
            this.NormalCellrd.TabIndex = 3;
            this.NormalCellrd.TabStop = true;
            this.NormalCellrd.Text = "Normal cell";
            this.NormalCellrd.UseVisualStyleBackColor = true;
            // 
            // ColodSourcerd
            // 
            this.ColodSourcerd.AutoSize = true;
            this.ColodSourcerd.Location = new System.Drawing.Point(6, 65);
            this.ColodSourcerd.Name = "ColodSourcerd";
            this.ColodSourcerd.Size = new System.Drawing.Size(83, 17);
            this.ColodSourcerd.TabIndex = 2;
            this.ColodSourcerd.TabStop = true;
            this.ColodSourcerd.Text = "Cold Source";
            this.ColodSourcerd.UseVisualStyleBackColor = true;
            // 
            // HeatSourcerd
            // 
            this.HeatSourcerd.AutoSize = true;
            this.HeatSourcerd.Location = new System.Drawing.Point(6, 42);
            this.HeatSourcerd.Name = "HeatSourcerd";
            this.HeatSourcerd.Size = new System.Drawing.Size(85, 17);
            this.HeatSourcerd.TabIndex = 1;
            this.HeatSourcerd.TabStop = true;
            this.HeatSourcerd.Text = "Heat Source";
            this.HeatSourcerd.UseVisualStyleBackColor = true;
            // 
            // Blockrd
            // 
            this.Blockrd.AutoSize = true;
            this.Blockrd.Location = new System.Drawing.Point(6, 19);
            this.Blockrd.Name = "Blockrd";
            this.Blockrd.Size = new System.Drawing.Size(52, 17);
            this.Blockrd.TabIndex = 0;
            this.Blockrd.TabStop = true;
            this.Blockrd.Text = "Block";
            this.Blockrd.UseVisualStyleBackColor = true;
            // 
            // VisulazingSystembt
            // 
            this.VisulazingSystembt.Location = new System.Drawing.Point(817, 566);
            this.VisulazingSystembt.Name = "VisulazingSystembt";
            this.VisulazingSystembt.Size = new System.Drawing.Size(66, 23);
            this.VisulazingSystembt.TabIndex = 4;
            this.VisulazingSystembt.Text = "Start";
            this.VisulazingSystembt.UseVisualStyleBackColor = true;
            this.VisulazingSystembt.Click += new System.EventHandler(this.VisulazingSystembt_Click);
            // 
            // ExitSystem
            // 
            this.ExitSystem.Location = new System.Drawing.Point(905, 566);
            this.ExitSystem.Name = "ExitSystem";
            this.ExitSystem.Size = new System.Drawing.Size(62, 23);
            this.ExitSystem.TabIndex = 7;
            this.ExitSystem.Text = "Exit";
            this.ExitSystem.UseVisualStyleBackColor = true;
            this.ExitSystem.Click += new System.EventHandler(this.ExitSystem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.NumThread);
            this.groupBox2.Controls.Add(this.Therad);
            this.groupBox2.Controls.Add(this.Parallel2);
            this.groupBox2.Controls.Add(this.Parallel1);
            this.groupBox2.Controls.Add(this.SequentialRadio);
            this.groupBox2.Location = new System.Drawing.Point(818, 422);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(150, 123);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // NumThread
            // 
            this.NumThread.Location = new System.Drawing.Point(76, 91);
            this.NumThread.Name = "NumThread";
            this.NumThread.Size = new System.Drawing.Size(41, 20);
            this.NumThread.TabIndex = 12;
            // 
            // Therad
            // 
            this.Therad.AutoSize = true;
            this.Therad.Location = new System.Drawing.Point(7, 94);
            this.Therad.Name = "Therad";
            this.Therad.Size = new System.Drawing.Size(63, 13);
            this.Therad.TabIndex = 11;
            this.Therad.Text = "ThreadNum";
            // 
            // Parallel2
            // 
            this.Parallel2.AutoSize = true;
            this.Parallel2.Location = new System.Drawing.Point(6, 65);
            this.Parallel2.Name = "Parallel2";
            this.Parallel2.Size = new System.Drawing.Size(81, 17);
            this.Parallel2.TabIndex = 2;
            this.Parallel2.TabStop = true;
            this.Parallel2.Text = "Parallel C++";
            this.Parallel2.UseVisualStyleBackColor = true;
            // 
            // Parallel1
            // 
            this.Parallel1.AutoSize = true;
            this.Parallel1.Location = new System.Drawing.Point(7, 42);
            this.Parallel1.Name = "Parallel1";
            this.Parallel1.Size = new System.Drawing.Size(76, 17);
            this.Parallel1.TabIndex = 1;
            this.Parallel1.TabStop = true;
            this.Parallel1.Text = "Parallel C#";
            this.Parallel1.UseVisualStyleBackColor = true;
            // 
            // SequentialRadio
            // 
            this.SequentialRadio.AutoSize = true;
            this.SequentialRadio.Location = new System.Drawing.Point(6, 19);
            this.SequentialRadio.Name = "SequentialRadio";
            this.SequentialRadio.Size = new System.Drawing.Size(75, 17);
            this.SequentialRadio.TabIndex = 0;
            this.SequentialRadio.TabStop = true;
            this.SequentialRadio.Text = "Sequential";
            this.SequentialRadio.UseVisualStyleBackColor = true;
            // 
            // ColorMapping1
            // 
            this.ColorMapping1.Location = new System.Drawing.Point(815, 243);
            this.ColorMapping1.Name = "ColorMapping1";
            this.ColorMapping1.Size = new System.Drawing.Size(159, 184);
            this.ColorMapping1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 601);
            this.Controls.Add(this.ColorMapping1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ExitSystem);
            this.Controls.Add(this.VisulazingSystembt);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Room);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CellSide;
        private System.Windows.Forms.RadioButton Windowrd;
        private System.Windows.Forms.RadioButton NormalCellrd;
        private System.Windows.Forms.RadioButton ColodSourcerd;
        private System.Windows.Forms.RadioButton HeatSourcerd;
        private System.Windows.Forms.RadioButton Blockrd;
        private System.Windows.Forms.Button VisulazingSystembt;
        private System.Windows.Forms.Button ExitSystem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton Parallel2;
        private System.Windows.Forms.RadioButton Parallel1;
        private System.Windows.Forms.RadioButton SequentialRadio;
        private System.Windows.Forms.Label Therad;
        private System.Windows.Forms.TextBox NumThread;
        private System.Windows.Forms.RadioButton MessageHintRadio;
        private System.Windows.Forms.TextBox OtherValuet;
        private System.Windows.Forms.Label OtherValue;
        private System.Windows.Forms.RadioButton OtherRadio;
        private Color_Mapping.UserControl1 ColorMapping1;
        public System.Windows.Forms.Panel Room;
        // public BufferPanel Room;

    }
}

