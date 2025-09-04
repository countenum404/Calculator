#pragma once

#include <string>
#include <algorithm>
#include <unordered_map>
#include <functional>

static std::unordered_map<std::string, int> operatorsRank{
	{"*", 1},
	{"/", 1},
	{"+", 3},
	{"-", 3},
	{"(", 4},
	{")", 4},
};

static std::unordered_map<char, std::function<double(double, double)>> operationsMapping{
	{'*', [](double a, double b) { return a * b; }},
	{'/', [](double a, double b) { return a / b; }},
	{'+', [](double a, double b) { return a + b; }},
	{'-', [](double a, double b) { return a - b; }},
};


bool is_operator(char c);

int rank(char c);

int rank(std::string c);

bool isNumber(const std::string& s);
