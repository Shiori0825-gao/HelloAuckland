using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace HelloAuckland
{
    public partial class Form1 : Form
    {
        private PictureBox picHero;
        private Panel panelHeroText;
        private Label lblWelcome, lblMaori;
        private Button btnSignUp, btnLogin;
        private TableLayoutPanel gridCards;

        public Form1()
        {
            InitializeComponent();


            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint, true);
            this.DoubleBuffered = true;


            this.Text = "Hello Auckland";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MinimumSize = new Size(1500, 1264);
            this.AutoScaleMode = AutoScaleMode.Dpi;
            this.BackColor = Color.Black;

            BuildUi();
            WireEvents();
        }


        private void Form1_Load(object sender, EventArgs e) { }

        private void BuildUi()
        {
            // 1) 英雄背景图
            picHero = new PictureBox();
            picHero.Dock = DockStyle.Fill;
            picHero.SizeMode = PictureBoxSizeMode.Zoom;   // 保持比例
            picHero.BackColor = Color.Black;
            picHero.Image = LoadAsset("hero_auckland.png");
            this.Controls.Add(picHero);

            // 2) 底部四卡片容器
            gridCards = new TableLayoutPanel();
            gridCards.Dock = DockStyle.Bottom;
            gridCards.Height = 260;
            gridCards.ColumnCount = 4;
            gridCards.RowCount = 1;
            gridCards.Padding = new Padding(12);
            gridCards.BackColor = Color.Transparent;
            for (int i = 0; i < 4; i++)
                gridCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25f));
            gridCards.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
            this.Controls.Add(gridCards);

            // 3) 欢迎语半透明块
            panelHeroText = new Panel();
            panelHeroText.BackColor = Color.FromArgb(140, 30, 30, 30);
            panelHeroText.Size = new Size(560, 220);
            panelHeroText.Location = new Point(90, 120);

            lblWelcome = new Label();
            lblWelcome.Text = "Welcome to Auckland";
            lblWelcome.AutoSize = true;
            lblWelcome.ForeColor = Color.White;
            lblWelcome.Font = new Font("Segoe UI", 32, FontStyle.Bold);
            lblWelcome.Location = new Point(24, 28);

            lblMaori = new Label();
            lblMaori.Text = "Nau mai ki Tāmaki Makaurau!";
            lblMaori.AutoSize = true;
            lblMaori.ForeColor = Color.White;
            lblMaori.Font = new Font("Segoe UI", 16, FontStyle.Regular);
            lblMaori.Location = new Point(24, 100);

            panelHeroText.Controls.Add(lblWelcome);
            panelHeroText.Controls.Add(lblMaori);
            this.Controls.Add(panelHeroText);

            // 4) 右上按钮
            btnSignUp = new Button();
            btnSignUp.Text = "Sign-up";
            btnSignUp.Size = new Size(110, 38);
            btnSignUp.BackColor = Color.FromArgb(215, 215, 215);
            btnSignUp.FlatStyle = FlatStyle.Flat;
            btnSignUp.FlatAppearance.BorderSize = 0;
            btnSignUp.ForeColor = Color.WhiteSmoke;
            btnSignUp.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            btnLogin = new Button();
            btnLogin.Text = "Login";
            btnLogin.Size = new Size(110, 38);
            btnLogin.BackColor = Color.FromArgb(170, 170, 170);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.ForeColor = Color.WhiteSmoke;
            btnLogin.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            this.Controls.Add(btnSignUp);
            this.Controls.Add(btnLogin);

            // 右上角定位（跟随窗口大小）
            this.Resize += delegate
            {
                btnSignUp.Left = this.ClientSize.Width - btnSignUp.Width - 20;
                btnSignUp.Top = 18;
                btnLogin.Left = this.ClientSize.Width - btnLogin.Width - 20;
                btnLogin.Top = 66;
            };
            // 触发一次
            btnSignUp.Left = this.ClientSize.Width - btnSignUp.Width - 20;
            btnSignUp.Top = 18;
            btnLogin.Left = this.ClientSize.Width - btnLogin.Width - 20;
            btnLogin.Top = 66;

            // 5) 四张卡片
            gridCards.Controls.Add(CreateCard("city_info.png", "CITY INFO"), 0, 0);
            gridCards.Controls.Add(CreateCard("see_do.png", "SEE & DO"), 1, 0);
            gridCards.Controls.Add(CreateCard("food.png", "FOOD"), 2, 0);
            gridCards.Controls.Add(CreateCard("stay.png", "STAY"), 3, 0);
        }

        private Panel CreateCard(string fileName, string section)
        {
            Panel card = new Panel();
            card.Dock = DockStyle.Fill;
            card.Margin = new Padding(6);
            card.Tag = "card";
            card.AccessibleDescription = section;

            PictureBox pic = new PictureBox();
            pic.Dock = DockStyle.Fill;
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            pic.Image = LoadAsset(fileName);

            Panel overlay = new Panel();
            overlay.Name = "overlay";
            overlay.Dock = DockStyle.Fill;
            overlay.BackColor = Color.FromArgb(100, 0, 0, 0); // 略暗；Hover 时变亮

            // 先加底图再加遮罩
            card.Controls.Add(pic);
            card.Controls.Add(overlay);

            BindCardEvents(card);
            return card;
        }

        private void BindCardEvents(Panel card)
        {
            Action<Control> bind = null;
            bind = c =>
            {
                c.MouseEnter += Card_MouseEnter;
                c.MouseLeave += Card_MouseLeave;
                c.Click += Card_Click;
                foreach (Control ch in c.Controls) bind(ch);
            };
            bind(card);
        }

        private void Card_MouseEnter(object sender, EventArgs e)
        {
            Panel card = FindCard(sender);
            if (card == null) return;

            card.Cursor = Cursors.Hand;
            card.Padding = new Padding(3); // 白边
            card.BackColor = Color.White;

            Panel overlay = card.Controls["overlay"] as Panel;
            if (overlay != null) overlay.BackColor = Color.FromArgb(40, 0, 0, 0); // 变亮
        }

        private void Card_MouseLeave(object sender, EventArgs e)
        {
            Panel card = FindCard(sender);
            if (card == null) return;

            card.Cursor = Cursors.Default;
            card.Padding = new Padding(0);
            card.BackColor = Color.Transparent;

            Panel overlay = card.Controls["overlay"] as Panel;
            if (overlay != null) overlay.BackColor = Color.FromArgb(100, 0, 0, 0); // 恢复
        }

        private void Card_Click(object sender, EventArgs e)
        {
            Panel card = FindCard(sender);
            if (card == null) return;

            string section = card.AccessibleDescription ?? "";

            // 这里把模块映射到你仓库里的窗体（Form2/3/4）
            try
            {
                switch (section)
                {
                    case "CITY INFO":
                        new Form2().Show(); // 机场进城 & AT HOP 可在 Form2 里继续做
                        break;
                    case "SEE & DO":
                        new Form3().Show();
                        break;
                    case "FOOD":
                        new Form4().Show();
                        break;
                    case "STAY":
                        new Form4().Show(); // 也可改成 Form5（若你将来新增）
                        break;
                    default:
                        MessageBox.Show("Open section: " + section);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Navigation error: " + ex.Message);
            }
        }

        private Panel FindCard(object sender)
        {
            Control c = sender as Control;
            while (c != null)
            {
                Panel p = c as Panel;
                if (p != null && (string)p.Tag == "card") return p;
                c = c.Parent;
            }
            return null;
        }

        // 从 assets 目录读取图片（确保图片属性：Copy to Output Directory = Copy always）
        private Image LoadAsset(string fileName)
        {
            string baseDir = AppDomain.CurrentDomain.BaseDirectory; // 更稳的运行目录
            string path = Path.Combine(baseDir, "images", fileName);

            if (!File.Exists(path))
            {
                MessageBox.Show(
                    "Image not found:\n" + path + "\n\n" +
                    "请检查 assets 是否在输出目录中（属性：Copy always）。",
                    "Missing asset", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // 占位图，避免黑屏
                Bitmap bmp = new Bitmap(800, 450);
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    g.Clear(Color.DimGray);
                    g.DrawString("Missing image:\n" + fileName,
                        new Font("Segoe UI", 16), Brushes.White, new RectangleF(20, 20, 760, 410));
                }
                return bmp;
            }

            return Image.FromFile(path);
        }

        private void WireEvents()
        {
            btnSignUp.Click += (s, e) => MessageBox.Show("Open: Sign-up");
            btnLogin.Click += (s, e) => MessageBox.Show("Open: Login");
        }
    }
}
