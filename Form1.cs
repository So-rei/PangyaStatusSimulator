using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PangyaStatusSimulator
{
    public partial class Form1 : Form
    {
        //デバッグ用ラベルメモ//////////////////////////////////////////////////////////////
        //         this.label1.Text = Convert.ToString(string.Format("{0}", ****));

        //各種初期宣言//////////////////////////////////////////////////////////////////////
        #region＜ListBox宣言＞
        //関数宣言と初期値
        List<MyItem> ListBoxItem000 = new List<MyItem>();
        List<MyItem> ListBoxItem001 = new List<MyItem>();
        List<MyItem> ListBoxItem002 = new List<MyItem>();
        List<MyItem> ListBoxItem003 = new List<MyItem>();
        List<MyItem> ListBoxItem004 = new List<MyItem>();
        List<MyItem> ListBoxItem005 = new List<MyItem>();
        List<MyItem> ListBoxItem006 = new List<MyItem>();
        List<MyItem> ListBoxItem007 = new List<MyItem>();
        List<MyItem> ListBoxItem008 = new List<MyItem>();
        List<MyItem> ListBoxItem009 = new List<MyItem>();
        List<MyItem> ListBoxItem010 = new List<MyItem>();
        List<MyItem> ListBoxItem011 = new List<MyItem>();
        List<MyItem> ListBoxItem012 = new List<MyItem>();
        List<MyItem> ListBoxItem013 = new List<MyItem>();
        List<MyItem> ListBoxItem014 = new List<MyItem>();
        List<MyItem> ListBoxItem015 = new List<MyItem>();
        List<MyItem> ListBoxItem016 = new List<MyItem>();
        List<MyItem> ListBoxItem017 = new List<MyItem>();
        List<MyItem> ListBoxItem018 = new List<MyItem>();
        List<MyItem> ListBoxItem019 = new List<MyItem>();
        List<MyItem> ListBoxItem020 = new List<MyItem>();
        List<MyItem> ListBoxItem021 = new List<MyItem>();
        List<MyItem> ListBoxItem022 = new List<MyItem>();
        List<MyItem> ListBoxItem023 = new List<MyItem>();
        List<MyItem> ListBoxItem024 = new List<MyItem>();
        List<MyItem> ListBoxItem025 = new List<MyItem>();
        List<MyItem> ListBoxItem026 = new List<MyItem>();
        List<MyItem> ListBoxItem027 = new List<MyItem>();
        List<MyItem> ListBoxItem028 = new List<MyItem>();
        List<MyItem> ListBoxItem029 = new List<MyItem>();
        List<MyItem> ListBoxItem030 = new List<MyItem>();
        List<MyItem> ListBoxItemZone = new List<MyItem>();//パンヤゾーン増加
        List<MyItem_clubrank> ListBoxclubrank = new List<MyItem_clubrank>();
        List<MyItem> ListBoxAddslot000 = new List<MyItem>();//ケン
        List<MyItem> ListBoxAddslot001 = new List<MyItem>();//エリカ
        List<MyItem> ListBoxAddslot002 = new List<MyItem>();//ダイスケ
        List<MyItem> ListBoxAddslot003 = new List<MyItem>();//セシリア
        List<MyItem> ListBoxAddslot004 = new List<MyItem>();//マックス
        List<MyItem> ListBoxAddslot005 = new List<MyItem>();//クー
        List<MyItem> ListBoxAddslot006 = new List<MyItem>();//アリン
        List<MyItem> ListBoxAddslot007 = new List<MyItem>();//カズ
        List<MyItem> ListBoxAddslot008 = new List<MyItem>();//ルーシア
        List<MyItem> ListBoxAddslot009 = new List<MyItem>();//ネル
        List<MyItem> ListBoxAddslot010 = new List<MyItem>();//スピカ
        //List<Settings> Settings = new List<Settings>();
        #endregion
        #region＜各種関数の初期値＞
        static bool bInit = false;
        //特殊な装備の説明
        string[] specialequip = new string[23];
        string result_special_9 = "";
        string result_special_10 = "";
        //計算用
        int[] specialup = new int[9];
        int[] powerup = new int[5];
        int[] specialup_caddy = new int[5];
        int rank_penalty = 0, rank_penalty_see = 0;
        int rank_power = 0, rank = 0;
        //ダウングレード系
        int downgread_1 = 0, downgread_2 = 0, downgread_3 = 0, downgread_4 = 0, downgread_5 = 0;
        //結果
        int result_main_1 = 0, result_main_2 = 0, result_main_3 = 0, result_main_4 = 0, result_main_5 = 0;
        int result_club_1 = 0, result_club_2 = 0, result_club_3 = 0, result_club_4 = 0, result_club_5 = 0;
        int status_1 = 0, status_2 = 0, status_3 = 0, status_4 = 0, status_5 = 0;
        int result_pow_1 = 0, result_con_2 = 0, result_sei_3 = 0, result_spi_4 = 0, result_cur_5 = 0;
        int result_1wmax_6 = 0, result_1wp_7 = 0, result_1wDp_8 = 0;
        //クラブセット系
        int clubmax_01 = 0, clubmax_02 = 0, clubmax_03 = 0, clubmax_04 = 0, clubmax_05 = 0;
        int club_kaizo_kaisu = 0, clubset_total = 0, type_01 = 0, type_02 = 0, type_04 = 0, club_kaizo_pm = 0;
        int club_kaizo = 0;
        //int club_status_1 = 0, club_status_2 = 0, club_status_3 = 0, club_status_4 = 0, club_status_5 = 0;
        int club_status_1 = 6, club_status_2 = 7, club_status_3 = 5, club_status_4 = 3, club_status_5 = 3;
        int club_status_1_default = 0, club_status_2_default = 0, club_status_3_default = 0, club_status_4_default = 0, club_status_5_default = 0;
        int club_button_1 = 0, club_button_2 = 0, club_button_3 = 0, club_button_4 = 0, club_button_5 = 0;
        //カードかぶりチェック系
        int check_card_npc1 = 0, check_card_npc2 = 0;
        int check_card_caddy1 = 0, check_card_caddy2 = 0, check_card_caddy3 = 0, check_card_caddy4 = 0;
        int roro_kekka, pipi_kekka;
        //numericタブの設定
        int numeric1 = 0;
        //ロードキャンセラーとセーブID
        int loadcancel = 0, saveID = 0;
        //パンヤゾーン量
        int[] pangyazone = new int[12];
        //キャラクター拡張スロットの必要TP
        //ひみつ
        int secretcheck = 0;
        #endregion
        //中央に表示するメッセージ
        string centermessage = "Ver1.2変更点：\r\nパンヤゾーンシュミレータを左下に追加。\r\n双輝石セット(リング)、キャディマスコット4種、\r\nアクアクリスタルエアーナイト(クラブ)、\r\n水着マガベニブルーム(その他)、ルー水着（靴）追加。\r\n\r\n※一部カードでセーブがズレているかもしれません。\r\n\r\n1.02以前のセーブデータは使えなくなりました。\r\nお手数ですがsettings.xmlを手動で削除して下さい。\r\n\r\n" +
                               "ここに貼るキャラクター画像募集中。\r\nhave_a_hope_so@yahoo.co.jpまで。\r\n" +
                               "今のところスピカ、ネルの画像を頂きました。\r\nクーのは私のサンプルです(--;";

        //メイン関数////////////////////////////////////////////////////////////////////////
        public Form1()
        {
            InitializeComponent();
            //MyItem宣言                                        
            #region ＜MyItem キャラ前半＞
            //000　キャラ
            MyItem[] mi_000 =
                {
                new MyItem("000", "ケン", 9, 11, 6, 2, 2),
                new MyItem("001", "エリカ", 9, 11, 6, 2, 2),
                new MyItem("002", "ダイスケ", 11, 8, 5, 5, 2),
                new MyItem("003", "セシリア", 10, 9, 6, 2, 6),
                new MyItem("004", "マックス", 12, 10, 6, 1, 1),
                new MyItem("005", "クー", 10, 11, 4, 3, 1),
                new MyItem("006", "アリン", 11, 10, 9, 2, 4),
                new MyItem("007", "カズ", 12, 11, 8, 3, 3),
                new MyItem("008", "ルーシア", 10, 11, 9, 2, 3),
                new MyItem("009", "ネル", 12, 11, 7, 3, 2),
                new MyItem("010", "スピカ", 12, 11, 9, 2, 3)
                };
            ListBoxItem000.AddRange(mi_000);

            comboBox_chara.DisplayMember = "Name";
            comboBox_chara.ValueMember = "ID";
            comboBox_chara.DataSource = ListBoxItem000;

            //001　頭１
            MyItem[] mi_001 =
                {
                new MyItem("000", "(なし)", 0, 0, 0, 0, 0),
                new MyItem("001", "スピン+1", 0, 0, 0, 1, 0),
                new MyItem("002", "スピン+2", 0, 0, 0, 2, 0),
                new MyItem("003", "スピン+3", 0, 0, 0, 3, 0),
                new MyItem("004", "カーブ+1", 0, 0, 0, 0, 1),
                new MyItem("005", "カーブ+2", 0, 0, 0, 0, 2),
                new MyItem("006", "カーブ+3", 0, 0, 0, 0, 3),
                new MyItem("007", "スピン+1カーブ+2", 0, 0, 0, 1, 2),
                new MyItem("008", "スピン+2カーブ+1", 0, 0, 0, 2, 1),
                new MyItem("009", "スピン+1正確度+1", 0, 0, 1, 1, 0),
                new MyItem("010", "スピン+2正確度+1", 0, 0, 1, 2, 0),
                new MyItem("011", "カーブ+1正確度+1", 0, 0, 1, 0, 1),
                new MyItem("012", "カーブ+2正確度+1", 0, 0, 1, 0, 2),
                new MyItem("013", "スピン+1カーブ+1正確度+1", 0, 0, 1, 1, 1),
                new MyItem("014", "スピン+2カーブ+2(クーのみ)", 0, 0, 0, 2, 2),
                new MyItem("015", "パワー+2(エリカのみ)", 2, 0, 0, 0, 0)
                };
            ListBoxItem001.AddRange(mi_001);

            comboBox_equip_001.DisplayMember = "Name";
            comboBox_equip_001.ValueMember = "ID";
            comboBox_equip_001.DataSource = ListBoxItem001;

            //002　頭２
            MyItem[] mi_002 =
                {
                new MyItem("000", "(なし)", 0, 0, 0, 0, 0),
                new MyItem("001", "スピン+2(クー/マックス)", 0, 0, 0, 2, 0),
                new MyItem("002", "カーブ+2(クー/マックス)", 0, 0, 0, 0, 2),
                new MyItem("003", "スピン+1カーブ+1(クー/マックス)", 0, 0, 0, 1, 1),
                new MyItem("004", "コント+1(ダイスケ/セシ)", 0, 1, 0, 0, 0),
                new MyItem("004", "スピン+1(ケン)", 0, 1, 0, 0, 0),
                new MyItem("004", "カーブ+1(ケン)", 0, 1, 0, 0, 0)
                };
            ListBoxItem002.AddRange(mi_002);

            comboBox_equip_002.DisplayMember = "Name";
            comboBox_equip_002.ValueMember = "ID";
            comboBox_equip_002.DataSource = ListBoxItem002;

            //003　耳
            MyItem[] mi_003 =
                {
                new MyItem("000", "(なし)", 0, 0, 0, 0, 0),
                new MyItem("001", "PEP(ALL+1)<ゲージ増加>", 1, 1, 1, 1, 1),
                new MyItem("002", "妖精の耳<中～強風パンヤゾーン増加>", 0, 0, 0, 0, 0),
                new MyItem("003", "シルフィード<中～強風パンヤゾーン増加>", 0, 0, 0, 0, 0),
                new MyItem("004", "サラ耳(ALL+1)<ゲージ増加/キャディslot>", 1, 1, 1, 1, 1),
                new MyItem("005", "シルフの耳<中～強風パンヤゾーン増加/キャディslot>", 0, 0, 0, 0, 0),
                new MyItem("006", "イヤーカフ<中～強風パンヤゾーン増加/風向時折変更>", 0, 0, 0, 0, 0),
                new MyItem("007", "セイレーンの耳飾り<中風でパンヤゾーン増加/キャディslot>", 0, 0, 0, 0, 0),
                new MyItem("008", "PMR-コントロール<キャディslot>", 0, 2, 0, 1, 1),
                new MyItem("009", "PMR-パワー<キャディslot>", 2, 0, 0, 1, 1),
                new MyItem("010", "銀エンシェントイヤーカフ(ALL+1)<雨時影響なし、パンヤゾーン+1,キャディslot？>", 1, 1, 1, 1, 1),
                new MyItem("011", "金エンシェントイヤーカフ(パワー+1,コント+2,スピン+1)<雨時影響なし、パンヤゾーン+1,キャディslot？>", 1, 2, 0, 1, 0)
                };
            ListBoxItem003.AddRange(mi_003);

            comboBox_equip_003.DisplayMember = "Name";
            comboBox_equip_003.ValueMember = "ID";
            comboBox_equip_003.DataSource = ListBoxItem003;

            //004　目
            MyItem[] mi_004 =
                {
                new MyItem("000", "(なし)", 0, 0, 0, 0, 0),
                new MyItem("001", "スピン+1<dropup>", 0, 0, 0, 1, 0),
                new MyItem("002", "スピン+2(マックス)", 0, 0, 0, 2, 0),
                new MyItem("003", "カーブ+1<dropup>", 0, 0, 0, 0, 1),
                new MyItem("004", "カーブ+4", 0, 0, 0, 0, 4),
                new MyItem("005", "カーブ+9", 0, 0, 0, 0, 9),
                new MyItem("006", "カーブ+10", 0, 0, 0, 0, 10),
                new MyItem("007", "正確度+1<dropup>", 0, 0, 1, 0, 0),
                new MyItem("008", "正確度+2", 0, 0, 2, 0, 0),
                new MyItem("009", "パワー+2(2006水着)", 2, 0, 0, 0, 0)
                };
            ListBoxItem004.AddRange(mi_004);

            comboBox_equip_004.DisplayMember = "Name";
            comboBox_equip_004.ValueMember = "ID";
            comboBox_equip_004.DataSource = ListBoxItem004;

            //005　頬
            MyItem[] mi_005 =
                {
                new MyItem("000", "(なし)", 0, 0, 0, 0, 0),
                new MyItem("001", "正確度+1", 0, 0, 1, 0, 0),
                new MyItem("002", "正確度+2", 0, 0, 2, 0, 0),
                new MyItem("003", "正確度+3(バッドペイント)", 0, 0, 3, 0, 0)
                };
            ListBoxItem005.AddRange(mi_005);

            comboBox_equip_005.DisplayMember = "Name";
            comboBox_equip_005.ValueMember = "ID";
            comboBox_equip_005.DataSource = ListBoxItem005;

            //006　背中
            MyItem[] mi_006 =
                {
                new MyItem("000", "(なし)", 0, 0, 0, 0, 0),
                new MyItem("001", "羽<パンヤゾーン+1pix>", 0, 0, 0, 0, 0),
                new MyItem("002", "天使の羽(正確度+1)<dropup>", 0, 0, 1, 0, 0),
                new MyItem("003", "悪魔の羽(正確度+1)<雨2倍>", 0, 0, 1, 0, 0),
                new MyItem("004", "ゾディ翼<パンヤゾーン+1pix/釘効果>", 0, 0, 0, 0, 0),
                new MyItem("005", "蝶の羽<パンヤゾーン+1pix/清風効果>", 0, 0, 0, 0, 0),
                new MyItem("006", "大天使の純白の翼(コント+1)<パンヤゾーン+1pix/drop>", 0, 1, 0, 0, 0),
                new MyItem("007", "堕天使の漆黒の翼(コント+1)<パンヤゾーン+1pix/雨>", 0, 1, 0, 0, 0),
                new MyItem("008", "鳳凰の翼(コント+1)<パンヤゾーン+1pix/毎Hゲージ+1>", 0, 1, 0, 0, 0),
                new MyItem("009", "フェニックスの翼<パンヤゾーン+1pix/毎Hゲージ+4>", 0, 0, 0, 0, 0),
                new MyItem("010", "妖怪セット(ALL+1)<パンヤゾーン+1pix/エフェクト装備>",1,1,1,1,1)
                };
            ListBoxItem006.AddRange(mi_006);

            comboBox_equip_006.DisplayMember = "Name";
            comboBox_equip_006.ValueMember = "ID";
            comboBox_equip_006.DataSource = ListBoxItem006;
            //007　手袋
            MyItem[] mi_007 =
                {
                new MyItem("000", "(なし)", 0, 0, 0, 0, 0),
                new MyItem("001", "スピン+1", 0, 0, 0, 1, 0),
                new MyItem("002", "スピン+2", 0, 0, 0, 2, 0),
                new MyItem("003", "スピン+2<清風発動>", 0, 0, 0, 2, 0),
                new MyItem("004", "スピン+2<４ゲージ>", 0, 0, 0, 2, 0),
                new MyItem("005", "スピン+2<アニパン>", 0, 0, 0, 2, 0),
                new MyItem("006", "カーブ+1", 0, 0, 0, 0, 1),
                new MyItem("007", "カーブ+2", 0, 0, 0, 0, 2),
                new MyItem("008", "スピン+1カーブ+1", 0, 0, 0, 1, 1),
                new MyItem("009", "スピン+3カーブ+3<ナックル>", 0, 0, 0, 3, 3),
                new MyItem("010", "スピン+6<ブレスレット>", 0, 0, 0, 6, 0),
                new MyItem("011", "<釘発動>(スマートPウォッチ)", 0, 0, 0, 0, 0),
                new MyItem("012", "<釘発動>(グランドエンブレムグローブ)", 0, 0, 0, 0, 0)
                };
            ListBoxItem007.AddRange(mi_007);

            comboBox_equip_007.DisplayMember = "Name";
            comboBox_equip_007.ValueMember = "ID";
            comboBox_equip_007.DataSource = ListBoxItem007;

            //008　アクセサリー
            MyItem[] mi_008 =
                {
                new MyItem("000", "(なし)", 0, 0, 0, 0, 0),
                new MyItem("001", "スピン+1正確度+1<drop2倍>", 0, 0, 1, 1, 0),
                new MyItem("002", "カーブ+1正確度+1<drop2倍>", 0, 0, 1, 0, 1),
                new MyItem("003", "正確度+1<drop2倍>", 0, 0, 1, 0, 0)
                };
            ListBoxItem008.AddRange(mi_008);

            comboBox_equip_008.DisplayMember = "Name";
            comboBox_equip_008.ValueMember = "ID";
            comboBox_equip_008.DataSource = ListBoxItem008;
            #endregion
            #region＜MyItem キャラ後半＞

            //009　服<上>
            MyItem[] mi_009 =
                {
                    new MyItem("000", "(なし)", 0, 0, 0, 0, 0),
                    new MyItem("001", "パワー+1", 1, 0, 0, 0, 0),
                    new MyItem("002", "パワー+2", 2, 0, 0, 0, 0),
                    new MyItem("003", "パワー+3", 3, 0, 0, 0, 0),
                    new MyItem("004", "パワー+4<カズWii水着>", 4, 0, 0, 0, 0),
                    new MyItem("005", "正確度+2<ラブTシャツ>", 0, 0, 2, 0, 0)
                };
            ListBoxItem009.AddRange(mi_009);

            comboBox_equip_009.DisplayMember = "Name";
            comboBox_equip_009.ValueMember = "ID";
            comboBox_equip_009.DataSource = ListBoxItem009;

            //010　服<下>
            MyItem[] mi_010 =
                {
                new MyItem("000", "(なし)", 0, 0, 0, 0, 0),
                new MyItem("001", "コントロール+1", 0, 1, 0, 0, 0),
                new MyItem("002", "コントロール+2", 0, 2, 0, 0, 0),
                new MyItem("003", "コントロール+3", 0, 3, 0, 0, 0),
                new MyItem("004", "コントロール+4", 0, 4, 0, 0, 0),
                new MyItem("005", "コントロール+5<ダイスケ>", 0, 5, 0, 0, 0),
                new MyItem("006", "正確度+1<クー>", 0, 0, 1, 0, 0),
                new MyItem("007", "コントロール+3正確度+1<クー>", 0, 3, 1, 0, 0)
                  };
            ListBoxItem010.AddRange(mi_010);
            comboBox_equip_010.DisplayMember = "Name";
            comboBox_equip_010.ValueMember = "ID";
            comboBox_equip_010.DataSource = ListBoxItem010;

            //011　尾
            MyItem mi_011;
            mi_011 = new MyItem("000", "(なし)", 0, 0, 0, 0, 0);
            ListBoxItem011.Add(mi_011);
            mi_011 = new MyItem("001", "正確度+1", 0, 0, 1, 0, 0);
            ListBoxItem011.Add(mi_011);
            mi_011 = new MyItem("002", "正確度+2(アニマル系)", 0, 0, 2, 0, 0);
            ListBoxItem011.Add(mi_011);

            comboBox_equip_011.DisplayMember = "Name";
            comboBox_equip_011.ValueMember = "ID";
            comboBox_equip_011.DataSource = ListBoxItem011;

            //012　靴
            MyItem[] mi_aaa =
                {
                new MyItem("000", "(なし)", 0, 0, 0, 0, 0),
                };
                ListBoxItem012.AddRange(mi_aaa);
            MyItem[] mi_012 =
                {
                new MyItem("000", "(なし)", 0, 0, 0, 0, 0),
                new MyItem("001", "パワー+1", 1, 0, 0, 0, 0),
                new MyItem("002", "パワー+2", 2, 0, 0, 0, 0),
                new MyItem("003", "パワー+1正確度+1", 1, 0, 1, 0, 0),
                new MyItem("004", "パワー+1正確度+2", 1, 0, 2, 0, 0),
                new MyItem("005", "パワー+1スピン+1", 1, 0, 0, 1, 0),
                new MyItem("006", "パワー+1カーブ+1", 1, 0, 0, 0, 1),
                new MyItem("007", "パワー+1コントロール+1", 1, 1, 0, 0, 0),
                new MyItem("008", "コントロール+1", 0, 1, 0, 0, 0),
                new MyItem("009", "コントロール+1正確度+1", 0, 1, 1, 0, 0),
                new MyItem("010", "コントロール+1スピン+1", 0, 1, 0, 1, 0),
                new MyItem("011", "コントロール+1カーブ+1", 0, 1, 0, 0, 1),
                new MyItem("012", "正確度+1", 0, 0, 1, 0, 0),
                new MyItem("013", "正確度+2", 0, 0, 2, 0, 0),
                new MyItem("014", "正確度+3", 0, 0, 3, 0, 0),
                new MyItem("015", "正確度+1スピン+1", 0, 0, 1, 1, 0),
                new MyItem("016", "正確度+1カーブ+1", 0, 0, 1, 0, 1),
                new MyItem("017", "スピン+1", 0, 0, 0, 1, 0),
                new MyItem("018", "カーブ+1", 0, 0, 0, 1, 0),
                new MyItem("019", "スピン+1カーブ+1(ネル/カズ:トライバル)", 0, 0, 0, 1, 1),
                new MyItem("020", "スピン+2(ルーシア:トライバル)", 0, 0, 0, 2, 0),
                new MyItem("021", "パワー+1カーブ+1スピン+1(ルー:2015水着)", 1, 0, 0, 1, 1)                         
                };
            ListBoxItem012.AddRange(mi_012);

            comboBox_equip_012.DisplayMember = "Name";
            comboBox_equip_012.ValueMember = "ID";
            comboBox_equip_012.DataSource = ListBoxItem012;

            //013　その他
            MyItem[] mi_013 =
                {
                new MyItem("000", "(なし)", 0, 0, 0, 0, 0),
                new MyItem("001", "ねこじゃらし(ダイスケ)", 0, 0, 0, 1, 2),
                new MyItem("002", "カーブ+2髪型(エリカR/ケンR)", 0, 0, 0, 0, 2),
                new MyItem("003", "スピン+2髪型(エリカR/ケンR)", 0, 0, 0, 2, 0),
                new MyItem("004", "マガベニブルーム", 0, 0, 0, 0, 0),
                new MyItem("005", "ねこ＋マガベニブルーム(パンヤゾーン+1)", 0, 0, 0, 0, 0),
                new MyItem("006", "カーブ+2＋マガベニブルーム(パンヤゾーン+1)", 0, 0, 0, 0, 2),
                new MyItem("007", "スピン+2＋マガベニブルーム(パンヤゾーン+1)", 0, 0, 0, 2, 0),                
                new MyItem("099", "※テスト用：ALLステ+10", 10, 10, 10, 10, 10),
                };
            ListBoxItem013.AddRange(mi_013);

            comboBox_equip_013.DisplayMember = "Name";
            comboBox_equip_013.ValueMember = "ID";
            comboBox_equip_013.DataSource = ListBoxItem013;

            //014　セット衣装
            MyItem[] mi_014 =
                {
                new MyItem("000", "(なし)", 0, 0, 0, 0, 0),
                new MyItem("001", "上下:パワー+1コント+1", 1, 1, 0, 0, 0),
                new MyItem("002", "上下:パワー+2コント+2", 2, 2, 0, 0, 0),
                new MyItem("003", "上下:パワー+2コント+3<SDワンピース>", 2, 3, 0, 0, 0),
                new MyItem("004", "上下:パワー+3コント+3", 3, 3, 0, 0, 0),
                new MyItem("005", "上下:パワー+3コント+4", 3, 4, 0, 0, 0),
                new MyItem("006", "上下:パワー+3コント+5<ダイスケ>", 3, 5, 0, 0, 0),
                new MyItem("007", "頭上下:パワー+3コント+4スピン+2", 3, 4, 0, 0, 0),
                new MyItem("008", "頭上下:パワー+3コント+4スピン+1カーブ+1", 3, 4, 0, 1, 1),
                new MyItem("009", "上下靴:パワー+3コント+4スピン+1", 3, 4, 0, 0, 1),
                new MyItem("010", "上下靴:パワー+3コント+6<ダイスケ>", 3, 6, 0, 0, 0),
                new MyItem("011", "上下手:パワー+3コント+4スピン+1", 3, 4, 0, 1, 0),
                new MyItem("012", "頭上:パワー+3スピン+2", 3, 0, 0, 2, 0),
                new MyItem("013", "頭上下手靴:パワー+3コント+5スピン+4カーブ+1<アリン>", 3, 5, 0, 4, 1)
                };
            ListBoxItem014.AddRange(mi_014);

            comboBox_equip_014.DisplayMember = "Name";
            comboBox_equip_014.ValueMember = "ID";
            comboBox_equip_014.DataSource = ListBoxItem014;
            #endregion
            #region＜MyItem クラブセット(暫定)＞
            //015　クラブセット
            MyItem[] mi_015 =
                {
                new MyItem("000", "エアーナイト.N", 6, 7, 5, 3, 3),
                new MyItem("001", "マジックエアーナイト.N", 0, 11, 7 ,2, 2),
                new MyItem("002", "練習用ポンタクラブセット.b", 8, 8, 8, 3, 3),
                new MyItem("003", "スパイクハンマーセット.b", 15, 8, 11, 3, 4),
                new MyItem("004", "SYアフターバーナー(赤).s", 13, 9, 12, 5, 2),
                new MyItem("005", "チャンバラクラブセット.c", 14, 10, 7, 2, 2),
                new MyItem("006", "黒魔剣セット.s", 14, 9, 11, 5, 3),
                new MyItem("007", "エアーナイトⅡ.b", 8, 12, 7, 3, 4),
                new MyItem("008", "野球バット.p", 10, 12, 7, 2, 5),
                new MyItem("009", "家庭用品セット.p", 11, 11, 8, 3, 3),
                new MyItem("010", "ツインフェザー.p", 14, 12, 11, 4, 4),
                new MyItem("011", "ミスリルソードセット.p", 15, 12, 10, 5, 3),
                new MyItem("012", "SEアフターバーナー(青).b", 12, 12, 8, 4, 3),
                new MyItem("013", "ヴォックスクラブセット.b", 13, 12, 10, 4, 3),
                new MyItem("014", "ゴールデンハンマーセット.b", 13, 12, 9, 3, 2),
                new MyItem("015", "ピコピコハンマーセット.b", 12, 11, 10, 4, 3),
                new MyItem("016", "ばんがさセット.b", 10, 11, 12, 3, 4),
                new MyItem("017", "まじかる☆ステッキ.b", 11, 12, 10, 3, 6),
                new MyItem("018", "エアーナイトⅢ(Ver3.16).p", 13, 12, 12, 6, 2),
                new MyItem("019", "クリスマスクラブセット.b", 11, 11, 14, 3, 3),
                new MyItem("020", "クリスマスクラブセットツヴァイ.s", 11, 12, 15, 4, 3),
                new MyItem("021", "ハロウィンクラブセット.b", 10, 12, 10, 4, 3),
                new MyItem("022", "キャンディクラブセット.b", 10, 12, 10, 3, 4),
                new MyItem("023", "チョコステッキクラブセット.b", 10, 12, 10, 3, 4),
                new MyItem("024", "ゴールデンツインフェザー.s", 14, 13, 11, 6, 6),
                new MyItem("025", "マジカルボイスクラブセット(Ver4.08).b", 10, 11, 10, 4, 2),
                new MyItem("026", "ミラクルボイスクラブセット(Ver4.08).b", 13, 12, 12, 3, 5),
                new MyItem("027", "キャット★ハンドクラブセット.b", 13, 12, 14, 3, 4),
                new MyItem("028", "ネギクラブセット.s", 12, 12, 13, 6, 2),
                new MyItem("029", "イクシードボイスクラブセット.p", 15, 12, 10, 4, 4),
                new MyItem("030", "ケミカルボイスクラブセット.p", 11, 11, 8, 3, 3),
                new MyItem("031", "ホーリーエアーナイト.b", 10, 12, 8, 2, 2),
                new MyItem("032", "ダークウェポンセット(Ver5.17).b", 15, 12, 4, 3, 2),
                new MyItem("033", "天然マグロクラブセット.b", 14, 12, 8, 3, 6),
                new MyItem("034", "養殖マグロクラブセット.b", 12, 11, 6, 3, 4),
                new MyItem("035", "三ツ矢サイダークラブセット.b", 11, 12, 11, 5, 2),
                new MyItem("036", "ソーダクラブセット.b", 11, 12, 11, 5, 2),
                new MyItem("037", "ソウルリーパークラブセット.p", 16, 12, 8, 5, 4),
                new MyItem("038", "ソウルマスタークラブセット.b", 16, 12, 8, 6, 4),
                new MyItem("039", "リリカルボイスクラブセット.p", 14, 12, 11, 5, 3),
                new MyItem("040", "トゥウィンクルボイスクラブセット.p", 10, 11, 8, 4, 3),
                new MyItem("041", "はだかのクラブ様(Ver5.67).p", 15, 12, 10, 3, 3),
                new MyItem("042", "スターナイトクラブセット.b", 15, 12, 12, 6, 0),
                new MyItem("043", "ストリングスクラブセット(Ver5.99).p", 15, 12, 8, 4, 5),
                new MyItem("044", "PWCクラブセット(レプリカ)(Ver5.9927).p", 14, 12, 10, 5, 3),
                new MyItem("045", "PWCクラブセット(チャンピオン).s", 15, 13, 11, 6, 4),
                new MyItem("046", "ルビーエアーナイト(Ver6.03).s", 16, 12, 13, 5, 4),
                new MyItem("047", "ハローキティクラブセット(Ver6.04).p", 14, 12, 11, 5, 4),
                new MyItem("048", "ネルにゃん☆ボイスクラブセット(Ver6.18).p", 14, 12, 12, 4, 5),
                new MyItem("049", "ネルにゃん☆クラブセット(Ver6.19).b", 13, 12, 12, 4, 4),
                new MyItem("050", "アリスクラブセット(Ver6.24).p", 16, 12, 12, 5, 5),
                new MyItem("051", "ネギま！クラブセット(木乃香/刹那)(Ver6.26).p", 15, 12, 11, 4, 4),
                new MyItem("052", "おはなクラブセット(Ver6.28).p", 15, 12, 9, 5, 4),
                new MyItem("053", "太鼓クラブセット(Ver6.28).p", 15, 12, 9, 5, 4),
                new MyItem("054", "コラールボイスクラブセット(Ver6.32).p", 15, 12, 14, 5, 4),
                new MyItem("055", "冷凍ネギクラブセット(Ver6.32).s", 14, 12, 13, 6, 2),
                new MyItem("056", "デモンズウェポンクラブセット(Ver6.43).p", 15, 12, 10, 5, 3),
                new MyItem("057", "文房具クラブセット(Ver6.46).p", 13, 12, 10, 4, 3),
                new MyItem("058", "シルビアセンチネルクラブセット(Ver6.49).p", 16, 12, 11, 6, 4),
                new MyItem("059", "文房具クラブセット(A/B(Ver6.51).p", 14, 12, 10, 4, 6),
                new MyItem("060", "イカ娘ボイスクラブセット(Ver6.55).p", 14, 12, 10, 5, 5),
                new MyItem("061", "エレメンタルクラブセット(Ver7.17).p", 17, 12, 11, 5, 4),
                new MyItem("062", "8thスペシャルクラブセット(Ver7.23).b", 14, 12, 11, 4, 3),
                new MyItem("063", "スピカボイスクラブセット(Ver7.28).p", 15, 12, 10, 7, 2),
                new MyItem("064", "まどか☆マギカクラブセット(Ver7.31).p", 15, 12, 8, 5, 5),
                new MyItem("065", "スピカボイスクラブセット(きらめきVer).p", 15, 12, 10, 4, 5),
                new MyItem("066", "シルバーカノッククラブセット(Ver7.37).p", 15, 12, 9, 5, 4),
                new MyItem("067", "ゴールデンエアーナイト(Ver7.46).b", 13, 12, 10, 4, 3),
                new MyItem("068", "ネイキッドクラブセット(Ver7.56).p", 15, 12, 9, 6, 4),
                new MyItem("069", "Thailandボイスクラブセット(Ver7.66).p", 14, 12, 11, 4, 3),
                new MyItem("070", "超電磁砲Sボイスクラブセット(Ver7.70).p", 15, 12, 10, 5, 4),
                new MyItem("071", "御坂妹ボイスクラブセット(Ver7.70).p", 11, 12, 7, 2, 2),
                new MyItem("072", "ブラッディーマリークラブセット(Ver7.72).c", 16, 12, 8, 6, 5),
                new MyItem("073", "9thアニバーサリークラブセット(Ver7.74).b", 14, 12, 12, 4, 3),
                new MyItem("074", "大感謝祭ボイスクラブセット(light).b", 12, 11, 8, 4, 3),
                new MyItem("075", "大感謝祭ボイスクラブセット[2013-12].b", 16, 12, 8, 6, 3),
                new MyItem("076", "雪ミククラブセット(Ver7.89).c", 15, 13, 7, 7, 3),   
                new MyItem("077", "エターナルボイスクラブセット(Ver8.01).c", 16, 12, 8, 6, 4),
                new MyItem("078", "パラドックスボイスクラブセット(Ver8.02).c", 16, 12, 8, 6, 4),
                new MyItem("079", "スペシャルボイスクラブセット(Ver8.07).c", 16, 12, 7, 6, 5),
                new MyItem("080", "お料理クラブセット(Ver8.14).c", 16, 12, 8, 6, 5), 
                new MyItem("083", "戦国ボイスクラブセット(Ver8.17).c", 16, 12, 8, 6, 4),
                new MyItem("084", "宝具ボイスクラブセット(2015/01/15).p", 16, 11, 7, 4, 3),
                new MyItem("081", "アーサークラブセット(2015/02/26)<熟練度1.3倍>.p", 17, 11, 8, 5, 5),
                new MyItem("082", "マーリンクラブセット(2015/02/26)<熟練度1.3倍>.c", 15, 13, 6, 6, 6),
                new MyItem("085", "アクアクリスタルエアーナイトクラブセット(2015/04/23).p", 18, 12, 8, 6, 3),
                new MyItem("086", "プリュームボイスクラブセット(ノーマル)(2015/11/26).b", 16, 13, 8, 8, 4),
                new MyItem("087", "プリュームボイスクラブセット(シャッフル)(2015/11/26).c", 16, 13, 8, 4, 8),
                new MyItem("088", "プリュームボイスクラブセット(ジョブ)(2015/11/26).p", 18, 12, 8, 8, 3),
                new MyItem("098", "ウイングトロスエボートナイトクラブセット(変化P).S", 12, 10, 8, 3, 2),
                new MyItem("099", "デュアルマナピカルクラブセット(変化S).S", 11, 10, 8, 4, 2),
                new MyItem("100", "ギガヤーズトーテムポールクラブセット(変化C).S", 11, 10, 8, 3, 3),

                };
            ListBoxItem015.AddRange(mi_015);

            comboBox_clubset.DisplayMember = "Name";
            comboBox_clubset.ValueMember = "ID";
            comboBox_clubset.DataSource = ListBoxItem015;
            #endregion
            #region＜MyItem キャラ共通装備＞
            //016　キャディ
            MyItem[] mi_016 =
                {
                new MyItem("000", "(なし)", 0, 0, 0, 0, 0),
                new MyItem("001", "ポンタ：コントロール+1", 0, 1, 0, 0, 0),
                new MyItem("002", "こげポン：コントロール+1スピン+5", 0, 1, 0, 5, 0),
                new MyItem("003", "すけポン：コントロール+1スピン+2カーブ+2", 0, 1, 0, 2, 2),
                new MyItem("004", "くろポン：コントロール+1スピン+10", 0, 1, 0, 10, 0),
                new MyItem("005", "BIGポンタ:コントロール+2<BIGポン特殊各種>", 0, 2, 0, 0, 0),
                new MyItem("006", "ビジュアルポンタ：ALLステ+1", 1, 1, 1, 1, 1),
                new MyItem("007", "ガネーシャポンタ：パワー+5コントロール+1", 5, 1, 0, 0, 0),
                new MyItem("008", "ゴールデンポンタ：パワー+1コントロール+3スピン+10", 1, 3, 0, 10, 0),
                new MyItem("009", "ピピン(old)：パワー+2", 2, 0, 0, 0, 0),
                new MyItem("010", "ピピン：パワー+2コントロール+2", 2, 2, 0, 0, 0),
                new MyItem("011", "ドルフ(old)：スピン+2", 0, 0, 0, 2, 0),
                new MyItem("012", "ドルフ：パワー+1コントロール+2", 1, 2, 0, 0, 0),
                new MyItem("013", "ティッキー(old)：正確度+2", 0, 0, 2, 0, 0),
                new MyItem("014", "ティッキー：コントロール+2正確度+2", 0, 2, 2, 0, 0),
                new MyItem("015", "ロロ(old)：スピン+1カーブ+1", 0, 0, 0, 1, 1),
                new MyItem("016", "ロロ：コントロール+2スピン+1カーブ+1", 0, 2, 0, 1, 1),
                new MyItem("017", "キューマ(old)：カーブ+2", 0, 0, 0, 0, 2),
                new MyItem("018", "キューマ：コントロール+2カーブ+2", 0, 2, 0, 0, 2),
                new MyItem("019", "タンプー(old)：パワー+2コントロール+2", 2, 2, 0, 0, 0),
                new MyItem("020", "タンプー：パワー+2コントロール+2正確度+1", 2, 2, 1, 0, 0),
                new MyItem("021", "カディエ(old)：コントロール+2正確度+2", 0, 2, 2, 0, 0),
                new MyItem("022", "カディエ：パワー+2コントロール+2スピン+1", 2, 2, 0, 1, 0),
                new MyItem("023", "ミンティ：パワー+2正確度+2", 2, 0, 2, 0, 0),
                new MyItem("024", "ウィンクルピピン：コントロール+2", 0, 2, 0, 0, 0),
                new MyItem("025", "アーリオ&オーリオ(N)：コントロール+2正確度+2スピン+1", 0, 2, 2, 1, 0),
                new MyItem("026", "アーリオ&オーリオ(R)：コントロール+2スピン+10", 0, 2, 0, 10, 0),
                new MyItem("027", "Ami_typeN：パワー+2コントロール+2スピン+5", 2, 2, 0, 5, 0),
                new MyItem("028", "Ami_typeR：パワー+2コントロール+3スピン+10", 2, 3, 0, 10, 0),
                new MyItem("029", "らみょん：コントロール+2正確度+2", 0, 2, 2, 0, 0),
                new MyItem("030", "シエン(N)：パワー+2コントロール+2スピン+5カーブ+1", 2, 2, 0, 5, 1),
                new MyItem("031", "シエン(R)：パワー+2コントロール+3スピン+10カーブ+1", 2, 3, 0, 10, 1),                
                new MyItem("032", "カレン(EX/R)：パワー+2コントロール+4正確度+3スピン+10カーブ+6<ボイス有>", 2, 4, 3, 10, 6),
                new MyItem("033", "カレン(RX)：パワー+7コントロール+1正確度+3スピン+8カーブ+6<ボイス有>", 7, 1, 3, 8, 6),
                new MyItem("034", "カレン(N)：パワー+2コントロール+3正確度+1スピン+4カーブ+2<ボイス有>", 2, 3, 1, 4, 2),
                new MyItem("035", "サルポンタ：パワー+2コントロール+2スピン+10", 2, 2, 0, 10, 0),
                };
            ListBoxItem016.AddRange(mi_016);

            comboBox_nochara1.DisplayMember = "Name";
            comboBox_nochara1.ValueMember = "ID";
            comboBox_nochara1.DataSource = ListBoxItem016;

            //017　マスコット
            MyItem[] mi_017 =
                {
                new MyItem("000", "(なし)", 0, 0, 0, 0, 0),
                new MyItem("001", "ドロシー/ルーシア/ネル<+2y/5%の確率でゾーン増加>", 0, 0, 0, 0, 0),
                new MyItem("002", "サラマンダー/KAITO/スピカ/エリカ/セシリア<allステ+1/5%の確率でゾーン増加>", 1, 1, 1, 1, 1),
                new MyItem("003", "レン<飛距離+4y/5%の確率でゾーン増加>", 0, 0, 0, 0, 0),
                new MyItem("004", "ビリー/アリン/クー<装備slot+1/5%の確率でゾーン増加>", 0, 0, 0, 0, 0),
                new MyItem("005", "ウィンディーネ系<赤使用時ゲージ+3/5%の確率でゾーン増加>", 0, 0, 0, 0, 0),
                new MyItem("006", "シルフィード系<初期ゲージ+22/5%の確率でゾーン増加>", 0, 0, 0, 0, 0),
                new MyItem("007", "ノーム系<パンヤ時さらにゲージ+1/5%の確率でゾーン増加>", 0, 0, 0, 0, 0),
                new MyItem("008", "ティッキー<毎Hゲージ+2/装備slot+1/5%の確率でゾーン増加>", 0, 0, 0, 0, 0),                
                new MyItem("009", "ドルフ(スピン+2)<飛距離+3y/5%の確率でゾーン増加>", 0, 0, 0, 2, 0),
                new MyItem("010", "カディエ<コンボゲージ+1/毎Hゲージ+4/初期ゲージ+16>", 0, 0, 0, 0, 0),                
                new MyItem("011", "ロロ<飛距離+4y/パワー以外+1/装備slot+1/exp+20%>", 0, 1, 1, 1, 1)
                };
            ListBoxItem017.AddRange(mi_017);

            comboBox_nochara2.DisplayMember = "Name";
            comboBox_nochara2.ValueMember = "ID";
            comboBox_nochara2.DataSource = ListBoxItem017;

            //018　リング
            MyItem[] mi_018 =
                {
                new MyItem("000", "(なし)", 0, 0, 0, 0, 0),
                new MyItem("001", "パワー+1", 1, 0, 0, 0, 0),
                new MyItem("002", "コントロール+1", 0, 1, 0, 0, 0),
                new MyItem("003", "正確度+1", 0, 0, 1, 0, 0),
                new MyItem("004", "スピン+1", 0, 0, 0, 1, 0),
                new MyItem("005", "カーブ+1", 0, 0, 0, 0, 1),
                new MyItem("006", "クリムゾンリング/ミッドナイトリング<+4y>", 0, 0, 0, 0, 0),
                new MyItem("007", "アルティメットリング<全ステ+1>", 1, 1, 1, 1, 1),
                new MyItem("008", "イグナイトリング/ハイブリッドリング<+2y/初期ゲージ+22>", 0, 0, 0, 0, 0),
                new MyItem("009", "オビリン、ミスリン等<ゲージ増加>", 0, 0, 0, 0, 0),
                new MyItem("010", "フレアリング<ゲージ増加>", 0, 0, 0, 0, 0),                
                new MyItem("011", "雪椿の輝石<輝石セットでパンヤゾーン+1,毎Hゲージ+2/初期ゲージ+10>", 0, 0, 0, 0, 0),
                new MyItem("012", "レインボーパンヤリング<アニパン効果>", 0, 0, 0, 0, 0),
                new MyItem("013", "アースリング<高確率で地形100%/低確率でセーフティ,コロナとともに装備で+10y>",0,0,0,0,0)
                };
            ListBoxItem018.AddRange(mi_018);

            comboBox_nochara3.DisplayMember = "Name";
            comboBox_nochara3.ValueMember = "ID";
            comboBox_nochara3.DataSource = ListBoxItem018;

            //019　リングL
            MyItem[] mi_019 =
                {
                new MyItem("000", "(なし)", 0, 0, 0, 0, 0),
                new MyItem("001", "ピンクダイアリング(L)/クリアダイヤリング(L)<+10y発動中>", 0, 0, 0, 0, 0),
                new MyItem("002", "ピンクダイアリング(L)/クリアダイヤリング(L)<+10y未発動>", 0, 0, 0, 0, 0),
                new MyItem("003", "アニパンリング(L)<アニパン効果(小)>", 0, 0, 0, 0, 0),
                new MyItem("004", "マーズリング(L)<低確率でコンボゲージ2倍加算>", 0, 0, 0, 0, 0),
                new MyItem("005", "ネプチューンリング(L)<高確率で地面100%>", 0, 0, 0, 0, 0),
                new MyItem("006", "スカーレットリング(L)<+6y>", 0, 0, 0, 0, 0),
                new MyItem("007", "岩桔梗の輝石(L)<輝石セットでパンヤゾーン+1,+5y>", 0, 0, 0, 0, 0),
                new MyItem("008", "エアロディレクションリング(L)<イヤーカフ効果>", 0, 0, 0, 0, 0),
                new MyItem("009", "アストロリング(L)<低確率でゲージ使用状態、アイテム使用時ゲージ+4、アースとともに装備で+10y>",0,0,0,0,0)
                };
            ListBoxItem019.AddRange(mi_019);

            comboBox_nochara4.DisplayMember = "Name";
            comboBox_nochara4.ValueMember = "ID";
            comboBox_nochara4.DataSource = ListBoxItem019;

            //020　時間カード
            MyItem[] mi_020 =
                {
                new MyItem("000", "(なし)", 0, 0, 0, 0, 0),
                new MyItem("001", "<2時間パワー+1>", 1, 0, 0, 0, 0),
                new MyItem("002", "<2時間パワー+2(バグ?)>", 2, 0, 0, 0, 0),
                new MyItem("003", "<2時間コント+1>", 0, 1, 0, 0, 0),
                new MyItem("004", "<2時間正確度+1>", 0, 0, 1, 0, 0),
                new MyItem("005", "<2時間スピン+1>", 0, 0, 0, 1, 0),
                new MyItem("006", "<2時間カーブ+1>", 0, 0, 0, 0, 1),
                new MyItem("007", "<2時間飛距離+2y>", 0, 0, 0, 0, 0),
                new MyItem("008", "<1時間ゾーン+1>", 0, 0, 0, 0, 0),
                new MyItem("009", "<30分ゾーン+2>", 0, 0, 0, 0, 0),
                new MyItem("010", "<時間制限カードその他>", 0, 0, 0, 0, 0),
                new MyItem("011", "<ｃ全部(ALL+1)>", 1, 1, 1, 1, 1),
                new MyItem("012", "<ｃ全部(ALL+2)>", 2, 2, 2, 2, 2),
                new MyItem("013", "<ｃ全部(ALL+3)>", 3, 3, 3, 3, 3),
                };
            ListBoxItem020.AddRange(mi_020);

            comboBox_nochara5.DisplayMember = "Name";
            comboBox_nochara5.ValueMember = "ID";
            comboBox_nochara5.DataSource = ListBoxItem020;

            //0--　パンヤゾーン増加
            MyItem[] mi_zone =
                {
                new MyItem("000", "(なし)", 0, 0, 0, 0, 0),
                new MyItem("001", "パンヤゾーン+1pix(妖精の涙、幸運のネックレス(シニア～セミプロ))", 0, 0, 0, 0, 0),
                new MyItem("002", "パンヤゾーン+2pix(幸運のネックレス(ジュニアまで)、マスコット(発動時))", 0, 0, 0, 0, 0),
                new MyItem("003", "パンヤゾーン+3pix", 0, 0, 0, 0, 0),
                new MyItem("004", "パンヤゾーン+4pix(ラキパン、アニパン(発動時))", 0, 0, 0, 0, 0),
                new MyItem("005", "パンヤゾーン+5pix", 0, 0, 0, 0, 0),
                new MyItem("006", "パンヤゾーン+6pix(マジックエアーナイト：ルーキーF時)", 0, 0, 0, 0, 0),
                new MyItem("007", "パンヤゾーン+7pix", 0, 0, 0, 0, 0),
                new MyItem("008", "パンヤゾーン+8pix", 0, 0, 0, 0, 0),
                new MyItem("009", "パンヤゾーン+9pix", 0, 0, 0, 0, 0),
                new MyItem("010", "パンヤゾーン+10pix", 0, 0, 0, 0, 0),
                new MyItem("011", "パンヤゾーン+11pix", 0, 0, 0, 0, 0),
                new MyItem("012", "パンヤゾーン+12pix", 0, 0, 0, 0, 0),
                new MyItem("013", "パンヤゾーン+13pix", 0, 0, 0, 0, 0),
                new MyItem("014", "パンヤゾーン+14pix", 0, 0, 0, 0, 0),
                };
            ListBoxItemZone.AddRange(mi_zone);

            comboBox_nochara6.DisplayMember = "Name";
            comboBox_nochara6.ValueMember = "ID";
            comboBox_nochara6.DataSource = ListBoxItemZone;

            #endregion
            #region＜MyItem カード(NPC/キャディ)＞
            //021 NPCカード1
            MyItem[] mi_021 =
                {
                new MyItem("000", "(なし)", 0, 0, 0, 0, 0),
                new MyItem("001", "ミューレンN<240y↑の時コント+1>", 0, 1, 0, 0, 0),
                new MyItem("002", "ミューレンR<260y↑の時コント+2>", 0, 2, 0, 0, 0),
                new MyItem("003", "ミューレンSR<280y↑の時コント+3>", 0, 3, 0, 0, 0),
                new MyItem("004", "ミューレンSC<300y↑の時コント+4>", 0, 4, 0, 0, 0),
                new MyItem("005", "ティタンチャムN<260y↑パンヤゾーン増加+1>", 0, 0, 0, 0, 0),
                new MyItem("006", "ティタンチャムR<280y↑パンヤゾーン増加+2>", 0, 0, 0, 0, 0),
                new MyItem("007", "ティタンチャムSR<300y↑パンヤゾーン増加+3>", 0, 0, 0, 0, 0),
                new MyItem("009", "ティタンチャムSC<320y↑パンヤゾーン増加+4>", 0, 0, 0, 0, 0),
                new MyItem("008", "その他", 0, 0, 0, 0, 0)
                };
            ListBoxItem021.AddRange(mi_021);

            comboBox_card_npc1.DisplayMember = "Name";
            comboBox_card_npc1.ValueMember = "ID";
            comboBox_card_npc1.DataSource = ListBoxItem021;

            //022 NPCカード２
            MyItem[] mi_022 =
                {
                new MyItem("000", "(なし)", 0, 0, 0, 0, 0),
                new MyItem("001", "ミューレンN<240y↑の時コント+1>", 0, 1, 0, 0, 0),
                new MyItem("002", "ミューレンR<260y↑の時コント+2>", 0, 2, 0, 0, 0),
                new MyItem("003", "ミューレンSR<280y↑の時コント+3>", 0, 3, 0, 0, 0),
                new MyItem("004", "ミューレンSC<300y↑の時コント+4>", 0, 4, 0, 0, 0),
                new MyItem("005", "ティタンチャムN<260y↑パンヤゾーン増加+1>", 0, 0, 0, 0, 0),
                new MyItem("006", "ティタンチャムR<280y↑パンヤゾーン増加+2>", 0, 0, 0, 0, 0),
                new MyItem("007", "ティタンチャムSR<300y↑パンヤゾーン増加+3>", 0, 0, 0, 0, 0),
                new MyItem("009", "ティタンチャムSC<320y↑パンヤゾーン増加+4>", 0, 0, 0, 0, 0),
                new MyItem("008", "その他", 0, 0, 0, 0, 0)
                };
            ListBoxItem022.AddRange(mi_022);

            comboBox_card_npc2.DisplayMember = "Name";
            comboBox_card_npc2.ValueMember = "ID";
            comboBox_card_npc2.DataSource = ListBoxItem022;

            //023 キャディカード１
            MyItem[] mi_023 =
                {
                new MyItem("000", "(なし)", 0, 0, 0, 0, 0),
                new MyItem("001", "ロロN<パワー時+2y>", 0, 0, 0, 0, 0),
                new MyItem("002", "ロロR<パワー時+4y>", 0, 0, 0, 0, 0),
                new MyItem("003", "ロロSR<パワー時+6y>", 0, 0, 0, 0, 0),
                new MyItem("004", "ロロSC<パワー時+8y>", 0, 0, 0, 0, 0),
                new MyItem("005", "ピピンN<飛距離+1y>", 0, 0, 0, 0, 0),
                new MyItem("006", "ピピンR<飛距離+2y>", 0, 0, 0, 0, 0),
                new MyItem("007", "ピピンSR<飛距離+3y>", 0, 0, 0, 0, 0),
                new MyItem("008", "ピピンSC<飛距離+4y>", 0, 0, 0, 0, 0),
                new MyItem("009", "タンプーN<風速減少(9mのみ)>", 0, 0, 0, 0, 0),
                new MyItem("010", "タンプーR<風速減少-1>", 0, 0, 0, 0, 0),
                new MyItem("011", "タンプーSC<風速減少-1～-2>", 0, 0, 0, 0, 0),
                new MyItem("012", "カディエN", 0, 0, 0, 0, 0),
                new MyItem("013", "カディエR", 0, 0, 0, 0, 0),
                new MyItem("014", "カディエSR", 0, 0, 0, 0, 0),
                new MyItem("015", "カディエSC", 0, 0, 0, 0, 0),
                new MyItem("016", "キューマN<通常パンヤ時ゲージ増加+1>", 0, 0, 0, 0, 0),
                new MyItem("017", "キューマR<通常パンヤ時ゲージ増加+2>", 0, 0, 0, 0, 0),
                new MyItem("018", "キューマSR<通常パンヤ時ゲージ増加+3>", 0, 0, 0, 0, 0),
                new MyItem("019", "キューマSC<通常パンヤ時ゲージ増加+4>", 0, 0, 0, 0, 0),
                new MyItem("020", "ミンティN<初期ゲージ増加小(+10)>", 0, 0, 0, 0, 0),
                new MyItem("021", "ミンティR<初期ゲージ増加中(+17)>", 0, 0, 0, 0, 0),
                new MyItem("022", "ミンティSR<初期ゲージ増加大(+25)>", 0, 0, 0, 0, 0),
                new MyItem("023", "ミンティSC<初期ゲージ増加特(+33)>", 0, 0, 0, 0, 0),
                new MyItem("024", "ポンタ系<補助剤確率増加>", 0, 0, 0, 0, 0),
                new MyItem("025", "ティッキー系<トレジャーポイント増加>", 0, 0, 0, 0, 0),
                new MyItem("026", "ドルフ系<バウンドボーナス増加>", 0, 0, 0, 0, 0),
                new MyItem("027", "ウィンクルピピン系<パー時トレジャーポイント増加>", 0, 0, 0, 0, 0)
                };
            ListBoxItem023.AddRange(mi_023);

            comboBox_card_caddy1.DisplayMember = "Name";
            comboBox_card_caddy1.ValueMember = "ID";
            comboBox_card_caddy1.DataSource = ListBoxItem023;

            //024 キャディカード２
            MyItem[] mi_024 =
                {
                new MyItem("000", "(なし)", 0, 0, 0, 0, 0),
                new MyItem("001", "ロロN<パワー時+2y>", 0, 0, 0, 0, 0),
                new MyItem("002", "ロロR<パワー時+4y>", 0, 0, 0, 0, 0),
                new MyItem("003", "ロロSR<パワー時+6y>", 0, 0, 0, 0, 0),
                new MyItem("004", "ロロSC<パワー時+8y>", 0, 0, 0, 0, 0),
                new MyItem("005", "ピピンN<飛距離+1y>", 0, 0, 0, 0, 0),
                new MyItem("006", "ピピンR<飛距離+2y>", 0, 0, 0, 0, 0),
                new MyItem("007", "ピピンSR<飛距離+3y>", 0, 0, 0, 0, 0),
                new MyItem("008", "ピピンSC<飛距離+4y>", 0, 0, 0, 0, 0),
                new MyItem("009", "タンプーN<風速減少(9mのみ)>", 0, 0, 0, 0, 0),
                new MyItem("010", "タンプーR<風速減少-1>", 0, 0, 0, 0, 0),
                new MyItem("011", "タンプーSC<風速減少-1～-2>", 0, 0, 0, 0, 0),
                new MyItem("012", "カディエN", 0, 0, 0, 0, 0),
                new MyItem("013", "カディエR", 0, 0, 0, 0, 0),
                new MyItem("014", "カディエSR", 0, 0, 0, 0, 0),
                new MyItem("015", "カディエSC", 0, 0, 0, 0, 0),
                new MyItem("016", "キューマN<通常パンヤ時ゲージ増加+1>", 0, 0, 0, 0, 0),
                new MyItem("017", "キューマR<通常パンヤ時ゲージ増加+2>", 0, 0, 0, 0, 0),
                new MyItem("018", "キューマSR<通常パンヤ時ゲージ増加+3>", 0, 0, 0, 0, 0),
                new MyItem("019", "キューマSC<通常パンヤ時ゲージ増加+4>", 0, 0, 0, 0, 0),
                new MyItem("020", "ミンティN<初期ゲージ増加小(+10)>", 0, 0, 0, 0, 0),
                new MyItem("021", "ミンティR<初期ゲージ増加中(+17)>", 0, 0, 0, 0, 0),
                new MyItem("022", "ミンティSR<初期ゲージ増加大(+25)>", 0, 0, 0, 0, 0),
                new MyItem("023", "ミンティSC<初期ゲージ増加特(+33)>", 0, 0, 0, 0, 0),
                new MyItem("024", "ポンタ系<補助剤確率増加>", 0, 0, 0, 0, 0),
                new MyItem("025", "ティッキー系<トレジャーポイント増加>", 0, 0, 0, 0, 0),
                new MyItem("026", "ドルフ系<バウンドボーナス増加>", 0, 0, 0, 0, 0),
                new MyItem("027", "ウィンクルピピン系<パー時トレジャーポイント増加>", 0, 0, 0, 0, 0)
                };
            ListBoxItem024.AddRange(mi_024);

            comboBox_card_caddy2.DisplayMember = "Name";
            comboBox_card_caddy2.ValueMember = "ID";
            comboBox_card_caddy2.DataSource = ListBoxItem024;

            //025 キャディカード３
            MyItem[] mi_025 =
                {
                new MyItem("000", "(なし)", 0, 0, 0, 0, 0),
                new MyItem("001", "ロロN<パワー時+2y>", 0, 0, 0, 0, 0),
                new MyItem("002", "ロロR<パワー時+4y>", 0, 0, 0, 0, 0),
                new MyItem("003", "ロロSR<パワー時+6y>", 0, 0, 0, 0, 0),
                new MyItem("004", "ロロSC<パワー時+8y>", 0, 0, 0, 0, 0),
                new MyItem("005", "ピピンN<飛距離+1y>", 0, 0, 0, 0, 0),
                new MyItem("006", "ピピンR<飛距離+2y>", 0, 0, 0, 0, 0),
                new MyItem("007", "ピピンSR<飛距離+3y>", 0, 0, 0, 0, 0),
                new MyItem("008", "ピピンSC<飛距離+4y>", 0, 0, 0, 0, 0),
                new MyItem("009", "タンプーN<風速減少(9mのみ)>", 0, 0, 0, 0, 0),
                new MyItem("010", "タンプーR<風速減少-1>", 0, 0, 0, 0, 0),
                new MyItem("011", "タンプーSC<風速減少-1～-2>", 0, 0, 0, 0, 0),
                new MyItem("012", "カディエN", 0, 0, 0, 0, 0),
                new MyItem("013", "カディエR", 0, 0, 0, 0, 0),
                new MyItem("014", "カディエSR", 0, 0, 0, 0, 0),
                new MyItem("015", "カディエSC", 0, 0, 0, 0, 0),
                new MyItem("016", "キューマN<通常パンヤ時ゲージ増加+1>", 0, 0, 0, 0, 0),
                new MyItem("017", "キューマR<通常パンヤ時ゲージ増加+2>", 0, 0, 0, 0, 0),
                new MyItem("018", "キューマSR<通常パンヤ時ゲージ増加+3>", 0, 0, 0, 0, 0),
                new MyItem("019", "キューマSC<通常パンヤ時ゲージ増加+4>", 0, 0, 0, 0, 0),
                new MyItem("020", "ミンティN<初期ゲージ増加小(+10)>", 0, 0, 0, 0, 0),
                new MyItem("021", "ミンティR<初期ゲージ増加中(+17)>", 0, 0, 0, 0, 0),
                new MyItem("022", "ミンティSR<初期ゲージ増加大(+25)>", 0, 0, 0, 0, 0),
                new MyItem("023", "ミンティSC<初期ゲージ増加特(+33)>", 0, 0, 0, 0, 0),
                new MyItem("024", "ポンタ系<補助剤確率増加>", 0, 0, 0, 0, 0),
                new MyItem("025", "ティッキー系<トレジャーポイント増加>", 0, 0, 0, 0, 0),
                new MyItem("026", "ドルフ系<バウンドボーナス増加>", 0, 0, 0, 0, 0),
                new MyItem("027", "ウィンクルピピン系<パー時トレジャーポイント増加>", 0, 0, 0, 0, 0)
                };
            ListBoxItem025.AddRange(mi_025);

            comboBox_card_caddy3.DisplayMember = "Name";
            comboBox_card_caddy3.ValueMember = "ID";
            comboBox_card_caddy3.DataSource = ListBoxItem025;

            //026 キャディカード４
            MyItem[] mi_026 =
                {
                new MyItem("000", "(なし)", 0, 0, 0, 0, 0),
                new MyItem("001", "ロロN<パワー時+2y>", 0, 0, 0, 0, 0),
                new MyItem("002", "ロロR<パワー時+4y>", 0, 0, 0, 0, 0),
                new MyItem("003", "ロロSR<パワー時+6y>", 0, 0, 0, 0, 0),
                new MyItem("004", "ロロSC<パワー時+8y>", 0, 0, 0, 0, 0),
                new MyItem("005", "ピピンN<飛距離+1y>", 0, 0, 0, 0, 0),
                new MyItem("006", "ピピンR<飛距離+2y>", 0, 0, 0, 0, 0),
                new MyItem("007", "ピピンSR<飛距離+3y>", 0, 0, 0, 0, 0),
                new MyItem("008", "ピピンSC<飛距離+4y>", 0, 0, 0, 0, 0),
                new MyItem("009", "タンプーN<風速減少(9mのみ)>", 0, 0, 0, 0, 0),
                new MyItem("010", "タンプーR<風速減少-1>", 0, 0, 0, 0, 0),
                new MyItem("028", "タンプーSR<風速減少(6-9mで-2)>", 0, 0, 0, 0, 0),
                new MyItem("011", "タンプーSC<風速減少-1～-2>", 0, 0, 0, 0, 0),
                new MyItem("012", "カディエN", 0, 0, 0, 0, 0),
                new MyItem("013", "カディエR", 0, 0, 0, 0, 0),
                new MyItem("014", "カディエSR", 0, 0, 0, 0, 0),
                new MyItem("015", "カディエSC", 0, 0, 0, 0, 0),
                new MyItem("016", "キューマN<通常パンヤ時ゲージ増加+1>", 0, 0, 0, 0, 0),
                new MyItem("017", "キューマR<通常パンヤ時ゲージ増加+2>", 0, 0, 0, 0, 0),
                new MyItem("018", "キューマSR<通常パンヤ時ゲージ増加+3>", 0, 0, 0, 0, 0),
                new MyItem("019", "キューマSC<通常パンヤ時ゲージ増加+4>", 0, 0, 0, 0, 0),
                new MyItem("020", "ミンティN<初期ゲージ増加小(+10)>", 0, 0, 0, 0, 0),
                new MyItem("021", "ミンティR<初期ゲージ増加中(+17)>", 0, 0, 0, 0, 0),
                new MyItem("022", "ミンティSR<初期ゲージ増加大(+25)>", 0, 0, 0, 0, 0),
                new MyItem("023", "ミンティSC<初期ゲージ増加特(+33)>", 0, 0, 0, 0, 0),
                new MyItem("024", "ポンタ系<補助剤確率増加>", 0, 0, 0, 0, 0),
                new MyItem("025", "ティッキー系<トレジャーポイント増加>", 0, 0, 0, 0, 0),
                new MyItem("026", "ドルフ系<バウンドボーナス増加>", 0, 0, 0, 0, 0),
                new MyItem("027", "ウィンクルピピン系<パー時トレジャーポイント増加>", 0, 0, 0, 0, 0)
                };
            ListBoxItem026.AddRange(mi_026);

            comboBox_card_caddy4.DisplayMember = "Name";
            comboBox_card_caddy4.ValueMember = "ID";
            comboBox_card_caddy4.DataSource = ListBoxItem026;
            #endregion
            #region＜MyItem カード(キャラクター)＞
            //027 キャラカード１
            MyItem[] mi_027 =
                {
                new MyItem("000", "(なし)", 0, 0, 0, 0, 0),
                new MyItem("001", "パワー+1", 1, 0, 0, 0, 0),
                new MyItem("002", "パワー+1スピン+1(カズR)", 1, 0, 0, 1, 0),
                new MyItem("003", "パワー+1スピン+2(カズSR)", 1, 0, 0, 2, 0),
                new MyItem("004", "パワー+1正確度+1(マックスR)", 1, 0, 1, 0, 0),
                new MyItem("005", "パワー+2正確度+1(マックスSR)", 2, 0, 1, 0, 0),
                new MyItem("006", "パワー+3コント+1(マックスSC)", 3, 1, 0, 0, 0),
                new MyItem("007", "コントロール+1(各種R)", 0, 1, 0, 0, 0),
                new MyItem("008", "コントロール+1正確度+3(セシSC)", 0, 1, 3, 0, 0),
                new MyItem("009", "コントロール+1スピン+2(スピカSR)", 0, 1, 0, 2, 0),
                new MyItem("010", "コントロール+1スピン+3(ダイスケSC/カズSC)", 0, 1, 0, 3, 0),
                new MyItem("011", "コントロール+1カーブ+4(エリカSC)", 0, 1, 0, 0, 4),
                new MyItem("012", "コントロール+2パワー+1<飛距離-2>(クーSR)", 1, 2, 0, 0, 0),
                new MyItem("032", "コントロール+3パワー+1<飛距離-1>(クーSC)", 1, 3, 0, 0, 0),
                new MyItem("013", "コントロール+2正確度+1<飛距離-2>(ネルSR)", 0, 2, 1, 0, 0),
                new MyItem("014", "コントロール+2正確度+1<飛距離-1>(ネルSC)", 0, 2, 1, 0, 0),
                new MyItem("015", "コントロール+2スピン+1<飛距離-2>(ケンSR)", 0, 2, 0, 1, 0),
                new MyItem("016", "コントロール+2スピン+1<飛距離-1>(ケンSC)", 0, 2, 0, 1, 0),
                new MyItem("017", "コントロール+2スピン+3<飛距離-2>(スピカSC)", 0, 2, 0, 3, 0),
                new MyItem("018", "正確度+1", 0, 0, 1, 0, 0),
                new MyItem("019", "正確度+1カーブ+1(アリンR)", 0, 0, 1, 0, 1),
                new MyItem("020", "正確度+2(セシR)", 0, 0, 2, 0, 0),
                new MyItem("021", "正確度+2カーブ+1(セシSR)", 0, 0, 2, 0, 1),
                new MyItem("022", "正確度+2カーブ+2(アリンSR)", 0, 0, 2, 0, 2),
                new MyItem("033", "正確度+2カーブ+3(アリンSC)", 0, 0, 2, 0, 3),
                new MyItem("023", "スピン+1", 0, 0, 0, 1, 0),
                new MyItem("024", "スピン+1カーブ+1(ルーシアR)", 0, 0, 0, 1, 1),
                new MyItem("025", "スピン+1カーブ+2(ルーシアSR)", 0, 0, 0, 1, 2),
                new MyItem("026", "スピン+1カーブ+3(ルーシアSC)", 0, 0, 0, 1, 3),
                new MyItem("027", "スピン+2(ダイスケ/カズR)", 0, 0, 0, 2, 0),
                new MyItem("028", "スピン+3(ダイスケSR)", 0, 0, 0, 3, 0),
                new MyItem("029", "カーブ+1", 0, 0, 0, 0, 1),
                new MyItem("030", "カーブ+2(エリカR)", 0, 0, 0, 0, 2),
                new MyItem("031", "カーブ+3(エリカSR)", 0, 0, 0, 0, 3)
                };
            ListBoxItem027.AddRange(mi_027);

            comboBox_card_chara1.DisplayMember = "Name";
            comboBox_card_chara1.ValueMember = "ID";
            comboBox_card_chara1.DataSource = ListBoxItem027;

            //028 キャラカード２
            MyItem[] mi_028 =
                {
                new MyItem("000", "(なし)", 0, 0, 0, 0, 0),
                new MyItem("001", "パワー+1", 1, 0, 0, 0, 0),
                new MyItem("002", "パワー+1スピン+1(カズR)", 1, 0, 0, 1, 0),
                new MyItem("003", "パワー+1スピン+2(カズSR)", 1, 0, 0, 2, 0),
                new MyItem("004", "パワー+1正確度+1(マックスR)", 1, 0, 1, 0, 0),
                new MyItem("005", "パワー+2正確度+1(マックスSR)", 2, 0, 1, 0, 0),
                new MyItem("006", "パワー+3コント+1(マックスSC)", 3, 1, 0, 0, 0),
                new MyItem("007", "コントロール+1(各種R)", 0, 1, 0, 0, 0),
                new MyItem("008", "コントロール+1正確度+3(セシSC)", 0, 1, 3, 0, 0),
                new MyItem("009", "コントロール+1スピン+2(スピカSR)", 0, 1, 0, 2, 0),
                new MyItem("010", "コントロール+1スピン+3(ダイスケSC/カズSC)", 0, 1, 0, 3, 0),
                new MyItem("011", "コントロール+1カーブ+4(エリカSC)", 0, 1, 0, 0, 4),
                new MyItem("012", "コントロール+2パワー+1<飛距離-2>(クーSR)", 1, 2, 0, 0, 0),
                new MyItem("032", "コントロール+3パワー+1<飛距離-1>(クーSC)", 1, 3, 0, 0, 0),
                new MyItem("013", "コントロール+2正確度+1<飛距離-2>(ネルSR)", 0, 2, 1, 0, 0),
                new MyItem("014", "コントロール+2正確度+1<飛距離-1>(ネルSC)", 0, 2, 1, 0, 0),
                new MyItem("015", "コントロール+2スピン+1<飛距離-2>(ケンSR)", 0, 2, 0, 1, 0),
                new MyItem("016", "コントロール+2スピン+1<飛距離-1>(ケンSC)", 0, 2, 0, 1, 0),
                new MyItem("017", "コントロール+2スピン+3<飛距離-2>(スピカSC)", 0, 2, 0, 3, 0),
                new MyItem("018", "正確度+1", 0, 0, 1, 0, 0),
                new MyItem("019", "正確度+1カーブ+1(アリンR)", 0, 0, 1, 0, 1),
                new MyItem("020", "正確度+2(セシR)", 0, 0, 2, 0, 0),
                new MyItem("021", "正確度+2カーブ+1(セシSR)", 0, 0, 2, 0, 1),
                new MyItem("022", "正確度+2カーブ+2(アリンSR)", 0, 0, 2, 0, 2),
                new MyItem("033", "正確度+2カーブ+3(アリンSC)", 0, 0, 2, 0, 3),
                new MyItem("023", "スピン+1", 0, 0, 0, 1, 0),
                new MyItem("024", "スピン+1カーブ+1(ルーシアR)", 0, 0, 0, 1, 1),
                new MyItem("025", "スピン+1カーブ+2(ルーシアSR)", 0, 0, 0, 1, 2),
                new MyItem("026", "スピン+1カーブ+3(ルーシアSC)", 0, 0, 0, 1, 3),
                new MyItem("027", "スピン+2(ダイスケ/カズR)", 0, 0, 0, 2, 0),
                new MyItem("028", "スピン+3(ダイスケSR)", 0, 0, 0, 3, 0),
                new MyItem("029", "カーブ+1", 0, 0, 0, 0, 1),
                new MyItem("030", "カーブ+2(エリカR)", 0, 0, 0, 0, 2),
                new MyItem("031", "カーブ+3(エリカSR)", 0, 0, 0, 0, 3)
                };
            ListBoxItem028.AddRange(mi_028);

            comboBox_card_chara2.DisplayMember = "Name";
            comboBox_card_chara2.ValueMember = "ID";
            comboBox_card_chara2.DataSource = ListBoxItem028;

            //029 キャラカード３
            MyItem[] mi_029 =
                {
                new MyItem("000", "(なし)", 0, 0, 0, 0, 0),
                new MyItem("001", "パワー+1", 1, 0, 0, 0, 0),
                new MyItem("002", "パワー+1スピン+1(カズR)", 1, 0, 0, 1, 0),
                new MyItem("003", "パワー+1スピン+2(カズSR)", 1, 0, 0, 2, 0),
                new MyItem("004", "パワー+1正確度+1(マックスR)", 1, 0, 1, 0, 0),
                new MyItem("005", "パワー+2正確度+1(マックスSR)", 2, 0, 1, 0, 0),
                new MyItem("006", "パワー+3コント+1(マックスSC)", 3, 1, 0, 0, 0),
                new MyItem("007", "コントロール+1(各種R)", 0, 1, 0, 0, 0),
                new MyItem("008", "コントロール+1正確度+3(セシSC)", 0, 1, 3, 0, 0),
                new MyItem("009", "コントロール+1スピン+2(スピカSR)", 0, 1, 0, 2, 0),
                new MyItem("010", "コントロール+1スピン+3(ダイスケSC/カズSC)", 0, 1, 0, 3, 0),
                new MyItem("011", "コントロール+1カーブ+4(エリカSC)", 0, 1, 0, 0, 4),
                new MyItem("012", "コントロール+2パワー+1<飛距離-2>(クーSR)", 1, 2, 0, 0, 0),
                new MyItem("032", "コントロール+3パワー+1<飛距離-1>(クーSC)", 1, 3, 0, 0, 0),
                new MyItem("013", "コントロール+2正確度+1<飛距離-2>(ネルSR)", 0, 2, 1, 0, 0),
                new MyItem("014", "コントロール+2正確度+1<飛距離-1>(ネルSC)", 0, 2, 1, 0, 0),
                new MyItem("015", "コントロール+2スピン+1<飛距離-2>(ケンSR)", 0, 2, 0, 1, 0),
                new MyItem("016", "コントロール+2スピン+1<飛距離-1>(ケンSC)", 0, 2, 0, 1, 0),
                new MyItem("017", "コントロール+2スピン+3<飛距離-2>(スピカSC)", 0, 2, 0, 3, 0),
                new MyItem("018", "正確度+1", 0, 0, 1, 0, 0),
                new MyItem("019", "正確度+1カーブ+1(アリンR)", 0, 0, 1, 0, 1),
                new MyItem("020", "正確度+2(セシR)", 0, 0, 2, 0, 0),
                new MyItem("021", "正確度+2カーブ+1(セシSR)", 0, 0, 2, 0, 1),
                new MyItem("022", "正確度+2カーブ+2(アリンSR)", 0, 0, 2, 0, 2),
                new MyItem("033", "正確度+2カーブ+3(アリンSC)", 0, 0, 2, 0, 3),
                new MyItem("023", "スピン+1", 0, 0, 0, 1, 0),
                new MyItem("024", "スピン+1カーブ+1(ルーシアR)", 0, 0, 0, 1, 1),
                new MyItem("025", "スピン+1カーブ+2(ルーシアSR)", 0, 0, 0, 1, 2),
                new MyItem("026", "スピン+1カーブ+3(ルーシアSC)", 0, 0, 0, 1, 3),
                new MyItem("027", "スピン+2(ダイスケ/カズR)", 0, 0, 0, 2, 0),
                new MyItem("028", "スピン+3(ダイスケSR)", 0, 0, 0, 3, 0),
                new MyItem("029", "カーブ+1", 0, 0, 0, 0, 1),
                new MyItem("030", "カーブ+2(エリカR)", 0, 0, 0, 0, 2),
                new MyItem("031", "カーブ+3(エリカSR)", 0, 0, 0, 0, 3)
                };
            ListBoxItem029.AddRange(mi_029);

            comboBox_card_chara3.DisplayMember = "Name";
            comboBox_card_chara3.ValueMember = "ID";
            comboBox_card_chara3.DataSource = ListBoxItem029;

            //030 キャラカード４
            MyItem[] mi_030 =
                {
                new MyItem("000", "(なし)", 0, 0, 0, 0, 0),
                new MyItem("001", "パワー+1", 1, 0, 0, 0, 0),
                new MyItem("002", "パワー+1スピン+1(カズR)", 1, 0, 0, 1, 0),
                new MyItem("003", "パワー+1スピン+2(カズSR)", 1, 0, 0, 2, 0),
                new MyItem("004", "パワー+1正確度+1(マックスR)", 1, 0, 1, 0, 0),
                new MyItem("005", "パワー+2正確度+1(マックスSR)", 2, 0, 1, 0, 0),
                new MyItem("006", "パワー+3コント+1(マックスSC)", 3, 1, 0, 0, 0),
                new MyItem("007", "コントロール+1(各種R)", 0, 1, 0, 0, 0),
                new MyItem("008", "コントロール+1正確度+3(セシSC)", 0, 1, 3, 0, 0),
                new MyItem("009", "コントロール+1スピン+2(スピカSR)", 0, 1, 0, 2, 0),
                new MyItem("010", "コントロール+1スピン+3(ダイスケSC/カズSC)", 0, 1, 0, 3, 0),
                new MyItem("011", "コントロール+1カーブ+4(エリカSC)", 0, 1, 0, 0, 4),
                new MyItem("012", "コントロール+2パワー+1<飛距離-2>(クーSR)", 1, 2, 0, 0, 0),
                new MyItem("032", "コントロール+3パワー+1<飛距離-1>(クーSC)", 1, 3, 0, 0, 0),
                new MyItem("013", "コントロール+2正確度+1<飛距離-2>(ネルSR)", 0, 2, 1, 0, 0),
                new MyItem("014", "コントロール+2正確度+1<飛距離-1>(ネルSC)", 0, 2, 1, 0, 0),
                new MyItem("015", "コントロール+2スピン+1<飛距離-2>(ケンSR)", 0, 2, 0, 1, 0),
                new MyItem("016", "コントロール+2スピン+1<飛距離-1>(ケンSC)", 0, 2, 0, 1, 0),
                new MyItem("017", "コントロール+2スピン+3<飛距離-2>(スピカSC)", 0, 2, 0, 3, 0),
                new MyItem("018", "正確度+1", 0, 0, 1, 0, 0),
                new MyItem("019", "正確度+1カーブ+1(アリンR)", 0, 0, 1, 0, 1),
                new MyItem("020", "正確度+2(セシR)", 0, 0, 2, 0, 0),
                new MyItem("021", "正確度+2カーブ+1(セシSR)", 0, 0, 2, 0, 1),
                new MyItem("022", "正確度+2カーブ+2(アリンSR)", 0, 0, 2, 0, 2),
                new MyItem("033", "正確度+2カーブ+3(アリンSC)", 0, 0, 2, 0, 3),
                new MyItem("023", "スピン+1", 0, 0, 0, 1, 0),
                new MyItem("024", "スピン+1カーブ+1(ルーシアR)", 0, 0, 0, 1, 1),
                new MyItem("025", "スピン+1カーブ+2(ルーシアSR)", 0, 0, 0, 1, 2),
                new MyItem("026", "スピン+1カーブ+3(ルーシアSC)", 0, 0, 0, 1, 3),
                new MyItem("027", "スピン+2(ダイスケ/カズR)", 0, 0, 0, 2, 0),
                new MyItem("028", "スピン+3(ダイスケSR)", 0, 0, 0, 3, 0),
                new MyItem("029", "カーブ+1", 0, 0, 0, 0, 1),
                new MyItem("030", "カーブ+2(エリカR)", 0, 0, 0, 0, 2),
                new MyItem("031", "カーブ+3(エリカSR)", 0, 0, 0, 0, 3)
                };
            ListBoxItem030.AddRange(mi_030);

            comboBox_card_chara4.DisplayMember = "Name";
            comboBox_card_chara4.ValueMember = "ID";
            comboBox_card_chara4.DataSource = ListBoxItem030;

            #endregion
            #region＜MyItem_clubrank クラブセットのランク＞
            //クラブセットのランク
            MyItem_clubrank[] mi_rank =
                {
                new MyItem_clubrank(30, "E1"),
                new MyItem_clubrank(31, "E2"),
                new MyItem_clubrank(32, "E3"),
                new MyItem_clubrank(33, "E4"),
                new MyItem_clubrank(34, "E5"),
                new MyItem_clubrank(35, "D1"),
                new MyItem_clubrank(36, "D2"),
                new MyItem_clubrank(37, "D3"),
                new MyItem_clubrank(38, "D4"),
                new MyItem_clubrank(39, "D5"),
                new MyItem_clubrank(40, "C1"),
                new MyItem_clubrank(41, "C2"),
                new MyItem_clubrank(42, "C3"),
                new MyItem_clubrank(43, "C4"),
                new MyItem_clubrank(44, "C5"),
                new MyItem_clubrank(45, "B1"),
                new MyItem_clubrank(46, "B2"),
                new MyItem_clubrank(47, "B3"),
                new MyItem_clubrank(48, "B4"),
                new MyItem_clubrank(49, "B5"),
                new MyItem_clubrank(50, "A1"),
                new MyItem_clubrank(51, "A2"),
                new MyItem_clubrank(52, "A3"),
                new MyItem_clubrank(53, "A4"),
                new MyItem_clubrank(54, "A5"),
                new MyItem_clubrank(56, "Ｓ")
                };
            ListBoxclubrank.AddRange(mi_rank);

            comboBox_clubrank.DisplayMember = "Name";
            comboBox_clubrank.ValueMember = "IDc";
            comboBox_clubrank.DataSource = ListBoxclubrank;
            #endregion

            #region＜MyItem 拡張スロット(ケン～クー)＞
            //ケン
            MyItem[] mi_add000 =
                {
                new MyItem("000", "(なし)",0,0,0,0,0),
                new MyItem("001", "Lv1:パワー",1,0,0,0,0),
                new MyItem("002", "Lv2:パワー",2,0,0,0,0),
                new MyItem("003", "Lv3:パワー(ジュニアE↑)",3,0,0,0,0),
                new MyItem("004", "Lv4:スピン",3,0,0,1,0),
                new MyItem("005", "Lv5:コントロール(アマチュアE↑)",3,1,0,1,0),
                new MyItem("006", "Lv6:カーブ",3,1,0,1,1),
                new MyItem("007", "Lv7:カーブ",3,1,0,1,2),
                new MyItem("008", "Lv8:パワー(プロE↑)",4,1,0,1,2),
                new MyItem("009", "Lv9:パワー",5,1,0,1,2),
                new MyItem("010", "Lv10:コントロール(マスターE↑)",5,2,0,1,2)
                };
            ListBoxAddslot000.AddRange(mi_add000);
            //エリカ
            MyItem[] mi_add001 =
                {
                new MyItem("000", "(なし)",0,0,0,0,0),
                new MyItem("001", "Lv1:パワー",1,0,0,0,0),
                new MyItem("002", "Lv2:パワー",2,0,0,0,0),
                new MyItem("003", "Lv3:パワー(ジュニアE↑)",3,0,0,0,0),
                new MyItem("004", "Lv4:コントロール",3,1,0,0,0),
                new MyItem("005", "Lv5:スピン(アマチュアE↑)",3,1,0,1,0),
                new MyItem("006", "Lv6:カーブ",3,1,0,1,1),
                new MyItem("007", "Lv7:カーブ",3,1,0,1,2),
                new MyItem("008", "Lv8:スピン(プロE↑)",3,1,0,2,2),
                new MyItem("009", "Lv9:コントロール",3,2,0,2,2),
                new MyItem("010", "Lv10:パワー(マスターE↑)",4,2,0,2,2)
                };
            ListBoxAddslot001.AddRange(mi_add001);
            //ダイスケ
            MyItem[] mi_add002 =
                {
                new MyItem("000", "(なし)",0,0,0,0,0),
                new MyItem("001", "Lv1:パワー",1,0,0,0,0),
                new MyItem("002", "Lv2:コントロール",1,1,0,0,0),
                new MyItem("003", "Lv3:コントロール(ジュニアE↑)",1,2,0,0,0),
                new MyItem("004", "Lv4:カーブ",1,2,0,0,1),
                new MyItem("005", "Lv5:パワー(アマチュアE↑)",2,2,0,0,1),
                new MyItem("006", "Lv6:カーブ",2,2,0,0,2),
                new MyItem("007", "Lv7:コントロール",2,3,0,0,2),
                new MyItem("008", "Lv8:カーブ(プロE↑)",2,3,0,0,3),
                new MyItem("009", "Lv9:パワー",3,3,0,0,3),
                new MyItem("010", "Lv10:コントロール(マスターE↑)",3,4,0,0,3)
                };
            ListBoxAddslot002.AddRange(mi_add002);
            //セシリア
            MyItem[] mi_add003 =
                {
                new MyItem("000", "(なし)",0,0,0,0,0),
                new MyItem("001", "Lv1:コントロール",0,1,0,0,0),
                new MyItem("002", "Lv2:パワー",1,1,0,0,0),
                new MyItem("003", "Lv3:コントロール(ジュニアE↑)",1,2,0,0,0),
                new MyItem("004", "Lv4:コントロール",1,3,0,0,0),
                new MyItem("005", "Lv5:スピン(アマチュアE↑)",1,3,0,1,0),
                new MyItem("006", "Lv6:スピン",1,3,0,2,0),
                new MyItem("007", "Lv7:スピン",1,3,0,3,0),
                new MyItem("008", "Lv8:スピン(プロE↑)",1,3,0,4,0),
                new MyItem("009", "Lv9:パワー",2,3,0,4,0),
                new MyItem("010", "Lv10:コントロール(マスターE↑)",2,4,0,4,0)
                };
            ListBoxAddslot003.AddRange(mi_add003);
            //マックス
            MyItem[] mi_add004 =
                {
                new MyItem("000", "(なし)",0,0,0,0,0),
                new MyItem("001", "Lv1:スピン",0,0,0,1,0),
                new MyItem("002", "Lv2:スピン",0,0,0,2,0),
                new MyItem("003", "Lv3:スピン(ジュニアE↑)",0,0,0,3,0),
                new MyItem("004", "Lv4:カーブ",0,0,0,3,1),
                new MyItem("005", "Lv5:コントロール(アマチュアE↑)",0,1,0,3,1),
                new MyItem("006", "Lv6:カーブ",0,1,0,3,2),
                new MyItem("007", "Lv7:カーブ",0,1,0,3,3),
                new MyItem("008", "Lv8:スピン(プロE↑)",0,1,0,4,3),
                new MyItem("009", "Lv9:パワー",1,1,0,4,3),
                new MyItem("010", "Lv10:コントロール(マスターE↑)",1,2,0,4,3)
                };
            ListBoxAddslot004.AddRange(mi_add004);
            //クー
            MyItem[] mi_add005 =
                {
                new MyItem("000", "(なし)",0,0,0,0,0),
                new MyItem("001", "Lv1:パワー",1,0,0,0,0),
                new MyItem("002", "Lv2:パワー",2,0,0,0,0),
                new MyItem("003", "Lv3:コントロール(ジュニアE↑)",2,1,0,0,0),
                new MyItem("004", "Lv4:スピン",2,1,0,1,0),
                new MyItem("005", "Lv5:パワー(アマチュアE↑)",3,1,0,1,0),
                new MyItem("006", "Lv6:カーブ",3,1,0,1,1),
                new MyItem("007", "Lv7:コントロール",3,2,0,1,1),
                new MyItem("008", "Lv8:カーブ(プロE↑)",3,2,0,1,2),
                new MyItem("009", "Lv9:パワー",4,2,0,1,2),
                new MyItem("010", "Lv10:コントロール(マスターE↑)",4,3,0,2,1)
                };
            ListBoxAddslot005.AddRange(mi_add005);
            #endregion
            #region＜MyItem 拡張スロット(アリン～スピカ)＞
            //アリン
            MyItem[] mi_add006 =
                {
                new MyItem("000", "(なし)",0,0,0,0,0),
                new MyItem("001", "Lv1:パワー",1,0,0,0,0),
                new MyItem("002", "Lv2:スピン",1,0,0,1,0),
                new MyItem("003", "Lv3:スピン(ジュニアE↑)",1,0,0,2,0),
                new MyItem("004", "Lv4:コントロール",1,1,0,2,0),
                new MyItem("005", "Lv5:カーブ(アマチュアE↑)",1,1,0,2,1),
                new MyItem("006", "Lv6:スピン",1,1,0,3,1),
                new MyItem("007", "Lv7:コントロール",1,2,0,3,1),
                new MyItem("008", "Lv8:パワー(プロE↑)",2,2,0,3,1),
                new MyItem("009", "Lv9:パワー",3,2,0,3,1),
                new MyItem("010", "Lv10:コントロール(マスターE↑)",3,3,0,3,1)
                };
            ListBoxAddslot006.AddRange(mi_add006);
            //カズ
            MyItem[] mi_add007 =
                {
                new MyItem("000", "(なし)",0,0,0,0,0),
                new MyItem("001", "Lv1:スピン",0,0,0,1,0),
                new MyItem("002", "Lv2:スピン",0,0,0,2,0),
                new MyItem("003", "Lv3:パワー(ジュニアE↑)",1,0,0,2,0),
                new MyItem("004", "Lv4:カーブ",1,0,0,2,1),
                new MyItem("005", "Lv5:コントロール(アマチュアE↑)",1,1,0,2,1),
                new MyItem("006", "Lv6:パワー",2,1,0,2,1),
                new MyItem("007", "Lv7:カーブ",2,1,0,2,2),
                new MyItem("008", "Lv8:スピン(プロE↑)",2,1,0,3,2),
                new MyItem("009", "Lv9:カーブ",2,1,0,3,3),
                new MyItem("010", "Lv10:コントロール(マスターE↑)",2,2,0,3,3)
                };
            ListBoxAddslot007.AddRange(mi_add007);
            //ルーシア
            MyItem[] mi_add008 =
                {
                new MyItem("000", "(なし)",0,0,0,0,0),
                new MyItem("001", "Lv1:スピン",0,0,0,1,0),
                new MyItem("002", "Lv2:コントロール",0,1,0,1,0),
                new MyItem("003", "Lv3:パワー(ジュニアE↑)",1,1,0,1,0),
                new MyItem("004", "Lv4:パワー",2,1,0,1,0),
                new MyItem("005", "Lv5:スピン(アマチュアE↑)",2,1,0,2,0),
                new MyItem("006", "Lv6:カーブ",2,1,0,2,1),
                new MyItem("007", "Lv7:パワー",3,1,0,2,1),
                new MyItem("008", "Lv8:スピン(プロE↑)",3,1,0,3,1),
                new MyItem("009", "Lv9:カーブ",3,1,0,3,2),
                new MyItem("010", "Lv10:コントロール(マスターE↑)",3,2,0,3,2)
                };
            ListBoxAddslot008.AddRange(mi_add008);
            //ネル
            MyItem[] mi_add009 =
                {
                new MyItem("000", "(なし)",0,0,0,0,0),
                new MyItem("001", "Lv1:スピン",0,0,0,1,0),
                new MyItem("002", "Lv2:コントロール",0,1,0,1,0),
                new MyItem("003", "Lv3:コントロール(ジュニアE↑)",0,2,0,1,0),
                new MyItem("004", "Lv4:パワー",1,2,0,1,0),
                new MyItem("005", "Lv5:カーブ(アマチュアE↑)",1,2,0,1,1),
                new MyItem("006", "Lv6:カーブ",1,2,0,1,2),
                new MyItem("007", "Lv7:パワー",2,2,0,1,2),
                new MyItem("008", "Lv8:スピン(プロE↑)",2,2,0,2,2),
                new MyItem("009", "Lv9:カーブ",2,2,0,2,3),
                new MyItem("010", "Lv10:コントロール(マスターE↑)",2,3,0,2,3)
                };
            ListBoxAddslot009.AddRange(mi_add009);
            //スピカ
            MyItem[] mi_add010 =
                {
                new MyItem("000", "(なし)",0,0,0,0,0),
                new MyItem("001", "Lv1:パワー",1,0,0,0,0),
                new MyItem("002", "Lv2:パワー",2,0,0,0,0),
                new MyItem("003", "Lv3:パワー(ジュニアE↑)",3,0,0,0,0),
                new MyItem("004", "Lv4:スピン",3,0,0,1,0),
                new MyItem("005", "Lv5:コントロール(アマチュアE↑)",3,1,0,1,0),
                new MyItem("006", "Lv6:カーブ",3,1,0,1,1),
                new MyItem("007", "Lv7:スピン",3,1,0,2,1),
                new MyItem("008", "Lv8:カーブ(プロE↑)",3,1,0,2,2),
                new MyItem("009", "Lv9:スピン",3,1,0,3,2),
                new MyItem("010", "Lv10:パワー(マスターE↑)",4,1,0,3,2)
                };
            ListBoxAddslot010.AddRange(mi_add010);

            comboBox_addslot.DisplayMember = "Name";
            comboBox_addslot.ValueMember = "ID";
            comboBox_addslot.DataSource = ListBoxAddslot000;

            #endregion
            //セーブデータのコンボボックス
            string[] defaultsavelist = {"Save0：(なし)","Save1：(なし)","Save2：(なし)","Save3：(なし)","Save4：(なし)",
                                            "Save5：(なし)","Save6：(なし)","Save7：(なし)","Save8：(なし)","Save9：(なし)",
                                            "Save10：(なし)","Save11：(なし)","Save12：(なし)","Save13：(なし)","Save14：(なし)"};
            comboBox_save.Items.AddRange(defaultsavelist);

            //まずクラブセットの計算へ～
            this.clubset_calc();
            return;
        }

        //クラブ系//////////////////////////////////////////////////////////////////////////

        //クラブセットの分を追加する計算
        public void clubset_calc()
        {
            if (!bInit) return;
            try
            {
                this.clubchange();
                this.clubset_rank_calc();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            return;
        }
        //クラブ改造の最大値を設定する計算
        public void clubset_rank_calc()
        {
            try
            {
                this.clubcustommax();
                this.clubset_custom_calc();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            return;
        }
        //クラブ改造の分を追加する計算
        public void clubset_custom_calc()
        {
            try
            {
                this.clubcustom();
                this.clubset_kekka_calc();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        public void clubset_kekka_calc()
        {
            try
            {
                //改造による増加分
                //club_status_kekka1 = club_status_1 - club_status_1_default;
                result_club_1 = club_status_1;
                result_club_2 = club_status_2;
                result_club_3 = club_status_3;
                result_club_4 = club_status_4;
                result_club_5 = club_status_5;

                //結果出力
                this.textBox_clubcustom.Text = Convert.ToString(string.Format("{0}", club_kaizo_kaisu));
                this.textBox01_2.Text = Convert.ToString(string.Format("{0}", result_club_1));
                this.textBox02_2.Text = Convert.ToString(string.Format("{0}", result_club_2));
                this.textBox03_2.Text = Convert.ToString(string.Format("{0}", result_club_3));
                this.textBox04_2.Text = Convert.ToString(string.Format("{0}", result_club_4));
                this.textBox05_2.Text = Convert.ToString(string.Format("{0}", result_club_5));

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            this.main();
            return;
        }
        //クラブセットの変更
        public void clubchange()
        {
            //クラブセットとランクは上位下位の関係にある
            //クラブセットを変更した時は、まずクラブセットの値を変え、その後ランクを自動で決定する
            clubset_total = ((MyItem)comboBox_clubset.SelectedItem).data_01 +
                            ((MyItem)comboBox_clubset.SelectedItem).data_02 +
                            ((MyItem)comboBox_clubset.SelectedItem).data_03 +
                            ((MyItem)comboBox_clubset.SelectedItem).data_04 +
                            ((MyItem)comboBox_clubset.SelectedItem).data_05;
            club_kaizo = clubset_total;
            //エアーナイト
            if (((MyItem)comboBox_clubset.SelectedItem).ID == "000")
            {
                comboBox_clubrank.SelectedIndex = 0;
                this.label_clubrank.Text = Convert.ToString(string.Format("改造不可"));
            }
            //マジックエアーナイト
            else if (((MyItem)comboBox_clubset.SelectedItem).ID == "001")
            {
                comboBox_clubrank.SelectedIndex = 0;
                this.label_clubrank.Text = Convert.ToString(string.Format("改造不可"));
            }
            else if (clubset_total >= 30)
            {
                //Index調整
                comboBox_clubrank.SelectedIndex = clubset_total - 30;
                this.label_clubrank.Text = Convert.ToString(string.Format("{0}", ((MyItem_clubrank)comboBox_clubrank.SelectedItem).name));
            }

            club_status_1_default = ((MyItem)comboBox_clubset.SelectedItem).data_01;
            club_status_2_default = ((MyItem)comboBox_clubset.SelectedItem).data_02;
            club_status_3_default = ((MyItem)comboBox_clubset.SelectedItem).data_03;
            club_status_4_default = ((MyItem)comboBox_clubset.SelectedItem).data_04;
            club_status_5_default = ((MyItem)comboBox_clubset.SelectedItem).data_05;
            //クラブを手動で変更した時のみ初期値を設定する
            if (loadcancel == 0)
            {
                club_status_1 = club_status_1_default;
                club_status_2 = club_status_2_default;
                club_status_3 = club_status_3_default;
                club_status_4 = club_status_4_default;
                club_status_5 = club_status_5_default;
            }

            this.textBox01_1.Text = Convert.ToString(string.Format("{0}", club_status_1_default));
            this.textBox02_1.Text = Convert.ToString(string.Format("{0}", club_status_2_default));
            this.textBox03_1.Text = Convert.ToString(string.Format("{0}", club_status_3_default));
            this.textBox04_1.Text = Convert.ToString(string.Format("{0}", club_status_4_default));
            this.textBox05_1.Text = Convert.ToString(string.Format("{0}", club_status_5_default));
            //this.textBox01_2.Text = Convert.ToString(string.Format("{0}", club_status_1_default));
            //this.textBox02_2.Text = Convert.ToString(string.Format("{0}", club_status_2_default));
            //this.textBox03_2.Text = Convert.ToString(string.Format("{0}", club_status_3_default));
            //  this.textBox04_2.Text = Convert.ToString(string.Format("{0}", club_status_4_default));
            // this.textBox05_2.Text = Convert.ToString(string.Format("{0}", club_status_5_default));
            return;
        }
        //クラブ改造限界値を設定
        public void clubcustommax()
        {
            try
            {
                //ランクを変更した時、残りのクラブ改造出来る回数

                #region＜エアーナイト・マジックエアーナイトは強制的に０回＞
                //エアーナイト
                if (((MyItem)comboBox_clubset.SelectedItem).ID == "000")
                {
                    club_kaizo_kaisu = 0;
                    clubmax_01 = 6;
                    clubmax_02 = 7;
                    clubmax_03 = 5;
                    clubmax_04 = 3;
                    clubmax_05 = 3;
                }
                //マジックエアーナイト
                else if (((MyItem)comboBox_clubset.SelectedItem).ID == "001")
                {
                    club_kaizo_kaisu = 0;
                    clubmax_01 = 0;
                    clubmax_02 = 11;
                    clubmax_03 = 7;
                    clubmax_04 = 2;
                    clubmax_05 = 2;
                }
                #endregion
                #region＜変化クラブのデータ＞
                //デュアルマナピカルクラブセット/ギガヤーズトーテムポールクラブセット/ウイングトロスエボートナイトクラブセット
                else if (((MyItem)comboBox_clubset.SelectedItem).ID == "098" || ((MyItem)comboBox_clubset.SelectedItem).ID == "099" || ((MyItem)comboBox_clubset.SelectedItem).ID == "100")
                //else if (comboBox_clubset.SelectedIndex > 97)
                {
                    //クラブタイプ実装
                    club_kaizo_kaisu = ((MyItem_clubrank)comboBox_clubrank.SelectedItem).IDc - clubset_total;
                    //C
                    if (((MyItem_clubrank)comboBox_clubrank.SelectedItem).IDc < 40)
                    {
                        clubmax_01 = 19;
                        clubmax_02 = 13;
                        clubmax_03 = 15;
                        clubmax_04 = 7;
                        clubmax_05 = 7;
                    }
                    //C
                    else if (((MyItem_clubrank)comboBox_clubrank.SelectedItem).IDc < 45)
                    {
                        clubmax_01 = 21;
                        clubmax_02 = 13;
                        clubmax_03 = 17;
                        clubmax_04 = 8;
                        clubmax_05 = 8;
                    }
                    //B
                    else if (((MyItem_clubrank)comboBox_clubrank.SelectedItem).IDc < 55)
                    {
                        clubmax_01 = 22;
                        clubmax_02 = 14;
                        clubmax_03 = 18;
                        clubmax_04 = 9;
                        clubmax_05 = 9;
                    }
                    //S・A
                    else if (((MyItem_clubrank)comboBox_clubrank.SelectedItem).IDc < 58)
                    {
                        if (((MyItem)comboBox_clubset.SelectedItem).ID == "098")
                        {
                            type_01 = 1;
                        }
                        else if (((MyItem)comboBox_clubset.SelectedItem).ID == "099")
                        {
                            type_04 = 1;
                        }
                        else if (((MyItem)comboBox_clubset.SelectedItem).ID == "100")
                        {
                            type_02 = 1;
                        }
                        clubmax_01 = 22 + type_01;
                        clubmax_02 = 14 + type_02;
                        clubmax_03 = 18;
                        clubmax_04 = 9 + type_04;
                        clubmax_05 = 9;
                    }
                }
                #endregion
                #region＜通常のクラブのデータ＞
                else
                {
                    //クラブタイプ実装
                    club_kaizo_kaisu = ((MyItem_clubrank)comboBox_clubrank.SelectedItem).IDc - clubset_total;
                    if (((MyItem)comboBox_clubset.SelectedItem).name.EndsWith("p"))//最初の１文字のときはStartsWith
                    {
                        type_01 = 1;
                    }
                    if (((MyItem)comboBox_clubset.SelectedItem).name.EndsWith("c"))
                    {
                        type_02 = 1;
                    }
                    if (((MyItem)comboBox_clubset.SelectedItem).name.EndsWith("s"))
                    {
                        type_04 = 1;
                    }
                    if (((MyItem)comboBox_clubset.SelectedItem).name.EndsWith("b"))
                    {
                        type_01 = 1;
                        type_02 = 1;
                        type_04 = 1;
                    }
                    //E
                    if (((MyItem_clubrank)comboBox_clubrank.SelectedItem).IDc < 35)
                    {
                        clubmax_01 = 14;
                        clubmax_02 = 12;
                        clubmax_03 = 12;
                        clubmax_04 = 5;
                        clubmax_05 = 5;
                    }
                    //D
                    if (((MyItem_clubrank)comboBox_clubrank.SelectedItem).IDc < 40)
                    {
                        clubmax_01 = 15 + type_01;
                        clubmax_02 = 12;
                        clubmax_03 = 13;
                        clubmax_04 = 6;
                        clubmax_05 = 6;
                    }
                    //C
                    else if (((MyItem_clubrank)comboBox_clubrank.SelectedItem).IDc < 45)
                    {
                        clubmax_01 = 16 + type_01;
                        clubmax_02 = 12;
                        clubmax_03 = 14;
                        clubmax_04 = 6 + type_04;
                        clubmax_05 = 6;
                    }
                    //B
                    else if (((MyItem_clubrank)comboBox_clubrank.SelectedItem).IDc < 50)
                    {
                        clubmax_01 = 18 + type_01;
                        clubmax_02 = 13;
                        clubmax_03 = 15;
                        clubmax_04 = 7 + type_04;
                        clubmax_05 = 7;
                    }
                    //A
                    else if (((MyItem_clubrank)comboBox_clubrank.SelectedItem).IDc < 55)
                    {
                        clubmax_01 = 20;
                        clubmax_02 = 13;
                        clubmax_03 = 16;
                        clubmax_04 = 8;
                        clubmax_05 = 8;
                    }
                    //S
                    else if (((MyItem_clubrank)comboBox_clubrank.SelectedItem).IDc < 57)
                    {
                        clubmax_01 = 20 + type_01;
                        clubmax_02 = 13 + type_02;
                        clubmax_03 = 16;
                        clubmax_04 = 8 + type_04;
                        clubmax_05 = 8;
                    }
                }
                #endregion
                //終わったらtype値を元に戻す
                type_01 = 0;
                type_02 = 0;
                type_04 = 0;

                this.textBox01_3.Text = Convert.ToString(string.Format("{0}", clubmax_01));
                this.textBox02_3.Text = Convert.ToString(string.Format("{0}", clubmax_02));
                this.textBox03_3.Text = Convert.ToString(string.Format("{0}", clubmax_03));
                this.textBox04_3.Text = Convert.ToString(string.Format("{0}", clubmax_04));
                this.textBox05_3.Text = Convert.ToString(string.Format("{0}", clubmax_05));
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

            return;
        }
        //クラブ改造
        public void clubcustom()
        {
            try
            {
                //例外設定；
                //1.クラブ改造残り回数が0回なのに＋を押した
                //2.クラブ改造残り回数がmaxなのに－を押した(これは3.で発見できるので無くていい)
                //3.－を押してステータスが最低ステータスを割った
                //4.＋を押してステータスが最高ステータスを超えた

                club_kaizo_kaisu = club_kaizo_kaisu - club_kaizo_pm;
                //例外1
                if (club_kaizo_kaisu < 0)
                {
                    //のこり0回だ、ばか
                    club_kaizo_kaisu = 0;
                    club_kaizo_pm = 0;
                    club_button_1 = 0;
                    club_button_2 = 0;
                    club_button_3 = 0;
                    club_button_4 = 0;
                    club_button_5 = 0;
                    return;
                }
                club_status_1 = club_status_1 + club_button_1;
                club_status_2 = club_status_2 + club_button_2;
                club_status_3 = club_status_3 + club_button_3;
                club_status_4 = club_status_4 + club_button_4;
                club_status_5 = club_status_5 + club_button_5;

                //例外3.4　例外起きた時は数値を元に戻したあとで終了
                if ((club_status_1 < club_status_1_default) || (clubmax_01 < club_status_1))
                {
                    club_kaizo_kaisu = club_kaizo_kaisu + club_kaizo_pm;
                    club_status_1 = club_status_1 - club_button_1;
                    club_button_1 = 0;
                    return;
                }
                if ((club_status_2 < club_status_2_default) || (clubmax_02 < club_status_2))
                {
                    club_kaizo_kaisu = club_kaizo_kaisu + club_kaizo_pm;
                    club_status_2 = club_status_2 - club_button_2;
                    club_button_2 = 0;
                    return;
                }
                if ((club_status_3 < club_status_3_default) || (clubmax_03 < club_status_3))
                {
                    club_kaizo_kaisu = club_kaizo_kaisu + club_kaizo_pm;
                    club_status_3 = club_status_3 - club_button_3;
                    club_button_3 = 0;
                    return;
                }
                if ((club_status_4 < club_status_4_default) || (clubmax_04 < club_status_4))
                {
                    club_kaizo_kaisu = club_kaizo_kaisu + club_kaizo_pm;
                    club_status_4 = club_status_4 - club_button_4;
                    club_button_4 = 0;
                    return;
                }
                if ((club_status_5 < club_status_5_default) || (clubmax_05 < club_status_5))
                {
                    club_kaizo_kaisu = club_kaizo_kaisu + club_kaizo_pm;
                    club_status_5 = club_status_5 - club_button_5;
                    club_button_5 = 0;
                    return;
                }

                //改造回数を初期値に戻す
                club_kaizo_pm = 0;
                club_button_1 = 0;
                club_button_2 = 0;
                club_button_3 = 0;
                club_button_4 = 0;
                club_button_5 = 0;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            return;
        }

        //メイン計算(クラブセット以外)//////////////////////////////////////////////////////
        public void main()
        {
            if (!bInit) return;
            try
            {
                #region＜ステータス計算＞

                result_main_1 = ((MyItem)comboBox_chara.SelectedItem).data_01 +
                    ((MyItem)comboBox_equip_001.SelectedItem).data_01 +
                    ((MyItem)comboBox_equip_002.SelectedItem).data_01 +
                    ((MyItem)comboBox_equip_003.SelectedItem).data_01 +
                    ((MyItem)comboBox_equip_004.SelectedItem).data_01 +
                    ((MyItem)comboBox_equip_005.SelectedItem).data_01 +
                    ((MyItem)comboBox_equip_006.SelectedItem).data_01 +
                    ((MyItem)comboBox_equip_007.SelectedItem).data_01 +
                    ((MyItem)comboBox_equip_008.SelectedItem).data_01 +
                    ((MyItem)comboBox_equip_009.SelectedItem).data_01 +
                    ((MyItem)comboBox_equip_010.SelectedItem).data_01 +
                    ((MyItem)comboBox_equip_011.SelectedItem).data_01 +
                    ((MyItem)comboBox_equip_012.SelectedItem).data_01 +
                    ((MyItem)comboBox_equip_013.SelectedItem).data_01 +
                    ((MyItem)comboBox_equip_014.SelectedItem).data_01 +
                    ((MyItem)comboBox_nochara1.SelectedItem).data_01 +
                    ((MyItem)comboBox_nochara2.SelectedItem).data_01 +
                    ((MyItem)comboBox_nochara3.SelectedItem).data_01 +
                    ((MyItem)comboBox_nochara4.SelectedItem).data_01 +
                    ((MyItem)comboBox_nochara5.SelectedItem).data_01 +
                    ((MyItem)comboBox_card_npc1.SelectedItem).data_01 +
                    ((MyItem)comboBox_card_npc2.SelectedItem).data_01 +
                    ((MyItem)comboBox_card_caddy1.SelectedItem).data_01 +
                    ((MyItem)comboBox_card_caddy2.SelectedItem).data_01 +
                    ((MyItem)comboBox_card_caddy3.SelectedItem).data_01 +
                    ((MyItem)comboBox_card_caddy4.SelectedItem).data_01 +
                    ((MyItem)comboBox_card_chara1.SelectedItem).data_01 +
                    ((MyItem)comboBox_card_chara2.SelectedItem).data_01 +
                    ((MyItem)comboBox_card_chara3.SelectedItem).data_01 +
                    ((MyItem)comboBox_card_chara4.SelectedItem).data_01 +
                    ((MyItem)comboBox_addslot.SelectedItem).data_01;

                result_main_2 = ((MyItem)comboBox_chara.SelectedItem).data_02 +
                    ((MyItem)comboBox_equip_001.SelectedItem).data_02 + ((MyItem)comboBox_equip_002.SelectedItem).data_02 + ((MyItem)comboBox_equip_003.SelectedItem).data_02 + ((MyItem)comboBox_equip_004.SelectedItem).data_02 + ((MyItem)comboBox_equip_005.SelectedItem).data_02 + ((MyItem)comboBox_equip_006.SelectedItem).data_02 + ((MyItem)comboBox_equip_007.SelectedItem).data_02 + ((MyItem)comboBox_equip_008.SelectedItem).data_02 + ((MyItem)comboBox_equip_009.SelectedItem).data_02 + ((MyItem)comboBox_equip_010.SelectedItem).data_02 + ((MyItem)comboBox_equip_011.SelectedItem).data_02 + ((MyItem)comboBox_equip_012.SelectedItem).data_02 + ((MyItem)comboBox_equip_013.SelectedItem).data_02 + ((MyItem)comboBox_equip_014.SelectedItem).data_02 +
                    ((MyItem)comboBox_nochara1.SelectedItem).data_02 + ((MyItem)comboBox_nochara2.SelectedItem).data_02 + ((MyItem)comboBox_nochara3.SelectedItem).data_02 + ((MyItem)comboBox_nochara4.SelectedItem).data_02 + ((MyItem)comboBox_nochara5.SelectedItem).data_02 +
                    ((MyItem)comboBox_card_npc1.SelectedItem).data_02 + ((MyItem)comboBox_card_npc2.SelectedItem).data_02 +
                    ((MyItem)comboBox_card_caddy1.SelectedItem).data_02 + ((MyItem)comboBox_card_caddy2.SelectedItem).data_02 + ((MyItem)comboBox_card_caddy3.SelectedItem).data_02 + ((MyItem)comboBox_card_caddy4.SelectedItem).data_02 +
                    ((MyItem)comboBox_card_chara1.SelectedItem).data_02 + ((MyItem)comboBox_card_chara2.SelectedItem).data_02 + ((MyItem)comboBox_card_chara3.SelectedItem).data_02 + ((MyItem)comboBox_card_chara4.SelectedItem).data_02 +
                    ((MyItem)comboBox_addslot.SelectedItem).data_02;

                result_main_3 = ((MyItem)comboBox_chara.SelectedItem).data_03 +
                    ((MyItem)comboBox_equip_001.SelectedItem).data_03 + ((MyItem)comboBox_equip_002.SelectedItem).data_03 + ((MyItem)comboBox_equip_003.SelectedItem).data_03 + ((MyItem)comboBox_equip_004.SelectedItem).data_03 + ((MyItem)comboBox_equip_005.SelectedItem).data_03 + ((MyItem)comboBox_equip_006.SelectedItem).data_03 + ((MyItem)comboBox_equip_007.SelectedItem).data_03 + ((MyItem)comboBox_equip_008.SelectedItem).data_03 + ((MyItem)comboBox_equip_009.SelectedItem).data_03 + ((MyItem)comboBox_equip_010.SelectedItem).data_03 + ((MyItem)comboBox_equip_011.SelectedItem).data_03 + ((MyItem)comboBox_equip_012.SelectedItem).data_03 + ((MyItem)comboBox_equip_013.SelectedItem).data_03 + ((MyItem)comboBox_equip_014.SelectedItem).data_03 +
                    ((MyItem)comboBox_nochara1.SelectedItem).data_03 + ((MyItem)comboBox_nochara2.SelectedItem).data_03 + ((MyItem)comboBox_nochara3.SelectedItem).data_03 + ((MyItem)comboBox_nochara4.SelectedItem).data_03 + ((MyItem)comboBox_nochara5.SelectedItem).data_03 +
                    ((MyItem)comboBox_card_npc1.SelectedItem).data_03 + ((MyItem)comboBox_card_npc2.SelectedItem).data_03 +
                    ((MyItem)comboBox_card_caddy1.SelectedItem).data_03 + ((MyItem)comboBox_card_caddy2.SelectedItem).data_03 + ((MyItem)comboBox_card_caddy3.SelectedItem).data_03 + ((MyItem)comboBox_card_caddy4.SelectedItem).data_03 +
                    ((MyItem)comboBox_card_chara1.SelectedItem).data_03 + ((MyItem)comboBox_card_chara2.SelectedItem).data_03 + ((MyItem)comboBox_card_chara3.SelectedItem).data_03 + ((MyItem)comboBox_card_chara4.SelectedItem).data_03 +
                    ((MyItem)comboBox_addslot.SelectedItem).data_03;

                result_main_4 = ((MyItem)comboBox_chara.SelectedItem).data_04 +
                    ((MyItem)comboBox_equip_001.SelectedItem).data_04 + ((MyItem)comboBox_equip_002.SelectedItem).data_04 + ((MyItem)comboBox_equip_003.SelectedItem).data_04 + ((MyItem)comboBox_equip_004.SelectedItem).data_04 + ((MyItem)comboBox_equip_005.SelectedItem).data_04 + ((MyItem)comboBox_equip_006.SelectedItem).data_04 + ((MyItem)comboBox_equip_007.SelectedItem).data_04 + ((MyItem)comboBox_equip_008.SelectedItem).data_04 + ((MyItem)comboBox_equip_009.SelectedItem).data_04 + ((MyItem)comboBox_equip_010.SelectedItem).data_04 + ((MyItem)comboBox_equip_011.SelectedItem).data_04 + ((MyItem)comboBox_equip_012.SelectedItem).data_04 + ((MyItem)comboBox_equip_013.SelectedItem).data_04 + ((MyItem)comboBox_equip_014.SelectedItem).data_04 +
                    ((MyItem)comboBox_nochara1.SelectedItem).data_04 + ((MyItem)comboBox_nochara2.SelectedItem).data_04 + ((MyItem)comboBox_nochara3.SelectedItem).data_04 + ((MyItem)comboBox_nochara4.SelectedItem).data_04 + ((MyItem)comboBox_nochara5.SelectedItem).data_04 +
                    ((MyItem)comboBox_card_npc1.SelectedItem).data_04 + ((MyItem)comboBox_card_npc2.SelectedItem).data_04 +
                    ((MyItem)comboBox_card_caddy1.SelectedItem).data_04 + ((MyItem)comboBox_card_caddy2.SelectedItem).data_04 + ((MyItem)comboBox_card_caddy3.SelectedItem).data_04 + ((MyItem)comboBox_card_caddy4.SelectedItem).data_04 +
                    ((MyItem)comboBox_card_chara1.SelectedItem).data_04 + ((MyItem)comboBox_card_chara2.SelectedItem).data_04 + ((MyItem)comboBox_card_chara3.SelectedItem).data_04 + ((MyItem)comboBox_card_chara4.SelectedItem).data_04 +
                    ((MyItem)comboBox_addslot.SelectedItem).data_04;

                result_main_5 = ((MyItem)comboBox_chara.SelectedItem).data_05 +
                    ((MyItem)comboBox_equip_001.SelectedItem).data_05 + ((MyItem)comboBox_equip_002.SelectedItem).data_05 + ((MyItem)comboBox_equip_003.SelectedItem).data_05 + ((MyItem)comboBox_equip_004.SelectedItem).data_05 + ((MyItem)comboBox_equip_005.SelectedItem).data_05 + ((MyItem)comboBox_equip_006.SelectedItem).data_05 + ((MyItem)comboBox_equip_007.SelectedItem).data_05 + ((MyItem)comboBox_equip_008.SelectedItem).data_05 + ((MyItem)comboBox_equip_009.SelectedItem).data_05 + ((MyItem)comboBox_equip_010.SelectedItem).data_05 + ((MyItem)comboBox_equip_011.SelectedItem).data_05 + ((MyItem)comboBox_equip_012.SelectedItem).data_05 + ((MyItem)comboBox_equip_013.SelectedItem).data_05 + ((MyItem)comboBox_equip_014.SelectedItem).data_05 +
                    ((MyItem)comboBox_nochara1.SelectedItem).data_05 + ((MyItem)comboBox_nochara2.SelectedItem).data_05 + ((MyItem)comboBox_nochara3.SelectedItem).data_05 + ((MyItem)comboBox_nochara4.SelectedItem).data_05 + ((MyItem)comboBox_nochara5.SelectedItem).data_05 +
                    ((MyItem)comboBox_card_npc1.SelectedItem).data_05 + ((MyItem)comboBox_card_npc2.SelectedItem).data_05 +
                    ((MyItem)comboBox_card_caddy1.SelectedItem).data_05 + ((MyItem)comboBox_card_caddy2.SelectedItem).data_05 + ((MyItem)comboBox_card_caddy3.SelectedItem).data_05 + ((MyItem)comboBox_card_caddy4.SelectedItem).data_05 +
                    ((MyItem)comboBox_card_chara1.SelectedItem).data_05 + ((MyItem)comboBox_card_chara2.SelectedItem).data_05 + ((MyItem)comboBox_card_chara3.SelectedItem).data_05 + ((MyItem)comboBox_card_chara4.SelectedItem).data_05 +
                    ((MyItem)comboBox_addslot.SelectedItem).data_05;

                #endregion
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            this.result();
            return;
        }
        //最終結果
        public void result()
        {
            specialup[3] = pipi_kekka;

            status_1 = result_club_1 + result_main_1;
            status_2 = result_club_2 + result_main_2;
            status_3 = result_club_3 + result_main_3;
            status_4 = result_club_4 + result_main_4;
            status_5 = result_club_5 + result_main_5;

            result_pow_1 = status_1 - downgread_1 + rank_power;
            result_con_2 = status_2 - downgread_2;
            result_sei_3 = status_3 - downgread_3;
            result_spi_4 = status_4 - downgread_4;
            result_cur_5 = status_5 - downgread_5;
            result_1wmax_6 = 200 + result_pow_1 * 2 + specialup[0] + specialup[1] + specialup[2] + specialup[3] + specialup[4] + specialup[5] + specialup[6] + specialup[7] + specialup[8];
            result_1wp_7 = result_1wmax_6 + 10 + roro_kekka;
            result_1wDp_8 = result_1wp_7 + 10;


            rank_penalty = result_pow_1 - 20 - rank;

            if (rank_penalty < 0)
            {
                rank_penalty_see = 0;
            }
            else
            {
                rank_penalty_see = rank_penalty;
            }

            this.label_pow.Text = Convert.ToString(string.Format("{0}", result_pow_1));
            this.label_con.Text = Convert.ToString(string.Format("{0} (-{1})", result_con_2, rank_penalty_see));
            this.label_sei.Text = Convert.ToString(string.Format("{0} (-{1})", result_sei_3, rank_penalty_see));
            this.label_spi.Text = Convert.ToString(string.Format("{0}", result_spi_4));
            this.label_cur.Text = Convert.ToString(string.Format("{0}", result_cur_5));
            this.label_1wmax.Text = Convert.ToString(string.Format("{0}", result_1wmax_6));
            this.label_1wp.Text = Convert.ToString(string.Format("{0}/{1}", result_1wp_7, result_1wDp_8));
            //特殊装備のコメント
            int low = 0;
            for (int i = 0; i < 23; i++)
            {
                //result_special_9 = result_special_9 /*+ Environment.NewLine + */ + specialequip[i] ;
                if (specialequip[i] != "")
                {
                    low++;
                    if (low == 1)
                    {
                        result_special_9 = specialequip[i];
                    }
                    else if (low < 12)
                    {
                        result_special_9 = result_special_9 + "\r\n" + specialequip[i];
                    }
                    if (low == 12)
                    {
                        result_special_10 = specialequip[i];
                    }
                    else if (low > 11)
                    {
                        result_special_10 = result_special_10 + "\r\n" + specialequip[i];
                    }
                }
            }
            this.label_specialitem.Text = result_special_9;
            this.label_specialitem2.Text = result_special_10;
            //特殊装備のコメントを元に戻す
            result_special_9 = "";
            result_special_10 = "";

            #region<パンヤゾーン計算・描画>

            int pangyazone_num = 0;
            for (int i = 0; i < 12; i++)
            {
                //0耳1背中2(手袋)3マガベニ4(マスコット)5時間限定カード6ティタン7カディエ8リングセット系9直接入力
                pangyazone_num = pangyazone_num + pangyazone[i];
            }
            this.label_zone.Text = Convert.ToString(string.Format("4＋{0}dot", pangyazone_num));
            ////////
            //描画先とするImageオブジェクトを作成する
            Bitmap canvas = new Bitmap(pictureBox_Zone.Width, pictureBox_Zone.Height);
            //ImageオブジェクトのGraphicsオブジェクトを作成する
            Graphics r0 = Graphics.FromImage(canvas);
            Graphics r1 = Graphics.FromImage(canvas);
            Graphics r2 = Graphics.FromImage(canvas);
            Graphics r3 = Graphics.FromImage(canvas);
            Graphics r4 = Graphics.FromImage(canvas);
            Graphics r5 = Graphics.FromImage(canvas);
            Graphics r6 = Graphics.FromImage(canvas);
            Graphics g = Graphics.FromImage(canvas);
            Graphics h = Graphics.FromImage(canvas);
            //レイヤー0～6
            r0.FillRectangle(Brushes.White, 0, 0, 75, 16);//白色線1 
            r1.FillRectangle(Brushes.DarkSlateGray, 8, 5, 39, 8);//背景濃青(左)
            r2.FillRectangle(Brushes.SteelBlue, 41, 5, 36, 8);//背景濃空青(右)
            r3.FillRectangle(Brushes.Silver, 8, 3, 67, 1);//灰色線
            r4.FillRectangle(Brushes.Black, 8, 4, 67, 1);//黒線
            r5.FillRectangle(Brushes.Black, 0, 0, 8, 16);//黒縁(パンヤバー
            r6.FillRectangle(Brushes.Silver, 1, 1, 6, 14);//灰色中(パンヤバー
            //正確度をまず先に描画する。
            int sei = result_sei_3 - rank_penalty_see;
            if (sei < 0)
            {
                //正確度マイナスは無い
                sei = 0;
            }
            //ピンクゾーンの幅＝元のパンヤゲージ(4dot)+増加パンヤゲージの大きさ＋(8+正確度)。※開始位置は、パンヤゾーンが中央に来るようにズレる。
            g.FillRectangle(Brushes.Magenta, 40 - (pangyazone_num + 12 + sei +1)/2, 5, (pangyazone_num + 12 + sei), 8);
            //パンヤゾーン
            h.FillRectangle(Brushes.White, 38 - (pangyazone_num + 1)/2, 4, (pangyazone_num + 4), 9);//ゾーンは左、右、左、右と増えるので+1している

            //Graphicsオブジェクトのリソースを解放する
            r0.Dispose();
            r1.Dispose();
            r2.Dispose();
            r3.Dispose();
            r4.Dispose();
            r5.Dispose();
            r6.Dispose();
            g.Dispose();
            h.Dispose();
            //PictureBox1に表示する
            pictureBox_Zone.Image = canvas;

            #endregion

            return;//これですべて終わり
        }
        //アラート//////////////////////////////////////////////////////////////////////////

        //同じキャディカードを複数つけた時、１枚分の性能しか表示しない　＋　"*"マークで警告する
        public void check_cardkaburi()
        {
            if (!bInit) return;
            try
            {
                roro_kekka = 0;
                pipi_kekka = 0;
                this.label_card_caddy1.Text = "";
                this.label_card_caddy2.Text = "";
                this.label_card_caddy3.Text = "";
                this.label_card_caddy4.Text = "";

                //カブリチェック計算用
                int kaburinasi = 0;
                int[] checkcardcaddy_roro = new int[7];
                int[] checkcardcaddy_pipi = new int[7];
                int[] checkcardcaddy_palam = new int[7];

                //まずかぶりのチェックだけ(case1,2以外も含めて)先にやる///////////////////////////////
                #region＜かぶりチェック＞
                for (int i = 0; i < 11; i++)
                {
                    if (check_card_caddy1 == i)
                    {
                        if ((check_card_caddy2 != i) && (check_card_caddy3 != i) && (check_card_caddy4 != i))//かぶりなし
                        {
                            kaburinasi++;
                        }
                        else//かぶりあり
                        {
                            this.label_card_caddy1.Text = "*";
                                if (check_card_caddy1 == check_card_caddy2)//1=2
                                {
                                    this.label_card_caddy2.Text = "*";
                                    if (check_card_caddy1 == 1)
                                    {
                                        checkcardcaddy_roro[1] = 1;
                                    }
                                    if (check_card_caddy1 == 2)
                                    {
                                        checkcardcaddy_pipi[1] = 1;
                                    }
                                    checkcardcaddy_palam[1] = 1;
                                }
                                if (check_card_caddy1 == check_card_caddy3)//1=3
                                {
                                    this.label_card_caddy3.Text = "*";
                                    if (check_card_caddy1 == 1)
                                    {
                                        checkcardcaddy_roro[2] = 1;
                                    }
                                    if (check_card_caddy1 == 2)
                                    {
                                        checkcardcaddy_pipi[2] = 1;
                                    }
                                    checkcardcaddy_palam[2] = 1;
                                }
                                if (check_card_caddy1 == check_card_caddy4)//1=4
                                {
                                    this.label_card_caddy4.Text = "*";
                                    if (check_card_caddy1 == 1)
                                    {
                                        checkcardcaddy_roro[3] = 1;
                                    }
                                    if (check_card_caddy1 == 2)
                                    {
                                        checkcardcaddy_pipi[3] = 1;
                                    }
                                    checkcardcaddy_palam[3] = 1;
                                }
                        }
                    }
                    if (check_card_caddy2 == i)
                    {
                        if ((check_card_caddy3 != i) && (check_card_caddy4 != i))//かぶりなし
                        {
                            kaburinasi++;
                        }
                        else//かぶりあり
                        {
                            this.label_card_caddy2.Text = "*";
                                
                                if (check_card_caddy2 == check_card_caddy3)//2=3
                                {
                                    this.label_card_caddy3.Text = "*";
                                    if (check_card_caddy1 == 1)
                                    {
                                        checkcardcaddy_roro[4] = 1;
                                    }
                                    if (check_card_caddy1 == 2)
                                    {
                                        checkcardcaddy_pipi[4] = 1;
                                    }
                                    checkcardcaddy_palam[4] = 1;
                                }
                                if (check_card_caddy2 == check_card_caddy4)//2=4
                                {
                                    this.label_card_caddy4.Text = "*";
                                    if (check_card_caddy1 == 1)
                                    {
                                        checkcardcaddy_roro[5] = 1;
                                    }
                                    if (check_card_caddy1 == 2)
                                    {
                                        checkcardcaddy_pipi[5] = 1;
                                    }
                                    checkcardcaddy_palam[5] = 1;
                                }
                        }
                    }
                    if (check_card_caddy3 == i)
                    {
                        if (check_card_caddy3 == check_card_caddy4)//かぶりあり3=4
                        {
                            this.label_card_caddy3.Text = "*";
                            this.label_card_caddy4.Text = "*";
                                if (check_card_caddy1 == 1)
                                {
                                    checkcardcaddy_roro[6] = 1;
                                }
                                if (check_card_caddy1 == 2)
                                {
                                    checkcardcaddy_pipi[6] = 1;
                                }
                                checkcardcaddy_palam[6] = 1;
                        }
                        else//かぶりなし
                        {
                            kaburinasi++;
                        }
                    }
                }
                #endregion

                #region＜初期値＞
                specialequip[13] = ((MyItem)comboBox_card_caddy1.SelectedItem).name;
                specialequip[14] = ((MyItem)comboBox_card_caddy2.SelectedItem).name;
                specialequip[15] = ((MyItem)comboBox_card_caddy3.SelectedItem).name;
                specialequip[16] = ((MyItem)comboBox_card_caddy4.SelectedItem).name;
                powerup[1] = comboBox_card_caddy1.SelectedIndex * 2;
                powerup[2] = comboBox_card_caddy2.SelectedIndex * 2;
                powerup[3] = comboBox_card_caddy3.SelectedIndex * 2;
                powerup[4] = comboBox_card_caddy4.SelectedIndex * 2;
                for (int i = 1; i < 5; i++)
                {
                    if (powerup[i] > 8)
                    {
                        powerup[i] = 0;
                    }
                }
                specialup_caddy[1] = comboBox_card_caddy1.SelectedIndex - 4;
                specialup_caddy[2] = comboBox_card_caddy2.SelectedIndex - 4;
                specialup_caddy[3] = comboBox_card_caddy3.SelectedIndex - 4;
                specialup_caddy[4] = comboBox_card_caddy4.SelectedIndex - 4;
                for (int i = 1; i < 5; i++)
                {
                    if (specialup_caddy[i] < 0 || 4 < specialup_caddy[i])
                    {
                        specialup_caddy[i] = 0;
                    }
                }
                #endregion
                #region＜かぶり回数から０のぶんを引く＞
                if ((check_card_caddy1 == 0) && (check_card_caddy2 == 0) && (check_card_caddy3 == 0))
                {
                    kaburinasi = kaburinasi + 3;
                }
                else if ((check_card_caddy1 == 0) && (check_card_caddy2 == 0) && (check_card_caddy4 == 0))
                {
                    kaburinasi = kaburinasi + 3;
                }
                else if ((check_card_caddy1 == 0) && (check_card_caddy3 == 0) && (check_card_caddy4 == 0))
                {
                    kaburinasi = kaburinasi + 3;
                }
                else if ((check_card_caddy2 == 0) && (check_card_caddy3 == 0) && (check_card_caddy4 == 0))
                {
                    kaburinasi = kaburinasi + 3;
                }
                else if ((check_card_caddy1 == 0) && (check_card_caddy2 == 0))
                {
                    kaburinasi = kaburinasi + 2;
                }
                else if ((check_card_caddy1 == 0) && (check_card_caddy3 == 0))
                {
                    kaburinasi = kaburinasi + 2;
                }
                else if ((check_card_caddy1 == 0) && (check_card_caddy4 == 0))
                {
                    kaburinasi = kaburinasi + 2;
                }
                else if ((check_card_caddy2 == 0) && (check_card_caddy3 == 0))
                {
                    kaburinasi = kaburinasi + 2;
                }
                else if ((check_card_caddy2 == 0) && (check_card_caddy4 == 0))
                {
                    kaburinasi = kaburinasi + 2;
                }
                else if ((check_card_caddy3 == 0) && (check_card_caddy4 == 0))
                {
                    kaburinasi = kaburinasi + 2;
                }
                else if ((check_card_caddy3 == 0) && (check_card_caddy4 == 0))
                {
                    kaburinasi = kaburinasi + 2;
                }
                else if ((check_card_caddy1 == 0) || (check_card_caddy2 == 0) || (check_card_caddy3 == 0) || (check_card_caddy4 == 0))
                {
                    kaburinasi++;
                }
                #endregion
                //かぶりなしの時の値
                if (kaburinasi > 3)
                {
                    for (int i = 1; i < 5; i++)
                    {
                        roro_kekka = roro_kekka + powerup[i];
                        pipi_kekka = pipi_kekka + specialup_caddy[i];
                    }
                }
                else
                {
                    for (int i = 1; i < 5; i++)
                    {
                        roro_kekka = roro_kekka + powerup[i];
                        pipi_kekka = pipi_kekka + specialup_caddy[i];
                    }
                    //かぶりありの時
                    //この順で処理していけば、case1・2以外の時の特殊装備コメントも同時に処理できる/////////////
                    #region＜1=2/1=3/1=4＞
                     //0の時はスキップ
                    if (check_card_caddy1 != 0)
                    {
                        if (checkcardcaddy_palam[1] == 1)//１＝２:case1
                        {

                            //コメント処理は基本、後の番号に
                            specialequip[13] = "";
                            specialequip[14] = ((MyItem)comboBox_card_caddy2.SelectedItem).name;
                            if (checkcardcaddy_roro[1] == 1)
                            {
                                if (powerup[1] > powerup[2])
                                {
                                    specialequip[13] = ((MyItem)comboBox_card_caddy1.SelectedItem).name;
                                    specialequip[14] = "";
                                    roro_kekka = powerup[1];
                                }
                                else
                                {
                                    roro_kekka = powerup[2];
                                }
                            }
                            if (checkcardcaddy_pipi[1] == 1)
                            {
                                if (specialup_caddy[1] > specialup_caddy[2])
                                {
                                    specialequip[13] = ((MyItem)comboBox_card_caddy1.SelectedItem).name;
                                    specialequip[14] = "";
                                    pipi_kekka = specialup_caddy[1];
                                }
                                else
                                {
                                    pipi_kekka = specialup_caddy[2];
                                }
                            }
                        }
                        if (checkcardcaddy_palam[2] == 1)//１＝３:case2
                        {
                            //コメント処理は基本、後の番号に
                            specialequip[13] = "";
                            specialequip[15] = ((MyItem)comboBox_card_caddy3.SelectedItem).name;
                            if (checkcardcaddy_roro[2] == 1)
                            {
                                if (powerup[1] > powerup[3])
                                {
                                    specialequip[13] = ((MyItem)comboBox_card_caddy1.SelectedItem).name;
                                    specialequip[15] = "";
                                    roro_kekka = powerup[1];
                                }
                                else
                                {
                                    roro_kekka = powerup[3];
                                }
                            }
                            if (checkcardcaddy_pipi[2] == 1)
                            {
                                if (specialup_caddy[1] > specialup_caddy[3])
                                {
                                    specialequip[13] = ((MyItem)comboBox_card_caddy1.SelectedItem).name;
                                    specialequip[15] = "";
                                    pipi_kekka = specialup_caddy[1];
                                }
                                else
                                {
                                    pipi_kekka = specialup_caddy[3];
                                }
                            }
                        }
                        if (checkcardcaddy_palam[3] == 1)//１＝４:case3
                        {
                            //コメント処理は基本、後の番号に
                            specialequip[13] = "";
                            specialequip[16] = ((MyItem)comboBox_card_caddy4.SelectedItem).name;

                            if (checkcardcaddy_roro[3] == 1)
                            {
                                if (powerup[1] > powerup[4])
                                {
                                    specialequip[13] = ((MyItem)comboBox_card_caddy1.SelectedItem).name;
                                    specialequip[16] = "";
                                    roro_kekka = powerup[1];
                                }
                                else
                                {
                                    roro_kekka = powerup[4];
                                }
                            }
                            if (checkcardcaddy_pipi[3] == 1)
                            {
                                if (specialup_caddy[1] > specialup_caddy[4])
                                {
                                    specialequip[13] = ((MyItem)comboBox_card_caddy1.SelectedItem).name;
                                    specialequip[16] = "";
                                    pipi_kekka = specialup_caddy[1];
                                }
                                else
                                {
                                    pipi_kekka = specialup_caddy[4];
                                }
                            }
                        }
                    }
                    #endregion
                    #region＜2=3/2=4/3=4＞
                    if (check_card_caddy2 != 0)
                    {
                        if (checkcardcaddy_palam[4] == 1)//２＝３:case4
                        {
                            //コメント処理は基本、後の番号に
                            specialequip[14] = "";
                            specialequip[15] = ((MyItem)comboBox_card_caddy3.SelectedItem).name;
                            if (checkcardcaddy_roro[4] == 1)
                            {
                                if (powerup[2] > powerup[3])
                                {
                                    specialequip[14] = ((MyItem)comboBox_card_caddy2.SelectedItem).name;
                                    specialequip[15] = "";
                                    roro_kekka = powerup[2];
                                }
                                else
                                {
                                    roro_kekka = powerup[3];
                                }
                            }
                            if (checkcardcaddy_pipi[4] == 1)
                            {
                                if (specialup_caddy[2] > specialup_caddy[3])
                                {
                                    specialequip[14] = ((MyItem)comboBox_card_caddy2.SelectedItem).name;
                                    specialequip[15] = "";
                                    pipi_kekka = specialup_caddy[2];
                                }
                                else
                                {
                                    pipi_kekka = specialup_caddy[3];
                                }
                            }
                        }
                        if (checkcardcaddy_palam[5] == 1)//２＝４:case5
                        {
                            //コメント処理は基本、後の番号に
                            specialequip[14] = "";
                            specialequip[16] = ((MyItem)comboBox_card_caddy3.SelectedItem).name;
                            if (checkcardcaddy_roro[5] == 1)
                            {
                                if (powerup[2] > powerup[4])
                                {
                                    specialequip[14] = ((MyItem)comboBox_card_caddy2.SelectedItem).name;
                                    specialequip[16] = "";
                                    roro_kekka = powerup[2];
                                }
                                else
                                {
                                    roro_kekka = powerup[4];
                                }
                            }
                            if (checkcardcaddy_pipi[5] == 1)
                            {
                                if (specialup_caddy[2] > specialup_caddy[4])
                                {
                                    specialequip[14] = ((MyItem)comboBox_card_caddy2.SelectedItem).name;
                                    specialequip[16] = "";
                                    pipi_kekka = specialup_caddy[2];
                                }
                                else
                                {
                                    pipi_kekka = specialup_caddy[4];
                                }
                            }
                        }
                    }
                    if (check_card_caddy3 != 0)
                    {
                        if (checkcardcaddy_palam[6] == 1)//３＝４
                        {
                            //コメント処理は基本、後の番号に
                            specialequip[15] = "";
                            specialequip[16] = ((MyItem)comboBox_card_caddy3.SelectedItem).name;
                            if (checkcardcaddy_roro[6] == 1)
                            {
                                if (powerup[3] > powerup[4])
                                {
                                    specialequip[15] = ((MyItem)comboBox_card_caddy3.SelectedItem).name;
                                    specialequip[16] = "";
                                    roro_kekka = powerup[3];
                                }
                                else
                                {
                                    roro_kekka = powerup[4];
                                }
                            }
                            if (checkcardcaddy_pipi[6] == 1)
                            {
                                if (specialup_caddy[3] > specialup_caddy[4])
                                {
                                    specialequip[15] = ((MyItem)comboBox_card_caddy3.SelectedItem).name;
                                    specialequip[16] = "";
                                    pipi_kekka = specialup_caddy[3];
                                }
                                else
                                {
                                    pipi_kekka = specialup_caddy[4];
                                }
                            }
                        }
                    }
                    #endregion
                }
                #region＜null値を戻す＞
                //データなしの時は、文字を表示しないようにする　＆　*表示しないようにする
                if (specialequip[13] == "(なし)")
                {
                    specialequip[13] = "";
                    this.label_card_caddy1.Text = "";
                }
                if (specialequip[13] == "")
                {
                    this.label_card_caddy1.Text = "";
                }
                if (specialequip[14] == "(なし)")
                {
                    specialequip[14] = "";
                    this.label_card_caddy2.Text = "";
                }
                if (specialequip[14] == "")
                {
                    this.label_card_caddy2.Text = "";
                }
                if (specialequip[15] == "(なし)")
                {
                    specialequip[15] = "";
                    this.label_card_caddy3.Text = "";
                }
                if (specialequip[15] == "")
                {
                    this.label_card_caddy3.Text = "";
                }
                if (specialequip[16] == "(なし)")
                {
                    specialequip[16] = "";
                    this.label_card_caddy4.Text = "";
                }
                if (specialequip[16] == "")
                {
                    this.label_card_caddy4.Text = "";
                }
                #endregion
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        //ランクを変えた時、ランクによって上げているパワーの最大値の設定と現在値が超えていないかチェック
        public void rankcheck()
        {
            //ランクによって変更できる最大値を変更
            if (rank < numericUpDown1.Value)
            {
                numericUpDown1.Value = rank;
            }
            numericUpDown1.Maximum = rank;
            this.result();
        }
        //ランク以上の拡張スロットを使用していた場合、"*"マークで警告する(選択自体は出来る)
        public void rank_addslot_error()
        {
            this.label_addslot_error.Text = "";
            if (rank < 2)
            {
                if (comboBox_addslot.SelectedIndex > 2)
                {
                    this.label_addslot_error.Text = "*";
                }
            }
            else if (rank < 4)
            {
                if (comboBox_addslot.SelectedIndex > 4)
                {
                    this.label_addslot_error.Text = "*";
                }
            }
            else if (rank < 6)
            {
                if (comboBox_addslot.SelectedIndex > 7)
                {
                    this.label_addslot_error.Text = "*";
                }
            }
            else if (rank < 9)
            {
                if (comboBox_addslot.SelectedIndex == 10)
                {
                    //comboBox_addslot.BackColor = Color.Red;
                    this.label_addslot_error.Text = "*";
                }
            }
            return;
        }
        //ソレンとクラブ経験値の計算////////////////////////////////////////////////////////
        private void button_soren_Click(object sender, EventArgs e)
        {
            //エアーナイト+マジエアの時発動しないように
            if (comboBox_clubset.SelectedIndex > 1)
            {
                //クラブセットの元のランクを換算
                //club_kaizoは34～50までの値(Sは絶対にない)なので、これでいけるはず
                int checker_rank_default = ((club_kaizo - 30) / 5);
                //現在のランクを数値に換算
                int checker_rank = 0;
                //E-A
                if (((MyItem_clubrank)comboBox_clubrank.SelectedItem).IDc < 55)
                {
                    checker_rank = ((((MyItem_clubrank)comboBox_clubrank.SelectedItem).IDc - 30) / 5);
                }
                //S
                else if (((MyItem_clubrank)comboBox_clubrank.SelectedItem).IDc < 58)
                {
                    checker_rank = 5;
                }
                //ランクアップした回数
                int rankup = checker_rank - checker_rank_default;
                int club_soren = 0;
                //ソレンチェック
                if (club_status_3 - club_status_3_default <= rankup)
                {
                    //0：正確度
                    //正確度のup回数＜ランクup回数だったら、それに足りない数だけソレンカード必要
                    club_soren = rankup - (club_status_3 - club_status_3_default);//1：カーブ
                    rankup = club_soren;
                    if (club_status_5 - club_status_5_default <= rankup)
                    {
                        club_soren = club_soren + rankup - (club_status_5 - club_status_5_default);
                        rankup = rankup - (club_status_5 - club_status_5_default);//2：パワー
                        if (club_status_1 - club_status_1_default <= rankup)
                        {
                            club_soren = club_soren + rankup - (club_status_1 - club_status_1_default);
                            rankup = rankup - (club_status_1 - club_status_1_default);//3：スピン
                            if (club_status_4 - club_status_4_default <= rankup)
                            {
                                club_soren = club_soren + rankup - (club_status_4 - club_status_4_default);
                                rankup = rankup - (club_status_4 - club_status_4_default);//4：コント
                                if (club_status_2 - club_status_2_default <= rankup)
                                {
                                    rankup = rankup - (club_status_2 - club_status_2_default);//4：コント
                                    if (rankup != 0)
                                    {
                                        //全部終わってもランクの分＞＋ボタンを押した数　だった場合エラー
                                        this.textBox_soren.Text = "Ｅ";
                                        return;
                                    }
                                }
                            }
                        }
                    }
                }

                //改造回数が残っている場合はその分を引く
                int check_clubkaizokaisu = club_kaizo_kaisu;
                check_clubkaizokaisu = club_kaizo_kaisu - (club_status_2 - club_status_2_default);
                if (check_clubkaizokaisu < 0)
                {
                    club_soren = club_soren - 4 * club_kaizo_kaisu;
                    //
                }
                else
                {
                    club_soren = club_soren - 4 * (club_status_2 - club_status_2_default);
                    check_clubkaizokaisu = check_clubkaizokaisu - (club_status_4 - club_status_4_default);
                    if (check_clubkaizokaisu < 0)
                    {
                        club_soren = club_soren - 3 * (check_clubkaizokaisu + club_status_4 - club_status_4_default);
                    }
                    else
                    {
                        club_soren = club_soren - 3 * (club_status_4 - club_status_4_default);
                        check_clubkaizokaisu = check_clubkaizokaisu - (club_status_1 - club_status_1_default);
                        if (check_clubkaizokaisu < 0)
                        {
                            club_soren = club_soren - 2 * (check_clubkaizokaisu + club_status_1 - club_status_1_default);
                        }
                        else
                        {
                            club_soren = club_soren - 2 * (club_status_1 - club_status_1_default);
                            check_clubkaizokaisu = check_clubkaizokaisu - (club_status_5 - club_status_5_default);
                            if (check_clubkaizokaisu < 0)
                            {
                                club_soren = club_soren - 1 * (check_clubkaizokaisu + club_status_5 - club_status_5_default);
                            }
                            else
                            {
                                club_soren = club_soren - 1 * (club_status_5 - club_status_5_default);
                                check_clubkaizokaisu = check_clubkaizokaisu - (club_status_5 - club_status_5_default);

                                if (check_clubkaizokaisu < 0)
                                {
                                    //
                                }
                            }
                        }
                    }
                }
                if (club_soren < 0)
                {
                    club_soren = 0;
                }

                this.textBox_soren.Text = Convert.ToString(string.Format("{0}", club_soren));

            }
            else
            {
                this.textBox_soren.Text = "";
            }

        }
        private void button_club_Click(object sender, EventArgs e)
        {
            //エアーナイト+マジエアの時発動しないように
            if (comboBox_clubset.SelectedIndex > 1)
            {
                //クラブセットの元のランクを換算
                //club_kaizoは34～50までの値(Sは絶対にない)なので、これでいけるはず
                int checker_rank_default = ((club_kaizo - 30) / 5);
                //現在のランクを数値に換算
                int checker_rank = 0;
                //E-A
                if (((MyItem_clubrank)comboBox_clubrank.SelectedItem).IDc < 55)
                {
                    checker_rank = ((((MyItem_clubrank)comboBox_clubrank.SelectedItem).IDc - 30) / 5);
                }
                //S
                else if (((MyItem_clubrank)comboBox_clubrank.SelectedItem).IDc < 58)
                {
                    checker_rank = 5;
                }

                //経験値を足していく
                int club_exp = 0;
                switch (checker_rank)
                {
                    case 5://A→S
                        if (((MyItem)comboBox_clubset.SelectedItem).name.EndsWith("c"))
                        {
                            club_exp = 75000;
                        }
                        else if (((MyItem)comboBox_clubset.SelectedItem).name.EndsWith("S"))
                        {
                            club_exp = 90000;
                        }
                        else
                        {
                            club_exp = 68000;
                        }
                        checker_rank--;
                        goto case 4;

                    case 4://B→A
                        if (checker_rank == checker_rank_default)
                        {
                            break;
                        }
                        if (((MyItem)comboBox_clubset.SelectedItem).name.EndsWith("c"))
                        {
                            club_exp = club_exp + 32500;
                        }
                        else if (((MyItem)comboBox_clubset.SelectedItem).name.EndsWith("S"))
                        {
                            club_exp = club_exp + 35000;
                        }
                        else
                        {
                            club_exp = club_exp + 20200;
                        }
                        checker_rank--;
                        goto case 3;

                    case 3://C→B
                        if (checker_rank == checker_rank_default)
                        {
                            break;
                        }
                        if (((MyItem)comboBox_clubset.SelectedItem).name.EndsWith("c"))
                        {
                            club_exp = club_exp + 15000;
                        }
                        else if (((MyItem)comboBox_clubset.SelectedItem).name.EndsWith("S"))
                        {
                            club_exp = club_exp + 17600;
                        }
                        else
                        {
                            club_exp = club_exp + 11000;
                        }
                        checker_rank--;
                        goto case 3;

                    case 2://D→C
                        if (checker_rank == checker_rank_default)
                        {
                            break;
                        }
                        if (((MyItem)comboBox_clubset.SelectedItem).name.EndsWith("c"))
                        {
                            club_exp = club_exp + 4800;
                        }
                        else if (((MyItem)comboBox_clubset.SelectedItem).name.EndsWith("S"))
                        {
                            club_exp = club_exp + 4800;
                        }
                        else
                        {
                            club_exp = club_exp + 4800;
                        }
                        checker_rank--;
                        goto case 1;

                    case 1://E→D
                        if (checker_rank == checker_rank_default)
                        {
                            break;
                        }
                        if (((MyItem)comboBox_clubset.SelectedItem).name.EndsWith("c"))
                        {
                            club_exp = club_exp + 900;
                        }
                        else if (((MyItem)comboBox_clubset.SelectedItem).name.EndsWith("S"))
                        {
                            club_exp = club_exp + 900;
                        }
                        else
                        {
                            club_exp = club_exp + 900;
                        }
                        break;
                }
                this.textBox_juku.Text = Convert.ToString(string.Format("{0}", club_exp));
            }
        }
        //入力系////////////////////////////////////////////////////////////////////////////
        #region＜入力系　キャラ＞
        private void comboBox_chara_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (secretcheck == 0)
            {

                if (comboBox_chara.SelectedIndex == 5)//クー
                {
                    Bitmap bmp5 = Properties.Resources.sample;
                    //pictureBox1.ImageLocation = bmp;
                    pictureBox1.Image = bmp5;
                    this.label_debug.Text = Convert.ToString(string.Format(""));
                }
                else if (comboBox_chara.SelectedIndex == 9)//ネル
                {
                    Bitmap bmp9 = Properties.Resources.neru;
                    pictureBox1.Image = bmp9;
                    this.label_debug.Text = Convert.ToString(string.Format(""));
                }                
                else if (comboBox_chara.SelectedIndex == 10)//スピカ
                {
                    Bitmap bmp10 = Properties.Resources.spika;
                    pictureBox1.Image = bmp10;
                    this.label_debug.Text = Convert.ToString(string.Format(""));
                }
                else
                {
                    //PictureBox1に表示されている画像を消す
                    pictureBox1.Image = null;

                    this.label_debug.Text = Convert.ToString(string.Format(centermessage));
                }
            }

            if (comboBox_chara.SelectedIndex == 0)//ケン
            {
                this.label_equip002.Text = "ヘッドセット";
                comboBox_equip_002.Enabled = true;
                //拡張スロットの内容をキャラクターに応じて変更する
                comboBox_addslot.DataSource = ListBoxAddslot000;
            }
            else if (comboBox_chara.SelectedIndex == 1)//エリカ
            {
                this.label_equip002.Text = "(なし)";
                comboBox_equip_002.Enabled = false;
                comboBox_addslot.DataSource = ListBoxAddslot001;
            }
            else if (comboBox_chara.SelectedIndex == 2)//ダイスケ
            {
                this.label_equip002.Text = "ひげ";
                comboBox_equip_002.Enabled = true;
                comboBox_addslot.DataSource = ListBoxAddslot002;
            }
            else if (comboBox_chara.SelectedIndex == 3)//セシリア
            {
                this.label_equip002.Text = "タトゥー";
                comboBox_equip_002.Enabled = true;
                comboBox_addslot.DataSource = ListBoxAddslot003;
            }
            else if (comboBox_chara.SelectedIndex == 4)//マックス
            {
                this.label_equip002.Text = "リストバンド";
                comboBox_equip_002.Enabled = true;
                comboBox_addslot.DataSource = ListBoxAddslot004;
            }
            else if (comboBox_chara.SelectedIndex == 5)//クー
            {
                this.label_equip002.Text = "髪飾り";
                comboBox_equip_002.Enabled = true;
                comboBox_addslot.DataSource = ListBoxAddslot005;
            }
            else if (comboBox_chara.SelectedIndex == 6)//アリン
            {
                this.label_equip002.Text = "(なし)";
                comboBox_equip_002.Enabled = false;
                comboBox_addslot.DataSource = ListBoxAddslot006;
            }
            else if (comboBox_chara.SelectedIndex == 7)//カズ
            {
                this.label_equip002.Text = "(なし)";
                comboBox_equip_002.Enabled = false;
                comboBox_addslot.DataSource = ListBoxAddslot007;
            }
            else if (comboBox_chara.SelectedIndex == 8)//ルーシア
            {
                this.label_equip002.Text = "(なし)";
                comboBox_equip_002.Enabled = false;
                comboBox_addslot.DataSource = ListBoxAddslot008;
            }
            else if (comboBox_chara.SelectedIndex == 9)//ネル
            {
                this.label_equip002.Text = "(なし)";
                comboBox_equip_002.Enabled = false;
                comboBox_addslot.DataSource = ListBoxAddslot009;
            }
            else if (comboBox_chara.SelectedIndex == 10)//スピカ
            {
                this.label_equip002.Text = "(なし)";
                comboBox_equip_002.Enabled = false;
                comboBox_addslot.DataSource = ListBoxAddslot010;
            }
            //キャラ選択したらダウングレード・拡張スロット初期化
            numericUpDown_d1.Value = 0;
            numericUpDown_d2.Value = 0;
            numericUpDown_d3.Value = 0;
            numericUpDown_d4.Value = 0;
            numericUpDown_d5.Value = 0;
            //comboBox_addslot.SelectedIndex = 0;
            this.main();
            return;
        }
        private void comboBox_equip_001_SelectedIndexChanged(object sender, EventArgs e)//頭1
        {
            this.main();
            return;
        }
        private void comboBox_equip_002_SelectedIndexChanged(object sender, EventArgs e)//頭2
        {
            this.main();
            return;
        }
        private void comboBox_equip_003_SelectedIndexChanged(object sender, EventArgs e)//耳
        {
            specialequip[0] = "";
            pangyazone[0] = 0;
            comboBox_card_caddy3.Enabled = false;
            if (comboBox_equip_003.SelectedIndex != 0)
            {
                specialequip[0] = ((MyItem)comboBox_equip_003.SelectedItem).name;
            }
            if (comboBox_equip_003.SelectedIndex == 2 || comboBox_equip_003.SelectedIndex == 3 ||comboBox_equip_003.SelectedIndex == 5 ||comboBox_equip_003.SelectedIndex ==6 || comboBox_equip_003.SelectedIndex ==7)//ゾーン増加系
            {
                //ゾーン系耳+1
                pangyazone[0] = 1;
            }

            if ((comboBox_equip_003.SelectedIndex == 1) || (comboBox_equip_003.SelectedIndex == 4) || (comboBox_equip_003.SelectedIndex == 5) || (comboBox_equip_003.SelectedIndex == 7) || (comboBox_equip_003.SelectedIndex == 8) || (comboBox_equip_003.SelectedIndex == 9))
            {
                comboBox_card_caddy3.SelectedIndex = 0;
                comboBox_card_caddy3.Enabled = true;
            }
            this.main();
            return;
        }
        private void comboBox_equip_004_SelectedIndexChanged(object sender, EventArgs e)//目
        {
            specialequip[1] = "";
            if ((comboBox_equip_004.SelectedIndex == 1) || (comboBox_equip_004.SelectedIndex == 3) || (comboBox_equip_004.SelectedIndex == 7))
            {
                specialequip[1] = ((MyItem)comboBox_equip_004.SelectedItem).name;
            }
            this.main();
            return;
        }
        private void comboBox_equip_005_SelectedIndexChanged(object sender, EventArgs e)//頬
        {
            this.main();
            return;
        }
        private void comboBox_equip_006_SelectedIndexChanged(object sender, EventArgs e)//背中
        {
            pangyazone[1] = 0;
            specialequip[2] = "";
            if (comboBox_equip_006.SelectedIndex != 0)
            {
                specialequip[2] = ((MyItem)comboBox_equip_006.SelectedItem).name;
            }
            if (comboBox_equip_006.SelectedIndex == 1 || comboBox_equip_006.SelectedIndex > 3)//ゾーン増加系背中
            {
                pangyazone[1] = 1;
            }
            this.main();
            return;
        }
        private void comboBox_equip_007_SelectedIndexChanged(object sender, EventArgs e)//手袋
        {
            pangyazone[2] = 0;
            specialequip[3] = "";
            //if (comboBox_equip_007.SelectedIndex == 5)//アニパン手袋
            //{
                //pangyazone[2] = 4;
            //}
            if ((comboBox_equip_007.SelectedIndex == 3) || (comboBox_equip_007.SelectedIndex == 4) || (comboBox_equip_007.SelectedIndex == 5) || (comboBox_equip_007.SelectedIndex == 11))
            {
                specialequip[3] = ((MyItem)comboBox_equip_007.SelectedItem).name;
            }
            this.main();
            return;
        }
        private void comboBox_equip_008_SelectedIndexChanged(object sender, EventArgs e)//アクセ
        {
            specialequip[4] = "";
            if (comboBox_equip_008.SelectedIndex != 0)
            {
                specialequip[4] = ((MyItem)comboBox_equip_008.SelectedItem).name;
            }
            this.main();
            return;
        }
        private void comboBox_equip_009_SelectedIndexChanged(object sender, EventArgs e)//服上
        {
            this.main();
            return;
        }
        private void comboBox_equip_010_SelectedIndexChanged(object sender, EventArgs e)//服下
        {
            this.main();
            return;
        }
        private void comboBox_equip_011_SelectedIndexChanged(object sender, EventArgs e)//尾
        {
            this.main();
            return;
        }
        private void comboBox_equip_012_SelectedIndexChanged(object sender, EventArgs e)//靴
        {
            this.main();
            return;
        }
        private void comboBox_equip_013_SelectedIndexChanged(object sender, EventArgs e)//その他
        {
            pangyazone[3] = 0;
            if (comboBox_equip_013.SelectedIndex >= 4 && comboBox_equip_013.SelectedIndex <= 7)
            {
                //マガベニブルーム
                pangyazone[3] = 1;
            }
            this.main();
            return;
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                comboBox_equip_014.Enabled = true;
            }
            else
            {
                comboBox_equip_014.Enabled = false;
            }
        }
        private void comboBox_equip_014_SelectedIndexChanged(object sender, EventArgs e)//セット装備
        {
            comboBox_equip_001.Enabled = true;
            comboBox_equip_007.Enabled = true;
            comboBox_equip_009.Enabled = true;
            comboBox_equip_010.Enabled = true;
            comboBox_equip_012.Enabled = true;
            if (comboBox_equip_014.SelectedIndex != 0)
            {
                if (comboBox_equip_014.SelectedIndex < 7)//上下
                {
                    comboBox_equip_009.SelectedIndex = 0;
                    comboBox_equip_009.Enabled = false;
                    comboBox_equip_010.SelectedIndex = 0;
                    comboBox_equip_010.Enabled = false;
                }
                else if (comboBox_equip_014.SelectedIndex < 9)//頭上下
                {
                    comboBox_equip_001.SelectedIndex = 0;
                    comboBox_equip_001.Enabled = false;
                    comboBox_equip_009.SelectedIndex = 0;
                    comboBox_equip_009.Enabled = false;
                    comboBox_equip_010.SelectedIndex = 0;
                    comboBox_equip_010.Enabled = false;
                }
                else if (comboBox_equip_014.SelectedIndex < 11)//上下靴
                {
                    comboBox_equip_009.SelectedIndex = 0;
                    comboBox_equip_009.Enabled = false;
                    comboBox_equip_010.SelectedIndex = 0;
                    comboBox_equip_010.Enabled = false;
                    comboBox_equip_012.SelectedIndex = 0;
                    comboBox_equip_012.Enabled = false;
                }
                else if (comboBox_equip_014.SelectedIndex == 11)//上下手
                {
                    comboBox_equip_009.SelectedIndex = 0;
                    comboBox_equip_009.Enabled = false;
                    comboBox_equip_010.SelectedIndex = 0;
                    comboBox_equip_010.Enabled = false;
                    comboBox_equip_007.SelectedIndex = 0;
                    comboBox_equip_007.Enabled = false;
                }
                else if (comboBox_equip_014.SelectedIndex == 12)//頭上
                {
                    comboBox_equip_001.SelectedIndex = 0;
                    comboBox_equip_001.Enabled = false;
                    comboBox_equip_009.SelectedIndex = 0;
                    comboBox_equip_009.Enabled = false;
                }
                else if (comboBox_equip_014.SelectedIndex == 13)//頭上下靴手
                {
                    comboBox_equip_001.SelectedIndex = 0;
                    comboBox_equip_001.Enabled = false;
                    comboBox_equip_009.SelectedIndex = 0;
                    comboBox_equip_009.Enabled = false;
                    comboBox_equip_010.SelectedIndex = 0;
                    comboBox_equip_010.Enabled = false;
                    comboBox_equip_007.SelectedIndex = 0;
                    comboBox_equip_007.Enabled = false;
                    comboBox_equip_012.SelectedIndex = 0;
                    comboBox_equip_012.Enabled = false;
                }
            }
            this.main();
            return;
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            //ランクによって変更できる最大値を変更
            numericUpDown1.Maximum = rank;
            rank_power = (int)numericUpDown1.Value;
            this.main();
            return;
        }
        #endregion
        #region＜入力系　ランク＞
        private void radioButton_01_CheckedChanged(object sender, EventArgs e)
        {
            rank = 0;
            this.rankcheck();
            this.rank_addslot_error();
            return;
        }
        private void radioButton_02_CheckedChanged(object sender, EventArgs e)
        {
            rank = 1;
            this.rankcheck();
            this.rank_addslot_error();
            return;
        }
        private void radioButton_03_CheckedChanged(object sender, EventArgs e)
        {
            rank = 2;
            this.rankcheck();
            this.rank_addslot_error();
            return;
        }
        private void radioButton_04_CheckedChanged(object sender, EventArgs e)
        {
            rank = 3;
            this.rankcheck();
            this.rank_addslot_error();
            return;
        }
        private void radioButton_05_CheckedChanged(object sender, EventArgs e)
        {
            rank = 4;
            this.rankcheck();
            this.rank_addslot_error();
            return;
        }
        private void radioButton_06_CheckedChanged(object sender, EventArgs e)
        {
            rank = 5;
            this.rankcheck();
            this.rank_addslot_error();
            return;
        }
        private void radioButton_07_CheckedChanged(object sender, EventArgs e)
        {
            rank = 6;
            this.rankcheck();
            this.rank_addslot_error();
            return;
        }
        private void radioButton_08_CheckedChanged(object sender, EventArgs e)
        {
            rank = 7;
            this.rankcheck();
            this.rank_addslot_error();
            return;
        }
        private void radioButton_09_CheckedChanged(object sender, EventArgs e)
        {
            rank = 8;
            this.rankcheck();
            this.rank_addslot_error();
            return;
        }
        private void radioButton_10_CheckedChanged(object sender, EventArgs e)
        {
            rank = 9;
            this.rankcheck();
            this.rank_addslot_error();
            return;
        }
        private void radioButton_11_CheckedChanged(object sender, EventArgs e)
        {
            rank = 10;
            this.rankcheck();
            this.rank_addslot_error();
            return;
        }
        private void radioButton_12_CheckedChanged(object sender, EventArgs e)
        {
            rank = 11;
            this.rankcheck();
            this.rank_addslot_error();
            return;
        }
        private void radioButton_13_CheckedChanged(object sender, EventArgs e)
        {
            rank = 12;
            this.rankcheck();
            this.rank_addslot_error();
            return;
        }
        private void radioButton_14_CheckedChanged(object sender, EventArgs e)
        {
            rank = 13;
            this.rankcheck();
            this.rank_addslot_error();
            return;
        }
        #endregion
        #region＜入力系　キャラ共通＞
        private void comboBox_clubset_SelectedIndexChanged(object sender, EventArgs e)
        {
            specialequip[21] = "";
            if ((comboBox_clubset.SelectedIndex == 81) || (comboBox_clubset.SelectedIndex == 82))
            {
                specialequip[21] = ((MyItem)comboBox_clubset.SelectedItem).name;
            }
            try
            {
                this.clubset_calc();
            }
            catch
            {
                MessageBox.Show(e.ToString());
            }
            return;
        }
        //↑のSelectedIndexChangedは使わないようにしたい
        //オートコンプリートの時、存在しない装備を入力されるとエラーが出るのでTextChangedで処理する。はずなんだが・・うまくいかん
        private void comboBox_clubset_TextUpdate(object sender, EventArgs e)
        {
            try
            {
                comboBox_clubset.SelectedIndex = 0;
            }
            catch
            {
                MessageBox.Show(e.ToString());
            }
            return;
        }
        //EditingControlShowingのほうがいい？
        /*private void DataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
                string newItem = comboBox_clubset.Text.Trim();
                //if (!String.IsNullOrEmpty(newItem) && !((MyItem)comboBox_clubset.SelectedItem).name.Contains(newItem))
                if ("あ" == ((MyItem)comboBox_clubset.SelectedItem).name)
                 {
                    comboBox_clubset.SelectedIndex = 0;
                 }
            if (e.Control is DataGridViewComboBoxEditingControl)
            {
                //該当する列か調べる
                DataGridView dgv = (DataGridView)sender;
                if (dgv.CurrentCell.OwningColumn.Name == "comboBox_clubset")
                {
                    //編集のために表示されているコントロールを取得
                    DataGridViewComboBoxEditingControl cb =
                        (DataGridViewComboBoxEditingControl)e.Control;
                    cb.DropDownStyle = ComboBoxStyle.DropDown;
                }
            }
        }*/

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                if (comboBox_nochara1.SelectedIndex != 0)
                {
                    //((MyItem)comboBox_nochara1.SelectedItem).name
                    specialequip[5] = "キャディ衣装";
                }
                else
                {
                    specialequip[5] = "";
                }

            }
            else
            {
                specialequip[5] = "";
            }
            this.main();
            return;
        }
        private void comboBox_nochara1_SelectedIndexChanged(object sender, EventArgs e)//キャディ
        {
            this.label_caddy.Text = Convert.ToString(((MyItem)comboBox_nochara1.SelectedItem).name);
            specialequip[6] = "";
            if (comboBox_nochara1.SelectedIndex == 5)
            {
                specialequip[6] = ((MyItem)comboBox_nochara1.SelectedItem).name;
            }
            this.main();
            return;
        }
        private void comboBox_nochara2_SelectedIndexChanged(object sender, EventArgs e)//マスコット
        {
            pangyazone[4] = 0;
            specialequip[7] = "";
            specialup[0] = 0;
            //if (comboBox_nochara2.SelectedIndex > 0 && comboBox_nochara2.SelectedIndex < 10)
            //{
                //マスコットの確率パンヤゾーン増加
            //    pangyazone[4] = 2;
            //}
            if (comboBox_nochara2.SelectedIndex != 0)
            {
                specialequip[7] = ((MyItem)comboBox_nochara2.SelectedItem).name;
            }
            if (comboBox_nochara2.SelectedIndex == 1)
            {
                //ドロシー
                specialup[0] = 2;
            }
            else if (comboBox_nochara2.SelectedIndex == 3)
            {
                //レン
                specialup[0] = 4;
            }
            else if (comboBox_nochara2.SelectedIndex == 9)
            {
                //ドルフ
                specialup[0] = 3;
            }
            else if (comboBox_nochara2.SelectedIndex == 11)
            {
                //ロロ
                specialup[0] = 4;
            }
            this.main();
            return;
        }
        private void comboBox_nochara3_SelectedIndexChanged(object sender, EventArgs e)//リング
        {
            pangyazone[8] = 0;
            specialequip[8] = "";
            specialup[1] = 0;
            if (comboBox_nochara3.SelectedIndex >= 6)
            {
                specialequip[8] = ((MyItem)comboBox_nochara3.SelectedItem).name;
            }
            if (comboBox_nochara3.SelectedIndex == 6)
            {
                //クリリン
                specialup[1] = 4;
            }
            else if (comboBox_nochara3.SelectedIndex == 8)
            {
                //イグナイト他
                specialup[1] = 2;
            }
            else if (comboBox_nochara3.SelectedIndex == 10)
            {
                //フレア＋マーズ/ネプチューンでパンヤゾーン+1pix
                if (comboBox_nochara4.SelectedIndex == 4 || comboBox_nochara4.SelectedIndex == 5)
                {
                    //フレア＋マーズ/ネプチューンでパンヤゾーン+1pix
                    pangyazone[8] = 1;
                }
            }
            else if (comboBox_nochara3.SelectedIndex == 11)
            {
                //輝石セットで+1pix
                if (comboBox_nochara4.SelectedIndex == 7)
                {
                    pangyazone[8] = 1;
                }
            }
            else if (comboBox_nochara3.SelectedIndex == 13)
            {
                //アストロセットで+10y
                if (comboBox_nochara4.SelectedIndex == 9)
                {
                    specialup[1] = 10;
                    specialup[2] = 0;
                }
            }
            this.main();
            return;
        }
        private void comboBox_nochara4_SelectedIndexChanged(object sender, EventArgs e)//リングL
        {
            pangyazone[8] = 0;
            specialup[2] = 0;
            specialequip[9] = "";
            if (comboBox_nochara4.SelectedIndex == 1)
            {
                //ピンクダイアL
                specialup[2] = 10;
            }
            else if (comboBox_nochara4.SelectedIndex == 4 || comboBox_nochara4.SelectedIndex == 5)
            {
                if (comboBox_nochara3.SelectedIndex == 10)
                {
                    //フレア＋マーズ/ネプチューンでパンヤゾーン+1pix
                    pangyazone[8] = 1;
                }
            }
            else if (comboBox_nochara4.SelectedIndex == 6)
            {
                //スカーレットリングL
                specialup[2] = 6;
            }
            else if (comboBox_nochara4.SelectedIndex == 7)
            {
                //岩桔梗の輝石(L)
                if (comboBox_nochara3.SelectedIndex == 11)
                {
                    pangyazone[8] = 1;
                }
                specialup[2] = 5;
            }
            else if (comboBox_nochara4.SelectedIndex == 9)
            {
                //アストロセットで+10y
                if (comboBox_nochara3.SelectedIndex == 13)
                {
                    specialup[1] = 0;
                    specialup[2] = 10;
                }
            }
            if (comboBox_nochara4.SelectedIndex != 0)
            {
                //specialequip[9] = Convert.ToString(string.Format("{0} \r\n", ((MyItem)comboBox_nochara4.SelectedItem).name));
                specialequip[9] = ((MyItem)comboBox_nochara4.SelectedItem).name;
            }
            this.main();
            return;
        }
        private void comboBox_nochara5_SelectedIndexChanged(object sender, EventArgs e)//時間カード
        {
            pangyazone[5] = 0;
            specialup[8] = 0;
            specialequip[10] = "";
            if (comboBox_nochara5.SelectedIndex == 7)
            {
                //2時間カード：ミンティの愛+2y
                specialup[8] = 2;
            }
            if (comboBox_nochara5.SelectedIndex==8)
            {
                //レインボーフェザーのパンヤゾーン増加
                pangyazone[5] = 1;
            }
            if (comboBox_nochara5.SelectedIndex == 9)
            {
                //妖精の耳のパンヤゾーン増加
                pangyazone[5] = 2;
            }
            if (comboBox_nochara5.SelectedIndex >= 7 && comboBox_nochara5.SelectedIndex <= 10)
            {
                specialequip[10] = ((MyItem)comboBox_nochara5.SelectedItem).name;
            }
            this.main();
            return;
        }
        private void comboBox_nochara6_SelectedIndexChanged(object sender, EventArgs e)//パンヤゾーン増加系アイテム
        {
            specialequip[22] = "";
            pangyazone[9] = 0;
            if (comboBox_nochara6.SelectedIndex != 0)
            {
                pangyazone[9] = comboBox_nochara6.SelectedIndex;
                specialequip[22] = ((MyItem)comboBox_nochara6.SelectedItem).name;
            }
            this.main();
            return;
        }
        #endregion
        #region＜入力系　カード＞
        private void comboBox_card_npc1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pangyazone[6] = 0;
            specialequip[11] = "";
            if (comboBox_card_npc1.SelectedIndex == 0)
            {
                check_card_npc1 = 0;
            }
            else if (comboBox_card_npc1.SelectedIndex <= 4)
            {
                if (check_card_npc2 != 1)
                {
                    //ミューレン=1
                    specialequip[11] = ((MyItem)comboBox_card_npc1.SelectedItem).name;
                    check_card_npc1 = 1;
                }
            }
            else if (comboBox_card_npc1.SelectedIndex > 4 && comboBox_card_npc1.SelectedIndex < 9 )
            {
                if (comboBox_card_npc1.SelectedIndex == 5)
                {
                    //ティタンN
                    pangyazone[6] = 1;
                }
                else if (comboBox_card_npc1.SelectedIndex == 6)
                {
                    //ティタンR
                    pangyazone[6] = 2;
                }
                else if (comboBox_card_npc1.SelectedIndex == 7)
                {
                    //ティタンSR
                    pangyazone[6] = 3;
                }
                else if (comboBox_card_npc1.SelectedIndex == 8)
                {
                    //ティタンSC
                    pangyazone[6] = 4;
                }
                if (check_card_npc2 != 2)
                {
                    //ティタンチャム=2
                    specialequip[11] = ((MyItem)comboBox_card_npc1.SelectedItem).name;
                    check_card_npc1 = 2;
                }
            }
            else if (comboBox_card_npc1.SelectedIndex == 6)
            {
                if (check_card_npc2 != 3)
                {
                    //その他=3
                    specialequip[11] = ((MyItem)comboBox_card_npc1.SelectedItem).name;
                    check_card_npc1 = 3;
                }
            }
            this.main();
            return;
        }
        private void comboBox_card_npc2_SelectedIndexChanged(object sender, EventArgs e)
        {
            pangyazone[6] = 0;
            specialequip[12] = "";
            if (comboBox_card_npc2.SelectedIndex == 0)
            {
                check_card_npc2 = 0;
            }
            else if (comboBox_card_npc2.SelectedIndex <= 4)
            {
                if (check_card_npc1 != 1)
                {
                    //ミューレン=1
                    specialequip[12] = ((MyItem)comboBox_card_npc2.SelectedItem).name;
                    check_card_npc2 = 1;
                }
            }
            else if (comboBox_card_npc2.SelectedIndex > 4 && comboBox_card_npc2.SelectedIndex < 9 )
            {
                if (comboBox_card_npc2.SelectedIndex == 5)
                {
                    pangyazone[6] = 1;
                }
                else if (comboBox_card_npc2.SelectedIndex == 6)
                {
                    pangyazone[6] = 2;
                }
                else if (comboBox_card_npc2.SelectedIndex == 7)
                {
                    pangyazone[6] = 3;
                }
                else if (comboBox_card_npc2.SelectedIndex == 8)
                {
                    //ティタンSC
                    pangyazone[6] = 4;
                }
                if (check_card_npc1 != 2)
                {
                    //ティタンチャム=2
                    specialequip[12] = ((MyItem)comboBox_card_npc2.SelectedItem).name;
                    check_card_npc2 = 2;
                }
            }
            else if (comboBox_card_npc2.SelectedIndex == 6)
            {
                if (check_card_npc1 != 3)
                {
                    //その他=3
                    specialequip[12] = ((MyItem)comboBox_card_npc2.SelectedItem).name;
                    check_card_npc2 = 3;
                }
            }
            this.main();
            return;
        }
        private void comboBox_card_caddy1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pangyazone[7] = 0;
            label_card_caddy1.Text = "";
            if (comboBox_card_caddy1.SelectedIndex == 0)//なし
            {
                check_card_caddy1 = 0;
            }
            else if (comboBox_card_caddy1.SelectedIndex <= 4)//ロロ系=1
            {
                check_card_caddy1 = 1;
            }
            else if (comboBox_card_caddy1.SelectedIndex <= 8)//ピピン系=2
            {
                check_card_caddy1 = 2;
            }
            else if (comboBox_card_caddy1.SelectedIndex <= 11)//タンプー系=3
            {
                check_card_caddy1 = 3;
            }
            else if (comboBox_card_caddy1.SelectedIndex <= 15)//カディエ系=4
            {
                if (comboBox_card_caddy1.SelectedIndex <= 14)
                {
                    //カディエN～SR
                    pangyazone[7] = 1;
                }
                else if (comboBox_card_caddy1.SelectedIndex == 15)
                {
                    //カディエSC
                    pangyazone[7] = 2;
                }
                check_card_caddy1 = 4;
            }
            else if (comboBox_card_caddy1.SelectedIndex <= 19)//キューマ系=5
            {
                check_card_caddy1 = 5;
            }
            else if (comboBox_card_caddy1.SelectedIndex <= 23)//ミンティ系=6
            {
                check_card_caddy1 = 6;
            }
            else if (comboBox_card_caddy1.SelectedIndex == 24)//ポンタ系=7
            {
                check_card_caddy1 = 7;
            }
            else if (comboBox_card_caddy1.SelectedIndex == 25)//ティッキー系=8
            {
                check_card_caddy1 = 8;
            }
            else if (comboBox_card_caddy1.SelectedIndex == 26)//ドルフ系=9
            {
                check_card_caddy1 = 9;
            }
            else if (comboBox_card_caddy1.SelectedIndex == 27)//ウィンクルピピン系=10
            {
                check_card_caddy1 = 10;
            }
            this.check_cardkaburi();
            this.main();
            return;
        }
        private void comboBox_card_caddy2_SelectedIndexChanged(object sender, EventArgs e)
        {
            pangyazone[7] = 0;
            //powerup[2] = 0;
            //specialup[3] = 0;
            label_card_caddy2.Text = "";

            if (comboBox_card_caddy2.SelectedIndex == 0)
            {
                check_card_caddy2 = 0;
            }
            else if (comboBox_card_caddy2.SelectedIndex <= 4)//ロロ系=1
            {
                check_card_caddy2 = 1;
            }
            else if (comboBox_card_caddy2.SelectedIndex <= 8)//ピピン系=2
            {
                check_card_caddy2 = 2;
            }
            else if (comboBox_card_caddy2.SelectedIndex <= 11)//タンプー系=3
            {
                check_card_caddy2 = 3;
            }
            else if (comboBox_card_caddy2.SelectedIndex <= 15)//カディエ系=4
            {
                if (comboBox_card_caddy2.SelectedIndex <= 14)
                {
                    //カディエN～SR
                    pangyazone[7] = 1;
                }
                else if (comboBox_card_caddy2.SelectedIndex == 15)
                {
                    //カディエSC
                    pangyazone[7] = 2;
                }
                check_card_caddy2 = 4;
            }
            else if (comboBox_card_caddy2.SelectedIndex <= 19)//キューマ系=5
            {
                check_card_caddy2 = 5;
            }
            else if (comboBox_card_caddy2.SelectedIndex <= 23)//ミンティ系=6
            {
                check_card_caddy2 = 6;
            }
            else if (comboBox_card_caddy2.SelectedIndex == 24)//ポンタ系=7
            {
                check_card_caddy2 = 7;
            }
            else if (comboBox_card_caddy2.SelectedIndex == 25)//ティッキー系=8
            {
                check_card_caddy2 = 8;
            }
            else if (comboBox_card_caddy2.SelectedIndex == 26)//ドルフ系=9
            {
                check_card_caddy2 = 9;
            }
            else if (comboBox_card_caddy2.SelectedIndex == 27)//ウィンクルピピン系=10
            {
                check_card_caddy2 = 10;
            }
            this.check_cardkaburi();
            this.main();
            return;
        }
        private void comboBox_card_caddy3_SelectedIndexChanged(object sender, EventArgs e)
        {
            pangyazone[7] = 0;
            label_card_caddy3.Text = "";
            if (comboBox_card_caddy3.SelectedIndex == 0)
            {
                check_card_caddy3 = 0;
            }
            else if (comboBox_card_caddy3.SelectedIndex <= 4)//ロロ系=1
            {
                check_card_caddy3 = 1;
            }
            else if (comboBox_card_caddy3.SelectedIndex <= 8)//ピピン系=2
            {
                check_card_caddy3 = 2;
            }
            else if (comboBox_card_caddy3.SelectedIndex <= 11)//タンプー系=3
            {
                check_card_caddy3 = 3;
            }
            else if (comboBox_card_caddy3.SelectedIndex <= 15)//カディエ系=4
            {
                if (comboBox_card_caddy3.SelectedIndex <= 14)
                {
                    //カディエN～SR
                    pangyazone[7] = 1;
                }
                else if (comboBox_card_caddy3.SelectedIndex == 15)
                {
                    //カディエSC
                    pangyazone[7] = 2;
                }
                check_card_caddy3 = 4;
            }
            else if (comboBox_card_caddy3.SelectedIndex <= 19)//キューマ系=5
            {
                check_card_caddy3 = 5;
            }
            else if (comboBox_card_caddy3.SelectedIndex <= 23)//ミンティ系=6
            {
                check_card_caddy3 = 6;
            }
            else if (comboBox_card_caddy3.SelectedIndex == 24)//ポンタ系=7
            {
                check_card_caddy3 = 7;
            }
            else if (comboBox_card_caddy3.SelectedIndex == 25)//ティッキー系=8
            {
                check_card_caddy3 = 8;
            }
            else if (comboBox_card_caddy3.SelectedIndex == 26)//ドルフ系=9
            {
                check_card_caddy3 = 9;
            }
            else if (comboBox_card_caddy3.SelectedIndex == 27)//ウィンクルピピン系=10
            {
                check_card_caddy3 = 10;
            }
            this.check_cardkaburi();
            this.main();
            return;
        }
        private void comboBox_card_caddy4_SelectedIndexChanged(object sender, EventArgs e)
        {
            pangyazone[7] = 0;
            label_card_caddy4.Text = "";
            if (comboBox_card_caddy4.SelectedIndex == 0)
            {
                check_card_caddy4 = 0;
            }
            else if (comboBox_card_caddy4.SelectedIndex <= 4)//ロロ系=1
            {
                check_card_caddy4 = 1;
            }
            else if (comboBox_card_caddy4.SelectedIndex <= 8)//ピピン系=2
            {
                check_card_caddy4 = 2;
            }
            else if (comboBox_card_caddy4.SelectedIndex <= 11)//タンプー系=3
            {
                check_card_caddy4 = 3;
            }
            else if (comboBox_card_caddy4.SelectedIndex <= 15)//カディエ系=4
            {
                if (comboBox_card_caddy4.SelectedIndex <= 14)
                {
                    //カディエN～SR
                    pangyazone[7] = 1;
                }
                else if (comboBox_card_caddy4.SelectedIndex == 15)
                {
                    //カディエSC
                    pangyazone[7] = 2;
                }
                check_card_caddy4 = 4;
            }
            else if (comboBox_card_caddy4.SelectedIndex <= 19)//キューマ系=5
            {
                check_card_caddy4 = 5;
            }
            else if (comboBox_card_caddy4.SelectedIndex <= 23)//ミンティ系=6
            {
                check_card_caddy4 = 6;
            }
            else if (comboBox_card_caddy4.SelectedIndex == 24)//ポンタ系=7
            {
                check_card_caddy4 = 7;
            }
            else if (comboBox_card_caddy4.SelectedIndex == 25)//ティッキー系=8
            {
                check_card_caddy4 = 8;
            }
            else if (comboBox_card_caddy4.SelectedIndex == 26)//ドルフ系=9
            {
                check_card_caddy4 = 9;
            }
            else if (comboBox_card_caddy4.SelectedIndex == 27)//ウィンクルピピン系=10
            {
                check_card_caddy4 = 10;
            }
            this.check_cardkaburi();
            this.main();
            return;
        }
        private void comboBox_card_chara1_SelectedIndexChanged(object sender, EventArgs e)
        {
            specialup[4] = 0;
            specialequip[17] = "";
            if ((((MyItem)comboBox_card_chara1.SelectedItem).ID == "012") || (((MyItem)comboBox_card_chara1.SelectedItem).ID == "013") || (((MyItem)comboBox_card_chara1.SelectedItem).ID == "015") || (((MyItem)comboBox_card_chara1.SelectedItem).ID == "017"))
            {
                specialup[4] = -2;
                specialequip[17] = ((MyItem)comboBox_card_chara1.SelectedItem).name;
            }
            else if ((((MyItem)comboBox_card_chara1.SelectedItem).ID == "014") || (((MyItem)comboBox_card_chara1.SelectedItem).ID == "016") || (((MyItem)comboBox_card_chara1.SelectedItem).ID == "032"))
            {
                specialup[4] = -1;
                specialequip[17] = ((MyItem)comboBox_card_chara1.SelectedItem).name;
            }
            this.main();
            return;
        }
        private void comboBox_card_chara2_SelectedIndexChanged(object sender, EventArgs e)
        {
            specialup[5] = 0;
            specialequip[18] = "";
            if ((((MyItem)comboBox_card_chara2.SelectedItem).ID == "012") || (((MyItem)comboBox_card_chara2.SelectedItem).ID == "013") || (((MyItem)comboBox_card_chara2.SelectedItem).ID == "015") || (((MyItem)comboBox_card_chara2.SelectedItem).ID == "017"))
            {
                specialup[5] = -2;
                specialequip[18] = ((MyItem)comboBox_card_chara2.SelectedItem).name;
            }
            else if ((((MyItem)comboBox_card_chara2.SelectedItem).ID == "014") || (((MyItem)comboBox_card_chara2.SelectedItem).ID == "016") || (((MyItem)comboBox_card_chara2.SelectedItem).ID == "032"))
            {
                specialup[5] = -1;
                specialequip[18] = ((MyItem)comboBox_card_chara2.SelectedItem).name;
            }
            this.main();
            return;
        }
        private void comboBox_card_chara3_SelectedIndexChanged(object sender, EventArgs e)
        {
            specialup[6] = 0;
            specialequip[19] = "";
            if ((((MyItem)comboBox_card_chara3.SelectedItem).ID == "012") || (((MyItem)comboBox_card_chara3.SelectedItem).ID == "013") || (((MyItem)comboBox_card_chara3.SelectedItem).ID == "015") || (((MyItem)comboBox_card_chara3.SelectedItem).ID == "017"))
            {
                specialup[6] = -2;
                specialequip[19] = ((MyItem)comboBox_card_chara3.SelectedItem).name;
            }
            else if ((((MyItem)comboBox_card_chara3.SelectedItem).ID == "014") || (((MyItem)comboBox_card_chara3.SelectedItem).ID == "016") || (((MyItem)comboBox_card_chara3.SelectedItem).ID == "032"))
            {
                specialup[6] = -1;
                specialequip[19] = ((MyItem)comboBox_card_chara3.SelectedItem).name;
            }
            this.main();
            return;
        }
        private void comboBox_card_chara4_SelectedIndexChanged(object sender, EventArgs e)
        {
            specialup[7] = 0;
            specialequip[20] = "";
            if ((((MyItem)comboBox_card_chara4.SelectedItem).ID == "012") || (((MyItem)comboBox_card_chara4.SelectedItem).ID == "013") || (((MyItem)comboBox_card_chara4.SelectedItem).ID == "015") || (((MyItem)comboBox_card_chara4.SelectedItem).ID == "017"))
            {
                specialup[7] = -2;
                specialequip[20] = ((MyItem)comboBox_card_chara4.SelectedItem).name;
            }
            else if ((((MyItem)comboBox_card_chara4.SelectedItem).ID == "014") || (((MyItem)comboBox_card_chara4.SelectedItem).ID == "016") || (((MyItem)comboBox_card_chara4.SelectedItem).ID == "032"))
            {
                specialup[7] = -1;
                specialequip[20] = ((MyItem)comboBox_card_chara4.SelectedItem).name;
            }
            this.main();
            return;
        }
        #endregion
        #region＜入力系　クラブ改造ボタン＞
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                groupBox_clubcustom.Enabled = true;
            }
            else
            {
                groupBox_clubcustom.Enabled = false;
            }
        }
        private void comboBox_clubrank_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loadcancel == 1)
            {
                this.clubset_rank_calc();
                return;
            }
            //クラブを改造した状態で、クラブのレベルを変更するとマイナスになる場合があり
            //まずいので、クラブのレベルを変更した時に一旦デフォルトに戻す
            club_status_1 = club_status_1_default;
            club_status_2 = club_status_2_default;
            club_status_3 = club_status_3_default;
            club_status_4 = club_status_4_default;
            club_status_5 = club_status_5_default;
            this.clubset_rank_calc();
            return;
        }
        private void button1_plu_Click(object sender, EventArgs e)
        {
            club_button_1 = 1;
            club_kaizo_pm = 1;
            this.clubset_custom_calc();
        }
        private void button2_plu_Click(object sender, EventArgs e)
        {
            club_button_2 = 1;
            club_kaizo_pm = 1;
            this.clubset_custom_calc();
        }
        private void button3_plu_Click(object sender, EventArgs e)
        {
            club_button_3 = 1;
            club_kaizo_pm = 1;
            this.clubset_custom_calc();
        }
        private void button4_plu_Click(object sender, EventArgs e)
        {
            club_button_4 = 1;
            club_kaizo_pm = 1;
            this.clubset_custom_calc();
        }
        private void button5_plu_Click(object sender, EventArgs e)
        {
            club_button_5 = 1;
            club_kaizo_pm = 1;
            this.clubset_custom_calc();
        }
        private void button1_dec_Click(object sender, EventArgs e)
        {
            club_button_1 = -1;
            club_kaizo_pm = -1;
            this.clubset_custom_calc();
        }
        private void button2_dec_Click(object sender, EventArgs e)
        {
            club_button_2 = -1;
            club_kaizo_pm = -1;
            this.clubset_custom_calc();
        }
        private void button3_dec_Click(object sender, EventArgs e)
        {
            club_button_3 = -1;
            club_kaizo_pm = -1;
            this.clubset_custom_calc();
        }
        private void button4_dec_Click(object sender, EventArgs e)
        {
            club_button_4 = -1;
            club_kaizo_pm = -1;
            this.clubset_custom_calc();
        }
        private void button5_dec_Click(object sender, EventArgs e)
        {
            club_button_5 = -1;
            club_kaizo_pm = -1;
            this.clubset_custom_calc();
        }
        #endregion
        #region＜入力系　ダウングレード＞
        private void numericUpDown_d1_ValueChanged(object sender, EventArgs e)
        {
            //ダウングレードの最大回数はマイナスにならない
            numericUpDown_d1.Maximum = status_1;
            downgread_1 = (int)numericUpDown_d1.Value;
            this.main();
        }
        private void numericUpDown_d2_ValueChanged(object sender, EventArgs e)
        {
            //ダウングレードの最大回数はマイナスにならない
            numericUpDown_d2.Maximum = status_2;
            downgread_2 = (int)numericUpDown_d2.Value;
            this.main();
        }
        private void numericUpDown_d3_ValueChanged(object sender, EventArgs e)
        {
            //ダウングレードの最大回数はマイナスにならない
            numericUpDown_d3.Maximum = status_3;
            downgread_3 = (int)numericUpDown_d3.Value;
            this.main();
        }
        private void numericUpDown_d4_ValueChanged(object sender, EventArgs e)
        {
            //ダウングレードの最大回数はマイナスにならない
            numericUpDown_d4.Maximum = status_4;
            downgread_4 = (int)numericUpDown_d4.Value;
            this.main();
        }
        private void numericUpDown_d5_ValueChanged(object sender, EventArgs e)
        {
            //ダウングレードの最大回数はマイナスにならない
            numericUpDown_d5.Maximum = status_5;
            downgread_5 = (int)numericUpDown_d5.Value;
            this.main();
        }
        #endregion
        #region＜入力系　ダウングレードのオンオフ＞
        private void checkBox_d1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_d1.Checked)
            {
                numericUpDown_d1.Enabled = true;
            }
            else
            {
                numericUpDown_d1.Enabled = false;
            }
        }
        private void checkBox_d2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_d2.Checked)
            {
                numericUpDown_d2.Enabled = true;
            }
            else
            {
                numericUpDown_d2.Enabled = false;
            }
        }
        private void checkBox_d3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_d3.Checked)
            {
                numericUpDown_d3.Enabled = true;
            }
            else
            {
                numericUpDown_d3.Enabled = false;
            }
        }
        private void checkBox_d4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_d4.Checked)
            {
                numericUpDown_d4.Enabled = true;
            }
            else
            {
                numericUpDown_d4.Enabled = false;
            }
        }
        private void checkBox_d5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_d5.Checked)
            {
                numericUpDown_d5.Enabled = true;
            }
            else
            {
                numericUpDown_d5.Enabled = false;
            }
        }
        #endregion
        #region＜入力系　キャラクター拡張スロット＞
        private void comboBox_addslot_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.label_addslot.Text = Convert.ToString(string.Format("拡張スロット合計：パワー{0},コント{1},スピン{2},カーブ{3}", ((MyItem)comboBox_addslot.SelectedItem).data_01, ((MyItem)comboBox_addslot.SelectedItem).data_02, ((MyItem)comboBox_addslot.SelectedItem).data_04, ((MyItem)comboBox_addslot.SelectedItem).data_05));
            this.rank_addslot_error();
            this.main();
            return;
        }
        private void button_addslot_Click(object sender, EventArgs e)
        {
            int[] addslot_tp_type1 = { 0, 1, 4, 12, 24, 42, 72, 112, 157, 205, 305 };//1,3,8,12,18,30,40,45,48,100
            int[] addslot_tp_type2 = { 0, 2, 7, 17, 32, 52, 82, 117, 157, 202, 302 };//2,5,10,15,20,30,35,40,45,100
            int[] addslot_tp_type3 = { 0, 3, 10, 22, 40, 65, 93, 125, 160, 200, 300 };//3,7,12,18,25,28,32,35,40,100
            int i = comboBox_addslot.SelectedIndex;

            if (comboBox_chara.SelectedIndex == 1 && comboBox_chara.SelectedIndex == 4 && comboBox_chara.SelectedIndex == 7 && comboBox_chara.SelectedIndex == 10)
            {
                this.textBox_addslot.Text = Convert.ToString(string.Format("{0}", addslot_tp_type1[i]));
            }
            else if (comboBox_chara.SelectedIndex == 3 && comboBox_chara.SelectedIndex == 5 && comboBox_chara.SelectedIndex == 9)
            {
                this.textBox_addslot.Text = Convert.ToString(string.Format("{0}", addslot_tp_type3[i]));
            }
            else
            {
                this.textBox_addslot.Text = Convert.ToString(string.Format("{0}", addslot_tp_type2[i]));
            }
        }
        #endregion
        //初期値の読み込み///////////////////////////////////////////////////////////////////
        private void Form1_Load(object sender, EventArgs e)
        {
            //プログラム全体に関わるコード
            this.FormBorderStyle = FormBorderStyle.FixedSingle; //アプリケーション自体のサイズ変更を禁止するコード
            // コントロールの初期値はコントロールの初期化が終わってからだ| _･)
            //初期値
            #region＜numericUpDownの初期値＞
            // 最小値
            numericUpDown1.Minimum = 0;
            // 最大値
            numericUpDown1.Maximum = 14;
            // 増減の矢印をクリックした際に加算、減算される値
            numericUpDown1.Increment = 1;
            // 以下略
            numericUpDown_d1.Minimum = 0;
            numericUpDown_d1.Maximum = 99;
            numericUpDown_d2.Minimum = 0;
            numericUpDown_d2.Maximum = 50;
            numericUpDown_d3.Minimum = 0;
            numericUpDown_d3.Maximum = 40;
            numericUpDown_d4.Minimum = 0;
            numericUpDown_d4.Maximum = 30;
            numericUpDown_d5.Minimum = 0;
            numericUpDown_d5.Maximum = 30;
            #endregion

            comboBox_save.SelectedIndex = 0;//既定
            this.label_debug.Text = Convert.ToString(string.Format(centermessage));
            //クラブセットのオートコンプリートモードの設定
            comboBox_clubset.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox_clubset.AutoCompleteSource = AutoCompleteSource.ListItems;

            //セーブデータの存在ちぇーっく
            string filePath = System.Windows.Forms.Application.StartupPath;
            string fileName = "settings.xml";
            string fileFullPath = System.IO.Path.Combine(filePath, fileName);
            if (System.IO.File.Exists(fileFullPath))
            {
                //セーブデータがあった場合、save0の値を画面に表示させる
                //２回ロードしているのは１回目のロードでいろいろな初期値がセットされるため
                saveID = 0;
                this.load();
                this.load();
                this.main();
                return;
            }
            else
            {
                #region＜セーブデータがない場合の初期値＞
                comboBox_chara.SelectedIndex = 0;
                numericUpDown1.Value = 0;
                comboBox_equip_001.SelectedIndex = 0;
                comboBox_equip_002.SelectedIndex = 0;
                comboBox_equip_003.SelectedIndex = 0;//5
                comboBox_equip_004.SelectedIndex = 0;
                comboBox_equip_005.SelectedIndex = 0;
                comboBox_equip_006.SelectedIndex = 0;
                comboBox_equip_007.SelectedIndex = 0;
                comboBox_equip_008.SelectedIndex = 0; //10
                comboBox_equip_009.SelectedIndex = 0;
                comboBox_equip_010.SelectedIndex = 0;
                comboBox_equip_011.SelectedIndex = 0;
                comboBox_equip_012.SelectedIndex = 0;
                comboBox_equip_013.SelectedIndex = 0;//15
                comboBox_equip_014.SelectedIndex = 0;
                comboBox_clubset.SelectedIndex = 0;
                comboBox_nochara1.SelectedIndex = 0;
                comboBox_nochara2.SelectedIndex = 0;
                comboBox_nochara3.SelectedIndex = 0; //20
                comboBox_nochara4.SelectedIndex = 0;
                comboBox_nochara5.SelectedIndex = 0;
                comboBox_card_npc1.SelectedIndex = 0;
                comboBox_card_npc2.SelectedIndex = 0;
                comboBox_card_caddy1.SelectedIndex = 0;//25
                comboBox_card_caddy2.SelectedIndex = 0;
                comboBox_card_caddy3.SelectedIndex = 0;
                comboBox_card_caddy4.SelectedIndex = 0;
                comboBox_card_chara1.SelectedIndex = 0;
                comboBox_card_chara2.SelectedIndex = 0; //30
                comboBox_card_chara3.SelectedIndex = 0;
                comboBox_card_chara4.SelectedIndex = 0;
                comboBox_clubrank.SelectedIndex = 0;
                numericUpDown_d1.Value = 0;
                numericUpDown_d2.Value = 0;//35
                numericUpDown_d3.Value = 0;
                numericUpDown_d4.Value = 0;
                numericUpDown_d5.Value = 0;
                //一番上で宣言してるのでここにはないが、rank=No.39
                //club_status_1～5がNo.40～44
                comboBox_addslot.SelectedIndex = 0;//2014/09/26アップデートにより追加。No.45
                #endregion
                bInit = true; // 計算に必要な値がすべて初期化される前に計算されるのを防ぐ
                this.clubset_calc();
                //"初期値"を仮にセーブする(セーブデータがないままexeを起動した時、setting.xmlを自動生成する)
                this.save();
            }
            return;
        }

        //セーブデータの読み書き/////////////////////////////////////////////////////////////
        //単体セーブ/ロード
        private void button_Save_Click(object sender, EventArgs e)
        {
            this.save();
            return;
        }
        private void button_Load_Click(object sender, EventArgs e)
        {
            //ロードする場所を先に指定
            saveID = comboBox_save.SelectedIndex;
            this.load();
            return;
        }
        public void save()
        {
            //セーブしたいデータを作成///////
            saveID = comboBox_save.SelectedIndex;
            string savename = Convert.ToString(string.Format("{0} {1}", ((MyItem)comboBox_chara.SelectedItem).name, saveID));
            //numericUPdownはdecimal型なので先に変換しておく
            numeric1 = (int)numericUpDown1.Value;

            int[] msavedata = {   comboBox_chara.SelectedIndex, numeric1, comboBox_equip_001.SelectedIndex, comboBox_equip_002.SelectedIndex , comboBox_equip_003.SelectedIndex ,
                                  comboBox_equip_004.SelectedIndex, comboBox_equip_005.SelectedIndex,comboBox_equip_006.SelectedIndex,comboBox_equip_007.SelectedIndex, comboBox_equip_008.SelectedIndex,
                                  comboBox_equip_009.SelectedIndex, comboBox_equip_010.SelectedIndex,comboBox_equip_011.SelectedIndex,comboBox_equip_012.SelectedIndex, comboBox_equip_013.SelectedIndex,
                                  comboBox_equip_014.SelectedIndex, comboBox_clubset.SelectedIndex, comboBox_nochara1.SelectedIndex, comboBox_nochara2.SelectedIndex, comboBox_nochara3.SelectedIndex,
                                  comboBox_nochara4.SelectedIndex, comboBox_nochara5.SelectedIndex, comboBox_card_npc1.SelectedIndex, comboBox_card_npc2.SelectedIndex, comboBox_card_caddy1.SelectedIndex,
                                  comboBox_card_caddy2.SelectedIndex, comboBox_card_caddy3.SelectedIndex, comboBox_card_caddy4.SelectedIndex, comboBox_card_chara1.SelectedIndex, comboBox_card_chara2.SelectedIndex,
                                  comboBox_card_chara3.SelectedIndex, comboBox_card_chara4.SelectedIndex, comboBox_clubrank.SelectedIndex, downgread_1, downgread_2,
                                  downgread_3, downgread_4, downgread_5, rank, club_kaizo_kaisu,
                                  club_status_1, club_status_2, club_status_3, club_status_4, club_status_5,
                                  comboBox_addslot.SelectedIndex};//暫定

            //セーブデータここまで/////////

            //Setting.csを使ってみる
            SetSave1.Instance.MsaveID = saveID;
            SetSave1.Instance.Msavename = savename;
            SetSave1.Instance.Msavedata = (int[])msavedata.Clone();
            SetSave1.Instance.Secret = secretcheck;
            SetSave1.Instance.SaveNameComplete();
            SetSave1.Instance.SaveDataComplete();

            SetSave1.Instance.SaveStatus();


            //セーブデータコンボボックスの表示を変更する
            comboBox_save.Items.RemoveAt(saveID);
            comboBox_save.Items.Insert(saveID, Convert.ToString(string.Format("Save{0}：{1}", saveID, savename)));
            comboBox_save.SelectedIndex = saveID;
            return;
        }
        public void load()
        {
            //ロード中に発生するクラブ変更/クラブランク変更はまずいことになるのでキャンセル
            loadcancel = 1;
            //ロード開始////////////////////////////
            SetSave1.Instance.LoadStatus();

            //セーブデータの中身を対応していく
            #region＜ロードする場所チェッカー＞

            int[] msavedata = new int[46];
            if (saveID == 0)
            {
                msavedata = SetSave1.Instance.savedata0;
            }
            else if (saveID == 1)
            {
                msavedata = SetSave1.Instance.savedata1;
            }
            else if (saveID == 2)
            {
                msavedata = SetSave1.Instance.savedata2;
            }
            else if (saveID == 3)
            {
                msavedata = SetSave1.Instance.savedata3;
            }
            else if (saveID == 4)
            {
                msavedata = SetSave1.Instance.savedata4;
            }
            else if (saveID == 5)
            {
                msavedata = SetSave1.Instance.savedata5;
            }
            else if (saveID == 6)
            {
                msavedata = SetSave1.Instance.savedata6;
            }
            else if (saveID == 7)
            {
                msavedata = SetSave1.Instance.savedata7;
            }
            else if (saveID == 8)
            {
                msavedata = SetSave1.Instance.savedata8;
            }
            else if (saveID == 9)
            {
                msavedata = SetSave1.Instance.savedata9;
            }
            else if (saveID == 10)
            {
                msavedata = SetSave1.Instance.savedata10;
            }
            else if (saveID == 11)
            {
                msavedata = SetSave1.Instance.savedata11;
            }
            else if (saveID == 12)
            {
                msavedata = SetSave1.Instance.savedata12;
            }
            else if (saveID == 13)
            {
                msavedata = SetSave1.Instance.savedata13;
            }
            else if (saveID == 14)
            {
                msavedata = SetSave1.Instance.savedata14;
            }
            #endregion
            #region＜ロードした内容のうち、クラブ改造以外の設定に必要なものを対応＞
            comboBox_chara.SelectedIndex = msavedata[0];
            numeric1 = msavedata[1];
            comboBox_equip_001.SelectedIndex = msavedata[2];
            comboBox_equip_002.SelectedIndex = msavedata[3];
            comboBox_equip_003.SelectedIndex = msavedata[4];
            comboBox_equip_004.SelectedIndex = msavedata[5];
            comboBox_equip_005.SelectedIndex = msavedata[6];
            comboBox_equip_006.SelectedIndex = msavedata[7];
            comboBox_equip_007.SelectedIndex = msavedata[8];
            comboBox_equip_008.SelectedIndex = msavedata[9];
            comboBox_equip_009.SelectedIndex = msavedata[10];
            comboBox_equip_010.SelectedIndex = msavedata[11];
            comboBox_equip_011.SelectedIndex = msavedata[12];
            comboBox_equip_012.SelectedIndex = msavedata[13];
            comboBox_equip_013.SelectedIndex = msavedata[14];
            comboBox_equip_014.SelectedIndex = msavedata[15];
            comboBox_clubset.SelectedIndex = msavedata[16];
            comboBox_nochara1.SelectedIndex = msavedata[17];
            comboBox_nochara2.SelectedIndex = msavedata[18];
            comboBox_nochara3.SelectedIndex = msavedata[19];
            comboBox_nochara4.SelectedIndex = msavedata[20];
            comboBox_nochara5.SelectedIndex = msavedata[21];
            comboBox_card_npc1.SelectedIndex = msavedata[22];
            comboBox_card_npc2.SelectedIndex = msavedata[23];
            comboBox_card_caddy1.SelectedIndex = msavedata[24];
            comboBox_card_caddy2.SelectedIndex = msavedata[25];
            comboBox_card_caddy3.SelectedIndex = msavedata[26];
            comboBox_card_caddy4.SelectedIndex = msavedata[27];
            comboBox_card_chara1.SelectedIndex = msavedata[28];
            comboBox_card_chara2.SelectedIndex = msavedata[29];
            comboBox_card_chara3.SelectedIndex = msavedata[30];
            comboBox_card_chara4.SelectedIndex = msavedata[31];
            //comboBox_clubrank.SelectedIndex = msavedata[32];
            numericUpDown_d1.Value = msavedata[33];
            numericUpDown_d2.Value = msavedata[34];
            numericUpDown_d3.Value = msavedata[35];
            numericUpDown_d4.Value = msavedata[36];
            numericUpDown_d5.Value = msavedata[37];
            rank = msavedata[38];
            //club_kaizo_kaisu = msavedata[39];
            //club_status_1 = msavedata[40];
            //club_status_2 = msavedata[41];
            //club_status_3 = msavedata[42];
            //club_status_4 = msavedata[43];
            //club_status_5 = msavedata[44];
            comboBox_addslot.SelectedIndex = msavedata[45];

            secretcheck = SetSave1.Instance.Secret;
            #endregion

            bInit = true; // 計算に必要な値がすべて初期化される前に計算されるのを防ぐ

            #region＜画面に表示する系の設定＞
            #region＜ランク表示チェンジャー＞
            if (rank == 13)
            {
                radioButton_14.Checked = true;
            }
            else if (rank == 12)
            {
                radioButton_13.Checked = true;
            }
            else if (rank == 11)
            {
                radioButton_12.Checked = true;
            }
            else if (rank == 10)
            {
                radioButton_11.Checked = true;
            }
            else if (rank == 9)
            {
                radioButton_10.Checked = true;
            }
            else if (rank == 8)
            {
                radioButton_09.Checked = true;
            }
            else if (rank == 7)
            {
                radioButton_08.Checked = true;
            }
            else if (rank == 6)
            {
                radioButton_07.Checked = true;
            }
            else if (rank == 5)
            {
                radioButton_06.Checked = true;
            }
            else if (rank == 4)
            {
                radioButton_05.Checked = true;
            }
            else if (rank == 3)
            {
                radioButton_04.Checked = true;
            }
            else if (rank == 2)
            {
                radioButton_03.Checked = true;
            }
            else if (rank == 1)
            {
                radioButton_02.Checked = true;
            }
            else if (rank == 0)
            {
                radioButton_01.Checked = true;
            }
            #endregion
            //ひみつの
            if (secretcheck == 1)
            {
                Secret.Checked = true;
            }
            else
            {
                Secret.Checked = false;
            }
            //ランクの表示を変更する
            numericUpDown1.Maximum = rank;
            numericUpDown1.Value = numeric1;

            //セーブデータコンボボックスの表示を変更する
            for (int i = 0; i < 15; i++)
            {
                comboBox_save.Items.RemoveAt(i);
                comboBox_save.Items.Insert(i, Convert.ToString(string.Format("Save{0}：{1}", i, SetSave1.Instance.savename[i])));
            }
            //特殊装備の表示を変更する
            this.label_specialitem.Text = "";
            this.label_specialitem2.Text = "";

            comboBox_save.SelectedIndex = saveID;
            #endregion
            //ロードキャンセラーを戻す
            loadcancel = 0;
            //メイン設定
            this.clubset_calc();
            //クラブ改造の設定(クラブセットの設定　→　クラブ改造の設定　の順で行わないと、設定が上書きされてしまう)
            #region＜クラブ改造に必要な関数＞
            comboBox_clubrank.SelectedIndex = msavedata[32];
            club_kaizo_kaisu = msavedata[39];

            //コント0ということは初期値を読み込んでいるということなので、"0"ではなくエアーナイトの初期値を設定する
            if (msavedata[41] == 0)
            {
                club_status_1 = 6;
                club_status_2 = 7;
                club_status_3 = 5;
                club_status_4 = 3;
                club_status_5 = 3;
            }
            else
            {
                club_status_1 = msavedata[40];
                club_status_2 = msavedata[41];
                club_status_3 = msavedata[42];
                club_status_4 = msavedata[43];
                club_status_5 = msavedata[44];
            }
            #endregion
            this.clubset_kekka_calc();

            return;
        }
        //全セーブ/ロード
        private void button_AllLoad_Click(object sender, EventArgs e)
        {
            //ロードする場所=全部
            for (int i = 0; i < 15; i++)
            {
                saveID = i;
                this.load();
            }
            return;
        }
        private void button_Allreset_Click(object sender, EventArgs e)
        {
            //全部消去はメッセージボックスで確認を取る
            DialogResult result = MessageBox.Show("すべての保存したデータが削除されます。\r\nよろしいですか？",
               "確認",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Exclamation,
               MessageBoxDefaultButton.Button2);

            //何が選択されたか調べる
            if (result == DialogResult.Yes)
            {
                this.allreset();
            }
            return;

        }
        public void allreset()
        {
            //
            for (int i = 0; i < 15; i++)
            {
                string savename = "なし";

                int[] msavedata = {0,0,0,0,0,0,0,0,0,0,
                                   0,0,0,0,0,0,0,0,0,0,
                                   0,0,0,0,0,0,0,0,0,0,
                                   0,0,0,0,0,0,0,0,0,0,
                                   0,0,0,0,0,0};
                //Setting.csを使ってみる
                SetSave1.Instance.MsaveID = i;
                SetSave1.Instance.Msavename = savename;
                SetSave1.Instance.Msavedata = (int[])msavedata.Clone();
                SetSave1.Instance.SaveNameComplete();
                SetSave1.Instance.SaveDataComplete();
                SetSave1.Instance.SaveStatus();

            }
            //セーブする場所をNo.0に戻す
            saveID = 0;
            //セーブデータコンボボックスの表示をすべて消去する
            comboBox_save.Items.Clear();
            //セーブデータコンボボックスの表示をデフォルトに戻す
            string[] defaultsavelist = {"Save0：(なし)","Save1：(なし)","Save2：(なし)","Save3：(なし)","Save4：(なし)",
                                            "Save5：(なし)","Save6：(なし)","Save7：(なし)","Save8：(なし)","Save9：(なし)",
                                            "Save10：(なし)","Save11：(なし)","Save12：(なし)","Save13：(なし)","Save14：(なし)"};
            comboBox_save.Items.AddRange(defaultsavelist);
            comboBox_save.SelectedIndex = 0;
            //"何も設定していないデータ"を現在の画面にロードする
            this.load();
            return;
        }
        //単体消去
        public void erase()
        {
                string savename = "なし";

                int[] msavedata = {0,0,0,0,0,0,0,0,0,0,
                                   0,0,0,0,0,0,0,0,0,0,
                                   0,0,0,0,0,0,0,0,0,0,
                                   0,0,0,0,0,0,0,0,0,0,
                                   0,0,0,0,0,0};
                //Setting.csを使ってみる
                SetSave1.Instance.MsaveID = saveID;
                SetSave1.Instance.Msavename = savename;
                SetSave1.Instance.Msavedata = (int[])msavedata.Clone();
                SetSave1.Instance.SaveNameComplete();
                SetSave1.Instance.SaveDataComplete();
                SetSave1.Instance.SaveStatus();

                //セーブデータコンボボックスの表示を変更する
                comboBox_save.Items.RemoveAt(saveID);
                comboBox_save.Items.Insert(saveID, Convert.ToString(string.Format("Save{0}：(なし)", saveID)));
                comboBox_save.SelectedIndex = saveID;
            //"何も設定していないデータ"を現在の画面にロードする
            this.load();
            return;
        }
        private void button_Erase_Click(object sender, EventArgs e)
        {
            //全部消去はメッセージボックスで確認を取る
            DialogResult result = MessageBox.Show("現在選択されているデータが削除されます。\r\nよろしいですか？",
               "確認",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Exclamation,
               MessageBoxDefaultButton.Button2);

            //Yesなら消去へ
            if (result == DialogResult.Yes)
            {
                saveID = comboBox_save.SelectedIndex;
                this.erase();
            }
            return;
        }

        //ひみつの///////////////////////////////////////////////////////////////////////////
        private void Secret_CheckedChanged(object sender, EventArgs e)
        {
            if (Secret.Checked)
            {
                secretcheck = 1;
                string filePath = System.Windows.Forms.Application.StartupPath;
                string fileName = "MyImage.jpg";
                string fileFullPath = System.IO.Path.Combine(filePath, fileName);
                if (System.IO.File.Exists(fileFullPath))
                {
                    pictureBox1.ImageLocation = fileFullPath;
                    this.label_debug.Text = Convert.ToString(string.Format(""));
                }
                else
                {
                    pictureBox1.Image = null;
                }
            }
            else
            {
                secretcheck = 0;
                pictureBox1.Image = null;
                this.label_debug.Text = Convert.ToString(string.Format(centermessage));
            }
        }




    }
}
