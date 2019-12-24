﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Nokia_Tool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process p1 = new Process();
            p1.StartInfo.UseShellExecute = false;
            p1.StartInfo.RedirectStandardOutput = true;
            p1.StartInfo.FileName = "cmd.exe";
            p1.StartInfo.Arguments = "/c echo getversions..";
            p1.StartInfo.CreateNoWindow = true;
            p1.Start();
            richTextBox1.Text = richTextBox1.Text + p1.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p1.WaitForExit();


            Process p2 = new Process();
            p2.StartInfo.UseShellExecute = false;
            p2.StartInfo.RedirectStandardOutput = true;
            p2.StartInfo.FileName = "cmd.exe";
            p2.StartInfo.Arguments = "/c fastboot oem getversions 2>getver.txt & type getver.txt ";
            p2.StartInfo.CreateNoWindow = true;
            p2.Start();
            richTextBox1.Text = richTextBox1.Text + p2.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p2.WaitForExit();

            Process p = new Process();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.Arguments = "/c del getver.txt";
            p.StartInfo.CreateNoWindow = true;
            p.Start();
            richTextBox1.Text = richTextBox1.Text + p.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p.WaitForExit();

            Process p3 = new Process();
            p3.StartInfo.UseShellExecute = false;
            p3.StartInfo.RedirectStandardOutput = true;
            p3.StartInfo.FileName = "cmd.exe";
            p3.StartInfo.Arguments = "/c echo device-info..";
            p3.StartInfo.CreateNoWindow = true;
            p3.Start();
            richTextBox1.Text = richTextBox1.Text + p3.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p3.WaitForExit();


            Process p4 = new Process();
            p4.StartInfo.UseShellExecute = false;
            p4.StartInfo.RedirectStandardOutput = true;
            p4.StartInfo.FileName = "cmd.exe";
            p4.StartInfo.Arguments = "/c fastboot oem device-info 2>device.txt & type device.txt  ";
            p4.StartInfo.CreateNoWindow = true;
            p4.Start();
            richTextBox1.Text = richTextBox1.Text + p4.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p4.WaitForExit();

            Process p5 = new Process();
            p5.StartInfo.UseShellExecute = false;
            p5.StartInfo.RedirectStandardOutput = true;
            p5.StartInfo.FileName = "cmd.exe";
            p5.StartInfo.Arguments = "/c echo Flashing abl_a..";
            p5.StartInfo.CreateNoWindow = true;
            p5.Start();
            richTextBox1.Text = richTextBox1.Text + p5.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p5.WaitForExit();


            Process p6 = new Process();
            p6.StartInfo.UseShellExecute = false;
            p6.StartInfo.RedirectStandardOutput = true;
            p6.StartInfo.FileName = "cmd.exe";
            p6.StartInfo.Arguments = "/c fastboot flash abl_a DRG-354H-0-00WW-B01-abl.img  2>>log.txt  ";
            p6.StartInfo.CreateNoWindow = true;
            p6.Start();
            richTextBox1.Text = richTextBox1.Text + p6.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p6.WaitForExit();

            Process p7 = new Process();
            p7.StartInfo.UseShellExecute = false;
            p7.StartInfo.RedirectStandardOutput = true;
            p7.StartInfo.FileName = "cmd.exe";
            p7.StartInfo.Arguments = "/c echo Flashing abl_b..";
            p7.StartInfo.CreateNoWindow = true;
            p7.Start();
            richTextBox1.Text = richTextBox1.Text + p7.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p7.WaitForExit();

            Process p8 = new Process();
            p8.StartInfo.UseShellExecute = false;
            p8.StartInfo.RedirectStandardOutput = true;
            p8.StartInfo.FileName = "cmd.exe";
            p8.StartInfo.Arguments = "/c fastboot flash abl_b DRG-354H-0-00WW-B01-abl.img  2>>log.txt ";
            p8.StartInfo.CreateNoWindow = true;
            p8.Start();
            richTextBox1.Text = richTextBox1.Text + p8.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p8.WaitForExit();

            Process p9 = new Process();
            p9.StartInfo.UseShellExecute = false;
            p9.StartInfo.RedirectStandardOutput = true;
            p9.StartInfo.FileName = "cmd.exe";
            p9.StartInfo.Arguments = "/c echo FLashing xbl_a..";
            p9.StartInfo.CreateNoWindow = true;
            p9.Start();
            richTextBox1.Text = richTextBox1.Text + p9.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p9.WaitForExit();

            Process p10 = new Process();
            p10.StartInfo.UseShellExecute = false;
            p10.StartInfo.RedirectStandardOutput = true;
            p10.StartInfo.FileName = "cmd.exe";
            p10.StartInfo.Arguments = "/c fastboot flash xbl_a DRG-354H-0-00WW-B01-xbl.img  2>>log.txt ";
            p10.StartInfo.CreateNoWindow = true;
            p10.Start();
            richTextBox1.Text = richTextBox1.Text + p10.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p10.WaitForExit();

            Process p11 = new Process();
            p11.StartInfo.UseShellExecute = false;
            p11.StartInfo.RedirectStandardOutput = true;
            p11.StartInfo.FileName = "cmd.exe";
            p11.StartInfo.Arguments = "/c echo Flashing xbl_b.. ";
            p11.StartInfo.CreateNoWindow = true;
            p11.Start();
            richTextBox1.Text = richTextBox1.Text + p11.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p11.WaitForExit();

            Process p12 = new Process();
            p12.StartInfo.UseShellExecute = false;
            p12.StartInfo.RedirectStandardOutput = true;
            p12.StartInfo.FileName = "cmd.exe";
            p12.StartInfo.Arguments = "/c fastboot flash xbl_b DRG-354H-0-00WW-B01-xbl.img  2>>log.txt ";
            p12.StartInfo.CreateNoWindow = true;
            p12.Start();
            richTextBox1.Text = richTextBox1.Text + p12.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p12.WaitForExit();

            Process p13 = new Process();
            p13.StartInfo.UseShellExecute = false;
            p13.StartInfo.RedirectStandardOutput = true;
            p13.StartInfo.FileName = "cmd.exe";
            p13.StartInfo.Arguments = "/c echo Flashing bluetooth_a.. ";
            p13.StartInfo.CreateNoWindow = true;
            p13.Start();
            richTextBox1.Text = richTextBox1.Text + p13.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p13.WaitForExit();

            Process p14 = new Process();
            p14.StartInfo.UseShellExecute = false;
            p14.StartInfo.RedirectStandardOutput = true;
            p14.StartInfo.FileName = "cmd.exe";
            p14.StartInfo.Arguments = "/c fastboot flash bluetooth_a DRG-354H-0-00WW-B01-bluetooth.img  2>>log.txt ";
            p14.StartInfo.CreateNoWindow = true;
            p14.Start();
            richTextBox1.Text = richTextBox1.Text + p14.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p14.WaitForExit();

            Process p15 = new Process();
            p15.StartInfo.UseShellExecute = false;
            p15.StartInfo.RedirectStandardOutput = true;
            p15.StartInfo.FileName = "cmd.exe";
            p15.StartInfo.Arguments = "/c echo Flashing boot_a.. ";
            p15.StartInfo.CreateNoWindow = true;
            p15.Start();
            richTextBox1.Text = richTextBox1.Text + p15.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p15.WaitForExit();

            Process p16 = new Process();
            p16.StartInfo.UseShellExecute = false;
            p16.StartInfo.RedirectStandardOutput = true;
            p16.StartInfo.FileName = "cmd.exe";
            p16.StartInfo.Arguments = "/c fastboot flash boot_a DRG-354H-0-00WW-B01-boot.img  2>>log.txt ";
            p16.StartInfo.CreateNoWindow = true;
            p16.Start();
            richTextBox1.Text = richTextBox1.Text + p16.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p16.WaitForExit();

            Process p17 = new Process();
            p17.StartInfo.UseShellExecute = false;
            p17.StartInfo.RedirectStandardOutput = true;
            p17.StartInfo.FileName = "cmd.exe";
            p17.StartInfo.Arguments = "/c echo Flashing cda_a.. ";
            p17.StartInfo.CreateNoWindow = true;
            p17.Start();
            richTextBox1.Text = richTextBox1.Text + p17.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p17.WaitForExit();

            Process p18 = new Process();
            p18.StartInfo.UseShellExecute = false;
            p18.StartInfo.RedirectStandardOutput = true;
            p18.StartInfo.FileName = "cmd.exe";
            p18.StartInfo.Arguments = "/c fastboot flash cda_a DRG-354H-0-00WW-B01-cda.img  2>>log.txt ";
            p18.StartInfo.CreateNoWindow = true;
            p18.Start();
            richTextBox1.Text = richTextBox1.Text + p18.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p18.WaitForExit();

            Process p19 = new Process();
            p19.StartInfo.UseShellExecute = false;
            p19.StartInfo.RedirectStandardOutput = true;
            p19.StartInfo.FileName = "cmd.exe";
            p19.StartInfo.Arguments = "/c echo Flashing cmnlib_a.. ";
            p19.StartInfo.CreateNoWindow = true;
            p19.Start();
            richTextBox1.Text = richTextBox1.Text + p19.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p19.WaitForExit();

            Process p20 = new Process();
            p20.StartInfo.UseShellExecute = false;
            p20.StartInfo.RedirectStandardOutput = true;
            p20.StartInfo.FileName = "cmd.exe";
            p20.StartInfo.Arguments = "/c fastboot flash cmnlib_a DRG-354H-0-00WW-B01-cmnlib.img  2>>log.txt ";
            p20.StartInfo.CreateNoWindow = true;
            p20.Start();
            richTextBox1.Text = richTextBox1.Text + p20.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p20.WaitForExit();

            Process p21 = new Process();
            p21.StartInfo.UseShellExecute = false;
            p21.StartInfo.RedirectStandardOutput = true;
            p21.StartInfo.FileName = "cmd.exe";
            p21.StartInfo.Arguments = "/c echo Flashing cmnlib64_a.. ";
            p21.StartInfo.CreateNoWindow = true;
            p21.Start();
            richTextBox1.Text = richTextBox1.Text + p21.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p21.WaitForExit();

            Process p22 = new Process();
            p22.StartInfo.UseShellExecute = false;
            p22.StartInfo.RedirectStandardOutput = true;
            p22.StartInfo.FileName = "cmd.exe";
            p22.StartInfo.Arguments = "/c fastboot flash cmnlib64_a DRG-354H-0-00WW-B01-cmnlib64.img  2>>log.txt ";
            p22.StartInfo.CreateNoWindow = true;
            p22.Start();
            richTextBox1.Text = richTextBox1.Text + p22.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p22.WaitForExit();

            Process p23 = new Process();
            p23.StartInfo.UseShellExecute = false;
            p23.StartInfo.RedirectStandardOutput = true;
            p23.StartInfo.FileName = "cmd.exe";
            p23.StartInfo.Arguments = "/c echo Flashing devcfg_a.. ";
            p23.StartInfo.CreateNoWindow = true;
            p23.Start();
            richTextBox1.Text = richTextBox1.Text + p23.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p23.WaitForExit();

            Process p24 = new Process();
            p24.StartInfo.UseShellExecute = false;
            p24.StartInfo.RedirectStandardOutput = true;
            p24.StartInfo.FileName = "cmd.exe";
            p24.StartInfo.Arguments = "/c fastboot flash devcfg_a DRG-354H-0-00WW-B01-devcfg.img  2>>log.txt ";
            p24.StartInfo.CreateNoWindow = true;
            p24.Start();
            richTextBox1.Text = richTextBox1.Text + p24.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p24.WaitForExit();

            Process p25 = new Process();
            p25.StartInfo.UseShellExecute = false;
            p25.StartInfo.RedirectStandardOutput = true;
            p25.StartInfo.FileName = "cmd.exe";
            p25.StartInfo.Arguments = "/c echo Flashing dsp_a.. ";
            p25.StartInfo.CreateNoWindow = true;
            p25.Start();
            richTextBox1.Text = richTextBox1.Text + p25.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p25.WaitForExit();

            Process p26 = new Process();
            p26.StartInfo.UseShellExecute = false;
            p26.StartInfo.RedirectStandardOutput = true;
            p26.StartInfo.FileName = "cmd.exe";
            p26.StartInfo.Arguments = "/c fastboot flash dsp_a DRG-354H-0-00WW-B01-dsp.img  2>>log.txt ";
            p26.StartInfo.CreateNoWindow = true;
            p26.Start();
            richTextBox1.Text = richTextBox1.Text + p26.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p26.WaitForExit();

            Process p27 = new Process();
            p27.StartInfo.UseShellExecute = false;
            p27.StartInfo.RedirectStandardOutput = true;
            p27.StartInfo.FileName = "cmd.exe";
            p27.StartInfo.Arguments = "/c echo Flashing hidden_a.. ";
            p27.StartInfo.CreateNoWindow = true;
            p27.Start();
            richTextBox1.Text = richTextBox1.Text + p27.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p27.WaitForExit();

            Process p28 = new Process();
            p28.StartInfo.UseShellExecute = false;
            p28.StartInfo.RedirectStandardOutput = true;
            p28.StartInfo.FileName = "cmd.exe";
            p28.StartInfo.Arguments = "/c fastboot flash hidden_a DRG-354H-0-00WW-B01-hidden.img  2>>log.txt ";
            p28.StartInfo.CreateNoWindow = true;
            p28.Start();
            richTextBox1.Text = richTextBox1.Text + p28.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p28.WaitForExit();

            Process p29 = new Process();
            p29.StartInfo.UseShellExecute = false;
            p29.StartInfo.RedirectStandardOutput = true;
            p29.StartInfo.FileName = "cmd.exe";
            p29.StartInfo.Arguments = "/c echo Flashing hyp_a.. ";
            p29.StartInfo.CreateNoWindow = true;
            p29.Start();
            richTextBox1.Text = richTextBox1.Text + p29.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p29.WaitForExit();

            Process p30 = new Process();
            p30.StartInfo.UseShellExecute = false;
            p30.StartInfo.RedirectStandardOutput = true;
            p30.StartInfo.FileName = "cmd.exe";
            p30.StartInfo.Arguments = "/c fastboot flash hyp_a DRG-354H-0-00WW-B01-hyp.img  2>>log.txt ";
            p30.StartInfo.CreateNoWindow = true;
            p30.Start();
            richTextBox1.Text = richTextBox1.Text + p30.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p30.WaitForExit();

            Process p31 = new Process();
            p31.StartInfo.UseShellExecute = false;
            p31.StartInfo.RedirectStandardOutput = true;
            p31.StartInfo.FileName = "cmd.exe";
            p31.StartInfo.Arguments = "/c echo flashing keymaster_a.. ";
            p31.StartInfo.CreateNoWindow = true;
            p31.Start();
            richTextBox1.Text = richTextBox1.Text + p31.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p31.WaitForExit();

            Process p32 = new Process();
            p32.StartInfo.UseShellExecute = false;
            p32.StartInfo.RedirectStandardOutput = true;
            p32.StartInfo.FileName = "cmd.exe";
            p32.StartInfo.Arguments = "/c fastboot flash keymaster_a DRG-354H-0-00WW-B01-keymaster.img  2>>log.txt ";
            p32.StartInfo.CreateNoWindow = true;
            p32.Start();
            richTextBox1.Text = richTextBox1.Text + p32.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p32.WaitForExit();

            Process p33 = new Process();
            p33.StartInfo.UseShellExecute = false;
            p33.StartInfo.RedirectStandardOutput = true;
            p33.StartInfo.FileName = "cmd.exe";
            p33.StartInfo.Arguments = "/c echo Flashing mdtp_a.. ";
            p33.StartInfo.CreateNoWindow = true;
            p33.Start();
            richTextBox1.Text = richTextBox1.Text + p33.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p33.WaitForExit();

            Process p34 = new Process();
            p34.StartInfo.UseShellExecute = false;
            p34.StartInfo.RedirectStandardOutput = true;
            p34.StartInfo.FileName = "cmd.exe";
            p34.StartInfo.Arguments = "/c fastboot flash mdtp_a DRG-354H-0-00WW-B01-mdtp.img  2>>log.txt ";
            p34.StartInfo.CreateNoWindow = true;
            p34.Start();
            richTextBox1.Text = richTextBox1.Text + p34.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p34.WaitForExit();

            Process p35 = new Process();
            p35.StartInfo.UseShellExecute = false;
            p35.StartInfo.RedirectStandardOutput = true;
            p35.StartInfo.FileName = "cmd.exe";
            p35.StartInfo.Arguments = "/c echo Flashing mdtpsecapp_a.. ";
            p35.StartInfo.CreateNoWindow = true;
            p35.Start();
            richTextBox1.Text = richTextBox1.Text + p35.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p35.WaitForExit();

            Process p36 = new Process();
            p36.StartInfo.UseShellExecute = false;
            p36.StartInfo.RedirectStandardOutput = true;
            p36.StartInfo.FileName = "cmd.exe";
            p36.StartInfo.Arguments = "/c fastboot flash mdtpsecapp_a DRG-354H-0-00WW-B01-mdtpsecapp.img  2>>log.txt ";
            p36.StartInfo.CreateNoWindow = true;
            p36.Start();
            richTextBox1.Text = richTextBox1.Text + p36.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p36.WaitForExit();

            Process p37 = new Process();
            p37.StartInfo.UseShellExecute = false;
            p37.StartInfo.RedirectStandardOutput = true;
            p37.StartInfo.FileName = "cmd.exe";
            p37.StartInfo.Arguments = "/c echo Flashing modem_a.. ";
            p37.StartInfo.CreateNoWindow = true;
            p37.Start();
            richTextBox1.Text = richTextBox1.Text + p37.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p37.WaitForExit();

            Process p38 = new Process();
            p38.StartInfo.UseShellExecute = false;
            p38.StartInfo.RedirectStandardOutput = true;
            p38.StartInfo.FileName = "cmd.exe";
            p38.StartInfo.Arguments = "/c fastboot flash modem_a DRG-354H-0-00WW-B01-modem.img  2>>log.txt ";
            p38.StartInfo.CreateNoWindow = true;
            p38.Start();
            richTextBox1.Text = richTextBox1.Text + p38.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p38.WaitForExit();

            Process p39 = new Process();
            p39.StartInfo.UseShellExecute = false;
            p39.StartInfo.RedirectStandardOutput = true;
            p39.StartInfo.FileName = "cmd.exe";
            p39.StartInfo.Arguments = "/c echo Flashing nvdef_a.. ";
            p39.StartInfo.CreateNoWindow = true;
            p39.Start();
            richTextBox1.Text = richTextBox1.Text + p39.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p39.WaitForExit();

            Process p40 = new Process();
            p40.StartInfo.UseShellExecute = false;
            p40.StartInfo.RedirectStandardOutput = true;
            p40.StartInfo.FileName = "cmd.exe";
            p40.StartInfo.Arguments = "/c fastboot flash nvdef_a DRG-354H-0-00WW-B01-nvdef.img  2>>log.txt ";
            p40.StartInfo.CreateNoWindow = true;
            p40.Start();
            richTextBox1.Text = richTextBox1.Text + p40.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p40.WaitForExit();

            Process p41 = new Process();
            p41.StartInfo.UseShellExecute = false;
            p41.StartInfo.RedirectStandardOutput = true;
            p41.StartInfo.FileName = "cmd.exe";
            p41.StartInfo.Arguments = "/c echo Flashing pmic_a.. ";
            p41.StartInfo.CreateNoWindow = true;
            p41.Start();
            richTextBox1.Text = richTextBox1.Text + p41.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p41.WaitForExit();

            Process p42 = new Process();
            p42.StartInfo.UseShellExecute = false;
            p42.StartInfo.RedirectStandardOutput = true;
            p42.StartInfo.FileName = "cmd.exe";
            p42.StartInfo.Arguments = "/c fastboot flash pmic_a DRG-354H-0-00WW-B01-pmic.img  2>>log.txt";
            p42.StartInfo.CreateNoWindow = true;
            p42.Start();
            richTextBox1.Text = richTextBox1.Text + p42.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p42.WaitForExit();

            Process p43 = new Process();
            p43.StartInfo.UseShellExecute = false;
            p43.StartInfo.RedirectStandardOutput = true;
            p43.StartInfo.FileName = "cmd.exe";
            p43.StartInfo.Arguments = "/c echo FLashing rpm_a.. ";
            p43.StartInfo.CreateNoWindow = true;
            p43.Start();
            richTextBox1.Text = richTextBox1.Text + p43.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p43.WaitForExit();

            Process p44 = new Process();
            p44.StartInfo.UseShellExecute = false;
            p44.StartInfo.RedirectStandardOutput = true;
            p44.StartInfo.FileName = "cmd.exe";
            p44.StartInfo.Arguments = "/c fastboot flash rpm_a DRG-354H-0-00WW-B01-rpm.img  2>>log.txt ";
            p44.StartInfo.CreateNoWindow = true;
            p44.Start();
            richTextBox1.Text = richTextBox1.Text + p44.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p44.WaitForExit();

            Process p45 = new Process();
            p45.StartInfo.UseShellExecute = false;
            p45.StartInfo.RedirectStandardOutput = true;
            p45.StartInfo.FileName = "cmd.exe";
            p45.StartInfo.Arguments = "/c echo Flashing splash_a.. ";
            p45.StartInfo.CreateNoWindow = true;
            p45.Start();
            richTextBox1.Text = richTextBox1.Text + p45.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p45.WaitForExit();

            Process p46 = new Process();
            p46.StartInfo.UseShellExecute = false;
            p46.StartInfo.RedirectStandardOutput = true;
            p46.StartInfo.FileName = "cmd.exe";
            p46.StartInfo.Arguments = "/c fastboot flash splash_a DRG-354H-0-00WW-B01-splash.img  2>>log.txt ";
            p46.StartInfo.CreateNoWindow = true;
            p46.Start();
            richTextBox1.Text = richTextBox1.Text + p46.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p46.WaitForExit();

            Process p47 = new Process();
            p47.StartInfo.UseShellExecute = false;
            p47.StartInfo.RedirectStandardOutput = true;
            p47.StartInfo.FileName = "cmd.exe";
            p47.StartInfo.Arguments = "/c echo Flashing system_a.. ";
            p47.StartInfo.CreateNoWindow = true;
            p47.Start();
            richTextBox1.Text = richTextBox1.Text + p47.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p47.WaitForExit();

            Process p48 = new Process();
            p48.StartInfo.UseShellExecute = false;
            p48.StartInfo.RedirectStandardOutput = true;
            p48.StartInfo.FileName = "cmd.exe";
            p48.StartInfo.Arguments = "/c fastboot flash system_a DRG-354H-0-00WW-B01-system.img  2>>log.txt ";
            p48.StartInfo.CreateNoWindow = true;
            p48.Start();
            richTextBox1.Text = richTextBox1.Text + p48.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p48.WaitForExit();

            Process p49 = new Process();
            p49.StartInfo.UseShellExecute = false;
            p49.StartInfo.RedirectStandardOutput = true;
            p49.StartInfo.FileName = "cmd.exe";
            p49.StartInfo.Arguments = "/c echo Flashing systeminfo_a.. ";
            p49.StartInfo.CreateNoWindow = true;
            p49.Start();
            richTextBox1.Text = richTextBox1.Text + p49.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p49.WaitForExit();

            Process p50 = new Process();
            p50.StartInfo.UseShellExecute = false;
            p50.StartInfo.RedirectStandardOutput = true;
            p50.StartInfo.FileName = "cmd.exe";
            p50.StartInfo.Arguments = "/c fastboot flash systeminfo_a DRG-354H-0-00WW-B01-systeminfo.img  2>>log.txt";
            p50.StartInfo.CreateNoWindow = true;
            p50.Start();
            richTextBox1.Text = richTextBox1.Text + p50.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p50.WaitForExit();

            Process p51 = new Process();
            p51.StartInfo.UseShellExecute = false;
            p51.StartInfo.RedirectStandardOutput = true;
            p51.StartInfo.FileName = "cmd.exe";
            p51.StartInfo.Arguments = "/c echo Flshing tz_a.";
            p51.StartInfo.CreateNoWindow = true;
            p51.Start();
            richTextBox1.Text = richTextBox1.Text + p51.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p51.WaitForExit();

            Process p52 = new Process();
            p52.StartInfo.UseShellExecute = false;
            p52.StartInfo.RedirectStandardOutput = true;
            p52.StartInfo.FileName = "cmd.exe";
            p52.StartInfo.Arguments = "/c fastboot flash tz_a DRG-354H-0-00WW-B01-tz.img  2>>log.txt";
            p52.StartInfo.CreateNoWindow = true;
            p52.Start();
            richTextBox1.Text = richTextBox1.Text + p52.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p52.WaitForExit();

            Process p53 = new Process();
            p53.StartInfo.UseShellExecute = false;
            p53.StartInfo.RedirectStandardOutput = true;
            p53.StartInfo.FileName = "cmd.exe";
            p53.StartInfo.Arguments = "/c echo Flashing vendor_a.. ";
            p53.StartInfo.CreateNoWindow = true;
            p53.Start();
            richTextBox1.Text = richTextBox1.Text + p53.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p53.WaitForExit();

            Process p54 = new Process();
            p54.StartInfo.UseShellExecute = false;
            p54.StartInfo.RedirectStandardOutput = true;
            p54.StartInfo.FileName = "cmd.exe";
            p54.StartInfo.Arguments = "/c fastboot flash vendor_a DRG-354H-0-00WW-B01-vendor.img  2>>log.txt ";
            p54.StartInfo.CreateNoWindow = true;
            p54.Start();
            richTextBox1.Text = richTextBox1.Text + p54.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p54.WaitForExit();

            Process p55 = new Process();
            p55.StartInfo.UseShellExecute = false;
            p55.StartInfo.RedirectStandardOutput = true;
            p55.StartInfo.FileName = "cmd.exe";
            p55.StartInfo.Arguments = "/c echo Erase ssd..";
            p55.StartInfo.CreateNoWindow = true;
            p55.Start();
            richTextBox1.Text = richTextBox1.Text + p55.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p55.WaitForExit();

            Process p56 = new Process();
            p56.StartInfo.UseShellExecute = false;
            p56.StartInfo.RedirectStandardOutput = true;
            p56.StartInfo.FileName = "cmd.exe";
            p56.StartInfo.Arguments = "/c fastboot erase ssd ";
            p56.StartInfo.CreateNoWindow = true;
            p56.Start();
            richTextBox1.Text = richTextBox1.Text + p56.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p56.WaitForExit();

            Process p57 = new Process();
            p57.StartInfo.UseShellExecute = false;
            p57.StartInfo.RedirectStandardOutput = true;
            p57.StartInfo.FileName = "cmd.exe";
            p57.StartInfo.Arguments = "/c echo Erase misc.. ";
            p57.StartInfo.CreateNoWindow = true;
            p57.Start();
            richTextBox1.Text = richTextBox1.Text + p57.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p57.WaitForExit();

            Process p58 = new Process();
            p58.StartInfo.UseShellExecute = false;
            p58.StartInfo.RedirectStandardOutput = true;
            p58.StartInfo.FileName = "cmd.exe";
            p58.StartInfo.Arguments = "/c fastboot erase misc ";
            p58.StartInfo.CreateNoWindow = true;
            p58.Start();
            richTextBox1.Text = richTextBox1.Text + p58.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p58.WaitForExit();

            Process p59 = new Process();
            p59.StartInfo.UseShellExecute = false;
            p59.StartInfo.RedirectStandardOutput = true;
            p59.StartInfo.FileName = "cmd.exe";
            p59.StartInfo.Arguments = "/c echo Erase sti.. ";
            p59.StartInfo.CreateNoWindow = true;
            p59.Start();
            richTextBox1.Text = richTextBox1.Text + p59.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p59.WaitForExit();

            Process p60 = new Process();
            p60.StartInfo.UseShellExecute = false;
            p60.StartInfo.RedirectStandardOutput = true;
            p60.StartInfo.FileName = "cmd.exe";
            p60.StartInfo.Arguments = "/c fastboot erase sti ";
            p60.StartInfo.CreateNoWindow = true;
            p60.Start();
            richTextBox1.Text = richTextBox1.Text + p60.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p60.WaitForExit();

            Process p61 = new Process();
            p61.StartInfo.UseShellExecute = false;
            p61.StartInfo.RedirectStandardOutput = true;
            p61.StartInfo.FileName = "cmd.exe";
            p61.StartInfo.Arguments = "/c echo Erase ddr.. ";
            p61.StartInfo.CreateNoWindow = true;
            p61.Start();
            richTextBox1.Text = richTextBox1.Text + p61.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p61.WaitForExit();

            Process p62 = new Process();
            p62.StartInfo.UseShellExecute = false;
            p62.StartInfo.RedirectStandardOutput = true;
            p62.StartInfo.FileName = "cmd.exe";
            p62.StartInfo.Arguments = "/c fastboot erase ddr ";
            p62.StartInfo.CreateNoWindow = true;
            p62.Start();
            richTextBox1.Text = richTextBox1.Text + p62.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p62.WaitForExit();

            Process p63 = new Process();
            p63.StartInfo.UseShellExecute = false;
            p63.StartInfo.RedirectStandardOutput = true;
            p63.StartInfo.FileName = "cmd.exe";
            p63.StartInfo.Arguments = "/c echo Erase securefs.. ";
            p63.StartInfo.CreateNoWindow = true;
            p63.Start();
            richTextBox1.Text = richTextBox1.Text + p63.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p63.WaitForExit();

            Process p64 = new Process();
            p64.StartInfo.UseShellExecute = false;
            p64.StartInfo.RedirectStandardOutput = true;
            p64.StartInfo.FileName = "cmd.exe";
            p64.StartInfo.Arguments = "/c fastboot erase securefs ";
            p64.StartInfo.CreateNoWindow = true;
            p64.Start();
            richTextBox1.Text = richTextBox1.Text + p64.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p64.WaitForExit();

            Process p65 = new Process();
            p65.StartInfo.UseShellExecute = false;
            p65.StartInfo.RedirectStandardOutput = true;
            p65.StartInfo.FileName = "cmd.exe";
            p65.StartInfo.Arguments = "/c echo Erase box.. ";
            p65.StartInfo.CreateNoWindow = true;
            p65.Start();
            richTextBox1.Text = richTextBox1.Text + p65.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p65.WaitForExit();

            Process p66 = new Process();
            p66.StartInfo.UseShellExecute = false;
            p66.StartInfo.RedirectStandardOutput = true;
            p66.StartInfo.FileName = "cmd.exe";
            p66.StartInfo.Arguments = "/c fastboot erase box ";
            p66.StartInfo.CreateNoWindow = true;
            p66.Start();
            richTextBox1.Text = richTextBox1.Text + p66.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p66.WaitForExit();

            Process p67 = new Process();
            p67.StartInfo.UseShellExecute = false;
            p67.StartInfo.RedirectStandardOutput = true;
            p67.StartInfo.FileName = "cmd.exe";
            p67.StartInfo.Arguments = "/c echo Erase boot_b.. ";
            p67.StartInfo.CreateNoWindow = true;
            p67.Start();
            richTextBox1.Text = richTextBox1.Text + p67.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p67.WaitForExit();

            Process p68 = new Process();
            p68.StartInfo.UseShellExecute = false;
            p68.StartInfo.RedirectStandardOutput = true;
            p68.StartInfo.FileName = "cmd.exe";
            p68.StartInfo.Arguments = "/c fastboot erase boot_b ";
            p68.StartInfo.CreateNoWindow = true;
            p68.Start();
            richTextBox1.Text = richTextBox1.Text + p68.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p68.WaitForExit();

            Process p69 = new Process();
            p69.StartInfo.UseShellExecute = false;
            p69.StartInfo.RedirectStandardOutput = true;
            p69.StartInfo.FileName = "cmd.exe";
            p69.StartInfo.Arguments = "/c echo set active slot A.. ";
            p69.StartInfo.CreateNoWindow = true;
            p69.Start();
            richTextBox1.Text = richTextBox1.Text + p69.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p69.WaitForExit();

            Process p70 = new Process();
            p70.StartInfo.UseShellExecute = false;
            p70.StartInfo.RedirectStandardOutput = true;
            p70.StartInfo.FileName = "cmd.exe";
            p70.StartInfo.Arguments = "/c fastboot --set-active=a ";
            p70.StartInfo.CreateNoWindow = true;
            p70.Start();
            richTextBox1.Text = richTextBox1.Text + p70.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p70.WaitForExit();

            Process p71 = new Process();
            p71.StartInfo.UseShellExecute = false;
            p71.StartInfo.RedirectStandardOutput = true;
            p71.StartInfo.FileName = "cmd.exe";
            p71.StartInfo.Arguments = "/c echo Erase Userdata.. ";
            p71.StartInfo.CreateNoWindow = true;
            p71.Start();
            richTextBox1.Text = richTextBox1.Text + p71.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p71.WaitForExit();

            Process p72 = new Process();
            p72.StartInfo.UseShellExecute = false;
            p72.StartInfo.RedirectStandardOutput = true;
            p72.StartInfo.FileName = "cmd.exe";
            p72.StartInfo.Arguments = "/c fastboot -w ";
            p72.StartInfo.CreateNoWindow = true;
            p72.Start();
            richTextBox1.Refresh();

            Process p73 = new Process();
            p73.StartInfo.UseShellExecute = false;
            p73.StartInfo.RedirectStandardOutput = true;
            p73.StartInfo.FileName = "cmd.exe";
            p73.StartInfo.Arguments = "/c echo Rebooting system.. ";
            p73.StartInfo.CreateNoWindow = true;
            p73.Start();
            richTextBox1.Text = richTextBox1.Text + p73.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p73.WaitForExit();

            Process p74 = new Process();
            p74.StartInfo.UseShellExecute = false;
            p74.StartInfo.RedirectStandardOutput = true;
            p74.StartInfo.FileName = "cmd.exe";
            p74.StartInfo.Arguments = "/c fastboot reboot ";
            p74.StartInfo.CreateNoWindow = true;
            p74.Start();
            richTextBox1.Text = richTextBox1.Text + p74.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p74.WaitForExit();

        }


        private void button2_Click(object sender, EventArgs e)
        {
            Process p1 = new Process();
            p1.StartInfo.UseShellExecute = false;
            p1.StartInfo.RedirectStandardOutput = true;
            p1.StartInfo.FileName = "cmd.exe";
            p1.StartInfo.Arguments = "/c echo getversions..";
            p1.StartInfo.CreateNoWindow = true;
            p1.Start();
            richTextBox1.Text = richTextBox1.Text + p1.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p1.WaitForExit();


            Process p2 = new Process();
            p2.StartInfo.UseShellExecute = false;
            p2.StartInfo.RedirectStandardOutput = true;
            p2.StartInfo.FileName = "cmd.exe";
            p2.StartInfo.Arguments = "/c fastboot oem getversions 2>getver.txt & type getver.txt ";
            p2.StartInfo.CreateNoWindow = true;
            p2.Start();
            richTextBox1.Text = richTextBox1.Text + p2.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p2.WaitForExit();

            Process p3 = new Process();
            p3.StartInfo.UseShellExecute = false;
            p3.StartInfo.RedirectStandardOutput = true;
            p3.StartInfo.FileName = "cmd.exe";
            p3.StartInfo.Arguments = "/c echo device-info..";
            p3.StartInfo.CreateNoWindow = true;
            p3.Start();
            richTextBox1.Text = richTextBox1.Text + p3.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p3.WaitForExit();


            Process p4 = new Process();
            p4.StartInfo.UseShellExecute = false;
            p4.StartInfo.RedirectStandardOutput = true;
            p4.StartInfo.FileName = "cmd.exe";
            p4.StartInfo.Arguments = "/c fastboot oem device-info 2>device.txt & type device.txt  ";
            p4.StartInfo.CreateNoWindow = true;
            p4.Start();
            richTextBox1.Text = richTextBox1.Text + p4.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p4.WaitForExit();

            Process p5 = new Process();
            p5.StartInfo.UseShellExecute = false;
            p5.StartInfo.RedirectStandardOutput = true;
            p5.StartInfo.FileName = "cmd.exe";
            p5.StartInfo.Arguments = "/c echo Flashing abl_a..";
            p5.StartInfo.CreateNoWindow = true;
            p5.Start();
            richTextBox1.Text = richTextBox1.Text + p5.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p5.WaitForExit();


            Process p6 = new Process();
            p6.StartInfo.UseShellExecute = false;
            p6.StartInfo.RedirectStandardOutput = true;
            p6.StartInfo.FileName = "cmd.exe";
            p6.StartInfo.Arguments = "/c fastboot flash abl_a DRG-354E-0-00WW-B01-abl.img  2>>log.txt  ";
            p6.StartInfo.CreateNoWindow = true;
            p6.Start();
            richTextBox1.Text = richTextBox1.Text + p6.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p6.WaitForExit();

            Process p7 = new Process();
            p7.StartInfo.UseShellExecute = false;
            p7.StartInfo.RedirectStandardOutput = true;
            p7.StartInfo.FileName = "cmd.exe";
            p7.StartInfo.Arguments = "/c echo Flashing abl_b..";
            p7.StartInfo.CreateNoWindow = true;
            p7.Start();
            richTextBox1.Text = richTextBox1.Text + p7.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p7.WaitForExit();

            Process p8 = new Process();
            p8.StartInfo.UseShellExecute = false;
            p8.StartInfo.RedirectStandardOutput = true;
            p8.StartInfo.FileName = "cmd.exe";
            p8.StartInfo.Arguments = "/c fastboot flash abl_b DRG-354E-0-00WW-B01-abl.img  2>>log.txt ";
            p8.StartInfo.CreateNoWindow = true;
            p8.Start();
            richTextBox1.Text = richTextBox1.Text + p8.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p8.WaitForExit();

            Process p9 = new Process();
            p9.StartInfo.UseShellExecute = false;
            p9.StartInfo.RedirectStandardOutput = true;
            p9.StartInfo.FileName = "cmd.exe";
            p9.StartInfo.Arguments = "/c echo FLashing xbl_a..";
            p9.StartInfo.CreateNoWindow = true;
            p9.Start();
            richTextBox1.Text = richTextBox1.Text + p9.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p9.WaitForExit();

            Process p10 = new Process();
            p10.StartInfo.UseShellExecute = false;
            p10.StartInfo.RedirectStandardOutput = true;
            p10.StartInfo.FileName = "cmd.exe";
            p10.StartInfo.Arguments = "/c fastboot flash xbl_a DRG-354E-0-00WW-B01-xbl.img  2>>log.txt ";
            p10.StartInfo.CreateNoWindow = true;
            p10.Start();
            richTextBox1.Text = richTextBox1.Text + p10.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p10.WaitForExit();

            Process p11 = new Process();
            p11.StartInfo.UseShellExecute = false;
            p11.StartInfo.RedirectStandardOutput = true;
            p11.StartInfo.FileName = "cmd.exe";
            p11.StartInfo.Arguments = "/c echo Flashing xbl_b.. ";
            p11.StartInfo.CreateNoWindow = true;
            p11.Start();
            richTextBox1.Text = richTextBox1.Text + p11.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p11.WaitForExit();

            Process p12 = new Process();
            p12.StartInfo.UseShellExecute = false;
            p12.StartInfo.RedirectStandardOutput = true;
            p12.StartInfo.FileName = "cmd.exe";
            p12.StartInfo.Arguments = "/c fastboot flash xbl_b DRG-354E-0-00WW-B01-xbl.img  2>>log.txt ";
            p12.StartInfo.CreateNoWindow = true;
            p12.Start();
            richTextBox1.Text = richTextBox1.Text + p12.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p12.WaitForExit();

            Process p13 = new Process();
            p13.StartInfo.UseShellExecute = false;
            p13.StartInfo.RedirectStandardOutput = true;
            p13.StartInfo.FileName = "cmd.exe";
            p13.StartInfo.Arguments = "/c echo Flashing bluetooth_a.. ";
            p13.StartInfo.CreateNoWindow = true;
            p13.Start();
            richTextBox1.Text = richTextBox1.Text + p13.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p13.WaitForExit();

            Process p14 = new Process();
            p14.StartInfo.UseShellExecute = false;
            p14.StartInfo.RedirectStandardOutput = true;
            p14.StartInfo.FileName = "cmd.exe";
            p14.StartInfo.Arguments = "/c fastboot flash bluetooth_a DRG-354E-0-00WW-B01-bluetooth.img  2>>log.txt ";
            p14.StartInfo.CreateNoWindow = true;
            p14.Start();
            richTextBox1.Text = richTextBox1.Text + p14.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p14.WaitForExit();

            Process p15 = new Process();
            p15.StartInfo.UseShellExecute = false;
            p15.StartInfo.RedirectStandardOutput = true;
            p15.StartInfo.FileName = "cmd.exe";
            p15.StartInfo.Arguments = "/c echo Flashing boot_a.. ";
            p15.StartInfo.CreateNoWindow = true;
            p15.Start();
            richTextBox1.Text = richTextBox1.Text + p15.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p15.WaitForExit();

            Process p16 = new Process();
            p16.StartInfo.UseShellExecute = false;
            p16.StartInfo.RedirectStandardOutput = true;
            p16.StartInfo.FileName = "cmd.exe";
            p16.StartInfo.Arguments = "/c fastboot flash boot_a DRG-354E-0-00WW-B01-boot.img  2>>log.txt ";
            p16.StartInfo.CreateNoWindow = true;
            p16.Start();
            richTextBox1.Text = richTextBox1.Text + p16.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p16.WaitForExit();

            Process p17 = new Process();
            p17.StartInfo.UseShellExecute = false;
            p17.StartInfo.RedirectStandardOutput = true;
            p17.StartInfo.FileName = "cmd.exe";
            p17.StartInfo.Arguments = "/c echo Flashing cda_a.. ";
            p17.StartInfo.CreateNoWindow = true;
            p17.Start();
            richTextBox1.Text = richTextBox1.Text + p17.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p17.WaitForExit();

            Process p18 = new Process();
            p18.StartInfo.UseShellExecute = false;
            p18.StartInfo.RedirectStandardOutput = true;
            p18.StartInfo.FileName = "cmd.exe";
            p18.StartInfo.Arguments = "/c fastboot flash cda_a DRG-354E-0-00WW-B01-cda.img  2>>log.txt ";
            p18.StartInfo.CreateNoWindow = true;
            p18.Start();
            richTextBox1.Text = richTextBox1.Text + p18.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p18.WaitForExit();

            Process p19 = new Process();
            p19.StartInfo.UseShellExecute = false;
            p19.StartInfo.RedirectStandardOutput = true;
            p19.StartInfo.FileName = "cmd.exe";
            p19.StartInfo.Arguments = "/c echo Flashing cmnlib_a.. ";
            p19.StartInfo.CreateNoWindow = true;
            p19.Start();
            richTextBox1.Text = richTextBox1.Text + p19.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p19.WaitForExit();

            Process p20 = new Process();
            p20.StartInfo.UseShellExecute = false;
            p20.StartInfo.RedirectStandardOutput = true;
            p20.StartInfo.FileName = "cmd.exe";
            p20.StartInfo.Arguments = "/c fastboot flash cmnlib_a DRG-354E-0-00WW-B01-cmnlib.img  2>>log.txt ";
            p20.StartInfo.CreateNoWindow = true;
            p20.Start();
            richTextBox1.Text = richTextBox1.Text + p20.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p20.WaitForExit();

            Process p21 = new Process();
            p21.StartInfo.UseShellExecute = false;
            p21.StartInfo.RedirectStandardOutput = true;
            p21.StartInfo.FileName = "cmd.exe";
            p21.StartInfo.Arguments = "/c echo Flashing cmnlib64_a.. ";
            p21.StartInfo.CreateNoWindow = true;
            p21.Start();
            richTextBox1.Text = richTextBox1.Text + p21.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p21.WaitForExit();

            Process p22 = new Process();
            p22.StartInfo.UseShellExecute = false;
            p22.StartInfo.RedirectStandardOutput = true;
            p22.StartInfo.FileName = "cmd.exe";
            p22.StartInfo.Arguments = "/c fastboot flash cmnlib64_a DRG-354E-0-00WW-B01-cmnlib64.img  2>>log.txt ";
            p22.StartInfo.CreateNoWindow = true;
            p22.Start();
            richTextBox1.Text = richTextBox1.Text + p22.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p22.WaitForExit();

            Process p23 = new Process();
            p23.StartInfo.UseShellExecute = false;
            p23.StartInfo.RedirectStandardOutput = true;
            p23.StartInfo.FileName = "cmd.exe";
            p23.StartInfo.Arguments = "/c echo Flashing devcfg_a.. ";
            p23.StartInfo.CreateNoWindow = true;
            p23.Start();
            richTextBox1.Text = richTextBox1.Text + p23.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p23.WaitForExit();

            Process p24 = new Process();
            p24.StartInfo.UseShellExecute = false;
            p24.StartInfo.RedirectStandardOutput = true;
            p24.StartInfo.FileName = "cmd.exe";
            p24.StartInfo.Arguments = "/c fastboot flash devcfg_a DRG-354E-0-00WW-B01-devcfg.img  2>>log.txt ";
            p24.StartInfo.CreateNoWindow = true;
            p24.Start();
            richTextBox1.Text = richTextBox1.Text + p24.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p24.WaitForExit();

            Process p25 = new Process();
            p25.StartInfo.UseShellExecute = false;
            p25.StartInfo.RedirectStandardOutput = true;
            p25.StartInfo.FileName = "cmd.exe";
            p25.StartInfo.Arguments = "/c echo Flashing dsp_a.. ";
            p25.StartInfo.CreateNoWindow = true;
            p25.Start();
            richTextBox1.Text = richTextBox1.Text + p25.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p25.WaitForExit();

            Process p26 = new Process();
            p26.StartInfo.UseShellExecute = false;
            p26.StartInfo.RedirectStandardOutput = true;
            p26.StartInfo.FileName = "cmd.exe";
            p26.StartInfo.Arguments = "/c fastboot flash dsp_a DRG-354E-0-00WW-B01-dsp.img  2>>log.txt ";
            p26.StartInfo.CreateNoWindow = true;
            p26.Start();
            richTextBox1.Text = richTextBox1.Text + p26.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p26.WaitForExit();

            Process p27 = new Process();
            p27.StartInfo.UseShellExecute = false;
            p27.StartInfo.RedirectStandardOutput = true;
            p27.StartInfo.FileName = "cmd.exe";
            p27.StartInfo.Arguments = "/c echo Flashing hidden_a.. ";
            p27.StartInfo.CreateNoWindow = true;
            p27.Start();
            richTextBox1.Text = richTextBox1.Text + p27.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p27.WaitForExit();

            Process p28 = new Process();
            p28.StartInfo.UseShellExecute = false;
            p28.StartInfo.RedirectStandardOutput = true;
            p28.StartInfo.FileName = "cmd.exe";
            p28.StartInfo.Arguments = "/c fastboot flash hidden_a DRG-354E-0-00WW-B01-hidden.img  2>>log.txt ";
            p28.StartInfo.CreateNoWindow = true;
            p28.Start();
            richTextBox1.Text = richTextBox1.Text + p28.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p28.WaitForExit();

            Process p29 = new Process();
            p29.StartInfo.UseShellExecute = false;
            p29.StartInfo.RedirectStandardOutput = true;
            p29.StartInfo.FileName = "cmd.exe";
            p29.StartInfo.Arguments = "/c echo Flashing hyp_a.. ";
            p29.StartInfo.CreateNoWindow = true;
            p29.Start();
            richTextBox1.Text = richTextBox1.Text + p29.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p29.WaitForExit();

            Process p30 = new Process();
            p30.StartInfo.UseShellExecute = false;
            p30.StartInfo.RedirectStandardOutput = true;
            p30.StartInfo.FileName = "cmd.exe";
            p30.StartInfo.Arguments = "/c fastboot flash hyp_a DRG-354E-0-00WW-B01-hyp.img  2>>log.txt ";
            p30.StartInfo.CreateNoWindow = true;
            p30.Start();
            richTextBox1.Text = richTextBox1.Text + p30.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p30.WaitForExit();

            Process p31 = new Process();
            p31.StartInfo.UseShellExecute = false;
            p31.StartInfo.RedirectStandardOutput = true;
            p31.StartInfo.FileName = "cmd.exe";
            p31.StartInfo.Arguments = "/c echo flashing keymaster_a.. ";
            p31.StartInfo.CreateNoWindow = true;
            p31.Start();
            richTextBox1.Text = richTextBox1.Text + p31.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p31.WaitForExit();

            Process p32 = new Process();
            p32.StartInfo.UseShellExecute = false;
            p32.StartInfo.RedirectStandardOutput = true;
            p32.StartInfo.FileName = "cmd.exe";
            p32.StartInfo.Arguments = "/c fastboot flash keymaster_a DRG-354E-0-00WW-B01-keymaster.img  2>>log.txt ";
            p32.StartInfo.CreateNoWindow = true;
            p32.Start();
            richTextBox1.Text = richTextBox1.Text + p32.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p32.WaitForExit();

            Process p33 = new Process();
            p33.StartInfo.UseShellExecute = false;
            p33.StartInfo.RedirectStandardOutput = true;
            p33.StartInfo.FileName = "cmd.exe";
            p33.StartInfo.Arguments = "/c echo Flashing mdtp_a.. ";
            p33.StartInfo.CreateNoWindow = true;
            p33.Start();
            richTextBox1.Text = richTextBox1.Text + p33.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p33.WaitForExit();

            Process p34 = new Process();
            p34.StartInfo.UseShellExecute = false;
            p34.StartInfo.RedirectStandardOutput = true;
            p34.StartInfo.FileName = "cmd.exe";
            p34.StartInfo.Arguments = "/c fastboot flash mdtp_a DRG-354E-0-00WW-B01-mdtp.img  2>>log.txt ";
            p34.StartInfo.CreateNoWindow = true;
            p34.Start();
            richTextBox1.Text = richTextBox1.Text + p34.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p34.WaitForExit();

            Process p35 = new Process();
            p35.StartInfo.UseShellExecute = false;
            p35.StartInfo.RedirectStandardOutput = true;
            p35.StartInfo.FileName = "cmd.exe";
            p35.StartInfo.Arguments = "/c echo Flashing mdtpsecapp_a.. ";
            p35.StartInfo.CreateNoWindow = true;
            p35.Start();
            richTextBox1.Text = richTextBox1.Text + p35.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p35.WaitForExit();

            Process p36 = new Process();
            p36.StartInfo.UseShellExecute = false;
            p36.StartInfo.RedirectStandardOutput = true;
            p36.StartInfo.FileName = "cmd.exe";
            p36.StartInfo.Arguments = "/c fastboot flash mdtpsecapp_a DRG-354E-0-00WW-B01-mdtpsecapp.img  2>>log.txt ";
            p36.StartInfo.CreateNoWindow = true;
            p36.Start();
            richTextBox1.Text = richTextBox1.Text + p36.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p36.WaitForExit();

            Process p37 = new Process();
            p37.StartInfo.UseShellExecute = false;
            p37.StartInfo.RedirectStandardOutput = true;
            p37.StartInfo.FileName = "cmd.exe";
            p37.StartInfo.Arguments = "/c echo Flashing modem_a.. ";
            p37.StartInfo.CreateNoWindow = true;
            p37.Start();
            richTextBox1.Text = richTextBox1.Text + p37.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p37.WaitForExit();

            Process p38 = new Process();
            p38.StartInfo.UseShellExecute = false;
            p38.StartInfo.RedirectStandardOutput = true;
            p38.StartInfo.FileName = "cmd.exe";
            p38.StartInfo.Arguments = "/c fastboot flash modem_a DRG-354E-0-00WW-B01-modem.img  2>>log.txt ";
            p38.StartInfo.CreateNoWindow = true;
            p38.Start();
            richTextBox1.Text = richTextBox1.Text + p38.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p38.WaitForExit();

            Process p39 = new Process();
            p39.StartInfo.UseShellExecute = false;
            p39.StartInfo.RedirectStandardOutput = true;
            p39.StartInfo.FileName = "cmd.exe";
            p39.StartInfo.Arguments = "/c echo Flashing nvdef_a.. ";
            p39.StartInfo.CreateNoWindow = true;
            p39.Start();
            richTextBox1.Text = richTextBox1.Text + p39.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p39.WaitForExit();

            Process p40 = new Process();
            p40.StartInfo.UseShellExecute = false;
            p40.StartInfo.RedirectStandardOutput = true;
            p40.StartInfo.FileName = "cmd.exe";
            p40.StartInfo.Arguments = "/c fastboot flash nvdef_a DRG-354E-0-00WW-B01-nvdef.img  2>>log.txt ";
            p40.StartInfo.CreateNoWindow = true;
            p40.Start();
            richTextBox1.Text = richTextBox1.Text + p40.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p40.WaitForExit();

            Process p41 = new Process();
            p41.StartInfo.UseShellExecute = false;
            p41.StartInfo.RedirectStandardOutput = true;
            p41.StartInfo.FileName = "cmd.exe";
            p41.StartInfo.Arguments = "/c echo Flashing pmic_a.. ";
            p41.StartInfo.CreateNoWindow = true;
            p41.Start();
            richTextBox1.Text = richTextBox1.Text + p41.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p41.WaitForExit();

            Process p42 = new Process();
            p42.StartInfo.UseShellExecute = false;
            p42.StartInfo.RedirectStandardOutput = true;
            p42.StartInfo.FileName = "cmd.exe";
            p42.StartInfo.Arguments = "/c fastboot flash pmic_a DRG-354E-0-00WW-B01-pmic.img  2>>log.txt";
            p42.StartInfo.CreateNoWindow = true;
            p42.Start();
            richTextBox1.Text = richTextBox1.Text + p42.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p42.WaitForExit();

            Process p43 = new Process();
            p43.StartInfo.UseShellExecute = false;
            p43.StartInfo.RedirectStandardOutput = true;
            p43.StartInfo.FileName = "cmd.exe";
            p43.StartInfo.Arguments = "/c echo FLashing rpm_a.. ";
            p43.StartInfo.CreateNoWindow = true;
            p43.Start();
            richTextBox1.Text = richTextBox1.Text + p43.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p43.WaitForExit();

            Process p44 = new Process();
            p44.StartInfo.UseShellExecute = false;
            p44.StartInfo.RedirectStandardOutput = true;
            p44.StartInfo.FileName = "cmd.exe";
            p44.StartInfo.Arguments = "/c fastboot flash rpm_a DRG-354E-0-00WW-B01-rpm.img  2>>log.txt ";
            p44.StartInfo.CreateNoWindow = true;
            p44.Start();
            richTextBox1.Text = richTextBox1.Text + p44.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p44.WaitForExit();

            Process p45 = new Process();
            p45.StartInfo.UseShellExecute = false;
            p45.StartInfo.RedirectStandardOutput = true;
            p45.StartInfo.FileName = "cmd.exe";
            p45.StartInfo.Arguments = "/c echo Flashing splash_a.. ";
            p45.StartInfo.CreateNoWindow = true;
            p45.Start();
            richTextBox1.Text = richTextBox1.Text + p45.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p45.WaitForExit();

            Process p46 = new Process();
            p46.StartInfo.UseShellExecute = false;
            p46.StartInfo.RedirectStandardOutput = true;
            p46.StartInfo.FileName = "cmd.exe";
            p46.StartInfo.Arguments = "/c fastboot flash splash_a DRG-354E-0-00WW-B01-splash.img  2>>log.txt ";
            p46.StartInfo.CreateNoWindow = true;
            p46.Start();
            richTextBox1.Text = richTextBox1.Text + p46.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p46.WaitForExit();

            Process p47 = new Process();
            p47.StartInfo.UseShellExecute = false;
            p47.StartInfo.RedirectStandardOutput = true;
            p47.StartInfo.FileName = "cmd.exe";
            p47.StartInfo.Arguments = "/c echo Flashing system_a.. ";
            p47.StartInfo.CreateNoWindow = true;
            p47.Start();
            richTextBox1.Text = richTextBox1.Text + p47.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p47.WaitForExit();

            Process p48 = new Process();
            p48.StartInfo.UseShellExecute = false;
            p48.StartInfo.RedirectStandardOutput = true;
            p48.StartInfo.FileName = "cmd.exe";
            p48.StartInfo.Arguments = "/c fastboot flash system_a DRG-354E-0-00WW-B01-system.img  2>>log.txt ";
            p48.StartInfo.CreateNoWindow = true;
            p48.Start();
            richTextBox1.Text = richTextBox1.Text + p48.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p48.WaitForExit();

            Process p49 = new Process();
            p49.StartInfo.UseShellExecute = false;
            p49.StartInfo.RedirectStandardOutput = true;
            p49.StartInfo.FileName = "cmd.exe";
            p49.StartInfo.Arguments = "/c echo Flashing systeminfo_a.. ";
            p49.StartInfo.CreateNoWindow = true;
            p49.Start();
            richTextBox1.Text = richTextBox1.Text + p49.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p49.WaitForExit();

            Process p50 = new Process();
            p50.StartInfo.UseShellExecute = false;
            p50.StartInfo.RedirectStandardOutput = true;
            p50.StartInfo.FileName = "cmd.exe";
            p50.StartInfo.Arguments = "/c fastboot flash systeminfo_a DRG-354E-0-00WW-B01-systeminfo.img  2>>log.txt";
            p50.StartInfo.CreateNoWindow = true;
            p50.Start();
            richTextBox1.Text = richTextBox1.Text + p50.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p50.WaitForExit();

            Process p51 = new Process();
            p51.StartInfo.UseShellExecute = false;
            p51.StartInfo.RedirectStandardOutput = true;
            p51.StartInfo.FileName = "cmd.exe";
            p51.StartInfo.Arguments = "/c echo Flshing tz_a.";
            p51.StartInfo.CreateNoWindow = true;
            p51.Start();
            richTextBox1.Text = richTextBox1.Text + p51.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p51.WaitForExit();

            Process p52 = new Process();
            p52.StartInfo.UseShellExecute = false;
            p52.StartInfo.RedirectStandardOutput = true;
            p52.StartInfo.FileName = "cmd.exe";
            p52.StartInfo.Arguments = "/c fastboot flash tz_a DRG-354E-0-00WW-B01-tz.img  2>>log.txt";
            p52.StartInfo.CreateNoWindow = true;
            p52.Start();
            richTextBox1.Text = richTextBox1.Text + p52.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p52.WaitForExit();

            Process p53 = new Process();
            p53.StartInfo.UseShellExecute = false;
            p53.StartInfo.RedirectStandardOutput = true;
            p53.StartInfo.FileName = "cmd.exe";
            p53.StartInfo.Arguments = "/c echo Flashing vendor_a.. ";
            p53.StartInfo.CreateNoWindow = true;
            p53.Start();
            richTextBox1.Text = richTextBox1.Text + p53.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p53.WaitForExit();

            Process p54 = new Process();
            p54.StartInfo.UseShellExecute = false;
            p54.StartInfo.RedirectStandardOutput = true;
            p54.StartInfo.FileName = "cmd.exe";
            p54.StartInfo.Arguments = "/c fastboot flash vendor_a DRG-354E-0-00WW-B01-vendor.img  2>>log.txt ";
            p54.StartInfo.CreateNoWindow = true;
            p54.Start();
            richTextBox1.Text = richTextBox1.Text + p54.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p54.WaitForExit();

            Process p55 = new Process();
            p55.StartInfo.UseShellExecute = false;
            p55.StartInfo.RedirectStandardOutput = true;
            p55.StartInfo.FileName = "cmd.exe";
            p55.StartInfo.Arguments = "/c echo Erase ssd..";
            p55.StartInfo.CreateNoWindow = true;
            p55.Start();
            richTextBox1.Text = richTextBox1.Text + p55.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p55.WaitForExit();

            Process p56 = new Process();
            p56.StartInfo.UseShellExecute = false;
            p56.StartInfo.RedirectStandardOutput = true;
            p56.StartInfo.FileName = "cmd.exe";
            p56.StartInfo.Arguments = "/c fastboot erase ssd ";
            p56.StartInfo.CreateNoWindow = true;
            p56.Start();
            richTextBox1.Text = richTextBox1.Text + p56.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p56.WaitForExit();

            Process p57 = new Process();
            p57.StartInfo.UseShellExecute = false;
            p57.StartInfo.RedirectStandardOutput = true;
            p57.StartInfo.FileName = "cmd.exe";
            p57.StartInfo.Arguments = "/c echo Erase misc.. ";
            p57.StartInfo.CreateNoWindow = true;
            p57.Start();
            richTextBox1.Text = richTextBox1.Text + p57.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p57.WaitForExit();

            Process p58 = new Process();
            p58.StartInfo.UseShellExecute = false;
            p58.StartInfo.RedirectStandardOutput = true;
            p58.StartInfo.FileName = "cmd.exe";
            p58.StartInfo.Arguments = "/c fastboot erase misc ";
            p58.StartInfo.CreateNoWindow = true;
            p58.Start();
            richTextBox1.Text = richTextBox1.Text + p58.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p58.WaitForExit();

            Process p59 = new Process();
            p59.StartInfo.UseShellExecute = false;
            p59.StartInfo.RedirectStandardOutput = true;
            p59.StartInfo.FileName = "cmd.exe";
            p59.StartInfo.Arguments = "/c echo Erase sti.. ";
            p59.StartInfo.CreateNoWindow = true;
            p59.Start();
            richTextBox1.Text = richTextBox1.Text + p59.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p59.WaitForExit();

            Process p60 = new Process();
            p60.StartInfo.UseShellExecute = false;
            p60.StartInfo.RedirectStandardOutput = true;
            p60.StartInfo.FileName = "cmd.exe";
            p60.StartInfo.Arguments = "/c fastboot erase sti ";
            p60.StartInfo.CreateNoWindow = true;
            p60.Start();
            richTextBox1.Text = richTextBox1.Text + p60.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p60.WaitForExit();

            Process p61 = new Process();
            p61.StartInfo.UseShellExecute = false;
            p61.StartInfo.RedirectStandardOutput = true;
            p61.StartInfo.FileName = "cmd.exe";
            p61.StartInfo.Arguments = "/c echo Erase ddr.. ";
            p61.StartInfo.CreateNoWindow = true;
            p61.Start();
            richTextBox1.Text = richTextBox1.Text + p61.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p61.WaitForExit();

            Process p62 = new Process();
            p62.StartInfo.UseShellExecute = false;
            p62.StartInfo.RedirectStandardOutput = true;
            p62.StartInfo.FileName = "cmd.exe";
            p62.StartInfo.Arguments = "/c fastboot erase ddr ";
            p62.StartInfo.CreateNoWindow = true;
            p62.Start();
            richTextBox1.Text = richTextBox1.Text + p62.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p62.WaitForExit();

            Process p63 = new Process();
            p63.StartInfo.UseShellExecute = false;
            p63.StartInfo.RedirectStandardOutput = true;
            p63.StartInfo.FileName = "cmd.exe";
            p63.StartInfo.Arguments = "/c echo Erase securefs.. ";
            p63.StartInfo.CreateNoWindow = true;
            p63.Start();
            richTextBox1.Text = richTextBox1.Text + p63.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p63.WaitForExit();

            Process p64 = new Process();
            p64.StartInfo.UseShellExecute = false;
            p64.StartInfo.RedirectStandardOutput = true;
            p64.StartInfo.FileName = "cmd.exe";
            p64.StartInfo.Arguments = "/c fastboot erase securefs ";
            p64.StartInfo.CreateNoWindow = true;
            p64.Start();
            richTextBox1.Text = richTextBox1.Text + p64.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p64.WaitForExit();

            Process p65 = new Process();
            p65.StartInfo.UseShellExecute = false;
            p65.StartInfo.RedirectStandardOutput = true;
            p65.StartInfo.FileName = "cmd.exe";
            p65.StartInfo.Arguments = "/c echo Erase box.. ";
            p65.StartInfo.CreateNoWindow = true;
            p65.Start();
            richTextBox1.Text = richTextBox1.Text + p65.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p65.WaitForExit();

            Process p66 = new Process();
            p66.StartInfo.UseShellExecute = false;
            p66.StartInfo.RedirectStandardOutput = true;
            p66.StartInfo.FileName = "cmd.exe";
            p66.StartInfo.Arguments = "/c fastboot erase box ";
            p66.StartInfo.CreateNoWindow = true;
            p66.Start();
            richTextBox1.Text = richTextBox1.Text + p66.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p66.WaitForExit();

            Process p67 = new Process();
            p67.StartInfo.UseShellExecute = false;
            p67.StartInfo.RedirectStandardOutput = true;
            p67.StartInfo.FileName = "cmd.exe";
            p67.StartInfo.Arguments = "/c echo Erase boot_b.. ";
            p67.StartInfo.CreateNoWindow = true;
            p67.Start();
            richTextBox1.Text = richTextBox1.Text + p67.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p67.WaitForExit();

            Process p68 = new Process();
            p68.StartInfo.UseShellExecute = false;
            p68.StartInfo.RedirectStandardOutput = true;
            p68.StartInfo.FileName = "cmd.exe";
            p68.StartInfo.Arguments = "/c fastboot erase boot_b ";
            p68.StartInfo.CreateNoWindow = true;
            p68.Start();
            richTextBox1.Text = richTextBox1.Text + p68.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p68.WaitForExit();

            Process p69 = new Process();
            p69.StartInfo.UseShellExecute = false;
            p69.StartInfo.RedirectStandardOutput = true;
            p69.StartInfo.FileName = "cmd.exe";
            p69.StartInfo.Arguments = "/c echo set active slot A.. ";
            p69.StartInfo.CreateNoWindow = true;
            p69.Start();
            richTextBox1.Text = richTextBox1.Text + p69.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p69.WaitForExit();

            Process p70 = new Process();
            p70.StartInfo.UseShellExecute = false;
            p70.StartInfo.RedirectStandardOutput = true;
            p70.StartInfo.FileName = "cmd.exe";
            p70.StartInfo.Arguments = "/c fastboot --set-active=a ";
            p70.StartInfo.CreateNoWindow = true;
            p70.Start();
            richTextBox1.Text = richTextBox1.Text + p70.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p70.WaitForExit();

            Process p71 = new Process();
            p71.StartInfo.UseShellExecute = false;
            p71.StartInfo.RedirectStandardOutput = true;
            p71.StartInfo.FileName = "cmd.exe";
            p71.StartInfo.Arguments = "/c echo Erase Userdata.. ";
            p71.StartInfo.CreateNoWindow = true;
            p71.Start();
            richTextBox1.Text = richTextBox1.Text + p71.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p71.WaitForExit();

            Process p72 = new Process();
            p72.StartInfo.UseShellExecute = false;
            p72.StartInfo.RedirectStandardOutput = true;
            p72.StartInfo.FileName = "cmd.exe";
            p72.StartInfo.Arguments = "/c fastboot -w ";
            p72.StartInfo.CreateNoWindow = true;
            p72.Start();
            richTextBox1.Refresh();

            Process p73 = new Process();
            p73.StartInfo.UseShellExecute = false;
            p73.StartInfo.RedirectStandardOutput = true;
            p73.StartInfo.FileName = "cmd.exe";
            p73.StartInfo.Arguments = "/c echo Rebooting system.. ";
            p73.StartInfo.CreateNoWindow = true;
            p73.Start();
            richTextBox1.Text = richTextBox1.Text + p73.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p73.WaitForExit();

            Process p74 = new Process();
            p74.StartInfo.UseShellExecute = false;
            p74.StartInfo.RedirectStandardOutput = true;
            p74.StartInfo.FileName = "cmd.exe";
            p74.StartInfo.Arguments = "/c fastboot reboot ";
            p74.StartInfo.CreateNoWindow = true;
            p74.Start();
            richTextBox1.Text = richTextBox1.Text + p74.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p74.WaitForExit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process p1 = new Process();
            p1.StartInfo.UseShellExecute = false;
            p1.StartInfo.RedirectStandardOutput = true;
            p1.StartInfo.FileName = "cmd.exe";
            p1.StartInfo.Arguments = "/c echo getversions..";
            p1.StartInfo.CreateNoWindow = true;
            p1.Start();
            richTextBox1.Text = richTextBox1.Text + p1.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p1.WaitForExit();


            Process p2 = new Process();
            p2.StartInfo.UseShellExecute = false;
            p2.StartInfo.RedirectStandardOutput = true;
            p2.StartInfo.FileName = "cmd.exe";
            p2.StartInfo.Arguments = "/c fastboot oem getversions 2>getver.txt & type getver.txt ";
            p2.StartInfo.CreateNoWindow = true;
            p2.Start();
            richTextBox1.Text = richTextBox1.Text + p2.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p2.WaitForExit();

            Process p3 = new Process();
            p3.StartInfo.UseShellExecute = false;
            p3.StartInfo.RedirectStandardOutput = true;
            p3.StartInfo.FileName = "cmd.exe";
            p3.StartInfo.Arguments = "/c echo device-info..";
            p3.StartInfo.CreateNoWindow = true;
            p3.Start();
            richTextBox1.Text = richTextBox1.Text + p3.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p3.WaitForExit();


            Process p4 = new Process();
            p4.StartInfo.UseShellExecute = false;
            p4.StartInfo.RedirectStandardOutput = true;
            p4.StartInfo.FileName = "cmd.exe";
            p4.StartInfo.Arguments = "/c fastboot oem device-info 2>device.txt & type device.txt  ";
            p4.StartInfo.CreateNoWindow = true;
            p4.Start();
            richTextBox1.Text = richTextBox1.Text + p4.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p4.WaitForExit();

            Process p5 = new Process();
            p5.StartInfo.UseShellExecute = false;
            p5.StartInfo.RedirectStandardOutput = true;
            p5.StartInfo.FileName = "cmd.exe";
            p5.StartInfo.Arguments = "/c echo Flashing abl_a..";
            p5.StartInfo.CreateNoWindow = true;
            p5.Start();
            richTextBox1.Text = richTextBox1.Text + p5.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p5.WaitForExit();


            Process p6 = new Process();
            p6.StartInfo.UseShellExecute = false;
            p6.StartInfo.RedirectStandardOutput = true;
            p6.StartInfo.FileName = "cmd.exe";
            p6.StartInfo.Arguments = "/c fastboot flash abl_a DRG-354B-0-00WW-B01-abl.img  2>>log.txt  ";
            p6.StartInfo.CreateNoWindow = true;
            p6.Start();
            richTextBox1.Text = richTextBox1.Text + p6.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p6.WaitForExit();

            Process p7 = new Process();
            p7.StartInfo.UseShellExecute = false;
            p7.StartInfo.RedirectStandardOutput = true;
            p7.StartInfo.FileName = "cmd.exe";
            p7.StartInfo.Arguments = "/c echo Flashing abl_b..";
            p7.StartInfo.CreateNoWindow = true;
            p7.Start();
            richTextBox1.Text = richTextBox1.Text + p7.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p7.WaitForExit();

            Process p8 = new Process();
            p8.StartInfo.UseShellExecute = false;
            p8.StartInfo.RedirectStandardOutput = true;
            p8.StartInfo.FileName = "cmd.exe";
            p8.StartInfo.Arguments = "/c fastboot flash abl_b DRG-354B-0-00WW-B01-abl.img  2>>log.txt ";
            p8.StartInfo.CreateNoWindow = true;
            p8.Start();
            richTextBox1.Text = richTextBox1.Text + p8.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p8.WaitForExit();

            Process p9 = new Process();
            p9.StartInfo.UseShellExecute = false;
            p9.StartInfo.RedirectStandardOutput = true;
            p9.StartInfo.FileName = "cmd.exe";
            p9.StartInfo.Arguments = "/c echo FLashing xbl_a..";
            p9.StartInfo.CreateNoWindow = true;
            p9.Start();
            richTextBox1.Text = richTextBox1.Text + p9.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p9.WaitForExit();

            Process p10 = new Process();
            p10.StartInfo.UseShellExecute = false;
            p10.StartInfo.RedirectStandardOutput = true;
            p10.StartInfo.FileName = "cmd.exe";
            p10.StartInfo.Arguments = "/c fastboot flash xbl_a DRG-354B-0-00WW-B01-xbl.img  2>>log.txt ";
            p10.StartInfo.CreateNoWindow = true;
            p10.Start();
            richTextBox1.Text = richTextBox1.Text + p10.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p10.WaitForExit();

            Process p11 = new Process();
            p11.StartInfo.UseShellExecute = false;
            p11.StartInfo.RedirectStandardOutput = true;
            p11.StartInfo.FileName = "cmd.exe";
            p11.StartInfo.Arguments = "/c echo Flashing xbl_b.. ";
            p11.StartInfo.CreateNoWindow = true;
            p11.Start();
            richTextBox1.Text = richTextBox1.Text + p11.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p11.WaitForExit();

            Process p12 = new Process();
            p12.StartInfo.UseShellExecute = false;
            p12.StartInfo.RedirectStandardOutput = true;
            p12.StartInfo.FileName = "cmd.exe";
            p12.StartInfo.Arguments = "/c fastboot flash xbl_b DRG-354B-0-00WW-B01-xbl.img  2>>log.txt ";
            p12.StartInfo.CreateNoWindow = true;
            p12.Start();
            richTextBox1.Text = richTextBox1.Text + p12.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p12.WaitForExit();

            Process p13 = new Process();
            p13.StartInfo.UseShellExecute = false;
            p13.StartInfo.RedirectStandardOutput = true;
            p13.StartInfo.FileName = "cmd.exe";
            p13.StartInfo.Arguments = "/c echo Flashing bluetooth_a.. ";
            p13.StartInfo.CreateNoWindow = true;
            p13.Start();
            richTextBox1.Text = richTextBox1.Text + p13.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p13.WaitForExit();

            Process p14 = new Process();
            p14.StartInfo.UseShellExecute = false;
            p14.StartInfo.RedirectStandardOutput = true;
            p14.StartInfo.FileName = "cmd.exe";
            p14.StartInfo.Arguments = "/c fastboot flash bluetooth_a DRG-354B-0-00WW-B01-bluetooth.img  2>>log.txt ";
            p14.StartInfo.CreateNoWindow = true;
            p14.Start();
            richTextBox1.Text = richTextBox1.Text + p14.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p14.WaitForExit();

            Process p15 = new Process();
            p15.StartInfo.UseShellExecute = false;
            p15.StartInfo.RedirectStandardOutput = true;
            p15.StartInfo.FileName = "cmd.exe";
            p15.StartInfo.Arguments = "/c echo Flashing boot_a.. ";
            p15.StartInfo.CreateNoWindow = true;
            p15.Start();
            richTextBox1.Text = richTextBox1.Text + p15.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p15.WaitForExit();

            Process p16 = new Process();
            p16.StartInfo.UseShellExecute = false;
            p16.StartInfo.RedirectStandardOutput = true;
            p16.StartInfo.FileName = "cmd.exe";
            p16.StartInfo.Arguments = "/c fastboot flash boot_a DRG-354B-0-00WW-B01-boot.img  2>>log.txt ";
            p16.StartInfo.CreateNoWindow = true;
            p16.Start();
            richTextBox1.Text = richTextBox1.Text + p16.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p16.WaitForExit();

            Process p17 = new Process();
            p17.StartInfo.UseShellExecute = false;
            p17.StartInfo.RedirectStandardOutput = true;
            p17.StartInfo.FileName = "cmd.exe";
            p17.StartInfo.Arguments = "/c echo Flashing cda_a.. ";
            p17.StartInfo.CreateNoWindow = true;
            p17.Start();
            richTextBox1.Text = richTextBox1.Text + p17.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p17.WaitForExit();

            Process p18 = new Process();
            p18.StartInfo.UseShellExecute = false;
            p18.StartInfo.RedirectStandardOutput = true;
            p18.StartInfo.FileName = "cmd.exe";
            p18.StartInfo.Arguments = "/c fastboot flash cda_a DRG-354B-0-00WW-B01-cda.img  2>>log.txt ";
            p18.StartInfo.CreateNoWindow = true;
            p18.Start();
            richTextBox1.Text = richTextBox1.Text + p18.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p18.WaitForExit();

            Process p19 = new Process();
            p19.StartInfo.UseShellExecute = false;
            p19.StartInfo.RedirectStandardOutput = true;
            p19.StartInfo.FileName = "cmd.exe";
            p19.StartInfo.Arguments = "/c echo Flashing cmnlib_a.. ";
            p19.StartInfo.CreateNoWindow = true;
            p19.Start();
            richTextBox1.Text = richTextBox1.Text + p19.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p19.WaitForExit();

            Process p20 = new Process();
            p20.StartInfo.UseShellExecute = false;
            p20.StartInfo.RedirectStandardOutput = true;
            p20.StartInfo.FileName = "cmd.exe";
            p20.StartInfo.Arguments = "/c fastboot flash cmnlib_a DRG-354B-0-00WW-B01-cmnlib.img  2>>log.txt ";
            p20.StartInfo.CreateNoWindow = true;
            p20.Start();
            richTextBox1.Text = richTextBox1.Text + p20.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p20.WaitForExit();

            Process p21 = new Process();
            p21.StartInfo.UseShellExecute = false;
            p21.StartInfo.RedirectStandardOutput = true;
            p21.StartInfo.FileName = "cmd.exe";
            p21.StartInfo.Arguments = "/c echo Flashing cmnlib64_a.. ";
            p21.StartInfo.CreateNoWindow = true;
            p21.Start();
            richTextBox1.Text = richTextBox1.Text + p21.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p21.WaitForExit();

            Process p22 = new Process();
            p22.StartInfo.UseShellExecute = false;
            p22.StartInfo.RedirectStandardOutput = true;
            p22.StartInfo.FileName = "cmd.exe";
            p22.StartInfo.Arguments = "/c fastboot flash cmnlib64_a DRG-354B-0-00WW-B01-cmnlib64.img  2>>log.txt ";
            p22.StartInfo.CreateNoWindow = true;
            p22.Start();
            richTextBox1.Text = richTextBox1.Text + p22.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p22.WaitForExit();

            Process p23 = new Process();
            p23.StartInfo.UseShellExecute = false;
            p23.StartInfo.RedirectStandardOutput = true;
            p23.StartInfo.FileName = "cmd.exe";
            p23.StartInfo.Arguments = "/c echo Flashing devcfg_a.. ";
            p23.StartInfo.CreateNoWindow = true;
            p23.Start();
            richTextBox1.Text = richTextBox1.Text + p23.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p23.WaitForExit();

            Process p24 = new Process();
            p24.StartInfo.UseShellExecute = false;
            p24.StartInfo.RedirectStandardOutput = true;
            p24.StartInfo.FileName = "cmd.exe";
            p24.StartInfo.Arguments = "/c fastboot flash devcfg_a DRG-354B-0-00WW-B01-devcfg.img  2>>log.txt ";
            p24.StartInfo.CreateNoWindow = true;
            p24.Start();
            richTextBox1.Text = richTextBox1.Text + p24.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p24.WaitForExit();

            Process p25 = new Process();
            p25.StartInfo.UseShellExecute = false;
            p25.StartInfo.RedirectStandardOutput = true;
            p25.StartInfo.FileName = "cmd.exe";
            p25.StartInfo.Arguments = "/c echo Flashing dsp_a.. ";
            p25.StartInfo.CreateNoWindow = true;
            p25.Start();
            richTextBox1.Text = richTextBox1.Text + p25.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p25.WaitForExit();

            Process p26 = new Process();
            p26.StartInfo.UseShellExecute = false;
            p26.StartInfo.RedirectStandardOutput = true;
            p26.StartInfo.FileName = "cmd.exe";
            p26.StartInfo.Arguments = "/c fastboot flash dsp_a DRG-354B-0-00WW-B01-dsp.img  2>>log.txt ";
            p26.StartInfo.CreateNoWindow = true;
            p26.Start();
            richTextBox1.Text = richTextBox1.Text + p26.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p26.WaitForExit();

            Process p27 = new Process();
            p27.StartInfo.UseShellExecute = false;
            p27.StartInfo.RedirectStandardOutput = true;
            p27.StartInfo.FileName = "cmd.exe";
            p27.StartInfo.Arguments = "/c echo Flashing hidden_a.. ";
            p27.StartInfo.CreateNoWindow = true;
            p27.Start();
            richTextBox1.Text = richTextBox1.Text + p27.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p27.WaitForExit();

            Process p28 = new Process();
            p28.StartInfo.UseShellExecute = false;
            p28.StartInfo.RedirectStandardOutput = true;
            p28.StartInfo.FileName = "cmd.exe";
            p28.StartInfo.Arguments = "/c fastboot flash hidden_a DRG-354B-0-00WW-B01-hidden.img  2>>log.txt ";
            p28.StartInfo.CreateNoWindow = true;
            p28.Start();
            richTextBox1.Text = richTextBox1.Text + p28.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p28.WaitForExit();

            Process p29 = new Process();
            p29.StartInfo.UseShellExecute = false;
            p29.StartInfo.RedirectStandardOutput = true;
            p29.StartInfo.FileName = "cmd.exe";
            p29.StartInfo.Arguments = "/c echo Flashing hyp_a.. ";
            p29.StartInfo.CreateNoWindow = true;
            p29.Start();
            richTextBox1.Text = richTextBox1.Text + p29.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p29.WaitForExit();

            Process p30 = new Process();
            p30.StartInfo.UseShellExecute = false;
            p30.StartInfo.RedirectStandardOutput = true;
            p30.StartInfo.FileName = "cmd.exe";
            p30.StartInfo.Arguments = "/c fastboot flash hyp_a DRG-354B-0-00WW-B01-hyp.img  2>>log.txt ";
            p30.StartInfo.CreateNoWindow = true;
            p30.Start();
            richTextBox1.Text = richTextBox1.Text + p30.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p30.WaitForExit();

            Process p31 = new Process();
            p31.StartInfo.UseShellExecute = false;
            p31.StartInfo.RedirectStandardOutput = true;
            p31.StartInfo.FileName = "cmd.exe";
            p31.StartInfo.Arguments = "/c echo flashing keymaster_a.. ";
            p31.StartInfo.CreateNoWindow = true;
            p31.Start();
            richTextBox1.Text = richTextBox1.Text + p31.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p31.WaitForExit();

            Process p32 = new Process();
            p32.StartInfo.UseShellExecute = false;
            p32.StartInfo.RedirectStandardOutput = true;
            p32.StartInfo.FileName = "cmd.exe";
            p32.StartInfo.Arguments = "/c fastboot flash keymaster_a DRG-354B-0-00WW-B01-keymaster.img  2>>log.txt ";
            p32.StartInfo.CreateNoWindow = true;
            p32.Start();
            richTextBox1.Text = richTextBox1.Text + p32.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p32.WaitForExit();

            Process p33 = new Process();
            p33.StartInfo.UseShellExecute = false;
            p33.StartInfo.RedirectStandardOutput = true;
            p33.StartInfo.FileName = "cmd.exe";
            p33.StartInfo.Arguments = "/c echo Flashing mdtp_a.. ";
            p33.StartInfo.CreateNoWindow = true;
            p33.Start();
            richTextBox1.Text = richTextBox1.Text + p33.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p33.WaitForExit();

            Process p34 = new Process();
            p34.StartInfo.UseShellExecute = false;
            p34.StartInfo.RedirectStandardOutput = true;
            p34.StartInfo.FileName = "cmd.exe";
            p34.StartInfo.Arguments = "/c fastboot flash mdtp_a DRG-354B-0-00WW-B01-mdtp.img  2>>log.txt ";
            p34.StartInfo.CreateNoWindow = true;
            p34.Start();
            richTextBox1.Text = richTextBox1.Text + p34.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p34.WaitForExit();

            Process p35 = new Process();
            p35.StartInfo.UseShellExecute = false;
            p35.StartInfo.RedirectStandardOutput = true;
            p35.StartInfo.FileName = "cmd.exe";
            p35.StartInfo.Arguments = "/c echo Flashing mdtpsecapp_a.. ";
            p35.StartInfo.CreateNoWindow = true;
            p35.Start();
            richTextBox1.Text = richTextBox1.Text + p35.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p35.WaitForExit();

            Process p36 = new Process();
            p36.StartInfo.UseShellExecute = false;
            p36.StartInfo.RedirectStandardOutput = true;
            p36.StartInfo.FileName = "cmd.exe";
            p36.StartInfo.Arguments = "/c fastboot flash mdtpsecapp_a DRG-354B-0-00WW-B01-mdtpsecapp.img  2>>log.txt ";
            p36.StartInfo.CreateNoWindow = true;
            p36.Start();
            richTextBox1.Text = richTextBox1.Text + p36.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p36.WaitForExit();

            Process p37 = new Process();
            p37.StartInfo.UseShellExecute = false;
            p37.StartInfo.RedirectStandardOutput = true;
            p37.StartInfo.FileName = "cmd.exe";
            p37.StartInfo.Arguments = "/c echo Flashing modem_a.. ";
            p37.StartInfo.CreateNoWindow = true;
            p37.Start();
            richTextBox1.Text = richTextBox1.Text + p37.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p37.WaitForExit();

            Process p38 = new Process();
            p38.StartInfo.UseShellExecute = false;
            p38.StartInfo.RedirectStandardOutput = true;
            p38.StartInfo.FileName = "cmd.exe";
            p38.StartInfo.Arguments = "/c fastboot flash modem_a DRG-354B-0-00WW-B01-modem.img  2>>log.txt ";
            p38.StartInfo.CreateNoWindow = true;
            p38.Start();
            richTextBox1.Text = richTextBox1.Text + p38.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p38.WaitForExit();

            Process p39 = new Process();
            p39.StartInfo.UseShellExecute = false;
            p39.StartInfo.RedirectStandardOutput = true;
            p39.StartInfo.FileName = "cmd.exe";
            p39.StartInfo.Arguments = "/c echo Flashing nvdef_a.. ";
            p39.StartInfo.CreateNoWindow = true;
            p39.Start();
            richTextBox1.Text = richTextBox1.Text + p39.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p39.WaitForExit();

            Process p40 = new Process();
            p40.StartInfo.UseShellExecute = false;
            p40.StartInfo.RedirectStandardOutput = true;
            p40.StartInfo.FileName = "cmd.exe";
            p40.StartInfo.Arguments = "/c fastboot flash nvdef_a DRG-354B-0-00WW-B01-nvdef.img  2>>log.txt ";
            p40.StartInfo.CreateNoWindow = true;
            p40.Start();
            richTextBox1.Text = richTextBox1.Text + p40.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p40.WaitForExit();

            Process p41 = new Process();
            p41.StartInfo.UseShellExecute = false;
            p41.StartInfo.RedirectStandardOutput = true;
            p41.StartInfo.FileName = "cmd.exe";
            p41.StartInfo.Arguments = "/c echo Flashing pmic_a.. ";
            p41.StartInfo.CreateNoWindow = true;
            p41.Start();
            richTextBox1.Text = richTextBox1.Text + p41.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p41.WaitForExit();

            Process p42 = new Process();
            p42.StartInfo.UseShellExecute = false;
            p42.StartInfo.RedirectStandardOutput = true;
            p42.StartInfo.FileName = "cmd.exe";
            p42.StartInfo.Arguments = "/c fastboot flash pmic_a DRG-354B-0-00WW-B01-pmic.img  2>>log.txt";
            p42.StartInfo.CreateNoWindow = true;
            p42.Start();
            richTextBox1.Text = richTextBox1.Text + p42.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p42.WaitForExit();

            Process p43 = new Process();
            p43.StartInfo.UseShellExecute = false;
            p43.StartInfo.RedirectStandardOutput = true;
            p43.StartInfo.FileName = "cmd.exe";
            p43.StartInfo.Arguments = "/c echo FLashing rpm_a.. ";
            p43.StartInfo.CreateNoWindow = true;
            p43.Start();
            richTextBox1.Text = richTextBox1.Text + p43.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p43.WaitForExit();

            Process p44 = new Process();
            p44.StartInfo.UseShellExecute = false;
            p44.StartInfo.RedirectStandardOutput = true;
            p44.StartInfo.FileName = "cmd.exe";
            p44.StartInfo.Arguments = "/c fastboot flash rpm_a DRG-354B-0-00WW-B01-rpm.img  2>>log.txt ";
            p44.StartInfo.CreateNoWindow = true;
            p44.Start();
            richTextBox1.Text = richTextBox1.Text + p44.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p44.WaitForExit();

            Process p45 = new Process();
            p45.StartInfo.UseShellExecute = false;
            p45.StartInfo.RedirectStandardOutput = true;
            p45.StartInfo.FileName = "cmd.exe";
            p45.StartInfo.Arguments = "/c echo Flashing splash_a.. ";
            p45.StartInfo.CreateNoWindow = true;
            p45.Start();
            richTextBox1.Text = richTextBox1.Text + p45.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p45.WaitForExit();

            Process p46 = new Process();
            p46.StartInfo.UseShellExecute = false;
            p46.StartInfo.RedirectStandardOutput = true;
            p46.StartInfo.FileName = "cmd.exe";
            p46.StartInfo.Arguments = "/c fastboot flash splash_a DRG-354B-0-00WW-B01-splash.img  2>>log.txt ";
            p46.StartInfo.CreateNoWindow = true;
            p46.Start();
            richTextBox1.Text = richTextBox1.Text + p46.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p46.WaitForExit();

            Process p47 = new Process();
            p47.StartInfo.UseShellExecute = false;
            p47.StartInfo.RedirectStandardOutput = true;
            p47.StartInfo.FileName = "cmd.exe";
            p47.StartInfo.Arguments = "/c echo Flashing system_a.. ";
            p47.StartInfo.CreateNoWindow = true;
            p47.Start();
            richTextBox1.Text = richTextBox1.Text + p47.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p47.WaitForExit();

            Process p48 = new Process();
            p48.StartInfo.UseShellExecute = false;
            p48.StartInfo.RedirectStandardOutput = true;
            p48.StartInfo.FileName = "cmd.exe";
            p48.StartInfo.Arguments = "/c fastboot flash system_a DRG-354B-0-00WW-B01-system.img  2>>log.txt ";
            p48.StartInfo.CreateNoWindow = true;
            p48.Start();
            richTextBox1.Text = richTextBox1.Text + p48.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p48.WaitForExit();

            Process p49 = new Process();
            p49.StartInfo.UseShellExecute = false;
            p49.StartInfo.RedirectStandardOutput = true;
            p49.StartInfo.FileName = "cmd.exe";
            p49.StartInfo.Arguments = "/c echo Flashing systeminfo_a.. ";
            p49.StartInfo.CreateNoWindow = true;
            p49.Start();
            richTextBox1.Text = richTextBox1.Text + p49.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p49.WaitForExit();

            Process p50 = new Process();
            p50.StartInfo.UseShellExecute = false;
            p50.StartInfo.RedirectStandardOutput = true;
            p50.StartInfo.FileName = "cmd.exe";
            p50.StartInfo.Arguments = "/c fastboot flash systeminfo_a DRG-354B-0-00WW-B01-systeminfo.img  2>>log.txt";
            p50.StartInfo.CreateNoWindow = true;
            p50.Start();
            richTextBox1.Text = richTextBox1.Text + p50.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p50.WaitForExit();

            Process p51 = new Process();
            p51.StartInfo.UseShellExecute = false;
            p51.StartInfo.RedirectStandardOutput = true;
            p51.StartInfo.FileName = "cmd.exe";
            p51.StartInfo.Arguments = "/c echo Flshing tz_a.";
            p51.StartInfo.CreateNoWindow = true;
            p51.Start();
            richTextBox1.Text = richTextBox1.Text + p51.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p51.WaitForExit();

            Process p52 = new Process();
            p52.StartInfo.UseShellExecute = false;
            p52.StartInfo.RedirectStandardOutput = true;
            p52.StartInfo.FileName = "cmd.exe";
            p52.StartInfo.Arguments = "/c fastboot flash tz_a DRG-354B-0-00WW-B01-tz.img  2>>log.txt";
            p52.StartInfo.CreateNoWindow = true;
            p52.Start();
            richTextBox1.Text = richTextBox1.Text + p52.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p52.WaitForExit();

            Process p53 = new Process();
            p53.StartInfo.UseShellExecute = false;
            p53.StartInfo.RedirectStandardOutput = true;
            p53.StartInfo.FileName = "cmd.exe";
            p53.StartInfo.Arguments = "/c echo Flashing vendor_a.. ";
            p53.StartInfo.CreateNoWindow = true;
            p53.Start();
            richTextBox1.Text = richTextBox1.Text + p53.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p53.WaitForExit();

            Process p54 = new Process();
            p54.StartInfo.UseShellExecute = false;
            p54.StartInfo.RedirectStandardOutput = true;
            p54.StartInfo.FileName = "cmd.exe";
            p54.StartInfo.Arguments = "/c fastboot flash vendor_a DRG-354B-0-00WW-B01-vendor.img  2>>log.txt ";
            p54.StartInfo.CreateNoWindow = true;
            p54.Start();
            richTextBox1.Text = richTextBox1.Text + p54.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p54.WaitForExit();

            Process p55 = new Process();
            p55.StartInfo.UseShellExecute = false;
            p55.StartInfo.RedirectStandardOutput = true;
            p55.StartInfo.FileName = "cmd.exe";
            p55.StartInfo.Arguments = "/c echo Erase ssd..";
            p55.StartInfo.CreateNoWindow = true;
            p55.Start();
            richTextBox1.Text = richTextBox1.Text + p55.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p55.WaitForExit();

            Process p56 = new Process();
            p56.StartInfo.UseShellExecute = false;
            p56.StartInfo.RedirectStandardOutput = true;
            p56.StartInfo.FileName = "cmd.exe";
            p56.StartInfo.Arguments = "/c fastboot erase ssd ";
            p56.StartInfo.CreateNoWindow = true;
            p56.Start();
            richTextBox1.Text = richTextBox1.Text + p56.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p56.WaitForExit();

            Process p57 = new Process();
            p57.StartInfo.UseShellExecute = false;
            p57.StartInfo.RedirectStandardOutput = true;
            p57.StartInfo.FileName = "cmd.exe";
            p57.StartInfo.Arguments = "/c echo Erase misc.. ";
            p57.StartInfo.CreateNoWindow = true;
            p57.Start();
            richTextBox1.Text = richTextBox1.Text + p57.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p57.WaitForExit();

            Process p58 = new Process();
            p58.StartInfo.UseShellExecute = false;
            p58.StartInfo.RedirectStandardOutput = true;
            p58.StartInfo.FileName = "cmd.exe";
            p58.StartInfo.Arguments = "/c fastboot erase misc ";
            p58.StartInfo.CreateNoWindow = true;
            p58.Start();
            richTextBox1.Text = richTextBox1.Text + p58.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p58.WaitForExit();

            Process p59 = new Process();
            p59.StartInfo.UseShellExecute = false;
            p59.StartInfo.RedirectStandardOutput = true;
            p59.StartInfo.FileName = "cmd.exe";
            p59.StartInfo.Arguments = "/c echo Erase sti.. ";
            p59.StartInfo.CreateNoWindow = true;
            p59.Start();
            richTextBox1.Text = richTextBox1.Text + p59.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p59.WaitForExit();

            Process p60 = new Process();
            p60.StartInfo.UseShellExecute = false;
            p60.StartInfo.RedirectStandardOutput = true;
            p60.StartInfo.FileName = "cmd.exe";
            p60.StartInfo.Arguments = "/c fastboot erase sti ";
            p60.StartInfo.CreateNoWindow = true;
            p60.Start();
            richTextBox1.Text = richTextBox1.Text + p60.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p60.WaitForExit();

            Process p61 = new Process();
            p61.StartInfo.UseShellExecute = false;
            p61.StartInfo.RedirectStandardOutput = true;
            p61.StartInfo.FileName = "cmd.exe";
            p61.StartInfo.Arguments = "/c echo Erase ddr.. ";
            p61.StartInfo.CreateNoWindow = true;
            p61.Start();
            richTextBox1.Text = richTextBox1.Text + p61.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p61.WaitForExit();

            Process p62 = new Process();
            p62.StartInfo.UseShellExecute = false;
            p62.StartInfo.RedirectStandardOutput = true;
            p62.StartInfo.FileName = "cmd.exe";
            p62.StartInfo.Arguments = "/c fastboot erase ddr ";
            p62.StartInfo.CreateNoWindow = true;
            p62.Start();
            richTextBox1.Text = richTextBox1.Text + p62.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p62.WaitForExit();

            Process p63 = new Process();
            p63.StartInfo.UseShellExecute = false;
            p63.StartInfo.RedirectStandardOutput = true;
            p63.StartInfo.FileName = "cmd.exe";
            p63.StartInfo.Arguments = "/c echo Erase securefs.. ";
            p63.StartInfo.CreateNoWindow = true;
            p63.Start();
            richTextBox1.Text = richTextBox1.Text + p63.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p63.WaitForExit();

            Process p64 = new Process();
            p64.StartInfo.UseShellExecute = false;
            p64.StartInfo.RedirectStandardOutput = true;
            p64.StartInfo.FileName = "cmd.exe";
            p64.StartInfo.Arguments = "/c fastboot erase securefs ";
            p64.StartInfo.CreateNoWindow = true;
            p64.Start();
            richTextBox1.Text = richTextBox1.Text + p64.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p64.WaitForExit();

            Process p65 = new Process();
            p65.StartInfo.UseShellExecute = false;
            p65.StartInfo.RedirectStandardOutput = true;
            p65.StartInfo.FileName = "cmd.exe";
            p65.StartInfo.Arguments = "/c echo Erase box.. ";
            p65.StartInfo.CreateNoWindow = true;
            p65.Start();
            richTextBox1.Text = richTextBox1.Text + p65.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p65.WaitForExit();

            Process p66 = new Process();
            p66.StartInfo.UseShellExecute = false;
            p66.StartInfo.RedirectStandardOutput = true;
            p66.StartInfo.FileName = "cmd.exe";
            p66.StartInfo.Arguments = "/c fastboot erase box ";
            p66.StartInfo.CreateNoWindow = true;
            p66.Start();
            richTextBox1.Text = richTextBox1.Text + p66.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p66.WaitForExit();

            Process p67 = new Process();
            p67.StartInfo.UseShellExecute = false;
            p67.StartInfo.RedirectStandardOutput = true;
            p67.StartInfo.FileName = "cmd.exe";
            p67.StartInfo.Arguments = "/c echo Erase boot_b.. ";
            p67.StartInfo.CreateNoWindow = true;
            p67.Start();
            richTextBox1.Text = richTextBox1.Text + p67.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p67.WaitForExit();

            Process p68 = new Process();
            p68.StartInfo.UseShellExecute = false;
            p68.StartInfo.RedirectStandardOutput = true;
            p68.StartInfo.FileName = "cmd.exe";
            p68.StartInfo.Arguments = "/c fastboot erase boot_b ";
            p68.StartInfo.CreateNoWindow = true;
            p68.Start();
            richTextBox1.Text = richTextBox1.Text + p68.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p68.WaitForExit();

            Process p69 = new Process();
            p69.StartInfo.UseShellExecute = false;
            p69.StartInfo.RedirectStandardOutput = true;
            p69.StartInfo.FileName = "cmd.exe";
            p69.StartInfo.Arguments = "/c echo set active slot A.. ";
            p69.StartInfo.CreateNoWindow = true;
            p69.Start();
            richTextBox1.Text = richTextBox1.Text + p69.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p69.WaitForExit();

            Process p70 = new Process();
            p70.StartInfo.UseShellExecute = false;
            p70.StartInfo.RedirectStandardOutput = true;
            p70.StartInfo.FileName = "cmd.exe";
            p70.StartInfo.Arguments = "/c fastboot --set-active=a ";
            p70.StartInfo.CreateNoWindow = true;
            p70.Start();
            richTextBox1.Text = richTextBox1.Text + p70.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p70.WaitForExit();

            Process p71 = new Process();
            p71.StartInfo.UseShellExecute = false;
            p71.StartInfo.RedirectStandardOutput = true;
            p71.StartInfo.FileName = "cmd.exe";
            p71.StartInfo.Arguments = "/c echo Erase Userdata.. ";
            p71.StartInfo.CreateNoWindow = true;
            p71.Start();
            richTextBox1.Text = richTextBox1.Text + p71.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p71.WaitForExit();

            Process p72 = new Process();
            p72.StartInfo.UseShellExecute = false;
            p72.StartInfo.RedirectStandardOutput = true;
            p72.StartInfo.FileName = "cmd.exe";
            p72.StartInfo.Arguments = "/c fastboot -w ";
            p72.StartInfo.CreateNoWindow = true;
            p72.Start();
            richTextBox1.Refresh();

            Process p73 = new Process();
            p73.StartInfo.UseShellExecute = false;
            p73.StartInfo.RedirectStandardOutput = true;
            p73.StartInfo.FileName = "cmd.exe";
            p73.StartInfo.Arguments = "/c echo Rebooting system.. ";
            p73.StartInfo.CreateNoWindow = true;
            p73.Start();
            richTextBox1.Text = richTextBox1.Text + p73.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p73.WaitForExit();

            Process p74 = new Process();
            p74.StartInfo.UseShellExecute = false;
            p74.StartInfo.RedirectStandardOutput = true;
            p74.StartInfo.FileName = "cmd.exe";
            p74.StartInfo.Arguments = "/c fastboot reboot ";
            p74.StartInfo.CreateNoWindow = true;
            p74.Start();
            richTextBox1.Text = richTextBox1.Text + p74.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p74.WaitForExit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process p1 = new Process();
            p1.StartInfo.UseShellExecute = false;
            p1.StartInfo.RedirectStandardOutput = true;
            p1.StartInfo.FileName = "cmd.exe";
            p1.StartInfo.Arguments = "/c echo getversions..";
            p1.StartInfo.CreateNoWindow = true;
            p1.Start();
            richTextBox1.Text = richTextBox1.Text + p1.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p1.WaitForExit();


            Process p2 = new Process();
            p2.StartInfo.UseShellExecute = false;
            p2.StartInfo.RedirectStandardOutput = true;
            p2.StartInfo.FileName = "cmd.exe";
            p2.StartInfo.Arguments = "/c fastboot oem getversions 2>getver.txt & type getver.txt ";
            p2.StartInfo.CreateNoWindow = true;
            p2.Start();
            richTextBox1.Text = richTextBox1.Text + p2.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p2.WaitForExit();

            Process p3 = new Process();
            p3.StartInfo.UseShellExecute = false;
            p3.StartInfo.RedirectStandardOutput = true;
            p3.StartInfo.FileName = "cmd.exe";
            p3.StartInfo.Arguments = "/c echo device-info..";
            p3.StartInfo.CreateNoWindow = true;
            p3.Start();
            richTextBox1.Text = richTextBox1.Text + p3.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p3.WaitForExit();


            Process p4 = new Process();
            p4.StartInfo.UseShellExecute = false;
            p4.StartInfo.RedirectStandardOutput = true;
            p4.StartInfo.FileName = "cmd.exe";
            p4.StartInfo.Arguments = "/c fastboot oem device-info 2>device.txt & type device.txt ";
            p4.StartInfo.CreateNoWindow = true;
            p4.Start();
            richTextBox1.Text = richTextBox1.Text + p4.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p4.WaitForExit();

            Process p5 = new Process();
            p5.StartInfo.UseShellExecute = false;
            p5.StartInfo.RedirectStandardOutput = true;
            p5.StartInfo.FileName = "cmd.exe";
            p5.StartInfo.Arguments = "/c echo Flashing abl_a..";
            p5.StartInfo.CreateNoWindow = true;
            p5.Start();
            richTextBox1.Text = richTextBox1.Text + p5.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p5.WaitForExit();


            Process p6 = new Process();
            p6.StartInfo.UseShellExecute = false;
            p6.StartInfo.RedirectStandardOutput = true;
            p6.StartInfo.FileName = "cmd.exe";
            p6.StartInfo.Arguments = "/c fastboot flash abl_a DRG-330B-0-00WW-B01-abl.img  2>>log.txt  ";
            p6.StartInfo.CreateNoWindow = true;
            p6.Start();
            richTextBox1.Text = richTextBox1.Text + p6.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p6.WaitForExit();

            Process p7 = new Process();
            p7.StartInfo.UseShellExecute = false;
            p7.StartInfo.RedirectStandardOutput = true;
            p7.StartInfo.FileName = "cmd.exe";
            p7.StartInfo.Arguments = "/c echo Flashing abl_b..";
            p7.StartInfo.CreateNoWindow = true;
            p7.Start();
            richTextBox1.Text = richTextBox1.Text + p7.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p7.WaitForExit();

            Process p8 = new Process();
            p8.StartInfo.UseShellExecute = false;
            p8.StartInfo.RedirectStandardOutput = true;
            p8.StartInfo.FileName = "cmd.exe";
            p8.StartInfo.Arguments = "/c fastboot flash abl_b DRG-330B-0-00WW-B01-abl.img  2>>log.txt ";
            p8.StartInfo.CreateNoWindow = true;
            p8.Start();
            richTextBox1.Text = richTextBox1.Text + p8.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p8.WaitForExit();

            Process p9 = new Process();
            p9.StartInfo.UseShellExecute = false;
            p9.StartInfo.RedirectStandardOutput = true;
            p9.StartInfo.FileName = "cmd.exe";
            p9.StartInfo.Arguments = "/c echo FLashing xbl_a..";
            p9.StartInfo.CreateNoWindow = true;
            p9.Start();
            richTextBox1.Text = richTextBox1.Text + p9.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p9.WaitForExit();

            Process p10 = new Process();
            p10.StartInfo.UseShellExecute = false;
            p10.StartInfo.RedirectStandardOutput = true;
            p10.StartInfo.FileName = "cmd.exe";
            p10.StartInfo.Arguments = "/c fastboot flash xbl_a DRG-330B-0-00WW-B01-xbl.img  2>>log.txt ";
            p10.StartInfo.CreateNoWindow = true;
            p10.Start();
            richTextBox1.Text = richTextBox1.Text + p10.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p10.WaitForExit();

            Process p11 = new Process();
            p11.StartInfo.UseShellExecute = false;
            p11.StartInfo.RedirectStandardOutput = true;
            p11.StartInfo.FileName = "cmd.exe";
            p11.StartInfo.Arguments = "/c echo Flashing xbl_b.. ";
            p11.StartInfo.CreateNoWindow = true;
            p11.Start();
            richTextBox1.Text = richTextBox1.Text + p11.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p11.WaitForExit();

            Process p12 = new Process();
            p12.StartInfo.UseShellExecute = false;
            p12.StartInfo.RedirectStandardOutput = true;
            p12.StartInfo.FileName = "cmd.exe";
            p12.StartInfo.Arguments = "/c fastboot flash xbl_b DRG-330B-0-00WW-B01-xbl.img  2>>log.txt ";
            p12.StartInfo.CreateNoWindow = true;
            p12.Start();
            richTextBox1.Text = richTextBox1.Text + p12.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p12.WaitForExit();

            Process p13 = new Process();
            p13.StartInfo.UseShellExecute = false;
            p13.StartInfo.RedirectStandardOutput = true;
            p13.StartInfo.FileName = "cmd.exe";
            p13.StartInfo.Arguments = "/c echo Flashing bluetooth_a.. ";
            p13.StartInfo.CreateNoWindow = true;
            p13.Start();
            richTextBox1.Text = richTextBox1.Text + p13.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p13.WaitForExit();

            Process p14 = new Process();
            p14.StartInfo.UseShellExecute = false;
            p14.StartInfo.RedirectStandardOutput = true;
            p14.StartInfo.FileName = "cmd.exe";
            p14.StartInfo.Arguments = "/c fastboot flash bluetooth_a DRG-330B-0-00WW-B01-bluetooth.img  2>>log.txt ";
            p14.StartInfo.CreateNoWindow = true;
            p14.Start();
            richTextBox1.Text = richTextBox1.Text + p14.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p14.WaitForExit();

            Process p15 = new Process();
            p15.StartInfo.UseShellExecute = false;
            p15.StartInfo.RedirectStandardOutput = true;
            p15.StartInfo.FileName = "cmd.exe";
            p15.StartInfo.Arguments = "/c echo Flashing boot_a.. ";
            p15.StartInfo.CreateNoWindow = true;
            p15.Start();
            richTextBox1.Text = richTextBox1.Text + p15.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p15.WaitForExit();

            Process p16 = new Process();
            p16.StartInfo.UseShellExecute = false;
            p16.StartInfo.RedirectStandardOutput = true;
            p16.StartInfo.FileName = "cmd.exe";
            p16.StartInfo.Arguments = "/c fastboot flash boot_a DRG-330B-0-00WW-B01-boot.img  2>>log.txt ";
            p16.StartInfo.CreateNoWindow = true;
            p16.Start();
            richTextBox1.Text = richTextBox1.Text + p16.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p16.WaitForExit();

            Process p17 = new Process();
            p17.StartInfo.UseShellExecute = false;
            p17.StartInfo.RedirectStandardOutput = true;
            p17.StartInfo.FileName = "cmd.exe";
            p17.StartInfo.Arguments = "/c echo Flashing cda_a.. ";
            p17.StartInfo.CreateNoWindow = true;
            p17.Start();
            richTextBox1.Text = richTextBox1.Text + p17.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p17.WaitForExit();

            Process p18 = new Process();
            p18.StartInfo.UseShellExecute = false;
            p18.StartInfo.RedirectStandardOutput = true;
            p18.StartInfo.FileName = "cmd.exe";
            p18.StartInfo.Arguments = "/c fastboot flash cda_a DRG-330B-0-00WW-B01-cda.img  2>>log.txt ";
            p18.StartInfo.CreateNoWindow = true;
            p18.Start();
            richTextBox1.Text = richTextBox1.Text + p18.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p18.WaitForExit();

            Process p19 = new Process();
            p19.StartInfo.UseShellExecute = false;
            p19.StartInfo.RedirectStandardOutput = true;
            p19.StartInfo.FileName = "cmd.exe";
            p19.StartInfo.Arguments = "/c echo Flashing cmnlib_a.. ";
            p19.StartInfo.CreateNoWindow = true;
            p19.Start();
            richTextBox1.Text = richTextBox1.Text + p19.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p19.WaitForExit();

            Process p20 = new Process();
            p20.StartInfo.UseShellExecute = false;
            p20.StartInfo.RedirectStandardOutput = true;
            p20.StartInfo.FileName = "cmd.exe";
            p20.StartInfo.Arguments = "/c fastboot flash cmnlib_a DRG-330B-0-00WW-B01-cmnlib.img  2>>log.txt ";
            p20.StartInfo.CreateNoWindow = true;
            p20.Start();
            richTextBox1.Text = richTextBox1.Text + p20.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p20.WaitForExit();

            Process p21 = new Process();
            p21.StartInfo.UseShellExecute = false;
            p21.StartInfo.RedirectStandardOutput = true;
            p21.StartInfo.FileName = "cmd.exe";
            p21.StartInfo.Arguments = "/c echo Flashing cmnlib64_a.. ";
            p21.StartInfo.CreateNoWindow = true;
            p21.Start();
            richTextBox1.Text = richTextBox1.Text + p21.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p21.WaitForExit();

            Process p22 = new Process();
            p22.StartInfo.UseShellExecute = false;
            p22.StartInfo.RedirectStandardOutput = true;
            p22.StartInfo.FileName = "cmd.exe";
            p22.StartInfo.Arguments = "/c fastboot flash cmnlib64_a DRG-330B-0-00WW-B01-cmnlib64.img  2>>log.txt ";
            p22.StartInfo.CreateNoWindow = true;
            p22.Start();
            richTextBox1.Text = richTextBox1.Text + p22.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p22.WaitForExit();

            Process p23 = new Process();
            p23.StartInfo.UseShellExecute = false;
            p23.StartInfo.RedirectStandardOutput = true;
            p23.StartInfo.FileName = "cmd.exe";
            p23.StartInfo.Arguments = "/c echo Flashing devcfg_a.. ";
            p23.StartInfo.CreateNoWindow = true;
            p23.Start();
            richTextBox1.Text = richTextBox1.Text + p23.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p23.WaitForExit();

            Process p24 = new Process();
            p24.StartInfo.UseShellExecute = false;
            p24.StartInfo.RedirectStandardOutput = true;
            p24.StartInfo.FileName = "cmd.exe";
            p24.StartInfo.Arguments = "/c fastboot flash devcfg_a DRG-330B-0-00WW-B01-devcfg.img  2>>log.txt ";
            p24.StartInfo.CreateNoWindow = true;
            p24.Start();
            richTextBox1.Text = richTextBox1.Text + p24.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p24.WaitForExit();

            Process p25 = new Process();
            p25.StartInfo.UseShellExecute = false;
            p25.StartInfo.RedirectStandardOutput = true;
            p25.StartInfo.FileName = "cmd.exe";
            p25.StartInfo.Arguments = "/c echo Flashing dsp_a.. ";
            p25.StartInfo.CreateNoWindow = true;
            p25.Start();
            richTextBox1.Text = richTextBox1.Text + p25.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p25.WaitForExit();

            Process p26 = new Process();
            p26.StartInfo.UseShellExecute = false;
            p26.StartInfo.RedirectStandardOutput = true;
            p26.StartInfo.FileName = "cmd.exe";
            p26.StartInfo.Arguments = "/c fastboot flash dsp_a DRG-330B-0-00WW-B01-dsp.img  2>>log.txt ";
            p26.StartInfo.CreateNoWindow = true;
            p26.Start();
            richTextBox1.Text = richTextBox1.Text + p26.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p26.WaitForExit();

            Process p27 = new Process();
            p27.StartInfo.UseShellExecute = false;
            p27.StartInfo.RedirectStandardOutput = true;
            p27.StartInfo.FileName = "cmd.exe";
            p27.StartInfo.Arguments = "/c echo Flashing hidden_a.. ";
            p27.StartInfo.CreateNoWindow = true;
            p27.Start();
            richTextBox1.Text = richTextBox1.Text + p27.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p27.WaitForExit();

            Process p28 = new Process();
            p28.StartInfo.UseShellExecute = false;
            p28.StartInfo.RedirectStandardOutput = true;
            p28.StartInfo.FileName = "cmd.exe";
            p28.StartInfo.Arguments = "/c fastboot flash hidden_a DRG-330B-0-00WW-B01-hidden.img  2>>log.txt ";
            p28.StartInfo.CreateNoWindow = true;
            p28.Start();
            richTextBox1.Text = richTextBox1.Text + p28.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p28.WaitForExit();

            Process p29 = new Process();
            p29.StartInfo.UseShellExecute = false;
            p29.StartInfo.RedirectStandardOutput = true;
            p29.StartInfo.FileName = "cmd.exe";
            p29.StartInfo.Arguments = "/c echo Flashing hyp_a.. ";
            p29.StartInfo.CreateNoWindow = true;
            p29.Start();
            richTextBox1.Text = richTextBox1.Text + p29.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p29.WaitForExit();

            Process p30 = new Process();
            p30.StartInfo.UseShellExecute = false;
            p30.StartInfo.RedirectStandardOutput = true;
            p30.StartInfo.FileName = "cmd.exe";
            p30.StartInfo.Arguments = "/c fastboot flash hyp_a DRG-330B-0-00WW-B01-hyp.img  2>>log.txt ";
            p30.StartInfo.CreateNoWindow = true;
            p30.Start();
            richTextBox1.Text = richTextBox1.Text + p30.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p30.WaitForExit();

            Process p31 = new Process();
            p31.StartInfo.UseShellExecute = false;
            p31.StartInfo.RedirectStandardOutput = true;
            p31.StartInfo.FileName = "cmd.exe";
            p31.StartInfo.Arguments = "/c echo flashing keymaster_a.. ";
            p31.StartInfo.CreateNoWindow = true;
            p31.Start();
            richTextBox1.Text = richTextBox1.Text + p31.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p31.WaitForExit();

            Process p32 = new Process();
            p32.StartInfo.UseShellExecute = false;
            p32.StartInfo.RedirectStandardOutput = true;
            p32.StartInfo.FileName = "cmd.exe";
            p32.StartInfo.Arguments = "/c fastboot flash keymaster_a DRG-330B-0-00WW-B01-keymaster.img  2>>log.txt ";
            p32.StartInfo.CreateNoWindow = true;
            p32.Start();
            richTextBox1.Text = richTextBox1.Text + p32.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p32.WaitForExit();

            Process p33 = new Process();
            p33.StartInfo.UseShellExecute = false;
            p33.StartInfo.RedirectStandardOutput = true;
            p33.StartInfo.FileName = "cmd.exe";
            p33.StartInfo.Arguments = "/c echo Flashing mdtp_a.. ";
            p33.StartInfo.CreateNoWindow = true;
            p33.Start();
            richTextBox1.Text = richTextBox1.Text + p33.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p33.WaitForExit();

            Process p34 = new Process();
            p34.StartInfo.UseShellExecute = false;
            p34.StartInfo.RedirectStandardOutput = true;
            p34.StartInfo.FileName = "cmd.exe";
            p34.StartInfo.Arguments = "/c fastboot flash mdtp_a DRG-330B-0-00WW-B01-mdtp.img  2>>log.txt ";
            p34.StartInfo.CreateNoWindow = true;
            p34.Start();
            richTextBox1.Text = richTextBox1.Text + p34.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p34.WaitForExit();

            Process p35 = new Process();
            p35.StartInfo.UseShellExecute = false;
            p35.StartInfo.RedirectStandardOutput = true;
            p35.StartInfo.FileName = "cmd.exe";
            p35.StartInfo.Arguments = "/c echo Flashing mdtpsecapp_a.. ";
            p35.StartInfo.CreateNoWindow = true;
            p35.Start();
            richTextBox1.Text = richTextBox1.Text + p35.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p35.WaitForExit();

            Process p36 = new Process();
            p36.StartInfo.UseShellExecute = false;
            p36.StartInfo.RedirectStandardOutput = true;
            p36.StartInfo.FileName = "cmd.exe";
            p36.StartInfo.Arguments = "/c fastboot flash mdtpsecapp_a DRG-330B-0-00WW-B01-mdtpsecapp.img  2>>log.txt ";
            p36.StartInfo.CreateNoWindow = true;
            p36.Start();
            richTextBox1.Text = richTextBox1.Text + p36.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p36.WaitForExit();

            Process p37 = new Process();
            p37.StartInfo.UseShellExecute = false;
            p37.StartInfo.RedirectStandardOutput = true;
            p37.StartInfo.FileName = "cmd.exe";
            p37.StartInfo.Arguments = "/c echo Flashing modem_a.. ";
            p37.StartInfo.CreateNoWindow = true;
            p37.Start();
            richTextBox1.Text = richTextBox1.Text + p37.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p37.WaitForExit();

            Process p38 = new Process();
            p38.StartInfo.UseShellExecute = false;
            p38.StartInfo.RedirectStandardOutput = true;
            p38.StartInfo.FileName = "cmd.exe";
            p38.StartInfo.Arguments = "/c fastboot flash modem_a DRG-330B-0-00WW-B01-modem.img  2>>log.txt ";
            p38.StartInfo.CreateNoWindow = true;
            p38.Start();
            richTextBox1.Text = richTextBox1.Text + p38.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p38.WaitForExit();

            Process p39 = new Process();
            p39.StartInfo.UseShellExecute = false;
            p39.StartInfo.RedirectStandardOutput = true;
            p39.StartInfo.FileName = "cmd.exe";
            p39.StartInfo.Arguments = "/c echo Flashing nvdef_a.. ";
            p39.StartInfo.CreateNoWindow = true;
            p39.Start();
            richTextBox1.Text = richTextBox1.Text + p39.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p39.WaitForExit();

            Process p40 = new Process();
            p40.StartInfo.UseShellExecute = false;
            p40.StartInfo.RedirectStandardOutput = true;
            p40.StartInfo.FileName = "cmd.exe";
            p40.StartInfo.Arguments = "/c fastboot flash nvdef_a DRG-330B-0-00WW-B01-nvdef.img  2>>log.txt ";
            p40.StartInfo.CreateNoWindow = true;
            p40.Start();
            richTextBox1.Text = richTextBox1.Text + p40.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p40.WaitForExit();

            Process p41 = new Process();
            p41.StartInfo.UseShellExecute = false;
            p41.StartInfo.RedirectStandardOutput = true;
            p41.StartInfo.FileName = "cmd.exe";
            p41.StartInfo.Arguments = "/c echo Flashing pmic_a.. ";
            p41.StartInfo.CreateNoWindow = true;
            p41.Start();
            richTextBox1.Text = richTextBox1.Text + p41.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p41.WaitForExit();

            Process p42 = new Process();
            p42.StartInfo.UseShellExecute = false;
            p42.StartInfo.RedirectStandardOutput = true;
            p42.StartInfo.FileName = "cmd.exe";
            p42.StartInfo.Arguments = "/c fastboot flash pmic_a DRG-330B-0-00WW-B01-pmic.img  2>>log.txt";
            p42.StartInfo.CreateNoWindow = true;
            p42.Start();
            richTextBox1.Text = richTextBox1.Text + p42.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p42.WaitForExit();

            Process p43 = new Process();
            p43.StartInfo.UseShellExecute = false;
            p43.StartInfo.RedirectStandardOutput = true;
            p43.StartInfo.FileName = "cmd.exe";
            p43.StartInfo.Arguments = "/c echo FLashing rpm_a.. ";
            p43.StartInfo.CreateNoWindow = true;
            p43.Start();
            richTextBox1.Text = richTextBox1.Text + p43.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p43.WaitForExit();

            Process p44 = new Process();
            p44.StartInfo.UseShellExecute = false;
            p44.StartInfo.RedirectStandardOutput = true;
            p44.StartInfo.FileName = "cmd.exe";
            p44.StartInfo.Arguments = "/c fastboot flash rpm_a DRG-330B-0-00WW-B01-rpm.img  2>>log.txt ";
            p44.StartInfo.CreateNoWindow = true;
            p44.Start();
            richTextBox1.Text = richTextBox1.Text + p44.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p44.WaitForExit();

            Process p45 = new Process();
            p45.StartInfo.UseShellExecute = false;
            p45.StartInfo.RedirectStandardOutput = true;
            p45.StartInfo.FileName = "cmd.exe";
            p45.StartInfo.Arguments = "/c echo Flashing splash_a.. ";
            p45.StartInfo.CreateNoWindow = true;
            p45.Start();
            richTextBox1.Text = richTextBox1.Text + p45.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p45.WaitForExit();

            Process p46 = new Process();
            p46.StartInfo.UseShellExecute = false;
            p46.StartInfo.RedirectStandardOutput = true;
            p46.StartInfo.FileName = "cmd.exe";
            p46.StartInfo.Arguments = "/c fastboot flash splash_a DRG-330B-0-00WW-B01-splash.img  2>>log.txt ";
            p46.StartInfo.CreateNoWindow = true;
            p46.Start();
            richTextBox1.Text = richTextBox1.Text + p46.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p46.WaitForExit();

            Process p47 = new Process();
            p47.StartInfo.UseShellExecute = false;
            p47.StartInfo.RedirectStandardOutput = true;
            p47.StartInfo.FileName = "cmd.exe";
            p47.StartInfo.Arguments = "/c echo Flashing system_a.. ";
            p47.StartInfo.CreateNoWindow = true;
            p47.Start();
            richTextBox1.Text = richTextBox1.Text + p47.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p47.WaitForExit();

            Process p48 = new Process();
            p48.StartInfo.UseShellExecute = false;
            p48.StartInfo.RedirectStandardOutput = true;
            p48.StartInfo.FileName = "cmd.exe";
            p48.StartInfo.Arguments = "/c fastboot flash system_a DRG-330B-0-00WW-B01-system.img  2>>log.txt ";
            p48.StartInfo.CreateNoWindow = true;
            p48.Start();
            richTextBox1.Text = richTextBox1.Text + p48.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p48.WaitForExit();

            Process p49 = new Process();
            p49.StartInfo.UseShellExecute = false;
            p49.StartInfo.RedirectStandardOutput = true;
            p49.StartInfo.FileName = "cmd.exe";
            p49.StartInfo.Arguments = "/c echo Flashing systeminfo_a.. ";
            p49.StartInfo.CreateNoWindow = true;
            p49.Start();
            richTextBox1.Text = richTextBox1.Text + p49.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p49.WaitForExit();

            Process p50 = new Process();
            p50.StartInfo.UseShellExecute = false;
            p50.StartInfo.RedirectStandardOutput = true;
            p50.StartInfo.FileName = "cmd.exe";
            p50.StartInfo.Arguments = "/c fastboot flash systeminfo_a DRG-330B-0-00WW-B01-systeminfo.img  2>>log.txt";
            p50.StartInfo.CreateNoWindow = true;
            p50.Start();
            richTextBox1.Text = richTextBox1.Text + p50.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p50.WaitForExit();

            Process p51 = new Process();
            p51.StartInfo.UseShellExecute = false;
            p51.StartInfo.RedirectStandardOutput = true;
            p51.StartInfo.FileName = "cmd.exe";
            p51.StartInfo.Arguments = "/c echo Flshing tz_a.";
            p51.StartInfo.CreateNoWindow = true;
            p51.Start();
            richTextBox1.Text = richTextBox1.Text + p51.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p51.WaitForExit();

            Process p52 = new Process();
            p52.StartInfo.UseShellExecute = false;
            p52.StartInfo.RedirectStandardOutput = true;
            p52.StartInfo.FileName = "cmd.exe";
            p52.StartInfo.Arguments = "/c fastboot flash tz_a DRG-330B-0-00WW-B01-tz.img  2>>log.txt";
            p52.StartInfo.CreateNoWindow = true;
            p52.Start();
            richTextBox1.Text = richTextBox1.Text + p52.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p52.WaitForExit();

            Process p53 = new Process();
            p53.StartInfo.UseShellExecute = false;
            p53.StartInfo.RedirectStandardOutput = true;
            p53.StartInfo.FileName = "cmd.exe";
            p53.StartInfo.Arguments = "/c echo Flashing vendor_a.. ";
            p53.StartInfo.CreateNoWindow = true;
            p53.Start();
            richTextBox1.Text = richTextBox1.Text + p53.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p53.WaitForExit();

            Process p54 = new Process();
            p54.StartInfo.UseShellExecute = false;
            p54.StartInfo.RedirectStandardOutput = true;
            p54.StartInfo.FileName = "cmd.exe";
            p54.StartInfo.Arguments = "/c fastboot flash vendor_a DRG-330B-0-00WW-B01-vendor.img  2>>log.txt ";
            p54.StartInfo.CreateNoWindow = true;
            p54.Start();
            richTextBox1.Text = richTextBox1.Text + p54.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p54.WaitForExit();

            Process p55 = new Process();
            p55.StartInfo.UseShellExecute = false;
            p55.StartInfo.RedirectStandardOutput = true;
            p55.StartInfo.FileName = "cmd.exe";
            p55.StartInfo.Arguments = "/c echo Erase ssd..";
            p55.StartInfo.CreateNoWindow = true;
            p55.Start();
            richTextBox1.Text = richTextBox1.Text + p55.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p55.WaitForExit();

            Process p56 = new Process();
            p56.StartInfo.UseShellExecute = false;
            p56.StartInfo.RedirectStandardOutput = true;
            p56.StartInfo.FileName = "cmd.exe";
            p56.StartInfo.Arguments = "/c fastboot erase ssd ";
            p56.StartInfo.CreateNoWindow = true;
            p56.Start();
            richTextBox1.Text = richTextBox1.Text + p56.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p56.WaitForExit();

            Process p57 = new Process();
            p57.StartInfo.UseShellExecute = false;
            p57.StartInfo.RedirectStandardOutput = true;
            p57.StartInfo.FileName = "cmd.exe";
            p57.StartInfo.Arguments = "/c echo Erase misc.. ";
            p57.StartInfo.CreateNoWindow = true;
            p57.Start();
            richTextBox1.Text = richTextBox1.Text + p57.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p57.WaitForExit();

            Process p58 = new Process();
            p58.StartInfo.UseShellExecute = false;
            p58.StartInfo.RedirectStandardOutput = true;
            p58.StartInfo.FileName = "cmd.exe";
            p58.StartInfo.Arguments = "/c fastboot erase misc ";
            p58.StartInfo.CreateNoWindow = true;
            p58.Start();
            richTextBox1.Text = richTextBox1.Text + p58.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p58.WaitForExit();

            Process p59 = new Process();
            p59.StartInfo.UseShellExecute = false;
            p59.StartInfo.RedirectStandardOutput = true;
            p59.StartInfo.FileName = "cmd.exe";
            p59.StartInfo.Arguments = "/c echo Erase sti.. ";
            p59.StartInfo.CreateNoWindow = true;
            p59.Start();
            richTextBox1.Text = richTextBox1.Text + p59.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p59.WaitForExit();

            Process p60 = new Process();
            p60.StartInfo.UseShellExecute = false;
            p60.StartInfo.RedirectStandardOutput = true;
            p60.StartInfo.FileName = "cmd.exe";
            p60.StartInfo.Arguments = "/c fastboot erase sti ";
            p60.StartInfo.CreateNoWindow = true;
            p60.Start();
            richTextBox1.Text = richTextBox1.Text + p60.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p60.WaitForExit();

            Process p61 = new Process();
            p61.StartInfo.UseShellExecute = false;
            p61.StartInfo.RedirectStandardOutput = true;
            p61.StartInfo.FileName = "cmd.exe";
            p61.StartInfo.Arguments = "/c echo Erase ddr.. ";
            p61.StartInfo.CreateNoWindow = true;
            p61.Start();
            richTextBox1.Text = richTextBox1.Text + p61.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p61.WaitForExit();

            Process p62 = new Process();
            p62.StartInfo.UseShellExecute = false;
            p62.StartInfo.RedirectStandardOutput = true;
            p62.StartInfo.FileName = "cmd.exe";
            p62.StartInfo.Arguments = "/c fastboot erase ddr ";
            p62.StartInfo.CreateNoWindow = true;
            p62.Start();
            richTextBox1.Text = richTextBox1.Text + p62.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p62.WaitForExit();

            Process p63 = new Process();
            p63.StartInfo.UseShellExecute = false;
            p63.StartInfo.RedirectStandardOutput = true;
            p63.StartInfo.FileName = "cmd.exe";
            p63.StartInfo.Arguments = "/c echo Erase securefs.. ";
            p63.StartInfo.CreateNoWindow = true;
            p63.Start();
            richTextBox1.Text = richTextBox1.Text + p63.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p63.WaitForExit();

            Process p64 = new Process();
            p64.StartInfo.UseShellExecute = false;
            p64.StartInfo.RedirectStandardOutput = true;
            p64.StartInfo.FileName = "cmd.exe";
            p64.StartInfo.Arguments = "/c fastboot erase securefs ";
            p64.StartInfo.CreateNoWindow = true;
            p64.Start();
            richTextBox1.Text = richTextBox1.Text + p64.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p64.WaitForExit();

            Process p65 = new Process();
            p65.StartInfo.UseShellExecute = false;
            p65.StartInfo.RedirectStandardOutput = true;
            p65.StartInfo.FileName = "cmd.exe";
            p65.StartInfo.Arguments = "/c echo Erase box.. ";
            p65.StartInfo.CreateNoWindow = true;
            p65.Start();
            richTextBox1.Text = richTextBox1.Text + p65.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p65.WaitForExit();

            Process p66 = new Process();
            p66.StartInfo.UseShellExecute = false;
            p66.StartInfo.RedirectStandardOutput = true;
            p66.StartInfo.FileName = "cmd.exe";
            p66.StartInfo.Arguments = "/c fastboot erase box ";
            p66.StartInfo.CreateNoWindow = true;
            p66.Start();
            richTextBox1.Text = richTextBox1.Text + p66.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p66.WaitForExit();

            Process p67 = new Process();
            p67.StartInfo.UseShellExecute = false;
            p67.StartInfo.RedirectStandardOutput = true;
            p67.StartInfo.FileName = "cmd.exe";
            p67.StartInfo.Arguments = "/c echo Erase boot_b.. ";
            p67.StartInfo.CreateNoWindow = true;
            p67.Start();
            richTextBox1.Text = richTextBox1.Text + p67.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p67.WaitForExit();

            Process p68 = new Process();
            p68.StartInfo.UseShellExecute = false;
            p68.StartInfo.RedirectStandardOutput = true;
            p68.StartInfo.FileName = "cmd.exe";
            p68.StartInfo.Arguments = "/c fastboot erase boot_b ";
            p68.StartInfo.CreateNoWindow = true;
            p68.Start();
            richTextBox1.Text = richTextBox1.Text + p68.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p68.WaitForExit();

            Process p69 = new Process();
            p69.StartInfo.UseShellExecute = false;
            p69.StartInfo.RedirectStandardOutput = true;
            p69.StartInfo.FileName = "cmd.exe";
            p69.StartInfo.Arguments = "/c echo set active slot A.. ";
            p69.StartInfo.CreateNoWindow = true;
            p69.Start();
            richTextBox1.Text = richTextBox1.Text + p69.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p69.WaitForExit();

            Process p70 = new Process();
            p70.StartInfo.UseShellExecute = false;
            p70.StartInfo.RedirectStandardOutput = true;
            p70.StartInfo.FileName = "cmd.exe";
            p70.StartInfo.Arguments = "/c fastboot --set-active=a ";
            p70.StartInfo.CreateNoWindow = true;
            p70.Start();
            richTextBox1.Text = richTextBox1.Text + p70.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p70.WaitForExit();

            Process p71 = new Process();
            p71.StartInfo.UseShellExecute = false;
            p71.StartInfo.RedirectStandardOutput = true;
            p71.StartInfo.FileName = "cmd.exe";
            p71.StartInfo.Arguments = "/c echo Erase Userdata.. ";
            p71.StartInfo.CreateNoWindow = true;
            p71.Start();
            richTextBox1.Text = richTextBox1.Text + p71.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p71.WaitForExit();

            Process p72 = new Process();
            p72.StartInfo.UseShellExecute = false;
            p72.StartInfo.RedirectStandardOutput = true;
            p72.StartInfo.FileName = "cmd.exe";
            p72.StartInfo.Arguments = "/c fastboot -w ";
            p72.StartInfo.CreateNoWindow = true;
            p72.Start();
            richTextBox1.Refresh();

            Process p73 = new Process();
            p73.StartInfo.UseShellExecute = false;
            p73.StartInfo.RedirectStandardOutput = true;
            p73.StartInfo.FileName = "cmd.exe";
            p73.StartInfo.Arguments = "/c echo Rebooting system.. ";
            p73.StartInfo.CreateNoWindow = true;
            p73.Start();
            richTextBox1.Text = richTextBox1.Text + p73.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p73.WaitForExit();

            Process p74 = new Process();
            p74.StartInfo.UseShellExecute = false;
            p74.StartInfo.RedirectStandardOutput = true;
            p74.StartInfo.FileName = "cmd.exe";
            p74.StartInfo.Arguments = "/c fastboot reboot ";
            p74.StartInfo.CreateNoWindow = true;
            p74.Start();
            richTextBox1.Text = richTextBox1.Text + p74.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p74.WaitForExit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process p1 = new Process();
            p1.StartInfo.UseShellExecute = false;
            p1.StartInfo.RedirectStandardOutput = true;
            p1.StartInfo.FileName = "cmd.exe";
            p1.StartInfo.Arguments = "/c echo getversions..";
            p1.StartInfo.CreateNoWindow = true;
            p1.Start();
            richTextBox1.Text = richTextBox1.Text + p1.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p1.WaitForExit();


            Process p2 = new Process();
            p2.StartInfo.UseShellExecute = false;
            p2.StartInfo.RedirectStandardOutput = true;
            p2.StartInfo.FileName = "cmd.exe";
            p2.StartInfo.Arguments = "/c fastboot oem getversions 2>getver.txt & type getver.txt ";
            p2.StartInfo.CreateNoWindow = true;
            p2.Start();
            richTextBox1.Text = richTextBox1.Text + p2.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p2.WaitForExit();

            Process p3 = new Process();
            p3.StartInfo.UseShellExecute = false;
            p3.StartInfo.RedirectStandardOutput = true;
            p3.StartInfo.FileName = "cmd.exe";
            p3.StartInfo.Arguments = "/c echo device-info..";
            p3.StartInfo.CreateNoWindow = true;
            p3.Start();
            richTextBox1.Text = richTextBox1.Text + p3.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p3.WaitForExit();


            Process p4 = new Process();
            p4.StartInfo.UseShellExecute = false;
            p4.StartInfo.RedirectStandardOutput = true;
            p4.StartInfo.FileName = "cmd.exe";
            p4.StartInfo.Arguments = "/c fastboot oem device-info 2>device.txt & type device.txt  ";
            p4.StartInfo.CreateNoWindow = true;
            p4.Start();
            richTextBox1.Text = richTextBox1.Text + p4.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p4.WaitForExit();

            Process p5 = new Process();
            p5.StartInfo.UseShellExecute = false;
            p5.StartInfo.RedirectStandardOutput = true;
            p5.StartInfo.FileName = "cmd.exe";
            p5.StartInfo.Arguments = "/c echo Flashing abl_a..";
            p5.StartInfo.CreateNoWindow = true;
            p5.Start();
            richTextBox1.Text = richTextBox1.Text + p5.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p5.WaitForExit();


            Process p6 = new Process();
            p6.StartInfo.UseShellExecute = false;
            p6.StartInfo.RedirectStandardOutput = true;
            p6.StartInfo.FileName = "cmd.exe";
            p6.StartInfo.Arguments = "/c fastboot flash abl_a CTL-408B-0-00WW-B03-abl.img  2>>log.txt  ";
            p6.StartInfo.CreateNoWindow = true;
            p6.Start();
            richTextBox1.Text = richTextBox1.Text + p6.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p6.WaitForExit();

            Process p7 = new Process();
            p7.StartInfo.UseShellExecute = false;
            p7.StartInfo.RedirectStandardOutput = true;
            p7.StartInfo.FileName = "cmd.exe";
            p7.StartInfo.Arguments = "/c echo Flashing abl_b..";
            p7.StartInfo.CreateNoWindow = true;
            p7.Start();
            richTextBox1.Text = richTextBox1.Text + p7.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p7.WaitForExit();

            Process p8 = new Process();
            p8.StartInfo.UseShellExecute = false;
            p8.StartInfo.RedirectStandardOutput = true;
            p8.StartInfo.FileName = "cmd.exe";
            p8.StartInfo.Arguments = "/c fastboot flash abl_b CTL-408B-0-00WW-B03-abl.img  2>>log.txt ";
            p8.StartInfo.CreateNoWindow = true;
            p8.Start();
            richTextBox1.Text = richTextBox1.Text + p8.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p8.WaitForExit();

            Process p9 = new Process();
            p9.StartInfo.UseShellExecute = false;
            p9.StartInfo.RedirectStandardOutput = true;
            p9.StartInfo.FileName = "cmd.exe";
            p9.StartInfo.Arguments = "/c echo FLashing xbl_a..";
            p9.StartInfo.CreateNoWindow = true;
            p9.Start();
            richTextBox1.Text = richTextBox1.Text + p9.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p9.WaitForExit();

            Process p10 = new Process();
            p10.StartInfo.UseShellExecute = false;
            p10.StartInfo.RedirectStandardOutput = true;
            p10.StartInfo.FileName = "cmd.exe";
            p10.StartInfo.Arguments = "/c fastboot flash xbl_a CTL-408B-0-00WW-B03-xbl.img  2>>log.txt ";
            p10.StartInfo.CreateNoWindow = true;
            p10.Start();
            richTextBox1.Text = richTextBox1.Text + p10.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p10.WaitForExit();

            Process p11 = new Process();
            p11.StartInfo.UseShellExecute = false;
            p11.StartInfo.RedirectStandardOutput = true;
            p11.StartInfo.FileName = "cmd.exe";
            p11.StartInfo.Arguments = "/c echo Flashing xbl_b.. ";
            p11.StartInfo.CreateNoWindow = true;
            p11.Start();
            richTextBox1.Text = richTextBox1.Text + p11.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p11.WaitForExit();

            Process p12 = new Process();
            p12.StartInfo.UseShellExecute = false;
            p12.StartInfo.RedirectStandardOutput = true;
            p12.StartInfo.FileName = "cmd.exe";
            p12.StartInfo.Arguments = "/c fastboot flash xbl_b CTL-408B-0-00WW-B03-xbl.img  2>>log.txt ";
            p12.StartInfo.CreateNoWindow = true;
            p12.Start();
            richTextBox1.Text = richTextBox1.Text + p12.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p12.WaitForExit();

            Process p13 = new Process();
            p13.StartInfo.UseShellExecute = false;
            p13.StartInfo.RedirectStandardOutput = true;
            p13.StartInfo.FileName = "cmd.exe";
            p13.StartInfo.Arguments = "/c echo Flashing bluetooth_a.. ";
            p13.StartInfo.CreateNoWindow = true;
            p13.Start();
            richTextBox1.Text = richTextBox1.Text + p13.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p13.WaitForExit();

            Process p14 = new Process();
            p14.StartInfo.UseShellExecute = false;
            p14.StartInfo.RedirectStandardOutput = true;
            p14.StartInfo.FileName = "cmd.exe";
            p14.StartInfo.Arguments = "/c fastboot flash bluetooth_a CTL-408B-0-00WW-B03-bluetooth.img  2>>log.txt ";
            p14.StartInfo.CreateNoWindow = true;
            p14.Start();
            richTextBox1.Text = richTextBox1.Text + p14.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p14.WaitForExit();

            Process p15 = new Process();
            p15.StartInfo.UseShellExecute = false;
            p15.StartInfo.RedirectStandardOutput = true;
            p15.StartInfo.FileName = "cmd.exe";
            p15.StartInfo.Arguments = "/c echo Flashing boot_a.. ";
            p15.StartInfo.CreateNoWindow = true;
            p15.Start();
            richTextBox1.Text = richTextBox1.Text + p15.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p15.WaitForExit();

            Process p16 = new Process();
            p16.StartInfo.UseShellExecute = false;
            p16.StartInfo.RedirectStandardOutput = true;
            p16.StartInfo.FileName = "cmd.exe";
            p16.StartInfo.Arguments = "/c fastboot flash boot_a CTL-408B-0-00WW-B03-boot.img  2>>log.txt ";
            p16.StartInfo.CreateNoWindow = true;
            p16.Start();
            richTextBox1.Text = richTextBox1.Text + p16.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p16.WaitForExit();

            Process p17 = new Process();
            p17.StartInfo.UseShellExecute = false;
            p17.StartInfo.RedirectStandardOutput = true;
            p17.StartInfo.FileName = "cmd.exe";
            p17.StartInfo.Arguments = "/c echo Flashing cda_a.. ";
            p17.StartInfo.CreateNoWindow = true;
            p17.Start();
            richTextBox1.Text = richTextBox1.Text + p17.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p17.WaitForExit();

            Process p18 = new Process();
            p18.StartInfo.UseShellExecute = false;
            p18.StartInfo.RedirectStandardOutput = true;
            p18.StartInfo.FileName = "cmd.exe";
            p18.StartInfo.Arguments = "/c fastboot flash cda_a CTL-408B-0-00WW-B03-cda.img  2>>log.txt ";
            p18.StartInfo.CreateNoWindow = true;
            p18.Start();
            richTextBox1.Text = richTextBox1.Text + p18.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p18.WaitForExit();

            Process p19 = new Process();
            p19.StartInfo.UseShellExecute = false;
            p19.StartInfo.RedirectStandardOutput = true;
            p19.StartInfo.FileName = "cmd.exe";
            p19.StartInfo.Arguments = "/c echo Flashing cmnlib_a.. ";
            p19.StartInfo.CreateNoWindow = true;
            p19.Start();
            richTextBox1.Text = richTextBox1.Text + p19.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p19.WaitForExit();

            Process p20 = new Process();
            p20.StartInfo.UseShellExecute = false;
            p20.StartInfo.RedirectStandardOutput = true;
            p20.StartInfo.FileName = "cmd.exe";
            p20.StartInfo.Arguments = "/c fastboot flash cmnlib_a CTL-408B-0-00WW-B03-cmnlib.img  2>>log.txt ";
            p20.StartInfo.CreateNoWindow = true;
            p20.Start();
            richTextBox1.Text = richTextBox1.Text + p20.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p20.WaitForExit();

            Process p21 = new Process();
            p21.StartInfo.UseShellExecute = false;
            p21.StartInfo.RedirectStandardOutput = true;
            p21.StartInfo.FileName = "cmd.exe";
            p21.StartInfo.Arguments = "/c echo Flashing cmnlib64_a.. ";
            p21.StartInfo.CreateNoWindow = true;
            p21.Start();
            richTextBox1.Text = richTextBox1.Text + p21.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p21.WaitForExit();

            Process p22 = new Process();
            p22.StartInfo.UseShellExecute = false;
            p22.StartInfo.RedirectStandardOutput = true;
            p22.StartInfo.FileName = "cmd.exe";
            p22.StartInfo.Arguments = "/c fastboot flash cmnlib64_a CTL-408B-0-00WW-B03-cmnlib64.img  2>>log.txt ";
            p22.StartInfo.CreateNoWindow = true;
            p22.Start();
            richTextBox1.Text = richTextBox1.Text + p22.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p22.WaitForExit();

            Process p23 = new Process();
            p23.StartInfo.UseShellExecute = false;
            p23.StartInfo.RedirectStandardOutput = true;
            p23.StartInfo.FileName = "cmd.exe";
            p23.StartInfo.Arguments = "/c echo Flashing devcfg_a.. ";
            p23.StartInfo.CreateNoWindow = true;
            p23.Start();
            richTextBox1.Text = richTextBox1.Text + p23.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p23.WaitForExit();

            Process p24 = new Process();
            p24.StartInfo.UseShellExecute = false;
            p24.StartInfo.RedirectStandardOutput = true;
            p24.StartInfo.FileName = "cmd.exe";
            p24.StartInfo.Arguments = "/c fastboot flash devcfg_a CTL-408B-0-00WW-B03-devcfg.img  2>>log.txt ";
            p24.StartInfo.CreateNoWindow = true;
            p24.Start();
            richTextBox1.Text = richTextBox1.Text + p24.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p24.WaitForExit();

            Process p25 = new Process();
            p25.StartInfo.UseShellExecute = false;
            p25.StartInfo.RedirectStandardOutput = true;
            p25.StartInfo.FileName = "cmd.exe";
            p25.StartInfo.Arguments = "/c echo Flashing dsp_a.. ";
            p25.StartInfo.CreateNoWindow = true;
            p25.Start();
            richTextBox1.Text = richTextBox1.Text + p25.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p25.WaitForExit();

            Process p26 = new Process();
            p26.StartInfo.UseShellExecute = false;
            p26.StartInfo.RedirectStandardOutput = true;
            p26.StartInfo.FileName = "cmd.exe";
            p26.StartInfo.Arguments = "/c fastboot flash dsp_a CTL-408B-0-00WW-B03-dsp.img  2>>log.txt ";
            p26.StartInfo.CreateNoWindow = true;
            p26.Start();
            richTextBox1.Text = richTextBox1.Text + p26.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p26.WaitForExit();

            Process p27 = new Process();
            p27.StartInfo.UseShellExecute = false;
            p27.StartInfo.RedirectStandardOutput = true;
            p27.StartInfo.FileName = "cmd.exe";
            p27.StartInfo.Arguments = "/c echo Flashing hidden_a.. ";
            p27.StartInfo.CreateNoWindow = true;
            p27.Start();
            richTextBox1.Text = richTextBox1.Text + p27.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p27.WaitForExit();

            Process p28 = new Process();
            p28.StartInfo.UseShellExecute = false;
            p28.StartInfo.RedirectStandardOutput = true;
            p28.StartInfo.FileName = "cmd.exe";
            p28.StartInfo.Arguments = "/c fastboot flash hidden_a CTL-408B-0-00WW-B03-hidden.img  2>>log.txt ";
            p28.StartInfo.CreateNoWindow = true;
            p28.Start();
            richTextBox1.Text = richTextBox1.Text + p28.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p28.WaitForExit();

            Process p29 = new Process();
            p29.StartInfo.UseShellExecute = false;
            p29.StartInfo.RedirectStandardOutput = true;
            p29.StartInfo.FileName = "cmd.exe";
            p29.StartInfo.Arguments = "/c echo Flashing hyp_a.. ";
            p29.StartInfo.CreateNoWindow = true;
            p29.Start();
            richTextBox1.Text = richTextBox1.Text + p29.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p29.WaitForExit();

            Process p30 = new Process();
            p30.StartInfo.UseShellExecute = false;
            p30.StartInfo.RedirectStandardOutput = true;
            p30.StartInfo.FileName = "cmd.exe";
            p30.StartInfo.Arguments = "/c fastboot flash hyp_a CTL-408B-0-00WW-B03-hyp.img  2>>log.txt ";
            p30.StartInfo.CreateNoWindow = true;
            p30.Start();
            richTextBox1.Text = richTextBox1.Text + p30.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p30.WaitForExit();

            Process p31 = new Process();
            p31.StartInfo.UseShellExecute = false;
            p31.StartInfo.RedirectStandardOutput = true;
            p31.StartInfo.FileName = "cmd.exe";
            p31.StartInfo.Arguments = "/c echo flashing keymaster_a.. ";
            p31.StartInfo.CreateNoWindow = true;
            p31.Start();
            richTextBox1.Text = richTextBox1.Text + p31.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p31.WaitForExit();

            Process p32 = new Process();
            p32.StartInfo.UseShellExecute = false;
            p32.StartInfo.RedirectStandardOutput = true;
            p32.StartInfo.FileName = "cmd.exe";
            p32.StartInfo.Arguments = "/c fastboot flash keymaster_a CTL-408B-0-00WW-B03-keymaster.img  2>>log.txt ";
            p32.StartInfo.CreateNoWindow = true;
            p32.Start();
            richTextBox1.Text = richTextBox1.Text + p32.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p32.WaitForExit();

            Process p33 = new Process();
            p33.StartInfo.UseShellExecute = false;
            p33.StartInfo.RedirectStandardOutput = true;
            p33.StartInfo.FileName = "cmd.exe";
            p33.StartInfo.Arguments = "/c echo Flashing mdtp_a.. ";
            p33.StartInfo.CreateNoWindow = true;
            p33.Start();
            richTextBox1.Text = richTextBox1.Text + p33.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p33.WaitForExit();

            Process p34 = new Process();
            p34.StartInfo.UseShellExecute = false;
            p34.StartInfo.RedirectStandardOutput = true;
            p34.StartInfo.FileName = "cmd.exe";
            p34.StartInfo.Arguments = "/c fastboot flash mdtp_a CTL-408B-0-00WW-B03-mdtp.img  2>>log.txt ";
            p34.StartInfo.CreateNoWindow = true;
            p34.Start();
            richTextBox1.Text = richTextBox1.Text + p34.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p34.WaitForExit();

            Process p35 = new Process();
            p35.StartInfo.UseShellExecute = false;
            p35.StartInfo.RedirectStandardOutput = true;
            p35.StartInfo.FileName = "cmd.exe";
            p35.StartInfo.Arguments = "/c echo Flashing mdtpsecapp_a.. ";
            p35.StartInfo.CreateNoWindow = true;
            p35.Start();
            richTextBox1.Text = richTextBox1.Text + p35.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p35.WaitForExit();

            Process p36 = new Process();
            p36.StartInfo.UseShellExecute = false;
            p36.StartInfo.RedirectStandardOutput = true;
            p36.StartInfo.FileName = "cmd.exe";
            p36.StartInfo.Arguments = "/c fastboot flash mdtpsecapp_a CTL-408B-0-00WW-B03-mdtpsecapp.img  2>>log.txt ";
            p36.StartInfo.CreateNoWindow = true;
            p36.Start();
            richTextBox1.Text = richTextBox1.Text + p36.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p36.WaitForExit();

            Process p37 = new Process();
            p37.StartInfo.UseShellExecute = false;
            p37.StartInfo.RedirectStandardOutput = true;
            p37.StartInfo.FileName = "cmd.exe";
            p37.StartInfo.Arguments = "/c echo Flashing modem_a.. ";
            p37.StartInfo.CreateNoWindow = true;
            p37.Start();
            richTextBox1.Text = richTextBox1.Text + p37.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p37.WaitForExit();

            Process p38 = new Process();
            p38.StartInfo.UseShellExecute = false;
            p38.StartInfo.RedirectStandardOutput = true;
            p38.StartInfo.FileName = "cmd.exe";
            p38.StartInfo.Arguments = "/c fastboot flash modem_a CTL-408B-0-00WW-B03-modem.img  2>>log.txt ";
            p38.StartInfo.CreateNoWindow = true;
            p38.Start();
            richTextBox1.Text = richTextBox1.Text + p38.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p38.WaitForExit();

            Process p39 = new Process();
            p39.StartInfo.UseShellExecute = false;
            p39.StartInfo.RedirectStandardOutput = true;
            p39.StartInfo.FileName = "cmd.exe";
            p39.StartInfo.Arguments = "/c echo Flashing nvdef_a.. ";
            p39.StartInfo.CreateNoWindow = true;
            p39.Start();
            richTextBox1.Text = richTextBox1.Text + p39.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p39.WaitForExit();

            Process p40 = new Process();
            p40.StartInfo.UseShellExecute = false;
            p40.StartInfo.RedirectStandardOutput = true;
            p40.StartInfo.FileName = "cmd.exe";
            p40.StartInfo.Arguments = "/c fastboot flash nvdef_a CTL-408B-0-00WW-B03-nvdef.img  2>>log.txt ";
            p40.StartInfo.CreateNoWindow = true;
            p40.Start();
            richTextBox1.Text = richTextBox1.Text + p40.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p40.WaitForExit();

            Process p41 = new Process();
            p41.StartInfo.UseShellExecute = false;
            p41.StartInfo.RedirectStandardOutput = true;
            p41.StartInfo.FileName = "cmd.exe";
            p41.StartInfo.Arguments = "/c echo Flashing pmic_a.. ";
            p41.StartInfo.CreateNoWindow = true;
            p41.Start();
            richTextBox1.Text = richTextBox1.Text + p41.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p41.WaitForExit();

            Process p42 = new Process();
            p42.StartInfo.UseShellExecute = false;
            p42.StartInfo.RedirectStandardOutput = true;
            p42.StartInfo.FileName = "cmd.exe";
            p42.StartInfo.Arguments = "/c fastboot flash pmic_a CTL-408B-0-00WW-B03-pmic.img  2>>log.txt";
            p42.StartInfo.CreateNoWindow = true;
            p42.Start();
            richTextBox1.Text = richTextBox1.Text + p42.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p42.WaitForExit();

            Process p43 = new Process();
            p43.StartInfo.UseShellExecute = false;
            p43.StartInfo.RedirectStandardOutput = true;
            p43.StartInfo.FileName = "cmd.exe";
            p43.StartInfo.Arguments = "/c echo FLashing rpm_a.. ";
            p43.StartInfo.CreateNoWindow = true;
            p43.Start();
            richTextBox1.Text = richTextBox1.Text + p43.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p43.WaitForExit();

            Process p44 = new Process();
            p44.StartInfo.UseShellExecute = false;
            p44.StartInfo.RedirectStandardOutput = true;
            p44.StartInfo.FileName = "cmd.exe";
            p44.StartInfo.Arguments = "/c fastboot flash rpm_a CTL-408B-0-00WW-B03-rpm.img  2>>log.txt ";
            p44.StartInfo.CreateNoWindow = true;
            p44.Start();
            richTextBox1.Text = richTextBox1.Text + p44.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p44.WaitForExit();

            Process p45 = new Process();
            p45.StartInfo.UseShellExecute = false;
            p45.StartInfo.RedirectStandardOutput = true;
            p45.StartInfo.FileName = "cmd.exe";
            p45.StartInfo.Arguments = "/c echo Flashing splash_a.. ";
            p45.StartInfo.CreateNoWindow = true;
            p45.Start();
            richTextBox1.Text = richTextBox1.Text + p45.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p45.WaitForExit();

            Process p46 = new Process();
            p46.StartInfo.UseShellExecute = false;
            p46.StartInfo.RedirectStandardOutput = true;
            p46.StartInfo.FileName = "cmd.exe";
            p46.StartInfo.Arguments = "/c fastboot flash splash_a CTL-408B-0-00WW-B03-splash.img  2>>log.txt ";
            p46.StartInfo.CreateNoWindow = true;
            p46.Start();
            richTextBox1.Text = richTextBox1.Text + p46.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p46.WaitForExit();

            Process p47 = new Process();
            p47.StartInfo.UseShellExecute = false;
            p47.StartInfo.RedirectStandardOutput = true;
            p47.StartInfo.FileName = "cmd.exe";
            p47.StartInfo.Arguments = "/c echo Flashing system_a.. ";
            p47.StartInfo.CreateNoWindow = true;
            p47.Start();
            richTextBox1.Text = richTextBox1.Text + p47.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p47.WaitForExit();

            Process p48 = new Process();
            p48.StartInfo.UseShellExecute = false;
            p48.StartInfo.RedirectStandardOutput = true;
            p48.StartInfo.FileName = "cmd.exe";
            p48.StartInfo.Arguments = "/c fastboot flash system_a CTL-408B-0-00WW-B03-system.img  2>>log.txt ";
            p48.StartInfo.CreateNoWindow = true;
            p48.Start();
            richTextBox1.Text = richTextBox1.Text + p48.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p48.WaitForExit();

            Process p49 = new Process();
            p49.StartInfo.UseShellExecute = false;
            p49.StartInfo.RedirectStandardOutput = true;
            p49.StartInfo.FileName = "cmd.exe";
            p49.StartInfo.Arguments = "/c echo Flashing systeminfo_a.. ";
            p49.StartInfo.CreateNoWindow = true;
            p49.Start();
            richTextBox1.Text = richTextBox1.Text + p49.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p49.WaitForExit();

            Process p50 = new Process();
            p50.StartInfo.UseShellExecute = false;
            p50.StartInfo.RedirectStandardOutput = true;
            p50.StartInfo.FileName = "cmd.exe";
            p50.StartInfo.Arguments = "/c fastboot flash systeminfo_a CTL-408B-0-00WW-B03-systeminfo.img  2>>log.txt";
            p50.StartInfo.CreateNoWindow = true;
            p50.Start();
            richTextBox1.Text = richTextBox1.Text + p50.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p50.WaitForExit();

            Process p51 = new Process();
            p51.StartInfo.UseShellExecute = false;
            p51.StartInfo.RedirectStandardOutput = true;
            p51.StartInfo.FileName = "cmd.exe";
            p51.StartInfo.Arguments = "/c echo Flshing tz_a.";
            p51.StartInfo.CreateNoWindow = true;
            p51.Start();
            richTextBox1.Text = richTextBox1.Text + p51.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p51.WaitForExit();

            Process p52 = new Process();
            p52.StartInfo.UseShellExecute = false;
            p52.StartInfo.RedirectStandardOutput = true;
            p52.StartInfo.FileName = "cmd.exe";
            p52.StartInfo.Arguments = "/c fastboot flash tz_a CTL-408B-0-00WW-B03-tz.img  2>>log.txt";
            p52.StartInfo.CreateNoWindow = true;
            p52.Start();
            richTextBox1.Text = richTextBox1.Text + p52.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p52.WaitForExit();

            Process p53 = new Process();
            p53.StartInfo.UseShellExecute = false;
            p53.StartInfo.RedirectStandardOutput = true;
            p53.StartInfo.FileName = "cmd.exe";
            p53.StartInfo.Arguments = "/c echo Flashing vendor_a.. ";
            p53.StartInfo.CreateNoWindow = true;
            p53.Start();
            richTextBox1.Text = richTextBox1.Text + p53.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p53.WaitForExit();

            Process p54 = new Process();
            p54.StartInfo.UseShellExecute = false;
            p54.StartInfo.RedirectStandardOutput = true;
            p54.StartInfo.FileName = "cmd.exe";
            p54.StartInfo.Arguments = "/c fastboot flash vendor_a CTL-408B-0-00WW-B03-vendor.img  2>>log.txt ";
            p54.StartInfo.CreateNoWindow = true;
            p54.Start();
            richTextBox1.Text = richTextBox1.Text + p54.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p54.WaitForExit();

            Process p55 = new Process();
            p55.StartInfo.UseShellExecute = false;
            p55.StartInfo.RedirectStandardOutput = true;
            p55.StartInfo.FileName = "cmd.exe";
            p55.StartInfo.Arguments = "/c echo Erase ssd..";
            p55.StartInfo.CreateNoWindow = true;
            p55.Start();
            richTextBox1.Text = richTextBox1.Text + p55.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p55.WaitForExit();

            Process p56 = new Process();
            p56.StartInfo.UseShellExecute = false;
            p56.StartInfo.RedirectStandardOutput = true;
            p56.StartInfo.FileName = "cmd.exe";
            p56.StartInfo.Arguments = "/c fastboot erase ssd ";
            p56.StartInfo.CreateNoWindow = true;
            p56.Start();
            richTextBox1.Text = richTextBox1.Text + p56.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p56.WaitForExit();

            Process p57 = new Process();
            p57.StartInfo.UseShellExecute = false;
            p57.StartInfo.RedirectStandardOutput = true;
            p57.StartInfo.FileName = "cmd.exe";
            p57.StartInfo.Arguments = "/c echo Erase misc.. ";
            p57.StartInfo.CreateNoWindow = true;
            p57.Start();
            richTextBox1.Text = richTextBox1.Text + p57.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p57.WaitForExit();

            Process p58 = new Process();
            p58.StartInfo.UseShellExecute = false;
            p58.StartInfo.RedirectStandardOutput = true;
            p58.StartInfo.FileName = "cmd.exe";
            p58.StartInfo.Arguments = "/c fastboot erase misc ";
            p58.StartInfo.CreateNoWindow = true;
            p58.Start();
            richTextBox1.Text = richTextBox1.Text + p58.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p58.WaitForExit();

            Process p59 = new Process();
            p59.StartInfo.UseShellExecute = false;
            p59.StartInfo.RedirectStandardOutput = true;
            p59.StartInfo.FileName = "cmd.exe";
            p59.StartInfo.Arguments = "/c echo Erase sti.. ";
            p59.StartInfo.CreateNoWindow = true;
            p59.Start();
            richTextBox1.Text = richTextBox1.Text + p59.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p59.WaitForExit();

            Process p60 = new Process();
            p60.StartInfo.UseShellExecute = false;
            p60.StartInfo.RedirectStandardOutput = true;
            p60.StartInfo.FileName = "cmd.exe";
            p60.StartInfo.Arguments = "/c fastboot erase sti ";
            p60.StartInfo.CreateNoWindow = true;
            p60.Start();
            richTextBox1.Text = richTextBox1.Text + p60.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p60.WaitForExit();

            Process p61 = new Process();
            p61.StartInfo.UseShellExecute = false;
            p61.StartInfo.RedirectStandardOutput = true;
            p61.StartInfo.FileName = "cmd.exe";
            p61.StartInfo.Arguments = "/c echo Erase ddr.. ";
            p61.StartInfo.CreateNoWindow = true;
            p61.Start();
            richTextBox1.Text = richTextBox1.Text + p61.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p61.WaitForExit();

            Process p62 = new Process();
            p62.StartInfo.UseShellExecute = false;
            p62.StartInfo.RedirectStandardOutput = true;
            p62.StartInfo.FileName = "cmd.exe";
            p62.StartInfo.Arguments = "/c fastboot erase ddr ";
            p62.StartInfo.CreateNoWindow = true;
            p62.Start();
            richTextBox1.Text = richTextBox1.Text + p62.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p62.WaitForExit();

            Process p63 = new Process();
            p63.StartInfo.UseShellExecute = false;
            p63.StartInfo.RedirectStandardOutput = true;
            p63.StartInfo.FileName = "cmd.exe";
            p63.StartInfo.Arguments = "/c echo Erase securefs.. ";
            p63.StartInfo.CreateNoWindow = true;
            p63.Start();
            richTextBox1.Text = richTextBox1.Text + p63.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p63.WaitForExit();

            Process p64 = new Process();
            p64.StartInfo.UseShellExecute = false;
            p64.StartInfo.RedirectStandardOutput = true;
            p64.StartInfo.FileName = "cmd.exe";
            p64.StartInfo.Arguments = "/c fastboot erase securefs ";
            p64.StartInfo.CreateNoWindow = true;
            p64.Start();
            richTextBox1.Text = richTextBox1.Text + p64.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p64.WaitForExit();

            Process p65 = new Process();
            p65.StartInfo.UseShellExecute = false;
            p65.StartInfo.RedirectStandardOutput = true;
            p65.StartInfo.FileName = "cmd.exe";
            p65.StartInfo.Arguments = "/c echo Erase box.. ";
            p65.StartInfo.CreateNoWindow = true;
            p65.Start();
            richTextBox1.Text = richTextBox1.Text + p65.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p65.WaitForExit();

            Process p66 = new Process();
            p66.StartInfo.UseShellExecute = false;
            p66.StartInfo.RedirectStandardOutput = true;
            p66.StartInfo.FileName = "cmd.exe";
            p66.StartInfo.Arguments = "/c fastboot erase box ";
            p66.StartInfo.CreateNoWindow = true;
            p66.Start();
            richTextBox1.Text = richTextBox1.Text + p66.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p66.WaitForExit();

            Process p67 = new Process();
            p67.StartInfo.UseShellExecute = false;
            p67.StartInfo.RedirectStandardOutput = true;
            p67.StartInfo.FileName = "cmd.exe";
            p67.StartInfo.Arguments = "/c echo Erase boot_b.. ";
            p67.StartInfo.CreateNoWindow = true;
            p67.Start();
            richTextBox1.Text = richTextBox1.Text + p67.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p67.WaitForExit();

            Process p68 = new Process();
            p68.StartInfo.UseShellExecute = false;
            p68.StartInfo.RedirectStandardOutput = true;
            p68.StartInfo.FileName = "cmd.exe";
            p68.StartInfo.Arguments = "/c fastboot erase boot_b ";
            p68.StartInfo.CreateNoWindow = true;
            p68.Start();
            richTextBox1.Text = richTextBox1.Text + p68.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p68.WaitForExit();

            Process p69 = new Process();
            p69.StartInfo.UseShellExecute = false;
            p69.StartInfo.RedirectStandardOutput = true;
            p69.StartInfo.FileName = "cmd.exe";
            p69.StartInfo.Arguments = "/c echo set active slot A.. ";
            p69.StartInfo.CreateNoWindow = true;
            p69.Start();
            richTextBox1.Text = richTextBox1.Text + p69.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p69.WaitForExit();

            Process p70 = new Process();
            p70.StartInfo.UseShellExecute = false;
            p70.StartInfo.RedirectStandardOutput = true;
            p70.StartInfo.FileName = "cmd.exe";
            p70.StartInfo.Arguments = "/c fastboot --set-active=a ";
            p70.StartInfo.CreateNoWindow = true;
            p70.Start();
            richTextBox1.Text = richTextBox1.Text + p70.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p70.WaitForExit();

            Process p71 = new Process();
            p71.StartInfo.UseShellExecute = false;
            p71.StartInfo.RedirectStandardOutput = true;
            p71.StartInfo.FileName = "cmd.exe";
            p71.StartInfo.Arguments = "/c echo Erase Userdata.. ";
            p71.StartInfo.CreateNoWindow = true;
            p71.Start();
            richTextBox1.Text = richTextBox1.Text + p71.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p71.WaitForExit();

            Process p72 = new Process();
            p72.StartInfo.UseShellExecute = false;
            p72.StartInfo.RedirectStandardOutput = true;
            p72.StartInfo.FileName = "cmd.exe";
            p72.StartInfo.Arguments = "/c fastboot -w ";
            p72.StartInfo.CreateNoWindow = true;
            p72.Start();
            richTextBox1.Refresh();

            Process p73 = new Process();
            p73.StartInfo.UseShellExecute = false;
            p73.StartInfo.RedirectStandardOutput = true;
            p73.StartInfo.FileName = "cmd.exe";
            p73.StartInfo.Arguments = "/c echo Rebooting system.. ";
            p73.StartInfo.CreateNoWindow = true;
            p73.Start();
            richTextBox1.Text = richTextBox1.Text + p73.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p73.WaitForExit();

            Process p74 = new Process();
            p74.StartInfo.UseShellExecute = false;
            p74.StartInfo.RedirectStandardOutput = true;
            p74.StartInfo.FileName = "cmd.exe";
            p74.StartInfo.Arguments = "/c fastboot reboot ";
            p74.StartInfo.CreateNoWindow = true;
            p74.Start();
            richTextBox1.Text = richTextBox1.Text + p74.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p74.WaitForExit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Process p1 = new Process();
            p1.StartInfo.UseShellExecute = false;
            p1.StartInfo.RedirectStandardOutput = true;
            p1.StartInfo.FileName = "cmd.exe";
            p1.StartInfo.Arguments = "/c echo getversions..";
            p1.StartInfo.CreateNoWindow = true;
            p1.Start();
            richTextBox1.Text = richTextBox1.Text + p1.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p1.WaitForExit();


            Process p2 = new Process();
            p2.StartInfo.UseShellExecute = false;
            p2.StartInfo.RedirectStandardOutput = true;
            p2.StartInfo.FileName = "cmd.exe";
            p2.StartInfo.Arguments = "/c fastboot oem getversions 2>getver.txt & type getver.txt ";
            p2.StartInfo.CreateNoWindow = true;
            p2.Start();
            richTextBox1.Text = richTextBox1.Text + p2.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p2.WaitForExit();

            Process p3 = new Process();
            p3.StartInfo.UseShellExecute = false;
            p3.StartInfo.RedirectStandardOutput = true;
            p3.StartInfo.FileName = "cmd.exe";
            p3.StartInfo.Arguments = "/c echo device-info..";
            p3.StartInfo.CreateNoWindow = true;
            p3.Start();
            richTextBox1.Text = richTextBox1.Text + p3.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p3.WaitForExit();


            Process p4 = new Process();
            p4.StartInfo.UseShellExecute = false;
            p4.StartInfo.RedirectStandardOutput = true;
            p4.StartInfo.FileName = "cmd.exe";
            p4.StartInfo.Arguments = "/c fastboot oem device-info 2>device.txt & type device.txt  ";
            p4.StartInfo.CreateNoWindow = true;
            p4.Start();
            richTextBox1.Text = richTextBox1.Text + p4.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p4.WaitForExit();

            Process p5 = new Process();
            p5.StartInfo.UseShellExecute = false;
            p5.StartInfo.RedirectStandardOutput = true;
            p5.StartInfo.FileName = "cmd.exe";
            p5.StartInfo.Arguments = "/c echo Flashing abl_a..";
            p5.StartInfo.CreateNoWindow = true;
            p5.Start();
            richTextBox1.Text = richTextBox1.Text + p5.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p5.WaitForExit();


            Process p6 = new Process();
            p6.StartInfo.UseShellExecute = false;
            p6.StartInfo.RedirectStandardOutput = true;
            p6.StartInfo.FileName = "cmd.exe";
            p6.StartInfo.Arguments = "/c fastboot flash abl_a CTL-354H-0-00WW-B01-abl.img  2>>log.txt  ";
            p6.StartInfo.CreateNoWindow = true;
            p6.Start();
            richTextBox1.Text = richTextBox1.Text + p6.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p6.WaitForExit();

            Process p7 = new Process();
            p7.StartInfo.UseShellExecute = false;
            p7.StartInfo.RedirectStandardOutput = true;
            p7.StartInfo.FileName = "cmd.exe";
            p7.StartInfo.Arguments = "/c echo Flashing abl_b..";
            p7.StartInfo.CreateNoWindow = true;
            p7.Start();
            richTextBox1.Text = richTextBox1.Text + p7.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p7.WaitForExit();

            Process p8 = new Process();
            p8.StartInfo.UseShellExecute = false;
            p8.StartInfo.RedirectStandardOutput = true;
            p8.StartInfo.FileName = "cmd.exe";
            p8.StartInfo.Arguments = "/c fastboot flash abl_b CTL-354H-0-00WW-B01-abl.img  2>>log.txt ";
            p8.StartInfo.CreateNoWindow = true;
            p8.Start();
            richTextBox1.Text = richTextBox1.Text + p8.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p8.WaitForExit();

            Process p9 = new Process();
            p9.StartInfo.UseShellExecute = false;
            p9.StartInfo.RedirectStandardOutput = true;
            p9.StartInfo.FileName = "cmd.exe";
            p9.StartInfo.Arguments = "/c echo FLashing xbl_a..";
            p9.StartInfo.CreateNoWindow = true;
            p9.Start();
            richTextBox1.Text = richTextBox1.Text + p9.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p9.WaitForExit();

            Process p10 = new Process();
            p10.StartInfo.UseShellExecute = false;
            p10.StartInfo.RedirectStandardOutput = true;
            p10.StartInfo.FileName = "cmd.exe";
            p10.StartInfo.Arguments = "/c fastboot flash xbl_a CTL-354H-0-00WW-B01-xbl.img  2>>log.txt ";
            p10.StartInfo.CreateNoWindow = true;
            p10.Start();
            richTextBox1.Text = richTextBox1.Text + p10.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p10.WaitForExit();

            Process p11 = new Process();
            p11.StartInfo.UseShellExecute = false;
            p11.StartInfo.RedirectStandardOutput = true;
            p11.StartInfo.FileName = "cmd.exe";
            p11.StartInfo.Arguments = "/c echo Flashing xbl_b.. ";
            p11.StartInfo.CreateNoWindow = true;
            p11.Start();
            richTextBox1.Text = richTextBox1.Text + p11.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p11.WaitForExit();

            Process p12 = new Process();
            p12.StartInfo.UseShellExecute = false;
            p12.StartInfo.RedirectStandardOutput = true;
            p12.StartInfo.FileName = "cmd.exe";
            p12.StartInfo.Arguments = "/c fastboot flash xbl_b CTL-354H-0-00WW-B01-xbl.img  2>>log.txt ";
            p12.StartInfo.CreateNoWindow = true;
            p12.Start();
            richTextBox1.Text = richTextBox1.Text + p12.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p12.WaitForExit();

            Process p13 = new Process();
            p13.StartInfo.UseShellExecute = false;
            p13.StartInfo.RedirectStandardOutput = true;
            p13.StartInfo.FileName = "cmd.exe";
            p13.StartInfo.Arguments = "/c echo Flashing bluetooth_a.. ";
            p13.StartInfo.CreateNoWindow = true;
            p13.Start();
            richTextBox1.Text = richTextBox1.Text + p13.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p13.WaitForExit();

            Process p14 = new Process();
            p14.StartInfo.UseShellExecute = false;
            p14.StartInfo.RedirectStandardOutput = true;
            p14.StartInfo.FileName = "cmd.exe";
            p14.StartInfo.Arguments = "/c fastboot flash bluetooth_a CTL-354H-0-00WW-B01-bluetooth.img  2>>log.txt ";
            p14.StartInfo.CreateNoWindow = true;
            p14.Start();
            richTextBox1.Text = richTextBox1.Text + p14.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p14.WaitForExit();

            Process p15 = new Process();
            p15.StartInfo.UseShellExecute = false;
            p15.StartInfo.RedirectStandardOutput = true;
            p15.StartInfo.FileName = "cmd.exe";
            p15.StartInfo.Arguments = "/c echo Flashing boot_a.. ";
            p15.StartInfo.CreateNoWindow = true;
            p15.Start();
            richTextBox1.Text = richTextBox1.Text + p15.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p15.WaitForExit();

            Process p16 = new Process();
            p16.StartInfo.UseShellExecute = false;
            p16.StartInfo.RedirectStandardOutput = true;
            p16.StartInfo.FileName = "cmd.exe";
            p16.StartInfo.Arguments = "/c fastboot flash boot_a CTL-354H-0-00WW-B01-boot.img  2>>log.txt ";
            p16.StartInfo.CreateNoWindow = true;
            p16.Start();
            richTextBox1.Text = richTextBox1.Text + p16.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p16.WaitForExit();

            Process p17 = new Process();
            p17.StartInfo.UseShellExecute = false;
            p17.StartInfo.RedirectStandardOutput = true;
            p17.StartInfo.FileName = "cmd.exe";
            p17.StartInfo.Arguments = "/c echo Flashing cda_a.. ";
            p17.StartInfo.CreateNoWindow = true;
            p17.Start();
            richTextBox1.Text = richTextBox1.Text + p17.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p17.WaitForExit();

            Process p18 = new Process();
            p18.StartInfo.UseShellExecute = false;
            p18.StartInfo.RedirectStandardOutput = true;
            p18.StartInfo.FileName = "cmd.exe";
            p18.StartInfo.Arguments = "/c fastboot flash cda_a CTL-354H-0-00WW-B01-cda.img  2>>log.txt ";
            p18.StartInfo.CreateNoWindow = true;
            p18.Start();
            richTextBox1.Text = richTextBox1.Text + p18.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p18.WaitForExit();

            Process p19 = new Process();
            p19.StartInfo.UseShellExecute = false;
            p19.StartInfo.RedirectStandardOutput = true;
            p19.StartInfo.FileName = "cmd.exe";
            p19.StartInfo.Arguments = "/c echo Flashing cmnlib_a.. ";
            p19.StartInfo.CreateNoWindow = true;
            p19.Start();
            richTextBox1.Text = richTextBox1.Text + p19.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p19.WaitForExit();

            Process p20 = new Process();
            p20.StartInfo.UseShellExecute = false;
            p20.StartInfo.RedirectStandardOutput = true;
            p20.StartInfo.FileName = "cmd.exe";
            p20.StartInfo.Arguments = "/c fastboot flash cmnlib_a CTL-354H-0-00WW-B01-cmnlib.img  2>>log.txt ";
            p20.StartInfo.CreateNoWindow = true;
            p20.Start();
            richTextBox1.Text = richTextBox1.Text + p20.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p20.WaitForExit();

            Process p21 = new Process();
            p21.StartInfo.UseShellExecute = false;
            p21.StartInfo.RedirectStandardOutput = true;
            p21.StartInfo.FileName = "cmd.exe";
            p21.StartInfo.Arguments = "/c echo Flashing cmnlib64_a.. ";
            p21.StartInfo.CreateNoWindow = true;
            p21.Start();
            richTextBox1.Text = richTextBox1.Text + p21.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p21.WaitForExit();

            Process p22 = new Process();
            p22.StartInfo.UseShellExecute = false;
            p22.StartInfo.RedirectStandardOutput = true;
            p22.StartInfo.FileName = "cmd.exe";
            p22.StartInfo.Arguments = "/c fastboot flash cmnlib64_a CTL-354H-0-00WW-B01-cmnlib64.img  2>>log.txt ";
            p22.StartInfo.CreateNoWindow = true;
            p22.Start();
            richTextBox1.Text = richTextBox1.Text + p22.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p22.WaitForExit();

            Process p23 = new Process();
            p23.StartInfo.UseShellExecute = false;
            p23.StartInfo.RedirectStandardOutput = true;
            p23.StartInfo.FileName = "cmd.exe";
            p23.StartInfo.Arguments = "/c echo Flashing devcfg_a.. ";
            p23.StartInfo.CreateNoWindow = true;
            p23.Start();
            richTextBox1.Text = richTextBox1.Text + p23.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p23.WaitForExit();

            Process p24 = new Process();
            p24.StartInfo.UseShellExecute = false;
            p24.StartInfo.RedirectStandardOutput = true;
            p24.StartInfo.FileName = "cmd.exe";
            p24.StartInfo.Arguments = "/c fastboot flash devcfg_a CTL-354H-0-00WW-B01-devcfg.img  2>>log.txt ";
            p24.StartInfo.CreateNoWindow = true;
            p24.Start();
            richTextBox1.Text = richTextBox1.Text + p24.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p24.WaitForExit();

            Process p25 = new Process();
            p25.StartInfo.UseShellExecute = false;
            p25.StartInfo.RedirectStandardOutput = true;
            p25.StartInfo.FileName = "cmd.exe";
            p25.StartInfo.Arguments = "/c echo Flashing dsp_a.. ";
            p25.StartInfo.CreateNoWindow = true;
            p25.Start();
            richTextBox1.Text = richTextBox1.Text + p25.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p25.WaitForExit();

            Process p26 = new Process();
            p26.StartInfo.UseShellExecute = false;
            p26.StartInfo.RedirectStandardOutput = true;
            p26.StartInfo.FileName = "cmd.exe";
            p26.StartInfo.Arguments = "/c fastboot flash dsp_a CTL-354H-0-00WW-B01-dsp.img  2>>log.txt ";
            p26.StartInfo.CreateNoWindow = true;
            p26.Start();
            richTextBox1.Text = richTextBox1.Text + p26.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p26.WaitForExit();

            Process p27 = new Process();
            p27.StartInfo.UseShellExecute = false;
            p27.StartInfo.RedirectStandardOutput = true;
            p27.StartInfo.FileName = "cmd.exe";
            p27.StartInfo.Arguments = "/c echo Flashing hidden_a.. ";
            p27.StartInfo.CreateNoWindow = true;
            p27.Start();
            richTextBox1.Text = richTextBox1.Text + p27.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p27.WaitForExit();

            Process p28 = new Process();
            p28.StartInfo.UseShellExecute = false;
            p28.StartInfo.RedirectStandardOutput = true;
            p28.StartInfo.FileName = "cmd.exe";
            p28.StartInfo.Arguments = "/c fastboot flash hidden_a CTL-354H-0-00WW-B01-hidden.img  2>>log.txt ";
            p28.StartInfo.CreateNoWindow = true;
            p28.Start();
            richTextBox1.Text = richTextBox1.Text + p28.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p28.WaitForExit();

            Process p29 = new Process();
            p29.StartInfo.UseShellExecute = false;
            p29.StartInfo.RedirectStandardOutput = true;
            p29.StartInfo.FileName = "cmd.exe";
            p29.StartInfo.Arguments = "/c echo Flashing hyp_a.. ";
            p29.StartInfo.CreateNoWindow = true;
            p29.Start();
            richTextBox1.Text = richTextBox1.Text + p29.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p29.WaitForExit();

            Process p30 = new Process();
            p30.StartInfo.UseShellExecute = false;
            p30.StartInfo.RedirectStandardOutput = true;
            p30.StartInfo.FileName = "cmd.exe";
            p30.StartInfo.Arguments = "/c fastboot flash hyp_a CTL-354H-0-00WW-B01-hyp.img  2>>log.txt ";
            p30.StartInfo.CreateNoWindow = true;
            p30.Start();
            richTextBox1.Text = richTextBox1.Text + p30.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p30.WaitForExit();

            Process p31 = new Process();
            p31.StartInfo.UseShellExecute = false;
            p31.StartInfo.RedirectStandardOutput = true;
            p31.StartInfo.FileName = "cmd.exe";
            p31.StartInfo.Arguments = "/c echo flashing keymaster_a.. ";
            p31.StartInfo.CreateNoWindow = true;
            p31.Start();
            richTextBox1.Text = richTextBox1.Text + p31.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p31.WaitForExit();

            Process p32 = new Process();
            p32.StartInfo.UseShellExecute = false;
            p32.StartInfo.RedirectStandardOutput = true;
            p32.StartInfo.FileName = "cmd.exe";
            p32.StartInfo.Arguments = "/c fastboot flash keymaster_a CTL-354H-0-00WW-B01-keymaster.img  2>>log.txt ";
            p32.StartInfo.CreateNoWindow = true;
            p32.Start();
            richTextBox1.Text = richTextBox1.Text + p32.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p32.WaitForExit();

            Process p33 = new Process();
            p33.StartInfo.UseShellExecute = false;
            p33.StartInfo.RedirectStandardOutput = true;
            p33.StartInfo.FileName = "cmd.exe";
            p33.StartInfo.Arguments = "/c echo Flashing mdtp_a.. ";
            p33.StartInfo.CreateNoWindow = true;
            p33.Start();
            richTextBox1.Text = richTextBox1.Text + p33.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p33.WaitForExit();

            Process p34 = new Process();
            p34.StartInfo.UseShellExecute = false;
            p34.StartInfo.RedirectStandardOutput = true;
            p34.StartInfo.FileName = "cmd.exe";
            p34.StartInfo.Arguments = "/c fastboot flash mdtp_a CTL-354H-0-00WW-B01-mdtp.img  2>>log.txt ";
            p34.StartInfo.CreateNoWindow = true;
            p34.Start();
            richTextBox1.Text = richTextBox1.Text + p34.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p34.WaitForExit();

            Process p35 = new Process();
            p35.StartInfo.UseShellExecute = false;
            p35.StartInfo.RedirectStandardOutput = true;
            p35.StartInfo.FileName = "cmd.exe";
            p35.StartInfo.Arguments = "/c echo Flashing mdtpsecapp_a.. ";
            p35.StartInfo.CreateNoWindow = true;
            p35.Start();
            richTextBox1.Text = richTextBox1.Text + p35.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p35.WaitForExit();

            Process p36 = new Process();
            p36.StartInfo.UseShellExecute = false;
            p36.StartInfo.RedirectStandardOutput = true;
            p36.StartInfo.FileName = "cmd.exe";
            p36.StartInfo.Arguments = "/c fastboot flash mdtpsecapp_a CTL-354H-0-00WW-B01-mdtpsecapp.img  2>>log.txt ";
            p36.StartInfo.CreateNoWindow = true;
            p36.Start();
            richTextBox1.Text = richTextBox1.Text + p36.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p36.WaitForExit();

            Process p37 = new Process();
            p37.StartInfo.UseShellExecute = false;
            p37.StartInfo.RedirectStandardOutput = true;
            p37.StartInfo.FileName = "cmd.exe";
            p37.StartInfo.Arguments = "/c echo Flashing modem_a.. ";
            p37.StartInfo.CreateNoWindow = true;
            p37.Start();
            richTextBox1.Text = richTextBox1.Text + p37.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p37.WaitForExit();

            Process p38 = new Process();
            p38.StartInfo.UseShellExecute = false;
            p38.StartInfo.RedirectStandardOutput = true;
            p38.StartInfo.FileName = "cmd.exe";
            p38.StartInfo.Arguments = "/c fastboot flash modem_a CTL-354H-0-00WW-B01-modem.img  2>>log.txt ";
            p38.StartInfo.CreateNoWindow = true;
            p38.Start();
            richTextBox1.Text = richTextBox1.Text + p38.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p38.WaitForExit();

            Process p39 = new Process();
            p39.StartInfo.UseShellExecute = false;
            p39.StartInfo.RedirectStandardOutput = true;
            p39.StartInfo.FileName = "cmd.exe";
            p39.StartInfo.Arguments = "/c echo Flashing nvdef_a.. ";
            p39.StartInfo.CreateNoWindow = true;
            p39.Start();
            richTextBox1.Text = richTextBox1.Text + p39.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p39.WaitForExit();

            Process p40 = new Process();
            p40.StartInfo.UseShellExecute = false;
            p40.StartInfo.RedirectStandardOutput = true;
            p40.StartInfo.FileName = "cmd.exe";
            p40.StartInfo.Arguments = "/c fastboot flash nvdef_a CTL-354H-0-00WW-B01-nvdef.img  2>>log.txt ";
            p40.StartInfo.CreateNoWindow = true;
            p40.Start();
            richTextBox1.Text = richTextBox1.Text + p40.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p40.WaitForExit();

            Process p41 = new Process();
            p41.StartInfo.UseShellExecute = false;
            p41.StartInfo.RedirectStandardOutput = true;
            p41.StartInfo.FileName = "cmd.exe";
            p41.StartInfo.Arguments = "/c echo Flashing pmic_a.. ";
            p41.StartInfo.CreateNoWindow = true;
            p41.Start();
            richTextBox1.Text = richTextBox1.Text + p41.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p41.WaitForExit();

            Process p42 = new Process();
            p42.StartInfo.UseShellExecute = false;
            p42.StartInfo.RedirectStandardOutput = true;
            p42.StartInfo.FileName = "cmd.exe";
            p42.StartInfo.Arguments = "/c fastboot flash pmic_a CTL-354H-0-00WW-B01-pmic.img  2>>log.txt";
            p42.StartInfo.CreateNoWindow = true;
            p42.Start();
            richTextBox1.Text = richTextBox1.Text + p42.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p42.WaitForExit();

            Process p43 = new Process();
            p43.StartInfo.UseShellExecute = false;
            p43.StartInfo.RedirectStandardOutput = true;
            p43.StartInfo.FileName = "cmd.exe";
            p43.StartInfo.Arguments = "/c echo FLashing rpm_a.. ";
            p43.StartInfo.CreateNoWindow = true;
            p43.Start();
            richTextBox1.Text = richTextBox1.Text + p43.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p43.WaitForExit();

            Process p44 = new Process();
            p44.StartInfo.UseShellExecute = false;
            p44.StartInfo.RedirectStandardOutput = true;
            p44.StartInfo.FileName = "cmd.exe";
            p44.StartInfo.Arguments = "/c fastboot flash rpm_a CTL-354H-0-00WW-B01-rpm.img  2>>log.txt ";
            p44.StartInfo.CreateNoWindow = true;
            p44.Start();
            richTextBox1.Text = richTextBox1.Text + p44.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p44.WaitForExit();

            Process p45 = new Process();
            p45.StartInfo.UseShellExecute = false;
            p45.StartInfo.RedirectStandardOutput = true;
            p45.StartInfo.FileName = "cmd.exe";
            p45.StartInfo.Arguments = "/c echo Flashing splash_a.. ";
            p45.StartInfo.CreateNoWindow = true;
            p45.Start();
            richTextBox1.Text = richTextBox1.Text + p45.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p45.WaitForExit();

            Process p46 = new Process();
            p46.StartInfo.UseShellExecute = false;
            p46.StartInfo.RedirectStandardOutput = true;
            p46.StartInfo.FileName = "cmd.exe";
            p46.StartInfo.Arguments = "/c fastboot flash splash_a CTL-354H-0-00WW-B01-splash.img  2>>log.txt ";
            p46.StartInfo.CreateNoWindow = true;
            p46.Start();
            richTextBox1.Text = richTextBox1.Text + p46.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p46.WaitForExit();

            Process p47 = new Process();
            p47.StartInfo.UseShellExecute = false;
            p47.StartInfo.RedirectStandardOutput = true;
            p47.StartInfo.FileName = "cmd.exe";
            p47.StartInfo.Arguments = "/c echo Flashing system_a.. ";
            p47.StartInfo.CreateNoWindow = true;
            p47.Start();
            richTextBox1.Text = richTextBox1.Text + p47.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p47.WaitForExit();

            Process p48 = new Process();
            p48.StartInfo.UseShellExecute = false;
            p48.StartInfo.RedirectStandardOutput = true;
            p48.StartInfo.FileName = "cmd.exe";
            p48.StartInfo.Arguments = "/c fastboot flash system_a CTL-354H-0-00WW-B01-system.img  2>>log.txt ";
            p48.StartInfo.CreateNoWindow = true;
            p48.Start();
            richTextBox1.Text = richTextBox1.Text + p48.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p48.WaitForExit();

            Process p49 = new Process();
            p49.StartInfo.UseShellExecute = false;
            p49.StartInfo.RedirectStandardOutput = true;
            p49.StartInfo.FileName = "cmd.exe";
            p49.StartInfo.Arguments = "/c echo Flashing systeminfo_a.. ";
            p49.StartInfo.CreateNoWindow = true;
            p49.Start();
            richTextBox1.Text = richTextBox1.Text + p49.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p49.WaitForExit();

            Process p50 = new Process();
            p50.StartInfo.UseShellExecute = false;
            p50.StartInfo.RedirectStandardOutput = true;
            p50.StartInfo.FileName = "cmd.exe";
            p50.StartInfo.Arguments = "/c fastboot flash systeminfo_a CTL-354H-0-00WW-B01-systeminfo.img  2>>log.txt";
            p50.StartInfo.CreateNoWindow = true;
            p50.Start();
            richTextBox1.Text = richTextBox1.Text + p50.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p50.WaitForExit();

            Process p51 = new Process();
            p51.StartInfo.UseShellExecute = false;
            p51.StartInfo.RedirectStandardOutput = true;
            p51.StartInfo.FileName = "cmd.exe";
            p51.StartInfo.Arguments = "/c echo Flshing tz_a.";
            p51.StartInfo.CreateNoWindow = true;
            p51.Start();
            richTextBox1.Text = richTextBox1.Text + p51.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p51.WaitForExit();

            Process p52 = new Process();
            p52.StartInfo.UseShellExecute = false;
            p52.StartInfo.RedirectStandardOutput = true;
            p52.StartInfo.FileName = "cmd.exe";
            p52.StartInfo.Arguments = "/c fastboot flash tz_a CTL-354H-0-00WW-B01-tz.img  2>>log.txt";
            p52.StartInfo.CreateNoWindow = true;
            p52.Start();
            richTextBox1.Text = richTextBox1.Text + p52.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p52.WaitForExit();

            Process p53 = new Process();
            p53.StartInfo.UseShellExecute = false;
            p53.StartInfo.RedirectStandardOutput = true;
            p53.StartInfo.FileName = "cmd.exe";
            p53.StartInfo.Arguments = "/c echo Flashing vendor_a.. ";
            p53.StartInfo.CreateNoWindow = true;
            p53.Start();
            richTextBox1.Text = richTextBox1.Text + p53.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p53.WaitForExit();

            Process p54 = new Process();
            p54.StartInfo.UseShellExecute = false;
            p54.StartInfo.RedirectStandardOutput = true;
            p54.StartInfo.FileName = "cmd.exe";
            p54.StartInfo.Arguments = "/c fastboot flash vendor_a CTL-354H-0-00WW-B01-vendor.img  2>>log.txt ";
            p54.StartInfo.CreateNoWindow = true;
            p54.Start();
            richTextBox1.Text = richTextBox1.Text + p54.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p54.WaitForExit();

            Process p55 = new Process();
            p55.StartInfo.UseShellExecute = false;
            p55.StartInfo.RedirectStandardOutput = true;
            p55.StartInfo.FileName = "cmd.exe";
            p55.StartInfo.Arguments = "/c echo Erase ssd..";
            p55.StartInfo.CreateNoWindow = true;
            p55.Start();
            richTextBox1.Text = richTextBox1.Text + p55.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p55.WaitForExit();

            Process p56 = new Process();
            p56.StartInfo.UseShellExecute = false;
            p56.StartInfo.RedirectStandardOutput = true;
            p56.StartInfo.FileName = "cmd.exe";
            p56.StartInfo.Arguments = "/c fastboot erase ssd ";
            p56.StartInfo.CreateNoWindow = true;
            p56.Start();
            richTextBox1.Text = richTextBox1.Text + p56.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p56.WaitForExit();

            Process p57 = new Process();
            p57.StartInfo.UseShellExecute = false;
            p57.StartInfo.RedirectStandardOutput = true;
            p57.StartInfo.FileName = "cmd.exe";
            p57.StartInfo.Arguments = "/c echo Erase misc.. ";
            p57.StartInfo.CreateNoWindow = true;
            p57.Start();
            richTextBox1.Text = richTextBox1.Text + p57.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p57.WaitForExit();

            Process p58 = new Process();
            p58.StartInfo.UseShellExecute = false;
            p58.StartInfo.RedirectStandardOutput = true;
            p58.StartInfo.FileName = "cmd.exe";
            p58.StartInfo.Arguments = "/c fastboot erase misc ";
            p58.StartInfo.CreateNoWindow = true;
            p58.Start();
            richTextBox1.Text = richTextBox1.Text + p58.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p58.WaitForExit();

            Process p59 = new Process();
            p59.StartInfo.UseShellExecute = false;
            p59.StartInfo.RedirectStandardOutput = true;
            p59.StartInfo.FileName = "cmd.exe";
            p59.StartInfo.Arguments = "/c echo Erase sti.. ";
            p59.StartInfo.CreateNoWindow = true;
            p59.Start();
            richTextBox1.Text = richTextBox1.Text + p59.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p59.WaitForExit();

            Process p60 = new Process();
            p60.StartInfo.UseShellExecute = false;
            p60.StartInfo.RedirectStandardOutput = true;
            p60.StartInfo.FileName = "cmd.exe";
            p60.StartInfo.Arguments = "/c fastboot erase sti ";
            p60.StartInfo.CreateNoWindow = true;
            p60.Start();
            richTextBox1.Text = richTextBox1.Text + p60.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p60.WaitForExit();

            Process p61 = new Process();
            p61.StartInfo.UseShellExecute = false;
            p61.StartInfo.RedirectStandardOutput = true;
            p61.StartInfo.FileName = "cmd.exe";
            p61.StartInfo.Arguments = "/c echo Erase ddr.. ";
            p61.StartInfo.CreateNoWindow = true;
            p61.Start();
            richTextBox1.Text = richTextBox1.Text + p61.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p61.WaitForExit();

            Process p62 = new Process();
            p62.StartInfo.UseShellExecute = false;
            p62.StartInfo.RedirectStandardOutput = true;
            p62.StartInfo.FileName = "cmd.exe";
            p62.StartInfo.Arguments = "/c fastboot erase ddr ";
            p62.StartInfo.CreateNoWindow = true;
            p62.Start();
            richTextBox1.Text = richTextBox1.Text + p62.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p62.WaitForExit();

            Process p63 = new Process();
            p63.StartInfo.UseShellExecute = false;
            p63.StartInfo.RedirectStandardOutput = true;
            p63.StartInfo.FileName = "cmd.exe";
            p63.StartInfo.Arguments = "/c echo Erase securefs.. ";
            p63.StartInfo.CreateNoWindow = true;
            p63.Start();
            richTextBox1.Text = richTextBox1.Text + p63.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p63.WaitForExit();

            Process p64 = new Process();
            p64.StartInfo.UseShellExecute = false;
            p64.StartInfo.RedirectStandardOutput = true;
            p64.StartInfo.FileName = "cmd.exe";
            p64.StartInfo.Arguments = "/c fastboot erase securefs ";
            p64.StartInfo.CreateNoWindow = true;
            p64.Start();
            richTextBox1.Text = richTextBox1.Text + p64.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p64.WaitForExit();

            Process p65 = new Process();
            p65.StartInfo.UseShellExecute = false;
            p65.StartInfo.RedirectStandardOutput = true;
            p65.StartInfo.FileName = "cmd.exe";
            p65.StartInfo.Arguments = "/c echo Erase box.. ";
            p65.StartInfo.CreateNoWindow = true;
            p65.Start();
            richTextBox1.Text = richTextBox1.Text + p65.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p65.WaitForExit();

            Process p66 = new Process();
            p66.StartInfo.UseShellExecute = false;
            p66.StartInfo.RedirectStandardOutput = true;
            p66.StartInfo.FileName = "cmd.exe";
            p66.StartInfo.Arguments = "/c fastboot erase box ";
            p66.StartInfo.CreateNoWindow = true;
            p66.Start();
            richTextBox1.Text = richTextBox1.Text + p66.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p66.WaitForExit();

            Process p67 = new Process();
            p67.StartInfo.UseShellExecute = false;
            p67.StartInfo.RedirectStandardOutput = true;
            p67.StartInfo.FileName = "cmd.exe";
            p67.StartInfo.Arguments = "/c echo Erase boot_b.. ";
            p67.StartInfo.CreateNoWindow = true;
            p67.Start();
            richTextBox1.Text = richTextBox1.Text + p67.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p67.WaitForExit();

            Process p68 = new Process();
            p68.StartInfo.UseShellExecute = false;
            p68.StartInfo.RedirectStandardOutput = true;
            p68.StartInfo.FileName = "cmd.exe";
            p68.StartInfo.Arguments = "/c fastboot erase boot_b ";
            p68.StartInfo.CreateNoWindow = true;
            p68.Start();
            richTextBox1.Text = richTextBox1.Text + p68.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p68.WaitForExit();

            Process p69 = new Process();
            p69.StartInfo.UseShellExecute = false;
            p69.StartInfo.RedirectStandardOutput = true;
            p69.StartInfo.FileName = "cmd.exe";
            p69.StartInfo.Arguments = "/c echo set active slot A.. ";
            p69.StartInfo.CreateNoWindow = true;
            p69.Start();
            richTextBox1.Text = richTextBox1.Text + p69.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p69.WaitForExit();

            Process p70 = new Process();
            p70.StartInfo.UseShellExecute = false;
            p70.StartInfo.RedirectStandardOutput = true;
            p70.StartInfo.FileName = "cmd.exe";
            p70.StartInfo.Arguments = "/c fastboot --set-active=a ";
            p70.StartInfo.CreateNoWindow = true;
            p70.Start();
            richTextBox1.Text = richTextBox1.Text + p70.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p70.WaitForExit();

            Process p71 = new Process();
            p71.StartInfo.UseShellExecute = false;
            p71.StartInfo.RedirectStandardOutput = true;
            p71.StartInfo.FileName = "cmd.exe";
            p71.StartInfo.Arguments = "/c echo Erase Userdata.. ";
            p71.StartInfo.CreateNoWindow = true;
            p71.Start();
            richTextBox1.Text = richTextBox1.Text + p71.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p71.WaitForExit();

            Process p72 = new Process();
            p72.StartInfo.UseShellExecute = false;
            p72.StartInfo.RedirectStandardOutput = true;
            p72.StartInfo.FileName = "cmd.exe";
            p72.StartInfo.Arguments = "/c fastboot -w ";
            p72.StartInfo.CreateNoWindow = true;
            p72.Start();
            richTextBox1.Refresh();

            Process p73 = new Process();
            p73.StartInfo.UseShellExecute = false;
            p73.StartInfo.RedirectStandardOutput = true;
            p73.StartInfo.FileName = "cmd.exe";
            p73.StartInfo.Arguments = "/c echo Rebooting system.. ";
            p73.StartInfo.CreateNoWindow = true;
            p73.Start();
            richTextBox1.Text = richTextBox1.Text + p73.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p73.WaitForExit();

            Process p74 = new Process();
            p74.StartInfo.UseShellExecute = false;
            p74.StartInfo.RedirectStandardOutput = true;
            p74.StartInfo.FileName = "cmd.exe";
            p74.StartInfo.Arguments = "/c fastboot reboot ";
            p74.StartInfo.CreateNoWindow = true;
            p74.Start();
            richTextBox1.Text = richTextBox1.Text + p74.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p74.WaitForExit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Process p1 = new Process();
            p1.StartInfo.UseShellExecute = false;
            p1.StartInfo.RedirectStandardOutput = true;
            p1.StartInfo.FileName = "cmd.exe";
            p1.StartInfo.Arguments = "/c echo getversions..";
            p1.StartInfo.CreateNoWindow = true;
            p1.Start();
            richTextBox1.Text = richTextBox1.Text + p1.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p1.WaitForExit();


            Process p2 = new Process();
            p2.StartInfo.UseShellExecute = false;
            p2.StartInfo.RedirectStandardOutput = true;
            p2.StartInfo.FileName = "cmd.exe";
            p2.StartInfo.Arguments = "/c fastboot oem getversions 2>getver.txt & type getver.txt ";
            p2.StartInfo.CreateNoWindow = true;
            p2.Start();
            richTextBox1.Text = richTextBox1.Text + p2.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p2.WaitForExit();

            Process p3 = new Process();
            p3.StartInfo.UseShellExecute = false;
            p3.StartInfo.RedirectStandardOutput = true;
            p3.StartInfo.FileName = "cmd.exe";
            p3.StartInfo.Arguments = "/c echo device-info..";
            p3.StartInfo.CreateNoWindow = true;
            p3.Start();
            richTextBox1.Text = richTextBox1.Text + p3.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p3.WaitForExit();


            Process p4 = new Process();
            p4.StartInfo.UseShellExecute = false;
            p4.StartInfo.RedirectStandardOutput = true;
            p4.StartInfo.FileName = "cmd.exe";
            p4.StartInfo.Arguments = "/c fastboot oem device-info 2>device.txt & type device.txt  ";
            p4.StartInfo.CreateNoWindow = true;
            p4.Start();
            richTextBox1.Text = richTextBox1.Text + p4.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p4.WaitForExit();

            Process p5 = new Process();
            p5.StartInfo.UseShellExecute = false;
            p5.StartInfo.RedirectStandardOutput = true;
            p5.StartInfo.FileName = "cmd.exe";
            p5.StartInfo.Arguments = "/c echo Flashing abl_a..";
            p5.StartInfo.CreateNoWindow = true;
            p5.Start();
            richTextBox1.Text = richTextBox1.Text + p5.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p5.WaitForExit();


            Process p6 = new Process();
            p6.StartInfo.UseShellExecute = false;
            p6.StartInfo.RedirectStandardOutput = true;
            p6.StartInfo.FileName = "cmd.exe";
            p6.StartInfo.Arguments = "/c fastboot flash abl_a B2N-354H-0-00WW-B01-abl.img  2>>log.txt  ";
            p6.StartInfo.CreateNoWindow = true;
            p6.Start();
            richTextBox1.Text = richTextBox1.Text + p6.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p6.WaitForExit();

            Process p7 = new Process();
            p7.StartInfo.UseShellExecute = false;
            p7.StartInfo.RedirectStandardOutput = true;
            p7.StartInfo.FileName = "cmd.exe";
            p7.StartInfo.Arguments = "/c echo Flashing abl_b..";
            p7.StartInfo.CreateNoWindow = true;
            p7.Start();
            richTextBox1.Text = richTextBox1.Text + p7.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p7.WaitForExit();

            Process p8 = new Process();
            p8.StartInfo.UseShellExecute = false;
            p8.StartInfo.RedirectStandardOutput = true;
            p8.StartInfo.FileName = "cmd.exe";
            p8.StartInfo.Arguments = "/c fastboot flash abl_b B2N-354H-0-00WW-B01-abl.img  2>>log.txt ";
            p8.StartInfo.CreateNoWindow = true;
            p8.Start();
            richTextBox1.Text = richTextBox1.Text + p8.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p8.WaitForExit();

            Process p9 = new Process();
            p9.StartInfo.UseShellExecute = false;
            p9.StartInfo.RedirectStandardOutput = true;
            p9.StartInfo.FileName = "cmd.exe";
            p9.StartInfo.Arguments = "/c echo FLashing xbl_a..";
            p9.StartInfo.CreateNoWindow = true;
            p9.Start();
            richTextBox1.Text = richTextBox1.Text + p9.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p9.WaitForExit();

            Process p10 = new Process();
            p10.StartInfo.UseShellExecute = false;
            p10.StartInfo.RedirectStandardOutput = true;
            p10.StartInfo.FileName = "cmd.exe";
            p10.StartInfo.Arguments = "/c fastboot flash xbl_a B2N-354H-0-00WW-B01-xbl.img  2>>log.txt ";
            p10.StartInfo.CreateNoWindow = true;
            p10.Start();
            richTextBox1.Text = richTextBox1.Text + p10.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p10.WaitForExit();

            Process p11 = new Process();
            p11.StartInfo.UseShellExecute = false;
            p11.StartInfo.RedirectStandardOutput = true;
            p11.StartInfo.FileName = "cmd.exe";
            p11.StartInfo.Arguments = "/c echo Flashing xbl_b.. ";
            p11.StartInfo.CreateNoWindow = true;
            p11.Start();
            richTextBox1.Text = richTextBox1.Text + p11.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p11.WaitForExit();

            Process p12 = new Process();
            p12.StartInfo.UseShellExecute = false;
            p12.StartInfo.RedirectStandardOutput = true;
            p12.StartInfo.FileName = "cmd.exe";
            p12.StartInfo.Arguments = "/c fastboot flash xbl_b B2N-354H-0-00WW-B01-xbl.img  2>>log.txt ";
            p12.StartInfo.CreateNoWindow = true;
            p12.Start();
            richTextBox1.Text = richTextBox1.Text + p12.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p12.WaitForExit();

            Process p13 = new Process();
            p13.StartInfo.UseShellExecute = false;
            p13.StartInfo.RedirectStandardOutput = true;
            p13.StartInfo.FileName = "cmd.exe";
            p13.StartInfo.Arguments = "/c echo Flashing bluetooth_a.. ";
            p13.StartInfo.CreateNoWindow = true;
            p13.Start();
            richTextBox1.Text = richTextBox1.Text + p13.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p13.WaitForExit();

            Process p14 = new Process();
            p14.StartInfo.UseShellExecute = false;
            p14.StartInfo.RedirectStandardOutput = true;
            p14.StartInfo.FileName = "cmd.exe";
            p14.StartInfo.Arguments = "/c fastboot flash bluetooth_a B2N-354H-0-00WW-B01-bluetooth.img  2>>log.txt ";
            p14.StartInfo.CreateNoWindow = true;
            p14.Start();
            richTextBox1.Text = richTextBox1.Text + p14.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p14.WaitForExit();

            Process p15 = new Process();
            p15.StartInfo.UseShellExecute = false;
            p15.StartInfo.RedirectStandardOutput = true;
            p15.StartInfo.FileName = "cmd.exe";
            p15.StartInfo.Arguments = "/c echo Flashing boot_a.. ";
            p15.StartInfo.CreateNoWindow = true;
            p15.Start();
            richTextBox1.Text = richTextBox1.Text + p15.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p15.WaitForExit();

            Process p16 = new Process();
            p16.StartInfo.UseShellExecute = false;
            p16.StartInfo.RedirectStandardOutput = true;
            p16.StartInfo.FileName = "cmd.exe";
            p16.StartInfo.Arguments = "/c fastboot flash boot_a B2N-354H-0-00WW-B01-boot.img  2>>log.txt ";
            p16.StartInfo.CreateNoWindow = true;
            p16.Start();
            richTextBox1.Text = richTextBox1.Text + p16.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p16.WaitForExit();

            Process p17 = new Process();
            p17.StartInfo.UseShellExecute = false;
            p17.StartInfo.RedirectStandardOutput = true;
            p17.StartInfo.FileName = "cmd.exe";
            p17.StartInfo.Arguments = "/c echo Flashing cda_a.. ";
            p17.StartInfo.CreateNoWindow = true;
            p17.Start();
            richTextBox1.Text = richTextBox1.Text + p17.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p17.WaitForExit();

            Process p18 = new Process();
            p18.StartInfo.UseShellExecute = false;
            p18.StartInfo.RedirectStandardOutput = true;
            p18.StartInfo.FileName = "cmd.exe";
            p18.StartInfo.Arguments = "/c fastboot flash cda_a B2N-354H-0-00WW-B01-cda.img  2>>log.txt ";
            p18.StartInfo.CreateNoWindow = true;
            p18.Start();
            richTextBox1.Text = richTextBox1.Text + p18.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p18.WaitForExit();

            Process p19 = new Process();
            p19.StartInfo.UseShellExecute = false;
            p19.StartInfo.RedirectStandardOutput = true;
            p19.StartInfo.FileName = "cmd.exe";
            p19.StartInfo.Arguments = "/c echo Flashing cmnlib_a.. ";
            p19.StartInfo.CreateNoWindow = true;
            p19.Start();
            richTextBox1.Text = richTextBox1.Text + p19.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p19.WaitForExit();

            Process p20 = new Process();
            p20.StartInfo.UseShellExecute = false;
            p20.StartInfo.RedirectStandardOutput = true;
            p20.StartInfo.FileName = "cmd.exe";
            p20.StartInfo.Arguments = "/c fastboot flash cmnlib_a B2N-354H-0-00WW-B01-cmnlib.img  2>>log.txt ";
            p20.StartInfo.CreateNoWindow = true;
            p20.Start();
            richTextBox1.Text = richTextBox1.Text + p20.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p20.WaitForExit();

            Process p21 = new Process();
            p21.StartInfo.UseShellExecute = false;
            p21.StartInfo.RedirectStandardOutput = true;
            p21.StartInfo.FileName = "cmd.exe";
            p21.StartInfo.Arguments = "/c echo Flashing cmnlib64_a.. ";
            p21.StartInfo.CreateNoWindow = true;
            p21.Start();
            richTextBox1.Text = richTextBox1.Text + p21.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p21.WaitForExit();

            Process p22 = new Process();
            p22.StartInfo.UseShellExecute = false;
            p22.StartInfo.RedirectStandardOutput = true;
            p22.StartInfo.FileName = "cmd.exe";
            p22.StartInfo.Arguments = "/c fastboot flash cmnlib64_a B2N-354H-0-00WW-B01-cmnlib64.img  2>>log.txt ";
            p22.StartInfo.CreateNoWindow = true;
            p22.Start();
            richTextBox1.Text = richTextBox1.Text + p22.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p22.WaitForExit();

            Process p23 = new Process();
            p23.StartInfo.UseShellExecute = false;
            p23.StartInfo.RedirectStandardOutput = true;
            p23.StartInfo.FileName = "cmd.exe";
            p23.StartInfo.Arguments = "/c echo Flashing devcfg_a.. ";
            p23.StartInfo.CreateNoWindow = true;
            p23.Start();
            richTextBox1.Text = richTextBox1.Text + p23.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p23.WaitForExit();

            Process p24 = new Process();
            p24.StartInfo.UseShellExecute = false;
            p24.StartInfo.RedirectStandardOutput = true;
            p24.StartInfo.FileName = "cmd.exe";
            p24.StartInfo.Arguments = "/c fastboot flash devcfg_a B2N-354H-0-00WW-B01-devcfg.img  2>>log.txt ";
            p24.StartInfo.CreateNoWindow = true;
            p24.Start();
            richTextBox1.Text = richTextBox1.Text + p24.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p24.WaitForExit();

            Process p25 = new Process();
            p25.StartInfo.UseShellExecute = false;
            p25.StartInfo.RedirectStandardOutput = true;
            p25.StartInfo.FileName = "cmd.exe";
            p25.StartInfo.Arguments = "/c echo Flashing dsp_a.. ";
            p25.StartInfo.CreateNoWindow = true;
            p25.Start();
            richTextBox1.Text = richTextBox1.Text + p25.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p25.WaitForExit();

            Process p26 = new Process();
            p26.StartInfo.UseShellExecute = false;
            p26.StartInfo.RedirectStandardOutput = true;
            p26.StartInfo.FileName = "cmd.exe";
            p26.StartInfo.Arguments = "/c fastboot flash dsp_a B2N-354H-0-00WW-B01-dsp.img  2>>log.txt ";
            p26.StartInfo.CreateNoWindow = true;
            p26.Start();
            richTextBox1.Text = richTextBox1.Text + p26.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p26.WaitForExit();

            Process p27 = new Process();
            p27.StartInfo.UseShellExecute = false;
            p27.StartInfo.RedirectStandardOutput = true;
            p27.StartInfo.FileName = "cmd.exe";
            p27.StartInfo.Arguments = "/c echo Flashing hidden_a.. ";
            p27.StartInfo.CreateNoWindow = true;
            p27.Start();
            richTextBox1.Text = richTextBox1.Text + p27.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p27.WaitForExit();

            Process p28 = new Process();
            p28.StartInfo.UseShellExecute = false;
            p28.StartInfo.RedirectStandardOutput = true;
            p28.StartInfo.FileName = "cmd.exe";
            p28.StartInfo.Arguments = "/c fastboot flash hidden_a B2N-354H-0-00WW-B01-hidden.img  2>>log.txt ";
            p28.StartInfo.CreateNoWindow = true;
            p28.Start();
            richTextBox1.Text = richTextBox1.Text + p28.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p28.WaitForExit();

            Process p29 = new Process();
            p29.StartInfo.UseShellExecute = false;
            p29.StartInfo.RedirectStandardOutput = true;
            p29.StartInfo.FileName = "cmd.exe";
            p29.StartInfo.Arguments = "/c echo Flashing hyp_a.. ";
            p29.StartInfo.CreateNoWindow = true;
            p29.Start();
            richTextBox1.Text = richTextBox1.Text + p29.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p29.WaitForExit();

            Process p30 = new Process();
            p30.StartInfo.UseShellExecute = false;
            p30.StartInfo.RedirectStandardOutput = true;
            p30.StartInfo.FileName = "cmd.exe";
            p30.StartInfo.Arguments = "/c fastboot flash hyp_a B2N-354H-0-00WW-B01-hyp.img  2>>log.txt ";
            p30.StartInfo.CreateNoWindow = true;
            p30.Start();
            richTextBox1.Text = richTextBox1.Text + p30.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p30.WaitForExit();

            Process p31 = new Process();
            p31.StartInfo.UseShellExecute = false;
            p31.StartInfo.RedirectStandardOutput = true;
            p31.StartInfo.FileName = "cmd.exe";
            p31.StartInfo.Arguments = "/c echo flashing keymaster_a.. ";
            p31.StartInfo.CreateNoWindow = true;
            p31.Start();
            richTextBox1.Text = richTextBox1.Text + p31.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p31.WaitForExit();

            Process p32 = new Process();
            p32.StartInfo.UseShellExecute = false;
            p32.StartInfo.RedirectStandardOutput = true;
            p32.StartInfo.FileName = "cmd.exe";
            p32.StartInfo.Arguments = "/c fastboot flash keymaster_a B2N-354H-0-00WW-B01-keymaster.img  2>>log.txt ";
            p32.StartInfo.CreateNoWindow = true;
            p32.Start();
            richTextBox1.Text = richTextBox1.Text + p32.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p32.WaitForExit();

            Process p33 = new Process();
            p33.StartInfo.UseShellExecute = false;
            p33.StartInfo.RedirectStandardOutput = true;
            p33.StartInfo.FileName = "cmd.exe";
            p33.StartInfo.Arguments = "/c echo Flashing mdtp_a.. ";
            p33.StartInfo.CreateNoWindow = true;
            p33.Start();
            richTextBox1.Text = richTextBox1.Text + p33.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p33.WaitForExit();

            Process p34 = new Process();
            p34.StartInfo.UseShellExecute = false;
            p34.StartInfo.RedirectStandardOutput = true;
            p34.StartInfo.FileName = "cmd.exe";
            p34.StartInfo.Arguments = "/c fastboot flash mdtp_a B2N-354H-0-00WW-B01-mdtp.img  2>>log.txt ";
            p34.StartInfo.CreateNoWindow = true;
            p34.Start();
            richTextBox1.Text = richTextBox1.Text + p34.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p34.WaitForExit();

            Process p35 = new Process();
            p35.StartInfo.UseShellExecute = false;
            p35.StartInfo.RedirectStandardOutput = true;
            p35.StartInfo.FileName = "cmd.exe";
            p35.StartInfo.Arguments = "/c echo Flashing mdtpsecapp_a.. ";
            p35.StartInfo.CreateNoWindow = true;
            p35.Start();
            richTextBox1.Text = richTextBox1.Text + p35.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p35.WaitForExit();

            Process p36 = new Process();
            p36.StartInfo.UseShellExecute = false;
            p36.StartInfo.RedirectStandardOutput = true;
            p36.StartInfo.FileName = "cmd.exe";
            p36.StartInfo.Arguments = "/c fastboot flash mdtpsecapp_a B2N-354H-0-00WW-B01-mdtpsecapp.img  2>>log.txt ";
            p36.StartInfo.CreateNoWindow = true;
            p36.Start();
            richTextBox1.Text = richTextBox1.Text + p36.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p36.WaitForExit();

            Process p37 = new Process();
            p37.StartInfo.UseShellExecute = false;
            p37.StartInfo.RedirectStandardOutput = true;
            p37.StartInfo.FileName = "cmd.exe";
            p37.StartInfo.Arguments = "/c echo Flashing modem_a.. ";
            p37.StartInfo.CreateNoWindow = true;
            p37.Start();
            richTextBox1.Text = richTextBox1.Text + p37.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p37.WaitForExit();

            Process p38 = new Process();
            p38.StartInfo.UseShellExecute = false;
            p38.StartInfo.RedirectStandardOutput = true;
            p38.StartInfo.FileName = "cmd.exe";
            p38.StartInfo.Arguments = "/c fastboot flash modem_a B2N-354H-0-00WW-B01-modem.img  2>>log.txt ";
            p38.StartInfo.CreateNoWindow = true;
            p38.Start();
            richTextBox1.Text = richTextBox1.Text + p38.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p38.WaitForExit();

            Process p39 = new Process();
            p39.StartInfo.UseShellExecute = false;
            p39.StartInfo.RedirectStandardOutput = true;
            p39.StartInfo.FileName = "cmd.exe";
            p39.StartInfo.Arguments = "/c echo Flashing nvdef_a.. ";
            p39.StartInfo.CreateNoWindow = true;
            p39.Start();
            richTextBox1.Text = richTextBox1.Text + p39.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p39.WaitForExit();

            Process p40 = new Process();
            p40.StartInfo.UseShellExecute = false;
            p40.StartInfo.RedirectStandardOutput = true;
            p40.StartInfo.FileName = "cmd.exe";
            p40.StartInfo.Arguments = "/c fastboot flash nvdef_a B2N-354H-0-00WW-B01-nvdef.img  2>>log.txt ";
            p40.StartInfo.CreateNoWindow = true;
            p40.Start();
            richTextBox1.Text = richTextBox1.Text + p40.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p40.WaitForExit();

            Process p41 = new Process();
            p41.StartInfo.UseShellExecute = false;
            p41.StartInfo.RedirectStandardOutput = true;
            p41.StartInfo.FileName = "cmd.exe";
            p41.StartInfo.Arguments = "/c echo Flashing pmic_a.. ";
            p41.StartInfo.CreateNoWindow = true;
            p41.Start();
            richTextBox1.Text = richTextBox1.Text + p41.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p41.WaitForExit();

            Process p42 = new Process();
            p42.StartInfo.UseShellExecute = false;
            p42.StartInfo.RedirectStandardOutput = true;
            p42.StartInfo.FileName = "cmd.exe";
            p42.StartInfo.Arguments = "/c fastboot flash pmic_a B2N-354H-0-00WW-B01-pmic.img  2>>log.txt";
            p42.StartInfo.CreateNoWindow = true;
            p42.Start();
            richTextBox1.Text = richTextBox1.Text + p42.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p42.WaitForExit();

            Process p43 = new Process();
            p43.StartInfo.UseShellExecute = false;
            p43.StartInfo.RedirectStandardOutput = true;
            p43.StartInfo.FileName = "cmd.exe";
            p43.StartInfo.Arguments = "/c echo FLashing rpm_a.. ";
            p43.StartInfo.CreateNoWindow = true;
            p43.Start();
            richTextBox1.Text = richTextBox1.Text + p43.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p43.WaitForExit();

            Process p44 = new Process();
            p44.StartInfo.UseShellExecute = false;
            p44.StartInfo.RedirectStandardOutput = true;
            p44.StartInfo.FileName = "cmd.exe";
            p44.StartInfo.Arguments = "/c fastboot flash rpm_a B2N-354H-0-00WW-B01-rpm.img  2>>log.txt ";
            p44.StartInfo.CreateNoWindow = true;
            p44.Start();
            richTextBox1.Text = richTextBox1.Text + p44.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p44.WaitForExit();

            Process p45 = new Process();
            p45.StartInfo.UseShellExecute = false;
            p45.StartInfo.RedirectStandardOutput = true;
            p45.StartInfo.FileName = "cmd.exe";
            p45.StartInfo.Arguments = "/c echo Flashing splash_a.. ";
            p45.StartInfo.CreateNoWindow = true;
            p45.Start();
            richTextBox1.Text = richTextBox1.Text + p45.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p45.WaitForExit();

            Process p46 = new Process();
            p46.StartInfo.UseShellExecute = false;
            p46.StartInfo.RedirectStandardOutput = true;
            p46.StartInfo.FileName = "cmd.exe";
            p46.StartInfo.Arguments = "/c fastboot flash splash_a B2N-354H-0-00WW-B01-splash.img  2>>log.txt ";
            p46.StartInfo.CreateNoWindow = true;
            p46.Start();
            richTextBox1.Text = richTextBox1.Text + p46.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p46.WaitForExit();

            Process p47 = new Process();
            p47.StartInfo.UseShellExecute = false;
            p47.StartInfo.RedirectStandardOutput = true;
            p47.StartInfo.FileName = "cmd.exe";
            p47.StartInfo.Arguments = "/c echo Flashing system_a.. ";
            p47.StartInfo.CreateNoWindow = true;
            p47.Start();
            richTextBox1.Text = richTextBox1.Text + p47.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p47.WaitForExit();

            Process p48 = new Process();
            p48.StartInfo.UseShellExecute = false;
            p48.StartInfo.RedirectStandardOutput = true;
            p48.StartInfo.FileName = "cmd.exe";
            p48.StartInfo.Arguments = "/c fastboot flash system_a B2N-354H-0-00WW-B01-system.img  2>>log.txt ";
            p48.StartInfo.CreateNoWindow = true;
            p48.Start();
            richTextBox1.Text = richTextBox1.Text + p48.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p48.WaitForExit();

            Process p49 = new Process();
            p49.StartInfo.UseShellExecute = false;
            p49.StartInfo.RedirectStandardOutput = true;
            p49.StartInfo.FileName = "cmd.exe";
            p49.StartInfo.Arguments = "/c echo Flashing systeminfo_a.. ";
            p49.StartInfo.CreateNoWindow = true;
            p49.Start();
            richTextBox1.Text = richTextBox1.Text + p49.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p49.WaitForExit();

            Process p50 = new Process();
            p50.StartInfo.UseShellExecute = false;
            p50.StartInfo.RedirectStandardOutput = true;
            p50.StartInfo.FileName = "cmd.exe";
            p50.StartInfo.Arguments = "/c fastboot flash systeminfo_a B2N-354H-0-00WW-B01-systeminfo.img  2>>log.txt";
            p50.StartInfo.CreateNoWindow = true;
            p50.Start();
            richTextBox1.Text = richTextBox1.Text + p50.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p50.WaitForExit();

            Process p51 = new Process();
            p51.StartInfo.UseShellExecute = false;
            p51.StartInfo.RedirectStandardOutput = true;
            p51.StartInfo.FileName = "cmd.exe";
            p51.StartInfo.Arguments = "/c echo Flshing tz_a.";
            p51.StartInfo.CreateNoWindow = true;
            p51.Start();
            richTextBox1.Text = richTextBox1.Text + p51.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p51.WaitForExit();

            Process p52 = new Process();
            p52.StartInfo.UseShellExecute = false;
            p52.StartInfo.RedirectStandardOutput = true;
            p52.StartInfo.FileName = "cmd.exe";
            p52.StartInfo.Arguments = "/c fastboot flash tz_a B2N-354H-0-00WW-B01-tz.img  2>>log.txt";
            p52.StartInfo.CreateNoWindow = true;
            p52.Start();
            richTextBox1.Text = richTextBox1.Text + p52.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p52.WaitForExit();

            Process p53 = new Process();
            p53.StartInfo.UseShellExecute = false;
            p53.StartInfo.RedirectStandardOutput = true;
            p53.StartInfo.FileName = "cmd.exe";
            p53.StartInfo.Arguments = "/c echo Flashing vendor_a.. ";
            p53.StartInfo.CreateNoWindow = true;
            p53.Start();
            richTextBox1.Text = richTextBox1.Text + p53.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p53.WaitForExit();

            Process p54 = new Process();
            p54.StartInfo.UseShellExecute = false;
            p54.StartInfo.RedirectStandardOutput = true;
            p54.StartInfo.FileName = "cmd.exe";
            p54.StartInfo.Arguments = "/c fastboot flash vendor_a B2N-354H-0-00WW-B01-vendor.img  2>>log.txt ";
            p54.StartInfo.CreateNoWindow = true;
            p54.Start();
            richTextBox1.Text = richTextBox1.Text + p54.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p54.WaitForExit();

            Process p55 = new Process();
            p55.StartInfo.UseShellExecute = false;
            p55.StartInfo.RedirectStandardOutput = true;
            p55.StartInfo.FileName = "cmd.exe";
            p55.StartInfo.Arguments = "/c echo Erase ssd..";
            p55.StartInfo.CreateNoWindow = true;
            p55.Start();
            richTextBox1.Text = richTextBox1.Text + p55.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p55.WaitForExit();

            Process p56 = new Process();
            p56.StartInfo.UseShellExecute = false;
            p56.StartInfo.RedirectStandardOutput = true;
            p56.StartInfo.FileName = "cmd.exe";
            p56.StartInfo.Arguments = "/c fastboot erase ssd ";
            p56.StartInfo.CreateNoWindow = true;
            p56.Start();
            richTextBox1.Text = richTextBox1.Text + p56.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p56.WaitForExit();

            Process p57 = new Process();
            p57.StartInfo.UseShellExecute = false;
            p57.StartInfo.RedirectStandardOutput = true;
            p57.StartInfo.FileName = "cmd.exe";
            p57.StartInfo.Arguments = "/c echo Erase misc.. ";
            p57.StartInfo.CreateNoWindow = true;
            p57.Start();
            richTextBox1.Text = richTextBox1.Text + p57.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p57.WaitForExit();

            Process p58 = new Process();
            p58.StartInfo.UseShellExecute = false;
            p58.StartInfo.RedirectStandardOutput = true;
            p58.StartInfo.FileName = "cmd.exe";
            p58.StartInfo.Arguments = "/c fastboot erase misc ";
            p58.StartInfo.CreateNoWindow = true;
            p58.Start();
            richTextBox1.Text = richTextBox1.Text + p58.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p58.WaitForExit();

            Process p59 = new Process();
            p59.StartInfo.UseShellExecute = false;
            p59.StartInfo.RedirectStandardOutput = true;
            p59.StartInfo.FileName = "cmd.exe";
            p59.StartInfo.Arguments = "/c echo Erase sti.. ";
            p59.StartInfo.CreateNoWindow = true;
            p59.Start();
            richTextBox1.Text = richTextBox1.Text + p59.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p59.WaitForExit();

            Process p60 = new Process();
            p60.StartInfo.UseShellExecute = false;
            p60.StartInfo.RedirectStandardOutput = true;
            p60.StartInfo.FileName = "cmd.exe";
            p60.StartInfo.Arguments = "/c fastboot erase sti ";
            p60.StartInfo.CreateNoWindow = true;
            p60.Start();
            richTextBox1.Text = richTextBox1.Text + p60.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p60.WaitForExit();

            Process p61 = new Process();
            p61.StartInfo.UseShellExecute = false;
            p61.StartInfo.RedirectStandardOutput = true;
            p61.StartInfo.FileName = "cmd.exe";
            p61.StartInfo.Arguments = "/c echo Erase ddr.. ";
            p61.StartInfo.CreateNoWindow = true;
            p61.Start();
            richTextBox1.Text = richTextBox1.Text + p61.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p61.WaitForExit();

            Process p62 = new Process();
            p62.StartInfo.UseShellExecute = false;
            p62.StartInfo.RedirectStandardOutput = true;
            p62.StartInfo.FileName = "cmd.exe";
            p62.StartInfo.Arguments = "/c fastboot erase ddr ";
            p62.StartInfo.CreateNoWindow = true;
            p62.Start();
            richTextBox1.Text = richTextBox1.Text + p62.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p62.WaitForExit();

            Process p63 = new Process();
            p63.StartInfo.UseShellExecute = false;
            p63.StartInfo.RedirectStandardOutput = true;
            p63.StartInfo.FileName = "cmd.exe";
            p63.StartInfo.Arguments = "/c echo Erase securefs.. ";
            p63.StartInfo.CreateNoWindow = true;
            p63.Start();
            richTextBox1.Text = richTextBox1.Text + p63.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p63.WaitForExit();

            Process p64 = new Process();
            p64.StartInfo.UseShellExecute = false;
            p64.StartInfo.RedirectStandardOutput = true;
            p64.StartInfo.FileName = "cmd.exe";
            p64.StartInfo.Arguments = "/c fastboot erase securefs ";
            p64.StartInfo.CreateNoWindow = true;
            p64.Start();
            richTextBox1.Text = richTextBox1.Text + p64.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p64.WaitForExit();

            Process p65 = new Process();
            p65.StartInfo.UseShellExecute = false;
            p65.StartInfo.RedirectStandardOutput = true;
            p65.StartInfo.FileName = "cmd.exe";
            p65.StartInfo.Arguments = "/c echo Erase box.. ";
            p65.StartInfo.CreateNoWindow = true;
            p65.Start();
            richTextBox1.Text = richTextBox1.Text + p65.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p65.WaitForExit();

            Process p66 = new Process();
            p66.StartInfo.UseShellExecute = false;
            p66.StartInfo.RedirectStandardOutput = true;
            p66.StartInfo.FileName = "cmd.exe";
            p66.StartInfo.Arguments = "/c fastboot erase box ";
            p66.StartInfo.CreateNoWindow = true;
            p66.Start();
            richTextBox1.Text = richTextBox1.Text + p66.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p66.WaitForExit();

            Process p67 = new Process();
            p67.StartInfo.UseShellExecute = false;
            p67.StartInfo.RedirectStandardOutput = true;
            p67.StartInfo.FileName = "cmd.exe";
            p67.StartInfo.Arguments = "/c echo Erase boot_b.. ";
            p67.StartInfo.CreateNoWindow = true;
            p67.Start();
            richTextBox1.Text = richTextBox1.Text + p67.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p67.WaitForExit();

            Process p68 = new Process();
            p68.StartInfo.UseShellExecute = false;
            p68.StartInfo.RedirectStandardOutput = true;
            p68.StartInfo.FileName = "cmd.exe";
            p68.StartInfo.Arguments = "/c fastboot erase boot_b ";
            p68.StartInfo.CreateNoWindow = true;
            p68.Start();
            richTextBox1.Text = richTextBox1.Text + p68.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p68.WaitForExit();

            Process p69 = new Process();
            p69.StartInfo.UseShellExecute = false;
            p69.StartInfo.RedirectStandardOutput = true;
            p69.StartInfo.FileName = "cmd.exe";
            p69.StartInfo.Arguments = "/c echo set active slot A.. ";
            p69.StartInfo.CreateNoWindow = true;
            p69.Start();
            richTextBox1.Text = richTextBox1.Text + p69.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p69.WaitForExit();

            Process p70 = new Process();
            p70.StartInfo.UseShellExecute = false;
            p70.StartInfo.RedirectStandardOutput = true;
            p70.StartInfo.FileName = "cmd.exe";
            p70.StartInfo.Arguments = "/c fastboot --set-active=a ";
            p70.StartInfo.CreateNoWindow = true;
            p70.Start();
            richTextBox1.Text = richTextBox1.Text + p70.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p70.WaitForExit();

            Process p71 = new Process();
            p71.StartInfo.UseShellExecute = false;
            p71.StartInfo.RedirectStandardOutput = true;
            p71.StartInfo.FileName = "cmd.exe";
            p71.StartInfo.Arguments = "/c echo Erase Userdata.. ";
            p71.StartInfo.CreateNoWindow = true;
            p71.Start();
            richTextBox1.Text = richTextBox1.Text + p71.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p71.WaitForExit();

            Process p72 = new Process();
            p72.StartInfo.UseShellExecute = false;
            p72.StartInfo.RedirectStandardOutput = true;
            p72.StartInfo.FileName = "cmd.exe";
            p72.StartInfo.Arguments = "/c fastboot -w ";
            p72.StartInfo.CreateNoWindow = true;
            p72.Start();
            richTextBox1.Refresh();

            Process p73 = new Process();
            p73.StartInfo.UseShellExecute = false;
            p73.StartInfo.RedirectStandardOutput = true;
            p73.StartInfo.FileName = "cmd.exe";
            p73.StartInfo.Arguments = "/c echo Rebooting system.. ";
            p73.StartInfo.CreateNoWindow = true;
            p73.Start();
            richTextBox1.Text = richTextBox1.Text + p73.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p73.WaitForExit();

            Process p74 = new Process();
            p74.StartInfo.UseShellExecute = false;
            p74.StartInfo.RedirectStandardOutput = true;
            p74.StartInfo.FileName = "cmd.exe";
            p74.StartInfo.Arguments = "/c fastboot reboot ";
            p74.StartInfo.CreateNoWindow = true;
            p74.Start();
            richTextBox1.Text = richTextBox1.Text + p74.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p74.WaitForExit();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Process p1 = new Process();
            p1.StartInfo.UseShellExecute = false;
            p1.StartInfo.RedirectStandardOutput = true;
            p1.StartInfo.FileName = "cmd.exe";
            p1.StartInfo.Arguments = "/c echo getversions..";
            p1.StartInfo.CreateNoWindow = true;
            p1.Start();
            richTextBox1.Text = richTextBox1.Text + p1.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p1.WaitForExit();


            Process p2 = new Process();
            p2.StartInfo.UseShellExecute = false;
            p2.StartInfo.RedirectStandardOutput = true;
            p2.StartInfo.FileName = "cmd.exe";
            p2.StartInfo.Arguments = "/c fastboot oem getversions 2>getver.txt & type getver.txt ";
            p2.StartInfo.CreateNoWindow = true;
            p2.Start();
            richTextBox1.Text = richTextBox1.Text + p2.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p2.WaitForExit();

            Process p3 = new Process();
            p3.StartInfo.UseShellExecute = false;
            p3.StartInfo.RedirectStandardOutput = true;
            p3.StartInfo.FileName = "cmd.exe";
            p3.StartInfo.Arguments = "/c echo device-info..";
            p3.StartInfo.CreateNoWindow = true;
            p3.Start();
            richTextBox1.Text = richTextBox1.Text + p3.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p3.WaitForExit();


            Process p4 = new Process();
            p4.StartInfo.UseShellExecute = false;
            p4.StartInfo.RedirectStandardOutput = true;
            p4.StartInfo.FileName = "cmd.exe";
            p4.StartInfo.Arguments = "/c fastboot oem device-info 2>device.txt & type device.txt ";
            p4.StartInfo.CreateNoWindow = true;
            p4.Start();
            richTextBox1.Text = richTextBox1.Text + p4.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p4.WaitForExit();

            Process p5 = new Process();
            p5.StartInfo.UseShellExecute = false;
            p5.StartInfo.RedirectStandardOutput = true;
            p5.StartInfo.FileName = "cmd.exe";
            p5.StartInfo.Arguments = "/c echo Flashing abl_a..";
            p5.StartInfo.CreateNoWindow = true;
            p5.Start();
            richTextBox1.Text = richTextBox1.Text + p5.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p5.WaitForExit();


            Process p6 = new Process();
            p6.StartInfo.UseShellExecute = false;
            p6.StartInfo.RedirectStandardOutput = true;
            p6.StartInfo.FileName = "cmd.exe";
            p6.StartInfo.Arguments = "/c fastboot flash abl_a PL2-354H-0-00WW-B01-abl.img  2>>log.txt  ";
            p6.StartInfo.CreateNoWindow = true;
            p6.Start();
            richTextBox1.Text = richTextBox1.Text + p6.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p6.WaitForExit();

            Process p7 = new Process();
            p7.StartInfo.UseShellExecute = false;
            p7.StartInfo.RedirectStandardOutput = true;
            p7.StartInfo.FileName = "cmd.exe";
            p7.StartInfo.Arguments = "/c echo Flashing abl_b..";
            p7.StartInfo.CreateNoWindow = true;
            p7.Start();
            richTextBox1.Text = richTextBox1.Text + p7.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p7.WaitForExit();

            Process p8 = new Process();
            p8.StartInfo.UseShellExecute = false;
            p8.StartInfo.RedirectStandardOutput = true;
            p8.StartInfo.FileName = "cmd.exe";
            p8.StartInfo.Arguments = "/c fastboot flash abl_b PL2-354H-0-00WW-B01-abl.img  2>>log.txt ";
            p8.StartInfo.CreateNoWindow = true;
            p8.Start();
            richTextBox1.Text = richTextBox1.Text + p8.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p8.WaitForExit();

            Process p9 = new Process();
            p9.StartInfo.UseShellExecute = false;
            p9.StartInfo.RedirectStandardOutput = true;
            p9.StartInfo.FileName = "cmd.exe";
            p9.StartInfo.Arguments = "/c echo FLashing xbl_a..";
            p9.StartInfo.CreateNoWindow = true;
            p9.Start();
            richTextBox1.Text = richTextBox1.Text + p9.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p9.WaitForExit();

            Process p10 = new Process();
            p10.StartInfo.UseShellExecute = false;
            p10.StartInfo.RedirectStandardOutput = true;
            p10.StartInfo.FileName = "cmd.exe";
            p10.StartInfo.Arguments = "/c fastboot flash xbl_a PL2-354H-0-00WW-B01-xbl.img  2>>log.txt ";
            p10.StartInfo.CreateNoWindow = true;
            p10.Start();
            richTextBox1.Text = richTextBox1.Text + p10.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p10.WaitForExit();

            Process p11 = new Process();
            p11.StartInfo.UseShellExecute = false;
            p11.StartInfo.RedirectStandardOutput = true;
            p11.StartInfo.FileName = "cmd.exe";
            p11.StartInfo.Arguments = "/c echo Flashing xbl_b.. ";
            p11.StartInfo.CreateNoWindow = true;
            p11.Start();
            richTextBox1.Text = richTextBox1.Text + p11.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p11.WaitForExit();

            Process p12 = new Process();
            p12.StartInfo.UseShellExecute = false;
            p12.StartInfo.RedirectStandardOutput = true;
            p12.StartInfo.FileName = "cmd.exe";
            p12.StartInfo.Arguments = "/c fastboot flash xbl_b PL2-354H-0-00WW-B01-xbl.img  2>>log.txt ";
            p12.StartInfo.CreateNoWindow = true;
            p12.Start();
            richTextBox1.Text = richTextBox1.Text + p12.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p12.WaitForExit();

            Process p13 = new Process();
            p13.StartInfo.UseShellExecute = false;
            p13.StartInfo.RedirectStandardOutput = true;
            p13.StartInfo.FileName = "cmd.exe";
            p13.StartInfo.Arguments = "/c echo Flashing bluetooth_a.. ";
            p13.StartInfo.CreateNoWindow = true;
            p13.Start();
            richTextBox1.Text = richTextBox1.Text + p13.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p13.WaitForExit();

            Process p14 = new Process();
            p14.StartInfo.UseShellExecute = false;
            p14.StartInfo.RedirectStandardOutput = true;
            p14.StartInfo.FileName = "cmd.exe";
            p14.StartInfo.Arguments = "/c fastboot flash bluetooth_a PL2-354H-0-00WW-B01-bluetooth.img  2>>log.txt ";
            p14.StartInfo.CreateNoWindow = true;
            p14.Start();
            richTextBox1.Text = richTextBox1.Text + p14.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p14.WaitForExit();

            Process p15 = new Process();
            p15.StartInfo.UseShellExecute = false;
            p15.StartInfo.RedirectStandardOutput = true;
            p15.StartInfo.FileName = "cmd.exe";
            p15.StartInfo.Arguments = "/c echo Flashing boot_a.. ";
            p15.StartInfo.CreateNoWindow = true;
            p15.Start();
            richTextBox1.Text = richTextBox1.Text + p15.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p15.WaitForExit();

            Process p16 = new Process();
            p16.StartInfo.UseShellExecute = false;
            p16.StartInfo.RedirectStandardOutput = true;
            p16.StartInfo.FileName = "cmd.exe";
            p16.StartInfo.Arguments = "/c fastboot flash boot_a PL2-354H-0-00WW-B01-boot.img  2>>log.txt ";
            p16.StartInfo.CreateNoWindow = true;
            p16.Start();
            richTextBox1.Text = richTextBox1.Text + p16.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p16.WaitForExit();

            Process p17 = new Process();
            p17.StartInfo.UseShellExecute = false;
            p17.StartInfo.RedirectStandardOutput = true;
            p17.StartInfo.FileName = "cmd.exe";
            p17.StartInfo.Arguments = "/c echo Flashing cda_a.. ";
            p17.StartInfo.CreateNoWindow = true;
            p17.Start();
            richTextBox1.Text = richTextBox1.Text + p17.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p17.WaitForExit();

            Process p18 = new Process();
            p18.StartInfo.UseShellExecute = false;
            p18.StartInfo.RedirectStandardOutput = true;
            p18.StartInfo.FileName = "cmd.exe";
            p18.StartInfo.Arguments = "/c fastboot flash cda_a PL2-354H-0-00WW-B01-cda.img  2>>log.txt ";
            p18.StartInfo.CreateNoWindow = true;
            p18.Start();
            richTextBox1.Text = richTextBox1.Text + p18.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p18.WaitForExit();

            Process p19 = new Process();
            p19.StartInfo.UseShellExecute = false;
            p19.StartInfo.RedirectStandardOutput = true;
            p19.StartInfo.FileName = "cmd.exe";
            p19.StartInfo.Arguments = "/c echo Flashing cmnlib_a.. ";
            p19.StartInfo.CreateNoWindow = true;
            p19.Start();
            richTextBox1.Text = richTextBox1.Text + p19.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p19.WaitForExit();

            Process p20 = new Process();
            p20.StartInfo.UseShellExecute = false;
            p20.StartInfo.RedirectStandardOutput = true;
            p20.StartInfo.FileName = "cmd.exe";
            p20.StartInfo.Arguments = "/c fastboot flash cmnlib_a PL2-354H-0-00WW-B01-cmnlib.img  2>>log.txt ";
            p20.StartInfo.CreateNoWindow = true;
            p20.Start();
            richTextBox1.Text = richTextBox1.Text + p20.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p20.WaitForExit();

            Process p21 = new Process();
            p21.StartInfo.UseShellExecute = false;
            p21.StartInfo.RedirectStandardOutput = true;
            p21.StartInfo.FileName = "cmd.exe";
            p21.StartInfo.Arguments = "/c echo Flashing cmnlib64_a.. ";
            p21.StartInfo.CreateNoWindow = true;
            p21.Start();
            richTextBox1.Text = richTextBox1.Text + p21.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p21.WaitForExit();

            Process p22 = new Process();
            p22.StartInfo.UseShellExecute = false;
            p22.StartInfo.RedirectStandardOutput = true;
            p22.StartInfo.FileName = "cmd.exe";
            p22.StartInfo.Arguments = "/c fastboot flash cmnlib64_a PL2-354H-0-00WW-B01-cmnlib64.img  2>>log.txt ";
            p22.StartInfo.CreateNoWindow = true;
            p22.Start();
            richTextBox1.Text = richTextBox1.Text + p22.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p22.WaitForExit();

            Process p23 = new Process();
            p23.StartInfo.UseShellExecute = false;
            p23.StartInfo.RedirectStandardOutput = true;
            p23.StartInfo.FileName = "cmd.exe";
            p23.StartInfo.Arguments = "/c echo Flashing devcfg_a.. ";
            p23.StartInfo.CreateNoWindow = true;
            p23.Start();
            richTextBox1.Text = richTextBox1.Text + p23.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p23.WaitForExit();

            Process p24 = new Process();
            p24.StartInfo.UseShellExecute = false;
            p24.StartInfo.RedirectStandardOutput = true;
            p24.StartInfo.FileName = "cmd.exe";
            p24.StartInfo.Arguments = "/c fastboot flash devcfg_a PL2-354H-0-00WW-B01-devcfg.img  2>>log.txt ";
            p24.StartInfo.CreateNoWindow = true;
            p24.Start();
            richTextBox1.Text = richTextBox1.Text + p24.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p24.WaitForExit();

            Process p25 = new Process();
            p25.StartInfo.UseShellExecute = false;
            p25.StartInfo.RedirectStandardOutput = true;
            p25.StartInfo.FileName = "cmd.exe";
            p25.StartInfo.Arguments = "/c echo Flashing dsp_a.. ";
            p25.StartInfo.CreateNoWindow = true;
            p25.Start();
            richTextBox1.Text = richTextBox1.Text + p25.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p25.WaitForExit();

            Process p26 = new Process();
            p26.StartInfo.UseShellExecute = false;
            p26.StartInfo.RedirectStandardOutput = true;
            p26.StartInfo.FileName = "cmd.exe";
            p26.StartInfo.Arguments = "/c fastboot flash dsp_a PL2-354H-0-00WW-B01-dsp.img  2>>log.txt ";
            p26.StartInfo.CreateNoWindow = true;
            p26.Start();
            richTextBox1.Text = richTextBox1.Text + p26.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p26.WaitForExit();

            Process p27 = new Process();
            p27.StartInfo.UseShellExecute = false;
            p27.StartInfo.RedirectStandardOutput = true;
            p27.StartInfo.FileName = "cmd.exe";
            p27.StartInfo.Arguments = "/c echo Flashing hidden_a.. ";
            p27.StartInfo.CreateNoWindow = true;
            p27.Start();
            richTextBox1.Text = richTextBox1.Text + p27.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p27.WaitForExit();

            Process p28 = new Process();
            p28.StartInfo.UseShellExecute = false;
            p28.StartInfo.RedirectStandardOutput = true;
            p28.StartInfo.FileName = "cmd.exe";
            p28.StartInfo.Arguments = "/c fastboot flash hidden_a PL2-354H-0-00WW-B01-hidden.img  2>>log.txt ";
            p28.StartInfo.CreateNoWindow = true;
            p28.Start();
            richTextBox1.Text = richTextBox1.Text + p28.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p28.WaitForExit();

            Process p29 = new Process();
            p29.StartInfo.UseShellExecute = false;
            p29.StartInfo.RedirectStandardOutput = true;
            p29.StartInfo.FileName = "cmd.exe";
            p29.StartInfo.Arguments = "/c echo Flashing hyp_a.. ";
            p29.StartInfo.CreateNoWindow = true;
            p29.Start();
            richTextBox1.Text = richTextBox1.Text + p29.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p29.WaitForExit();

            Process p30 = new Process();
            p30.StartInfo.UseShellExecute = false;
            p30.StartInfo.RedirectStandardOutput = true;
            p30.StartInfo.FileName = "cmd.exe";
            p30.StartInfo.Arguments = "/c fastboot flash hyp_a PL2-354H-0-00WW-B01-hyp.img  2>>log.txt ";
            p30.StartInfo.CreateNoWindow = true;
            p30.Start();
            richTextBox1.Text = richTextBox1.Text + p30.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p30.WaitForExit();

            Process p31 = new Process();
            p31.StartInfo.UseShellExecute = false;
            p31.StartInfo.RedirectStandardOutput = true;
            p31.StartInfo.FileName = "cmd.exe";
            p31.StartInfo.Arguments = "/c echo flashing keymaster_a.. ";
            p31.StartInfo.CreateNoWindow = true;
            p31.Start();
            richTextBox1.Text = richTextBox1.Text + p31.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p31.WaitForExit();

            Process p32 = new Process();
            p32.StartInfo.UseShellExecute = false;
            p32.StartInfo.RedirectStandardOutput = true;
            p32.StartInfo.FileName = "cmd.exe";
            p32.StartInfo.Arguments = "/c fastboot flash keymaster_a PL2-354H-0-00WW-B01-keymaster.img  2>>log.txt ";
            p32.StartInfo.CreateNoWindow = true;
            p32.Start();
            richTextBox1.Text = richTextBox1.Text + p32.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p32.WaitForExit();

            Process p33 = new Process();
            p33.StartInfo.UseShellExecute = false;
            p33.StartInfo.RedirectStandardOutput = true;
            p33.StartInfo.FileName = "cmd.exe";
            p33.StartInfo.Arguments = "/c echo Flashing mdtp_a.. ";
            p33.StartInfo.CreateNoWindow = true;
            p33.Start();
            richTextBox1.Text = richTextBox1.Text + p33.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p33.WaitForExit();

            Process p34 = new Process();
            p34.StartInfo.UseShellExecute = false;
            p34.StartInfo.RedirectStandardOutput = true;
            p34.StartInfo.FileName = "cmd.exe";
            p34.StartInfo.Arguments = "/c fastboot flash mdtp_a PL2-354H-0-00WW-B01-mdtp.img  2>>log.txt ";
            p34.StartInfo.CreateNoWindow = true;
            p34.Start();
            richTextBox1.Text = richTextBox1.Text + p34.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p34.WaitForExit();

            Process p35 = new Process();
            p35.StartInfo.UseShellExecute = false;
            p35.StartInfo.RedirectStandardOutput = true;
            p35.StartInfo.FileName = "cmd.exe";
            p35.StartInfo.Arguments = "/c echo Flashing mdtpsecapp_a.. ";
            p35.StartInfo.CreateNoWindow = true;
            p35.Start();
            richTextBox1.Text = richTextBox1.Text + p35.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p35.WaitForExit();

            Process p36 = new Process();
            p36.StartInfo.UseShellExecute = false;
            p36.StartInfo.RedirectStandardOutput = true;
            p36.StartInfo.FileName = "cmd.exe";
            p36.StartInfo.Arguments = "/c fastboot flash mdtpsecapp_a PL2-354H-0-00WW-B01-mdtpsecapp.img  2>>log.txt ";
            p36.StartInfo.CreateNoWindow = true;
            p36.Start();
            richTextBox1.Text = richTextBox1.Text + p36.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p36.WaitForExit();

            Process p37 = new Process();
            p37.StartInfo.UseShellExecute = false;
            p37.StartInfo.RedirectStandardOutput = true;
            p37.StartInfo.FileName = "cmd.exe";
            p37.StartInfo.Arguments = "/c echo Flashing modem_a.. ";
            p37.StartInfo.CreateNoWindow = true;
            p37.Start();
            richTextBox1.Text = richTextBox1.Text + p37.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p37.WaitForExit();

            Process p38 = new Process();
            p38.StartInfo.UseShellExecute = false;
            p38.StartInfo.RedirectStandardOutput = true;
            p38.StartInfo.FileName = "cmd.exe";
            p38.StartInfo.Arguments = "/c fastboot flash modem_a PL2-354H-0-00WW-B01-modem.img  2>>log.txt ";
            p38.StartInfo.CreateNoWindow = true;
            p38.Start();
            richTextBox1.Text = richTextBox1.Text + p38.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p38.WaitForExit();

            Process p39 = new Process();
            p39.StartInfo.UseShellExecute = false;
            p39.StartInfo.RedirectStandardOutput = true;
            p39.StartInfo.FileName = "cmd.exe";
            p39.StartInfo.Arguments = "/c echo Flashing nvdef_a.. ";
            p39.StartInfo.CreateNoWindow = true;
            p39.Start();
            richTextBox1.Text = richTextBox1.Text + p39.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p39.WaitForExit();

            Process p40 = new Process();
            p40.StartInfo.UseShellExecute = false;
            p40.StartInfo.RedirectStandardOutput = true;
            p40.StartInfo.FileName = "cmd.exe";
            p40.StartInfo.Arguments = "/c fastboot flash nvdef_a PL2-354H-0-00WW-B01-nvdef.img  2>>log.txt ";
            p40.StartInfo.CreateNoWindow = true;
            p40.Start();
            richTextBox1.Text = richTextBox1.Text + p40.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p40.WaitForExit();

            Process p41 = new Process();
            p41.StartInfo.UseShellExecute = false;
            p41.StartInfo.RedirectStandardOutput = true;
            p41.StartInfo.FileName = "cmd.exe";
            p41.StartInfo.Arguments = "/c echo Flashing pmic_a.. ";
            p41.StartInfo.CreateNoWindow = true;
            p41.Start();
            richTextBox1.Text = richTextBox1.Text + p41.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p41.WaitForExit();

            Process p42 = new Process();
            p42.StartInfo.UseShellExecute = false;
            p42.StartInfo.RedirectStandardOutput = true;
            p42.StartInfo.FileName = "cmd.exe";
            p42.StartInfo.Arguments = "/c fastboot flash pmic_a PL2-354H-0-00WW-B01-pmic.img  2>>log.txt";
            p42.StartInfo.CreateNoWindow = true;
            p42.Start();
            richTextBox1.Text = richTextBox1.Text + p42.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p42.WaitForExit();

            Process p43 = new Process();
            p43.StartInfo.UseShellExecute = false;
            p43.StartInfo.RedirectStandardOutput = true;
            p43.StartInfo.FileName = "cmd.exe";
            p43.StartInfo.Arguments = "/c echo FLashing rpm_a.. ";
            p43.StartInfo.CreateNoWindow = true;
            p43.Start();
            richTextBox1.Text = richTextBox1.Text + p43.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p43.WaitForExit();

            Process p44 = new Process();
            p44.StartInfo.UseShellExecute = false;
            p44.StartInfo.RedirectStandardOutput = true;
            p44.StartInfo.FileName = "cmd.exe";
            p44.StartInfo.Arguments = "/c fastboot flash rpm_a PL2-354H-0-00WW-B01-rpm.img  2>>log.txt ";
            p44.StartInfo.CreateNoWindow = true;
            p44.Start();
            richTextBox1.Text = richTextBox1.Text + p44.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p44.WaitForExit();

            Process p45 = new Process();
            p45.StartInfo.UseShellExecute = false;
            p45.StartInfo.RedirectStandardOutput = true;
            p45.StartInfo.FileName = "cmd.exe";
            p45.StartInfo.Arguments = "/c echo Flashing splash_a.. ";
            p45.StartInfo.CreateNoWindow = true;
            p45.Start();
            richTextBox1.Text = richTextBox1.Text + p45.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p45.WaitForExit();

            Process p46 = new Process();
            p46.StartInfo.UseShellExecute = false;
            p46.StartInfo.RedirectStandardOutput = true;
            p46.StartInfo.FileName = "cmd.exe";
            p46.StartInfo.Arguments = "/c fastboot flash splash_a PL2-354H-0-00WW-B01-splash.img  2>>log.txt ";
            p46.StartInfo.CreateNoWindow = true;
            p46.Start();
            richTextBox1.Text = richTextBox1.Text + p46.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p46.WaitForExit();

            Process p47 = new Process();
            p47.StartInfo.UseShellExecute = false;
            p47.StartInfo.RedirectStandardOutput = true;
            p47.StartInfo.FileName = "cmd.exe";
            p47.StartInfo.Arguments = "/c echo Flashing system_a.. ";
            p47.StartInfo.CreateNoWindow = true;
            p47.Start();
            richTextBox1.Text = richTextBox1.Text + p47.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p47.WaitForExit();

            Process p48 = new Process();
            p48.StartInfo.UseShellExecute = false;
            p48.StartInfo.RedirectStandardOutput = true;
            p48.StartInfo.FileName = "cmd.exe";
            p48.StartInfo.Arguments = "/c fastboot flash system_a PL2-354H-0-00WW-B01-system.img  2>>log.txt ";
            p48.StartInfo.CreateNoWindow = true;
            p48.Start();
            richTextBox1.Text = richTextBox1.Text + p48.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p48.WaitForExit();

            Process p49 = new Process();
            p49.StartInfo.UseShellExecute = false;
            p49.StartInfo.RedirectStandardOutput = true;
            p49.StartInfo.FileName = "cmd.exe";
            p49.StartInfo.Arguments = "/c echo Flashing systeminfo_a.. ";
            p49.StartInfo.CreateNoWindow = true;
            p49.Start();
            richTextBox1.Text = richTextBox1.Text + p49.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p49.WaitForExit();

            Process p50 = new Process();
            p50.StartInfo.UseShellExecute = false;
            p50.StartInfo.RedirectStandardOutput = true;
            p50.StartInfo.FileName = "cmd.exe";
            p50.StartInfo.Arguments = "/c fastboot flash systeminfo_a PL2-354H-0-00WW-B01-systeminfo.img  2>>log.txt";
            p50.StartInfo.CreateNoWindow = true;
            p50.Start();
            richTextBox1.Text = richTextBox1.Text + p50.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p50.WaitForExit();

            Process p51 = new Process();
            p51.StartInfo.UseShellExecute = false;
            p51.StartInfo.RedirectStandardOutput = true;
            p51.StartInfo.FileName = "cmd.exe";
            p51.StartInfo.Arguments = "/c echo Flshing tz_a.";
            p51.StartInfo.CreateNoWindow = true;
            p51.Start();
            richTextBox1.Text = richTextBox1.Text + p51.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p51.WaitForExit();

            Process p52 = new Process();
            p52.StartInfo.UseShellExecute = false;
            p52.StartInfo.RedirectStandardOutput = true;
            p52.StartInfo.FileName = "cmd.exe";
            p52.StartInfo.Arguments = "/c fastboot flash tz_a PL2-354H-0-00WW-B01-tz.img  2>>log.txt";
            p52.StartInfo.CreateNoWindow = true;
            p52.Start();
            richTextBox1.Text = richTextBox1.Text + p52.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p52.WaitForExit();

            Process p53 = new Process();
            p53.StartInfo.UseShellExecute = false;
            p53.StartInfo.RedirectStandardOutput = true;
            p53.StartInfo.FileName = "cmd.exe";
            p53.StartInfo.Arguments = "/c echo Flashing vendor_a.. ";
            p53.StartInfo.CreateNoWindow = true;
            p53.Start();
            richTextBox1.Text = richTextBox1.Text + p53.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p53.WaitForExit();

            Process p54 = new Process();
            p54.StartInfo.UseShellExecute = false;
            p54.StartInfo.RedirectStandardOutput = true;
            p54.StartInfo.FileName = "cmd.exe";
            p54.StartInfo.Arguments = "/c fastboot flash vendor_a PL2-354H-0-00WW-B01-vendor.img  2>>log.txt ";
            p54.StartInfo.CreateNoWindow = true;
            p54.Start();
            richTextBox1.Text = richTextBox1.Text + p54.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p54.WaitForExit();

            Process p55 = new Process();
            p55.StartInfo.UseShellExecute = false;
            p55.StartInfo.RedirectStandardOutput = true;
            p55.StartInfo.FileName = "cmd.exe";
            p55.StartInfo.Arguments = "/c echo Erase ssd..";
            p55.StartInfo.CreateNoWindow = true;
            p55.Start();
            richTextBox1.Text = richTextBox1.Text + p55.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p55.WaitForExit();

            Process p56 = new Process();
            p56.StartInfo.UseShellExecute = false;
            p56.StartInfo.RedirectStandardOutput = true;
            p56.StartInfo.FileName = "cmd.exe";
            p56.StartInfo.Arguments = "/c fastboot erase ssd ";
            p56.StartInfo.CreateNoWindow = true;
            p56.Start();
            richTextBox1.Text = richTextBox1.Text + p56.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p56.WaitForExit();

            Process p57 = new Process();
            p57.StartInfo.UseShellExecute = false;
            p57.StartInfo.RedirectStandardOutput = true;
            p57.StartInfo.FileName = "cmd.exe";
            p57.StartInfo.Arguments = "/c echo Erase misc.. ";
            p57.StartInfo.CreateNoWindow = true;
            p57.Start();
            richTextBox1.Text = richTextBox1.Text + p57.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p57.WaitForExit();

            Process p58 = new Process();
            p58.StartInfo.UseShellExecute = false;
            p58.StartInfo.RedirectStandardOutput = true;
            p58.StartInfo.FileName = "cmd.exe";
            p58.StartInfo.Arguments = "/c fastboot erase misc ";
            p58.StartInfo.CreateNoWindow = true;
            p58.Start();
            richTextBox1.Text = richTextBox1.Text + p58.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p58.WaitForExit();

            Process p59 = new Process();
            p59.StartInfo.UseShellExecute = false;
            p59.StartInfo.RedirectStandardOutput = true;
            p59.StartInfo.FileName = "cmd.exe";
            p59.StartInfo.Arguments = "/c echo Erase sti.. ";
            p59.StartInfo.CreateNoWindow = true;
            p59.Start();
            richTextBox1.Text = richTextBox1.Text + p59.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p59.WaitForExit();

            Process p60 = new Process();
            p60.StartInfo.UseShellExecute = false;
            p60.StartInfo.RedirectStandardOutput = true;
            p60.StartInfo.FileName = "cmd.exe";
            p60.StartInfo.Arguments = "/c fastboot erase sti ";
            p60.StartInfo.CreateNoWindow = true;
            p60.Start();
            richTextBox1.Text = richTextBox1.Text + p60.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p60.WaitForExit();

            Process p61 = new Process();
            p61.StartInfo.UseShellExecute = false;
            p61.StartInfo.RedirectStandardOutput = true;
            p61.StartInfo.FileName = "cmd.exe";
            p61.StartInfo.Arguments = "/c echo Erase ddr.. ";
            p61.StartInfo.CreateNoWindow = true;
            p61.Start();
            richTextBox1.Text = richTextBox1.Text + p61.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p61.WaitForExit();

            Process p62 = new Process();
            p62.StartInfo.UseShellExecute = false;
            p62.StartInfo.RedirectStandardOutput = true;
            p62.StartInfo.FileName = "cmd.exe";
            p62.StartInfo.Arguments = "/c fastboot erase ddr ";
            p62.StartInfo.CreateNoWindow = true;
            p62.Start();
            richTextBox1.Text = richTextBox1.Text + p62.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p62.WaitForExit();

            Process p63 = new Process();
            p63.StartInfo.UseShellExecute = false;
            p63.StartInfo.RedirectStandardOutput = true;
            p63.StartInfo.FileName = "cmd.exe";
            p63.StartInfo.Arguments = "/c echo Erase securefs.. ";
            p63.StartInfo.CreateNoWindow = true;
            p63.Start();
            richTextBox1.Text = richTextBox1.Text + p63.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p63.WaitForExit();

            Process p64 = new Process();
            p64.StartInfo.UseShellExecute = false;
            p64.StartInfo.RedirectStandardOutput = true;
            p64.StartInfo.FileName = "cmd.exe";
            p64.StartInfo.Arguments = "/c fastboot erase securefs ";
            p64.StartInfo.CreateNoWindow = true;
            p64.Start();
            richTextBox1.Text = richTextBox1.Text + p64.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p64.WaitForExit();

            Process p65 = new Process();
            p65.StartInfo.UseShellExecute = false;
            p65.StartInfo.RedirectStandardOutput = true;
            p65.StartInfo.FileName = "cmd.exe";
            p65.StartInfo.Arguments = "/c echo Erase box.. ";
            p65.StartInfo.CreateNoWindow = true;
            p65.Start();
            richTextBox1.Text = richTextBox1.Text + p65.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p65.WaitForExit();

            Process p66 = new Process();
            p66.StartInfo.UseShellExecute = false;
            p66.StartInfo.RedirectStandardOutput = true;
            p66.StartInfo.FileName = "cmd.exe";
            p66.StartInfo.Arguments = "/c fastboot erase box ";
            p66.StartInfo.CreateNoWindow = true;
            p66.Start();
            richTextBox1.Text = richTextBox1.Text + p66.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p66.WaitForExit();

            Process p67 = new Process();
            p67.StartInfo.UseShellExecute = false;
            p67.StartInfo.RedirectStandardOutput = true;
            p67.StartInfo.FileName = "cmd.exe";
            p67.StartInfo.Arguments = "/c echo Erase boot_b.. ";
            p67.StartInfo.CreateNoWindow = true;
            p67.Start();
            richTextBox1.Text = richTextBox1.Text + p67.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p67.WaitForExit();

            Process p68 = new Process();
            p68.StartInfo.UseShellExecute = false;
            p68.StartInfo.RedirectStandardOutput = true;
            p68.StartInfo.FileName = "cmd.exe";
            p68.StartInfo.Arguments = "/c fastboot erase boot_b ";
            p68.StartInfo.CreateNoWindow = true;
            p68.Start();
            richTextBox1.Text = richTextBox1.Text + p68.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p68.WaitForExit();

            Process p69 = new Process();
            p69.StartInfo.UseShellExecute = false;
            p69.StartInfo.RedirectStandardOutput = true;
            p69.StartInfo.FileName = "cmd.exe";
            p69.StartInfo.Arguments = "/c echo set active slot A.. ";
            p69.StartInfo.CreateNoWindow = true;
            p69.Start();
            richTextBox1.Text = richTextBox1.Text + p69.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p69.WaitForExit();

            Process p70 = new Process();
            p70.StartInfo.UseShellExecute = false;
            p70.StartInfo.RedirectStandardOutput = true;
            p70.StartInfo.FileName = "cmd.exe";
            p70.StartInfo.Arguments = "/c fastboot --set-active=a ";
            p70.StartInfo.CreateNoWindow = true;
            p70.Start();
            richTextBox1.Text = richTextBox1.Text + p70.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p70.WaitForExit();

            Process p71 = new Process();
            p71.StartInfo.UseShellExecute = false;
            p71.StartInfo.RedirectStandardOutput = true;
            p71.StartInfo.FileName = "cmd.exe";
            p71.StartInfo.Arguments = "/c echo Erase Userdata.. ";
            p71.StartInfo.CreateNoWindow = true;
            p71.Start();
            richTextBox1.Text = richTextBox1.Text + p71.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p71.WaitForExit();

            Process p72 = new Process();
            p72.StartInfo.UseShellExecute = false;
            p72.StartInfo.RedirectStandardOutput = true;
            p72.StartInfo.FileName = "cmd.exe";
            p72.StartInfo.Arguments = "/c fastboot -w ";
            p72.StartInfo.CreateNoWindow = true;
            p72.Start();
            richTextBox1.Refresh();

            Process p73 = new Process();
            p73.StartInfo.UseShellExecute = false;
            p73.StartInfo.RedirectStandardOutput = true;
            p73.StartInfo.FileName = "cmd.exe";
            p73.StartInfo.Arguments = "/c echo Rebooting system.. ";
            p73.StartInfo.CreateNoWindow = true;
            p73.Start();
            richTextBox1.Text = richTextBox1.Text + p73.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p73.WaitForExit();

            Process p74 = new Process();
            p74.StartInfo.UseShellExecute = false;
            p74.StartInfo.RedirectStandardOutput = true;
            p74.StartInfo.FileName = "cmd.exe";
            p74.StartInfo.Arguments = "/c fastboot reboot ";
            p74.StartInfo.CreateNoWindow = true;
            p74.Start();
            richTextBox1.Text = richTextBox1.Text + p74.StandardOutput.ReadToEnd();
            richTextBox1.Refresh();
            p74.WaitForExit();
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.ScrollToCaret();
        }
    }
}