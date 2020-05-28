using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using GlpkSharp;
using System.IO;
using Hydra;
namespace ProyectodeTesis
{
    public partial class Fba : Plantilla
    {
        public Fba()
        {
            InitializeComponent();
        }

        public static string objetive = "";
        Read readsbml;
        static public Sbml sbml;
        public static MakeFba makefba;
        public static OptimisationDirection pd;
        public static Setup_Constraints sc;

        public static string reactionoptimize;

        static bool results;

        public static int Funcion_obj;
        public static double z;

        public static bool Result 
        {
            get { return results; }
        }
        private void Fba_Load(object sender, EventArgs e)
        {
            fileTextBox.Text = Principal.FileAddres;

            
            readsbml= new Read();

            results = false;

            Principal.abierto = true;

            sbml = Principal.mysbml;       

            foreach (Reaction item in sbml.ListReaction)
            {
                reactionObjetiveComboBox.Items.Add(item.Id);
                comboconstrain.Items.Add(item.Id);
            }
            foreach (Specie item in sbml.ListSpecie) 
            {
                combometabolites.Items.Add(item.Id);
            }
            reactionObjetiveComboBox.Text = Principal.objetivefuntion;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            Principal.mod.Close();
            Principal.abierto = false;
        }

        private void solveButton_Click(object sender, EventArgs e)
        {

            

            
        }

        private void reactionObjetiveComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            foreach (Reaction item in sbml.ListReaction)
            {
                if (item.Id == reactionObjetiveComboBox.Text)
                {
                    reactionTextBox.Text = item.Id;                    
                    
                    break;
                }

            }
            
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (comboconstrain.Text.Length > 0)
            {
                if (Sbml.There(comboconstrain, comboconstrain.Text))
                {
                    if (isReversibleTextBox.Text == "False")
                    {
                        if (double.Parse(lowertextBox1.Text, CultureInfo.InvariantCulture.NumberFormat) < 0)
                        {
                            MessageBox.Show("This reaction is irreversible, the Lower Bound must be less than zero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            foreach (Reaction item in sbml.ListReaction)
                            {
                                if (item.Id == comboconstrain.Text)
                                {

                                    item.LowerBound = double.Parse(lowertextBox1.Text, CultureInfo.InvariantCulture.NumberFormat);
                                    item.UpperBound = double.Parse(uppertextBox2.Text, CultureInfo.InvariantCulture.NumberFormat);
                                    Principal.mysbml = sbml;
                                    if (!Principal.txt)
                                    {
                                        Read red = new Read();
                                        red.ActualizarRestricciones(Principal.doc, comboconstrain.Text.ToLower(), lowertextBox1.Text, uppertextBox2.Text);
                                    }
                                    MessageBox.Show("Update!!!!!!", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    break;

                                }

                            }
                        }
                    }
                    else
                    {
                        foreach (Reaction item in sbml.ListReaction)
                        {
                            if (item.Id == comboconstrain.Text)
                            {

                                item.LowerBound = double.Parse(lowertextBox1.Text, CultureInfo.InvariantCulture.NumberFormat);
                                item.UpperBound = double.Parse(uppertextBox2.Text, CultureInfo.InvariantCulture.NumberFormat);
                                Principal.mysbml = sbml;
                                if (!Principal.txt)
                                {
                                    Read red = new Read();
                                    red.ActualizarRestricciones(Principal.doc, comboconstrain.Text.ToLower(), lowertextBox1.Text, uppertextBox2.Text);
                                }
                                MessageBox.Show("Update!!!!!!", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            }

                        }
                    }
                }
                else 
                {
                    MessageBox.Show("Not exist a reaction with this name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else 
            {
                MessageBox.Show("Select the reaction to be configured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (reactionObjetiveComboBox.Text.Length > 0)
            {
                
                    makefba = new MakeFba();

                    int i = 0;

                    bool find = false;

                    foreach (Reaction item in sbml.ListReaction)
                    {
                        if (item.Id == reactionObjetiveComboBox.Text)
                        {
                            reactionoptimize = reactionObjetiveComboBox.Text;

                            find = true;

                            break;
                        }
                        i++;
                    }
                    if (find)
                    {


                        if (radiomax.Checked)
                        {
                            pd = OptimisationDirection.MAXIMISE;
                        }
                        else
                        {
                            pd = OptimisationDirection.MINIMISE;
                        }
                        Funcion_obj = i;
                        makefba.Fba(sbml, i, pd);

                        double z = makefba.Lp.GetObjectiveValue();

                        resultlist.Items.Clear();

                        string[] str = new string[2] { "Z = " + reactionObjetiveComboBox.Text, z.ToString() };

                        ListViewItem list = new ListViewItem(str);
                        resultlist.Items.Add(list);

                        for (int k = 0; k < sbml.ListReaction.Length; k++)
                        {
                            str = new string[2] { sbml.ListReaction[k].Id, makefba.Lp.GetColPrimal(k + 1).ToString() };

                            list = new ListViewItem(str);
                            resultlist.Items.Add(list);
                        }
                        results = true;
                        button5.Enabled = true;
                        button3.Enabled = true;

                    }
                    else
                    {
                        results = false;
                        button3.Enabled = false;
                        MessageBox.Show("This reaction not exist in the model", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                

            }
            else 
            {
                MessageBox.Show("Select the function to optimize", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (results)
            {
                if (save.ShowDialog() == DialogResult.OK) 
                {
                   

                    makefba.SaveResult(sbml, save.FileName, pd, reactionoptimize);
                    MessageBox.Show("Correctly Saved!!!", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else 
            {
                MessageBox.Show("Not exist a result that save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboconstrain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboconstrain.Text != reactionObjetiveComboBox.Text)
            {
                foreach (Reaction item in sbml.ListReaction)
                {
                    if (item.Id == comboconstrain.Text)
                    {
                        lowertextBox1.Text = item.LowerBound.ToString();
                        uppertextBox2.Text = item.UpperBound.ToString();
                        isReversibleTextBox.Text = item.Reversible.ToString();
                        break;
                    }

                }
            }
            else 
            {

                DialogResult dr = MessageBox.Show("The objective function must be not configured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                if (dr == DialogResult.OK)
                {
                    comboconstrain.ResetText();
                    comboconstrain.SelectedIndex = -1;
                }
            }
        }

        private void lowertextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == '-' || char.IsControl(e.KeyChar) || e.KeyChar == '.')
            {
                e.Handled = false;
            }
            else 
            {
                e.Handled = true;
            }
        }

        private void uppertextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == '-' || char.IsControl(e.KeyChar) || e.KeyChar == '.')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (combometabolites.Text.Length > 0)
            {
                if (Sbml.There(combometabolites, combometabolites.Text))
                {
                    sbml.AgregaraMetabolitosExternos(combometabolites.Text);
                    if (!Principal.txt)
                    {
                        Read read = new Read();
                        read.ActualizarBoundaryCondition(Principal.doc, combometabolites.Text.ToLower());
                    }
                    // Principal.doc.PreserveWhitespace = true;


                    combometabolites.Items.Remove(combometabolites.Text);
                    Principal.mysbml = sbml;
                    MessageBox.Show("Correctly Converted!!!", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else 
                {
                    MessageBox.Show("not exist a metabolite with this name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            else 
            {
                MessageBox.Show("Select the metabolite to be removed of the internal metabolites", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
            double flujo_r = 0;
          
            makefba.Fba(sbml, Funcion_obj, pd);
            z = makefba.Lp.GetObjectiveValue();


            string[] aux_flujos = new String[sbml.ListReaction.Length];
            for (int j = 0; j < sbml.ListReaction.Length; j++)
            {
                aux_flujos[j] = makefba.Lp.GetColPrimal(j + 1).ToString();

            }
            int pos = 1;

           
            
            for (int i = 0; i < sbml.ListReaction.Length; i++)//
            {


                if (makefba.Lp.GetColPrimal(i + 1) < 9000 && makefba.Lp.GetColPrimal(i + 1) > -9000)
                {



                   

                    flujo_r = makefba.Lp.GetColPrimal(i + 1);
                    pos = i;

 
                    double viejo_low = sbml.ListReaction[i].LowerBound;//
                    double viejo_up = sbml.ListReaction[i].UpperBound;//
                    double nuevo_low = 0;
                    double nuevo_up = 0;
                    if (flujo_r == 0)
                    {
                        nuevo_low = 0.002;
                        nuevo_up = 0.003;

                    }
                    else
                    {
                        nuevo_low = flujo_r * 1 / 100;
                        nuevo_low = flujo_r - nuevo_low;
                        nuevo_up = flujo_r * 1.1 / 100;
                        nuevo_up = flujo_r - nuevo_up;
                    }
                    sbml.ListReaction[i].LowerBound = nuevo_low;//
                    sbml.ListReaction[i].UpperBound = nuevo_up;//
                    MakeFba makefba_shadows = new MakeFba();
                    makefba_shadows.Fba(sbml, Funcion_obj, pd);//
                    double z_prima = makefba_shadows.Lp.GetObjectiveValue();

                   
                    double aux = makefba_shadows.Lp.GetColPrimal(pos + 1);
                    double shadows = (z - z_prima) / (flujo_r - makefba_shadows.Lp.GetColPrimal(pos + 1));
                    if (flujo_r - makefba_shadows.Lp.GetColPrimal(pos + 1) != 0)
                    {
                        string[] str = new string[3] { sbml.ListReaction[i].Id, aux_flujos[i], shadows.ToString() };
                        ListViewItem list = new ListViewItem(str);
                        resultlist.Items[pos + 1] = list;
                    }
                    else
                    {
                        string[] str = new string[3] { sbml.ListReaction[i].Id, aux_flujos[i], "Infinito." };
                        ListViewItem list = new ListViewItem(str);
                        resultlist.Items[pos + 1] = list;

                    }
                  
                    sbml.ListReaction[i].LowerBound = viejo_low;
                    sbml.ListReaction[i].UpperBound = viejo_up;



                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (reactionObjetiveComboBox.Text.Length == 0)
            {
                MessageBox.Show("Select the function to optimize", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                if (Sbml.There(reactionObjetiveComboBox, reactionObjetiveComboBox.Text))
                {
                    Principal.objetivefuntion = reactionObjetiveComboBox.Text;
                    Principal.yaabriconstraint = true;
                    sc = new Setup_Constraints();
                    sc.MdiParent = Principal.ActiveForm;
                    objetive = reactionObjetiveComboBox.Text;
                    this.Close();
                    sc.Show();
                }
                else 
                {
                    MessageBox.Show("This reaction not exist in the model", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
