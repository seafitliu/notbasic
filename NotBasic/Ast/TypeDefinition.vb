﻿
Public Class TypeDefinition
    Inherits Definition

    Private _sourceSpan As Compilers.SourceSpan
    Private _typeName As UnifiedIdentifer
    Private _typeParams As IEnumerable(Of TypeParameter)
    Private _whereClauses As IEnumerable(Of ConceptConstraintClause)
    Private _fields As IEnumerable(Of FieldDefinition)
    Private _sourceSpan1 As Compilers.SourceSpan

    Sub New(sourceSpan As Compilers.SourceSpan, sourceSpan1 As Compilers.SourceSpan, typeName As UnifiedIdentifer, typeParams As IEnumerable(Of TypeParameter), whereClauses As IEnumerable(Of ConceptConstraintClause), fields As IEnumerable(Of FieldDefinition))
        ' TODO: Complete member initialization 
        _sourceSpan = sourceSpan
        _sourceSpan1 = sourceSpan1
        _typeName = typeName
        _typeParams = typeParams
        _whereClauses = whereClauses
        _fields = fields
    End Sub

End Class