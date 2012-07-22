﻿Imports VBF.Compilers
Imports VBF.NotBasic.Compiler

Module ProgramEntry

    Sub Main()
        Dim em As New CompilationErrorManager
        Dim parser As New NotBasicParser(em)

        Dim code = <![CDATA[
fun Foo(a, b)
    return 0
end

fun Bar()
    if 1 then a = 0
    if 1 then a = 0  else b = 0
    if 1 
        a = 0
    elseif 2
        b = 0
    else
        c = 0
    end

    do while 1
        a = 0
    loop
end
]]>
        Dim s = parser.Parse(code.Value)

        Stop
    End Sub

End Module