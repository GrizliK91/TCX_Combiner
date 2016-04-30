using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace TCX_Combiner
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string str;
        string time_string = "";

        string fileName_garm;
        string fileName_endo;

        TimeSpan time_endo;
        TimeSpan time_gar;
        TimeSpan time_rez;
        TimeSpan time_value = new TimeSpan(0, 0, 13);

        int count_time_gar_string = 0;
        int count_heart_string = 0;

        bool find_time = false;
        bool flag_timecount = false;
        bool flag_heartcount = false;
        bool flag_containsFlag = false;

        List<string> list_heart_value = new List<string>();
        List<string> list_time_value = new List<string>();

        private void load_garmin_file()
        {
            listBox_garm.Items.Clear();
            string line_garm;
            using (var reader = File.OpenText(fileName_garm))
            {
                while ((line_garm = reader.ReadLine()) != null)
                {
                    listBox_garm.Items.Add(line_garm.Replace(" ", ""));
                }
            }
            list_heart_value.Clear();
            list_time_value.Clear();
            foreach (var item in listBox_garm.Items)
            {
                str = item.ToString();
                if (time_string != "")
                {
                    if (str.Contains("<Value>") == true)
                    {
                        list_heart_value.Add("<HeartRateBpm>" + str + "</HeartRateBpm>");
                        list_time_value.Add(time_string.Substring(17, 8));
                        time_string = "";
                    }
                }
                if (str.Contains("<Time>") == true)
                    time_string = str;
            }

            if (list_heart_value.Count > 0 && list_time_value.Count > 0)
            {
                label_count_heart.Text = "Count Heart: " + list_heart_value.Count.ToString();
                label_count_time.Text = "Count Time: " + list_time_value.Count.ToString();

                button_load_garmin.Enabled = false;
                button_clear_garm.Enabled = true;
                listBox_garm.AllowDrop = false;
                label_dragndrop2.Visible = false;

                if (listBox_endo.Items.Count > 0)
                    button_combine.Enabled = true;
            }
            else
            {
                list_heart_value.Clear();
                list_time_value.Clear();
                listBox_garm.Items.Clear();
                MessageBox.Show("We don't find any heart beat date!");
            }
        }

        private void load_endo_file()
        {
            string line_endo;
            using (var reader = File.OpenText(fileName_endo))
            {
                while ((line_endo = reader.ReadLine()) != null)
                {
                    if (flag_containsFlag == false)
                    {
                        listBox_endo.Items.Add(line_endo);
                        if (line_endo.Contains("<Track>") == true)
                            flag_containsFlag = true;
                    }
                    else
                    {
                        if (line_endo.Contains("Activity Sport") == true || line_endo.Contains("Lap StartTime") == true)
                            listBox_endo.Items.Add(line_endo);
                        else
                            listBox_endo.Items.Add(line_endo.Replace(" ", ""));
                    }
                }
                flag_containsFlag = false;

                button_load_endo.Enabled = false;
                button_clear_endo.Enabled = true;
                listBox_endo.AllowDrop = false;
                label_dragndrop1.Visible = false;

                if (listBox_garm.Items.Count > 0)
                    button_combine.Enabled = true;
            }
        }

        private void button_load_endo_Click(object sender, EventArgs e)
        {
            Stream mystream_endo;
            OpenFileDialog commandFileDialog_endo = new OpenFileDialog();
            commandFileDialog_endo.Filter = "TCX files (*.tcx)|*.tcx";
            commandFileDialog_endo.InitialDirectory = @"C:\";
            commandFileDialog_endo.Title = "Please select Endomondo TCX file";
            if (commandFileDialog_endo.ShowDialog() == DialogResult.OK)
            {
                listBox_endo.Items.Clear();
                if ((mystream_endo = commandFileDialog_endo.OpenFile()) != null)
                {
                    fileName_endo = commandFileDialog_endo.FileName;
                    load_endo_file();
                }
            }
        }

        private void button_load_garmin_Click(object sender, EventArgs e)
        {
            Stream mystream_garm;
            OpenFileDialog commandFileDialog_garm = new OpenFileDialog();
            commandFileDialog_garm.Filter = "TCX files (*.tcx)|*.tcx";
            commandFileDialog_garm.InitialDirectory = @"C:\";
            commandFileDialog_garm.Title = "Please select Garmin TCX file";
            if (commandFileDialog_garm.ShowDialog() == DialogResult.OK)
            {
                if ((mystream_garm = commandFileDialog_garm.OpenFile()) != null)
                {
                    if (commandFileDialog_garm.FileName.Contains("tcx") == false)
                        MessageBox.Show("Upload only TCX file!");
                    else
                    {
                        fileName_garm = commandFileDialog_garm.FileName;
                        load_garmin_file();
                    }
                }
            }
        }

        private void button_combine_Click(object sender, EventArgs e)
        {
            listBox_output.Items.Clear();
            time_gar = TimeSpan.Parse(list_time_value[count_time_gar_string].ToString());
            foreach (var items in listBox_endo.Items)
            {
                str = items.ToString();

                if (str.Contains("<Time>") == true && flag_timecount == false)
                {
                    time_endo = TimeSpan.Parse(str.Substring(17, 8));
                    time_rez = time_gar - time_endo;
                    if (time_rez < time_value)
                    {
                        find_time = true;

                        if (list_time_value.Count > count_time_gar_string)
                        {
                            time_gar = TimeSpan.Parse(list_time_value[count_time_gar_string].ToString());
                            count_time_gar_string++;
                        }
                        else
                            flag_timecount = false;
                    }
                }
                if (find_time == true && flag_heartcount == false && flag_timecount == false)
                {
                    find_time = false;
                    listBox_output.Items.Add(str);
                    if (list_heart_value.Count > count_heart_string)
                    {
                        listBox_output.Items.Add(list_heart_value[count_heart_string]);
                        count_heart_string++;
                    }
                    else
                        flag_heartcount = false;
                }
                else
                    listBox_output.Items.Add(str);
            }
            button_clear_combine.Enabled = true;
            button_save.Enabled = true;
        }

        
        private void button_save_Click(object sender, EventArgs e)
        {
            var saveFile = new SaveFileDialog();
            saveFile.Filter = "TCX File (*.tcx)|*.tcx";
            saveFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            saveFile.FileName = "TCX_Combiner_output";
            if (saveFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                using (var sw = new StreamWriter(saveFile.FileName, false))
                    foreach (var item in listBox_output.Items)
                        sw.Write(item.ToString() + Environment.NewLine);
                MessageBox.Show("Success");
            }
        }

        private void listBox_endo_DragDrop(object sender, DragEventArgs e)
        {
            string[] files_endo = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files_endo[0].Contains(".tcx") == false)
                MessageBox.Show("Upload only TCX file!");
            else
            {
                listBox_endo.Items.Clear();
                fileName_endo = files_endo[0];
                load_endo_file();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox_endo_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }

        private void listBox_garm_DragDrop(object sender, DragEventArgs e)
        {
            string[] files_garm = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files_garm[0].Contains(".tcx") == false)
                MessageBox.Show("Upload only TCX file!");
            else
            {
                fileName_garm = files_garm[0];
                load_garmin_file();
            }
        }

        private void listBox_garm_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }

        private void button_clear_garm_Click(object sender, EventArgs e)
        {
            listBox_garm.Items.Clear();
            button_clear_garm.Enabled = false;
            listBox_garm.AllowDrop = true;
            button_load_garmin.Enabled = true;
            button_combine.Enabled = false;
            label_count_heart.Text = "Count Heart: ";
            label_count_time.Text = "Count Time: ";
            label_dragndrop2.Visible = true;
        }

        private void button_clear_endo_Click(object sender, EventArgs e)
        {
            listBox_endo.Items.Clear();
            button_clear_endo.Enabled = false;
            listBox_endo.AllowDrop = true;
            button_load_endo.Enabled = true;
            button_combine.Enabled = false;
            label_dragndrop1.Visible = true;
        }

        private void button_clear_combine_Click(object sender, EventArgs e)
        {
            listBox_output.Items.Clear();
            button_clear_combine.Enabled = false;
            button_save.Enabled = false;
        }

        private void label_about_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TCX_Combiner\nApplication combine TCX from Endomondo App and Garmin Vivofit2\nAlexander Ivanov 2016","About",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
