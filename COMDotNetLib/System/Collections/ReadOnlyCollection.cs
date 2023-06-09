﻿using GSystem = global::System;
using System.Runtime.InteropServices;
using System.ComponentModel;

namespace DotNetLib.System.Collections
{

    [ComVisible(true)]
    [Description("Provides the base class for a generic read-only collection.")]
    [Guid("E4643BBE-74AF-467D-8DF3-06B681E93E4C")]
    [ProgId("DotNetLib.System.Collections.ReadOnlyCollection")]
    [ClassInterface(ClassInterfaceType.AutoDual)]

    public class ReadOnlyCollection : GSystem.Collections.ReadOnlyCollectionBase
    {

        public ReadOnlyCollection()
        {
        }

        public ReadOnlyCollection(GSystem.Collections.IList sourceList)
        {
            InnerList.AddRange(sourceList);
        }

        public ReadOnlyCollection Create(GSystem.Collections.IList sourceList)
        {
            return new ReadOnlyCollection(sourceList);
        }


        public object this[int index]
        {
            get
            {
                return (InnerList[index]);
            }
        }

        public int IndexOf(object value)
        {
            return (InnerList.IndexOf(value));
        }

        public bool Contains(object value)
        {
            return (InnerList.Contains(value));
        }

        public void CopyTo(object[] array, int index)
        { 
            InnerList.CopyTo(array, index);
        }

        public override GSystem.Collections.IEnumerator GetEnumerator()
        { 
            return InnerList.GetEnumerator(); 
        }

        public object[] ToArray()
        {
            return InnerList.ToArray();
        }
    }
}
