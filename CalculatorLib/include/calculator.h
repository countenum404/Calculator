#pragma once
#include <string>
#include <memory>

namespace CalcLib {
    class ICalculator {
    public:
        virtual double Calculate(const std::string& expression) = 0;
        virtual ~ICalculator() {};
    };

    class Calculator {
    public:
        Calculator();
        ~Calculator();
        double Calculate(const std::string& expression);

    private:
        std::unique_ptr<ICalculator> impl;
    };
}