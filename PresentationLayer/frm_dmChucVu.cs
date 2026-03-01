using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BusinessLogicLayer;
using DataTransferObject;

namespace PresentationLayer
{
    public partial class frm_dmChucVu : Form
    {
        BindingSource bs = new BindingSource();

        public frm_dmChucVu()
        {
            InitializeComponent();
        }

        private void frm_dmChucVu_Load(object sender, EventArgs e)
        {
            List<ChucVu_DTO> lstChucVu = ChucVu_BUS.LayChucVu();
            dgDSChucVu.DataSource = lstChucVu;
        }
    }
}