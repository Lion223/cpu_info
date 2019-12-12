using System;
using System.Drawing;
using System.Management;
using System.Windows.Forms;

namespace CPUInfo
{
    public partial class CPUInfoUC : UserControl
    {
        public CPUInfoUC()
        {
            InitializeComponent();
            propertiesListView.Items.Clear();
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_Processor");
            try
            {
                foreach (ManagementObject share in searcher.Get())
                {

                    ListViewGroup grp;
                    try
                    {
                        grp = propertiesListView.Groups.Add(share["Name"].ToString(), share["Name"].ToString());
                    }
                    catch
                    {
                        grp = propertiesListView.Groups.Add(share.ToString(), share.ToString());
                    }

                    if (share.Properties.Count <= 0)
                    {
                        MessageBox.Show("No Information Available", "No Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    foreach (PropertyData PC in share.Properties)
                    {

                        ListViewItem item = new ListViewItem(grp);
                        if (propertiesListView.Items.Count % 2 != 0)
                            item.BackColor = Color.White;
                        else
                            item.BackColor = Color.Red;

                        item.Text = PC.Name;

                        if (PC.Value != null && PC.Value.ToString() != "")
                        {
                            switch (PC.Value.GetType().ToString())
                            {
                                case "System.String[]":
                                    string[] str = (string[])PC.Value;

                                    string str2 = "";
                                    foreach (string st in str)
                                        str2 += st + " ";

                                    item.SubItems.Add(str2);

                                    break;
                                case "System.UInt16[]":
                                    ushort[] shortData = (ushort[])PC.Value;


                                    string tstr2 = "";
                                    foreach (ushort st in shortData)
                                        tstr2 += st.ToString() + " ";

                                    item.SubItems.Add(tstr2);

                                    break;

                                default:
                                    item.SubItems.Add(PC.Value.ToString());
                                    break;
                            }
                            if (PC.Value != null) propertiesListView.Items.Add(item);
                        }
                        //if (string.IsNullOrWhiteSpace(PC.Value.ToString())) 

                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Can't get data because of the following error \n" + exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void metroListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
