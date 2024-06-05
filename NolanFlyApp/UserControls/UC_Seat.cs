using NolanFlyApp.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;

namespace NolanFlyApp.UserControls
{
    public partial class UC_Seat : UserControl
    {
        DbService _dbService = new DbService();
        List<string> selectedSeats = new List<string>();
        List<string> occupiedSeats = new List<string>();
        private int selectedFlightId;

        public void SetSelectedFlightId(int id)
        {
            selectedFlightId = id;
        }

        private static UC_Seat _instance;
        public static UC_Seat Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UC_Seat();
                }
                return _instance;
            }
        }

        public UC_Seat()
        {
            InitializeComponent();
        }

        private void ClearTheaterSeats()
        {
            foreach (Control control in Controls.OfType<Button>().ToList())
            {
                Controls.Remove(control);
                control.Dispose();
            }
        }

        public void GetFlight(int selectedFlight)
        {
            ClearTheaterSeats();
            selectedSeats.Clear();
            if (selectedFlight == 0)
            {
                lb_selectedSeats.Text = "Selected Seat(s):";
                return;
            }
            occupiedSeats = _dbService.GetOccupiedSeatsNoBasedOnFlightId(selectedFlight);
            CreateSeats(6, 25, occupiedSeats); // Adjusted rows and columns to match the image
            Instance.SetSelectedFlightId(selectedFlight);
        }

        private void CreateSeats(int rowCount, int columnCount, List<string> occupiedSeats)
        {
            const int seatGap = 5;
            const int seatWidth = 30;
            const int seatHeight = 30;
            const int aisleGap = 20;

            char[] letters = "ABCDEF".ToCharArray(); // Adjusted to match the image
            int totalWidth = columnCount * (seatWidth + seatGap) + aisleGap;
            int totalHeight = rowCount * (seatHeight + seatGap);
            int startX = 10;
            int startY = 10;

            for (int row = 0; row < rowCount; row++)
            {
                for (int col = 0; col < columnCount; col++)
                {
                    Button btnSeat = new Button();
                    btnSeat.Cursor = Cursors.Hand;
                    btnSeat.Name = $"btnSeat_{letters[row]}{col + 1}";
                    btnSeat.Text = $"{letters[row]}{col + 1}";

                    if (occupiedSeats.Contains(btnSeat.Text))
                    {
                        btnSeat.BackColor = Color.Blue;
                        btnSeat.ForeColor = Color.Black;
                    }
                    else if (selectedSeats.Contains(btnSeat.Text))
                    {
                        btnSeat.BackColor = Color.Red;
                        btnSeat.ForeColor = Color.Black;
                    }
                    else
                    {
                        btnSeat.BackColor = Color.White;
                        btnSeat.ForeColor = Color.Black;
                    }

                    btnSeat.Width = seatWidth;
                    btnSeat.Height = seatHeight;

                    if (col >= columnCount / 2)
                    {
                        btnSeat.Left = startX + col * (seatWidth + seatGap) + aisleGap;
                    }
                    else
                    {
                        btnSeat.Left = startX + col * (seatWidth + seatGap);
                    }

                    btnSeat.Top = startY + row * (seatHeight + seatGap);

                    btnSeat.Click += BtnSeat_Click;
                    Controls.Add(btnSeat);
                }
            }

            AddLegend(startX, startY + totalHeight + 20);
        }

        private void BtnSeat_Click(object sender, EventArgs e)
        {
            string seatName = ((Button)sender).Name;
            string seatNumber = seatName.Substring(seatName.IndexOf('_') + 1);

            if (selectedSeats.Contains(seatNumber))
            {
                selectedSeats.Remove(seatNumber);
            }
            else if (occupiedSeats.Contains(seatNumber))
            {
                MessageBox.Show("This seat is already taken!");
                return;
            }
            else
            {
                selectedSeats.Add(seatNumber);
            }

            if (selectedSeats.Contains(seatNumber))
            {
                ((Button)sender).BackColor = Color.Red;
            }
            else
            {
                ((Button)sender).BackColor = Color.White;
            }

            selectedSeats.Sort();
            lb_selectedSeats.Text = "Selected Seats: " + string.Join(", ", selectedSeats);
        }

        private void AddLegend(int startX, int startY)
        {
            Label lblSelected = new Label
            {
                Text = "Selected Seat",
                BackColor = Color.Red,
                Width = 100,
                Height = 30,
                Location = new Point(startX, startY)
            };

            Label lblOccupied = new Label
            {
                Text = "Occupied Seat",
                BackColor = Color.Blue,
                Width = 100,
                Height = 30,
                Location = new Point(startX + 120, startY)
            };

            Label lblAvailable = new Label
            {
                Text = "Available Seat",
                BackColor = Color.White,
                Width = 100,
                Height = 30,
                Location = new Point(startX + 240, startY)
            };

            Controls.Add(lblSelected);
            Controls.Add(lblOccupied);
            Controls.Add(lblAvailable);
        }

        private void pb_confirmSeats_Click(object sender, EventArgs e)
        {
            if (selectedSeats.Count == 0)
            {
                MessageBox.Show("Select a seat first!");
                return;
            }

            UC_Reservation.Instance.ReservationDetails(selectedFlightId, selectedSeats);
            UC_Reservation.Instance.GetSelectedSeats(selectedSeats);
            ((NolanFlyApplication)this.ParentForm).tab_Reservation_Click(null, null);
        }
    }
}
