using DepartmentSystemClient.DTO;
using DepartmentSystemClient.Enums;
using DepartmentSystemClient.Entities;
using DepartmentSystemClient.Filter;

namespace DepartmentSystemClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public ModEnum mod;
        private async void btnAddStudent_Click(object sender, EventArgs e)
        {
            //Edit
            if(mod == ModEnum.Editing && txtAddStudentNo.Text != "" && txtAddName.Text != "" && comboBoxPutDepartment.SelectedIndex != -1 && comboBoxPutGraduate.SelectedIndex != -1 && comboBoxPutGender.SelectedIndex != -1)
            {
                //Student student = new Student { id = 8, name = "ekle", department_id=1, graduate_id=1};
                EditStudentDTO student = new EditStudentDTO();
                student.Id = Int32.Parse(txtAddStudentNo.Text);
                student.Name = txtAddName.Text;
                //student.department_id = Int16.Parse(txtAddDepatmentId.Text);
                student.DepartmentId = int.Parse(comboBoxPutDepartment.SelectedValue.ToString());
                //student.graduate_id = Int16.Parse(txtAddGraduateId.Text);
                student.GraduateId = int.Parse(comboBoxPutGraduate.SelectedValue.ToString());
                student.Gender = (byte)comboBoxPutGender.SelectedValue;
                var url = await Methods.EditStudentAsync(student.Id, student);
                MessageBox.Show(url.Message);

            }
            //New save
            else if(txtAddStudentNo.Text != "" && txtAddName.Text != "" && comboBoxPutDepartment.SelectedIndex != -1 && comboBoxPutGraduate.SelectedIndex != -1 && comboBoxPutGender.SelectedIndex != -1)
            {
                CreateStudentDTO student = new CreateStudentDTO();
                student.Id = Int32.Parse(txtAddStudentNo.Text);
                student.Name = txtAddName.Text;
                //student.department_id = Int16.Parse(txtAddDepatmentId.Text);
                student.DepartmentId = int.Parse(comboBoxPutDepartment.SelectedValue.ToString());
                //student.graduate_id = Int16.Parse(txtAddGraduateId.Text);
                student.GraduateId = int.Parse(comboBoxPutGraduate.SelectedValue.ToString());
                student.Gender = (byte)comboBoxPutGender.SelectedValue;
                var url = await Methods.CreateStudentAsync(student);
                MessageBox.Show(url.Message);
            }
            else
            {
                MessageBox.Show("Please fill all required fields");
            }
            mod = ModEnum.AddNew;

            txtAddStudentNo.Text = "";
            txtAddName.Text = "";
            comboBoxPutDepartment.SelectedIndex = 0;
            comboBoxPutGraduate.SelectedIndex = 0;

        }

        private async void btnGetStudentList_Click(object sender, EventArgs e)
        {
            var url = await Methods.GetAllData();
            Methods.FillDataGridView(url, DGWStudentList);
            //DGWStudentList.DataSource = url;

            //DGWStudentList.Columns["department_id"].Visible = false;
            //DGWStudentList.Columns["graduate_id"].Visible = false;

        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            StudentFilter studentFilter = new StudentFilter();
            if(txtSearchId.Text != "")
            {
                studentFilter.Id = Int16.Parse(txtSearchId.Text);
            }
            if(txtSearchName.Text != "")
            {
                studentFilter.Name = txtSearchName.Text;
            }
            //if(txtSearchDepartmentId.Text != "")
            //{
            //    studentFilter.DepartmentId = Int16.Parse(txtSearchDepartmentId.Text);
            //}
            if( comboBoxDepartment.SelectedIndex != 0 || comboBoxDepartment.SelectedIndex != -1)      
            {
                studentFilter.DepartmentId = int.Parse(comboBoxDepartment.SelectedValue.ToString());
            }

            if (comboBoxSearchGraduate.SelectedIndex != 0 || comboBoxSearchGraduate.SelectedIndex != -1)
            {
                studentFilter.GraduateId = int.Parse(comboBoxSearchGraduate.SelectedValue.ToString());
            }


            //if (txtSearchGraduateId.Text != "")
            //{
            //    studentFilter.GraduateId = Int16.Parse(txtSearchGraduateId.Text);
            //}

            //studentFilter.Gender = (byte)comboBoxSearchGender.Text;
            //Gender enum = (Gender)comboBoxSearchGender.SelectedItem;
            studentFilter.Gender = (byte)comboBoxSearchGender.SelectedValue;
             
            //var url = await Methods.GetBySearch(studentFilter);
            try
            {
                var url = await Methods.GetBySearchTestDTO(studentFilter);
                if(url.Status == true)
                {
                    Methods.FillDataGridView(url.Data, DGWStudentList);
                }
                else
                {
                    MessageBox.Show(url.Message);
                }
            }
            catch (Exception ex)
            {
                return;
            }

            //DGWStudentList.Columns.Remove("department_id");
            //DGWStudentList.Columns.Remove("graduate_id");
            

            //DGWStudentList.DataSource = url;



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void Form1_Load(object sender, EventArgs e)
        {

            //comboBoxDepartment.DataSource = departments;
            //comboBoxDepartment.Items.Add(departments);
            //comboBoxDepartment.Items.Add("Computer Science");
            //comboBoxDepartment.Items.Add("Mathematic Science");
            FillComboboxDepartment(comboBoxDepartment);
            FillComboboxGraduate(comboBoxSearchGraduate);
            FillComboboxGender(comboBoxSearchGender, "search");

            FillCreateComboboxDepartment(comboBoxPutDepartment);
            FillCreateComboboxGraduate(comboBoxPutGraduate);
            FillCreateComboboxGender(comboBoxPutGender);

            //FillComboboxDepartment(comboBoxPutDepartment);
            //FillComboboxGraduate(comboBoxPutGraduate);
        }
        private async Task FillCreateComboboxDepartment(ComboBox comboBox)
        {
            var departments = await Methods.GetAllDepartments();

            comboBox.DataSource = departments;

            //var allOption = new Graduate();
            //allOption.id = 0;
            //allOption.name = "Select a department";
            //departments.Insert(0, allOption);

            comboBox.DisplayMember = "Name";
            comboBox.ValueMember = "Id";
            comboBox.SelectedIndex = -1;
            comboBox.Text = "Select a department";
        }
        private async Task FillCreateComboboxGraduate(ComboBox comboBox)
        {
            var graduates = await Methods.GetAllGraduates();

            comboBox.DataSource = graduates;

            //var allOption = new Graduate();
            //allOption.id = 0;
            //allOption.name = "Select a graduate";
            //graduates.Insert(0, allOption);

            comboBox.DisplayMember = "Name";
            comboBox.ValueMember = "Id";
            comboBox.SelectedIndex = -1;

            comboBox.Text = "Select a graduate";
        }
        private async Task FillCreateComboboxGender(ComboBox comboBox)
        {
            var genderDictionary = await Methods.GetGender("add");
            comboBox.DataSource = new BindingSource(genderDictionary, null);
            comboBox.DisplayMember = "Key";
            comboBox.ValueMember = "Value";
            comboBox.SelectedIndex = -1;

            comboBox.Text = "Select a gender";
        }
        private async Task FillComboboxGender(ComboBox comboBox, string type)
        {

            //comboBox.Items.Add("All");
            //comboBox.Items.Add("Male");
            //comboBox.Items.Add("Female");
            //comboBox.SelectedIndex = 0;

            //comboBox.DataSource = Methods.GetGender();
            //Dictionary<string, int> a = new Dictionary<string, int>();
            var a = await Methods.GetGender(type);
            comboBox.DataSource = a;
            /// comboBox.DataSource = new BindingSource(genderDictionary, null);
            comboBox.DisplayMember = "Key";
            comboBox.ValueMember = "Value";

            //var genderDictionary = await Methods.GetGender();
            //comboBox.DataSource = new BindingSource(genderDictionary, null);
            //comboBox.DisplayMember = "Key";
            //comboBox.ValueMember = "Value";

            //comboBox.DataSource = Enum.GetValues(typeof(Gender));
            //comboBox.SelectedIndex = 2;

            //comboBox.DisplayMember = "Text";
            //comboBox.ValueMember = "Value";

            //var items = new[] {
            //    new { Text = "All", Value = "null" },
            //    new { Text = "Male", Value = "0" },
            //    new { Text = "Female", Value = "1" },
            //};

            //comboBox.DataSource = items;

        }
        private async Task FillComboboxGraduate(ComboBox comboBox)
        {
            var graduates = await Methods.GetAllGraduates();

            comboBox.DataSource = graduates;

            var allOption = new Graduate();
            allOption.id = 0;
            allOption.name = "All";
            graduates.Insert(0, allOption);

            comboBox.DisplayMember = "Name";
            comboBox.ValueMember = "Id";
            //comboBox.Text = "Select a department";


        }
        private async Task FillComboboxDepartment(ComboBox comboBox)
        {
            var departments = await Methods.GetAllDepartments();
            comboBox.DataSource = departments;

            var allOption = new Department();
            allOption.id = 0;
            allOption.name = "All";
            departments.Insert(0, allOption);

            comboBox.DisplayMember = "Name";
            comboBox.ValueMember = "Id";
            //comboBox.Text = "Select a department";
        }
        //private async void FillComboboxDepartment()
        //{
        //    var departments = await Methods.GetAllDepartments();
        //    comboBoxDepartment.DataSource = departments;

        //    var allOption = new Department();
        //    allOption.id = 0;
        //    allOption.name = "All";
        //    departments.Insert(0, allOption);

        //    comboBoxDepartment.DisplayMember = "Name";
        //    comboBoxDepartment.ValueMember = "Id";
        //    comboBoxDepartment.Text = "Select a department";

        //}

        private async void DGWStudentList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            mod = ModEnum.Editing;

            StudentDTO studentDTO = (StudentDTO)DGWStudentList.CurrentRow.DataBoundItem;
            txtAddStudentNo.Text = studentDTO.id.ToString();
            txtAddName.Text = studentDTO.name;
            //await FillComboboxDepartment(comboBoxPutDepartment);
            comboBoxPutDepartment.Text = studentDTO.departmentName.ToString();
            //await FillComboboxGraduate(comboBoxPutGraduate);
            comboBoxPutGraduate.Text = studentDTO.graduateName.ToString();
            comboBoxPutGender.Text = studentDTO.gender.ToString();

        }

        private async void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.id = int.Parse(txtAddStudentNo.Text);
            try
            {
                var url = await Methods.DeleteStudentAsync(student.id);
                MessageBox.Show(url.Message);
            }
            catch (Exception ex)
            {

                return;
            }
        }

        private void btnNewStudent_Click(object sender, EventArgs e)
        {
            mod = ModEnum.AddNew;

            txtAddStudentNo.Text = "";
            txtAddName.Text = "";

            //comboBoxPutDepartment.SelectedIndex = 0;
            //comboBoxPutGraduate.SelectedIndex = 0;
            comboBoxPutDepartment.Text = "Select a department";
            comboBoxPutGraduate.Text = "Select a graduate";
            comboBoxPutGender.Text = "Select a gender";


            //comboBoxPutDepartment.DataSource = null;
            

        }

        private void comboBoxSearchGraduate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSearchGraduateId_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAddGraduateId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}