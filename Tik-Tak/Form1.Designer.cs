using System.Drawing;

namespace Tik_Tak
{
    partial class TikTacGame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TikTacGame));
            this.txtBox_11 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtBox_12 = new System.Windows.Forms.TextBox();
            this.txtBox_13 = new System.Windows.Forms.TextBox();
            this.txtBox_23 = new System.Windows.Forms.TextBox();
            this.txtBox_22 = new System.Windows.Forms.TextBox();
            this.txtBox_21 = new System.Windows.Forms.TextBox();
            this.txtBox_33 = new System.Windows.Forms.TextBox();
            this.txtBox_32 = new System.Windows.Forms.TextBox();
            this.txtBox_31 = new System.Windows.Forms.TextBox();
            this.ticTacTabControl = new System.Windows.Forms.TabControl();
            this.info_tab = new System.Windows.Forms.TabPage();
            this.ok_btn = new System.Windows.Forms.Button();
            this.saveDetails_btn = new System.Windows.Forms.Button();
            this.play_disable_label = new System.Windows.Forms.Label();
            this.p2_Sign_label = new System.Windows.Forms.Label();
            this.p1_Sign_label = new System.Windows.Forms.Label();
            this.play_btn = new System.Windows.Forms.Button();
            this.p2_symbol_comboBox = new System.Windows.Forms.ComboBox();
            this.p1_symbol_comboBox = new System.Windows.Forms.ComboBox();
            this.player_two_input_txtBox = new System.Windows.Forms.TextBox();
            this.player_one_input_txtBox = new System.Windows.Forms.TextBox();
            this.p2_label = new System.Windows.Forms.Label();
            this.playerTwoName_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.playerOneName_label = new System.Windows.Forms.Label();
            this.p1_label = new System.Windows.Forms.Label();
            this.game_tab = new System.Windows.Forms.TabPage();
            this.goBack_btn = new System.Windows.Forms.Button();
            this.newGame_btn = new System.Windows.Forms.Button();
            this.game_tab_label = new System.Windows.Forms.Label();
            this.ticTacTabControl.SuspendLayout();
            this.info_tab.SuspendLayout();
            this.game_tab.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBox_11
            // 
            this.txtBox_11.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_11.Location = new System.Drawing.Point(71, 27);
            this.txtBox_11.Multiline = true;
            this.txtBox_11.Name = "txtBox_11";
            this.txtBox_11.ReadOnly = true;
            this.txtBox_11.Size = new System.Drawing.Size(66, 57);
            this.txtBox_11.TabIndex = 0;
            this.txtBox_11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBox_11.Click += new System.EventHandler(this.txtBox_click);
            this.txtBox_11.MouseHover += new System.EventHandler(this.CommonMouseHover);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtBox_12
            // 
            this.txtBox_12.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_12.Location = new System.Drawing.Point(143, 27);
            this.txtBox_12.Multiline = true;
            this.txtBox_12.Name = "txtBox_12";
            this.txtBox_12.ReadOnly = true;
            this.txtBox_12.Size = new System.Drawing.Size(66, 57);
            this.txtBox_12.TabIndex = 2;
            this.txtBox_12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBox_12.Click += new System.EventHandler(this.txtBox_click);
            this.txtBox_12.MouseHover += new System.EventHandler(this.CommonMouseHover);
            // 
            // txtBox_13
            // 
            this.txtBox_13.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_13.Location = new System.Drawing.Point(215, 27);
            this.txtBox_13.Multiline = true;
            this.txtBox_13.Name = "txtBox_13";
            this.txtBox_13.ReadOnly = true;
            this.txtBox_13.Size = new System.Drawing.Size(66, 57);
            this.txtBox_13.TabIndex = 3;
            this.txtBox_13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBox_13.Click += new System.EventHandler(this.txtBox_click);
            this.txtBox_13.MouseHover += new System.EventHandler(this.CommonMouseHover);
            // 
            // txtBox_23
            // 
            this.txtBox_23.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_23.Location = new System.Drawing.Point(215, 90);
            this.txtBox_23.Multiline = true;
            this.txtBox_23.Name = "txtBox_23";
            this.txtBox_23.ReadOnly = true;
            this.txtBox_23.Size = new System.Drawing.Size(66, 57);
            this.txtBox_23.TabIndex = 6;
            this.txtBox_23.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBox_23.Click += new System.EventHandler(this.txtBox_click);
            this.txtBox_23.MouseHover += new System.EventHandler(this.CommonMouseHover);
            // 
            // txtBox_22
            // 
            this.txtBox_22.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_22.Location = new System.Drawing.Point(143, 90);
            this.txtBox_22.Multiline = true;
            this.txtBox_22.Name = "txtBox_22";
            this.txtBox_22.ReadOnly = true;
            this.txtBox_22.Size = new System.Drawing.Size(66, 57);
            this.txtBox_22.TabIndex = 5;
            this.txtBox_22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBox_22.Click += new System.EventHandler(this.txtBox_click);
            this.txtBox_22.MouseHover += new System.EventHandler(this.CommonMouseHover);
            // 
            // txtBox_21
            // 
            this.txtBox_21.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_21.Location = new System.Drawing.Point(71, 90);
            this.txtBox_21.Multiline = true;
            this.txtBox_21.Name = "txtBox_21";
            this.txtBox_21.ReadOnly = true;
            this.txtBox_21.Size = new System.Drawing.Size(66, 57);
            this.txtBox_21.TabIndex = 4;
            this.txtBox_21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBox_21.Click += new System.EventHandler(this.txtBox_click);
            this.txtBox_21.MouseHover += new System.EventHandler(this.CommonMouseHover);
            // 
            // txtBox_33
            // 
            this.txtBox_33.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_33.Location = new System.Drawing.Point(215, 153);
            this.txtBox_33.Multiline = true;
            this.txtBox_33.Name = "txtBox_33";
            this.txtBox_33.ReadOnly = true;
            this.txtBox_33.Size = new System.Drawing.Size(66, 57);
            this.txtBox_33.TabIndex = 9;
            this.txtBox_33.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBox_33.Click += new System.EventHandler(this.txtBox_click);
            this.txtBox_33.MouseHover += new System.EventHandler(this.CommonMouseHover);
            // 
            // txtBox_32
            // 
            this.txtBox_32.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_32.Location = new System.Drawing.Point(143, 153);
            this.txtBox_32.Multiline = true;
            this.txtBox_32.Name = "txtBox_32";
            this.txtBox_32.ReadOnly = true;
            this.txtBox_32.Size = new System.Drawing.Size(66, 57);
            this.txtBox_32.TabIndex = 8;
            this.txtBox_32.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBox_32.Click += new System.EventHandler(this.txtBox_click);
            this.txtBox_32.MouseHover += new System.EventHandler(this.CommonMouseHover);
            // 
            // txtBox_31
            // 
            this.txtBox_31.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_31.Location = new System.Drawing.Point(71, 153);
            this.txtBox_31.Multiline = true;
            this.txtBox_31.Name = "txtBox_31";
            this.txtBox_31.ReadOnly = true;
            this.txtBox_31.Size = new System.Drawing.Size(66, 57);
            this.txtBox_31.TabIndex = 7;
            this.txtBox_31.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBox_31.Click += new System.EventHandler(this.txtBox_click);
            this.txtBox_31.MouseHover += new System.EventHandler(this.CommonMouseHover);
            // 
            // ticTacTabControl
            // 
            this.ticTacTabControl.Controls.Add(this.info_tab);
            this.ticTacTabControl.Controls.Add(this.game_tab);
            this.ticTacTabControl.Location = new System.Drawing.Point(12, 12);
            this.ticTacTabControl.Name = "ticTacTabControl";
            this.ticTacTabControl.SelectedIndex = 0;
            this.ticTacTabControl.Size = new System.Drawing.Size(353, 371);
            this.ticTacTabControl.TabIndex = 10;
            // 
            // info_tab
            // 
            this.info_tab.Controls.Add(this.ok_btn);
            this.info_tab.Controls.Add(this.saveDetails_btn);
            this.info_tab.Controls.Add(this.play_disable_label);
            this.info_tab.Controls.Add(this.p2_Sign_label);
            this.info_tab.Controls.Add(this.p1_Sign_label);
            this.info_tab.Controls.Add(this.play_btn);
            this.info_tab.Controls.Add(this.p2_symbol_comboBox);
            this.info_tab.Controls.Add(this.p1_symbol_comboBox);
            this.info_tab.Controls.Add(this.player_two_input_txtBox);
            this.info_tab.Controls.Add(this.player_one_input_txtBox);
            this.info_tab.Controls.Add(this.p2_label);
            this.info_tab.Controls.Add(this.playerTwoName_label);
            this.info_tab.Controls.Add(this.label3);
            this.info_tab.Controls.Add(this.playerOneName_label);
            this.info_tab.Controls.Add(this.p1_label);
            this.info_tab.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info_tab.Location = new System.Drawing.Point(4, 22);
            this.info_tab.Name = "info_tab";
            this.info_tab.Padding = new System.Windows.Forms.Padding(3);
            this.info_tab.Size = new System.Drawing.Size(345, 345);
            this.info_tab.TabIndex = 0;
            this.info_tab.Text = "Info!";
            this.info_tab.UseVisualStyleBackColor = true;
            // 
            // ok_btn
            // 
            this.ok_btn.Location = new System.Drawing.Point(271, 177);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(57, 28);
            this.ok_btn.TabIndex = 7;
            this.ok_btn.Text = "OK";
            this.ok_btn.UseVisualStyleBackColor = true;
            this.ok_btn.Click += new System.EventHandler(this.ok_btn_Click);
            // 
            // saveDetails_btn
            // 
            this.saveDetails_btn.Location = new System.Drawing.Point(248, 75);
            this.saveDetails_btn.Name = "saveDetails_btn";
            this.saveDetails_btn.Size = new System.Drawing.Size(80, 28);
            this.saveDetails_btn.TabIndex = 6;
            this.saveDetails_btn.Text = "Save";
            this.saveDetails_btn.UseVisualStyleBackColor = true;
            this.saveDetails_btn.Click += new System.EventHandler(this.saveDetails_btn_Click);
            // 
            // play_disable_label
            // 
            this.play_disable_label.AutoSize = true;
            this.play_disable_label.Location = new System.Drawing.Point(12, 315);
            this.play_disable_label.Name = "play_disable_label";
            this.play_disable_label.Size = new System.Drawing.Size(0, 18);
            this.play_disable_label.TabIndex = 5;
            // 
            // p2_Sign_label
            // 
            this.p2_Sign_label.AutoSize = true;
            this.p2_Sign_label.Location = new System.Drawing.Point(244, 181);
            this.p2_Sign_label.Name = "p2_Sign_label";
            this.p2_Sign_label.Size = new System.Drawing.Size(0, 18);
            this.p2_Sign_label.TabIndex = 4;
            // 
            // p1_Sign_label
            // 
            this.p1_Sign_label.AutoSize = true;
            this.p1_Sign_label.Location = new System.Drawing.Point(244, 144);
            this.p1_Sign_label.Name = "p1_Sign_label";
            this.p1_Sign_label.Size = new System.Drawing.Size(0, 18);
            this.p1_Sign_label.TabIndex = 4;
            // 
            // play_btn
            // 
            this.play_btn.Location = new System.Drawing.Point(118, 265);
            this.play_btn.Name = "play_btn";
            this.play_btn.Size = new System.Drawing.Size(101, 38);
            this.play_btn.TabIndex = 3;
            this.play_btn.Text = "Play!!";
            this.play_btn.UseVisualStyleBackColor = true;
            this.play_btn.Click += new System.EventHandler(this.play_btn_Click);
            // 
            // p2_symbol_comboBox
            // 
            this.p2_symbol_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.p2_symbol_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2_symbol_comboBox.FormattingEnabled = true;
            this.p2_symbol_comboBox.Items.AddRange(new object[] {
            "X",
            "O"});
            this.p2_symbol_comboBox.Location = new System.Drawing.Point(169, 177);
            this.p2_symbol_comboBox.Name = "p2_symbol_comboBox";
            this.p2_symbol_comboBox.Size = new System.Drawing.Size(59, 26);
            this.p2_symbol_comboBox.TabIndex = 2;
            this.p2_symbol_comboBox.SelectedValueChanged += new System.EventHandler(this.p2_symbol_comboBox_SelectedValueChanged);
            // 
            // p1_symbol_comboBox
            // 
            this.p1_symbol_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.p1_symbol_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1_symbol_comboBox.FormattingEnabled = true;
            this.p1_symbol_comboBox.Items.AddRange(new object[] {
            "X",
            "O"});
            this.p1_symbol_comboBox.Location = new System.Drawing.Point(169, 139);
            this.p1_symbol_comboBox.Name = "p1_symbol_comboBox";
            this.p1_symbol_comboBox.Size = new System.Drawing.Size(59, 26);
            this.p1_symbol_comboBox.TabIndex = 2;
            this.p1_symbol_comboBox.SelectedValueChanged += new System.EventHandler(this.p1_symbol_comboBox_SelectedValueChanged);
            // 
            // player_two_input_txtBox
            // 
            this.player_two_input_txtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player_two_input_txtBox.Location = new System.Drawing.Point(132, 45);
            this.player_two_input_txtBox.Name = "player_two_input_txtBox";
            this.player_two_input_txtBox.Size = new System.Drawing.Size(196, 24);
            this.player_two_input_txtBox.TabIndex = 1;
            // 
            // player_one_input_txtBox
            // 
            this.player_one_input_txtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player_one_input_txtBox.Location = new System.Drawing.Point(132, 15);
            this.player_one_input_txtBox.Name = "player_one_input_txtBox";
            this.player_one_input_txtBox.Size = new System.Drawing.Size(196, 24);
            this.player_one_input_txtBox.TabIndex = 1;
            // 
            // p2_label
            // 
            this.p2_label.AutoSize = true;
            this.p2_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2_label.Location = new System.Drawing.Point(12, 51);
            this.p2_label.Name = "p2_label";
            this.p2_label.Size = new System.Drawing.Size(114, 18);
            this.p2_label.TabIndex = 0;
            this.p2_label.Text = "Player 2 Name:-";
            // 
            // playerTwoName_label
            // 
            this.playerTwoName_label.AutoSize = true;
            this.playerTwoName_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerTwoName_label.Location = new System.Drawing.Point(12, 180);
            this.playerTwoName_label.Name = "playerTwoName_label";
            this.playerTwoName_label.Size = new System.Drawing.Size(112, 18);
            this.playerTwoName_label.TabIndex = 0;
            this.playerTwoName_label.Text = "Player 2\'s sign:-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Select symbol";
            // 
            // playerOneName_label
            // 
            this.playerOneName_label.AutoSize = true;
            this.playerOneName_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerOneName_label.Location = new System.Drawing.Point(12, 142);
            this.playerOneName_label.Name = "playerOneName_label";
            this.playerOneName_label.Size = new System.Drawing.Size(112, 18);
            this.playerOneName_label.TabIndex = 0;
            this.playerOneName_label.Text = "Player 1\'s sign:-";
            // 
            // p1_label
            // 
            this.p1_label.AutoSize = true;
            this.p1_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1_label.Location = new System.Drawing.Point(12, 18);
            this.p1_label.Name = "p1_label";
            this.p1_label.Size = new System.Drawing.Size(114, 18);
            this.p1_label.TabIndex = 0;
            this.p1_label.Text = "Player 1 Name:-";
            // 
            // game_tab
            // 
            this.game_tab.Controls.Add(this.goBack_btn);
            this.game_tab.Controls.Add(this.newGame_btn);
            this.game_tab.Controls.Add(this.game_tab_label);
            this.game_tab.Controls.Add(this.txtBox_11);
            this.game_tab.Controls.Add(this.txtBox_33);
            this.game_tab.Controls.Add(this.txtBox_12);
            this.game_tab.Controls.Add(this.txtBox_32);
            this.game_tab.Controls.Add(this.txtBox_13);
            this.game_tab.Controls.Add(this.txtBox_31);
            this.game_tab.Controls.Add(this.txtBox_21);
            this.game_tab.Controls.Add(this.txtBox_23);
            this.game_tab.Controls.Add(this.txtBox_22);
            this.game_tab.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.game_tab.Location = new System.Drawing.Point(4, 22);
            this.game_tab.Name = "game_tab";
            this.game_tab.Padding = new System.Windows.Forms.Padding(3);
            this.game_tab.Size = new System.Drawing.Size(345, 345);
            this.game_tab.TabIndex = 1;
            this.game_tab.Text = "Lets play!!";
            this.game_tab.UseVisualStyleBackColor = true;
            // 
            // goBack_btn
            // 
            this.goBack_btn.Location = new System.Drawing.Point(199, 237);
            this.goBack_btn.Name = "goBack_btn";
            this.goBack_btn.Size = new System.Drawing.Size(108, 49);
            this.goBack_btn.TabIndex = 12;
            this.goBack_btn.Text = "Go back!";
            this.goBack_btn.UseVisualStyleBackColor = true;
            this.goBack_btn.Click += new System.EventHandler(this.goBack_btn_Click);
            // 
            // newGame_btn
            // 
            this.newGame_btn.Location = new System.Drawing.Point(47, 237);
            this.newGame_btn.Name = "newGame_btn";
            this.newGame_btn.Size = new System.Drawing.Size(108, 49);
            this.newGame_btn.TabIndex = 11;
            this.newGame_btn.Text = "New Game?";
            this.newGame_btn.UseVisualStyleBackColor = true;
            this.newGame_btn.Click += new System.EventHandler(this.newGame_btn_Click);
            // 
            // game_tab_label
            // 
            this.game_tab_label.AutoSize = true;
            this.game_tab_label.Location = new System.Drawing.Point(14, 316);
            this.game_tab_label.Name = "game_tab_label";
            this.game_tab_label.Size = new System.Drawing.Size(0, 18);
            this.game_tab_label.TabIndex = 10;
            // 
            // TikTacGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 389);
            this.Controls.Add(this.ticTacTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "TikTacGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tik Tak";
            this.ticTacTabControl.ResumeLayout(false);
            this.info_tab.ResumeLayout(false);
            this.info_tab.PerformLayout();
            this.game_tab.ResumeLayout(false);
            this.game_tab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox_11;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtBox_12;
        private System.Windows.Forms.TextBox txtBox_13;
        private System.Windows.Forms.TextBox txtBox_23;
        private System.Windows.Forms.TextBox txtBox_22;
        private System.Windows.Forms.TextBox txtBox_21;
        private System.Windows.Forms.TextBox txtBox_33;
        private System.Windows.Forms.TextBox txtBox_32;
        private System.Windows.Forms.TextBox txtBox_31;
        private System.Windows.Forms.TabControl ticTacTabControl;
        private System.Windows.Forms.TabPage info_tab;
        private System.Windows.Forms.ComboBox p2_symbol_comboBox;
        private System.Windows.Forms.ComboBox p1_symbol_comboBox;
        private System.Windows.Forms.TextBox player_two_input_txtBox;
        private System.Windows.Forms.TextBox player_one_input_txtBox;
        private System.Windows.Forms.Label p2_label;
        private System.Windows.Forms.Label p1_label;
        private System.Windows.Forms.TabPage game_tab;
        private System.Windows.Forms.Label game_tab_label;
        private System.Windows.Forms.Label playerTwoName_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label playerOneName_label;
        private System.Windows.Forms.Button play_btn;
        private System.Windows.Forms.Button goBack_btn;
        private System.Windows.Forms.Button newGame_btn;
        private System.Windows.Forms.Label p2_Sign_label;
        private System.Windows.Forms.Label p1_Sign_label;
        private System.Windows.Forms.Label play_disable_label;
        private System.Windows.Forms.Button saveDetails_btn;
        private System.Windows.Forms.Button ok_btn;
    }
}

