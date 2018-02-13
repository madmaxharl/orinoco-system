namespace Room_Booking_CSharp_
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
            this.calBookingDate = new System.Windows.Forms.MonthCalendar();
            this.tblRoomAvailability = new System.Windows.Forms.TableLayoutPanel();
            this.btnQuery = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // calBookingDate
            // 
            this.calBookingDate.Location = new System.Drawing.Point(18, 18);
            this.calBookingDate.Name = "calBookingDate";
            this.calBookingDate.TabIndex = 0;
            // 
            // tblRoomAvailability
            // 
            this.tblRoomAvailability.ColumnCount = 6;
            this.tblRoomAvailability.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblRoomAvailability.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblRoomAvailability.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblRoomAvailability.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblRoomAvailability.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblRoomAvailability.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblRoomAvailability.Location = new System.Drawing.Point(283, 18);
            this.tblRoomAvailability.Name = "tblRoomAvailability";
            this.tblRoomAvailability.RowCount = 5;
            this.tblRoomAvailability.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblRoomAvailability.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblRoomAvailability.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblRoomAvailability.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblRoomAvailability.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblRoomAvailability.Size = new System.Drawing.Size(552, 268);
            this.tblRoomAvailability.TabIndex = 1;
            this.tblRoomAvailability.Paint += new System.Windows.Forms.PaintEventHandler(this.tblRoomAvailability_Paint);
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(18, 193);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 2;
            this.btnQuery.Text = "Query";
            this.btnQuery.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 446);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.tblRoomAvailability);
            this.Controls.Add(this.calBookingDate);
            this.Name = "Form1";
            this.Text = "FrmBooking";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar calBookingDate;
        private System.Windows.Forms.TableLayoutPanel tblRoomAvailability;
        private System.Windows.Forms.Button btnQuery;
    }
}

