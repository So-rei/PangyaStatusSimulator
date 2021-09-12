using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Windows.Forms;

namespace PangyaStatusSimulator
{
    //セーブデータを作成するクラス
    public class SetSave1
    {
        //初期値
        private int msaveID;
        private string msavename = "Save000";
        public int MsaveID
        {
            get { return msaveID; }
            set { msaveID = value; }
        }
        public string Msavename
        {
            get { return msavename; }
            set { msavename = value; }
        }

        private int[] msavedata = new int[46];
        [System.Xml.Serialization.XmlIgnore]
        public int[] Msavedata
        {
            get { return msavedata; }
            set { msavedata = value; }
        }
        #region＜savedata＞
        public int[] savedata0 = new int[46];
        public int[] savedata1 = new int[46];
        public int[] savedata2 = new int[46];
        public int[] savedata3 = new int[46];
        public int[] savedata4 = new int[46];
        public int[] savedata5 = new int[46];
        public int[] savedata6 = new int[46];
        public int[] savedata7 = new int[46];
        public int[] savedata8 = new int[46];
        public int[] savedata9 = new int[46];
        public int[] savedata10 = new int[46];
        public int[] savedata11 = new int[46];
        public int[] savedata12 = new int[46];
        public int[] savedata13 = new int[46];
        public int[] savedata14 = new int[46];
        /*
        public int[] SaveData01
        {
            get { return savedata01; }
            set { savedata01 = value; }
        }
        public int[] SaveData02
        {
            get { return savedata02; }
            set { savedata02 = value; }
        }
        public int[] SaveData03
        {
            get { return savedata03; }
            set { savedata03 = value; }
        }
        public int[] SaveData04
        {
            get { return savedata04; }
            set { savedata04 = value; }
        }
        public int[] SaveData05
        {
            get { return savedata05; }
            set { savedata05 = value; }
        }
        public int[] SaveData06
        {
            get { return savedata06; }
            set { savedata06 = value; }
        }
        public int[] SaveData07
        {
            get { return savedata07; }
            set { savedata07 = value; }
        }
        public int[] SaveData08
        {
            get { return savedata08; }
            set { savedata08 = value; }
        }
        public int[] SaveData09
        {
            get { return savedata09; }
            set { savedata09 = value; }
        }
        public int[] SaveData10
        {
            get { return savedata10; }
            set { savedata10 = value; }
        }
        public int[] SaveData11
        {
            get { return savedata11; }
            set { savedata11 = value; }
        }
        public int[] SaveData12
        {
            get { return savedata12; }
            set { savedata12 = value; }
        }
        public int[] SaveData13
        {
            get { return savedata13; }
            set { savedata13 = value; }
        }
        public int[] SaveData14
        {
            get { return savedata14; }
            set { savedata14 = value; }
        }
         */
        #endregion

        public string[] savename = new string[15]{"(なし)","(なし)","(なし)","(なし)","(なし)",
                                                  "(なし)","(なし)","(なし)","(なし)","(なし)",
                                                  "(なし)","(なし)","(なし)","(なし)","(なし)",};
        public int Secret;
        
        //セーブデータの形式を整理
        public void SaveDataComplete()
        {
            if (msaveID == 0)
            {
                for (int i = 0; i < 46; i++)
                {
                    savedata0[i] = msavedata[i];
                }
            }
            else if (msaveID == 1)
            {
                for (int i = 0; i < 46; i++)
                {
                    savedata1[i] = msavedata[i];
                }
            }
            else if (msaveID == 2)
            {
                for (int i = 0; i < 46; i++)
                {
                    savedata2[i] = msavedata[i];
                }
            }
            else if (msaveID == 3)
            {
                for (int i = 0; i < 46; i++)
                {
                    savedata3[i] = msavedata[i];
                }
            }
            else if (msaveID == 4)
            {
                for (int i = 0; i < 46; i++)
                {
                    savedata4[i] = msavedata[i];
                }
            }
            else if (msaveID == 5)
            {
                for (int i = 0; i < 46; i++)
                {
                    savedata5[i] = msavedata[i];
                }
            }
            else if (msaveID == 6)
            {
                for (int i = 0; i < 46; i++)
                {
                    savedata6[i] = msavedata[i];
                }
            }
            else if (msaveID == 7)
            {
                for (int i = 0; i < 46; i++)
                {
                    savedata7[i] = msavedata[i];
                }
            }
            else if (msaveID == 8)
            {
                for (int i = 0; i < 46; i++)
                {
                    savedata8[i] = msavedata[i];
                }
            }
            else if (msaveID == 9)
            {
                for (int i = 0; i < 46; i++)
                {
                    savedata9[i] = msavedata[i];
                }
            }
            else if (msaveID == 10)
            {
                for (int i = 0; i < 46; i++)
                {
                    savedata10[i] = msavedata[i];
                }
            }
            else if (msaveID == 11)
            {
                for (int i = 0; i < 46; i++)
                {
                    savedata11[i] = msavedata[i];
                }
            }
            else if (msaveID == 12)
            {
                for (int i = 0; i < 46; i++)
                {
                    savedata12[i] = msavedata[i];
                }
            }
            else if (msaveID == 13)
            {
                for (int i = 0; i < 46; i++)
                {
                    savedata13[i] = msavedata[i];
                }
            }
            else if (msaveID == 14)
            {
                for (int i = 0; i < 46; i++)
                {
                    savedata14[i] = msavedata[i];
                }
            }
        }
        public void SaveNameComplete()
        {
            savename[msaveID] = msavename;
        }

        //セーブ
        public void SaveStatus()
        {
            //これでシリアライズ化できるはず！！
            XmlSerializer serializer = new XmlSerializer(typeof(SetSave1));
            //fileFullPath = @"D:\settings.xml";
            string filePath = System.Windows.Forms.Application.StartupPath;
            string fileName = "settings.xml";
            string fileFullPath = System.IO.Path.Combine(filePath, fileName);

            using (FileStream stream = new FileStream(fileFullPath, FileMode.Create))
            {
                serializer.Serialize(stream, Instance);
            }
        }

        //ロード
        public void LoadStatus()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(SetSave1));
            SetSave1 loading;
            string filePath = System.Windows.Forms.Application.StartupPath;
            string fileName = "settings.xml";
            string fileFullPath = System.IO.Path.Combine(filePath, fileName); 
            using (FileStream stream = new FileStream(fileFullPath, FileMode.Open))
            {
                loading = (SetSave1)serializer.Deserialize(stream);
            }
            Instance = loading;
        }

        //SetSaveクラスのただ一つのインスタンス
        [NonSerialized()]
        private static SetSave1 _instance;
        [System.Xml.Serialization.XmlIgnore]
        public static SetSave1 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new SetSave1();
                return _instance;
            }
            set { _instance = value; }
        }
    }
}
