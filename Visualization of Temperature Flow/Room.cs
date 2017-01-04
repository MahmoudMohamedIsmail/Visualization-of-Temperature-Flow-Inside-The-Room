using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading;

namespace Visualization_of_Temperature_Flow
{
    class Room
    {
        public const int Width = 800, Height = 551;
        public int[,] Position=new int[Height+1,Width+1];
        public Cell [,] Cells;
        public int Rows, Cols, Side, time = 50, threads=1;
        public double Smin,Smax;
        public bool Work = true;
        public Form1 form;

        public Room(int side,double Min,double Max)
        {
            Side = side;
            Smin = Min;
            Smax = Max;
            Rows = Height / Side;
            Cols = Width / Side;
            Cells = new Cell[Rows + 1, Cols + 1];
            //Set Cells
            SetRoomCells();
        }

        public void SetRoomCells()
        {
            for (int row = 0; row <=Rows; row++)
            {
                for (int col = 0; col <=Cols; col++)
                {
                    Cells[row, col] = new Cell(Side);
                    Cells[row, col].Value = (Smin + Smax) / 2f;
                    Cells[row, col].X = col * Side;
                    Cells[row, col].Y = row * Side;
                    Cells[row, col].Normal = true;
 
                }
            }
        }
        public void UpdateCell(int row, int col, String State,double value)
        {

            if (State=="Block")
            {
                //Block True
                Cells[row, col].Block = true;
                Cells[row,col].Window = false;
                Cells[row, col].Normal = false;
                Cells[row,col].Cold = false;
                Cells[row,col].Heat = false;
                Cells[row, col].Other = false;


            }
            else if (State=="Window")
            {
                //Window True
                Cells[row, col].Block = false;
                Cells[row, col].Window = true;
                Cells[row, col].Normal = false;
                Cells[row, col].Cold = false;
                Cells[row, col].Heat = false;
                Cells[row, col].Other = false;

                //Change Value
                Cells[row, col].Value =value;


            }
            else if (State == "Cold")
            {
                //Cold True
                Cells[row, col].Block = false;
                Cells[row, col].Window = false;
                Cells[row, col].Normal = false;
                Cells[row, col].Cold = true;
                Cells[row, col].Heat = false;
                Cells[row, col].Other = false;
                //Change Value
                Cells[row, col].Value = value;
            }
            else if (State =="Heat")
            {
                //Heat True
                Cells[row, col].Block = false;
                Cells[row, col].Window = false;
                Cells[row, col].Normal = false;
                Cells[row, col].Cold = false;
                Cells[row, col].Heat = true;
                Cells[row, col].Other = false;

                //Change Value
                Cells[row, col].Value = value;
            }
            else if (State == "Normal")
            {
                //Normal True
                Cells[row, col].Block = false;
                Cells[row, col].Window = false;
                Cells[row, col].Normal = true;
                Cells[row, col].Cold = false;
                Cells[row, col].Heat = false;
                Cells[row, col].Other = false;

                //Change Value
                Cells[row, col].Value = value;
            }
            else if (State == "Other")
            {
                
                    Cells[row, col].Block = false;
                    Cells[row, col].Window = false;
                    Cells[row, col].Normal = false;
                    Cells[row, col].Cold = false;
                    Cells[row, col].Heat = false;
                    Cells[row, col].Other = true;
                    //change Value
                    Cells[row, col].Value = value;
               
            }
        }
        public void UpdateRoomCells()
        {
            for (int row = 0; row <= Rows; row++)
            {
                for (int col = 0; col <= Cols; col++)
                {

                    //Block
                    //Update From Right
                    if (Cells[row, col].Normal)
                    {
                        //continue;
                        // 0 1 2
                        //  3 C 5
                        //   6 7 8

                        int count = 0;
                        double Values = 0;
                        if ((col - 1) >= 0)
                        {
                            //0
                            if ((row - 1) >= 0)
                            {
                                //NOT Block
                                if (!Cells[row - 1, col - 1].Block)
                                {
                                    Values += Cells[row - 1, col - 1].Value;
                                    count++;
                                }
                            }
                            //6
                            if ((row + 1) <= Rows)
                            {
                                //NOT Block
                                if (!Cells[row + 1, col - 1].Block)
                                {
                                    Values+=Cells[row + 1, col - 1].Value;
                                    count++;
                                }
                            }

                            //3
                            if (!Cells[row, col - 1].Block)
                            {
                                Values+=Cells[row, col - 1].Value;
                                count++;
                            }

                        }
                        if ((col + 1) <= Cols)
                        {
                            //2
                            if ((row - 1) >= 0)
                            {
                                //NOT Block
                                if (!Cells[row - 1, col + 1].Block)
                                {
                                    Values+=Cells[row - 1, col + 1].Value;
                                    count++;
                                }

                            }
                            //5
                            if ((row + 1) <= Rows)
                            {
                                //NOT Block
                                if (!Cells[row + 1, col + 1].Block)
                                {
                                   Values+= Cells[row + 1, col + 1].Value;
                                   count++;

                                }
                            }
                            //8
                            if (!Cells[row, col + 1].Block)
                            {
                                Values+=Cells[row, col + 1].Value;
                                count++;

                            }
                        }
                        //1
                        if ((row - 1) >= 0)
                        {
                            //NOT Block
                            if (!Cells[row - 1, col].Block)
                            {
                                Values+=Cells[row - 1, col].Value;
                                count++;
                            }

                        }
                        //7
                        if ((row + 1) <= Rows)
                        {
                            //NOT Block
                            if (!Cells[row + 1, col].Block)
                            {
                              Values+=Cells[row + 1, col].Value;
                              count++;

                            }
                        }

                        if (count>0)
                        {
                            Cells[row, col].Value = (Values / (double)count);
 
                        }
                    
                    
                    }
                    
               
                }
            }  
        }
        public void Sequential()
        {
            while (Work)
            {
                UpdateRoomCells();

                form.Invoke(new MethodInvoker(delegate()
                {
                    form.Room.Invalidate();
                }));
                Thread.Sleep(time);
            }
            
        }
        public void Parallels()
        {
            while (Work)
            {
                Parallel.For(0, Rows, new ParallelOptions { MaxDegreeOfParallelism = threads }, row =>
                {

                    Parallel.For(0, Cols, new ParallelOptions { MaxDegreeOfParallelism = threads }, col =>
                    {

                        //Block
                        //Update From Right
                        if (Cells[row, col].Normal)
                        {
                            //continue;
                            // 0 1 2
                            //  3 C 5
                            //   6 7 8

                            int count = 0;
                            double Values = 0;
                            if ((col - 1) >= 0)
                            {
                                //0
                                if ((row - 1) >= 0)
                                {
                                    //NOT Block
                                    if (!Cells[row - 1, col - 1].Block)
                                    {
                                        Values += Cells[row - 1, col - 1].Value;
                                        count++;
                                    }
                                }
                                //6
                                if ((row + 1) <= Rows)
                                {
                                    //NOT Block
                                    if (!Cells[row + 1, col - 1].Block)
                                    {
                                        Values += Cells[row + 1, col - 1].Value;
                                        count++;
                                    }
                                }

                                //3
                                if (!Cells[row, col - 1].Block)
                                {
                                    Values += Cells[row, col - 1].Value;
                                    count++;
                                }

                            }
                            if ((col + 1) <= Cols)
                            {
                                //2
                                if ((row - 1) >= 0)
                                {
                                    //NOT Block
                                    if (!Cells[row - 1, col + 1].Block)
                                    {
                                        Values += Cells[row - 1, col + 1].Value;
                                        count++;
                                    }

                                }
                                //5
                                if ((row + 1) <= Rows)
                                {
                                    //NOT Block
                                    if (!Cells[row + 1, col + 1].Block)
                                    {
                                        Values += Cells[row + 1, col + 1].Value;
                                        count++;

                                    }
                                }
                                //8
                                if (!Cells[row, col + 1].Block)
                                {
                                    Values += Cells[row, col + 1].Value;
                                    count++;

                                }
                            }
                            //1
                            if ((row - 1) >= 0)
                            {
                                //NOT Block
                                if (!Cells[row - 1, col].Block)
                                {
                                    Values += Cells[row - 1, col].Value;
                                    count++;
                                }

                            }
                            //7
                            if ((row + 1) <= Rows)
                            {
                                //NOT Block
                                if (!Cells[row + 1, col].Block)
                                {
                                    Values += Cells[row + 1, col].Value;
                                    count++;

                                }
                            }

                            if (count > 0)
                            {
                                Cells[row, col].Value = (Values / (double)count);

                            }


                        }


                    });


                });
                form.Invoke(new MethodInvoker(delegate()
                {
                    form.Room.Invalidate();
                }));
                Thread.Sleep(time);
            }
        }
    }
}
