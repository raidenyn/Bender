﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Bender.Collections;
using NUnit.Framework;
using Should;
using Tests.Collections.Implementations;

namespace Tests.Collections
{
    [TestFixture]
    public class GenericListAdapterTests
    {
        private GenericListImpl<string> _list; 
        private IList _adapter;

        [SetUp]
        public void Setup()
        {
            _list = new GenericListImpl<string> { "oh", "hai" };
            _adapter = GenericListAdapter.Create(_list);
        }

        [Test]
        public void should_return_object_if_it_implements_ilist()
        {
            var list = new List<string>();
            GenericListAdapter.Create(list).ShouldBeSameAs(list);
        }

        [Test]
        public void should_fail_if_not_a_list()
        {
            Assert.Throws<ArgumentException>(() => GenericListAdapter.Create(new object()));
        }

        [Test]
        public void should_return_readonly_flag()
        {
            _adapter.IsReadOnly.ShouldBeFalse();
        }

        [Test]
        public void should_return_fixed_size_flag()
        {
            _adapter.IsFixedSize.ShouldBeFalse();
        }

        [Test]
        public void should_return_count()
        {
             _adapter.Count.ShouldEqual(2);
        }
        
        [Test]
        public void should_return_sync_flag()
        {
            _adapter.IsSynchronized.ShouldBeFalse();
        }

        [Test]
        public void should_return_sync_root()
        {
            _adapter.SyncRoot.ShouldEqual(_list);
        }

        [Test]
        public void should_return_value()
        {
            _adapter[0].ShouldEqual("oh");
            _adapter[1].ShouldEqual("hai");
        }

        [Test]
        public void should_return_index_of()
        {
            _adapter.IndexOf("oh").ShouldEqual(0);
            _adapter.IndexOf("hai").ShouldEqual(1);
            _adapter.IndexOf("orly").ShouldEqual(-1);
        }

        [Test]
        public void should_return_contains()
        {
            _adapter.Contains("oh").ShouldBeTrue();
            _adapter.Contains("hai").ShouldBeTrue();
            _adapter.Contains("orly").ShouldBeFalse();
        }

        [Test]
        public void should_add_item()
        {
            _adapter.Add("yo").ShouldEqual(2);
            _list.Count.ShouldEqual(3);
            _list[2].ShouldEqual("yo");
        }

        [Test]
        public void should_insert_item()
        {
            _adapter.Insert(1, "yo");
            _list.Count.ShouldEqual(3);
            _list[1].ShouldEqual("yo");
        }

        [Test]
        public void should_remove_item()
        {
            _adapter.Remove("hai");
            _list.Count.ShouldEqual(1);
            _list[0].ShouldEqual("oh");
        }

        [Test]
        public void should_remove_item_at()
        {
            _adapter.RemoveAt(1);
            _list.Count.ShouldEqual(1);
            _list[0].ShouldEqual("oh");
        }

        [Test]
        public void should_clear()
        {
            _adapter.Clear();
            _list.Count.ShouldEqual(0);
        }

        [Test]
        public void should_copy_to_array()
        {
            var array = new object[2];
            _adapter.CopyTo(array, 0);
            array[0].ShouldEqual("oh");
            array[1].ShouldEqual("hai");
        }

        [Test]
        public void should_enumerate()
        {
            var entries = _adapter.Cast<string>().ToList();
            entries[0].ShouldEqual("oh");
            entries[1].ShouldEqual("hai");
        }
    }
}
