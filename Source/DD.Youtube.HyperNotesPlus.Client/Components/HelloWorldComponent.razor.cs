using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DD.Youtube.HyperNotesPlus.Client.Components
{
    public class HelloWorldComponentBase : ComponentBase
    {

        protected string title = "Hello, world!";
        protected int contador = 0;


        protected void IncreaseCounter()
        {
            contador++;
        }

    }
}
