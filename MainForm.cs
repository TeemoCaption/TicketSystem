
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

            string sql = $@"select ticket_id,ticketNo,runTime,startStation,endStation,price,ticketNum 
                from Ticket where runTime='{date}' ";
            this.dgvTicket.DataSource = dbHelper.GetDataTable(sql);
        }
    }
}