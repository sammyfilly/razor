// <auto-generated/>
#pragma warning disable 1591
namespace Test
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
    public class TestComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder builder)
        {
            __Blazor.Test.TestComponent.TypeInference.CreateMyComponent_0(builder, 0, 1, 
#nullable restore
#line 1 "x:\dir\subdir\Test\TestComponent.cshtml"
                     "hi"

#line default
#line hidden
#nullable disable
            , 2, (context) => (builder2) => {
                builder2.AddContent(3, 
#nullable restore
#line 2 "x:\dir\subdir\Test\TestComponent.cshtml"
                    context.ToLower()

#line default
#line hidden
#nullable disable
                );
            }
            , 4, (context) => (builder2) => {
                builder2.AddContent(5, 
#nullable restore
#line 3 "x:\dir\subdir\Test\TestComponent.cshtml"
                context

#line default
#line hidden
#nullable disable
                );
            }
            );
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.Test.TestComponent
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMyComponent_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder builder, int seq, int __seq0, TItem __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment<TItem> __arg1, int __seq2, global::Microsoft.AspNetCore.Components.RenderFragment<System.Int32> __arg2)
        {
        builder.OpenComponent<global::Test.MyComponent<TItem>>(seq);
        builder.AddAttribute(__seq0, "Item", __arg0);
        builder.AddAttribute(__seq1, "GenericFragment", __arg1);
        builder.AddAttribute(__seq2, "IntFragment", __arg2);
        builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
