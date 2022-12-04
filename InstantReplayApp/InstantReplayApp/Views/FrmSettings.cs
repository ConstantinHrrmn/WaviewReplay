using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AForge.Video;
using AForge.Video.DirectShow;

namespace InstantReplayApp
{
    public partial class FrmSettings : Form
    {
        #region VARIABLES PRIVEES
        
        // Manager nécéssaire afin d'éffectuer toutes les actions dans l'application
        private MainManager _manager;

        // Variales privées 
        private bool changeInput = true;
        private int[] speedArray = null;
        private bool edit = false;

        private bool nud_edit = false;

        private List<Tuple<Label, TextBox>> _shortcutControls;
        #endregion

        #region GETTER / SETTER PUBLIQUES
        public MainManager Manager { get => _manager; set => _manager = value; }
        public List<Tuple<Label, TextBox>> ShortcutControls { get => _shortcutControls; set => _shortcutControls = value; }
        #endregion

        #region CONSTRUCTEUR / LOAD

        /// <summary>
        /// Constructeur par défaut de la form des réglages
        /// </summary>
        /// <param name="a_manager">Le manager de l'application principale</param>
        public FrmSettings(MainManager a_manager)
        {
            InitializeComponent();
            this.Manager = a_manager;
        }

        private void FrmSettings_Load(object sender, EventArgs e)
        {
            this.LoadComboSourceInput();
            this.InitSave();
            this.LoadData();

            this.LoadShortcutsControls();
            this.LoadShortcutData();
        }

        #endregion

        #region INPUT SELECTION

        /// <summary>
        /// Charger toutes les sources vidéos dans le combobox
        /// </summary>
        private void LoadComboSourceInput()
        {
            this.cmbSources.Items.Clear();

            foreach (FilterInfo item in this.Manager.LoadInputList())
                this.cmbSources.Items.Add(item.Name);
        }

        /// <summary>
        /// Chnager l'index de la combobox sans affecter le live
        /// </summary>
        /// <param name="index">l'index a sélectionner</param>
        public void CmbChangeIndex(int index)
        {
            this.changeInput = false;
            this.cmbSources.SelectedIndex = index;
            this.changeInput = true;
        }

        #endregion

        #region REPLAY SAVE PATH
        
        /// <summary>
        /// Changer le label du chemin de sauvegarde
        /// </summary>
        /// <param name="text">le text a afficher</param>
        /// <param name="c">la couleur du text</param>
        private void ChangeSavePathLabel(string text, Color c)
        {
            this.lblSavePath.Text = string.Format("( {0} )", text);
            this.lblSavePath.ForeColor = c;
        }

        /// <summary>
        /// Initialiser le chemin de sauvegarde
        /// </summary>
        private void InitSave()
        {
            if (Properties.Settings.Default.SavePath == null)
                this.ChangeSavePathLabel("No save path", Color.Red);
            else
            {
                if (!Directory.Exists(this.Manager.GetSavePath()))
                {
                    MessageBox.Show("The save path is not valid. Please select a new one.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Manager.SetSavePath(null);
                    this.ChangeSavePathLabel("No save path", Color.Red);
                }
                else
                    this.ChangeSavePathLabel(this.Manager.GetSavePath(), Color.Green);
            }
        }
        
        #endregion

        #region REWIND AND FORWARD

        /// <summary>
        /// Charger les informations de vitesse dans les numeric correspondants de la form
        /// </summary>
        private void LoadData()
        {
            // On récupère les données de vitesse à partir du manager
            this.speedArray = this.Manager.GetSpeeds();

            this.nudR25.Value = this.speedArray[0];
            this.nudR10.Value = this.speedArray[1];
            this.nudR1.Value = this.speedArray[2];

            this.nudF1.Value = this.speedArray[3];
            this.nudF10.Value = this.speedArray[4];
            this.nudF25.Value = this.speedArray[5];
        }

        /// <summary>
        /// Sauvegarder les données de vitesse dans le manager
        /// </summary>
        public void SaveSpeed()
        {
            this.nud_edit = false;
            
            this.speedArray[0] = (int)this.nudR25.Value;
            this.speedArray[1] = (int)this.nudR10.Value;
            this.speedArray[2] = (int)this.nudR1.Value;

            this.speedArray[3] = (int)this.nudF1.Value;
            this.speedArray[4] = (int)this.nudF10.Value;
            this.speedArray[5] = (int)this.nudF25.Value;

            this.Manager.SetSpeeds(this.speedArray);

            this.nud_edit = true;
        }

        /// <summary>
        /// Mettre les valeurs par défaut dans les vitesses
        /// </summary>
        public void ResetSpeeds()
        {
            this.Manager.ResetSpeed();
            this.LoadData();
        }

        private void nud_ValueChanged(object sender, EventArgs e)
        {
            if (nud_edit)
            {
                this.SaveSpeed();
                this.nud_edit = false;
            }
            
        }

        

        #endregion

        #region SHORTCUTS

        public void LoadShortcutsControls()
        {
            this.ShortcutControls = new List<Tuple<Label, TextBox>>();

            this.ShortcutControls.Add(new Tuple<Label, TextBox>(this.lbl0, this.tbx0));
            this.ShortcutControls.Add(new Tuple<Label, TextBox>(this.lbl1, this.tbx1));
            this.ShortcutControls.Add(new Tuple<Label, TextBox>(this.lbl2, this.tbx2));
            this.ShortcutControls.Add(new Tuple<Label, TextBox>(this.lbl3, this.tbx3));
            this.ShortcutControls.Add(new Tuple<Label, TextBox>(this.lbl4, this.tbx4));
            this.ShortcutControls.Add(new Tuple<Label, TextBox>(this.lbl5, this.tbx5));
            this.ShortcutControls.Add(new Tuple<Label, TextBox>(this.lbl6, this.tbx6));
            this.ShortcutControls.Add(new Tuple<Label, TextBox>(this.lbl7, this.tbx7));
            this.ShortcutControls.Add(new Tuple<Label, TextBox>(this.lbl8, this.tbx8));
            this.ShortcutControls.Add(new Tuple<Label, TextBox>(this.lbl9, this.tbx9));
            this.ShortcutControls.Add(new Tuple<Label, TextBox>(this.lbl10, this.tbx10));
            this.ShortcutControls.Add(new Tuple<Label, TextBox>(this.lbl11, this.tbx11));
            this.ShortcutControls.Add(new Tuple<Label, TextBox>(this.lbl12, this.tbx12));
            this.ShortcutControls.Add(new Tuple<Label, TextBox>(this.lbl13, this.tbx13));
            this.ShortcutControls.Add(new Tuple<Label, TextBox>(this.lbl14, this.tbx14));
            this.ShortcutControls.Add(new Tuple<Label, TextBox>(this.lbl15, this.tbx15));
            this.ShortcutControls.Add(new Tuple<Label, TextBox>(this.lbl16, this.tbx16));
        }

        public void LoadShortcutData()
        {
            int index = 0;
            foreach (Tuple<string, char, Action> item in this.Manager.Functions)
            {
                this.ShortcutControls[index].Item1.Text = item.Item1;
                this.ShortcutControls[index].Item2.Text = item.Item2.ToString();
                index++;
            }
        }

        private void tbx_TextChanged(object sender, EventArgs e)
        {
            if (edit)
            {
                TextBox tbx = (TextBox)sender;
                int index = this.ShortcutControls.FindIndex(x => x.Item2 == tbx);

                // if tbx input is only one char and an alpha char
                if (tbx.Text.Length == 1 && Char.IsLetter(tbx.Text[0]) && !this.Manager.ShortcutUsed(tbx.Text[0]))
                {
                    this.Manager.ChangeShortcut(index, tbx.Text[0]);
                    this.edit = false;
                    this.LoadShortcutData();
                }
                else
                {
                    this.edit = false;
                    tbx.Text = "";
                    MessageBox.Show("Error OR shortcut allready used");
                    this.LoadShortcutData();
                    this.edit = true;
                }

                this.lbl0.Focus();
            }

        }
        #endregion

        #region BUTTONS CLICK / COMBOBOX EVENTS

        // Tous les events sur les boutons

        #region REWIND ANS FORWARD

        private void button1_Click(object sender, EventArgs e)
        {
            this.ResetSpeeds();
        }
        #endregion

        #region SAVE PATH
        private void btnSetSavePath_Click(object sender, EventArgs e)
        {
            if (fbdReplay.ShowDialog() == DialogResult.OK)
            {
                //this.lblSaveReplayPath.Text = "Replay path : " + fbdReplay.SelectedPath;
                this.Manager.SetSavePath(fbdReplay.SelectedPath);

                this.ChangeSavePathLabel(this.Manager.GetSavePath(), Color.Green);

                Properties.Settings.Default.SavePath = fbdReplay.SelectedPath;
                Properties.Settings.Default.Save();
            }
        }
        #endregion

        #region INPUT SELECTION
        private void btnCloseLiveInput_Click(object sender, EventArgs e)
        {
            this.Manager.CloseLive();
            this.btnCloseLiveInput.Enabled = false;
            this.changeInput = false;
            this.cmbSources.SelectedIndex = -1;
            this.changeInput = true;
        }

        private void cmbSources_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.changeInput)
                this.Manager.ChangeInput(this.cmbSources.SelectedIndex);
            this.btnCloseLiveInput.Enabled = true;
        }

        #endregion

        #region SHORTCUTS

        private void btnResetShortcuts_Click(object sender, EventArgs e)
        {
            this.Manager.ResetShortcuts();
            this.LoadShortcutData();
        }

        private void tbx_Click(object sender, EventArgs e)
        {
            TextBox tbx = (TextBox)sender;
            tbx.Text = "";
            this.edit = true;
            tbx.Focus();
        }







        #endregion

        #endregion

        private void nud_Click(object sender, EventArgs e)
        {
            NumericUpDown nud = (NumericUpDown)sender;
            nud.Select(0, nud.Text.Length);
            this.nud_edit = true;
        }
    }
}
