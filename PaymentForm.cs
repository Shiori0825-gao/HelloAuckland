using System;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace HelloAuckland   // ← 若命名空间不同请改这里
{
    public partial class PaymentForm : Form
    {
        private readonly BookingRequest _req;
        private TextBox tbName, tbCard, tbExpiry, tbCvc, tbEmail;
        private CheckBox cbAgree;
        private Button btnPay, btnCancel;
        private Label lblSummary, lblError;

        public PaymentResult Result { get; private set; }
        private readonly PaymentServiceMock _svc = new PaymentServiceMock();

        public PaymentForm(BookingRequest request)
        {
            InitializeComponent();       // 模板生成的方法，保留
            _req = request ?? new BookingRequest();

            ConfigureForm();
            BuildUi();
            WireEvents();

            RefreshSummary();
            ValidateForm();
        }

        private void ConfigureForm()
        {
            this.Text = "Payment (Mock) – Hello Auckland";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Size = new Size(720, 520);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
        }

        private void BuildUi()
        {
            var layout = new TableLayoutPanel();
            layout.Dock = DockStyle.Fill;
            layout.ColumnCount = 2;
            layout.RowCount = 8;
            layout.Padding = new Padding(16);
            layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48));
            layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 52));
            for (int i = 0; i < 8; i++) layout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            this.Controls.Add(layout);

            // 左侧：订单摘要
            lblSummary = new Label { AutoSize = true, Font = new Font("Segoe UI", 10) };
            var grp = new GroupBox { Text = "Booking Summary", Font = new Font("Segoe UI", 10, FontStyle.Bold), Padding = new Padding(10), Dock = DockStyle.Fill };
            grp.Controls.Add(lblSummary);
            layout.Controls.Add(grp, 0, 0);
            layout.SetRowSpan(grp, 6);

            // 右侧：表单
            tbName = new TextBox(); tbCard = new TextBox();
            tbExpiry = new TextBox(); tbCvc = new TextBox();
            tbEmail = new TextBox();

            layout.Controls.Add(MakeLabeled("Name on card", tbName), 1, 0);
            layout.Controls.Add(MakeLabeled("Card number", tbCard), 1, 1);
            layout.Controls.Add(MakeLabeled("Expiry (MM/YY)", tbExpiry), 1, 2);
            layout.Controls.Add(MakeLabeled("CVC", tbCvc), 1, 3);
            layout.Controls.Add(MakeLabeled("Email (optional)", tbEmail), 1, 4);

            cbAgree = new CheckBox { Text = "I agree to the Terms & Privacy (Mock payment – no real charge)." };
            layout.Controls.Add(cbAgree, 1, 5);

            lblError = new Label { AutoSize = true, ForeColor = Color.Firebrick };
            layout.Controls.Add(lblError, 1, 6);

            var btnPanel = new FlowLayoutPanel { FlowDirection = FlowDirection.RightToLeft, Dock = DockStyle.Fill };
            btnPay = new Button { Text = "Pay Now", Width = 120 };
            btnCancel = new Button { Text = "Cancel", Width = 100 };
            btnPanel.Controls.Add(btnPay);
            btnPanel.Controls.Add(btnCancel);
            layout.Controls.Add(btnPanel, 1, 7);
        }

        private Control MakeLabeled(string label, Control input)
        {
            var p = new Panel { Dock = DockStyle.Fill, Height = 58 };
            var l = new Label { Text = label, AutoSize = true, Location = new Point(0, 0) };
            input.Location = new Point(0, 22); input.Width = 300;
            p.Controls.Add(l); p.Controls.Add(input);
            return p;
        }

        private void WireEvents()
        {
            tbCard.TextChanged += delegate { FormatCard(); ValidateForm(); };
            tbExpiry.TextChanged += delegate { FormatExpiry(); ValidateForm(); };
            tbCvc.TextChanged += delegate { KeepDigits(tbCvc, 4); ValidateForm(); };
            tbName.TextChanged += delegate { ValidateForm(); };
            tbEmail.TextChanged += delegate { ValidateForm(); };
            cbAgree.CheckedChanged += delegate { ValidateForm(); };

            btnCancel.Click += delegate { this.DialogResult = DialogResult.Cancel; this.Close(); };
            btnPay.Click += BtnPay_Click;
        }

        private void RefreshSummary()
        {
            lblSummary.Text = string.Format(
                "Hotel: {0}\nRoom: {1}\nDates: {2:yyyy-MM-dd} → {3:yyyy-MM-dd}\nGuests: {4}\n\nTotal: NZD {5:F2}",
                _req.HotelName ?? "(Hotel)", _req.RoomType ?? "(Room)",
                _req.CheckIn, _req.CheckOut, _req.Guests, _req.PriceTotal);
        }

        // ---- 输入格式化与校验 ----
        private void FormatCard()
        {
            string digits = new string(tbCard.Text.Where(char.IsDigit).ToArray());
            if (digits.Length > 19) digits = digits.Substring(0, 19);
            string grouped = "";
            for (int i = 0; i < digits.Length; i++) { if (i > 0 && i % 4 == 0) grouped += " "; grouped += digits[i]; }
            tbCard.Text = grouped;
            tbCard.SelectionStart = tbCard.Text.Length;
        }

        private void FormatExpiry()
        {
            string digits = new string(tbExpiry.Text.Where(char.IsDigit).ToArray());
            if (digits.Length > 4) digits = digits.Substring(0, 4);
            tbExpiry.Text = digits.Length >= 3 ? digits.Substring(0, 2) + "/" + digits.Substring(2) : digits;
            tbExpiry.SelectionStart = tbExpiry.Text.Length;
        }

        private void KeepDigits(TextBox tb, int maxLen)
        {
            string digits = new string(tb.Text.Where(char.IsDigit).ToArray());
            if (digits.Length > maxLen) digits = digits.Substring(0, maxLen);
            tb.Text = digits; tb.SelectionStart = tb.Text.Length;
        }

        private void ValidateForm()
        {
            lblError.Text = ""; btnPay.Enabled = false;

            string name = tbName.Text.Trim();
            string cardDigits = new string(tbCard.Text.Where(char.IsDigit).ToArray());
            string exp = tbExpiry.Text.Trim();
            string cvc = tbCvc.Text.Trim();
            string email = tbEmail.Text.Trim();

            if (name.Length < 2) { lblError.Text = "Please enter the card holder name."; return; }
            if (cardDigits.Length < 12 || cardDigits.Length > 19) { lblError.Text = "Please enter a valid card number."; return; }
            if (!PaymentServiceMock.LuhnCheck(cardDigits)) { lblError.Text = "Card number failed Luhn check."; return; }
            if (!PaymentServiceMock.IsValidExpiry(exp)) { lblError.Text = "Invalid expiry. Use MM/YY and future date."; return; }
            if (cvc.Length < 3 || cvc.Length > 4) { lblError.Text = "Invalid CVC."; return; }
            if (email.Length > 0 && !Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$")) { lblError.Text = "Invalid email format."; return; }
            if (!cbAgree.Checked) { lblError.Text = "Please agree to Terms & Privacy."; return; }

            btnPay.Enabled = true;
        }

        private void BtnPay_Click(object sender, EventArgs e)
        {
            try
            {
                string name = tbName.Text.Trim();
                string cardDigits = new string(tbCard.Text.Where(char.IsDigit).ToArray());
                string exp = tbExpiry.Text.Trim();
                string cvc = tbCvc.Text.Trim();

                var pay = _svc.Pay(cardDigits, name, exp, cvc, _req.PriceTotal);
                Result = pay;

                // 成功 → 弹出确认页
                new BookingConfirmationForm(_req, Result).ShowDialog(this);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }
    }
}
