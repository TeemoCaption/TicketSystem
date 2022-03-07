
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
            string sql = @"select ticket_id,ticketNo,runTime,startStation,endStation,ticketNum from Ticket";
            this.dgvTicket.DataSource = dbHelper.GetDataTable(sql);
        }
    }
}