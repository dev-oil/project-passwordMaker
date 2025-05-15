using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_passwordMaker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 기본값 설정 (선택)
            numeric_length.Minimum = 4;
            numeric_length.Maximum = 32;
            numeric_length.Value = 12;

            text_password.ReadOnly = true;

            // 전체 폼 스타일
            this.BackColor = Color.Black;
            this.ForeColor = Color.White;
            this.Font = new Font("맑은 고딕", 10, FontStyle.Regular);
            this.Text = "비밀번호 생성기";

            // 체크박스 등 텍스트 컨트롤 스타일
            foreach (var ctrl in this.Controls)
            {
                if (ctrl is Label lbl)
                {
                    lbl.ForeColor = Color.White;
                }
                else if (ctrl is CheckBox chk)
                {
                    chk.ForeColor = Color.White;
                    chk.BackColor = Color.Black;
                }
                else if (ctrl is NumericUpDown num)
                {
                    num.BackColor = Color.Black;
                    num.ForeColor = Color.White;
                }
                else if (ctrl is TextBox txt)
                {
                    txt.BackColor = Color.Black;
                    txt.ForeColor = Color.White;
                    txt.ReadOnly = true;
                    txt.BorderStyle = BorderStyle.FixedSingle;
                }
                else if (ctrl is Button btn)
                {
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.BackColor = Color.Black;
                    btn.ForeColor = Color.White;
                    btn.Font = new Font("맑은 고딕", 10, FontStyle.Bold);
                    btn.FlatAppearance.BorderColor = Color.White;
                    btn.FlatAppearance.BorderSize = 1;
                }
            }

        }

        private void button_generate_Click(object sender, EventArgs e)
        {
            int length = (int)numeric_length.Value;
            bool useUpper = check_upper.Checked;
            bool useNumber = check_number.Checked;
            bool useSpecial = check_special.Checked;

            string password = GeneratePassword(length, useUpper, useNumber, useSpecial);
            text_password.Text = password;
        }

        private string GeneratePassword(int length, bool upper, bool number, bool special)
        {
            if (length < 4)
                return "길이는 최소 4 이상!";

            string lowerChars = "abcdefghijklmnopqrstuvwxyz";
            string upperChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string numberChars = "0123456789";
            string specialChars = "!@#$%^&*()-_+=";

            List<char> passwordChars = new List<char>();
            StringBuilder charPool = new StringBuilder(lowerChars);

            Random rand = new Random();

            // 조건별 1개 보장
            if (upper)
            {
                passwordChars.Add(upperChars[rand.Next(upperChars.Length)]);
                charPool.Append(upperChars);
            }

            if (number)
            {
                passwordChars.Add(numberChars[rand.Next(numberChars.Length)]);
                charPool.Append(numberChars);
            }

            if (special)
            {
                passwordChars.Add(specialChars[rand.Next(specialChars.Length)]);
                charPool.Append(specialChars);
            }

            // 나머지 자리수 채우기
            while (passwordChars.Count < length)
            {
                passwordChars.Add(charPool[rand.Next(charPool.Length)]);
            }

            // 전체 섞기
            passwordChars = passwordChars.OrderBy(x => rand.Next()).ToList();

            return new string(passwordChars.ToArray());
        }


        private void button_copy_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(text_password.Text))
            {
                Clipboard.SetText(text_password.Text);
                MessageBox.Show("비밀번호가 복사되었습니다!", "복사 완료", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("복사할 비밀번호가 없습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void check_special_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}