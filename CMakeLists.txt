cmake_minimum_required(VERSION 3.10)

set(CMAKE_WINDOWS_EXPORT_ALL_SYMBOLS ON)

if (POLICY CMP0141)
  cmake_policy(SET CMP0141 NEW)
  set(CMAKE_MSVC_DEBUG_INFORMATION_FORMAT "$<IF:$<AND:$<C_COMPILER_ID:MSVC>,$<CXX_COMPILER_ID:MSVC>>,$<$<CONFIG:Debug,RelWithDebInfo>:EditAndContinue>,$<$<CONFIG:Debug,RelWithDebInfo>:ProgramDatabase>>")
endif()

project ("Calculator")

# Include sub-projects.
add_subdirectory(CalculatorLib)
add_subdirectory(main)

# C++ std 20 for other compilers.
target_compile_features(CalculatorLib PUBLIC cxx_std_20)
# C++ std 20 for MSVC.
target_compile_options(CalculatorLib PUBLIC /std:c++20) 