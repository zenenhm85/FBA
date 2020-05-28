namespace ProyectodeTesis
{
    partial class Fba
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fba));
            this.reactionTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.isReversibleTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.reactionObjetiveComboBox = new System.Windows.Forms.ComboBox();
            this.answerLabel = new System.Windows.Forms.Label();
            this.fileTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lowertextBox1 = new System.Windows.Forms.TextBox();
            this.uppertextBox2 = new System.Windows.Forms.TextBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.resultlist = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radiomin = new System.Windows.Forms.RadioButton();
            this.radiomax = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.SaveFileDialog();
            this.label7 = new System.Windows.Forms.Label();
            this.comboconstrain = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.combometabolites = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.button1, "button1");
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.button2, "button2");
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // reactionTextBox
            // 
            resources.ApplyResources(this.reactionTextBox, "reactionTextBox");
            this.reactionTextBox.Name = "reactionTextBox";
            this.reactionTextBox.ReadOnly = true;
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // isReversibleTextBox
            // 
            resources.ApplyResources(this.isReversibleTextBox, "isReversibleTextBox");
            this.isReversibleTextBox.Name = "isReversibleTextBox";
            this.isReversibleTextBox.ReadOnly = true;
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // reactionObjetiveComboBox
            // 
            this.reactionObjetiveComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.reactionObjetiveComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.reactionObjetiveComboBox.FormattingEnabled = true;
            resources.ApplyResources(this.reactionObjetiveComboBox, "reactionObjetiveComboBox");
            this.reactionObjetiveComboBox.Name = "reactionObjetiveComboBox";
            this.reactionObjetiveComboBox.SelectedIndexChanged += new System.EventHandler(this.reactionObjetiveComboBox_SelectedIndexChanged);
            // 
            // answerLabel
            // 
            resources.ApplyResources(this.answerLabel, "answerLabel");
            this.answerLabel.ForeColor = System.Drawing.Color.Red;
            this.answerLabel.Name = "answerLabel";
            // 
            // fileTextBox
            // 
            resources.ApplyResources(this.fileTextBox, "fileTextBox");
            this.fileTextBox.Name = "fileTextBox";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // lowertextBox1
            // 
            resources.ApplyResources(this.lowertextBox1, "lowertextBox1");
            this.lowertextBox1.Name = "lowertextBox1";
            this.lowertextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lowertextBox1_KeyPress);
            // 
            // uppertextBox2
            // 
            resources.ApplyResources(this.uppertextBox2, "uppertextBox2");
            this.uppertextBox2.Name = "uppertextBox2";
            this.uppertextBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.uppertextBox2_KeyPress);
            // 
            // updateButton
            // 
            resources.ApplyResources(this.updateButton, "updateButton");
            this.updateButton.Name = "updateButton";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // resultlist
            // 
            this.resultlist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.resultlist.GridLines = true;
            resources.ApplyResources(this.resultlist, "resultlist");
            this.resultlist.Name = "resultlist";
            this.resultlist.UseCompatibleStateImageBehavior = false;
            this.resultlist.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            resources.ApplyResources(this.columnHeader1, "columnHeader1");
            // 
            // columnHeader2
            // 
            resources.ApplyResources(this.columnHeader2, "columnHeader2");
            // 
            // columnHeader3
            // 
            resources.ApplyResources(this.columnHeader3, "columnHeader3");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radiomin);
            this.groupBox1.Controls.Add(this.radiomax);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // radiomin
            // 
            resources.ApplyResources(this.radiomin, "radiomin");
            this.radiomin.Name = "radiomin";
            this.radiomin.UseVisualStyleBackColor = true;
            // 
            // radiomax
            // 
            resources.ApplyResources(this.radiomax, "radiomax");
            this.radiomax.Checked = true;
            this.radiomax.Name = "radiomax";
            this.radiomax.TabStop = true;
            this.radiomax.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // save
            // 
            this.save.DefaultExt = "txt";
            resources.ApplyResources(this.save, "save");
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // comboconstrain
            // 
            this.comboconstrain.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboconstrain.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboconstrain.FormattingEnabled = true;
            resources.ApplyResources(this.comboconstrain, "comboconstrain");
            this.comboconstrain.Name = "comboconstrain";
            this.comboconstrain.SelectedIndexChanged += new System.EventHandler(this.comboconstrain_SelectedIndexChanged);
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // combometabolites
            // 
            this.combometabolites.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combometabolites.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combometabolites.FormattingEnabled = true;
            resources.ApplyResources(this.combometabolites, "combometabolites");
            this.combometabolites.Name = "combometabolites";
            // 
            // button4
            // 
            resources.ApplyResources(this.button4, "button4");
            this.button4.Name = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // saveFileDialog2
            // 
            resources.ApplyResources(this.saveFileDialog2, "saveFileDialog2");
            // 
            // button5
            // 
            resources.ApplyResources(this.button5, "button5");
            this.button5.Name = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            resources.ApplyResources(this.button6, "button6");
            this.button6.Name = "button6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Fba
            // 
            this.AcceptButton = this.button2;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.CancelButton = this.button1;
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.combometabolites);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboconstrain);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.resultlist);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.uppertextBox2);
            this.Controls.Add(this.lowertextBox1);
            this.Controls.Add(this.reactionTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.isReversibleTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.reactionObjetiveComboBox);
            this.Controls.Add(this.answerLabel);
            this.Controls.Add(this.fileTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Fba";
            this.Load += new System.EventHandler(this.Fba_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.fileTextBox, 0);
            this.Controls.SetChildIndex(this.answerLabel, 0);
            this.Controls.SetChildIndex(this.reactionObjetiveComboBox, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.isReversibleTextBox, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.reactionTextBox, 0);
            this.Controls.SetChildIndex(this.lowertextBox1, 0);
            this.Controls.SetChildIndex(this.uppertextBox2, 0);
            this.Controls.SetChildIndex(this.updateButton, 0);
            this.Controls.SetChildIndex(this.button3, 0);
            this.Controls.SetChildIndex(this.resultlist, 0);
            this.Controls.SetChildIndex(this.button5, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.comboconstrain, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.combometabolites, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.button4, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.button6, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox reactionTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox isReversibleTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox reactionObjetiveComboBox;
        private System.Windows.Forms.Label answerLabel;
        private System.Windows.Forms.TextBox fileTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lowertextBox1;
        private System.Windows.Forms.TextBox uppertextBox2;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.ListView resultlist;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radiomin;
        private System.Windows.Forms.RadioButton radiomax;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.SaveFileDialog save;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboconstrain;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox combometabolites;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}