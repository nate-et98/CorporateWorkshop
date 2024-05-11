
namespace WorkshopSelector
{
    partial class Form1
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
            this.listCities = new System.Windows.Forms.ListBox();
            this.listWorkshops = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRegCost = new System.Windows.Forms.Label();
            this.lblLodCost = new System.Windows.Forms.Label();
            this.lblTotCost = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listCities
            // 
            this.listCities.FormattingEnabled = true;
            this.listCities.ItemHeight = 20;
            this.listCities.Items.AddRange(new object[] {
            "Austin",
            "Chicago",
            "Dallas",
            "Orlando",
            "Phoenix",
            "Raleigh"});
            this.listCities.Location = new System.Drawing.Point(452, 57);
            this.listCities.Name = "listCities";
            this.listCities.Size = new System.Drawing.Size(191, 164);
            this.listCities.TabIndex = 0;
            this.listCities.SelectedIndexChanged += new System.EventHandler(this.listCities_SelectedIndexChanged);
            // 
            // listWorkshops
            // 
            this.listWorkshops.FormattingEnabled = true;
            this.listWorkshops.ItemHeight = 20;
            this.listWorkshops.Items.AddRange(new object[] {
            "Handling Stress",
            "Time Management",
            "Supervision Skills",
            "Negotiation",
            "How To Interview"});
            this.listWorkshops.Location = new System.Drawing.Point(155, 57);
            this.listWorkshops.Name = "listWorkshops";
            this.listWorkshops.Size = new System.Drawing.Size(203, 164);
            this.listWorkshops.TabIndex = 1;
            this.listWorkshops.SelectedIndexChanged += new System.EventHandler(this.listWorkshops_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(222, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Registration Cost:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lodging Cost:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Total Cost:";
            // 
            // lblRegCost
            // 
            this.lblRegCost.AutoSize = true;
            this.lblRegCost.Location = new System.Drawing.Point(469, 236);
            this.lblRegCost.Name = "lblRegCost";
            this.lblRegCost.Size = new System.Drawing.Size(18, 20);
            this.lblRegCost.TabIndex = 5;
            this.lblRegCost.Text = "0";
            // 
            // lblLodCost
            // 
            this.lblLodCost.AutoSize = true;
            this.lblLodCost.Location = new System.Drawing.Point(469, 265);
            this.lblLodCost.Name = "lblLodCost";
            this.lblLodCost.Size = new System.Drawing.Size(18, 20);
            this.lblLodCost.TabIndex = 6;
            this.lblLodCost.Text = "0";
            this.lblLodCost.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblTotCost
            // 
            this.lblTotCost.AutoSize = true;
            this.lblTotCost.Location = new System.Drawing.Point(469, 298);
            this.lblTotCost.Name = "lblTotCost";
            this.lblTotCost.Size = new System.Drawing.Size(18, 20);
            this.lblTotCost.TabIndex = 7;
            this.lblTotCost.Text = "0";
            this.lblTotCost.Click += new System.EventHandler(this.lblTotCost_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(322, 346);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(120, 38);
            this.btnCalc.TabIndex = 8;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lblTotCost);
            this.Controls.Add(this.lblLodCost);
            this.Controls.Add(this.lblRegCost);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listWorkshops);
            this.Controls.Add(this.listCities);
            this.Name = "Form1";
            this.Text = "Workshop Selection Tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listCities;
        private System.Windows.Forms.ListBox listWorkshops;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRegCost;
        private System.Windows.Forms.Label lblLodCost;
        private System.Windows.Forms.Label lblTotCost;
        private System.Windows.Forms.Button btnCalc;
    }
}

