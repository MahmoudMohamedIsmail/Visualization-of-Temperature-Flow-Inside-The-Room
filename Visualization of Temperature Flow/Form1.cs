using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Visualization_of_Temperature_Flow
{
    public partial class Form1 : Form
    {
        bool flag = false,click=false;
        Room room;

        public Form1()
        {
            InitializeComponent();
        }

        private void Room_Paint(object sender, PaintEventArgs e)
        {           
                if (flag)
                {
                    for (int row = 0; row <= room.Rows; row++)
                    {
                        for (int col = 0; col <= room.Cols; col++)
                        {

                            if (room.Cells[row, col].Block)
                            {
                                //Draw Black Rectangle
                                e.Graphics.FillRectangle(new SolidBrush(Color.Black), room.Cells[row, col].X, room.Cells[row, col].Y, room.Cells[row, col].Side, room.Cells[row, col].Side);
                            }
                            else
                            {
                                double r = 0, b = 0, g = 0;
                                //To avoid RunTime Changing in TextBox
                                if (ColorMapping1.Smin.Text == "" || ColorMapping1.Smax.Text == "")
                                {
                                    ColorMapping1.Smin.Text = "0";
                                    ColorMapping1.Smax.Text = "100";
                                }
                                    //Get ValueToColor
                                    ColorMapping1.functions.ValueToColor(room.Cells[row, col].Value, double.Parse(ColorMapping1.Smin.Text), double.Parse(ColorMapping1.Smax.Text), ColorMapping1.Color_Grid.SelectedIndex, out r, out g, out b);
                                

                                //Draw Cell
                                Color color = Color.FromArgb((int)r, (int)g, (int)b);
                                e.Graphics.FillRectangle(new SolidBrush(color), room.Cells[row, col].X, room.Cells[row, col].Y, room.Cells[row, col].Side, room.Cells[row, col].Side);

                                if (room.Cells[row, col].Window)
                                {
                                    e.Graphics.DrawRectangle(new Pen(Color.Black), room.Cells[row, col].X, room.Cells[row, col].Y, room.Cells[row, col].Side - 1, room.Cells[row, col].Side - 1);

                                }
                                else if (room.Cells[row, col].Other)
                                {
                                    e.Graphics.DrawRectangle(new Pen(Color.White), room.Cells[row, col].X, room.Cells[row, col].Y, room.Cells[row, col].Side - 1, room.Cells[row, col].Side - 1);

                                }
                            }
                        }
                    }
                }            
        }
        private void VisulazingSystembt_Click(object sender, EventArgs e)
        {

           
            click = !click;
            room.form = this;
            room.Work = click;
            if (click)
            {
                VisulazingSystembt.Text = "STOP";
            }
            else
            {
                VisulazingSystembt.Text = "START";
            }
            if (SequentialRadio.Checked)
            {
                Thread Update = new Thread(new ThreadStart(room.Sequential));
                Update.Start();
            }
            else if (Parallel1.Checked)
            {
                if (NumThread.Text != "")
                    room.threads = int.Parse(NumThread.Text);
                Thread Update = new Thread(new ThreadStart(room.Parallels));
                Update.Start();

            }
            else if (Parallel2.Checked)
            { }
           
            
        }

        private void ExitSystem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CellSide.Text != "" && ColorMapping1.Smin.Text != "" && ColorMapping1.Smax.Text != "")
            {

                room = new Room(int.Parse(CellSide.Text), int.Parse(ColorMapping1.Smin.Text), int.Parse(ColorMapping1.Smax.Text));
                flag = true;
                Room.Invalidate();
            }
            else {
                MessageBox.Show("Plz Enter Data");
            }

        }

        private void Room_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left&&ColorMapping1.Smin.Text != "" && ColorMapping1.Smax.Text != "")
            {

                if (Blockrd.Checked)
                {
                    room.UpdateCell(e.Y / room.Side, e.X / room.Side,"Block",0);

                }
                else if (Windowrd.Checked)
                {
                    room.UpdateCell(e.Y / room.Side, e.X / room.Side, "Window", (double.Parse(ColorMapping1.Smin.Text) + double.Parse(ColorMapping1.Smax.Text)) / 2f);
                }
                else if (ColodSourcerd.Checked)
                {
                    room.UpdateCell(e.Y / room.Side, e.X / room.Side, "Cold", double.Parse(ColorMapping1.Smin.Text));
                }
                else if (HeatSourcerd.Checked)
                {
                    room.UpdateCell(e.Y / room.Side, e.X / room.Side, "Heat", double.Parse(ColorMapping1.Smax.Text));
                }
                else if (NormalCellrd.Checked)
                {
                    room.UpdateCell(e.Y / room.Side, e.X / room.Side, "Normal", (double.Parse(ColorMapping1.Smin.Text) + double.Parse(ColorMapping1.Smax.Text)) / 2f);
                }
                else if (OtherRadio.Checked)
                {
                    if (OtherValuet.Text != "")
                    {
                        room.UpdateCell(e.Y / room.Side, e.X / room.Side, "Window", double.Parse(OtherValuet.Text));
                    }
                    else
                    {
                        MessageBox.Show("Enter value of Cell");
                    }
                }
              
                Room.Invalidate();
            }
          
        }

        private void Room_MouseClick(object sender, MouseEventArgs e)
        {
            if (Blockrd.Checked && ColorMapping1.Smin.Text != "" && ColorMapping1.Smax.Text != "")
            {
                room.UpdateCell(e.Y / room.Side, e.X / room.Side, "Block", 0);

            }
            else if (Windowrd.Checked && ColorMapping1.Smin.Text != "" && ColorMapping1.Smax.Text != "")
            {
                room.UpdateCell(e.Y / room.Side, e.X / room.Side, "Window", (double.Parse(ColorMapping1.Smin.Text) + double.Parse(ColorMapping1.Smax.Text)) / 2f);
            }
            else if (ColodSourcerd.Checked && ColorMapping1.Smin.Text != "" && ColorMapping1.Smax.Text != "")
            {
                room.UpdateCell(e.Y / room.Side, e.X / room.Side, "Cold", double.Parse(ColorMapping1.Smin.Text));
            }
            else if (HeatSourcerd.Checked && ColorMapping1.Smin.Text != "" && ColorMapping1.Smax.Text != "")
            {
                room.UpdateCell(e.Y / room.Side, e.X / room.Side, "Heat", double.Parse(ColorMapping1.Smax.Text));
            }
            else if (NormalCellrd.Checked && ColorMapping1.Smin.Text != "" && ColorMapping1.Smax.Text != "")
            {
                room.UpdateCell(e.Y / room.Side, e.X / room.Side, "Normal", (double.Parse(ColorMapping1.Smin.Text) + double.Parse(ColorMapping1.Smax.Text)) / 2f);
            }
            else if (OtherRadio.Checked && ColorMapping1.Smin.Text != "" && ColorMapping1.Smax.Text != "")
            {
                if (OtherValuet.Text != "" && ColorMapping1.Smin.Text != "" && ColorMapping1.Smax.Text != "")
                {
                    room.UpdateCell(e.Y / room.Side, e.X / room.Side, "Window", double.Parse(OtherValuet.Text));
                }
                else
                {
                    MessageBox.Show("Enter value of Cell");
                }
            }
            //Display Message Hint
            if (MessageHintRadio.Checked)
            {
                ToolTip message = new ToolTip();
                message.Show(room.Cells[e.Y / room.Side, e.X / room.Side].Value.ToString(), Room, e.X, e.Y, 1000);
            }
            Room.Invalidate();

        }   
        private void Form1_Load(object sender, EventArgs e)
        {
          
        } 
    }
}
