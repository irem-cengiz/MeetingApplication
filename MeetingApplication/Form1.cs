using MeetingApplication.Context;
using MeetingApplication.Entities;
using System.Windows.Forms;
using MeetingApplication.Entities;
using System;

namespace MeetingApplication
{
    public partial class Form1 : Form
    {
        MeetingDbContext _db;

        public Form1()
        {
            InitializeComponent();
            _db = new MeetingDbContext();
            Listele();
            UpdateMeetingComboBox();
            Listele2();
            Listele3();

        }

        private void UpdateMeetingComboBox()
        {
            cmbmeeting.DataSource = _db.Meetings.ToList();
            cmbmeeting.DisplayMember = "MeetingName";
            cmbmeeting.ValueMember = "Id";
        }
        private void btnMeetingEkle_Click(object sender, EventArgs e)
        {
            {
                string meetingName = txtmName.Text;

                bool existingMeeting = _db.Meetings.Any(m => m.MeetingName == meetingName);
                if (existingMeeting)
                {
                    MessageBox.Show("Bu isme sahip bir toplant� zaten mevcut!");
                    return;
                }

                Meeting meeting = new Meeting() { MeetingName = meetingName };
                _db.Meetings.Add(meeting);
                _db.SaveChanges();

                string secilenPlatform = cmbPlatform.SelectedItem.ToString();
                MeetingPlatform platform = new MeetingPlatform { MeetingPlatformName = secilenPlatform };

                _db.MeetingPlatforms.Add(platform);
                _db.SaveChanges();
                meeting.MeetingPlatform = platform;

                dgvMeeting.DataSource = _db.Meetings.ToList();

                string secilenKonu = cmbtopic.SelectedItem.ToString();
                MeetingSubject subject = new MeetingSubject() { MeetingSubjectName = secilenKonu };

                _db.MeetingSubjects.Add(subject);
                _db.SaveChanges();
                meeting.MeetingSubject = subject;

                dgvMeeting.DataSource = _db.MeetingSubjects.ToList();
                Listele();
                Listele2();
                Listele3();
                UpdateMeetingComboBox();

            }

        }
        private void Listele3()
        {
            dgvReport.DataSource = _db.MeetingReports.ToList();
        }

        private void Listele2()
        {
            dgvKisiler.DataSource = _db.MeetingPersons.ToList();
        }
        private void Listele()
        {
            dgvMeeting.DataSource = _db.Meetings.ToList();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvMeeting.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dgvMeeting.SelectedRows[0].Index;
                int meetingId = (int)dgvMeeting.Rows[selectedRowIndex].Cells["Id"].Value;

                // G�ncelleme yap�lacak toplant�y� veritaban�ndan al
                Meeting selectedMeeting = _db.Meetings.FirstOrDefault(m => m.Id == meetingId);
                if (selectedMeeting != null)
                {
                    // Yeni ad� al
                    string newMeetingName = txtmName.Text;

                    // De�i�iklikleri yap
                    selectedMeeting.MeetingName = newMeetingName;

                    // Veritaban�na kaydet
                    _db.SaveChanges();

                    // DataGridView'i g�ncelle
                    dgvMeeting.DataSource = _db.Meetings.ToList();
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvMeeting.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvMeeting.SelectedRows[0];
                int meetingId = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                Meeting meetingToDelete = _db.Meetings.Find(meetingId);
                _db.Meetings.Remove(meetingToDelete);
                _db.SaveChanges();
                dgvMeeting.DataSource = _db.Meetings.ToList();
            }
            else
            {
                MessageBox.Show("L�tfen silmek istedi�iniz toplant�y� se�in.", "Uyar�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnRaporEkle_Click(object sender, EventArgs e)
        {
            string content = txtRc.Text;
            int meetingId = int.Parse(txtrId.Text);

            // �lgili toplant�y� veritaban�ndan al
            Meeting meeting = _db.Meetings.FirstOrDefault(m => m.Id == meetingId);

            if (meeting != null)
            {
                // Yeni bir Metting Report olu�tur
                MeetingReport mettingReport = new MeetingReport
                {
                    Content = content,
                    Meeting = meeting
                };

                // Metting Report'u veritaban�na ekle
                _db.MeetingReports.Add(mettingReport);
                _db.SaveChanges();

                // DataGridView'i g�ncelle
                dgvReport.DataSource = _db.MeetingReports.ToList();
            }
            else
            {
                // Hata durumunda mesaj g�ster
                MessageBox.Show("Belirtilen Meeting ID ile e�le�en bir toplant� bulunamad�.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRaporSil_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = dgvReport.SelectedCells[0].RowIndex;
            MeetingReport selectedReport = (MeetingReport)dgvReport.Rows[selectedRowIndex].DataBoundItem;
            _db.MeetingReports.Remove(selectedReport);
            _db.SaveChanges();
            dgvReport.DataSource = _db.MeetingReports.ToList();
        }

        private void btnRaporGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvReport.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dgvReport.SelectedRows[0].Index;
                int reportId = (int)dgvReport.Rows[selectedRowIndex].Cells["Id"].Value;

                // G�ncelleme yap�lacak raporu veritaban�ndan al
                MeetingReport selectedReport = _db.MeetingReports.FirstOrDefault(r => r.Id == reportId);
                if (selectedReport != null)
                {
                    // Yeni report id al
                    string newReportContent = (txtRc.Text);

                    // De�i�iklikleri yap
                    selectedReport.Content = newReportContent;

                    // Veritaban�na kaydet
                    _db.SaveChanges();

                    // DataGridView'i g�ncelle
                    dgvReport.DataSource = _db.MeetingReports.ToList();
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedSort = cmbSiralameeting.SelectedItem.ToString();

            List<Meeting> sortedMeetings = new List<Meeting>();
            switch (selectedSort)
            {
                case "MeetingName":
                    sortedMeetings = _db.Meetings.OrderBy(m => m.MeetingName).ToList();
                    break;
                case "Id(Azalan)":
                    sortedMeetings = _db.Meetings.OrderByDescending(m => m.Id).ToList();
                    break;
                case "Id(Artan)":
                    sortedMeetings = _db.Meetings.OrderBy(m => m.Id).ToList();
                    break;

                default:

                    sortedMeetings = _db.Meetings.ToList();
                    break;
            }

            dgvMeeting.DataSource = sortedMeetings;
        }

        private void cmbSirallamaReport_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedsortreport = cmbSirallamaReport.SelectedItem.ToString();
            List<MeetingReport> sortedReport = new List<MeetingReport>();
            switch (selectedsortreport)
            {
                case "Id":
                    sortedReport = _db.MeetingReports.OrderBy(m => m.Id).ToList();
                    break;
                case "Content":
                    sortedReport = _db.MeetingReports.OrderByDescending(m => m.Content).ToList();
                    break;
                case "Meeting":
                    sortedReport = _db.MeetingReports.OrderByDescending(m => m.Meeting).ToList();
                    break;

                default:

                    sortedReport = _db.MeetingReports.ToList();
                    break;
            }

            dgvReport.DataSource = sortedReport;
        }


        private void btn�nsanEkle_Click(object sender, EventArgs e)
        {
            string tcno = txtTcNo.Text;
            string firstname = txtAd.Text;
            string lastname = txtSoyad.Text;

            Meeting selectedMeeting = (Meeting)cmbmeeting.SelectedItem;

            Person person = new Person
            {
                TcNo = tcno,
                FirstName = firstname,
                LastName = lastname
            };

            MeetingPerson meetingPerson = new MeetingPerson
            {
                TcNo = tcno,
                Person = person,
                Meeting = selectedMeeting
            };

            _db.MeetingPersons.Add(meetingPerson);
            _db.SaveChanges();

            dgvKisiler.DataSource = selectedMeeting.MeetingPersons.ToList();
            Listele2();
        }

        private void btn�nsanSil_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = dgvKisiler.SelectedCells[0].RowIndex;
            MeetingPerson selectedperson = (MeetingPerson)dgvKisiler.Rows[selectedRowIndex].DataBoundItem;
            _db.MeetingPersons.Remove(selectedperson);
            _db.SaveChanges();
            dgvKisiler.DataSource = _db.MeetingPersons.ToList();
        }

        private void dgvMeeting_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}