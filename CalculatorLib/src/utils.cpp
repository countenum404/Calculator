#include "utils.h"


bool is_operator(char c) {
	return operatorsRank.contains(std::string(1, c));
}

int rank(char c) {
	return operatorsRank[std::string(1, c)];
}

int rank(std::string c) {
	return operatorsRank[c];
}

bool isNumber(const std::string& s) {
	return !s.empty() && std::all_of(s.begin(), s.end(), ::isdigit);
}