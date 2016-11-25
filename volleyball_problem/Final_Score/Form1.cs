using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Score
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TxtHasil.Enabled = false;
        }

        public const int Modular = 1000000007;

        public void Swap(ref int A, ref int B) { int temp = B; B = A; A = temp; }

        public long Prob(int A, int B) {
            if (!((A >= 25 && B == A - 2) || (A == 25 && B < 24))) { return 0; }
            else {
                if (A > 26) {
                    long result = nCr(48, 24);
                    A -= 24; B -= 24;
                    result = result ^ nCr(A + B - 1, B);
                    return result;
                }
                else {
                    A += B; A -= 1;
                    return nCr(A, B);
                }
            }
        }


        public long[] FactorialDivision(int numerator, int denominator) {
            long[] numer = new long[numerator];
            long[] denomin = new long[denominator];
            for (int i = 0; i < numerator; i++) { numer[i] = numerator - i; }
            for (int j = 0; j < denominator; j++) { denomin[j] = denominator - j; }
            for (int i = 0; i < numer.Length; i++) {
                for (int j = 0; j < denomin.Length; j++) {
                    if ((numer[i] != 1 && denomin[j] != 1) && (numer[i] == denomin[j])) {
                        numer[i] = 1;
                        denomin[j] = 1;
                        break;
                    }
                }
            }
            return numer;
        }

        public long nCr(int n, int r) {
            long result = 1;
            long[] numer = FactorialDivision(n, n - r);
            long[] denomin = new long[r];
            for (int j = 0; j < r; j++) { denomin[j] = r - j; }
            for (int i = 0; i < numer.Length; i++) {
                for (int j = 0; j < denomin.Length; j++) {
                    if (denomin[j] != 1 && (numer[i] % denomin[j] == 0)) {
                        numer[i] /= denomin[j]; denomin[j] = 1; break;
                    }
                }
            }
            for (int i = 0; i < numer.Length; i++) { result *= numer[i]; }
            for (int i = 0; i < denomin.Length; i++) { result /= denomin[i]; }
            return result;
        }

        private void BtnHitung_Click(object sender, EventArgs e) {
            int A, B;
            A = int.Parse(Txt1.Text);
            B = int.Parse(Txt2.Text);
            if (A < B) { Swap(ref A, ref B); }
            long probability = Prob(A, B);
            if (probability > Modular) { probability %= Modular; }
            TxtHasil.Text = probability + "";
        }
    }
}
