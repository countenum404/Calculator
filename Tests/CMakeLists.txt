add_executable(CalculatorTests calc_unit_tests.cpp)

target_link_libraries(CalculatorTests PRIVATE 
    CalculatorLib 
    GTest::gtest_main
)

if(WIN32)
    add_custom_command(TARGET CalculatorTests POST_BUILD
        COMMAND ${CMAKE_COMMAND} -E copy_if_different
            $<TARGET_FILE:CalculatorLib>
            $<TARGET_FILE_DIR:CalculatorTests>
        COMMENT "Copying CalculatorLib DLL to test directory"
    )
else()
    set_target_properties(CalculatorTests PROPERTIES
        BUILD_RPATH "$ORIGIN"
        INSTALL_RPATH "$ORIGIN"
    )
endif()

target_include_directories(CalculatorTests PRIVATE ../CalculatorLib)


enable_testing()
add_test(NAME CalculatorTests COMMAND CalculatorTests)