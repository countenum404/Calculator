#include <iostream>
#include <string>

#include "Calculator.h"


class IApp {
public:
    IApp() = default;
    ~IApp() = default;
    virtual void Run() = 0;
};

class CalculatorApplication : public IApp {
public:

    CalculatorApplication() : calculator(std::make_unique<CalcLib::Calculator>()) {}
    ~CalculatorApplication() = default;
    
    void Run() override {
        std::string expression = "";
        std::cout << "You are welcome to write math expression:" << std::endl;
        while (std::getline(std::cin, expression)) {
            try {
                double result = calculator->Calculate(expression);
                std::cout << "Answer: " << result << std::endl;
            }
            catch (std::exception e) {
                std::cout << "Error: " << e.what() << std::endl;
            }
            std::cout << "You are welcome to write math expression:" << std::endl;
        }
    }
private:
    std::unique_ptr<CalcLib::Calculator> calculator;
};

int main()
{
    std::unique_ptr<IApp> calcApp = std::make_unique<CalculatorApplication>();
    calcApp->Run();
    return 0;
}