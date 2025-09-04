#include "utils.h"
#include "calculator.h"

#include <stack>
#include <sstream>
#include <iostream>


class RpnCalculatorImpl : public CalcLib::ICalculator {
public:
	RpnCalculatorImpl() = default;
	
	double Calculate(const std::string& expression) override {
		std::string rpn = toRpn(expression);
		std::stack<double> stack;
		std::stringstream ss(rpn);
		std::string token;

		while (ss >> token) {
			if (token.size() == 1 && is_operator(token[0])) {
				if (stack.size() < 2) throw std::runtime_error("not enough arguments");
				double right = stack.top(); stack.pop();
				double left = stack.top(); stack.pop();
				double result = operationsMapping[token[0]](left, right);
				stack.push(result);
			}
			else if (isNumber(token)) {
				stack.push(std::stoi(token));
			}
			else {
				throw std::runtime_error("Invalid token: " + token);
			}
		}
		if (stack.size() != 1) throw std::runtime_error("Invalid expression");
		return stack.top();
	};
	
	std::string toRpn(const std::string& infix) {
		std::stack<std::string> rpn_stack;
		std::string rpn = "";

		for (char c : infix) {
			if (std::isdigit(c)) {
				rpn.push_back(c);
				continue;
			}
			else if (c == '(') {
				rpn_stack.push(std::string(1, c));
			}
			else if (c == ')') {
				rpn += " ";

				while (!rpn_stack.empty()) {
					std::string top = rpn_stack.top();
					if (top == "(") {
						rpn_stack.pop();
						break;
					}
					rpn += top + " ";
					rpn_stack.pop();
				}
			}
			else if (is_operator(c)) {
				rpn += " ";
				while (!rpn_stack.empty()) {
					std::string top = rpn_stack.top();
					if (rank(top) > rank(c)) {
						break;
					}
					rpn += top + " ";
					rpn_stack.pop();
				}
				rpn_stack.push(std::string(1, c));
			}
		}
		rpn += " ";
		while (!rpn_stack.empty()) {
			std::string top = rpn_stack.top();
			rpn += top + " ";
			rpn_stack.pop();
		}

		return rpn;
	}
};

class InvalidOperationException : public std::exception {
	std::string m_msg;
public:
	explicit InvalidOperationException(const std::string& msg) : m_msg(msg) {}
	const char* what() const noexcept override {
		return m_msg.c_str();
	}
};

CalcLib::Calculator::Calculator() : impl(std::make_unique<RpnCalculatorImpl>()) {}
CalcLib::Calculator::~Calculator() = default;

double CalcLib::Calculator::Calculate(const std::string& expression) {
	return impl->Calculate(expression);
}