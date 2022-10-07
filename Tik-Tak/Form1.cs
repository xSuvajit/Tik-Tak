using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tik_Tak
{
    public partial class TikTacGame : Form
    {
        public TikTacGame()
        {
            InitializeComponent();
            play_btn.Enabled = false;
            ok_btn.Enabled = false;
            SetColorWhite();
            ticTacTabControl.TabPages.Remove(game_tab);
        }

        String PlayerOneName, PlayerTwoName, p1Sign, p2Sign;

        Color p1Color, p2Color;

        #region Info Tab 

        private void saveDetails_btn_Click(object sender, EventArgs e)
        {
            if (player_one_input_txtBox.Text.Trim().Length > 0 &&
                player_two_input_txtBox.Text.Trim().Length > 0)
            {
                PlayerOneName = player_one_input_txtBox.Text.Trim();
                PlayerTwoName = player_two_input_txtBox.Text.Trim();
                if (!PlayerOneName.Equals(PlayerTwoName))
                {
                    playerOneName_label.Text = PlayerOneName + "'s sign:-";
                    playerTwoName_label.Text = PlayerTwoName + "'s sign:-";
                    ok_btn.Enabled = true;
                    saveDetails_btn.Enabled = false;
                    play_disable_label.ResetText();
                }
                else
                {
                    play_disable_label.Text = "Please enter different names!!";
                }
            }
            else
                play_disable_label.Text = "Please provide all names!!";
        }

        private void ok_btn_Click(object sender, EventArgs e)
        {
            if(p1_symbol_comboBox.SelectedItem!= null && p2_symbol_comboBox.SelectedItem!=null)
            {
                if (p1_symbol_comboBox.SelectedItem.ToString().Equals
                (p2_symbol_comboBox.SelectedItem.ToString()))
                {
                    play_btn.Enabled = false;
                    play_disable_label.Text = "Please select different signs!!";
                }
                else
                {
                    play_btn.Enabled = true;
                    play_disable_label.ResetText();
                }
            }
            else            
                play_disable_label.Text = "Please select all values!!";            
        }  

        private Color GetColor(String x)
        {
            if (x.Equals("x",StringComparison.InvariantCultureIgnoreCase))
                return Color.Tomato;
            else
                return Color.Lime;
        }

        private void play_btn_Click(object sender, EventArgs e)
        {
            p1Sign = p1_symbol_comboBox.SelectedItem.ToString();
            p1Color = GetColor(p1Sign);
            p2Sign = p2_symbol_comboBox.SelectedItem.ToString();
            p2Color=GetColor(p2Sign);
            ticTacTabControl.TabPages.Remove(info_tab);
            ticTacTabControl.TabPages.Add(game_tab);
            game_tab_label.Text = PlayerOneName + "'s turn! (" + p1Sign + ")";
        }

        private Color setColorToLabel(string str)
        {
            if (str.Equals("x", StringComparison.InvariantCultureIgnoreCase))
                return Color.Tomato;
            else 
                return Color.Lime;            
        }

        private string setSignToLabel(string str)
        {
            if (str.Equals("x", StringComparison.InvariantCultureIgnoreCase))
                return str.ToUpper();
            else
                return str.ToUpper();
        }

        private void p2_symbol_comboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if(p2_symbol_comboBox.SelectedItem!=null)
            {                
                p2_Sign_label.Text = setSignToLabel(p2_symbol_comboBox.SelectedItem.ToString());
                p2_Sign_label.BackColor = setColorToLabel(p2_symbol_comboBox.SelectedItem.ToString());
                play_btn.Enabled = false;
            }
            else
                p2_Sign_label.ResetText();
        }               

        private void p1_symbol_comboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (p1_symbol_comboBox.SelectedItem != null)
            {
                p1_Sign_label.Text = setSignToLabel(p1_symbol_comboBox.SelectedItem.ToString());
                p1_Sign_label.BackColor = setColorToLabel(p1_symbol_comboBox.SelectedItem.ToString());
                play_btn.Enabled = false;
            }
            else
                p2_Sign_label.ResetText();
        }

        #endregion

        #region Game logic

        #region internal logics

        int count = 0;

        private String IsWin()
        {
            if (txtBox_11.Text.Equals(txtBox_12.Text) && txtBox_11.Text.Equals(txtBox_13.Text))
                return txtBox_11.Text;
            else if (txtBox_21.Text.Equals(txtBox_22.Text) && txtBox_21.Text.Equals(txtBox_23.Text))
                return txtBox_21.Text;
            else if (txtBox_31.Text.Equals(txtBox_32.Text) && txtBox_31.Text.Equals(txtBox_33.Text))
                return txtBox_31.Text;
            else if (txtBox_11.Text.Equals(txtBox_21.Text) && txtBox_11.Text.Equals(txtBox_31.Text))
                return txtBox_11.Text;
            else if (txtBox_12.Text.Equals(txtBox_22.Text) && txtBox_12.Text.Equals(txtBox_32.Text))
                return txtBox_12.Text;
            else if (txtBox_13.Text.Equals(txtBox_23.Text) && txtBox_13.Text.Equals(txtBox_33.Text))
                return txtBox_13.Text;
            else if (txtBox_11.Text.Equals(txtBox_22.Text) && txtBox_11.Text.Equals(txtBox_33.Text))
                return txtBox_11.Text;
            else if (txtBox_13.Text.Equals(txtBox_22.Text) && txtBox_13.Text.Equals(txtBox_31.Text))
                return txtBox_13.Text;
            else if (count == 9)
                return "Draw!! No one win!!";
            else return "";
        }

        private void MatchFinish()
        {
            txtBox_11.Enabled = false;
            txtBox_12.Enabled = false;
            txtBox_13.Enabled = false;
            txtBox_21.Enabled = false;
            txtBox_22.Enabled = false;
            txtBox_23.Enabled = false;
            txtBox_31.Enabled = false;
            txtBox_32.Enabled = false;
            txtBox_33.Enabled = false;            
        }

        private void SetTxtBoxTrue()
        {
            txtBox_11.Enabled = true;
            txtBox_12.Enabled = true;
            txtBox_13.Enabled = true;
            txtBox_21.Enabled = true;
            txtBox_22.Enabled = true;
            txtBox_23.Enabled = true;
            txtBox_31.Enabled = true;
            txtBox_32.Enabled = true;
            txtBox_33.Enabled = true;
        }

        private void ClearTxtBox()
        {
            txtBox_11.Clear();
            txtBox_12.Clear();
            txtBox_13.Clear();
            txtBox_21.Clear();
            txtBox_22.Clear();
            txtBox_23.Clear();
            txtBox_31.Clear();
            txtBox_32.Clear();
            txtBox_33.Clear();
        }

        private void SetColorWhite()
        {
            txtBox_11.BackColor = Color.White;
            txtBox_12.BackColor = Color.White;
            txtBox_13.BackColor = Color.White;
            txtBox_21.BackColor = Color.White;
            txtBox_22.BackColor = Color.White;
            txtBox_23.BackColor = Color.White;
            txtBox_31.BackColor = Color.White;
            txtBox_32.BackColor = Color.White;
            txtBox_33.BackColor = Color.White;
        }

        private string SetMsg(string text, string sign)
        {
            return text.Equals(sign) ? "🥳 Congratulation!! " + PlayerOneName + " Wins!!"
                    : "🥳 Congratulation!! " + PlayerTwoName + " Wins!!";
        }

        private String PlayerTurn()
        {
            count++;
            if (count % 2 == 1)                            
                return p1Sign;
            
            else                            
                return p2Sign;            
        }

        private Color SetColor(string turn)
        {
            if(turn.Equals(p1Sign))
                return p1Color;
            else return p2Color;
        }

        private string setMsgToGameTurnLabel(string str)
        {
            if(str.Equals(p2Sign))
                return PlayerOneName + "'s turn! (" + p1Sign + ")";
            else
                return PlayerTwoName + "'s turn! (" + p2Sign + ")";
        }    

        #endregion

        #region Events

        private void txtBox_click(object sender, EventArgs e)
        {
            TextBox t = sender as TextBox;
            t.Text = PlayerTurn();
            t.BackColor = SetColor(t.Text);
            t.Enabled = false;
            string data = IsWin();
            if (data.Equals(t.Text, StringComparison.InvariantCultureIgnoreCase))
            {
                MatchFinish();
                game_tab_label.Text = SetMsg(t.Text, p1Sign);
            }
            else if (data.Equals(String.Empty))            
                game_tab_label.Text = setMsgToGameTurnLabel(t.Text);            
            else
                game_tab_label.Text = data;
        }         

        private void CommonMouseHover(Object obj, EventArgs e)
        {
            TextBox t = obj as TextBox;
            t.Cursor = Cursors.Hand;
        }             

        #endregion

        #region other buttons in game page

        private void ResetGame()
        {
            game_tab_label.ResetText();
            count = 0;
            SetTxtBoxTrue();
            ClearTxtBox();
            SetColorWhite();
        }

        private void newGame_btn_Click(object sender, EventArgs e)
        {
            ResetGame();
            game_tab_label.Text = PlayerOneName + "'s turn! (" + p1Sign + ")";
        }

        private void goBack_btn_Click(object sender, EventArgs e)
        {
            ResetGame();
            ticTacTabControl.TabPages.Remove(game_tab);
            ticTacTabControl.TabPages.Add(info_tab);
            player_one_input_txtBox.Clear();
            player_two_input_txtBox.Clear();
            saveDetails_btn.Enabled = true;
            ok_btn.Enabled = false;
            play_btn.Enabled=false;
            playerOneName_label.Text = "Player 1's sign:-";
            playerTwoName_label.Text = "Player 2's sign:-";
            p1_Sign_label.ResetText();
            p2_Sign_label.ResetText();
            p1_symbol_comboBox.SelectedIndex = -1;
            p2_symbol_comboBox.SelectedIndex = -1;
        }

        #endregion

        #endregion
    }
}
