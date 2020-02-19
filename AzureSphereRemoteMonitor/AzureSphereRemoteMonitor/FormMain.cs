using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Azure.Devices;
using Microsoft.ServiceBus.Messaging;
using System.Diagnostics;
using System.Runtime.Serialization.Json;
using System.IO;
using Newtonsoft.Json;

namespace AzureSphereRemoteMonitor
{
    public partial class FormMain : Form
    {
        static ServiceClient serviceClient;
        static string connectionString = "Your HostName, SharedAccessKeyName, and SharedAccessKey";
        static string iotHubD2cEndpoint = "messages/events";
        static EventHubClient eventHubClient;
        string DeviceID = "Your Device ID";
        SensorData SensorDataObj;
        double TempThres = 27.0;
        bool cooleron = false;

        public FormMain()
        {
            InitializeComponent();
            SensorDataObj = new SensorData();
            this.Shown += Form_Shown;
        }

               private async void Form_Shown(object sender, EventArgs e)
        {
            try
            {
                serviceClient = ServiceClient.CreateFromConnectionString(connectionString);
                eventHubClient = EventHubClient.CreateFromConnectionString(connectionString, iotHubD2cEndpoint);
                var d2cPartitions = eventHubClient.GetRuntimeInformation().PartitionIds;

                foreach (string partition in d2cPartitions)
                {
                    ReceiveMessagesFromDeviceAsync(partition);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }

        }

        public class SensorData
        {
            public float gX;
            public float gY;
            public float gZ;
            public float aX;
            public float aY;
            public float aZ;
            public float pressure;
            public float light;
            public float altitude;
            public float temperature;
            public float rssi;
            //public string Currentdatetime;


            public SensorData() { } //required for JSON serializers
            public SensorData(float GX, float GY, float GZ, float AX, float AY, float AZ, float Pressure, float Light, float Altitude, float Temperature, float Rssi)
            {
                gX = GX;
                gY = GY;
                gZ = GZ;
                aX = AX;
                aY = AY;
                aZ = AZ;
                pressure = Pressure;
                light = Light;
                altitude = Altitude;
                temperature = Temperature;
                rssi = Rssi;
                //Currentdatetime = Cdatetime;              
            }

        }

        public T Deserialize<T>(string json)
        {
            var _Bytes = Encoding.Unicode.GetBytes(json);
            using (MemoryStream _Stream = new MemoryStream(_Bytes))
            {
                var _Serializer = new DataContractJsonSerializer(typeof(T));
                return (T)_Serializer.ReadObject(_Stream);
            }
        }
        private async Task ReceiveMessagesFromDeviceAsync(string partition)
        {
            var eventHubReceiver = eventHubClient.GetDefaultConsumerGroup().CreateReceiver(partition, DateTime.Now);

            while (true)
            {
                try
                {
                    EventData eventData = await eventHubReceiver.ReceiveAsync();
                    if (eventData == null) continue;
                    byte[] data = eventData.GetBytes();
                    string connectionDeviceId = eventData.SystemProperties["iothub-connection-device-id"].ToString();
                    Debug.WriteLine("Message from " + connectionDeviceId);
                    if (connectionDeviceId != DeviceID)
                        continue;
                    
                    string json = System.Text.Encoding.UTF8.GetString(data);
                    Debug.WriteLine(json);
                    //SensorDataObj = Deserialize<SensorData>(json);
                    SensorDataObj = JsonConvert.DeserializeObject<SensorData>(json);
                    gX.Invoke(new Action(() =>
                    {
                        gX.Text = SensorDataObj.gX.ToString();
                    }));
                    gY.Invoke(new Action(() =>
                    {
                        gY.Text = SensorDataObj.gY.ToString();
                    }));
                    gZ.Invoke(new Action(() =>
                    {
                        gZ.Text = SensorDataObj.gZ.ToString();
                        }));
                    aX.Invoke(new Action(() =>
                    {
                        aX.Text = SensorDataObj.aX.ToString();
                    }));
                    aY.Invoke(new Action(() =>
                    {
                        aY.Text = SensorDataObj.aY.ToString();
                    }));
                    aZ.Invoke(new Action(() =>
                    {
                        aZ.Text = SensorDataObj.aZ.ToString();
                    }));
                    pressure.Invoke(new Action(() =>
                    {
                        pressure.Text = SensorDataObj.pressure.ToString();
                    }));
                    altitude.Invoke(new Action(() =>
                    {
                        altitude.Text = SensorDataObj.altitude.ToString();
                    }));
                    temperature.Invoke(new Action(() =>
                    {
                        temperature.Text = SensorDataObj.temperature.ToString();
                    }));
                    light.Invoke(new Action(() =>
                    {
                        light.Text = SensorDataObj.light.ToString();
                    }));
                    rssi.Invoke(new Action(() =>
                    {
                        rssi.Text = SensorDataObj.rssi.ToString();
                    }));
                    msgTime.Invoke(new Action(() =>
                    {
                        msgTime.Text = System.DateTime.Now.ToString();
                    }));
                    if (SensorDataObj.temperature >= TempThres)
                    {
                        if (!cooleron)
                        {
                            SendCloudToDeviceMessageAsync("On");    //Power on Cooler
                            sysstatus.Invoke(new Action(() =>
                            {
                                sysstatus.Text = "Relay ON";
                            }));
                            cooleron = true;
                        }
                    }
                    else
                    {
                        if (cooleron)
                        {
                            SendCloudToDeviceMessageAsync("Off");    //Power on Cooler
                            sysstatus.Invoke(new Action(() =>
                            {
                                sysstatus.Text = "Relay OFF";
                            }));
                            cooleron = false;
                        }
                    }

                }
                catch (Exception e)
                {
                    Debug.WriteLine(e.ToString());
                }

                //  string data = Encoding.UTF8.GetString(eventData.GetBytes());
                //  Debug.WriteLine(string.Format("Message received. Partition: {0} Data: '{1}'", partition, data));
            }
        }

        private void SendCloudToDeviceMessageAsync(string Data)
        {
            try
            {
                var commandMessage = new Microsoft.Azure.Devices.Message(Encoding.ASCII.GetBytes(Data));
                serviceClient.SendAsync(DeviceID, commandMessage);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.ToString());
            }
        }


        private void SetTemp_Click(object sender, EventArgs e)
        {
            TempThres = Convert.ToDouble(TempThreshold.Text);
            
        }

        private void buttonForward_Click(object sender, EventArgs e)
        {
            SendCloudToDeviceMessageAsync("Forward");
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            SendCloudToDeviceMessageAsync("Back");
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            SendCloudToDeviceMessageAsync("Stop");
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            SendCloudToDeviceMessageAsync("Left");
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            SendCloudToDeviceMessageAsync("Right");
        }

        private void buttonSpeedup_Click(object sender, EventArgs e)
        {
            SendCloudToDeviceMessageAsync("Up");
        }

        private void buttonSlowdown_Click(object sender, EventArgs e)
        {
            SendCloudToDeviceMessageAsync("Down");
        }
    }
}
