using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Hydra;
using System.Xml;

namespace ProyectodeTesis
{
    public partial class Principal : Form
    {
        
        static MakeFba makefba;
        public static bool abierto;
        static string fileaddres;
        public static string objetivefuntion;
        public static Model mod;
        public static Fba fba;

        public static XmlDocument doc;
        public static Sbml mysbml;
        bool fba2;
        int time;
        public static bool txt;
        bool yaabri;
        public static bool yaabriconstraint;
        public Principal()
        {
            InitializeComponent();
            
        }
        
        public static string FileAddres
        {
            get { return fileaddres; }
            set { fileaddres = value; }
        }
        public static MakeFba Modelo 
        {
            get { return makefba; }
            set { makefba = value; }
        }
       
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Close();
        }

        private void optimize_Click(object sender, EventArgs e)
        {
            if (abierto)
            {
                progressBar1.Visible = true;
                optimizer2.Enabled = false;
                timer1.Enabled = true;
               
                optimize.Enabled = false;
                abierto = false;
                time = Environment.TickCount;
            }

           
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            makefba = new MakeFba();
            doc = new XmlDocument();
            fba2 = false;
            yaabri = false;
            txt = false;
            abierto = false;
            objetivefuntion = "";
            yaabriconstraint = false;
        }
        
        private void sbmlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.openfile.ShowDialog() == DialogResult.OK) 
            {
                string aux = openfile.FileName.Split('.')[1];

                if (aux == "xml")
                {
                    
                    fileaddres = openfile.FileName;
                    Read read = new Read();
                    mysbml = read.ReadXml(fileaddres);
                    if (mysbml.ListReaction.Length == 0 || mysbml.ListSpecie.Length == 0)
                    {
                        MessageBox.Show("Unreadable file,\n verify complies with the standard", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                        doc.Load(fileaddres);
                        optimize.Enabled = true;
                        optimizer2.Enabled = true;
                        toolStripButton2.Enabled = true;
                        toolStripMenuItem1.Enabled = true;
                        save2toolStrip.Enabled = true;
                        toolStripMenuItem2.Enabled = true;
                       
                        if (yaabri)
                        {

                            mod.Close();
                            mod = new Model();
                            mod.MdiParent = this;
                            mod.Show();
                        }
                        else
                        {
                            mod = new Model();
                            mod.MdiParent = this;
                            mod.Show();
                            yaabri = true;
                        }
                        fba2 = false;
                    }
                   // MessageBox.Show("Successfully Loaded", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else 
                {
                    MessageBox.Show("Incorrect Extension", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }               

                
            }
                

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Fba.Result && abierto)
            {
                export.Enabled = true;
            }
            else 
            {
                export.Enabled = false;
            }
        }

        private void export_Click(object sender, EventArgs e)
        {
            if (Fba.Result)
            {
                if (save1.ShowDialog() == DialogResult.OK)
                {
                    Fba.makefba.SaveResult(Fba.sbml, save1.FileName,Fba.pd,Fba.reactionoptimize);
                    MessageBox.Show("Successfully saved!!!", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Not exist a model that save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.openfile2.ShowDialog() == DialogResult.OK)
            {
                string aux = openfile2.FileName.Split('.')[1];

                if (aux == "txt")
                {

                    fileaddres = openfile2.FileName;
                    Read read = new Read();
                    mysbml = read.Readtxt(fileaddres);
                    if (mysbml.ListReaction.Length == 0 || mysbml.ListSpecie.Length == 0)
                    {
                        MessageBox.Show("Unreadable file,\n verify complies with the standard", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                        optimize.Enabled = true;
                        optimizer2.Enabled = true;
                        toolStripButton2.Enabled = true;
                        toolStripMenuItem1.Enabled = true;
                        save2toolStrip.Enabled = true;
                        toolStripMenuItem2.Enabled = true;
                        txt = true;
                       
                        if (yaabri)
                        {
                            mod.Close();
                            mod = new Model();
                            mod.MdiParent = this;
                            mod.Show();
                        }
                        else
                        {
                            mod = new Model();
                            mod.MdiParent = this;
                            mod.Show();
                            yaabri = true;
                        }
                        fba2 = false;
                    }
                    //MessageBox.Show("Successfully Loaded", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Incorrect Extension", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            
            int b = Environment.TickCount;

            if ((b - time) >= 1000)
            {
                timer1.Enabled = false;
                progressBar1.Visible = false;
               
                progressBar1.Value = 0;
                if (!fba2)
                {
                    //fba.Close();
                    fba = new Fba();
                    fba.MdiParent = this;

                    fba.Show();
                }
                else
                {
                   
                }
            }
            else
            {
                //progressBar1.Step += 200;
                if (progressBar1.Value + 150 < progressBar1.Maximum)
                {
                    progressBar1.Value += 150;
                }
                else 
                {
                    progressBar1.Value = 0;
                }
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (abierto)
            {
                progressBar1.Visible = true;
                optimizer2.Enabled = false;
                timer1.Enabled = true;
                
                optimize.Enabled = false;
                abierto = false;
                time = Environment.TickCount;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (this.openfile.ShowDialog() == DialogResult.OK)
            {
                string aux = openfile.FileName.Split('.')[1];

                if (aux == "xml")
                {

                    
                    fileaddres = openfile.FileName;
                    
                    Read read = new Read();
                    mysbml = read.ReadXml(fileaddres);
                    if (mysbml.ListReaction.Length == 0 || mysbml.ListSpecie.Length == 0)
                    {
                        MessageBox.Show("Unreadable file,\n verify complies with the standard", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                        doc.Load(fileaddres);
                        optimize.Enabled = true;
                        optimizer2.Enabled = true;
                        toolStripButton2.Enabled = true;
                        toolStripMenuItem1.Enabled = true;
                        save2toolStrip.Enabled = true;
                        toolStripMenuItem2.Enabled = true;
                        txt = false;
                        

                        if (yaabri)
                        {
                            mod.Close();
                            mod = new Model();
                            mod.MdiParent = this;
                            mod.Show();
                        }
                        else
                        {
                            mod = new Model();
                            mod.MdiParent = this;
                            mod.Show();
                            yaabri = true;
                        }
                        fba2 = false;
                    }
                    //MessageBox.Show("Successfully Loaded", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Incorrect Extension", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (Fba.Result)
            {
                if (save1.ShowDialog() == DialogResult.OK)
                {
                    Fba.makefba.SaveResult(Fba.sbml, save1.FileName, Fba.pd, Fba.reactionoptimize);
                    MessageBox.Show("Successfully saved!!!", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Not exist a model that save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void toolStripButton3_Click(object sender, EventArgs e)
        {

        }

        private void Principal_Shown(object sender, EventArgs e)
        {
            
        }

        

        private void Principal_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void Principal_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void Principal_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void save2_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void save2_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (this.openfile2.ShowDialog() == DialogResult.OK)
            {
                string aux = openfile2.FileName.Split('.')[1];

                if (aux == "txt")
                {

                    fileaddres = openfile2.FileName;
                    Read read = new Read();
                    mysbml = read.Readtxt(fileaddres);

                    if (mysbml.ListReaction.Length == 0 || mysbml.ListSpecie.Length == 0)
                    {
                        MessageBox.Show("Unreadable file,\n verify complies with the standard", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                        optimize.Enabled = true;
                        optimizer2.Enabled = true;
                        toolStripButton2.Enabled = true;
                        toolStripMenuItem1.Enabled = true;
                        save2toolStrip.Enabled = true;
                        toolStripMenuItem2.Enabled = true;
                        txt = true;
                       
                        if (yaabri)
                        {
                            mod.Close();
                            mod = new Model();
                            mod.MdiParent = this;
                            mod.Show();
                        }
                        else
                        {
                            mod = new Model();
                            mod.MdiParent = this;
                            mod.Show();
                            yaabri = true;
                        }
                        fba2 = false;
                    }
                    //MessageBox.Show("Successfully Loaded", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Incorrect Extension", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (yaabri)
            {
                mod.Close();
                if (fba != null)
                {
                    fba.Close();
                }
                yaabri = false;
                toolStripButton2.Enabled = false;
                toolStripMenuItem1.Enabled = false;
                optimize.Enabled = false;
                toolStripMenuItem2.Enabled = false;
                optimizer2.Enabled = false;
                save2toolStrip.Enabled = false;
                objetivefuntion = "";

            }
            if (yaabriconstraint)
            {
                Fba.sc.Close();
            }
            
        }

        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {
            if (yaabri)
            {
                mod.Close();
                if (fba != null)
                {
                    fba.Close();
                }
                yaabri = false;
                toolStripButton2.Enabled = false;
                toolStripMenuItem1.Enabled = false;
                toolStripMenuItem2.Enabled = false;
                optimize.Enabled = false;
                optimizer2.Enabled = false;
                save2toolStrip.Enabled = false;
                objetivefuntion = "";
                
            }
            if (yaabriconstraint) 
            {
                Fba.sc.Close();
            }
        }

        private void Principal_Activated(object sender, EventArgs e)
        {
           
        }

        private void Principal_Enter(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton2_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton2_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void optimizer2_MouseHover(object sender, EventArgs e)
        {
            if (abierto)
            {
                optimizer2.Enabled = true;
            }
            else 
            {
                optimizer2.Enabled = false;
            }
        }

        private void optimizer2_MouseLeave(object sender, EventArgs e)
        {
            if (abierto)
            {
                optimizer2.Enabled = true;
            }
            else
            {
                optimizer2.Enabled = false;
            }
        }

        private void fBAToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripButton4_Click_1(object sender, EventArgs e)
        {
            if (!Principal.txt)
            {
                DialogResult ok = saveFileDialog2.ShowDialog();

                if (ok == DialogResult.OK)
                {
                    Principal.doc.Save(saveFileDialog2.FileName);

                    MessageBox.Show("Successfully saved!!!", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else 
            {
                if (Principal.txt)
                {
                    DialogResult ok = saveFileDialog1.ShowDialog();

                    if (ok == DialogResult.OK)
                    {
                        SbmlTraductor trad = new SbmlTraductor(mysbml);
                        trad.SbmlToTxt(saveFileDialog1.FileName);
                        MessageBox.Show("Successfully saved!!!", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (!Principal.txt)
            {
                DialogResult ok = saveFileDialog2.ShowDialog();

                if (ok == DialogResult.OK)
                {
                    Principal.doc.Save(saveFileDialog2.FileName);

                    MessageBox.Show("Successfully saved!!!", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else 
            {
                if (Principal.txt)
                {
                    DialogResult ok = saveFileDialog1.ShowDialog();

                    if (ok == DialogResult.OK)
                    {
                        SbmlTraductor trad = new SbmlTraductor(mysbml);
                        trad.SbmlToTxt(saveFileDialog1.FileName);
                        MessageBox.Show("Successfully saved!!!", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}
