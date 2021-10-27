// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace SyncfutionTest.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Work\SyncfutionTest\SyncfutionTest\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Work\SyncfutionTest\SyncfutionTest\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Work\SyncfutionTest\SyncfutionTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Work\SyncfutionTest\SyncfutionTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Work\SyncfutionTest\SyncfutionTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Work\SyncfutionTest\SyncfutionTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Work\SyncfutionTest\SyncfutionTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Work\SyncfutionTest\SyncfutionTest\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Work\SyncfutionTest\SyncfutionTest\_Imports.razor"
using SyncfutionTest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Work\SyncfutionTest\SyncfutionTest\_Imports.razor"
using SyncfutionTest.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 469 "C:\Work\SyncfutionTest\SyncfutionTest\Pages\Gantt.razor"
using Syncfusion.Blazor.Gantt;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/gantt")]
    public partial class Gantt : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 478 "C:\Work\SyncfutionTest\SyncfutionTest\Pages\Gantt.razor"
      
    public List<TaskData> TaskCollection { get; set; }

    protected override void OnInitialized()
    {
        this.TaskCollection = GetTaskCollection();
    }

    public void OnActionComplete(GanttActionEventArgs<TaskData> args)
    {
        if (args.Action == "Add")
        {
            Console.WriteLine(args.Data.ParentId);
        }
    }

    public class TaskData
    {
        public int TaskId { get; set; }
        public string TaskName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Duration { get; set; }
        public double Progress { get; set; }
        public string Predecessor { get; set; }
        public int? ParentId { get; set; }
    }

    public static List<TaskData> GetTaskCollection()
    {
        List<TaskData> Tasks = new List<TaskData>()
        {
            new TaskData()
            {
                TaskId = 1,
                TaskName = "Project initiation",
                StartDate = new DateTime(2019, 04, 02),
                EndDate = new DateTime(2019, 04, 21)
            }
        };
        return Tasks;
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
