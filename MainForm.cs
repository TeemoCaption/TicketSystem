using System.Data.SqlClient;
using System.Data;
namespace TicketSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //�@ȡ�Ñ�ݔ��l��
            string start = this.cboStart.Text;   //���lվ
            string end = this.cboEnd.Text;   //Ŀ�ĵ�
            string date = this.dtpDate.Value.ToShortDateString();   //�l܇�r�g

            //select convert(varchar,runTime,111) from Ticket;   ��ʽ������
            string sql = @"select ticket_id,ticketNo,runTime,startStation,endStation,price,ticketNum from Ticket where convert(varchar, runTime,111)= convert(varchar, @date, 111)";
            //this.dgvTicket.DataSource = dbHelper.GetDataTable(sql);

            //��ԃ���l�ء�Ŀ�ĵ�
            sql += start != "" ? " and startStation=@startStation" : " ";
            sql += end != "" ? " and endStation=@endStation" : " ";

            SqlParameter[] paras = {
                new SqlParameter("@date",Convert.ToDateTime(date)),    //���ַ����D������
                new SqlParameter("@startStation",start),
                new SqlParameter("@endStation",end)
            };

            this.dgvTicket.DataSource = dbHelper.GetDataTable(sql, paras);
        }

        private void tsmlBuy_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// �����c���¼�(�������I)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvTicket_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex >= 0)
                {
                    //ȡ��ԭ���x�е��Y��
                    this.dgvTicket.ClearSelection();
                    this.dgvTicket.Rows[e.RowIndex].Selected=true;     //�ք��xȡ��

                }
            }
        }
    }
}