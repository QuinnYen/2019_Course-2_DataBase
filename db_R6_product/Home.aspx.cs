using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace db_R6_product
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            logo.ImageUrl = "~/pic/r6_logo.png";
            ImageButton1.ImageUrl = "~/pic/01_flores.png";
            ImageButton2.ImageUrl = "~/pic/02_aruni.png";
            ImageButton3.ImageUrl = "~/pic/03_zero.png";
            ImageButton4.ImageUrl = "~/pic/04_ace.png";
            ImageButton5.ImageUrl = "~/pic/05_melusi.png";
            ImageButton6.ImageUrl = "~/pic/06_oryx.png";
            ImageButton7.ImageUrl = "~/pic/07_iana.png";
            ImageButton8.ImageUrl = "~/pic/08_wamai.png";
            ImageButton9.ImageUrl = "~/pic/09_kali.png";
            ImageButton10.ImageUrl = "~/pic/10_amaru.png";
            ImageButton11.ImageUrl = "~/pic/11_goyo.png";
            ImageButton12.ImageUrl = "~/pic/12_nokk.png";
            ImageButton13.ImageUrl = "~/pic/13_warden.png";
            ImageButton14.ImageUrl = "~/pic/14_mozzie.png";
            ImageButton15.ImageUrl = "~/pic/15_gridlock.png";
            ImageButton16.ImageUrl = "~/pic/16_nomad.png";
            ImageButton17.ImageUrl = "~/pic/17_kaid.png";
            ImageButton18.ImageUrl = "~/pic/18_clash.png";
            ImageButton19.ImageUrl = "~/pic/19_maverick.png";
            ImageButton20.ImageUrl = "~/pic/20_maestro.png";
            ImageButton21.ImageUrl = "~/pic/21_alibi.png";
            ImageButton22.ImageUrl = "~/pic/22_finka.png";
            ImageButton23.ImageUrl = "~/pic/23_lion.png";
            ImageButton24.ImageUrl = "~/pic/24_vigil.png";
            ImageButton25.ImageUrl = "~/pic/25_dokkaebi.png";
            ImageButton26.ImageUrl = "~/pic/26_zofia.png";
            ImageButton27.ImageUrl = "~/pic/27_ela.png";
            ImageButton28.ImageUrl = "~/pic/28_ying.png";
            ImageButton29.ImageUrl = "~/pic/29_lesion.png";
            ImageButton30.ImageUrl = "~/pic/30_mira.png";
            ImageButton31.ImageUrl = "~/pic/31_jackal.png";
            ImageButton32.ImageUrl = "~/pic/32_hibana.png";
            ImageButton33.ImageUrl = "~/pic/33_echo.png";
            ImageButton34.ImageUrl = "~/pic/34_caveira.png";
            ImageButton35.ImageUrl = "~/pic/35_capitao.png";
            ImageButton36.ImageUrl = "~/pic/36_blackbeard.png";
            ImageButton37.ImageUrl = "~/pic/37_valkyrie.png";
            ImageButton38.ImageUrl = "~/pic/38_buck.png";
            ImageButton39.ImageUrl = "~/pic/39_frost.png";
            ImageButton40.ImageUrl = "~/pic/40_mute.png";
            ImageButton41.ImageUrl = "~/pic/41_sledge.png";
            ImageButton42.ImageUrl = "~/pic/42_smoke.png";
            ImageButton43.ImageUrl = "~/pic/43_thatcher.png";
            ImageButton44.ImageUrl = "~/pic/44_ash.png";
            ImageButton45.ImageUrl = "~/pic/45_castle.png";
            ImageButton46.ImageUrl = "~/pic/46_pulse.png";
            ImageButton47.ImageUrl = "~/pic/47_thermite.png";
            ImageButton48.ImageUrl = "~/pic/48_montagne.png";
            ImageButton49.ImageUrl = "~/pic/49_twitch.png";
            ImageButton50.ImageUrl = "~/pic/50_doc.png";
            ImageButton51.ImageUrl = "~/pic/51_rook.png";
            ImageButton52.ImageUrl = "~/pic/52_jager.png";
            ImageButton53.ImageUrl = "~/pic/53_bandit.png";
            ImageButton54.ImageUrl = "~/pic/54_blitz.png";
            ImageButton55.ImageUrl = "~/pic/55_iq.png";
            ImageButton56.ImageUrl = "~/pic/56_fuze.png";
            ImageButton57.ImageUrl = "~/pic/57_glaz.png";
            ImageButton58.ImageUrl = "~/pic/58_tachanka.png";
            ImageButton59.ImageUrl = "~/pic/59_kapkan.png";
        }

        // 攻擊方按鈕觸發事件
        protected void Att_Click(object sender, EventArgs e)
        {
            // 兩鈕未點，並點擊攻擊鈕
            if (Att.Text == "攻擊方")
            {
                // 防守鈕已點，並點擊攻擊鈕
                if (Def.Text == "(防守方)")
                {
                    Def.BackColor = Color.Gray; Def.Text = "防守方";
                    // 攻擊圖片顯示
                    ImageButton1.Visible = true; ImageButton3.Visible = true; ImageButton4.Visible = true;
                    ImageButton7.Visible = true; ImageButton9.Visible = true; ImageButton10.Visible = true;
                    ImageButton12.Visible = true; ImageButton15.Visible = true; ImageButton16.Visible = true;
                    ImageButton19.Visible = true; ImageButton22.Visible = true; ImageButton23.Visible = true;
                    ImageButton25.Visible = true; ImageButton26.Visible = true; ImageButton28.Visible = true;
                    ImageButton31.Visible = true; ImageButton32.Visible = true; ImageButton35.Visible = true;
                    ImageButton36.Visible = true; ImageButton38.Visible = true; ImageButton41.Visible = true;
                    ImageButton43.Visible = true; ImageButton44.Visible = true; ImageButton47.Visible = true;
                    ImageButton48.Visible = true; ImageButton49.Visible = true; ImageButton54.Visible = true;
                    ImageButton55.Visible = true; ImageButton56.Visible = true; ImageButton57.Visible = true;
                }
                Att.BackColor = Color.Blue;
                Att.Text = "(攻擊方)";
                // 防守圖片隱藏
                ImageButton2.Visible = false; ImageButton5.Visible = false; ImageButton6.Visible = false;
                ImageButton8.Visible = false; ImageButton11.Visible = false; ImageButton13.Visible = false;
                ImageButton14.Visible = false; ImageButton17.Visible = false; ImageButton18.Visible = false;
                ImageButton20.Visible = false; ImageButton21.Visible = false; ImageButton24.Visible = false;
                ImageButton27.Visible = false; ImageButton29.Visible = false; ImageButton30.Visible = false;
                ImageButton33.Visible = false; ImageButton34.Visible = false; ImageButton37.Visible = false;
                ImageButton39.Visible = false; ImageButton40.Visible = false; ImageButton42.Visible = false;
                ImageButton45.Visible = false; ImageButton46.Visible = false; ImageButton50.Visible = false;
                ImageButton51.Visible = false; ImageButton52.Visible = false; ImageButton53.Visible = false;
                ImageButton58.Visible = false; ImageButton59.Visible = false;

                // DropList選項變更
                DropDownList1.Items[3].Enabled = false; DropDownList1.Items[7].Enabled = false;
                DropDownList1.Items[15].Enabled = false; DropDownList1.Items[16].Enabled = false;
            }
            // 點擊攻擊鈕，將其取消
            else if (Att.Text == "(攻擊方)")
            {
                Att.BackColor = Color.Gray;
                Att.Text = "攻擊方";
                // 防守圖片顯示
                ImageButton2.Visible = true; ImageButton5.Visible = true; ImageButton6.Visible = true;
                ImageButton8.Visible = true; ImageButton11.Visible = true; ImageButton13.Visible = true;
                ImageButton14.Visible = true; ImageButton17.Visible = true; ImageButton18.Visible = true;
                ImageButton20.Visible = true; ImageButton21.Visible = true; ImageButton24.Visible = true;
                ImageButton27.Visible = true; ImageButton29.Visible = true; ImageButton30.Visible = true;
                ImageButton33.Visible = true; ImageButton34.Visible = true; ImageButton37.Visible = true;
                ImageButton39.Visible = true; ImageButton40.Visible = true; ImageButton42.Visible = true;
                ImageButton45.Visible = true; ImageButton46.Visible = true; ImageButton50.Visible = true;
                ImageButton51.Visible = true; ImageButton52.Visible = true; ImageButton53.Visible = true;
                ImageButton58.Visible = true; ImageButton59.Visible = true;
                // DropList選項變更
                DropDownList1.Items[3].Enabled = true; DropDownList1.Items[7].Enabled = true;
                DropDownList1.Items[15].Enabled = true; DropDownList1.Items[16].Enabled = true;
            }
        }

        // 防守方按鈕觸發事件
        protected void Def_Click(object sender, EventArgs e)
        {
            // 兩鈕未點，並點擊防守鈕
            if (Def.Text == "防守方")
            {
                // 攻擊鈕已點，並點擊防守鈕
                if (Att.Text == "(攻擊方)")
                {
                    Att.BackColor = Color.Gray; Att.Text = "攻擊方";
                    // 防守圖片顯示
                    ImageButton2.Visible = true; ImageButton5.Visible = true; ImageButton6.Visible = true;
                    ImageButton8.Visible = true; ImageButton11.Visible = true; ImageButton13.Visible = true;
                    ImageButton14.Visible = true; ImageButton17.Visible = true; ImageButton18.Visible = true;
                    ImageButton20.Visible = true; ImageButton21.Visible = true; ImageButton24.Visible = true;
                    ImageButton27.Visible = true; ImageButton29.Visible = true; ImageButton30.Visible = true;
                    ImageButton33.Visible = true; ImageButton34.Visible = true; ImageButton37.Visible = true;
                    ImageButton39.Visible = true; ImageButton40.Visible = true; ImageButton42.Visible = true;
                    ImageButton45.Visible = true; ImageButton46.Visible = true; ImageButton50.Visible = true;
                    ImageButton51.Visible = true; ImageButton52.Visible = true; ImageButton53.Visible = true;
                    ImageButton58.Visible = true; ImageButton59.Visible = true;
                }
                Def.BackColor = Color.Orange;
                Def.Text = "(防守方)";
                // 攻擊圖片隱藏
                ImageButton1.Visible = false; ImageButton3.Visible = false; ImageButton4.Visible = false;
                ImageButton7.Visible = false; ImageButton9.Visible = false; ImageButton10.Visible = false;
                ImageButton12.Visible = false; ImageButton15.Visible = false; ImageButton16.Visible = false;
                ImageButton19.Visible = false; ImageButton22.Visible = false; ImageButton23.Visible = false;
                ImageButton25.Visible = false; ImageButton26.Visible = false; ImageButton28.Visible = false;
                ImageButton31.Visible = false; ImageButton32.Visible = false; ImageButton35.Visible = false;
                ImageButton36.Visible = false; ImageButton38.Visible = false; ImageButton41.Visible = false;
                ImageButton43.Visible = false; ImageButton44.Visible = false; ImageButton47.Visible = false;
                ImageButton48.Visible = false; ImageButton49.Visible = false; ImageButton54.Visible = false;
                ImageButton55.Visible = false; ImageButton56.Visible = false; ImageButton57.Visible = false;
                // DropList選項變更
                DropDownList1.Items[2].Enabled = false; DropDownList1.Items[4].Enabled = false; DropDownList1.Items[5].Enabled = false;
                DropDownList1.Items[6].Enabled = false; DropDownList1.Items[8].Enabled = false; DropDownList1.Items[10].Enabled = false;
            }
            // 點擊防守鈕，將其取消
            else if (Def.Text == "(防守方)")
            {
                Def.BackColor = Color.Gray;
                Def.Text = "防守方";
                // 攻擊圖片顯示
                ImageButton1.Visible = true; ImageButton3.Visible = true; ImageButton4.Visible = true;
                ImageButton7.Visible = true; ImageButton9.Visible = true; ImageButton10.Visible = true;
                ImageButton12.Visible = true; ImageButton15.Visible = true; ImageButton16.Visible = true;
                ImageButton19.Visible = true; ImageButton22.Visible = true; ImageButton23.Visible = true;
                ImageButton25.Visible = true; ImageButton26.Visible = true; ImageButton28.Visible = true;
                ImageButton31.Visible = true; ImageButton32.Visible = true; ImageButton35.Visible = true;
                ImageButton36.Visible = true; ImageButton38.Visible = true; ImageButton41.Visible = true;
                ImageButton43.Visible = true; ImageButton44.Visible = true; ImageButton47.Visible = true;
                ImageButton48.Visible = true; ImageButton49.Visible = true; ImageButton54.Visible = true;
                ImageButton55.Visible = true; ImageButton56.Visible = true; ImageButton57.Visible = true;
                // DropList選項變更
                DropDownList1.Items[2].Enabled = true; DropDownList1.Items[4].Enabled = true; DropDownList1.Items[5].Enabled = true;
                DropDownList1.Items[6].Enabled = true; DropDownList1.Items[8].Enabled = true; DropDownList1.Items[10].Enabled = true;
            }
        }

        // 檢視Droplist項目
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 全部開啟
            if (DropDownList1.SelectedValue == "1")
            {
                Att.Enabled = true; Def.Enabled = true;
                ImageButton1.Visible = true; ImageButton3.Visible = true; ImageButton4.Visible = true;
                ImageButton7.Visible = true; ImageButton9.Visible = true; ImageButton10.Visible = true;
                ImageButton12.Visible = true; ImageButton15.Visible = true; ImageButton16.Visible = true;
                ImageButton19.Visible = true; ImageButton22.Visible = true; ImageButton23.Visible = true;
                ImageButton25.Visible = true; ImageButton26.Visible = true; ImageButton28.Visible = true;
                ImageButton31.Visible = true; ImageButton32.Visible = true; ImageButton35.Visible = true;
                ImageButton36.Visible = true; ImageButton38.Visible = true; ImageButton41.Visible = true;
                ImageButton43.Visible = true; ImageButton44.Visible = true; ImageButton47.Visible = true;
                ImageButton48.Visible = true; ImageButton49.Visible = true; ImageButton54.Visible = true;
                ImageButton55.Visible = true; ImageButton56.Visible = true; ImageButton57.Visible = true;
                ImageButton2.Visible = true; ImageButton5.Visible = true; ImageButton6.Visible = true;
                ImageButton8.Visible = true; ImageButton11.Visible = true; ImageButton13.Visible = true;
                ImageButton14.Visible = true; ImageButton17.Visible = true; ImageButton18.Visible = true;
                ImageButton20.Visible = true; ImageButton21.Visible = true; ImageButton24.Visible = true;
                ImageButton27.Visible = true; ImageButton29.Visible = true; ImageButton30.Visible = true;
                ImageButton33.Visible = true; ImageButton34.Visible = true; ImageButton37.Visible = true;
                ImageButton39.Visible = true; ImageButton40.Visible = true; ImageButton42.Visible = true;
                ImageButton45.Visible = true; ImageButton46.Visible = true; ImageButton50.Visible = true;
                ImageButton51.Visible = true; ImageButton52.Visible = true; ImageButton53.Visible = true;
                ImageButton58.Visible = true; ImageButton59.Visible = true;
            }
            // 軟突破
            if (DropDownList1.SelectedValue == "2")
            {
                Att.Enabled = true; Def.Enabled = true;
                ImageButton1.Visible = true; ImageButton2.Visible = false; ImageButton3.Visible = false; ImageButton4.Visible = false;
                ImageButton5.Visible = false; ImageButton6.Visible = true; ImageButton7.Visible = false; ImageButton8.Visible = false;
                ImageButton9.Visible = false; ImageButton10.Visible = false; ImageButton11.Visible = false; ImageButton12.Visible = false;
                ImageButton13.Visible = false; ImageButton14.Visible = false; ImageButton15.Visible = false; ImageButton16.Visible = false;
                ImageButton17.Visible = false; ImageButton18.Visible = false; ImageButton19.Visible = false; ImageButton20.Visible = false;
                ImageButton21.Visible = false; ImageButton22.Visible = false; ImageButton23.Visible = false; ImageButton24.Visible = false;
                ImageButton25.Visible = false; ImageButton26.Visible = true; ImageButton27.Visible = false; ImageButton28.Visible = false;
                ImageButton29.Visible = false; ImageButton30.Visible = false; ImageButton31.Visible = false; ImageButton32.Visible = false;
                ImageButton33.Visible = false; ImageButton34.Visible = false; ImageButton35.Visible = false; ImageButton36.Visible = false;
                ImageButton37.Visible = false; ImageButton38.Visible = true; ImageButton39.Visible = false; ImageButton40.Visible = false;
                ImageButton41.Visible = true; ImageButton42.Visible = false; ImageButton43.Visible = false; ImageButton44.Visible = true;
                ImageButton45.Visible = false; ImageButton46.Visible = false; ImageButton47.Visible = false; ImageButton48.Visible = false;
                ImageButton49.Visible = false; ImageButton50.Visible = false; ImageButton51.Visible = false; ImageButton52.Visible = false;
                ImageButton53.Visible = false; ImageButton54.Visible = false; ImageButton55.Visible = false; ImageButton56.Visible = false;
                ImageButton57.Visible = true; ImageButton58.Visible = false; ImageButton59.Visible = false;
            }
            // 硬突破
            if (DropDownList1.SelectedValue == "3")
            {
                Att.Enabled = true; Def.Enabled = false;
                ImageButton1.Visible = false; ImageButton2.Visible = false; ImageButton3.Visible = false; ImageButton4.Visible = true;
                ImageButton5.Visible = false; ImageButton6.Visible = false; ImageButton7.Visible = false; ImageButton8.Visible = false;
                ImageButton9.Visible = false; ImageButton10.Visible = false; ImageButton11.Visible = false; ImageButton12.Visible = false;
                ImageButton13.Visible = false; ImageButton14.Visible = false; ImageButton15.Visible = false; ImageButton16.Visible = false;
                ImageButton17.Visible = false; ImageButton18.Visible = false; ImageButton19.Visible = true; ImageButton20.Visible = false;
                ImageButton21.Visible = false; ImageButton22.Visible = false; ImageButton23.Visible = false; ImageButton24.Visible = false;
                ImageButton25.Visible = false; ImageButton26.Visible = false; ImageButton27.Visible = false; ImageButton28.Visible = false;
                ImageButton29.Visible = false; ImageButton30.Visible = false; ImageButton31.Visible = false; ImageButton32.Visible = true;
                ImageButton33.Visible = false; ImageButton34.Visible = false; ImageButton35.Visible = false; ImageButton36.Visible = false;
                ImageButton37.Visible = false; ImageButton38.Visible = false; ImageButton39.Visible = false; ImageButton40.Visible = false;
                ImageButton41.Visible = false; ImageButton42.Visible = false; ImageButton43.Visible = false; ImageButton44.Visible = false;
                ImageButton45.Visible = false; ImageButton46.Visible = false; ImageButton47.Visible = true; ImageButton48.Visible = false;
                ImageButton49.Visible = false; ImageButton50.Visible = false; ImageButton51.Visible = false; ImageButton52.Visible = false;
                ImageButton53.Visible = false; ImageButton54.Visible = false; ImageButton55.Visible = false; ImageButton56.Visible = false;
                ImageButton57.Visible = false; ImageButton58.Visible = false; ImageButton59.Visible = false;
            }
            // 反硬突破
            if (DropDownList1.SelectedValue == "4")
            {
                Att.Enabled = false; Def.Enabled = true;
                ImageButton1.Visible = false; ImageButton2.Visible = false; ImageButton3.Visible = false; ImageButton4.Visible = false;
                ImageButton5.Visible = false; ImageButton6.Visible = false; ImageButton7.Visible = false; ImageButton8.Visible = false;
                ImageButton9.Visible = false; ImageButton10.Visible = false; ImageButton11.Visible = false; ImageButton12.Visible = false;
                ImageButton13.Visible = false; ImageButton14.Visible = false; ImageButton15.Visible = false; ImageButton16.Visible = false;
                ImageButton17.Visible = true; ImageButton18.Visible = false; ImageButton19.Visible = false; ImageButton20.Visible = false;
                ImageButton21.Visible = false; ImageButton22.Visible = false; ImageButton23.Visible = false; ImageButton24.Visible = false;
                ImageButton25.Visible = false; ImageButton26.Visible = false; ImageButton27.Visible = false; ImageButton28.Visible = false;
                ImageButton29.Visible = false; ImageButton30.Visible = false; ImageButton31.Visible = false; ImageButton32.Visible = false;
                ImageButton33.Visible = false; ImageButton34.Visible = false; ImageButton35.Visible = false; ImageButton36.Visible = false;
                ImageButton37.Visible = false; ImageButton38.Visible = false; ImageButton39.Visible = false; ImageButton40.Visible = true;
                ImageButton41.Visible = false; ImageButton42.Visible = false; ImageButton43.Visible = false; ImageButton44.Visible = false;
                ImageButton45.Visible = false; ImageButton46.Visible = false; ImageButton47.Visible = false; ImageButton48.Visible = false;
                ImageButton49.Visible = false; ImageButton50.Visible = false; ImageButton51.Visible = false; ImageButton52.Visible = false;
                ImageButton53.Visible = true; ImageButton54.Visible = false; ImageButton55.Visible = false; ImageButton56.Visible = false;
                ImageButton57.Visible = false; ImageButton58.Visible = false; ImageButton59.Visible = false;
            }
            // 前鋒
            if (DropDownList1.SelectedValue == "5")
            {
                Att.Enabled = true; Def.Enabled = false;
                ImageButton1.Visible = false; ImageButton2.Visible = false; ImageButton3.Visible = false; ImageButton4.Visible = true;
                ImageButton5.Visible = false; ImageButton6.Visible = false; ImageButton7.Visible = false; ImageButton8.Visible = false;
                ImageButton9.Visible = false; ImageButton10.Visible = true; ImageButton11.Visible = false; ImageButton12.Visible = false;
                ImageButton13.Visible = false; ImageButton14.Visible = false; ImageButton15.Visible = false; ImageButton16.Visible = false;
                ImageButton17.Visible = false; ImageButton18.Visible = false; ImageButton19.Visible = false; ImageButton20.Visible = false;
                ImageButton21.Visible = false; ImageButton22.Visible = false; ImageButton23.Visible = false; ImageButton24.Visible = false;
                ImageButton25.Visible = false; ImageButton26.Visible = false; ImageButton27.Visible = false; ImageButton28.Visible = true;
                ImageButton29.Visible = false; ImageButton30.Visible = false; ImageButton31.Visible = false; ImageButton32.Visible = true;
                ImageButton33.Visible = false; ImageButton34.Visible = false; ImageButton35.Visible = true; ImageButton36.Visible = false;
                ImageButton37.Visible = false; ImageButton38.Visible = false; ImageButton39.Visible = false; ImageButton40.Visible = false;
                ImageButton41.Visible = false; ImageButton42.Visible = false; ImageButton43.Visible = false; ImageButton44.Visible = true;
                ImageButton45.Visible = false; ImageButton46.Visible = false; ImageButton47.Visible = false; ImageButton48.Visible = false;
                ImageButton49.Visible = true; ImageButton50.Visible = false; ImageButton51.Visible = false; ImageButton52.Visible = false;
                ImageButton53.Visible = false; ImageButton54.Visible = true; ImageButton55.Visible = true; ImageButton56.Visible = false;
                ImageButton57.Visible = false; ImageButton58.Visible = false; ImageButton59.Visible = false;
            }
            // 後衛
            if (DropDownList1.SelectedValue == "6")
            {
                Att.Enabled = true; Def.Enabled = false;
                ImageButton1.Visible = true; ImageButton2.Visible = false; ImageButton3.Visible = false; ImageButton4.Visible = false;
                ImageButton5.Visible = false; ImageButton6.Visible = false; ImageButton7.Visible = false; ImageButton8.Visible = false;
                ImageButton9.Visible = true; ImageButton10.Visible = false; ImageButton11.Visible = false; ImageButton12.Visible = false;
                ImageButton13.Visible = false; ImageButton14.Visible = false; ImageButton15.Visible = false; ImageButton16.Visible = false;
                ImageButton17.Visible = false; ImageButton18.Visible = false; ImageButton19.Visible = true; ImageButton20.Visible = false;
                ImageButton21.Visible = false; ImageButton22.Visible = true; ImageButton23.Visible = true; ImageButton24.Visible = false;
                ImageButton25.Visible = false; ImageButton26.Visible = false; ImageButton27.Visible = false; ImageButton28.Visible = false;
                ImageButton29.Visible = false; ImageButton30.Visible = false; ImageButton31.Visible = false; ImageButton32.Visible = true;
                ImageButton33.Visible = false; ImageButton34.Visible = false; ImageButton35.Visible = false; ImageButton36.Visible = true;
                ImageButton37.Visible = false; ImageButton38.Visible = false; ImageButton39.Visible = false; ImageButton40.Visible = false;
                ImageButton41.Visible = false; ImageButton42.Visible = false; ImageButton43.Visible = true; ImageButton44.Visible = false;
                ImageButton45.Visible = false; ImageButton46.Visible = false; ImageButton47.Visible = true; ImageButton48.Visible = false;
                ImageButton49.Visible = true; ImageButton50.Visible = false; ImageButton51.Visible = false; ImageButton52.Visible = false;
                ImageButton53.Visible = false; ImageButton54.Visible = false; ImageButton55.Visible = false; ImageButton56.Visible = false;
                ImageButton57.Visible = true; ImageButton58.Visible = false; ImageButton59.Visible = false;
            }
            // 側翼
            if (DropDownList1.SelectedValue == "7")
            {
                Att.Enabled = true; Def.Enabled = false;
                ImageButton1.Visible = false; ImageButton2.Visible = false; ImageButton3.Visible = false; ImageButton4.Visible = false;
                ImageButton5.Visible = false; ImageButton6.Visible = false; ImageButton7.Visible = false; ImageButton8.Visible = false;
                ImageButton9.Visible = false; ImageButton10.Visible = true; ImageButton11.Visible = false; ImageButton12.Visible = true;
                ImageButton13.Visible = false; ImageButton14.Visible = false; ImageButton15.Visible = false; ImageButton16.Visible = false;
                ImageButton17.Visible = false; ImageButton18.Visible = false; ImageButton19.Visible = true; ImageButton20.Visible = false;
                ImageButton21.Visible = false; ImageButton22.Visible = false; ImageButton23.Visible = false; ImageButton24.Visible = false;
                ImageButton25.Visible = true; ImageButton26.Visible = true; ImageButton27.Visible = false; ImageButton28.Visible = false;
                ImageButton29.Visible = false; ImageButton30.Visible = false; ImageButton31.Visible = false; ImageButton32.Visible = false;
                ImageButton33.Visible = false; ImageButton34.Visible = false; ImageButton35.Visible = true; ImageButton36.Visible = false;
                ImageButton37.Visible = false; ImageButton38.Visible = false; ImageButton39.Visible = false; ImageButton40.Visible = false;
                ImageButton41.Visible = true; ImageButton42.Visible = false; ImageButton43.Visible = false; ImageButton44.Visible = true;
                ImageButton45.Visible = false; ImageButton46.Visible = false; ImageButton47.Visible = false; ImageButton48.Visible = false;
                ImageButton49.Visible = false; ImageButton50.Visible = false; ImageButton51.Visible = false; ImageButton52.Visible = false;
                ImageButton53.Visible = false; ImageButton54.Visible = false; ImageButton55.Visible = true; ImageButton56.Visible = true;
                ImageButton57.Visible = false; ImageButton58.Visible = false; ImageButton59.Visible = false;
            }
            // 游擊
            if (DropDownList1.SelectedValue == "8")
            {
                Att.Enabled = false; Def.Enabled = true;
                ImageButton1.Visible = false; ImageButton2.Visible = false; ImageButton3.Visible = false; ImageButton4.Visible = false;
                ImageButton5.Visible = false; ImageButton6.Visible = true; ImageButton7.Visible = false; ImageButton8.Visible = false;
                ImageButton9.Visible = false; ImageButton10.Visible = false; ImageButton11.Visible = false; ImageButton12.Visible = false;
                ImageButton13.Visible = false; ImageButton14.Visible = false; ImageButton15.Visible = false; ImageButton16.Visible = false;
                ImageButton17.Visible = false; ImageButton18.Visible = false; ImageButton19.Visible = false; ImageButton20.Visible = false;
                ImageButton21.Visible = true; ImageButton22.Visible = false; ImageButton23.Visible = false; ImageButton24.Visible = true;
                ImageButton25.Visible = false; ImageButton26.Visible = false; ImageButton27.Visible = true; ImageButton28.Visible = false;
                ImageButton29.Visible = true; ImageButton30.Visible = false; ImageButton31.Visible = false; ImageButton32.Visible = false;
                ImageButton33.Visible = false; ImageButton34.Visible = true; ImageButton35.Visible = false; ImageButton36.Visible = false;
                ImageButton37.Visible = true; ImageButton38.Visible = false; ImageButton39.Visible = false; ImageButton40.Visible = false;
                ImageButton41.Visible = false; ImageButton42.Visible = false; ImageButton43.Visible = false; ImageButton44.Visible = false;
                ImageButton45.Visible = false; ImageButton46.Visible = true; ImageButton47.Visible = false; ImageButton48.Visible = false;
                ImageButton49.Visible = false; ImageButton50.Visible = false; ImageButton51.Visible = false; ImageButton52.Visible = true;
                ImageButton53.Visible = true; ImageButton54.Visible = false; ImageButton55.Visible = false; ImageButton56.Visible = false;
                ImageButton57.Visible = false; ImageButton58.Visible = false; ImageButton59.Visible = false;
            }
            // 反游擊
            if (DropDownList1.SelectedValue == "9")
            {
                Att.Enabled = true; Def.Enabled = false;
                ImageButton1.Visible = false; ImageButton2.Visible = false; ImageButton3.Visible = false; ImageButton4.Visible = false;
                ImageButton5.Visible = false; ImageButton6.Visible = false; ImageButton7.Visible = false; ImageButton8.Visible = false;
                ImageButton9.Visible = false; ImageButton10.Visible = false; ImageButton11.Visible = false; ImageButton12.Visible = false;
                ImageButton13.Visible = false; ImageButton14.Visible = false; ImageButton15.Visible = true; ImageButton16.Visible = true;
                ImageButton17.Visible = false; ImageButton18.Visible = false; ImageButton19.Visible = false; ImageButton20.Visible = false;
                ImageButton21.Visible = false; ImageButton22.Visible = false; ImageButton23.Visible = true; ImageButton24.Visible = false;
                ImageButton25.Visible = true; ImageButton26.Visible = true; ImageButton27.Visible = false; ImageButton28.Visible = false;
                ImageButton29.Visible = false; ImageButton30.Visible = false; ImageButton31.Visible = true; ImageButton32.Visible = false;
                ImageButton33.Visible = false; ImageButton34.Visible = false; ImageButton35.Visible = false; ImageButton36.Visible = false;
                ImageButton37.Visible = false; ImageButton38.Visible = false; ImageButton39.Visible = false; ImageButton40.Visible = false;
                ImageButton41.Visible = false; ImageButton42.Visible = false; ImageButton43.Visible = false; ImageButton44.Visible = false;
                ImageButton45.Visible = false; ImageButton46.Visible = false; ImageButton47.Visible = false; ImageButton48.Visible = false;
                ImageButton49.Visible = false; ImageButton50.Visible = false; ImageButton51.Visible = false; ImageButton52.Visible = false;
                ImageButton53.Visible = false; ImageButton54.Visible = true; ImageButton55.Visible = false; ImageButton56.Visible = false;
                ImageButton57.Visible = false; ImageButton58.Visible = false; ImageButton59.Visible = false;
            }
            // 盾
            if (DropDownList1.SelectedValue == "10")
            {
                Att.Enabled = true; Def.Enabled = true;
                ImageButton1.Visible = false; ImageButton2.Visible = false; ImageButton3.Visible = false; ImageButton4.Visible = false;
                ImageButton5.Visible = false; ImageButton6.Visible = false; ImageButton7.Visible = false; ImageButton8.Visible = false;
                ImageButton9.Visible = false; ImageButton10.Visible = false; ImageButton11.Visible = false; ImageButton12.Visible = false;
                ImageButton13.Visible = false; ImageButton14.Visible = false; ImageButton15.Visible = false; ImageButton16.Visible = false;
                ImageButton17.Visible = false; ImageButton18.Visible = true; ImageButton19.Visible = false; ImageButton20.Visible = false;
                ImageButton21.Visible = false; ImageButton22.Visible = false; ImageButton23.Visible = false; ImageButton24.Visible = false;
                ImageButton25.Visible = false; ImageButton26.Visible = false; ImageButton27.Visible = false; ImageButton28.Visible = false;
                ImageButton29.Visible = false; ImageButton30.Visible = false; ImageButton31.Visible = false; ImageButton32.Visible = false;
                ImageButton33.Visible = false; ImageButton34.Visible = false; ImageButton35.Visible = false; ImageButton36.Visible = true;
                ImageButton37.Visible = false; ImageButton38.Visible = false; ImageButton39.Visible = false; ImageButton40.Visible = false;
                ImageButton41.Visible = false; ImageButton42.Visible = false; ImageButton43.Visible = false; ImageButton44.Visible = false;
                ImageButton45.Visible = false; ImageButton46.Visible = false; ImageButton47.Visible = false; ImageButton48.Visible = true;
                ImageButton49.Visible = false; ImageButton50.Visible = false; ImageButton51.Visible = false; ImageButton52.Visible = false;
                ImageButton53.Visible = false; ImageButton54.Visible = true; ImageButton55.Visible = false; ImageButton56.Visible = false;
                ImageButton57.Visible = false; ImageButton58.Visible = true; ImageButton59.Visible = false;
            }
            // 牽制
            if (DropDownList1.SelectedValue == "11")
            {
                Att.Enabled = true; Def.Enabled = false;
                ImageButton1.Visible = true; ImageButton2.Visible = false; ImageButton3.Visible = false; ImageButton4.Visible = false;
                ImageButton5.Visible = false; ImageButton6.Visible = false; ImageButton7.Visible = false; ImageButton8.Visible = false;
                ImageButton9.Visible = true; ImageButton10.Visible = false; ImageButton11.Visible = false; ImageButton12.Visible = false;
                ImageButton13.Visible = false; ImageButton14.Visible = false; ImageButton15.Visible = false; ImageButton16.Visible = false;
                ImageButton17.Visible = false; ImageButton18.Visible = false; ImageButton19.Visible = true; ImageButton20.Visible = false;
                ImageButton21.Visible = false; ImageButton22.Visible = false; ImageButton23.Visible = false; ImageButton24.Visible = false;
                ImageButton25.Visible = false; ImageButton26.Visible = true; ImageButton27.Visible = false; ImageButton28.Visible = false;
                ImageButton29.Visible = false; ImageButton30.Visible = false; ImageButton31.Visible = false; ImageButton32.Visible = false;
                ImageButton33.Visible = false; ImageButton34.Visible = false; ImageButton35.Visible = false; ImageButton36.Visible = false;
                ImageButton37.Visible = false; ImageButton38.Visible = false; ImageButton39.Visible = false; ImageButton40.Visible = false;
                ImageButton41.Visible = false; ImageButton42.Visible = false; ImageButton43.Visible = true; ImageButton44.Visible = true;
                ImageButton45.Visible = false; ImageButton46.Visible = false; ImageButton47.Visible = false; ImageButton48.Visible = false;
                ImageButton49.Visible = true; ImageButton50.Visible = false; ImageButton51.Visible = false; ImageButton52.Visible = false;
                ImageButton53.Visible = false; ImageButton54.Visible = false; ImageButton55.Visible = true; ImageButton56.Visible = true;
                ImageButton57.Visible = false; ImageButton58.Visible = false; ImageButton59.Visible = false;
            }
            // 陷阱
            if (DropDownList1.SelectedValue == "12")
            {
                Att.Enabled = true; Def.Enabled = true;
                ImageButton1.Visible = false; ImageButton2.Visible = false; ImageButton3.Visible = false; ImageButton4.Visible = false;
                ImageButton5.Visible = false; ImageButton6.Visible = false; ImageButton7.Visible = false; ImageButton8.Visible = false;
                ImageButton9.Visible = false; ImageButton10.Visible = false; ImageButton11.Visible = false; ImageButton12.Visible = false;
                ImageButton13.Visible = false; ImageButton14.Visible = false; ImageButton15.Visible = false; ImageButton16.Visible = true;
                ImageButton17.Visible = false; ImageButton18.Visible = false; ImageButton19.Visible = false; ImageButton20.Visible = false;
                ImageButton21.Visible = true; ImageButton22.Visible = false; ImageButton23.Visible = false; ImageButton24.Visible = false;
                ImageButton25.Visible = false; ImageButton26.Visible = false; ImageButton27.Visible = true; ImageButton28.Visible = false;
                ImageButton29.Visible = true; ImageButton30.Visible = false; ImageButton31.Visible = false; ImageButton32.Visible = false;
                ImageButton33.Visible = false; ImageButton34.Visible = false; ImageButton35.Visible = false; ImageButton36.Visible = false;
                ImageButton37.Visible = false; ImageButton38.Visible = false; ImageButton39.Visible = true; ImageButton40.Visible = false;
                ImageButton41.Visible = false; ImageButton42.Visible = false; ImageButton43.Visible = false; ImageButton44.Visible = false;
                ImageButton45.Visible = false; ImageButton46.Visible = false; ImageButton47.Visible = false; ImageButton48.Visible = false;
                ImageButton49.Visible = false; ImageButton50.Visible = false; ImageButton51.Visible = false; ImageButton52.Visible = false;
                ImageButton53.Visible = false; ImageButton54.Visible = false; ImageButton55.Visible = false; ImageButton56.Visible = false;
                ImageButton57.Visible = false; ImageButton58.Visible = false; ImageButton59.Visible = true;
            }
            // 情資蒐集
            if (DropDownList1.SelectedValue == "13")
            {
                Att.Enabled = true; Def.Enabled = true;
                ImageButton1.Visible = false; ImageButton2.Visible = true; ImageButton3.Visible = true; ImageButton4.Visible = false;
                ImageButton5.Visible = true; ImageButton6.Visible = false; ImageButton7.Visible = true; ImageButton8.Visible = false;
                ImageButton9.Visible = false; ImageButton10.Visible = false; ImageButton11.Visible = false; ImageButton12.Visible = false;
                ImageButton13.Visible = false; ImageButton14.Visible = true; ImageButton15.Visible = false; ImageButton16.Visible = false;
                ImageButton17.Visible = false; ImageButton18.Visible = true; ImageButton19.Visible = false; ImageButton20.Visible = true;
                ImageButton21.Visible = true; ImageButton22.Visible = false; ImageButton23.Visible = true; ImageButton24.Visible = false;
                ImageButton25.Visible = true; ImageButton26.Visible = false; ImageButton27.Visible = false; ImageButton28.Visible = false;
                ImageButton29.Visible = true; ImageButton30.Visible = true; ImageButton31.Visible = true; ImageButton32.Visible = false;
                ImageButton33.Visible = true; ImageButton34.Visible = true; ImageButton35.Visible = false; ImageButton36.Visible = false;
                ImageButton37.Visible = true; ImageButton38.Visible = false; ImageButton39.Visible = false; ImageButton40.Visible = false;
                ImageButton41.Visible = false; ImageButton42.Visible = false; ImageButton43.Visible = false; ImageButton44.Visible = false;
                ImageButton45.Visible = false; ImageButton46.Visible = true; ImageButton47.Visible = false; ImageButton48.Visible = false;
                ImageButton49.Visible = true; ImageButton50.Visible = false; ImageButton51.Visible = false; ImageButton52.Visible = false;
                ImageButton53.Visible = false; ImageButton54.Visible = false; ImageButton55.Visible = true; ImageButton56.Visible = false;
                ImageButton57.Visible = false; ImageButton58.Visible = false; ImageButton59.Visible = false;
            }
            // 情資阻絕
            if (DropDownList1.SelectedValue == "14")
            {
                Att.Enabled = true; Def.Enabled = true;
                ImageButton1.Visible = false; ImageButton2.Visible = false; ImageButton3.Visible = true; ImageButton4.Visible = false;
                ImageButton5.Visible = false; ImageButton6.Visible = false; ImageButton7.Visible = true; ImageButton8.Visible = false;
                ImageButton9.Visible = false; ImageButton10.Visible = false; ImageButton11.Visible = false; ImageButton12.Visible = true;
                ImageButton13.Visible = true; ImageButton14.Visible = true; ImageButton15.Visible = false; ImageButton16.Visible = false;
                ImageButton17.Visible = false; ImageButton18.Visible = false; ImageButton19.Visible = false; ImageButton20.Visible = false;
                ImageButton21.Visible = true; ImageButton22.Visible = false; ImageButton23.Visible = false; ImageButton24.Visible = true;
                ImageButton25.Visible = true; ImageButton26.Visible = false; ImageButton27.Visible = false; ImageButton28.Visible = false;
                ImageButton29.Visible = false; ImageButton30.Visible = false; ImageButton31.Visible = false; ImageButton32.Visible = false;
                ImageButton33.Visible = false; ImageButton34.Visible = true; ImageButton35.Visible = false; ImageButton36.Visible = false;
                ImageButton37.Visible = false; ImageButton38.Visible = false; ImageButton39.Visible = false; ImageButton40.Visible = true;
                ImageButton41.Visible = false; ImageButton42.Visible = false; ImageButton43.Visible = false; ImageButton44.Visible = false;
                ImageButton45.Visible = false; ImageButton46.Visible = false; ImageButton47.Visible = false; ImageButton48.Visible = false;
                ImageButton49.Visible = false; ImageButton50.Visible = false; ImageButton51.Visible = false; ImageButton52.Visible = false;
                ImageButton53.Visible = false; ImageButton54.Visible = false; ImageButton55.Visible = false; ImageButton56.Visible = false;
                ImageButton57.Visible = false; ImageButton58.Visible = false; ImageButton59.Visible = false;
            }
            // 區域阻絕
            if (DropDownList1.SelectedValue == "15")
            {
                Att.Enabled = true; Def.Enabled = true;
                ImageButton1.Visible = true; ImageButton2.Visible = false; ImageButton3.Visible = false; ImageButton4.Visible = false;
                ImageButton5.Visible = false; ImageButton6.Visible = false; ImageButton7.Visible = false; ImageButton8.Visible = false;
                ImageButton9.Visible = false; ImageButton10.Visible = false; ImageButton11.Visible = true; ImageButton12.Visible = false;
                ImageButton13.Visible = false; ImageButton14.Visible = false; ImageButton15.Visible = true; ImageButton16.Visible = false;
                ImageButton17.Visible = false; ImageButton18.Visible = false; ImageButton19.Visible = false; ImageButton20.Visible = true;
                ImageButton21.Visible = false; ImageButton22.Visible = false; ImageButton23.Visible = false; ImageButton24.Visible = false;
                ImageButton25.Visible = false; ImageButton26.Visible = false; ImageButton27.Visible = false; ImageButton28.Visible = false;
                ImageButton29.Visible = false; ImageButton30.Visible = false; ImageButton31.Visible = false; ImageButton32.Visible = false;
                ImageButton33.Visible = false; ImageButton34.Visible = false; ImageButton35.Visible = true; ImageButton36.Visible = false;
                ImageButton37.Visible = false; ImageButton38.Visible = false; ImageButton39.Visible = false; ImageButton40.Visible = false;
                ImageButton41.Visible = false; ImageButton42.Visible = true; ImageButton43.Visible = false; ImageButton44.Visible = false;
                ImageButton45.Visible = false; ImageButton46.Visible = false; ImageButton47.Visible = false; ImageButton48.Visible = false;
                ImageButton49.Visible = false; ImageButton50.Visible = false; ImageButton51.Visible = false; ImageButton52.Visible = false;
                ImageButton53.Visible = false; ImageButton54.Visible = false; ImageButton55.Visible = false; ImageButton56.Visible = true;
                ImageButton57.Visible = false; ImageButton58.Visible = false; ImageButton59.Visible = false;
            }
            // 固守者
            if (DropDownList1.SelectedValue == "16")
            {
                Att.Enabled = false; Def.Enabled = true;
                ImageButton1.Visible = false; ImageButton2.Visible = true; ImageButton3.Visible = false; ImageButton4.Visible = false;
                ImageButton5.Visible = false; ImageButton6.Visible = false; ImageButton7.Visible = false; ImageButton8.Visible = true;
                ImageButton9.Visible = false; ImageButton10.Visible = false; ImageButton11.Visible = false; ImageButton12.Visible = false;
                ImageButton13.Visible = true; ImageButton14.Visible = false; ImageButton15.Visible = false; ImageButton16.Visible = false;
                ImageButton17.Visible = true; ImageButton18.Visible = false; ImageButton19.Visible = false; ImageButton20.Visible = true;
                ImageButton21.Visible = false; ImageButton22.Visible = false; ImageButton23.Visible = false; ImageButton24.Visible = false;
                ImageButton25.Visible = false; ImageButton26.Visible = false; ImageButton27.Visible = false; ImageButton28.Visible = false;
                ImageButton29.Visible = true; ImageButton30.Visible = true; ImageButton31.Visible = false; ImageButton32.Visible = false;
                ImageButton33.Visible = true; ImageButton34.Visible = false; ImageButton35.Visible = false; ImageButton36.Visible = false;
                ImageButton37.Visible = false; ImageButton38.Visible = false; ImageButton39.Visible = false; ImageButton40.Visible = false;
                ImageButton41.Visible = false; ImageButton42.Visible = true; ImageButton43.Visible = false; ImageButton44.Visible = false;
                ImageButton45.Visible = true; ImageButton46.Visible = false; ImageButton47.Visible = false; ImageButton48.Visible = false;
                ImageButton49.Visible = false; ImageButton50.Visible = true; ImageButton51.Visible = true; ImageButton52.Visible = false;
                ImageButton53.Visible = false; ImageButton54.Visible = false; ImageButton55.Visible = false; ImageButton56.Visible = false;
                ImageButton57.Visible = false; ImageButton58.Visible = true; ImageButton59.Visible = false;
            }
            // 安全維護
            if (DropDownList1.SelectedValue == "17")
            {
                Att.Enabled = false; Def.Enabled = true;
                ImageButton1.Visible = false; ImageButton2.Visible = true; ImageButton3.Visible = false; ImageButton4.Visible = false;
                ImageButton5.Visible = true; ImageButton6.Visible = false; ImageButton7.Visible = false; ImageButton8.Visible = true;
                ImageButton9.Visible = false; ImageButton10.Visible = false; ImageButton11.Visible = true; ImageButton12.Visible = false;
                ImageButton13.Visible = false; ImageButton14.Visible = true; ImageButton15.Visible = false; ImageButton16.Visible = false;
                ImageButton17.Visible = true; ImageButton18.Visible = true; ImageButton19.Visible = false; ImageButton20.Visible = true;
                ImageButton21.Visible = false; ImageButton22.Visible = false; ImageButton23.Visible = false; ImageButton24.Visible = false;
                ImageButton25.Visible = false; ImageButton26.Visible = false; ImageButton27.Visible = false; ImageButton28.Visible = false;
                ImageButton29.Visible = false; ImageButton30.Visible = true; ImageButton31.Visible = false; ImageButton32.Visible = false;
                ImageButton33.Visible = true; ImageButton34.Visible = false; ImageButton35.Visible = false; ImageButton36.Visible = false;
                ImageButton37.Visible = false; ImageButton38.Visible = false; ImageButton39.Visible = false; ImageButton40.Visible = true;
                ImageButton41.Visible = false; ImageButton42.Visible = true; ImageButton43.Visible = false; ImageButton44.Visible = false;
                ImageButton45.Visible = true; ImageButton46.Visible = false; ImageButton47.Visible = false; ImageButton48.Visible = false;
                ImageButton49.Visible = false; ImageButton50.Visible = false; ImageButton51.Visible = false; ImageButton52.Visible = true;
                ImageButton53.Visible = true; ImageButton54.Visible = false; ImageButton55.Visible = false; ImageButton56.Visible = false;
                ImageButton57.Visible = false; ImageButton58.Visible = false; ImageButton59.Visible = false;
            }
            // 群體控制
            if (DropDownList1.SelectedValue == "18")
            {
                Att.Enabled = true; Def.Enabled = true;
                ImageButton1.Visible = false; ImageButton2.Visible = false; ImageButton3.Visible = false; ImageButton4.Visible = false;
                ImageButton5.Visible = true; ImageButton6.Visible = false; ImageButton7.Visible = false; ImageButton8.Visible = false;
                ImageButton9.Visible = false; ImageButton10.Visible = false; ImageButton11.Visible = false; ImageButton12.Visible = false;
                ImageButton13.Visible = false; ImageButton14.Visible = false; ImageButton15.Visible = true; ImageButton16.Visible = true;
                ImageButton17.Visible = false; ImageButton18.Visible = true; ImageButton19.Visible = false; ImageButton20.Visible = false;
                ImageButton21.Visible = false; ImageButton22.Visible = false; ImageButton23.Visible = true; ImageButton24.Visible = false;
                ImageButton25.Visible = false; ImageButton26.Visible = true; ImageButton27.Visible = true; ImageButton28.Visible = true;
                ImageButton29.Visible = true; ImageButton30.Visible = false; ImageButton31.Visible = false; ImageButton32.Visible = false;
                ImageButton33.Visible = true; ImageButton34.Visible = false; ImageButton35.Visible = false; ImageButton36.Visible = false;
                ImageButton37.Visible = false; ImageButton38.Visible = false; ImageButton39.Visible = true; ImageButton40.Visible = false;
                ImageButton41.Visible = false; ImageButton42.Visible = false; ImageButton43.Visible = false; ImageButton44.Visible = false;
                ImageButton45.Visible = false; ImageButton46.Visible = false; ImageButton47.Visible = false; ImageButton48.Visible = false;
                ImageButton49.Visible = false; ImageButton50.Visible = false; ImageButton51.Visible = false; ImageButton52.Visible = false;
                ImageButton53.Visible = false; ImageButton54.Visible = true; ImageButton55.Visible = false; ImageButton56.Visible = false;
                ImageButton57.Visible = false; ImageButton58.Visible = false; ImageButton59.Visible = false;
            }
            // 火力掩護
            if (DropDownList1.SelectedValue == "19")
            {
                Att.Enabled = true; Def.Enabled = true;
                ImageButton1.Visible = false; ImageButton2.Visible = false; ImageButton3.Visible = false; ImageButton4.Visible = false;
                ImageButton5.Visible = false; ImageButton6.Visible = false; ImageButton7.Visible = false; ImageButton8.Visible = false;
                ImageButton9.Visible = true; ImageButton10.Visible = false; ImageButton11.Visible = false; ImageButton12.Visible = false;
                ImageButton13.Visible = false; ImageButton14.Visible = false; ImageButton15.Visible = false; ImageButton16.Visible = false;
                ImageButton17.Visible = false; ImageButton18.Visible = false; ImageButton19.Visible = false; ImageButton20.Visible = false;
                ImageButton21.Visible = false; ImageButton22.Visible = false; ImageButton23.Visible = false; ImageButton24.Visible = false;
                ImageButton25.Visible = false; ImageButton26.Visible = false; ImageButton27.Visible = false; ImageButton28.Visible = false;
                ImageButton29.Visible = false; ImageButton30.Visible = false; ImageButton31.Visible = false; ImageButton32.Visible = false;
                ImageButton33.Visible = false; ImageButton34.Visible = false; ImageButton35.Visible = false; ImageButton36.Visible = true;
                ImageButton37.Visible = false; ImageButton38.Visible = false; ImageButton39.Visible = false; ImageButton40.Visible = false;
                ImageButton41.Visible = false; ImageButton42.Visible = false; ImageButton43.Visible = false; ImageButton44.Visible = false;
                ImageButton45.Visible = false; ImageButton46.Visible = false; ImageButton47.Visible = false; ImageButton48.Visible = false;
                ImageButton49.Visible = false; ImageButton50.Visible = false; ImageButton51.Visible = false; ImageButton52.Visible = false;
                ImageButton53.Visible = false; ImageButton54.Visible = false; ImageButton55.Visible = false; ImageButton56.Visible = false;
                ImageButton57.Visible = true; ImageButton58.Visible = true; ImageButton59.Visible = false;
            }
            // 增益效果
            if (DropDownList1.SelectedValue == "20")
            {
                Att.Enabled = true; Def.Enabled = true;
                ImageButton1.Visible = false; ImageButton2.Visible = false; ImageButton3.Visible = false; ImageButton4.Visible = false;
                ImageButton5.Visible = false; ImageButton6.Visible = false; ImageButton7.Visible = false; ImageButton8.Visible = false;
                ImageButton9.Visible = false; ImageButton10.Visible = false; ImageButton11.Visible = false; ImageButton12.Visible = false;
                ImageButton13.Visible = false; ImageButton14.Visible = false; ImageButton15.Visible = false; ImageButton16.Visible = false;
                ImageButton17.Visible = false; ImageButton18.Visible = false; ImageButton19.Visible = false; ImageButton20.Visible = false;
                ImageButton21.Visible = false; ImageButton22.Visible = true; ImageButton23.Visible = false; ImageButton24.Visible = false;
                ImageButton25.Visible = false; ImageButton26.Visible = false; ImageButton27.Visible = false; ImageButton28.Visible = false;
                ImageButton29.Visible = false; ImageButton30.Visible = false; ImageButton31.Visible = false; ImageButton32.Visible = false;
                ImageButton33.Visible = false; ImageButton34.Visible = false; ImageButton35.Visible = false; ImageButton36.Visible = false;
                ImageButton37.Visible = false; ImageButton38.Visible = false; ImageButton39.Visible = false; ImageButton40.Visible = false;
                ImageButton41.Visible = false; ImageButton42.Visible = false; ImageButton43.Visible = false; ImageButton44.Visible = false;
                ImageButton45.Visible = false; ImageButton46.Visible = false; ImageButton47.Visible = false; ImageButton48.Visible = false;
                ImageButton49.Visible = false; ImageButton50.Visible = true; ImageButton51.Visible = true; ImageButton52.Visible = false;
                ImageButton53.Visible = false; ImageButton54.Visible = false; ImageButton55.Visible = false; ImageButton56.Visible = false;
                ImageButton57.Visible = false; ImageButton58.Visible = false; ImageButton59.Visible = false;
            }
        }

        // 所有圖片按鈕觸發事件
        protected void bt_click(object sender, ImageClickEventArgs e)
        {
            ImageButton btn = (ImageButton)sender;
            if (btn == ImageButton1)
            {
                Response.Redirect("character.aspx?id=01");
            }
            if (btn == ImageButton2)
            {
                Response.Redirect("character.aspx?id=02");
            }
            if (btn == ImageButton3)
            {
                Response.Redirect("character.aspx?id=03");
            }
            if (btn == ImageButton4)
            {
                Response.Redirect("character.aspx?id=04");
            }
            if (btn == ImageButton5)
            {
                Response.Redirect("character.aspx?id=05");
            }
            if (btn == ImageButton6)
            {
                Response.Redirect("character.aspx?id=06");
            }
            if (btn == ImageButton7)
            {
                Response.Redirect("character.aspx?id=07");
            }
            if (btn == ImageButton8)
            {
                Response.Redirect("character.aspx?id=08");
            }
            if (btn == ImageButton9)
            {
                Response.Redirect("character.aspx?id=09");
            }
            if (btn == ImageButton10)
            {
                Response.Redirect("character.aspx?id=10");
            }
            if (btn == ImageButton11)
            {
                Response.Redirect("character.aspx?id=11");
            }
            if (btn == ImageButton12)
            {
                Response.Redirect("character.aspx?id=12");
            }
            if (btn == ImageButton13)
            {
                Response.Redirect("character.aspx?id=13");
            }
            if (btn == ImageButton14)
            {
                Response.Redirect("character.aspx?id=14");
            }
            if (btn == ImageButton15)
            {
                Response.Redirect("character.aspx?id=15");
            }
            if (btn == ImageButton16)
            {
                Response.Redirect("character.aspx?id=16");
            }
            if (btn == ImageButton17)
            {
                Response.Redirect("character.aspx?id=17");
            }
            if (btn == ImageButton18)
            {
                Response.Redirect("character.aspx?id=18");
            }
            if (btn == ImageButton19)
            {
                Response.Redirect("character.aspx?id=19");
            }
            if (btn == ImageButton20)
            {
                Response.Redirect("character.aspx?id=20");
            }
            if (btn == ImageButton21)
            {
                Response.Redirect("character.aspx?id=21");
            }
            if (btn == ImageButton22)
            {
                Response.Redirect("character.aspx?id=22");
            }
            if (btn == ImageButton23)
            {
                Response.Redirect("character.aspx?id=23");
            }
            if (btn == ImageButton24)
            {
                Response.Redirect("character.aspx?id=24");
            }
            if (btn == ImageButton25)
            {
                Response.Redirect("character.aspx?id=25");
            }
            if (btn == ImageButton26)
            {
                Response.Redirect("character.aspx?id=26");
            }
            if (btn == ImageButton27)
            {
                Response.Redirect("character.aspx?id=27");
            }
            if (btn == ImageButton28)
            {
                Response.Redirect("character.aspx?id=28");
            }
            if (btn == ImageButton29)
            {
                Response.Redirect("character.aspx?id=29");
            }
            if (btn == ImageButton30)
            {
                Response.Redirect("character.aspx?id=30");
            }
            if (btn == ImageButton31)
            {
                Response.Redirect("character.aspx?id=31");
            }
            if (btn == ImageButton32)
            {
                Response.Redirect("character.aspx?id=32");
            }
            if (btn == ImageButton33)
            {
                Response.Redirect("character.aspx?id=33");
            }
            if (btn == ImageButton34)
            {
                Response.Redirect("character.aspx?id=34");
            }
            if (btn == ImageButton35)
            {
                Response.Redirect("character.aspx?id=35");
            }
            if (btn == ImageButton36)
            {
                Response.Redirect("character.aspx?id=36");
            }
            if (btn == ImageButton37)
            {
                Response.Redirect("character.aspx?id=37");
            }
            if (btn == ImageButton38)
            {
                Response.Redirect("character.aspx?id=38");
            }
            if (btn == ImageButton39)
            {
                Response.Redirect("character.aspx?id=39");
            }
            if (btn == ImageButton40)
            {
                Response.Redirect("character.aspx?id=40");
            }
            if (btn == ImageButton41)
            {
                Response.Redirect("character.aspx?id=41");
            }
            if (btn == ImageButton42)
            {
                Response.Redirect("character.aspx?id=42");
            }
            if (btn == ImageButton43)
            {
                Response.Redirect("character.aspx?id=43");
            }
            if (btn == ImageButton44)
            {
                Response.Redirect("character.aspx?id=44");
            }
            if (btn == ImageButton45)
            {
                Response.Redirect("character.aspx?id=45");
            }
            if (btn == ImageButton46)
            {
                Response.Redirect("character.aspx?id=46");
            }
            if (btn == ImageButton47)
            {
                Response.Redirect("character.aspx?id=47");
            }
            if (btn == ImageButton48)
            {
                Response.Redirect("character.aspx?id=48");
            }
            if (btn == ImageButton49)
            {
                Response.Redirect("character.aspx?id=49");
            }
            if (btn == ImageButton50)
            {
                Response.Redirect("character.aspx?id=50");
            }
            if (btn == ImageButton51)
            {
                Response.Redirect("character.aspx?id=51");
            }
            if (btn == ImageButton52)
            {
                Response.Redirect("character.aspx?id=52");
            }
            if (btn == ImageButton53)
            {
                Response.Redirect("character.aspx?id=53");
            }
            if (btn == ImageButton54)
            {
                Response.Redirect("character.aspx?id=54");
            }
            if (btn == ImageButton55)
            {
                Response.Redirect("character.aspx?id=55");
            }
            if (btn == ImageButton56)
            {
                Response.Redirect("character.aspx?id=56");
            }
            if (btn == ImageButton57)
            {
                Response.Redirect("character.aspx?id=57");
            }
            if (btn == ImageButton58)
            {
                Response.Redirect("character.aspx?id=58");
            }
            if (btn == ImageButton59)
            {
                Response.Redirect("character.aspx?id=59");
            }
        }

        protected void Btn_clear_Click(object sender, EventArgs e)
        {
            Att.Text = "攻擊方"; Att.BackColor = Color.Gray;
            Def.Text = "防守方"; Def.BackColor = Color.Gray;
            Att.Enabled = true; Def.Enabled = true;
            DropDownList1.SelectedValue = "1";
            DropDownList1.Items[1].Enabled = true; DropDownList1.Items[2].Enabled = true; DropDownList1.Items[3].Enabled = true;
            DropDownList1.Items[4].Enabled = true; DropDownList1.Items[5].Enabled = true; DropDownList1.Items[6].Enabled = true;
            DropDownList1.Items[7].Enabled = true; DropDownList1.Items[8].Enabled = true; DropDownList1.Items[9].Enabled = true;
            DropDownList1.Items[10].Enabled = true; DropDownList1.Items[11].Enabled = true; DropDownList1.Items[12].Enabled = true;
            DropDownList1.Items[13].Enabled = true; DropDownList1.Items[14].Enabled = true; DropDownList1.Items[15].Enabled = true;
            DropDownList1.Items[16].Enabled = true; DropDownList1.Items[17].Enabled = true; DropDownList1.Items[18].Enabled = true;
            DropDownList1.Items[19].Enabled = true;

            ImageButton1.Visible = true; ImageButton3.Visible = true; ImageButton4.Visible = true;
            ImageButton7.Visible = true; ImageButton9.Visible = true; ImageButton10.Visible = true;
            ImageButton12.Visible = true; ImageButton15.Visible = true; ImageButton16.Visible = true;
            ImageButton19.Visible = true; ImageButton22.Visible = true; ImageButton23.Visible = true;
            ImageButton25.Visible = true; ImageButton26.Visible = true; ImageButton28.Visible = true;
            ImageButton31.Visible = true; ImageButton32.Visible = true; ImageButton35.Visible = true;
            ImageButton36.Visible = true; ImageButton38.Visible = true; ImageButton41.Visible = true;
            ImageButton43.Visible = true; ImageButton44.Visible = true; ImageButton47.Visible = true;
            ImageButton48.Visible = true; ImageButton49.Visible = true; ImageButton54.Visible = true;
            ImageButton55.Visible = true; ImageButton56.Visible = true; ImageButton57.Visible = true;
            ImageButton2.Visible = true; ImageButton5.Visible = true; ImageButton6.Visible = true;
            ImageButton8.Visible = true; ImageButton11.Visible = true; ImageButton13.Visible = true;
            ImageButton14.Visible = true; ImageButton17.Visible = true; ImageButton18.Visible = true;
            ImageButton20.Visible = true; ImageButton21.Visible = true; ImageButton24.Visible = true;
            ImageButton27.Visible = true; ImageButton29.Visible = true; ImageButton30.Visible = true;
            ImageButton33.Visible = true; ImageButton34.Visible = true; ImageButton37.Visible = true;
            ImageButton39.Visible = true; ImageButton40.Visible = true; ImageButton42.Visible = true;
            ImageButton45.Visible = true; ImageButton46.Visible = true; ImageButton50.Visible = true;
            ImageButton51.Visible = true; ImageButton52.Visible = true; ImageButton53.Visible = true;
            ImageButton58.Visible = true; ImageButton59.Visible = true;
        }

    }
}