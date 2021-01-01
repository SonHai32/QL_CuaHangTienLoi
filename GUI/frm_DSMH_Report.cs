using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frm_DSMH_Report : Form
    {
        public frm_DSMH_Report()
        {
            InitializeComponent();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            CR_MHTuDen rp = new CR_MHTuDen();
            CrystalDecisions.Shared.ParameterValues myValue = new CrystalDecisions.Shared.ParameterValues();
            CrystalDecisions.Shared.ParameterDiscreteValue PDVTuNgay = new CrystalDecisions.Shared.ParameterDiscreteValue();
            CrystalDecisions.Shared.ParameterDiscreteValue PDVDenNgay = new CrystalDecisions.Shared.ParameterDiscreteValue();


            CrystalDecisions.Shared.ConnectionInfo con = new CrystalDecisions.Shared.ConnectionInfo();
            con.ServerName = frmDangnhap.SV;
            con.DatabaseName = frmDangnhap.DB;
            con.UserID = frmDangnhap.ID;
            con.Password = frmDangnhap.PASS;

            TableLogOnInfo table = new TableLogOnInfo();
            table.ConnectionInfo = con;
            rp.Database.Tables[0].ApplyLogOnInfo(table);

            PDVTuNgay.Value = this.txtDayStart.Value;
            myValue.Add(PDVTuNgay);
            rp.DataDefinition.ParameterFields["@TUNGAY"].ApplyCurrentValues(myValue);
            myValue.Clear();

            PDVDenNgay.Value = this.txtDayEnd.Value;
            myValue.Add(PDVDenNgay);
            rp.DataDefinition.ParameterFields["@DENNGAY"].ApplyCurrentValues(myValue);
            myValue.Clear();


            this.crystalReportViewer1.ReportSource = rp;



        }
    }
}
