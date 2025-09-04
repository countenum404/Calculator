add_executable(main main.cpp)
target_include_directories(main PRIVATE ../CalculatorLib)
target_link_libraries(main PRIVATE CalculatorLib)

set_target_properties(main PROPERTIES
    RUNTIME_OUTPUT_DIRECTORY ${CMAKE_BINARY_DIR}/bin
    OUTPUT_NAME main
)

if (CMAKE_VERSION VERSION_GREATER 3.12)
    set_property(TARGET main PROPERTY CXX_STANDARD 20)
endif()
