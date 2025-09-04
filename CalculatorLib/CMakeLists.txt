file(GLOB LIB_SOURCES "src/*.cpp")
add_library(CalculatorLib SHARED ${LIB_SOURCES})

target_compile_definitions(CalculatorLib PRIVATE CALCULATORLIB_EXPORTS)

set_target_properties(CalculatorLib PROPERTIES
    ARCHIVE_OUTPUT_DIRECTORY ${CMAKE_BINARY_DIR}/lib
    LIBRARY_OUTPUT_DIRECTORY ${CMAKE_BINARY_DIR}/bin
    RUNTIME_OUTPUT_DIRECTORY ${CMAKE_BINARY_DIR}/bin
    OUTPUT_NAME CalculatorLib
    VERSION 1.0.0
    SOVERSION 1
)

install(TARGETS CalculatorLib
    ARCHIVE DESTINATION lib
    LIBRARY DESTINATION lib
    RUNTIME DESTINATION bin
    INCLUDES DESTINATION include
)
install(DIRECTORY include/ DESTINATION include)

target_include_directories(CalculatorLib PUBLIC 
    "${CMAKE_CURRENT_SOURCE_DIR}/include"
)

if (CMAKE_VERSION VERSION_GREATER 3.12)
    set_property(TARGET CalculatorLib PROPERTY CXX_STANDARD 20)
endif()

message("My message - CalculatorLib CMAKE_BINARY_DIR: " ${CMAKE_BINARY_DIR})
message("My message - CalculatorLib CMAKE_CURRENT_SOURCE_DIR: " ${CMAKE_CURRENT_SOURCE_DIR})
