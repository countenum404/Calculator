#include "calculator.h"

#include <gtest/gtest.h>
#include <memory>


class CalculatorFixture : public ::testing::Test {
protected:
	void SetUp() override {
		calc = std::make_unique<CalcLib::Calculator>();
	}

	void TearDown() override {
		calc.reset();
	}
	
	std::unique_ptr<CalcLib::Calculator> calc;
};


TEST_F(CalculatorFixture, Addition) {
	EXPECT_EQ(calc->Calculate("1 + 1"), 2.0);
	EXPECT_EQ(calc->Calculate("5 - 2"), 3.0);
	EXPECT_EQ(calc->Calculate("1000 + 1"), 1001.0);
	//EXPECT_EQ(calc->Calculate("2.5 + 2.5"), 5.0);
}

TEST_F(CalculatorFixture, Multiplication) {
	EXPECT_EQ(calc->Calculate("10 * 50"), 500.0 );
	EXPECT_EQ(calc->Calculate( "3 * 4" ), 12.0);
	EXPECT_EQ(calc->Calculate( "6 * 16"), 96.0);
}

TEST_F(CalculatorFixture, Division) {
	EXPECT_EQ(calc->Calculate("100 / 10"), 10);
	EXPECT_EQ(calc->Calculate("5 / 2"), 2.5);
}
