using DataAccess.ConctreteRepository;
using DataAccess.Context;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class Form1 : Form
    {
        private CodeFirstDbContext _codeFirstDbContext;
        private SchoolRepository _schoolRepository;
        private TeacherRepository _teacherRepository;
        public Form1()
        {
            _codeFirstDbContext = new CodeFirstDbContext(); //DbSetlerin oluşması için
            _schoolRepository = new SchoolRepository(_codeFirstDbContext);
            _teacherRepository = new TeacherRepository(_codeFirstDbContext);
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            School eklenecekOkul = new School();
            eklenecekOkul.Name = txtSchoolName.Text;
            eklenecekOkul.NumberOfEmploye = Convert.ToInt32(txtNumberOfEmploye.Text);
            eklenecekOkul.NumberOfStudent = Convert.ToInt32(txtNumberOfStudent.Text);

            _schoolRepository.Add(eklenecekOkul);
            Clear();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            dgwOkul.DataSource = _schoolRepository.GetAll();
        }

        int aranacakOkulID;
        
        private void dgwOkul_SelectionChanged(object sender, EventArgs e)
        {
            aranacakOkulID = Convert.ToInt32(dgwOkul.CurrentRow.Cells["ID"].Value); // İlk okulumID' si 1
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var silinecekOkul = _schoolRepository.GetById(aranacakOkulID);
            silinecekOkul.DeletedDate = DateTime.Now;
            _schoolRepository.Delete(silinecekOkul);
            dgwOkul.DataSource = _schoolRepository.GetAll();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            var guncellencekOkul = _schoolRepository.GetById(aranacakOkulID); //Okulu buldum!!

            guncellencekOkul.Name = txtSchoolName.Text;
            guncellencekOkul.NumberOfStudent = Convert.ToInt32(txtNumberOfStudent.Text);
            guncellencekOkul.NumberOfEmploye = Convert.ToInt32(txtNumberOfEmploye.Text);
            guncellencekOkul.ModifiedDate = DateTime.Now;
            guncellencekOkul.ModifiedBy = "Furkan Aydın";
            _schoolRepository.Update(guncellencekOkul);

            dgwOkul.DataSource = _schoolRepository.GetAll();
            Clear();
        }

        private void Clear()
        {
            foreach (var item in this.groupBox1.Controls)
            {
                if (item is TextBox)
                    ((TextBox)item).Text = " "; //group box içerisinde textboxların temizlenmesini sağlıyor.
            }
            foreach (var item in this.grpOgretmen.Controls)
            {
                if (item is TextBox)
                    ((TextBox)item).Text = " "; //group box içerisinde textboxların temizlenmesini sağlıyor.
            }
        }

        private void btnOgretmenEkle_Click(object sender, EventArgs e)
        {
            Teacher eklenecekOgretmen = new Teacher();
            eklenecekOgretmen.FirstName = txtOgretmenAdi.Text;
            eklenecekOgretmen.LastName = txtOgretmenSoyad.Text;
            eklenecekOgretmen.Wage = Convert.ToDecimal(txtOgretmenMaas.Text);
            if (rdbEvli.Checked)
                eklenecekOgretmen.Married = true;
            else
                eklenecekOgretmen.Married = false;
            eklenecekOgretmen.NumberOfStudent = Convert.ToInt32(txtOgrenciSayisi.Text);
            //Benim eklenen öğretmenimin hangi okulun öğretmeni olduğunu söyledim.
            eklenecekOgretmen.SchoolID = aranacakOkulID;

            _teacherRepository.Add(eklenecekOgretmen);
            Clear();
        }

        private void btnOgretmenListele_Click(object sender, EventArgs e)
        {
            dgwOgretmen.DataSource = _teacherRepository.GetAll();
        }

        private void btnOgretmenSil_Click(object sender, EventArgs e)
        {
            var silinecekOgretmen = _teacherRepository.GetById(aranacakOgretmenID);

            silinecekOgretmen.DeletedDate = DateTime.Now;
            silinecekOgretmen.DeletedBy = "Furkan Aydın";
            _teacherRepository.Delete(silinecekOgretmen);

            dgwOgretmen.DataSource = _teacherRepository.GetAll();
        }
        int aranacakOgretmenID; //DataGridView'de seçilen öğretmenin ID bilgisini tutacak
        private void dgwOgretmen_SelectionChanged(object sender, EventArgs e)
        {
            aranacakOgretmenID = Convert.ToInt32(dgwOgretmen.CurrentRow.Cells["ID"].Value);
        }

        private void btnOgretmenGuncelle_Click(object sender, EventArgs e)
        {
            var guncellenecekOgretmen = _teacherRepository.GetById(aranacakOgretmenID); //Öğretemeni buldum!!

            guncellenecekOgretmen.FirstName = txtOgretmenAdi.Text;

            guncellenecekOgretmen.LastName = txtOgretmenSoyad.Text;
            guncellenecekOgretmen.Wage = Convert.ToDecimal(txtOgretmenMaas.Text);
            if (rdbEvli.Checked)
                guncellenecekOgretmen.Married = true;
            else
                guncellenecekOgretmen.Married = false;
            guncellenecekOgretmen.NumberOfStudent = Convert.ToInt32(txtOgrenciSayisi.Text);
            _teacherRepository.Update(guncellenecekOgretmen);

            dgwOgretmen.DataSource = _teacherRepository.GetAll();
            Clear();
        }
    }
}
