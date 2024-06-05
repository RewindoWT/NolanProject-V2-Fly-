namespace NolanFlyApp.UserControls
{
    partial class UC_Reservation
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_confirmReservation = new System.Windows.Forms.Button();
            this.lb_totalPayment = new System.Windows.Forms.Label();
            this.lb_FlightDetails = new System.Windows.Forms.Label();
            this.lb_flightTime = new System.Windows.Forms.Label();
            this.lb_airline = new System.Windows.Forms.Label();
            this.lb_selectedSeatNo = new System.Windows.Forms.Label();
            this.lb_flightTo = new System.Windows.Forms.Label();
            this.lb_flightFrom = new System.Windows.Forms.Label();
            this.lb_planeId = new System.Windows.Forms.Label();
            this.lb_flightDate = new System.Windows.Forms.Label();
            this.lb_flightId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_confirmReservation
            // 
            this.btn_confirmReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_confirmReservation.Location = new System.Drawing.Point(438, 412);
            this.btn_confirmReservation.Name = "btn_confirmReservation";
            this.btn_confirmReservation.Size = new System.Drawing.Size(330, 36);
            this.btn_confirmReservation.TabIndex = 30;
            this.btn_confirmReservation.Text = "Complete Purchase";
            this.btn_confirmReservation.UseVisualStyleBackColor = true;
            this.btn_confirmReservation.Click += new System.EventHandler(this.pb_confirmReservation_Click);
            // 
            // lb_totalPayment
            // 
            this.lb_totalPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_totalPayment.Location = new System.Drawing.Point(438, 389);
            this.lb_totalPayment.Name = "lb_totalPayment";
            this.lb_totalPayment.Size = new System.Drawing.Size(330, 20);
            this.lb_totalPayment.TabIndex = 29;
            this.lb_totalPayment.Text = "Total Payment: 00 $";
            this.lb_totalPayment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_FlightDetails
            // 
            this.lb_FlightDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_FlightDetails.Location = new System.Drawing.Point(241, 14);
            this.lb_FlightDetails.Name = "lb_FlightDetails";
            this.lb_FlightDetails.Size = new System.Drawing.Size(309, 33);
            this.lb_FlightDetails.TabIndex = 22;
            this.lb_FlightDetails.Text = "Flight Details";
            // 
            // lb_flightTime
            // 
            this.lb_flightTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_flightTime.Location = new System.Drawing.Point(3, 261);
            this.lb_flightTime.Name = "lb_flightTime";
            this.lb_flightTime.Size = new System.Drawing.Size(309, 20);
            this.lb_flightTime.TabIndex = 39;
            this.lb_flightTime.Text = "Flight Time: ";
            // 
            // lb_airline
            // 
            this.lb_airline.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_airline.Location = new System.Drawing.Point(375, 200);
            this.lb_airline.Name = "lb_airline";
            this.lb_airline.Size = new System.Drawing.Size(309, 20);
            this.lb_airline.TabIndex = 38;
            this.lb_airline.Text = "Airline";
            // 
            // lb_selectedSeatNo
            // 
            this.lb_selectedSeatNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_selectedSeatNo.Location = new System.Drawing.Point(375, 264);
            this.lb_selectedSeatNo.Name = "lb_selectedSeatNo";
            this.lb_selectedSeatNo.Size = new System.Drawing.Size(321, 125);
            this.lb_selectedSeatNo.TabIndex = 37;
            this.lb_selectedSeatNo.Text = "Seat No(s): ";
            // 
            // lb_flightTo
            // 
            this.lb_flightTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_flightTo.Location = new System.Drawing.Point(375, 122);
            this.lb_flightTo.Name = "lb_flightTo";
            this.lb_flightTo.Size = new System.Drawing.Size(309, 20);
            this.lb_flightTo.TabIndex = 36;
            this.lb_flightTo.Text = "To Location";
            // 
            // lb_flightFrom
            // 
            this.lb_flightFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_flightFrom.Location = new System.Drawing.Point(375, 88);
            this.lb_flightFrom.Name = "lb_flightFrom";
            this.lb_flightFrom.Size = new System.Drawing.Size(309, 20);
            this.lb_flightFrom.TabIndex = 35;
            this.lb_flightFrom.Text = "From Location:";
            // 
            // lb_planeId
            // 
            this.lb_planeId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_planeId.Location = new System.Drawing.Point(375, 234);
            this.lb_planeId.Name = "lb_planeId";
            this.lb_planeId.Size = new System.Drawing.Size(309, 20);
            this.lb_planeId.TabIndex = 34;
            this.lb_planeId.Text = "Plane Id:";
            // 
            // lb_flightDate
            // 
            this.lb_flightDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_flightDate.Location = new System.Drawing.Point(3, 179);
            this.lb_flightDate.Name = "lb_flightDate";
            this.lb_flightDate.Size = new System.Drawing.Size(309, 20);
            this.lb_flightDate.TabIndex = 33;
            this.lb_flightDate.Text = "Flight Date: ";
            // 
            // lb_flightId
            // 
            this.lb_flightId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_flightId.Location = new System.Drawing.Point(3, 87);
            this.lb_flightId.Name = "lb_flightId";
            this.lb_flightId.Size = new System.Drawing.Size(309, 21);
            this.lb_flightId.TabIndex = 32;
            this.lb_flightId.Text = "Flight Id: ";
            // 
            // UC_Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lb_flightTime);
            this.Controls.Add(this.lb_airline);
            this.Controls.Add(this.lb_selectedSeatNo);
            this.Controls.Add(this.lb_flightTo);
            this.Controls.Add(this.lb_flightFrom);
            this.Controls.Add(this.lb_planeId);
            this.Controls.Add(this.lb_flightDate);
            this.Controls.Add(this.lb_flightId);
            this.Controls.Add(this.btn_confirmReservation);
            this.Controls.Add(this.lb_totalPayment);
            this.Controls.Add(this.lb_FlightDetails);
            this.Name = "UC_Reservation";
            this.Size = new System.Drawing.Size(784, 461);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_confirmReservation;
        private System.Windows.Forms.Label lb_totalPayment;
        private System.Windows.Forms.Label lb_FlightDetails;
        private System.Windows.Forms.Label lb_flightTime;
        private System.Windows.Forms.Label lb_airline;
        private System.Windows.Forms.Label lb_selectedSeatNo;
        private System.Windows.Forms.Label lb_flightTo;
        private System.Windows.Forms.Label lb_flightFrom;
        private System.Windows.Forms.Label lb_planeId;
        private System.Windows.Forms.Label lb_flightDate;
        private System.Windows.Forms.Label lb_flightId;
    }
}
