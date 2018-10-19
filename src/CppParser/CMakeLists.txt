project(CppParser)

file(GLOB SOURCES 
    "*.cpp"
    "*.h"
)

add_library(CppSharp.CppParser SHARED ${SOURCES})