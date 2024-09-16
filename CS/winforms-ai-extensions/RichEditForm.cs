using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_AI_Extensions
{
    public partial class RichEditForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public RichEditForm()
        {
            InitializeComponent();
            RibbonControl ribbon = richEditControl1.CreateRibbon();
            this.Controls.Add(ribbon);
            richEditControl1.LoadDocument("WindowsForms.docx");
        }
    }
}