#pragma checksum "C:\CST-TERM-4\4870\ServerBlazorEF\Pages\CreateStudents.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "077ac1b97732a19eff416abf74fd69d31ebface0"
// <auto-generated/>
#pragma warning disable 1591
namespace ServerBlazorEF.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\CST-TERM-4\4870\ServerBlazorEF\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\CST-TERM-4\4870\ServerBlazorEF\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\CST-TERM-4\4870\ServerBlazorEF\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\CST-TERM-4\4870\ServerBlazorEF\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\CST-TERM-4\4870\ServerBlazorEF\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\CST-TERM-4\4870\ServerBlazorEF\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\CST-TERM-4\4870\ServerBlazorEF\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\CST-TERM-4\4870\ServerBlazorEF\_Imports.razor"
using ServerBlazorEF;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\CST-TERM-4\4870\ServerBlazorEF\_Imports.razor"
using ServerBlazorEF.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\CST-TERM-4\4870\ServerBlazorEF\Pages\CreateStudents.razor"
using ServerBlazorEF.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\CST-TERM-4\4870\ServerBlazorEF\Pages\CreateStudents.razor"
using ServerBlazorEF.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/createStudents")]
    public partial class CreateStudents : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Create Students</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>This component demonstrates creating a student data.</p>\r\n\r\n");
            __builder.OpenElement(2, "button");
            __builder.AddAttribute(3, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "C:\CST-TERM-4\4870\ServerBlazorEF\Pages\CreateStudents.razor"
                   Add

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "class", "btn btn-success");
            __builder.AddContent(5, "Add");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n\r\n");
#nullable restore
#line 11 "C:\CST-TERM-4\4870\ServerBlazorEF\Pages\CreateStudents.razor"
 if (students != null && mode==MODE.Add) // Insert form 
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(7, "  ");
            __builder.OpenElement(8, "input");
            __builder.AddAttribute(9, "placeholder", "First Name");
            __builder.AddAttribute(10, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 13 "C:\CST-TERM-4\4870\ServerBlazorEF\Pages\CreateStudents.razor"
                                          firstName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => firstName = __value, firstName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "<br>\r\n  ");
            __builder.OpenElement(13, "input");
            __builder.AddAttribute(14, "placeholder", "Last Name");
            __builder.AddAttribute(15, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "C:\CST-TERM-4\4870\ServerBlazorEF\Pages\CreateStudents.razor"
                                         lastName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => lastName = __value, lastName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "<br>\r\n  ");
            __builder.OpenElement(18, "input");
            __builder.AddAttribute(19, "placeholder", "School");
            __builder.AddAttribute(20, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 15 "C:\CST-TERM-4\4870\ServerBlazorEF\Pages\CreateStudents.razor"
                                      school

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => school = __value, school));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "<br>\r\n  ");
            __builder.OpenElement(23, "button");
            __builder.AddAttribute(24, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "C:\CST-TERM-4\4870\ServerBlazorEF\Pages\CreateStudents.razor"
                     Insert

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "class", "btn btn-warning");
            __builder.AddContent(26, "Insert");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n");
#nullable restore
#line 17 "C:\CST-TERM-4\4870\ServerBlazorEF\Pages\CreateStudents.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 19 "C:\CST-TERM-4\4870\ServerBlazorEF\Pages\CreateStudents.razor"
       
  List<Student> students;

  string studentId;
  string firstName;
  string lastName;
  string school;
	private enum MODE { None, Add, EditDelete };
	MODE mode = MODE.None;
	Student student;


  protected override async Task OnInitializedAsync() {
    await load();
  }

  protected async Task load() {
    students = await studentService.GetStudentsAsync();
  }
	protected async Task Insert() {

  Student s = new Student() {
    StudentId = Guid.NewGuid().ToString(),
    FirstName = firstName,
    LastName = lastName,
    School = school
  };
	
	await studentService.InsertStudentAsync(s);
		ClearFields();
		await load();
	}

	protected void ClearFields() {
		studentId = string.Empty;
		firstName = string.Empty;
		lastName = string.Empty;
		school = string.Empty;
	}
	protected void Add() { 
		ClearFields();
		mode = MODE.Add;
	}

	protected async Task Update() {

  Student s = new Student() {
    StudentId = studentId,
    FirstName = firstName,
    LastName = lastName,
    School = school
  };

		await studentService.UpdateStudentAsync(studentId, s);
		ClearFields();
		await load();
		mode = MODE.None;
	}

	protected async Task Delete() {
		await studentService.DeleteStudentAsync(studentId);
		ClearFields();
		await load();
		mode = MODE.None;
	}

	protected async Task Show(string id) {
		student = await studentService.GetStudentByIdAsync(id);
		studentId = student.StudentId;
		firstName = student.FirstName;
		lastName = student.LastName;
		school = student.School;
		mode = MODE.EditDelete;
	}




#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private StudentService studentService { get; set; }
    }
}
#pragma warning restore 1591