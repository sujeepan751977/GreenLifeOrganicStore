namespace GreenLifeOrganicStore.Forms
{
    partial class ReviewForm
    {

        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dgvReviews;

        private System.Windows.Forms.Label lblProductName;

        private System.Windows.Forms.Panel pnlAddReview;

        private System.Windows.Forms.NumericUpDown nudRating;

        private System.Windows.Forms.TextBox txtComment;

        private System.Windows.Forms.Label lblRating;

        private System.Windows.Forms.Label lblComment;

        private System.Windows.Forms.Button btnSubmit;

        private System.Windows.Forms.Button btnBack;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvReviews = new System.Windows.Forms.DataGridView();
            this.lblProductName = new System.Windows.Forms.Label();
            this.pnlAddReview = new System.Windows.Forms.Panel();
            this.nudRating = new System.Windows.Forms.NumericUpDown();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.lblRating = new System.Windows.Forms.Label();
            this.lblComment = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReviews)).BeginInit();
            this.pnlAddReview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRating)).BeginInit();
            this.SuspendLayout();
            // lblProductName
            this.lblProductName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblProductName.Location = new System.Drawing.Point(20, 20);
            this.lblProductName.Size = new System.Drawing.Size(560, 30);
            this.lblProductName.Text = "Product Reviews";
            // dgvReviews
            this.dgvReviews.Location = new System.Drawing.Point(20, 60);
            this.dgvReviews.Size = new System.Drawing.Size(560, 250);
            // pnlAddReview
            this.pnlAddReview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAddReview.Controls.Add(this.lblRating);
            this.pnlAddReview.Controls.Add(this.nudRating);
            this.pnlAddReview.Controls.Add(this.lblComment);
            this.pnlAddReview.Controls.Add(this.txtComment);
            this.pnlAddReview.Controls.Add(this.btnSubmit);
            this.pnlAddReview.Location = new System.Drawing.Point(20, 320);
            this.pnlAddReview.Size = new System.Drawing.Size(560, 160);
            // lblRating
            this.lblRating.Location = new System.Drawing.Point(10, 15);
            this.lblRating.Size = new System.Drawing.Size(80, 20);
            this.lblRating.Text = "Rating (1-5):";
            // nudRating
            this.nudRating.Location = new System.Drawing.Point(100, 13);
            this.nudRating.Size = new System.Drawing.Size(50, 25);
            this.nudRating.Minimum = 1;
            this.nudRating.Maximum = 5;
            this.nudRating.Maximum = 5;
            // lblComment
            this.lblComment.Location = new System.Drawing.Point(10, 50);
            this.lblComment.Size = new System.Drawing.Size(80, 20);
            this.lblComment.Text = "Comment:";
            // txtComment
            this.txtComment.Location = new System.Drawing.Point(100, 50);
            this.txtComment.Size = new System.Drawing.Size(440, 60);
            this.txtComment.Multiline = true;
            // btnSubmit
            this.btnSubmit.Location = new System.Drawing.Point(420, 120);
            this.btnSubmit.Size = new System.Drawing.Size(120, 30);
            this.btnSubmit.Text = "Post Review";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // btnBack
            this.btnBack.Location = new System.Drawing.Point(20, 490);
            this.btnBack.Size = new System.Drawing.Size(100, 30);
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 540);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pnlAddReview);
            this.Controls.Add(this.dgvReviews);
            this.Controls.Add(this.lblProductName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ReviewForm";
            this.Text = "Product Reviews";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReviews)).EndInit();
            this.pnlAddReview.ResumeLayout(false);
            this.pnlAddReview.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRating)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
