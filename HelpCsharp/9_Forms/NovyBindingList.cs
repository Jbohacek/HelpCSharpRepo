using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Forms
{
    internal class NovyBindingList : IListSource
    {
        private BindingList<User> data = new BindingList<User>();

        public IList GetList()
        {
            return data;
        }

        public bool ContainsListCollection { get; } = true;
    }
}
