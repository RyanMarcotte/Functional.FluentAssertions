﻿using FluentAssertions;
using System;
using Xunit;

namespace Functional.Unions.FluentAssertions.Tests
{
	public partial class UnionValueTypeAssertionsTests
	{
		public class DefinitionWithEightTypes
		{
			[Fact]
			public void When_EqualityIsTrue_Then_ShouldNotThrowException() => new Action(() =>
				Union.FromDefinition<EightDefinition>().Create(ModelEight).Value().Should().Be(Union.FromDefinition<EightDefinition>().Create(ModelEight).Value())
			).Should().NotThrow();

			[Fact]
			public void When_EqualityIsFalse_Then_ShouldThrowException() => new Action(() =>
				Union.FromDefinition<EightDefinition>().Create(ModelEight).Value().Should().Be(Union.FromDefinition<EightDefinition>().Create(new ClassEight()).Value())
			).Should().Throw<Exception>();

			[Fact]
			public void When_TypeIsOneAndExpectedTypeIsOne_Then_ShouldNotThrowException() => new Action(() =>
				Union.FromDefinition<EightDefinition>().Create(ModelOne).Value().Should().BeOfTypeOne()
			).Should().NotThrow();

			[Fact]
			public void When_TypeIsOneAndExpectedTypeIsNotOne_Then_ShouldThrowException() => new Action(() =>
				Union.FromDefinition<EightDefinition>().Create(ModelOne).Value().Should().BeOfTypeTwo()
			).Should().Throw<Exception>();

			[Fact]
			public void When_TypeIsTwoAndExpectedTypeIsTwo_Then_ShouldNotThrowException() => new Action(() =>
				Union.FromDefinition<EightDefinition>().Create(ModelTwo).Value().Should().BeOfTypeTwo()
			).Should().NotThrow();

			[Fact]
			public void When_TypeIsTwoAndExpectedTypeIsNotTwo_Then_ShouldThrowException() => new Action(() =>
				Union.FromDefinition<EightDefinition>().Create(ModelTwo).Value().Should().BeOfTypeOne()
			).Should().Throw<Exception>();

			[Fact]
			public void When_TypeIsThreeAndExpectedTypeIsThree_Then_ShouldNotThrowException() => new Action(() =>
				Union.FromDefinition<EightDefinition>().Create(ModelThree).Value().Should().BeOfTypeThree()
			).Should().NotThrow();

			[Fact]
			public void When_TypeIsThreeAndExpectedTypeIsNotThree_Then_ShouldThrowException() => new Action(() =>
				Union.FromDefinition<EightDefinition>().Create(ModelThree).Value().Should().BeOfTypeTwo()
			).Should().Throw<Exception>();

			[Fact]
			public void When_TypeIsFourAndExpectedTypeIsFour_Then_ShouldNotThrowException() => new Action(() =>
				Union.FromDefinition<EightDefinition>().Create(ModelFour).Value().Should().BeOfTypeFour()
			).Should().NotThrow();

			[Fact]
			public void When_TypeIsFourAndExpectedTypeIsNotFour_Then_ShouldThrowException() => new Action(() =>
				Union.FromDefinition<EightDefinition>().Create(ModelFour).Value().Should().BeOfTypeThree()
			).Should().Throw<Exception>();

			[Fact]
			public void When_TypeIsFiveAndExpectedTypeIsFive_Then_ShouldNotThrowException() => new Action(() =>
				Union.FromDefinition<EightDefinition>().Create(ModelFive).Value().Should().BeOfTypeFive()
			).Should().NotThrow();

			[Fact]
			public void When_TypeIsFiveAndExpectedTypeIsNotFive_Then_ShouldThrowException() => new Action(() =>
				Union.FromDefinition<EightDefinition>().Create(ModelFive).Value().Should().BeOfTypeFour()
			).Should().Throw<Exception>();

			[Fact]
			public void When_TypeIsSixAndExpectedTypeIsSix_Then_ShouldNotThrowException() => new Action(() =>
				Union.FromDefinition<EightDefinition>().Create(ModelSix).Value().Should().BeOfTypeSix()
			).Should().NotThrow();

			[Fact]
			public void When_TypeIsSixAndExpectedTypeIsNotSix_Then_ShouldThrowException() => new Action(() =>
				Union.FromDefinition<EightDefinition>().Create(ModelSix).Value().Should().BeOfTypeFive()
			).Should().Throw<Exception>();

			[Fact]
			public void When_TypeIsSevenAndExpectedTypeIsSeven_Then_ShouldNotThrowException() => new Action(() =>
				Union.FromDefinition<EightDefinition>().Create(ModelSeven).Value().Should().BeOfTypeSeven()
			).Should().NotThrow();

			[Fact]
			public void When_TypeIsSevenAndExpectedTypeIsNotSeven_Then_ShouldThrowException() => new Action(() =>
				Union.FromDefinition<EightDefinition>().Create(ModelSeven).Value().Should().BeOfTypeSix()
			).Should().Throw<Exception>();

			[Fact]
			public void When_TypeIsEightAndExpectedTypeIsEight_Then_ShouldNotThrowException() => new Action(() =>
				Union.FromDefinition<EightDefinition>().Create(ModelEight).Value().Should().BeOfTypeEight()
			).Should().NotThrow();

			[Fact]
			public void When_TypeIsEightAndExpectedTypeIsNotEight_Then_ShouldThrowException() => new Action(() =>
				Union.FromDefinition<EightDefinition>().Create(ModelEight).Value().Should().BeOfTypeSeven()
			).Should().Throw<Exception>();

			[Fact]
			public void When_TypeIsOneAndAdditionalAssertionSucceeds_Then_ShouldNotThrowException() => new Action(() =>
				Union.FromDefinition<EightDefinition>().Create(ModelOne).Value().Should().BeOfTypeOne().AndValue.Should().Be(ModelOne)
			).Should().NotThrow();

			[Fact]
			public void When_TypeIsTwoAndAdditionalAssertionSucceeds_Then_ShouldNotThrowException() => new Action(() =>
				Union.FromDefinition<EightDefinition>().Create(ModelTwo).Value().Should().BeOfTypeTwo().AndValue.Should().Be(ModelTwo)
			).Should().NotThrow();

			[Fact]
			public void When_TypeIsThreeAndAdditionalAssertionSucceeds_Then_ShouldNotThrowException() => new Action(() =>
				Union.FromDefinition<EightDefinition>().Create(ModelThree).Value().Should().BeOfTypeThree().AndValue.Should().Be(ModelThree)
			).Should().NotThrow();

			[Fact]
			public void When_TypeIsFourAndAdditionalAssertionSucceeds_Then_ShouldNotThrowException() => new Action(() =>
				Union.FromDefinition<EightDefinition>().Create(ModelFour).Value().Should().BeOfTypeFour().AndValue.Should().Be(ModelFour)
			).Should().NotThrow();

			[Fact]
			public void When_TypeIsFiveAndAdditionalAssertionSucceeds_Then_ShouldNotThrowException() => new Action(() =>
				Union.FromDefinition<EightDefinition>().Create(ModelFive).Value().Should().BeOfTypeFive().AndValue.Should().Be(ModelFive)
			).Should().NotThrow();

			[Fact]
			public void When_TypeIsSixAndAdditionalAssertionSucceeds_Then_ShouldNotThrowException() => new Action(() =>
				Union.FromDefinition<EightDefinition>().Create(ModelSix).Value().Should().BeOfTypeSix().AndValue.Should().Be(ModelSix)
			).Should().NotThrow();

			[Fact]
			public void When_TypeIsSevenAndAdditionalAssertionSucceeds_Then_ShouldNotThrowException() => new Action(() =>
				Union.FromDefinition<EightDefinition>().Create(ModelSeven).Value().Should().BeOfTypeSeven().AndValue.Should().Be(ModelSeven)
			).Should().NotThrow();

			[Fact]
			public void When_TypeIsEightAndAdditionalAssertionSucceeds_Then_ShouldNotThrowException() => new Action(() =>
				Union.FromDefinition<EightDefinition>().Create(ModelEight).Value().Should().BeOfTypeEight().AndValue.Should().Be(ModelEight)
			).Should().NotThrow();
		}
	}
}
