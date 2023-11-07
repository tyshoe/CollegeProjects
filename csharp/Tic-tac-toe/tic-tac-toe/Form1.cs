//this does not have player class in it but i did not see a need for it. You can very easily do it without it.
//need to fix condition for when player whens but you can still play... button disable code?
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tic_tac_toe
{
    
    public partial class Character_setup_form : Form
    {
        public static string p1_name = "";
        public static string p2_name = "";
        //default colors
        public static Color p1_box_color = Color.LightBlue;
        public static Color p2_box_color = Color.IndianRed;
        public static Color p1_ch_color = Color.DarkBlue;
        public static Color p2_ch_color = Color.DarkRed;
        //default symbols
        public static string p1_sym;
        public static string p2_sym;

        public Character_setup_form()
        {
            InitializeComponent();
        }
            
        //player 1 settings
        private bool p1_ready_state;
        //tile color button
        private void tilecolor_btn_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Color color = colorDialog1.Color;
                tilecolor_btn.BackColor = color;
                //set player 1 back color in game form
                p1_box_color = color;
            }
        }
        //character color button
        private void chcolor_btn_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Color color = colorDialog1.Color;
                chcolor_btn.BackColor = color;
                //set player 1 character color in game form
                p1_ch_color = color;
            }
        }
        //character select
        public void select_color_p1()
        {
            if (p1_sym == p1star_btn.Text)
            {
                p1star_btn.BackColor = Color.Green;
                p1smile_btn.BackColor = Color.LightBlue;
                p1snwflk_btn.BackColor = Color.LightBlue;
                p1drop_btn.BackColor = Color.LightBlue;
                p1sun_btn.BackColor = Color.LightBlue;
                p1hand_btn.BackColor = Color.LightBlue;
                p1mouse_btn.BackColor = Color.LightBlue;
                p1comp_btn.BackColor = Color.LightBlue;
            }
            else if (p1_sym == p1smile_btn.Text)
            {

                p1star_btn.BackColor = Color.LightBlue;
                p1smile_btn.BackColor = Color.Green;
                p1snwflk_btn.BackColor = Color.LightBlue;
                p1drop_btn.BackColor = Color.LightBlue;
                p1sun_btn.BackColor = Color.LightBlue;
                p1hand_btn.BackColor = Color.LightBlue;
                p1mouse_btn.BackColor = Color.LightBlue;
                p1comp_btn.BackColor = Color.LightBlue;
            }
            else if (p1_sym == p1snwflk_btn.Text)
            {
                p1star_btn.BackColor = Color.LightBlue;
                p1smile_btn.BackColor = Color.LightBlue;
                p1snwflk_btn.BackColor = Color.Green;
                p1drop_btn.BackColor = Color.LightBlue;
                p1sun_btn.BackColor = Color.LightBlue;
                p1hand_btn.BackColor = Color.LightBlue;
                p1mouse_btn.BackColor = Color.LightBlue;
                p1comp_btn.BackColor = Color.LightBlue;
            }
            else if (p1_sym == p1drop_btn.Text)
            {
                p1star_btn.BackColor = Color.LightBlue;
                p1smile_btn.BackColor = Color.LightBlue;
                p1snwflk_btn.BackColor = Color.LightBlue;
                p1drop_btn.BackColor = Color.Green;
                p1sun_btn.BackColor = Color.LightBlue;
                p1hand_btn.BackColor = Color.LightBlue;
                p1mouse_btn.BackColor = Color.LightBlue;
                p1comp_btn.BackColor = Color.LightBlue;
            }
            else if (p1_sym == p1sun_btn.Text)
            {
                p1star_btn.BackColor = Color.LightBlue;
                p1smile_btn.BackColor = Color.LightBlue;
                p1snwflk_btn.BackColor = Color.LightBlue;
                p1drop_btn.BackColor = Color.LightBlue;
                p1sun_btn.BackColor = Color.Green;
                p1hand_btn.BackColor = Color.LightBlue;
                p1mouse_btn.BackColor = Color.LightBlue;
                p1comp_btn.BackColor = Color.LightBlue;
            }
            else if (p1_sym == p1hand_btn.Text)
            {
                p1star_btn.BackColor = Color.LightBlue;
                p1smile_btn.BackColor = Color.LightBlue;
                p1snwflk_btn.BackColor = Color.LightBlue;
                p1drop_btn.BackColor = Color.LightBlue;
                p1sun_btn.BackColor = Color.LightBlue;
                p1hand_btn.BackColor = Color.Green;
                p1mouse_btn.BackColor = Color.LightBlue;
                p1comp_btn.BackColor = Color.LightBlue;
            }
            else if (p1_sym == p1mouse_btn.Text)
            {
                p1star_btn.BackColor = Color.LightBlue;
                p1smile_btn.BackColor = Color.LightBlue;
                p1snwflk_btn.BackColor = Color.LightBlue;
                p1drop_btn.BackColor = Color.LightBlue;
                p1sun_btn.BackColor = Color.LightBlue;
                p1hand_btn.BackColor = Color.LightBlue;
                p1mouse_btn.BackColor = Color.Green;
                p1comp_btn.BackColor = Color.LightBlue;
            }
            else if (p1_sym == p1comp_btn.Text)
            {
                p1star_btn.BackColor = Color.LightBlue;
                p1smile_btn.BackColor = Color.LightBlue;
                p1snwflk_btn.BackColor = Color.LightBlue;
                p1drop_btn.BackColor = Color.LightBlue;
                p1sun_btn.BackColor = Color.LightBlue;
                p1hand_btn.BackColor = Color.LightBlue;
                p1mouse_btn.BackColor = Color.LightBlue;
                p1comp_btn.BackColor = Color.Green;
            }
        }
        //ready up button
        private void ready1_btn_Click(object sender, EventArgs e)
        {
            
            p1_ready_state = !p1_ready_state;

            if (p1_ready_state == true)
            {
                ready1_btn.BackColor = Color.Green;
                ready1_btn.Text = $"{p1name.Text} Ready!";
                select_color_p1();

            }
            else if (p1_ready_state == false)
            {
                ready1_btn.BackColor = Color.Red;
                ready1_btn.Text = $"{p1name.Text} not Ready!";
            }
            p1_name = p1name.Text;
            p1_box_color = tilecolor_btn.BackColor;
            //when ready button is pushed, check ready state of both players and make sure symbols are different. if all true, start game
            if (p1_ready_state == true && p2_ready_state == true && p1_sym != p2_sym)
            {
                //closes form 1
                this.Hide();
                //open form 2
                Form frm = new Tic_Tac_toe_form();
                frm.ShowDialog();
            }

        }
        //character buttons
        private void p1star_btn_Click(object sender, EventArgs e)
        {
            p1_sym = p1star_btn.Text;
        }
        private void p1smile_btn_Click(object sender, EventArgs e)
        {
            p1_sym = p1smile_btn.Text;
        }
        private void p1snwflk_btn_Click(object sender, EventArgs e)
        {
            p1_sym = p1snwflk_btn.Text;
        }
        private void p1drop_btn_Click(object sender, EventArgs e)
        {
            p1_sym = p1drop_btn.Text;
        }
        private void p1sun_btn_Click(object sender, EventArgs e)
        {
            p1_sym = p1sun_btn.Text;
        }
        private void p1hand_btn_Click(object sender, EventArgs e)
        {
            p1_sym = p1hand_btn.Text;
        }
        private void p1mouse_btn_Click(object sender, EventArgs e)
        {
            p1_sym = p1mouse_btn.Text;
        }
        private void p1comp_btn_Click(object sender, EventArgs e)
        {
            p1_sym = p1comp_btn.Text;
        }



        //player 2 settings
        private bool p2_ready_state;
        //tile color button
        private void tilecolor2_btn_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Color color = colorDialog1.Color;
                tilecolor2_btn.BackColor = color;
                //set player 2 back color in game form
                p2_box_color = color;
            }
        }
        //character color button
        private void chcolor2_btn_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Color color = colorDialog1.Color;
                chcolor2_btn.BackColor = color;
                //set player 2 character color in game form
                p2_ch_color = color;
            }
        }
        //character select
        public void select_color_p2()
        {
            if (p2_sym == p2star_btn.Text)
            {
                p2star_btn.BackColor = Color.Green;
                p2smile_btn.BackColor = Color.IndianRed;
                p2snwflk_btn.BackColor = Color.IndianRed;
                p2drop_btn.BackColor = Color.IndianRed;
                p2sun_btn.BackColor = Color.IndianRed;
                p2hand_btn.BackColor = Color.IndianRed;
                p2mouse_btn.BackColor = Color.IndianRed;
                p2comp_btn.BackColor = Color.IndianRed;
            }
            else if (p2_sym == p2smile_btn.Text)
            {

                p2star_btn.BackColor = Color.IndianRed;
                p2smile_btn.BackColor = Color.Green;
                p2snwflk_btn.BackColor = Color.IndianRed;
                p2drop_btn.BackColor = Color.IndianRed;
                p2sun_btn.BackColor = Color.IndianRed;
                p2hand_btn.BackColor = Color.IndianRed;
                p2mouse_btn.BackColor = Color.IndianRed;
                p2comp_btn.BackColor = Color.IndianRed;
            }
            else if (p2_sym == p2snwflk_btn.Text)
            {
                p2star_btn.BackColor = Color.IndianRed;
                p2smile_btn.BackColor = Color.IndianRed;
                p2snwflk_btn.BackColor = Color.Green;
                p2drop_btn.BackColor = Color.IndianRed;
                p2sun_btn.BackColor = Color.IndianRed;
                p2hand_btn.BackColor = Color.IndianRed;
                p2mouse_btn.BackColor = Color.IndianRed;
                p2comp_btn.BackColor = Color.IndianRed;
            }
            else if (p2_sym == p2drop_btn.Text)
            {
                p2star_btn.BackColor = Color.IndianRed;
                p2smile_btn.BackColor = Color.IndianRed;
                p2snwflk_btn.BackColor = Color.IndianRed;
                p2drop_btn.BackColor = Color.Green;
                p2sun_btn.BackColor = Color.IndianRed;
                p2hand_btn.BackColor = Color.IndianRed;
                p2mouse_btn.BackColor = Color.IndianRed;
                p2comp_btn.BackColor = Color.IndianRed;
            }
            else if (p2_sym == p2sun_btn.Text)
            {
                p2star_btn.BackColor = Color.IndianRed;
                p2smile_btn.BackColor = Color.IndianRed;
                p2snwflk_btn.BackColor = Color.IndianRed;
                p2drop_btn.BackColor = Color.IndianRed;
                p2sun_btn.BackColor = Color.Green;
                p2hand_btn.BackColor = Color.IndianRed;
                p2mouse_btn.BackColor = Color.IndianRed;
                p2comp_btn.BackColor = Color.IndianRed;
            }
            else if (p2_sym == p2hand_btn.Text)
            {
                p2star_btn.BackColor = Color.IndianRed;
                p2smile_btn.BackColor = Color.IndianRed;
                p2snwflk_btn.BackColor = Color.IndianRed;
                p2drop_btn.BackColor = Color.IndianRed;
                p2sun_btn.BackColor = Color.IndianRed;
                p2hand_btn.BackColor = Color.Green;
                p2mouse_btn.BackColor = Color.IndianRed;
                p2comp_btn.BackColor = Color.IndianRed;
            }
            else if (p2_sym == p2mouse_btn.Text)
            {
                p2star_btn.BackColor = Color.IndianRed;
                p2smile_btn.BackColor = Color.IndianRed;
                p2snwflk_btn.BackColor = Color.IndianRed;
                p2drop_btn.BackColor = Color.IndianRed;
                p2sun_btn.BackColor = Color.IndianRed;
                p2hand_btn.BackColor = Color.IndianRed;
                p2mouse_btn.BackColor = Color.Green;
                p2comp_btn.BackColor = Color.IndianRed;
            }
            else if (p2_sym == p2comp_btn.Text)
            {
                p2star_btn.BackColor = Color.IndianRed;
                p2smile_btn.BackColor = Color.IndianRed;
                p2snwflk_btn.BackColor = Color.IndianRed;
                p2drop_btn.BackColor = Color.IndianRed;
                p2sun_btn.BackColor = Color.IndianRed;
                p2hand_btn.BackColor = Color.IndianRed;
                p2mouse_btn.BackColor = Color.IndianRed;
                p2comp_btn.BackColor = Color.Green;
            }
        }
        //ready up button
        private void ready2_btn_Click(object sender, EventArgs e)
        {
            p2_ready_state = !p2_ready_state;
            if (p2_ready_state == true)
            {
                ready2_btn.BackColor = Color.Green;
                ready2_btn.Text = $"{p2name.Text} Ready!";
                select_color_p2();
            }
            else if (p2_ready_state == false)
            {
                ready2_btn.BackColor = Color.Red;
                ready2_btn.Text = $"{p2name.Text} not Ready!";
            }

            p2_name = p2name.Text;

            //when ready button is pushed, check ready state of both players. if both true, start game
            if (p1_ready_state == true && p2_ready_state == true && p1_sym != p2_sym)
            {
                //closes form 1
                this.Hide();
                //open form 2
                Form frm = new Tic_Tac_toe_form();
                frm.ShowDialog();
            }
        }
        //character buttons
        private void p2star_btn_Click(object sender, EventArgs e)
        {
            p2_sym = p2star_btn.Text;
        }
        private void p2smile_btn_Click(object sender, EventArgs e)
        {
            p2_sym = p2smile_btn.Text;
        }
        private void p2snwflk_btn_Click(object sender, EventArgs e)
        {
            p2_sym = p2snwflk_btn.Text;
        }
        private void p2drop_btn_Click(object sender, EventArgs e)
        {
            p2_sym = p2drop_btn.Text;
        }
        private void p2sun_btn_Click(object sender, EventArgs e)
        {
            p2_sym = p2sun_btn.Text;
        }
        private void p2hand_btn_Click(object sender, EventArgs e)
        {
            p2_sym = p2hand_btn.Text;
        }
        private void p2mouse_btn_Click(object sender, EventArgs e)
        {
            p2_sym = p2mouse_btn.Text;
        }
        private void p2comp_btn_Click(object sender, EventArgs e)
        {
            p2_sym = p2comp_btn.Text;
        }
    }
        
}
