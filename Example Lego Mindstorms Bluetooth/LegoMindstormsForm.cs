using EV3MessengerLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example_Lego_Mindstorms_Bluetooth
{
    public partial class LegoMindstormsForm : Form
    {
        private EV3Messenger messenger;

        public LegoMindstormsForm()
        {
            InitializeComponent();
            // Init application
            messenger = new EV3Messenger();
            fillSerialPortSelectionBoxWithAvailablePorts();
            updateFormGUI();
           
        }

        //
        #region Connection form
        private void refreshButton_Click(object sender, EventArgs e)
        {
            fillSerialPortSelectionBoxWithAvailablePorts();
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            // Check if a port has been selected
            if (portListBox.SelectedIndex > -1)
            {
                // Get the selected port from the ListBox
                string port = portListBox.SelectedItem.ToString().ToUpper();
                // Try to connect with the Brick via the selected port
                if (messenger.Connect(port))
                {
                    updateFormGUI();
                }
                else
                {
                    MessageBox.Show("Failed to connect to serial port '" + port + "'.\n"
                        + "Make sure your robot is connected to that serial port and try again.");
                }
            }
            else
            {
                MessageBox.Show("Please select a port for the bluetooth connection");
            }
        }

        private void disconnectButton_Click(object sender, EventArgs e)
        {
            // Disconnect from the Brick
            messenger.Disconnect();

            updateFormGUI();
        }

        private void fillSerialPortSelectionBoxWithAvailablePorts()
        {
            String[] ports = SerialPort.GetPortNames();
            Array.Sort(ports);

            portListBox.Items.Clear();
            foreach (String port in ports)
            {
                portListBox.Items.Add(port);
            }
        }

        #endregion

        #region Input & output form

        private void inputButton_Click(object sender, EventArgs e)
        {
            string txtMsg = inputTextBox.Text;
            // Make sure a message has been typed
            if (!String.IsNullOrWhiteSpace(txtMsg))
            {
                // Send a message to the Brick with title: MESSAGE and the message
                if (messenger.SendMessage("MESSAGE", txtMsg))
                {
                    inputTextBox.Text = "";
                    MessageBox.Show("The message has been send to the Brick");
                }
                else
                {
                    MessageBox.Show("Unable to send the message to the Brick. Please try again.");
                }
            }
            else
            {
                MessageBox.Show("Please type a message in the above textbox for the Brick");
            }
        }

        private void outputButton_Click(object sender, EventArgs e)
        {
            // Try to get a message
            EV3Message message = messenger.ReadMessage();
            // Check if there is a message received from the Brick
            if (message != null)
            {
                outputlistBox.Items.Add("Message: " + message.ValueAsText);
                // Auto scroll the listbox
                outputlistBox.TopIndex = outputlistBox.Items.Count - 1;
            }
            else
            {
                MessageBox.Show("No message recieved from the Brick");
            }
        }

        #endregion

        #region GUI

        private void updateFormGUI()
        {
            if (messenger.IsConnected)
            {
                refreshButton.Enabled = false;
                connectButton.Enabled = false;

                inputGroupBox.Enabled = true;
                outputGroupBox.Enabled = true;
                disconnectButton.Enabled = true;
                //btLeft.Enabled = true;
                //btRight.Enabled = true;
                //btStop.Enabled = true;
                //btForward.Enabled = true;
                //btBack.Enabled = true;
                //btndrop.Enabled = true;
                //btnLift.Enabled = true;
                //btShowMessage.Enabled = true;


                outputlistBox.Items.Clear();
            }
            else
            {
                refreshButton.Enabled = true;
                connectButton.Enabled = true;

                inputGroupBox.Enabled = false;
                outputGroupBox.Enabled = false;
                disconnectButton.Enabled = false;
                btLeft.Enabled = false;
                btRight.Enabled = false;
                btStop.Enabled = false;
                btForward.Enabled = false;
                btBack.Enabled = false;
                btndrop.Enabled = false;
                btnLift.Enabled = false;
                btShowMessage.Enabled = false;
                btnStart.Enabled = false;
            }
        }
        
        #endregion

        private void btForward_Click(object sender, EventArgs e)
        {
            string forward = "Forward";
            messenger.SendMessage("MESSAGE", forward);
            //Thread.Sleep(100);
            //messenger.SendMessage("MESSAGE", "Stop");
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            string back = "Back";
            messenger.SendMessage("MESSAGE", back);
        }

        private void btLeft_Click(object sender, EventArgs e)
        {
            string left = "Left";
            messenger.SendMessage("MESSAGE", left);
        }

        private void btRight_Click(object sender, EventArgs e)
        {
            string right = "Right";
            messenger.SendMessage("MESSAGE", right);
        }

        private void btForward_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void btBack_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void btRight_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void btLeft_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void btStop_Click(object sender, EventArgs e)
        {
            string Stop = "Stop";
            messenger.SendMessage("MESSAGE", Stop);
            
        }

        private void btStop_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void LegoMindstormsForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 65)
            {
                btLeft.PerformClick();
            }           
            if (e.KeyValue == 68)
            {
                btRight.PerformClick();
            }
            if (e.KeyValue == 87)
            {
                btForward.PerformClick();
            }
            if (e.KeyValue == 83)
            {
                btBack.PerformClick();
            }
            if (e.KeyValue == 69)
            {
                btStop.PerformClick();
            }
            if (e.KeyValue == 67)
            {
                btnLift.PerformClick();
            }
            if (e.KeyValue == 90)
            {
                btndrop.PerformClick();
            }
        }

        private void btGrap_Click(object sender, EventArgs e)
        {
            string Lift = "Lift";
            messenger.SendMessage("MESSAGE", Lift);
           
            
        }

        private void btlift_Click(object sender, EventArgs e)
        {
            string Grap = "Grap";
            messenger.SendMessage("MESSAGE", Grap);
            
        }

        private void LegoMindstormsForm_Load(object sender, EventArgs e)
        {
           
        }

        private void btShowMessage_Click(object sender, EventArgs e)
        {
            // Try to get a message
            EV3Message message = messenger.ReadMessage();
            // Check if there is a message received from the Brick
            if (message != null)
            {
                outputlistBox.Items.Add("Message: " + message.ValueAsText);
                // Auto scroll the listbox
                outputlistBox.TopIndex = outputlistBox.Items.Count - 1;
            }
            else
            {
                MessageBox.Show("No message recieved from the Brick");
            }
        }

        private void gbxcontrols_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cbmode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbmode.SelectedItem.Equals("Manual"))
            {
                btLeft.Enabled = true;
                btRight.Enabled = true;
                btStop.Enabled = true;
                btForward.Enabled = true;
                btBack.Enabled = true;
                btndrop.Enabled = true;
                btnLift.Enabled = true;
                btShowMessage.Enabled = true;
                btStop.Enabled = true;
                btnStart.Enabled = false;
            }

          else  if(cbmode.SelectedItem.Equals("Automatic"))
            {
                btStop.Enabled = true;
                btnStart.Enabled = true;
                btLeft.Enabled = false;
                btRight.Enabled = false;
               
                btForward.Enabled = false;
                btBack.Enabled = false;
                btndrop.Enabled = false;
                btnLift.Enabled = false;
                btShowMessage.Enabled = true;
            }

            else 
                {
                btStop.Enabled = false;
                btnStart.Enabled = false;
                btLeft.Enabled = false;
                btRight.Enabled = false;

                btForward.Enabled = false;
                btBack.Enabled = false;
                btndrop.Enabled = false;
                btnLift.Enabled = false;
                btShowMessage.Enabled = false;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            string Start = "Start";
            messenger.SendMessage("MESSAGE", Start);
            EV3Message message = messenger.ReadMessage();
            do
            {
                if (message != null)
                {
                    outputlistBox.Items.Add("Message: " + message.ValueAsText);

                    outputlistBox.TopIndex = outputlistBox.Items.Count - 1;
                    message = messenger.ReadMessage();
                }
                else
                {
                    MessageBox.Show("No message recieved from the Brick");
                }

            } while (message != null);

        }


        private void RMessage()
        {
            //Method to read message
            EV3Message message = messenger.ReadMessage();
            if(message!=null)
            {
                outputlistBox.Items.Add("Message: " + message.ValueAsText);
                outputlistBox.TopIndex = outputlistBox.Items.Count - 1;

            }
            else
            {
                MessageBox.Show(" No Message recieved from Brick");
            }
        }
    }
}
