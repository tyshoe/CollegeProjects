
namespace tic_tac_toe
{
    partial class Tic_Tac_toe_form
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.p1_panel = new System.Windows.Forms.Panel();
            this.p1_symbol = new System.Windows.Forms.Label();
            this.Player1_name_lbl = new System.Windows.Forms.Label();
            this.p2_panel = new System.Windows.Forms.Panel();
            this.p2_symbol = new System.Windows.Forms.Label();
            this.Player2_name_lbl = new System.Windows.Forms.Label();
            this.results_panel = new System.Windows.Forms.Panel();
            this.newgame_btn = new System.Windows.Forms.Button();
            this.winner_lbl = new System.Windows.Forms.Label();
            this.ext_btn = new System.Windows.Forms.Button();
            this.TL_btn = new System.Windows.Forms.Button();
            this.TM_btn = new System.Windows.Forms.Button();
            this.TR_btn = new System.Windows.Forms.Button();
            this.MR_btn = new System.Windows.Forms.Button();
            this.C_btn = new System.Windows.Forms.Button();
            this.ML_btn = new System.Windows.Forms.Button();
            this.BR_btn = new System.Windows.Forms.Button();
            this.BM_btn = new System.Windows.Forms.Button();
            this.BL_btn = new System.Windows.Forms.Button();
            this.p1_panel.SuspendLayout();
            this.p2_panel.SuspendLayout();
            this.results_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // p1_panel
            // 
            this.p1_panel.Controls.Add(this.p1_symbol);
            this.p1_panel.Controls.Add(this.Player1_name_lbl);
            this.p1_panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1_panel.Location = new System.Drawing.Point(67, 12);
            this.p1_panel.Name = "p1_panel";
            this.p1_panel.Size = new System.Drawing.Size(160, 58);
            this.p1_panel.TabIndex = 0;
            this.p1_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.p1_panel_Paint);
            // 
            // p1_symbol
            // 
            this.p1_symbol.AutoSize = true;
            this.p1_symbol.Font = new System.Drawing.Font("Wingdings", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.p1_symbol.Location = new System.Drawing.Point(103, 11);
            this.p1_symbol.Name = "p1_symbol";
            this.p1_symbol.Size = new System.Drawing.Size(53, 41);
            this.p1_symbol.TabIndex = 1;
            this.p1_symbol.Text = "m";
            // 
            // Player1_name_lbl
            // 
            this.Player1_name_lbl.AutoSize = true;
            this.Player1_name_lbl.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player1_name_lbl.Location = new System.Drawing.Point(3, 11);
            this.Player1_name_lbl.Name = "Player1_name_lbl";
            this.Player1_name_lbl.Size = new System.Drawing.Size(94, 29);
            this.Player1_name_lbl.TabIndex = 0;
            this.Player1_name_lbl.Text = "Player 1:";
            // 
            // p2_panel
            // 
            this.p2_panel.Controls.Add(this.p2_symbol);
            this.p2_panel.Controls.Add(this.Player2_name_lbl);
            this.p2_panel.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2_panel.Location = new System.Drawing.Point(451, 13);
            this.p2_panel.Name = "p2_panel";
            this.p2_panel.Size = new System.Drawing.Size(158, 57);
            this.p2_panel.TabIndex = 1;
            this.p2_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // p2_symbol
            // 
            this.p2_symbol.AutoSize = true;
            this.p2_symbol.Font = new System.Drawing.Font("Wingdings", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.p2_symbol.Location = new System.Drawing.Point(104, 10);
            this.p2_symbol.Name = "p2_symbol";
            this.p2_symbol.Size = new System.Drawing.Size(51, 41);
            this.p2_symbol.TabIndex = 1;
            this.p2_symbol.Text = "o";
            // 
            // Player2_name_lbl
            // 
            this.Player2_name_lbl.AutoSize = true;
            this.Player2_name_lbl.Location = new System.Drawing.Point(3, 10);
            this.Player2_name_lbl.Name = "Player2_name_lbl";
            this.Player2_name_lbl.Size = new System.Drawing.Size(98, 29);
            this.Player2_name_lbl.TabIndex = 0;
            this.Player2_name_lbl.Text = "Player 2:";
            // 
            // results_panel
            // 
            this.results_panel.Controls.Add(this.newgame_btn);
            this.results_panel.Controls.Add(this.winner_lbl);
            this.results_panel.Controls.Add(this.ext_btn);
            this.results_panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.results_panel.Location = new System.Drawing.Point(67, 314);
            this.results_panel.Name = "results_panel";
            this.results_panel.Size = new System.Drawing.Size(659, 100);
            this.results_panel.TabIndex = 2;
            // 
            // newgame_btn
            // 
            this.newgame_btn.Location = new System.Drawing.Point(502, 14);
            this.newgame_btn.Name = "newgame_btn";
            this.newgame_btn.Size = new System.Drawing.Size(141, 33);
            this.newgame_btn.TabIndex = 3;
            this.newgame_btn.Text = "New Game";
            this.newgame_btn.UseVisualStyleBackColor = true;
            this.newgame_btn.Click += new System.EventHandler(this.newgame_btn_Click);
            // 
            // winner_lbl
            // 
            this.winner_lbl.AutoSize = true;
            this.winner_lbl.Location = new System.Drawing.Point(244, 38);
            this.winner_lbl.Name = "winner_lbl";
            this.winner_lbl.Size = new System.Drawing.Size(44, 25);
            this.winner_lbl.TabIndex = 3;
            this.winner_lbl.Text = "win";
            // 
            // ext_btn
            // 
            this.ext_btn.Location = new System.Drawing.Point(502, 53);
            this.ext_btn.Name = "ext_btn";
            this.ext_btn.Size = new System.Drawing.Size(141, 33);
            this.ext_btn.TabIndex = 0;
            this.ext_btn.Text = "Close Game";
            this.ext_btn.UseVisualStyleBackColor = true;
            this.ext_btn.Click += new System.EventHandler(this.ext_btn_Click);
            // 
            // TL_btn
            // 
            this.TL_btn.Font = new System.Drawing.Font("Wingdings", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.TL_btn.Location = new System.Drawing.Point(152, 87);
            this.TL_btn.Name = "TL_btn";
            this.TL_btn.Size = new System.Drawing.Size(75, 62);
            this.TL_btn.TabIndex = 3;
            this.TL_btn.UseVisualStyleBackColor = true;
            this.TL_btn.Click += new System.EventHandler(this.button_click);
            // 
            // TM_btn
            // 
            this.TM_btn.Font = new System.Drawing.Font("Wingdings", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.TM_btn.Location = new System.Drawing.Point(305, 87);
            this.TM_btn.Name = "TM_btn";
            this.TM_btn.Size = new System.Drawing.Size(75, 62);
            this.TM_btn.TabIndex = 4;
            this.TM_btn.UseVisualStyleBackColor = true;
            this.TM_btn.Click += new System.EventHandler(this.button_click);
            // 
            // TR_btn
            // 
            this.TR_btn.Font = new System.Drawing.Font("Wingdings", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.TR_btn.Location = new System.Drawing.Point(459, 87);
            this.TR_btn.Name = "TR_btn";
            this.TR_btn.Size = new System.Drawing.Size(75, 62);
            this.TR_btn.TabIndex = 5;
            this.TR_btn.UseVisualStyleBackColor = true;
            this.TR_btn.Click += new System.EventHandler(this.button_click);
            // 
            // MR_btn
            // 
            this.MR_btn.Font = new System.Drawing.Font("Wingdings", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.MR_btn.Location = new System.Drawing.Point(459, 167);
            this.MR_btn.Name = "MR_btn";
            this.MR_btn.Size = new System.Drawing.Size(75, 62);
            this.MR_btn.TabIndex = 8;
            this.MR_btn.UseVisualStyleBackColor = true;
            this.MR_btn.Click += new System.EventHandler(this.button_click);
            // 
            // C_btn
            // 
            this.C_btn.Font = new System.Drawing.Font("Wingdings", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.C_btn.Location = new System.Drawing.Point(305, 167);
            this.C_btn.Name = "C_btn";
            this.C_btn.Size = new System.Drawing.Size(75, 62);
            this.C_btn.TabIndex = 7;
            this.C_btn.UseVisualStyleBackColor = true;
            this.C_btn.Click += new System.EventHandler(this.button_click);
            // 
            // ML_btn
            // 
            this.ML_btn.Font = new System.Drawing.Font("Wingdings", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.ML_btn.Location = new System.Drawing.Point(152, 167);
            this.ML_btn.Name = "ML_btn";
            this.ML_btn.Size = new System.Drawing.Size(75, 62);
            this.ML_btn.TabIndex = 6;
            this.ML_btn.UseVisualStyleBackColor = true;
            this.ML_btn.Click += new System.EventHandler(this.button_click);
            // 
            // BR_btn
            // 
            this.BR_btn.Font = new System.Drawing.Font("Wingdings", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.BR_btn.Location = new System.Drawing.Point(459, 246);
            this.BR_btn.Name = "BR_btn";
            this.BR_btn.Size = new System.Drawing.Size(75, 62);
            this.BR_btn.TabIndex = 11;
            this.BR_btn.UseVisualStyleBackColor = true;
            this.BR_btn.Click += new System.EventHandler(this.button_click);
            // 
            // BM_btn
            // 
            this.BM_btn.Font = new System.Drawing.Font("Wingdings", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.BM_btn.Location = new System.Drawing.Point(305, 246);
            this.BM_btn.Name = "BM_btn";
            this.BM_btn.Size = new System.Drawing.Size(75, 62);
            this.BM_btn.TabIndex = 10;
            this.BM_btn.UseVisualStyleBackColor = true;
            this.BM_btn.Click += new System.EventHandler(this.button_click);
            // 
            // BL_btn
            // 
            this.BL_btn.Font = new System.Drawing.Font("Wingdings", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.BL_btn.Location = new System.Drawing.Point(152, 246);
            this.BL_btn.Name = "BL_btn";
            this.BL_btn.Size = new System.Drawing.Size(75, 62);
            this.BL_btn.TabIndex = 9;
            this.BL_btn.UseVisualStyleBackColor = true;
            this.BL_btn.Click += new System.EventHandler(this.button_click);
            // 
            // Tic_Tac_toe_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BR_btn);
            this.Controls.Add(this.BM_btn);
            this.Controls.Add(this.BL_btn);
            this.Controls.Add(this.MR_btn);
            this.Controls.Add(this.C_btn);
            this.Controls.Add(this.ML_btn);
            this.Controls.Add(this.TR_btn);
            this.Controls.Add(this.TM_btn);
            this.Controls.Add(this.TL_btn);
            this.Controls.Add(this.results_panel);
            this.Controls.Add(this.p2_panel);
            this.Controls.Add(this.p1_panel);
            this.Name = "Tic_Tac_toe_form";
            this.Text = "Tic-Tac-Toe";
            this.p1_panel.ResumeLayout(false);
            this.p1_panel.PerformLayout();
            this.p2_panel.ResumeLayout(false);
            this.p2_panel.PerformLayout();
            this.results_panel.ResumeLayout(false);
            this.results_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel p1_panel;
        private System.Windows.Forms.Label Player1_name_lbl;
        private System.Windows.Forms.Panel p2_panel;
        private System.Windows.Forms.Label Player2_name_lbl;
        private System.Windows.Forms.Label p1_symbol;
        private System.Windows.Forms.Label p2_symbol;
        private System.Windows.Forms.Panel results_panel;
        private System.Windows.Forms.Button ext_btn;
        private System.Windows.Forms.Label winner_lbl;
        private System.Windows.Forms.Button newgame_btn;
        private System.Windows.Forms.Button TL_btn;
        private System.Windows.Forms.Button TM_btn;
        private System.Windows.Forms.Button TR_btn;
        private System.Windows.Forms.Button MR_btn;
        private System.Windows.Forms.Button C_btn;
        private System.Windows.Forms.Button ML_btn;
        private System.Windows.Forms.Button BR_btn;
        private System.Windows.Forms.Button BM_btn;
        private System.Windows.Forms.Button BL_btn;
    }
}