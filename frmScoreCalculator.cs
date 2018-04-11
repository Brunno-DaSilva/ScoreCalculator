/*
 *Author: Bruno Leandro DaSilva 
 *Course: ITSE-1330.WW1: Introduction to C# Programming  
 * Date: 09/08/2017
 * Application: Score Calculator - Project 1
 * Description: This Application Adds Score values and displayes the Total Score, Count,
 * and average of a given set of scores. Additionally, the user can clear the scores 
 * entered and Exit the application.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScoreCalculator
{
    public partial class frmScoreCalculator : Form
    {
        private List<int> Scores = new List<int>();
        private int total = 0;
        private float average = 0F;

        public frmScoreCalculator()
        {
            InitializeComponent();
        }

        private float CalculateAverage(int sum, int n)
        {
            return (float)sum / (float)n; 
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            int score = Convert.ToInt32(txtScore.Text);

            Scores.Add(score);

           
            total += score;
            txtTotal.Text = total.ToString();

            txtCount.Text = Scores.Count.ToString();

            average = CalculateAverage(total, Scores.Count);
            txtAverage.Text = average.ToString("0.0");

            txtScore.Text = string.Empty;
            txtScore.Focus();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Scores.Clear();
            total = 0;
            average = 0F;

            txtTotal.Text = total.ToString();
            txtCount.Text = Scores.Count.ToString();
            txtAverage.Text = average.ToString();
            txtScore.Focus();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
