﻿using FluentAssertions;
using System;
using System.Threading.Tasks;
using Xunit;

namespace Functional.Unions.FluentAssertions.Tests
{
	public partial class UnionValueTypeAssertionsTests
	{
		public class TaskAdHocWithTwoTypes
		{
			[Fact]
			public void When_EqualityIsTrue_Then_ShouldNotThrowException() => new Func<Task>(() =>
				Task.FromResult(Union.FromTypes<ClassOne, ClassTwo>().Create(ModelTwo)).Value().Should().Be(Union.FromTypes<ClassOne, ClassTwo>().Create(ModelTwo).Value())
			).Should().NotThrow();

			[Fact]
			public void When_EqualityIsFalse_Then_ShouldThrowException() => new Func<Task>(() =>
				Task.FromResult(Union.FromTypes<ClassOne, ClassTwo>().Create(ModelTwo)).Value().Should().Be(Union.FromTypes<ClassOne, ClassTwo>().Create(new ClassTwo()).Value())
			).Should().Throw<Exception>();

			[Fact]
			public void When_TypeIsOneAndExpectedTypeIsOne_Then_ShouldNotThrowException() => new Func<Task>(() =>
				Task.FromResult(Union.FromTypes<ClassOne, ClassTwo>().Create(ModelOne)).Value().Should().BeOfTypeOne()
			).Should().NotThrow();

			[Fact]
			public void When_TypeIsOneAndExpectedTypeIsNotOne_Then_ShouldThrowException() => new Func<Task>(() =>
				Task.FromResult(Union.FromTypes<ClassOne, ClassTwo>().Create(ModelOne)).Value().Should().BeOfTypeTwo()
			).Should().Throw<Exception>();

			[Fact]
			public void When_TypeIsTwoAndExpectedTypeIsTwo_Then_ShouldNotThrowException() => new Func<Task>(() =>
				Task.FromResult(Union.FromTypes<ClassOne, ClassTwo>().Create(ModelTwo)).Value().Should().BeOfTypeTwo()
			).Should().NotThrow();

			[Fact]
			public void When_TypeIsTwoAndExpectedTypeIsNotTwo_Then_ShouldThrowException() => new Func<Task>(() =>
				Task.FromResult(Union.FromTypes<ClassOne, ClassTwo>().Create(ModelTwo)).Value().Should().BeOfTypeOne()
			).Should().Throw<Exception>();

			[Fact]
			public void When_TypeIsOneAndAdditionalAssertionSucceeds_Then_ShouldNotThrowException() => new Func<Task>(() =>
				Task.FromResult(Union.FromTypes<ClassOne, ClassTwo>().Create(ModelOne)).Value().Should().BeOfTypeOne().AndValue(value => value.Should().Be(ModelOne))
			).Should().NotThrow();

			[Fact]
			public void When_TypeIsTwoAndAdditionalAssertionSucceeds_Then_ShouldNotThrowException() => new Func<Task>(() =>
				Task.FromResult(Union.FromTypes<ClassOne, ClassTwo>().Create(ModelTwo)).Value().Should().BeOfTypeTwo().AndValue(value => value.Should().Be(ModelTwo))
			).Should().NotThrow();
		}
	}
}
