using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;

namespace MPServer_v01.dv
{
    public partial class Form1 : Form
    {

        DroneDV dr1;



        public class DroneDV
        {
            float gamma = Single.NaN;//рыскание
            float ksi = Single.NaN;//тангаж
            float phi = Single.NaN;//крен

            float Power;

            //Netservis=================================
            IPAddress localAddress;
            TcpListener listener;
            TcpClient client;
            static NetworkStream ntws;


            //loopservis================================
            static Queue<byte[]> comQueue = new Queue<byte[]>();
            public Thread loopthread = new Thread(new ParameterizedThreadStart(MPLoop));

            public DroneDV()
            {
                localAddress = IPAddress.Parse("192.168.173.1");
                listener = new TcpListener(localAddress, 80);
                listener.Start();
                client = listener.AcceptTcpClient();
                ntws = client.GetStream();
                while (ntws.DataAvailable == false) { };
                while (ntws.DataAvailable)
                {
                    string qwe = ntws.ReadByte().ToString();
                }
            }

            public void setPID(float PIDgP, float PIDgI, float PIDgD,
                                float PIDkP, float PIDkI, float PIDkD,
                                float PIDpP, float PIDpI, float PIDpD)
            {
                byte[] asd = new byte[9 * sizeof(float)+2];

                asd[0] = (byte)(9 * sizeof(float));
                asd[1] = Convert.ToByte('s');

                Array.Copy(BitConverter.GetBytes(PIDgP), 0, asd, 2, 4);
                Array.Copy(BitConverter.GetBytes(PIDgI), 0, asd, 6, 4);
                Array.Copy(BitConverter.GetBytes(PIDgD), 0, asd, 10, 4);

                Array.Copy(BitConverter.GetBytes(PIDkP), 0, asd, 14, 4);
                Array.Copy(BitConverter.GetBytes(PIDkI), 0, asd, 18, 4);
                Array.Copy(BitConverter.GetBytes(PIDkD), 0, asd, 22, 4);

                Array.Copy(BitConverter.GetBytes(PIDpP), 0, asd, 26, 4);
                Array.Copy(BitConverter.GetBytes(PIDpI), 0, asd, 30, 4);
                Array.Copy(BitConverter.GetBytes(PIDpD), 0, asd, 34, 4);

                comQueue.Enqueue(asd);
            }  //s

            public void setPos(float gamma, float ksi, float phi, float Power)
            {
                byte[] asd = new byte[4 * sizeof(float) + 2];

                asd[0] = (byte)(4 * sizeof(float));
                asd[1] = Convert.ToByte('a');

                Array.Copy(BitConverter.GetBytes(gamma), 0, asd, 2, 4);
                Array.Copy(BitConverter.GetBytes(ksi), 0, asd, 6, 4);
                Array.Copy(BitConverter.GetBytes(phi), 0, asd, 10, 4);
                Array.Copy(BitConverter.GetBytes(Power), 0, asd, 10, 4);
                comQueue.Enqueue(asd);
            } //a

            public void setPower(Int16 M1, Int16 M2, Int16 M3, Int16 M4) //d
            {
                byte[] asd = new byte[4 * sizeof(Int16) + 2];

                asd[0] = (byte)(4 * sizeof(Int16));
                asd[1] = Convert.ToByte('d');

                Array.Copy(BitConverter.GetBytes(M1), 0, asd, 2, 2);
                Array.Copy(BitConverter.GetBytes(M2), 0, asd, 4, 2);
                Array.Copy(BitConverter.GetBytes(M3), 0, asd, 6, 2);
                Array.Copy(BitConverter.GetBytes(M4), 0, asd, 8, 2);
                comQueue.Enqueue(asd);
            }

            public static void MPLoop(object pbox)
            {
             /*   PictureBox pbox1 = (PictureBox)Convert.ChangeType(pbox, typeof(PictureBox));
                Graphics gr1 = pbox1.CreateGraphics();
                gr1.DrawEllipse(new Pen(Color.Black), 10, 10, 10, 10);
              
                */char com = ' ';
                while (com != 'e')
                {
                    while (!ntws.DataAvailable) { }
                    ntws.ReadByte();
                    if (comQueue.Count == 0) 
                    { 
                        com = 'p';
                        byte[] command = new byte[2] {(byte)0, Convert.ToByte('p')};
                        ntws.Write(command, 0, command.Length);
                    }
                    else
                    {
                        byte[] command = comQueue.Dequeue();
                        com = (char)command[1];
                        ntws.Write(command, 0, command.Length);
                    }
                    
                }
            }

        }


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // dr1 = new DroneDV();
        }

        private void START_btn_Click(object sender, EventArgs e)
        {
            dr1 = new DroneDV();
            dr1.loopthread.Start(log_pbox);
        }

        private void STOP_btn_Click(object sender, EventArgs e)
        {
            dr1.loopthread.Abort();
        }

        private void setPID_btn_Click(object sender, EventArgs e)
        {
            string[] PIDg = PIDg_tbox.Text.Split(' ');
            string[] PIDk = PIDk_tbox.Text.Split(' ');
            string[] PIDp = PIDp_tbox.Text.Split(' ');

            float PIDgP = float.Parse(PIDg[0].Replace('.',','));
            float PIDgI = float.Parse(PIDg[1].Replace('.', ','));
            float PIDgD = float.Parse(PIDg[2].Replace('.', ','));

            float PIDkP = float.Parse(PIDk[0].Replace('.', ','));
            float PIDkI = float.Parse(PIDk[1].Replace('.', ','));
            float PIDkD = float.Parse(PIDk[2].Replace('.', ','));

            float PIDpP = float.Parse(PIDp[0].Replace('.', ','));
            float PIDpI = float.Parse(PIDp[1].Replace('.', ','));
            float PIDpD = float.Parse(PIDp[2].Replace('.', ','));

            dr1.setPID(PIDgP, PIDgI, PIDgD,
                PIDkP, PIDkI, PIDkD,
                PIDpP, PIDpI, PIDpD);
        }

        private void PIDg_tbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void setAngle_btn_Click(object sender, EventArgs e)
        {
            float gamma = float.Parse(gamma_tbox.Text.Replace('.', ','));
            float ksi = float.Parse(ksi_tbox.Text.Replace('.', ','));
            float phi = float.Parse(phi_tbox.Text.Replace('.', ','));
            dr1.setPos(gamma, ksi, phi, 10);
        }

        private void setDrive_btn_Click(object sender, EventArgs e)
        {

            Int16 M1 = Int16.Parse(M1pwd_tbox.Text);
            Int16 M2 = Int16.Parse(M2pwd_tbox.Text);
            Int16 M3 = Int16.Parse(M3pwd_tbox.Text);
            Int16 M4 = Int16.Parse(M4pwd_tbox.Text);

            dr1.setPower(M1, M2, M3, M4);

        }

        private void ABORT_btn_Click(object sender, EventArgs e)
        {
            dr1.setPower(88, 88, 88, 88);
        }
    }
}
