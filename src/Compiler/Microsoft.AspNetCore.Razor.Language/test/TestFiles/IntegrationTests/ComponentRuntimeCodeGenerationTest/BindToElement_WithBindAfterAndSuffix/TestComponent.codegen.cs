﻿// <auto-generated/>
#pragma warning disable 1591
namespace Test
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
    public partial class TestComponent : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "myvalue", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 1 "x:\dir\subdir\Test\TestComponent.cshtml"
                     ParentValue

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "myevent", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredBindSetter(callback: __value => { ParentValue = __value; return global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.InvokeAsynchronousDelegate(callback: 
#nullable restore
#line 1 "x:\dir\subdir\Test\TestComponent.cshtml"
                                                       DoSomething

#line default
#line hidden
#nullable disable
            ); }, value: ParentValue), ParentValue));
            __builder.SetUpdatesAttributeName("myvalue");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 3 "x:\dir\subdir\Test\TestComponent.cshtml"
       
    public string ParentValue { get; set; } = "hi";

    Task DoSomething()
    {
        return Task.CompletedTask;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
