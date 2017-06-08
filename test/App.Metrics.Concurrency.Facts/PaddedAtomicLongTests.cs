﻿using System.Runtime.InteropServices;
using FluentAssertions;
using Xunit;

namespace App.Metrics.Concurrency.Facts
{
    public class PaddedAtomicLongTests
    {
        private PaddedAtomicLong _num = new PaddedAtomicLong();

        [Fact]
        public void can_add_value()
        {
            _num.Add(7L).Should().Be(7L);
            _num.GetValue().Should().Be(7L);
        }

        [Fact]
        public void can_be_assigned()
        {
            _num.SetValue(10L);
            PaddedAtomicLong y = _num;
            y.GetValue().Should().Be(10L);
        }

        [Fact]
        public void can_be_created_with()
        {
            new PaddedAtomicLong(5L).GetValue().Should().Be(5L);
        }

        [Fact]
        public void can_be_decremented()
        {
            _num.Decrement().Should().Be(-1L);
            _num.GetValue().Should().Be(-1L);
        }

        [Fact]
        public void can_be_decremented_multiple_times()
        {
            _num.Decrement().Should().Be(-1L);
            _num.Decrement().Should().Be(-2L);
            _num.Decrement().Should().Be(-3L);

            _num.GetValue().Should().Be(-3L);
        }

        [Fact]
        public void can_be_incremented()
        {
            _num.Increment().Should().Be(1L);
            _num.GetValue().Should().Be(1L);
        }

        [Fact]
        public void can_be_incremented_multiple_times()
        {
            _num.Increment().Should().Be(1L);
            _num.GetValue().Should().Be(1L);

            _num.Increment().Should().Be(2L);
            _num.GetValue().Should().Be(2L);

            _num.Increment().Should().Be(3L);
            _num.GetValue().Should().Be(3L);
        }

        [Fact]
        public void can_compare_and_swap()
        {
            _num.SetValue(10L);

            _num.CompareAndSwap(5L, 11L).Should().Be(false);
            _num.GetValue().Should().Be(10L);

            _num.CompareAndSwap(10L, 11L).Should().Be(true);
            _num.GetValue().Should().Be(11L);
        }

        [Fact]
        public void can_get_and_add()
        {
            _num.SetValue(10L);
            _num.GetAndAdd(5L).Should().Be(10L);
            _num.GetValue().Should().Be(15L);
        }

        [Fact]
        public void can_get_and_decrement()
        {
            _num.SetValue(10L);

            _num.GetAndDecrement().Should().Be(10L);
            _num.GetValue().Should().Be(9L);

            _num.GetAndDecrement(5L).Should().Be(9L);
            _num.GetValue().Should().Be(4L);
        }

        [Fact]
        public void can_get_and_increment()
        {
            _num.SetValue(10L);

            _num.GetAndIncrement().Should().Be(10L);
            _num.GetValue().Should().Be(11L);

            _num.GetAndIncrement(5L).Should().Be(11L);
            _num.GetValue().Should().Be(16L);
        }

        [Fact]
        public void can_get_and_reset()
        {
            _num.SetValue(32);
            _num.GetAndReset().Should().Be(32);
            _num.GetValue().Should().Be(0);
        }

        [Fact]
        public void can_get_and_set()
        {
            _num.SetValue(32);
            _num.GetAndSet(64).Should().Be(32);
            _num.GetValue().Should().Be(64);
        }

        [Fact]
        public void can_set_and_read_value()
        {
            _num.SetValue(32);
            _num.GetValue().Should().Be(32);
        }

        [Fact]
        public void defaults_to_zero()
        {
            _num.GetValue().Should().Be(0L);
        }

        [Fact]
        public void should_have_correct_size()
        {
            PaddedAtomicLong.SizeInBytes.Should().Be(Marshal.SizeOf<PaddedAtomicLong>());
        }
    }
}