using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueAndRef_Demo
{
    public partial class Example : Component
    {
        public Example()
        {
            InitializeComponent();
        }

        public Example(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
