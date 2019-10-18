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
            this.components = new System.ComponentModel.Container();
            this.cpb_loading = new XanderUI.XUICircleProgressBar();
            this.timer_loading = new System.Windows.Forms.Timer(this.components);
            this.lbLoading = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SuspendLayout();
            // 
            // cpb_loading
            // 
            this.cpb_loading.AnimationSpeed = 5;
            this.cpb_loading.FilledColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(220)))), ((int)(((byte)(210)))));
            this.cpb_loading.FilledColorAlpha = 130;
            this.cpb_loading.FilledThickness = 40;
            this.cpb_loading.IsAnimated = false;
            this.cpb_loading.Location = new System.Drawing.Point(151, 14);
            this.cpb_loading.Name = "cpb_loading";
            this.cpb_loading.Percentage = 0;
            this.cpb_loading.ShowText = true;
            this.cpb_loading.Size = new System.Drawing.Size(145, 142);
            this.cpb_loading.TabIndex = 0;
            this.cpb_loading.TextColor = System.Drawing.Color.Gray;
            this.cpb_loading.TextSize = 25;
            this.cpb_loading.UnFilledColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            this.cpb_loading.UnfilledThickness = 24;
            // 
            // timer_loading
            // 
            this.timer_loading.Enabled = true;
            this.timer_loading.Interval = 600;
            this.timer_loading.Tick += new System.EventHandler(this.timer_loading_Tick);
            // 
            // lbLoading
            // 
            this.lbLoading.AutoSize = true;
            this.lbLoading.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoading.ForeColor = System.Drawing.Color.Navy;
            this.lbLoading.Location = new System.Drawing.Point(148, 174);
            this.lbLoading.Name = "lbLoading";
            this.lbLoading.Size = new System.Drawing.Size(172, 16);
            this.lbLoading.TabIndex = 1;
            this.lbLoading.Text = "Bạn đợi tôi một chút nhé";
            // 
            // frmHandling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 199);
            this.Controls.Add(this.lbLoading);
            this.Controls.Add(this.cpb_loading);
            this.Name = "frmHandling";
            this.Text = "frmHandling";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private XanderUI.XUICircleProgressBar cpb_loading;
        private System.Windows.Forms.Timer timer_loading;
        private Bunifu.Framework.UI.BunifuCustomLabel lbLoading;
    }
}