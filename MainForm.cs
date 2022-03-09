using System.Data.SqlClient;
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
            string start=this.cboStart.Text;   //���lվ
            string end = this.cboEnd.Text;   //Ŀ�ĵ�
            string date=this.dtpDate.Value.ToString("yyyy/MM/dd");   //�l܇�r�g

            //select convert(varchar,runTime,111) from Ticket;   ��ʽ������
            string sql = @"select ticket_id,ticketNo,runTime,startStation,endStation,price,ticketNum from Ticket 
                where convert(varchar,runTime,111)=convert(varchar,@date,111) from Ticket";
            this.dgvTicket.DataSource = dbHelper.GetDataTable(sql);

            //��ԃ���l�ء�Ŀ�ĵ�
            sql += start != "" ? "and startStation=@startStation" : " ";
            sql += end != "" ? "and endStation=@endStation" : " ";

            SqlParameter[] paras = new SqlParameter[] {


            };
        }
    }
}