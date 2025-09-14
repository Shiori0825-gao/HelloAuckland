using System;
using System.Drawing;
using System.Windows.Forms;

namespace HelloAuckland   // ← 若命名空间不同请改这里
{
    public partial class BookingConfirmationForm : Form
    {
        private readonly BookingRequest _req;
        private readonly PaymentResult _res;

        public BookingConfirmationForm(BookingRequest req, PaymentResult res)
        {
            InitializeComponent();    // 模板生成的方法，保留
            _req = req ?? new BookingRequest();
            _res = res ?? new PaymentResult();

            ConfigureForm();
            BuildUi();
        }

        private void ConfigureForm()
        {
            this.Text = "Booking Confirmed – Hello Auckland";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Size = new Size(560, 380);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
        }

        private void BuildUi()
        {
            var panel = new TableLayoutPanel { Dock = DockStyle.Fill, Padding = new Padding(16), RowCount = 6 };
            for (int i = 0; i < 6; i++) panel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            this.Controls.Add(panel);

            var title = new Label { Text = "Booking Confirmed", Font = new Font("Segoe UI", 18, FontStyle.Bold), AutoSize = true };
            panel.Controls.Add(title);

            var info = new Label { AutoSize = true };
            info.Text = string.Format(
                "Hotel: {0}\nRoom: {1}\nDates: {2:yyyy-MM-dd} → {3:yyyy-MM-dd}\nGuests: {4}\n\nPaid: NZD {5:F2}\nAuth: {6}  (**** **** **** {7})\nTime: {8}",
                _req.HotelName ?? "(Hotel)", _req.RoomType ?? "(Room)",
                _req.CheckIn, _req.CheckOut, _req.Guests,
                _res.Amount, _res.AuthorizationCode, _res.Last4, _res.PaidAt);
            panel.Controls.Add(info);

            var ok = new Button { Text = "Back to Home", Width = 140 };
            ok.Click += delegate { this.Close(); };
            panel.Controls.Add(ok);
        }
    }
}

