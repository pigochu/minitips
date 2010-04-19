using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Kerido.Controls;

namespace MiniTips
{

    public partial class FormWizardTipTime : Form
    {
        private Color _normalBackColor;
        private Color _normalForeColor;
        private Font _normalFont;
        private Color _selectedBackColor;
        private Color _selectedForeColor;
        private Font _selectedFont;
        private int _currentStep;

        private MiniTipsDataSet.TipsTimeRow _tipTimeRow;

        public FormWizardTipTime(MiniTipsDataSet.TipsTimeRow row)
        {
            InitializeComponent();
            this._tipTimeRow = row;
        }

        private void FormWizardTipTime_Load(object sender, EventArgs e)
        {
            _normalBackColor = Color.FromArgb(this.panelLeft.BackColor.ToArgb());
            _normalForeColor = Color.FromArgb(this.panelLeft.ForeColor.ToArgb());
            _normalFont = (Font)this.panelLeft.Font.Clone();
            _selectedBackColor = Color.FromArgb(this.panelLeftStep1.BackColor.ToArgb());
            _selectedForeColor = Color.FromArgb(this.panelLeftStep1.ForeColor.ToArgb());
            _selectedFont = (Font)this.panelLeftStep1.Font.Clone();
            _currentStep = 1;


            // 以下是設定各控制項的值
            if (_tipTimeRow.TipType == 0)
            {
                this.rb_Once.Checked = true;
            }
            else if (_tipTimeRow.TipType == 1)
            {
                this.rb_Year.Checked = true;
            }
            else if (_tipTimeRow.TipType == 2)
            {
                this.rb_Month.Checked = true;
            }
            else if (_tipTimeRow.TipType == 3)
            {
                this.rb_Week.Checked = true;
                // 設定每星期的checkbox控制項
                if ((_tipTimeRow.Week & 1) > 0)
                {
                    this.cb_Week0.Checked = true;
                }
                if ((_tipTimeRow.Week & 2) > 0)
                {
                    this.cb_Week1.Checked = true;
                }
                if ((_tipTimeRow.Week & 4) > 0)
                {
                    this.cb_Week2.Checked = true;
                }
                if ((_tipTimeRow.Week & 8) > 0)
                {
                    this.cb_Week3.Checked = true;
                }
                if ((_tipTimeRow.Week & 16) > 0)
                {
                    this.cb_Week4.Checked = true;
                }
                if ((_tipTimeRow.Week & 32) > 0)
                {
                    this.cb_Week5.Checked = true;
                }
                if ((_tipTimeRow.Week & 64) > 0)
                {
                    this.cb_Week6.Checked = true;
                }
            }
            else if (_tipTimeRow.TipType == 4)
            {
                this.rb_Day.Checked = true;
            }

            else if (_tipTimeRow.TipType == 5)
            {
                this.rb_Hour.Checked = true;
            }

            this.dt_DateTime.Value = _tipTimeRow.TipDateTime;


            this.cb_EnableExpireNotify.Checked = _tipTimeRow.EnableExpireNotify;

            this.groupBox_Expire.Enabled = true;
            this.numericUpDown_ExpireDay.Value = _tipTimeRow.ExpireDay;
            this.numericUpDown_ExpireHour.Value = _tipTimeRow.ExpireHour;
            this.numericUpDown_ExpireMinute.Value = _tipTimeRow.ExpireMinute;



        }

        private void SetWeekCheckboxVisable(bool b)
        {
            cb_Week0.Visible = b;
            cb_Week1.Visible = b;
            cb_Week2.Visible = b;
            cb_Week3.Visible = b;
            cb_Week4.Visible = b;
            cb_Week5.Visible = b;
            cb_Week6.Visible = b;
        }

        private void InitExpireControl()
        {
            if (true == this.cb_EnableExpireNotify.Checked)
            {
                if (rb_Once.Checked || rb_Year.Checked || rb_Month.Checked || rb_Week.Checked)
                {
                    this.numericUpDown_ExpireDay.Enabled = true;
                    this.numericUpDown_ExpireHour.Enabled = true;
                    this.numericUpDown_ExpireMinute.Enabled = true;
                }
                else if (rb_Day.Checked)
                {
                    this.numericUpDown_ExpireDay.Enabled = false;
                    this.numericUpDown_ExpireDay.Value = 0;
                    this.numericUpDown_ExpireHour.Enabled = true;
                    this.numericUpDown_ExpireMinute.Enabled = true;
                }
                else
                {
                    this.numericUpDown_ExpireDay.Enabled = false;
                    this.numericUpDown_ExpireDay.Value = 0;
                    this.numericUpDown_ExpireHour.Enabled = false;
                    this.numericUpDown_ExpireHour.Value = 0;
                    this.numericUpDown_ExpireMinute.Enabled = true;
                }
            }
            else
            {
                this.numericUpDown_ExpireDay.Enabled = false;
                this.numericUpDown_ExpireHour.Enabled = false;
                this.numericUpDown_ExpireMinute.Enabled = false;
            }
        }



        private void SwitchStep(int step)
        {
            // 切換左邊 SideBar
            string leftKey = "panelLeftStep";
            Panel panelStep;
            
            panelStep = (Panel)this.panelLeft.Controls[ leftKey + _currentStep.ToString()];
            panelStep.BackColor = Color.FromArgb(_normalBackColor.ToArgb());
            panelStep.ForeColor = Color.FromArgb(_normalForeColor.ToArgb());
            panelStep.Font = _normalFont;

            panelStep = (Panel)this.panelLeft.Controls[leftKey + step.ToString()];
            panelStep.BackColor = Color.FromArgb(_selectedBackColor.ToArgb());
            panelStep.ForeColor = Color.FromArgb(_selectedForeColor.ToArgb());
            panelStep.Font = _selectedFont;



            // 切換上面 Title
            // string topKey = "mp_TopStep";
            // MultiPanePage pageTop;
            //pageTop = (MultiPanePage)this.mp_Top.Controls[topKey + step.ToString()];
            // pageTop = (MultiPanePage)this.mp_Top.Controls[step-1];

            this.mp_Top.SelectedPage = (MultiPanePage)this.mp_Top.Controls[step - 1];



            // 切換內容
            // string contentKey = "mp_ContentStep";
            // MultiPanePage pageContent;
            //pageContent = (MultiPanePage)this.mp_Content.Controls[contentKey + step.ToString()];
            // pageContent = (MultiPanePage)this.mp_Content.Controls[step - 1];
            this.mp_Content.SelectedPage = (MultiPanePage)this.mp_Content.Controls[step - 1];
            

            // 處理下方按鈕
            if (1 == step)
            {
                this.buttonPrev.Enabled = false;
                this.buttonNext.Enabled = true;
            }
            else if (2 == step)
            {
                this.buttonFinish.Enabled = false;
                this.buttonNext.Enabled = true;
                this.buttonPrev.Enabled = true;


                // 判斷各種類型 , 讓這一頁的 Control 有不同的視覺
                this.SetWeekCheckboxVisable(rb_Week.Checked);

                if(true == rb_Once.Checked) 
                {
                    this.dt_DateTime.CustomFormat = "yyyy 年 MM 月 dd 日 HH:mm:ss";
                    this.labelType.Text = this.rb_Once.Text;
                }
                else if (true == rb_Year.Checked)
                {
                    this.dt_DateTime.CustomFormat = "MM 月 dd 日 HH:mm:ss";
                    this.labelType.Text = this.rb_Year.Text;
                } 
                else if(true == rb_Month.Checked)
                {
                    this.dt_DateTime.CustomFormat = "dd 日 HH:mm:ss";
                    this.labelType.Text = this.rb_Month.Text;
                }
                else if (true == rb_Week.Checked)
                {
                    this.dt_DateTime.CustomFormat = "HH:mm:ss";
                    this.labelType.Text = this.rb_Week.Text;
                }

                else if (true == rb_Day.Checked)
                {
                    this.dt_DateTime.CustomFormat = "HH:mm:ss";
                    this.labelType.Text = this.rb_Day.Text;
                }
                else
                {
                    this.dt_DateTime.CustomFormat = "mm:ss";
                    this.labelType.Text = this.rb_Hour.Text;
                }


                this.InitExpireControl();

            }
            else if (3 == step)
            {
                this.buttonNext.Enabled = false;
                this.buttonPrev.Enabled = true;
                this.buttonFinish.Enabled = true;
            }


            _currentStep = step;
        }


        private void NextStep()
        {
            if (_currentStep < 3)
            {
                this.SwitchStep(_currentStep + 1);
            }
        }

        private void PrevStep()
        {
            if (_currentStep > 1)
            {
                this.SwitchStep(_currentStep - 1);
            }
        }


        private void Save()
        {

            if (true == rb_Once.Checked)
            {
                _tipTimeRow.TipType = 0;
            }
            else if (true == rb_Year.Checked)
            {
                _tipTimeRow.TipType = 1;
            }
            else if (true == rb_Month.Checked)
            {
                _tipTimeRow.TipType = 2;
            }
            else if (true == rb_Week.Checked)
            {

                _tipTimeRow.TipType = 3;

                // 用 byte 儲存複選的星期
                // bit1 代表 周日 , bit2 代表周一...bit7 代表周六
                Byte week = 0;
                if (true == cb_Week0.Checked)
                {
                    week = (Byte)(week | 1);
                }
                if (true == cb_Week1.Checked)
                {
                    week = (Byte)(week | 2);
                }
                if (true == cb_Week2.Checked)
                {
                    week = (Byte)(week | 4);
                }
                if (true == cb_Week3.Checked)
                {
                    week = (Byte)(week | 8);
                }
                if (true == cb_Week4.Checked)
                {
                    week = (Byte)(week | 16);
                }
                if (true == cb_Week5.Checked)
                {
                    week = (Byte)(week | 32);
                }
                if (true == cb_Week6.Checked)
                {
                    week = (Byte)(week | 64);
                }
                _tipTimeRow.Week = week;
            }
            else if (true == rb_Day.Checked)
            {
                _tipTimeRow.TipType = 4;
            }


            else if (true == rb_Hour.Checked)
            {
                _tipTimeRow.TipType = 5;
            }
            _tipTimeRow.TipDateTime = this.dt_DateTime.Value;

            _tipTimeRow.EnableExpireNotify = this.cb_EnableExpireNotify.Checked;
            if (true == _tipTimeRow.EnableExpireNotify)
            {
                _tipTimeRow.ExpireDay = (Int32)this.numericUpDown_ExpireDay.Value;
                _tipTimeRow.ExpireHour = (Int32)this.numericUpDown_ExpireHour.Value;
                _tipTimeRow.ExpireMinute = (Int32)this.numericUpDown_ExpireMinute.Value;
            }
            else
            {
                _tipTimeRow.ExpireDay = 0;
                _tipTimeRow.ExpireHour = 0;
                _tipTimeRow.ExpireMinute = 0;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private bool CheckTypeChecked()
        {
            if (true == this.rb_Once.Checked
                || true == this.rb_Year.Checked
                || true == this.rb_Month.Checked
                || true == this.rb_Week.Checked
                || true == this.rb_Day.Checked
                || true == this.rb_Hour.Checked)
            {
                return true;
            }
            else
            {
                MessageBox.Show("請選擇類型", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool CheckTime()
        {
            if (this.rb_Week.Checked == true)
            {
                // 檢查有沒有勾選星期

                if (true == cb_Week0.Checked
                    || true == cb_Week1.Checked
                    || true == cb_Week2.Checked
                    || true == cb_Week3.Checked
                    || true == cb_Week4.Checked
                    || true == cb_Week5.Checked
                    || true == cb_Week6.Checked)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("你沒有勾選星期中的任何一天", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

            }

            return true;
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            this.PrevStep();
        }
        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (1 == _currentStep)
            {
                // 假如目前是步驟 1, 要先檢查是否有選擇提醒類型
                if (this.CheckTypeChecked())
                {
                    this.SwitchStep(_currentStep + 1);
                }
            }
            else if (2 == _currentStep)
            {
                // 假如目前是步驟 2 , 檢查輸入的時間資料是否正確
                if (this.CheckTime())
                {
                    this.SwitchStep(_currentStep + 1);
                }
            }
        }


        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }



        private void buttonFinish_Click(object sender, EventArgs e)
        {
            this.Save();
        }

        private void cb_EnableExpireNotify_CheckStateChanged(object sender, EventArgs e)
        {
            this.InitExpireControl();
        }






    }
}
