namespace QUANLYLINHKIEN_PTUD
{
    partial class frmHandling
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHandling));
            this.cpb_loading = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.lb_Loading = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cpb_loading
            // 
            this.cpb_loading.animated = false;
            this.cpb_loading.animationIterval = 5;
            this.cpb_loading.animationSpeed = 300;
            this.cpb_loading.BackColor = System.Drawing.Color.White;
            this.cpb_loading.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cpb_loading.BackgroundImage")));
            this.cpb_loading.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.cpb_loading.ForeColor = System.Drawing.Color.SeaGreen;
            this.cpb_loading.LabelVisible = true;
            this.cpb_loading.LineProgressThickness = 8;
            this.cpb_loading.LineThickness = 5;
            this.cpb_loading.Location = new System.Drawing.Point(219, 18);
            this.cpb_loading.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.cpb_loading.MaxValue = 100;
            this.cpb_loading.Name = "cpb_loading";
            this.cpb_loading.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.cpb_loading.ProgressColor = System.Drawing.Color.SeaGreen;
            this.cpb_loading.Size = new System.Drawing.Size(121, 121);
            this.cpb_loading.TabIndex = 0;
            this.cpb_loading.Value = 63;
            // 
            // lb_Loading
            // 
            this.lb_Loading.AutoSize = true;
            this.lb_Loading.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Loading.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lb_Loading.Location = new System.Drawing.Point(143, 148);
            this.lb_Loading.Name = "lb_Loading";
            this.lb_Loading.Size = new System.Drawing.Size(305, 19);
            this.lb_Loading.TabIndex = 1;
            this.lb_Loading.Text = "Bạn vui lòng đợi chúng tôi một chút nhé";
            // 
            // frmHandling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 191);
            this.Controls.Add(this.lb_Loading);
            this.Controls.Add(this.cpb_loading);
            this.Name = "frmHandling";
            this.Text = "frmHandling";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCircleProgressbar cpb_loading;
        private System.Windows.Forms.Label lb_Loading;
    }
}