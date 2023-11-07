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
    public partial class Tic_Tac_toe_form : Form
    {
        bool turn = false;
        int turn_count = 0;
        bool there_is_winner = false;

        public Tic_Tac_toe_form()
        {
            InitializeComponent();
        }


        //p1 panel
        private void p1_panel_Paint(object sender, PaintEventArgs e)
        {
            p1_panel.BackColor = Character_setup_form.p1_box_color;
            Player1_name_lbl.Text = Character_setup_form.p1_name;
            p1_symbol.Text = Character_setup_form.p1_sym;
            p1_symbol.ForeColor = Character_setup_form.p1_ch_color;
            winner_lbl.Text = Character_setup_form.p1_name + " turn";
            results_panel.BackColor = Character_setup_form.p1_box_color;
            ext_btn.Hide();
            newgame_btn.Hide();
        }


        //p2 panel
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            p2_panel.BackColor = Character_setup_form.p2_box_color;
            Player2_name_lbl.Text = Character_setup_form.p2_name;
            p2_symbol.Text = Character_setup_form.p2_sym;
            p2_symbol.ForeColor = Character_setup_form.p2_ch_color;
        }




        //exit button
        private void ext_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
            {
                b.Text = p1_symbol.Text;//changes text in button to players symbol
                winner_lbl.Text = Player1_name_lbl.Text + " turn";//changes winner label text to next players name to prompt next play
                results_panel.BackColor = Character_setup_form.p1_box_color;//changes players color to prompt next play
                b.BackColor = Character_setup_form.p2_box_color;//changes button background to player color that played that button
                b.ForeColor = Character_setup_form.p2_ch_color;//changes button foreground to player color that played that button
            }    
            else
            {
                b.Text = p2_symbol.Text;//changes text in button to players symbol
                winner_lbl.Text = Player2_name_lbl.Text + " turn";//changes winner label text to next players name to prompt next play
                results_panel.BackColor = Character_setup_form.p2_box_color;//changes players color to prompt next play
                b.BackColor = Character_setup_form.p1_box_color;//changes button background to player color that played that button
                b.ForeColor = Character_setup_form.p1_ch_color;//changes button foreground to player color that played that button
            }

            turn = !turn;
            turn_count++;

            checkForWinner();
        }

        private void checkForWinner()
        {

            //horizontal wins
            if ((TL_btn.Text == TM_btn.Text) && (TM_btn.Text == TR_btn.Text) && (TL_btn.Text != "") && (TM_btn.Text != "") && (TR_btn.Text != ""))//top row
            {
                there_is_winner = true;
            }
            if ((ML_btn.Text == C_btn.Text) && (C_btn.Text == MR_btn.Text) && (ML_btn.Text != "") && (C_btn.Text != "") && (MR_btn.Text != ""))//middle row
            {
                there_is_winner = true;
            }
            if ((BL_btn.Text == TM_btn.Text) && (BM_btn.Text == BR_btn.Text) && (BL_btn.Text != "") && (BM_btn.Text != "") && (BR_btn.Text != ""))//bottom row
            {
                there_is_winner = true;
            }

            //vertical wins
            if ((TL_btn.Text == ML_btn.Text) && (ML_btn.Text == BL_btn.Text) && (TL_btn.Text != "") && (ML_btn.Text != "") && (BL_btn.Text != ""))//left columns
            {
                there_is_winner = true;
            }
            if ((TM_btn.Text == C_btn.Text) && (C_btn.Text == BM_btn.Text) && (TM_btn.Text != "") && (C_btn.Text != "") && (BM_btn.Text != ""))//middle columns
            {
                there_is_winner = true;
            }
            if ((TR_btn.Text == MR_btn.Text) && (MR_btn.Text == BR_btn.Text) && (TR_btn.Text != "") && (MR_btn.Text != "") && (BR_btn.Text != ""))//right columns
            {
                there_is_winner = true;
            }

            //diagonal wins
            if ((TL_btn.Text == C_btn.Text) && (C_btn.Text == BR_btn.Text) && (TL_btn.Text != "") && (C_btn.Text != "") && (BR_btn.Text != ""))//top left to bottom right
            {
                there_is_winner = true;
            }
            if ((BL_btn.Text == C_btn.Text) && (C_btn.Text == TR_btn.Text) && (BL_btn.Text != "") && (C_btn.Text != "") && (TR_btn.Text != ""))//bottom left to top right
            {
                there_is_winner = true;
            }

            if(there_is_winner == true)
            {
                if (turn)
                {
                    winner_lbl.Text = Player1_name_lbl.Text + " is the winner";
                    results_panel.BackColor = Character_setup_form.p1_box_color;
                    ext_btn.Show();
                    newgame_btn.Show();
                }
                else
                {
                    winner_lbl.Text = Player2_name_lbl.Text + " is the winner";
                    results_panel.BackColor = Character_setup_form.p2_box_color;
                    ext_btn.Show();
                    newgame_btn.Show();
                }
            }
            else if (turn_count > 8)
            {
                winner_lbl.Text = "Tie";
                results_panel.BackColor = Color.White;
                ext_btn.Show();
                newgame_btn.Show();
            }

        }

        private void newgame_btn_Click(object sender, EventArgs e)
        {
            //resets characters
            TL_btn.Text = "";
            TM_btn.Text = "";
            TR_btn.Text = "";
            ML_btn.Text = "";
            C_btn.Text = "";
            MR_btn.Text = "";
            BL_btn.Text = "";
            BM_btn.Text = "";
            BR_btn.Text = "";

            //resets back colors
            TL_btn.BackColor = SystemColors.Control;
            TM_btn.BackColor = SystemColors.Control;
            TR_btn.BackColor = SystemColors.Control;
            ML_btn.BackColor = SystemColors.Control;
            C_btn.BackColor = SystemColors.Control;
            MR_btn.BackColor = SystemColors.Control;
            BL_btn.BackColor = SystemColors.Control;
            BM_btn.BackColor = SystemColors.Control;
            BR_btn.BackColor = SystemColors.Control;

            //reset counter
            turn_count = 0;

            //reset turn
            turn = false;
            winner_lbl.Text = Character_setup_form.p1_name + " turn";
            results_panel.BackColor = Character_setup_form.p1_box_color;
            ext_btn.Hide();
            newgame_btn.Hide();

            //reset winner
            there_is_winner = false;
        }
    }
}
