using System.Net;
using static System.Net.Mime.MediaTypeNames;

namespace HW4_gui
{
    public partial class Form1 : Form
    {

        private QueueFiles que = new QueueFiles();

        public Form1()
        {
            InitializeComponent();
            if (que.isEmpty())
            {
                MessageBox.Show("The queue is empty");
                queListBox.Items.Add("The queue is empty");
                dequeBtn.Enabled = false;
                extensionComboBox.DataSource = Enum.GetValues(typeof(FileTypeExtension));
            }
        }

        private void btnCreateFile_Click(object sender, EventArgs e)
        {
            if (que.isEmpty()) queListBox.Items.Clear();
            DataFile file = new DataFile();
            queListBox.Items.Add(file.Dir());
            que.Enqueue(file);
            dequeBtn.Enabled = true;
        }

        private void btnCreateCustomFile_Click(object sender, EventArgs e)
        {
            queFunctions.Visible = false;
            customFileOptions.Visible = true;
            fileNameBox.Text = "";
            dataTextBox.Text = "";
        }

        private void dequeBtn_Click(object sender, EventArgs e)
        {
            que.Dequeue();
            queListBox.Items.Clear();
            updateListBox();
        }

        private void updateListBox()
        {
            if (que.isEmpty())
            {
                dequeBtn.Enabled = false;
                queListBox.Items.Add("The queue is empty");
            }
            else
            {
                queListBox.Items.Clear();
                queListBox.Items.AddRange(que.PrintQueue());
            }
        }

        private void createFileFromData_Click(object sender, EventArgs e) //fix changed combo box value event
        {
            DataFile file = new DataFile(fileNameBox.Text, dataTextBox.Text, (FileTypeExtension)extensionComboBox.SelectedItem);
            que.Enqueue(file);
            updateListBox();
            customFileOptions.Visible = false;
            queFunctions.Visible = true;
            dequeBtn.Enabled = true;
        }

        private void showByType_Click(object sender, EventArgs e)
        {
            queListBox.Items.Clear();
            int value = 0;
            if (radioButtonTXT.Checked is true) value = 1;
            else if (radioButtonDOC.Checked is true) value = 2;
            else if (radioButtonDOCX.Checked is true) value = 3;
            else if (radioButtonPDF.Checked is true) value = 4;
            else if (radioButtonPPTX.Checked is true) value = 5;
            else
            {
                if (que.isEmpty()) queListBox.Items.Add("The queue is empty");
                MessageBox.Show("No type selected");
            }
            foreach (DataFile item in que.SearchFileByType((FileTypeExtension)value))
            {
                queListBox.Items.Add(item.Dir());
            }
            if (queListBox.Items.Count == 0 && value != 0) queListBox.Items.Add($"No files of .{(FileTypeExtension)value} extension found");
        }

        private void showLargestFile_Click(object sender, EventArgs e)
        {
            queListBox.Items.Clear();
            if(que.isEmpty()) queListBox.Items.Add("The queue is empty");
            else queListBox.Items.Add(que.BigFile().Dir());
        }

        private void showAllQue_Click(object sender, EventArgs e)
        {
            queListBox.Items.Clear();
            updateListBox();
        }
    }
}