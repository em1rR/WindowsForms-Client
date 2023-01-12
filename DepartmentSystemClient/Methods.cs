using DepartmentSystemClient.ComboBoxModel;
using DepartmentSystemClient.DTO;
using DepartmentSystemClient.Entities;
using DepartmentSystemClient.Filter;
using DepartmentSystemClient.GenericDTO;
using Microsoft.AspNetCore.WebUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace DepartmentSystemClient
{
    public class Methods
    {
        static public HttpClient ClientAddress()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7275");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            return client;
        }

        static async public Task<ApiResponse<CreateStudentDTO>> CreateStudentAsync(CreateStudentDTO student)
        {
            try
            {

                var client = ClientAddress();

                HttpResponseMessage response = await client.PostAsJsonAsync("api/App/Student/Post", student);
                var apiResponse = await response.Content.ReadFromJsonAsync<ApiResponse<CreateStudentDTO>>();
                return apiResponse;
                //response.EnsureSuccessStatusCode();

                //return response.Headers.Location;
            }
            catch (Exception exp)
            {

                throw;
            }
            
            //return client.BaseAddress;
        }

        static async public Task<ApiResponse<EditStudentDTO>> EditStudentAsync(int id, EditStudentDTO student)
        {
            try
            {

                var client = ClientAddress();

                string url = "api/App/Student/Put";

                //string queryString = GetQueryString(id);
                //string queryString = GetQueryString(student);
                //url = QueryHelpers.AddQueryString(url, queryString);
                //var uri = String.Concat(url, queryString);
                //var response = await client.PutAsJsonAsync(uri, student);

                HttpResponseMessage response = await client.PutAsJsonAsync(url + id, student);
                //ApiResponse<EditStudentDTO> response = await client.PutAsJsonAsync(url + id, student);

                //HttpResponseMessage response = await client.PutAsJsonAsync("api/App/Student/Put{id}", id, student);
                var apiResponse = new ApiResponse<EditStudentDTO>();
                apiResponse = await response.Content.ReadFromJsonAsync<ApiResponse<EditStudentDTO>>();


                return apiResponse;
                //return response.Headers.Location;
            }
            catch (Exception exp)
            {

                return null;
            }

            //return client.BaseAddress;
        }
        //Delete
        static async public Task<ApiResponse<Student>> DeleteStudentAsync(int id)
        {
            try
            {

                var client = ClientAddress();

                HttpResponseMessage response = await client.DeleteAsync("api/App/Student/Delete" + id);
                var apiResponse = await response.Content.ReadFromJsonAsync<ApiResponse<Student>>();
                return apiResponse;
                //response.EnsureSuccessStatusCode();

                //return response.Headers.Location;
            }
            catch (Exception exp)
            {

                throw;
            }

            //return client.BaseAddress;
        }

        //static async public Task<List<Student>> GetAllData()
        static async public Task<List<StudentDTO>> GetAllData()
        {
            var students = new List<Student>();
            //List<Student> students = null;
            var client = ClientAddress();

           


            HttpResponseMessage response = await client.GetAsync("api/App/StudentDto/Get");
            //HttpResponseMessage response = await client.GetAsync("api/App/Student/Get");


            //students = response.Content.ReadAsAsync<List<Student>>();
            //students = await response.Content.ReadFromJsonAsync<List<Student>>();
            //return students;
            var studentstest = new List<StudentDTO>();
            studentstest = await response.Content.ReadFromJsonAsync<List<StudentDTO>>();
            return studentstest;
        }

        static async public Task<List<Student>> GetBySearch(StudentFilter studentFilter)
        {

            var students = new List<Student>();
            //List<Student> students = null;
            var client = ClientAddress();
            string url = "api/App/Student/GetBySearch";
            
            if (studentFilter.Name == null)
                studentFilter.Name = "q";
            string queryString = GetQueryString(studentFilter);
            //url = QueryHelpers.AddQueryString(url, queryString);
            var uri = String.Concat(url, queryString);
            var response = await client.GetAsync(uri);

            //students = response.Content.ReadAsAsync<List<Student>>();
            try
            {
                students = await response.Content.ReadFromJsonAsync<List<Student>>();
               //var resp =  await response.Content.ReadAsStringAsync();

            }
            catch (Exception ex)
            {

                throw;
            }
            //students = new List<Student>();
            //students.Add(resp);
            return students;
        }
        //static async public Task<List<StudentDTO>> GetBySearchTestDTO(StudentFilter studentFilter)

        static async public Task<ApiResponse<List<StudentDTO>>> GetBySearchTestDTO(StudentFilter studentFilter)
        {

            //var students = new List<StudentDTO>();
            var students = new ApiResponse<List<StudentDTO>>();
            //List<Student> students = null;
            var client = ClientAddress();
            string url = "api/App/Student/GetBySearchTest";

            if (studentFilter.Name == null)
                studentFilter.Name = "q";
            string queryString = GetQueryString(studentFilter);
            //url = QueryHelpers.AddQueryString(url, queryString);
            var uri = String.Concat(url, queryString);
            HttpResponseMessage response = await client.GetAsync(uri);

            //students = response.Content.ReadAsAsync<List<Student>>();
            students = await response.Content.ReadFromJsonAsync<ApiResponse<List<StudentDTO>>>();

            return students;
        }


        static async public Task<List<Student>> GetBySearchTest(StudentFilter studentFilter)
        {

            var students = new List<Student>();
            //List<Student> students = null;
            var client = ClientAddress();
            string url = "api/App/Student/GetBySearch";
            string q = "qwe";

            //url = string.Format("api/App/Student/Get/id={0}&type={1}", q, q);

            var asd = studentFilter;
            var query = new Dictionary<string, string>
            {
                ["id"] = studentFilter.Id.ToString(),
                ["name"] = studentFilter.Name,
                ["department_id"] = studentFilter.DepartmentId.ToString(),
                ["graduate_id"] = studentFilter.GraduateId.ToString(),
                // ...
            };
            //var response = await client.GetAsync(QueryHelpers.AddQueryString(url, query));

            url = QueryHelpers.AddQueryString(url, query);
            //url = QueryHelpers.a
            // Usage:
            string queryString = GetQueryString(studentFilter);
            //url = QueryHelpers.AddQueryString(url, queryString);
            //url = QueryHelpers.AddQueryString(url, queryString);


            HttpResponseMessage response = await client.GetAsync(url);

            //students = response.Content.ReadAsAsync<List<Student>>();
            try
            {
                students = await response.Content.ReadFromJsonAsync<List<Student>>();

            }
            catch (Exception ex)
            {

                throw;
            }
            return students;
        }


        static string GetQueryString(object obj)
        {
            var properties = from p in obj.GetType().GetProperties()
                             where p.GetValue(obj, null) != null
                             select p.Name + "=" + HttpUtility.UrlEncode(p.GetValue(obj, null).ToString());

            return "?" + String.Join("&", properties.ToArray());
        }


        static async public Task<List<Department>> GetAllDepartments()
        {
            var departments = new List<Department>();
            //List<Student> students = null;
            var client = ClientAddress();




            HttpResponseMessage response = await client.GetAsync("api/App/Department/Get");

            //students = response.Content.ReadAsAsync<List<Student>>();
            departments = await response.Content.ReadFromJsonAsync<List<Department>>();
            return departments;
        }

        static async public Task<List<Graduate>> GetAllGraduates()
        {
            var graduates = new List<Graduate>();
            //List<Student> students = null;
            var client = ClientAddress();




            HttpResponseMessage response = await client.GetAsync("api/App/Graduate/Get");

            //students = response.Content.ReadAsAsync<List<Student>>();
            graduates = await response.Content.ReadFromJsonAsync<List<Graduate>>();
            return graduates;
        }

        static async public Task<List<DropDownGenderModel>> GetGender(string type)
        {
            //var genderDictionary = new List<DropDownGenderModel>();
            ////List<Student> students = null;
            //var client = ClientAddress();

            //try
            //{
            //    HttpResponseMessage response = await client.GetAsync("api/App/Gender/Get");

            //    //students = response.Content.ReadAsAsync<List<Student>>();
            //    genderDictionary = await response.Content.ReadFromJsonAsync<List<DropDownGenderModel>>();
            //    return genderDictionary;
            //}
            //catch (Exception ex)
            //{

            //    return new List<DropDownGenderModel>();
            //}

            var genderDictionary = new List<DropDownGenderModel>();
            //List<Student> students = null;
            var client = ClientAddress();
            string url = "api/App/Gender/Get";
            //var query = GetQueryString(type);
            var uri = String.Concat(url, $"?type={type}");    
            var response = await client.GetAsync(uri);

            try
            {
                genderDictionary = await response.Content.ReadFromJsonAsync<List<DropDownGenderModel>>();
                return genderDictionary;

            }
            catch (Exception ex)
            {

                return new List<DropDownGenderModel>();
            }
           
        }

        static public void FillDataGridView(List<StudentDTO> studentDTOs, DataGridView dataGridView)
        {
            dataGridView.DataSource = studentDTOs;

            dataGridView.Columns["department_id"].Visible = false;
            dataGridView.Columns["graduate_id"].Visible = false;
        }

    }
}
