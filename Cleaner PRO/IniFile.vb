Imports System.Runtime.InteropServices
Imports System.Text
Imports System.IO
Imports ICSharpCode.Decompiler.IL

Friend Class IniFile
    Private ReadOnly FileName As String
    Private pMem As IntPtr

    Public Sub New(ByVal Optional FileName As String = Nothing)
        ''''''Return CSharpImpl.__Assign(Me.FileName, New System.IO.FileInfo(FileName).FullName.ToString())
    End Sub

    <DllImport("kernel32", CharSet:=CharSet.Auto)>
    Private Shared Function WritePrivateProfileString(ByVal lpAppName As String, ByVal lpKeyName As String, ByVal lpString As String, ByVal lpFileName As String) As Long

    End Function
    <DllImport("kernel32", CharSet:=CharSet.Auto)>
    Private Shared Function GetPrivateProfileString(ByVal lpAppName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString As StringBuilder, ByVal nSize As Integer, ByVal lpFileName As String) As Integer

    End Function
    <DllImport("kernel32", CharSet:=CharSet.Auto)>
    Private Shared Function GetPrivateProfileInt(ByVal lpAppName As String, ByVal lpKeyName As String, ByVal nDefault As Integer, ByVal lpFileName As String) As Integer

    End Function
    <DllImport("kernel32", CharSet:=CharSet.Auto)>
    Private Shared Function GetPrivateProfileSection(ByVal lpAppName As String, ByVal lpReturnedString As System.IntPtr, ByVal nSize As Integer, ByVal lpFileName As String) As Integer

    End Function
    <DllImport("kernel32", CharSet:=CharSet.Auto)>
    Private Shared Function GetPrivateProfileSectionNames(ByVal lpReturnedString As System.IntPtr, ByVal nSize As Integer, ByVal lpFileName As String) As Integer

    End Function

    Public Sub Write(ByVal Key As String, ByVal Value As String, ByVal Optional Section As String = Nothing)
        ''''''Return WritePrivateProfileString(Section, Key, Value, FileName)
    End Sub

    Public Function ReadString(ByVal Key As String, ByVal Optional Section As String = Nothing, ByVal Optional Size As Integer = 255, ByVal Optional [Default] As String = "") As String
        Dim tmp As StringBuilder = New StringBuilder(Size)
        GetPrivateProfileString(Section, Key, [Default], tmp, Size, FileName)
        Return tmp.ToString()
    End Function

    Public Function ReadInt(ByVal Key As String, ByVal Optional Section As String = Nothing, ByVal Optional [Default] As Integer = -1) As Integer
        Return GetPrivateProfileInt(Section, Key, [Default], FileName)
    End Function

    Public Function ReadBool(ByVal Key As String, ByVal Optional Section As String = Nothing, ByVal Optional Size As Integer = 255) As Boolean
        Dim tmp As StringBuilder = New StringBuilder(Size)
        GetPrivateProfileString(Section, Key, "", tmp, Size, FileName)
        Return System.Convert.ToBoolean(tmp.ToString())
    End Function

    Public Function GetAllDataSection(ByVal Section As String, ByVal Optional Size As Integer = 255) As String()
        ''' Cannot convert LocalDeclarationStatementSyntax, CONVERSION ERROR: Conversion for SizeOfExpression not implemented, please report this issue in 'sizeof(char)' at character 2171
        '''    at ICSharpCode.CodeConverter.VB.NodesVisitor.DefaultVisit(SyntaxNode node)
        '''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.VisitSizeOfExpression(SizeOfExpressionSyntax node)
        '''    at Microsoft.CodeAnalysis.CSharp.Syntax.SizeOfExpressionSyntax.Accept[TResult](CSharpSyntaxVisitor`1 visitor)
        '''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
        '''    at ICSharpCode.CodeConverter.VB.CommentConvertingNodesVisitor.DefaultVisit(SyntaxNode node)
        '''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.VisitSizeOfExpression(SizeOfExpressionSyntax node)
        '''    at Microsoft.CodeAnalysis.CSharp.Syntax.SizeOfExpressionSyntax.Accept[TResult](CSharpSyntaxVisitor`1 visitor)
        '''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitBinaryExpression(BinaryExpressionSyntax node)
        '''    at Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax.Accept[TResult](CSharpSyntaxVisitor`1 visitor)
        '''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
        '''    at ICSharpCode.CodeConverter.VB.CommentConvertingNodesVisitor.DefaultVisit(SyntaxNode node)
        '''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.VisitBinaryExpression(BinaryExpressionSyntax node)
        '''    at Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax.Accept[TResult](CSharpSyntaxVisitor`1 visitor)
        '''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitArgument(ArgumentSyntax node)
        '''    at Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentSyntax.Accept[TResult](CSharpSyntaxVisitor`1 visitor)
        '''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
        '''    at ICSharpCode.CodeConverter.VB.CommentConvertingNodesVisitor.DefaultVisit(SyntaxNode node)
        '''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.VisitArgument(ArgumentSyntax node)
        '''    at Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentSyntax.Accept[TResult](CSharpSyntaxVisitor`1 visitor)
        '''    at ICSharpCode.CodeConverter.VB.NodesVisitor.<VisitArgumentList>b__99_0(ArgumentSyntax a)
        '''    at System.Linq.Enumerable.WhereSelectEnumerableIterator`2.MoveNext()
        '''    at Microsoft.CodeAnalysis.VisualBasic.SyntaxFactory.SeparatedList[TNode](IEnumerable`1 nodes)
        '''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitArgumentList(ArgumentListSyntax node)
        '''    at Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentListSyntax.Accept[TResult](CSharpSyntaxVisitor`1 visitor)
        '''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
        '''    at ICSharpCode.CodeConverter.VB.CommentConvertingNodesVisitor.DefaultVisit(SyntaxNode node)
        '''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.VisitArgumentList(ArgumentListSyntax node)
        '''    at Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentListSyntax.Accept[TResult](CSharpSyntaxVisitor`1 visitor)
        '''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitInvocationExpression(InvocationExpressionSyntax node)
        '''    at Microsoft.CodeAnalysis.CSharp.Syntax.InvocationExpressionSyntax.Accept[TResult](CSharpSyntaxVisitor`1 visitor)
        '''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
        '''    at ICSharpCode.CodeConverter.VB.CommentConvertingNodesVisitor.DefaultVisit(SyntaxNode node)
        '''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.VisitInvocationExpression(InvocationExpressionSyntax node)
        '''    at Microsoft.CodeAnalysis.CSharp.Syntax.InvocationExpressionSyntax.Accept[TResult](CSharpSyntaxVisitor`1 visitor)
        '''    at ICSharpCode.CodeConverter.VB.CommonConversions.ConvertTopLevelExpression(ExpressionSyntax topLevelExpression)
        '''    at ICSharpCode.CodeConverter.VB.CommonConversions.RemodelVariableDeclaration(VariableDeclarationSyntax declaration)
        '''    at ICSharpCode.CodeConverter.VB.MethodBodyVisitor.VisitLocalDeclarationStatement(LocalDeclarationStatementSyntax node)
        '''    at Microsoft.CodeAnalysis.CSharp.Syntax.LocalDeclarationStatementSyntax.Accept[TResult](CSharpSyntaxVisitor`1 visitor)
        '''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
        '''    at ICSharpCode.CodeConverter.VB.CommentConvertingMethodBodyVisitor.ConvertWithTrivia(SyntaxNode node)
        '''    at ICSharpCode.CodeConverter.VB.CommentConvertingMethodBodyVisitor.DefaultVisit(SyntaxNode node)
        ''' 
        ''' Input: 
        '''         System.IntPtr pMem = Marshal.AllocHGlobal(4096 * sizeof(char));

        ''' 
        Dim temp As String = String.Empty
        ''' Cannot convert LocalDeclarationStatementSyntax, CONVERSION ERROR: Conversion for SizeOfExpression not implemented, please report this issue in 'sizeof(char)' at character 2290
        '''    at ICSharpCode.CodeConverter.VB.NodesVisitor.DefaultVisit(SyntaxNode node)
        '''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.VisitSizeOfExpression(SizeOfExpressionSyntax node)
        '''    at Microsoft.CodeAnalysis.CSharp.Syntax.SizeOfExpressionSyntax.Accept[TResult](CSharpSyntaxVisitor`1 visitor)
        '''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
        '''    at ICSharpCode.CodeConverter.VB.CommentConvertingNodesVisitor.DefaultVisit(SyntaxNode node)
        '''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.VisitSizeOfExpression(SizeOfExpressionSyntax node)
        '''    at Microsoft.CodeAnalysis.CSharp.Syntax.SizeOfExpressionSyntax.Accept[TResult](CSharpSyntaxVisitor`1 visitor)
        '''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitBinaryExpression(BinaryExpressionSyntax node)
        '''    at Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax.Accept[TResult](CSharpSyntaxVisitor`1 visitor)
        '''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
        '''    at ICSharpCode.CodeConverter.VB.CommentConvertingNodesVisitor.DefaultVisit(SyntaxNode node)
        '''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.VisitBinaryExpression(BinaryExpressionSyntax node)
        '''    at Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax.Accept[TResult](CSharpSyntaxVisitor`1 visitor)
        '''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitArgument(ArgumentSyntax node)
        '''    at Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentSyntax.Accept[TResult](CSharpSyntaxVisitor`1 visitor)
        '''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
        '''    at ICSharpCode.CodeConverter.VB.CommentConvertingNodesVisitor.DefaultVisit(SyntaxNode node)
        '''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.VisitArgument(ArgumentSyntax node)
        '''    at Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentSyntax.Accept[TResult](CSharpSyntaxVisitor`1 visitor)
        '''    at ICSharpCode.CodeConverter.VB.NodesVisitor.<VisitArgumentList>b__99_0(ArgumentSyntax a)
        '''    at System.Linq.Enumerable.WhereSelectEnumerableIterator`2.MoveNext()
        '''    at Microsoft.CodeAnalysis.VisualBasic.SyntaxFactory.SeparatedList[TNode](IEnumerable`1 nodes)
        '''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitArgumentList(ArgumentListSyntax node)
        '''    at Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentListSyntax.Accept[TResult](CSharpSyntaxVisitor`1 visitor)
        '''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
        '''    at ICSharpCode.CodeConverter.VB.CommentConvertingNodesVisitor.DefaultVisit(SyntaxNode node)
        '''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.VisitArgumentList(ArgumentListSyntax node)
        '''    at Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentListSyntax.Accept[TResult](CSharpSyntaxVisitor`1 visitor)
        '''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitInvocationExpression(InvocationExpressionSyntax node)
        '''    at Microsoft.CodeAnalysis.CSharp.Syntax.InvocationExpressionSyntax.Accept[TResult](CSharpSyntaxVisitor`1 visitor)
        '''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
        '''    at ICSharpCode.CodeConverter.VB.CommentConvertingNodesVisitor.DefaultVisit(SyntaxNode node)
        '''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.VisitInvocationExpression(InvocationExpressionSyntax node)
        '''    at Microsoft.CodeAnalysis.CSharp.Syntax.InvocationExpressionSyntax.Accept[TResult](CSharpSyntaxVisitor`1 visitor)
        '''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitBinaryExpression(BinaryExpressionSyntax node)
        '''    at Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax.Accept[TResult](CSharpSyntaxVisitor`1 visitor)
        '''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
        '''    at ICSharpCode.CodeConverter.VB.CommentConvertingNodesVisitor.DefaultVisit(SyntaxNode node)
        '''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.VisitBinaryExpression(BinaryExpressionSyntax node)
        '''    at Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax.Accept[TResult](CSharpSyntaxVisitor`1 visitor)
        '''    at ICSharpCode.CodeConverter.VB.CommonConversions.ConvertTopLevelExpression(ExpressionSyntax topLevelExpression)
        '''    at ICSharpCode.CodeConverter.VB.CommonConversions.RemodelVariableDeclaration(VariableDeclarationSyntax declaration)
        '''    at ICSharpCode.CodeConverter.VB.MethodBodyVisitor.VisitLocalDeclarationStatement(LocalDeclarationStatementSyntax node)
        '''    at Microsoft.CodeAnalysis.CSharp.Syntax.LocalDeclarationStatementSyntax.Accept[TResult](CSharpSyntaxVisitor`1 visitor)
        '''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
        '''    at ICSharpCode.CodeConverter.VB.CommentConvertingMethodBodyVisitor.ConvertWithTrivia(SyntaxNode node)
        '''    at ICSharpCode.CodeConverter.VB.CommentConvertingMethodBodyVisitor.DefaultVisit(SyntaxNode node)
        ''' 
        ''' Input: 
        ''' 
        '''''''''Int count = GetPrivateProfileSection(Section, pMem, Size * SizeOf(Of Char), FileName) - 1;

        ''' 
        ''''''''If count > 0 Then temp = Marshal.PtrToStringUni(pMem, count)
        Marshal.FreeHGlobal(pMem)
        Return temp.Split(vbNullChar)
    End Function

    Public Function GetAllSections(ByVal Optional Size As Integer = 255) As String()
        ''' Cannot convert LocalDeclarationStatementSyntax, CONVERSION ERROR: Conversion for SizeOfExpression not implemented, please report this issue in 'sizeof(char)' at character 2575
        '''    at ICSharpCode.CodeConverter.VB.NodesVisitor.DefaultVisit(SyntaxNode node)
        '''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.VisitSizeOfExpression(SizeOfExpressionSyntax node)
        '''    at Microsoft.CodeAnalysis.CSharp.Syntax.SizeOfExpressionSyntax.Accept[TResult](CSharpSyntaxVisitor`1 visitor)
        '''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
        '''    at ICSharpCode.CodeConverter.VB.CommentConvertingNodesVisitor.DefaultVisit(SyntaxNode node)
        '''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.VisitSizeOfExpression(SizeOfExpressionSyntax node)
        '''    at Microsoft.CodeAnalysis.CSharp.Syntax.SizeOfExpressionSyntax.Accept[TResult](CSharpSyntaxVisitor`1 visitor)
        '''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitBinaryExpression(BinaryExpressionSyntax node)
        '''    at Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax.Accept[TResult](CSharpSyntaxVisitor`1 visitor)
        '''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
        '''    at ICSharpCode.CodeConverter.VB.CommentConvertingNodesVisitor.DefaultVisit(SyntaxNode node)
        '''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.VisitBinaryExpression(BinaryExpressionSyntax node)
        '''    at Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax.Accept[TResult](CSharpSyntaxVisitor`1 visitor)
        '''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitArgument(ArgumentSyntax node)
        '''    at Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentSyntax.Accept[TResult](CSharpSyntaxVisitor`1 visitor)
        '''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
        '''    at ICSharpCode.CodeConverter.VB.CommentConvertingNodesVisitor.DefaultVisit(SyntaxNode node)
        '''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.VisitArgument(ArgumentSyntax node)
        '''    at Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentSyntax.Accept[TResult](CSharpSyntaxVisitor`1 visitor)
        '''    at ICSharpCode.CodeConverter.VB.NodesVisitor.<VisitArgumentList>b__99_0(ArgumentSyntax a)
        '''    at System.Linq.Enumerable.WhereSelectEnumerableIterator`2.MoveNext()
        '''    at Microsoft.CodeAnalysis.VisualBasic.SyntaxFactory.SeparatedList[TNode](IEnumerable`1 nodes)
        '''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitArgumentList(ArgumentListSyntax node)
        '''    at Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentListSyntax.Accept[TResult](CSharpSyntaxVisitor`1 visitor)
        '''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
        '''    at ICSharpCode.CodeConverter.VB.CommentConvertingNodesVisitor.DefaultVisit(SyntaxNode node)
        '''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.VisitArgumentList(ArgumentListSyntax node)
        '''    at Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentListSyntax.Accept[TResult](CSharpSyntaxVisitor`1 visitor)
        '''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitInvocationExpression(InvocationExpressionSyntax node)
        '''    at Microsoft.CodeAnalysis.CSharp.Syntax.InvocationExpressionSyntax.Accept[TResult](CSharpSyntaxVisitor`1 visitor)
        '''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
        '''    at ICSharpCode.CodeConverter.VB.CommentConvertingNodesVisitor.DefaultVisit(SyntaxNode node)
        '''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.VisitInvocationExpression(InvocationExpressionSyntax node)
        '''    at Microsoft.CodeAnalysis.CSharp.Syntax.InvocationExpressionSyntax.Accept[TResult](CSharpSyntaxVisitor`1 visitor)
        '''    at ICSharpCode.CodeConverter.VB.CommonConversions.ConvertTopLevelExpression(ExpressionSyntax topLevelExpression)
        '''    at ICSharpCode.CodeConverter.VB.CommonConversions.RemodelVariableDeclaration(VariableDeclarationSyntax declaration)
        '''    at ICSharpCode.CodeConverter.VB.MethodBodyVisitor.VisitLocalDeclarationStatement(LocalDeclarationStatementSyntax node)
        '''    at Microsoft.CodeAnalysis.CSharp.Syntax.LocalDeclarationStatementSyntax.Accept[TResult](CSharpSyntaxVisitor`1 visitor)
        '''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
        '''    at ICSharpCode.CodeConverter.VB.CommentConvertingMethodBodyVisitor.ConvertWithTrivia(SyntaxNode node)
        '''    at ICSharpCode.CodeConverter.VB.CommentConvertingMethodBodyVisitor.DefaultVisit(SyntaxNode node)
        ''' 
        ''' Input: 
        '''         System.IntPtr pMem = Marshal.AllocHGlobal(4096 * sizeof(char));

        ''' 
        Dim temp As String = String.Empty
        ''' Cannot convert LocalDeclarationStatementSyntax, CONVERSION ERROR: Conversion for SizeOfExpression not implemented, please report this issue in 'sizeof(char)' at character 2690
        '''    at ICSharpCode.CodeConverter.VB.NodesVisitor.DefaultVisit(SyntaxNode node)
        '''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.VisitSizeOfExpression(SizeOfExpressionSyntax node)
        '''    at Microsoft.CodeAnalysis.CSharp.Syntax.SizeOfExpressionSyntax.Accept[TResult](CSharpSyntaxVisitor`1 visitor)
        '''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
        '''    at ICSharpCode.CodeConverter.VB.CommentConvertingNodesVisitor.DefaultVisit(SyntaxNode node)
        '''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.VisitSizeOfExpression(SizeOfExpressionSyntax node)
        '''    at Microsoft.CodeAnalysis.CSharp.Syntax.SizeOfExpressionSyntax.Accept[TResult](CSharpSyntaxVisitor`1 visitor)
        '''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitBinaryExpression(BinaryExpressionSyntax node)
        '''    at Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax.Accept[TResult](CSharpSyntaxVisitor`1 visitor)
        '''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
        '''    at ICSharpCode.CodeConverter.VB.CommentConvertingNodesVisitor.DefaultVisit(SyntaxNode node)
        '''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.VisitBinaryExpression(BinaryExpressionSyntax node)
        '''    at Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax.Accept[TResult](CSharpSyntaxVisitor`1 visitor)
        '''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitArgument(ArgumentSyntax node)
        '''    at Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentSyntax.Accept[TResult](CSharpSyntaxVisitor`1 visitor)
        '''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
        '''    at ICSharpCode.CodeConverter.VB.CommentConvertingNodesVisitor.DefaultVisit(SyntaxNode node)
        '''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.VisitArgument(ArgumentSyntax node)
        '''    at Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentSyntax.Accept[TResult](CSharpSyntaxVisitor`1 visitor)
        '''    at ICSharpCode.CodeConverter.VB.NodesVisitor.<VisitArgumentList>b__99_0(ArgumentSyntax a)
        '''    at System.Linq.Enumerable.WhereSelectEnumerableIterator`2.MoveNext()
        '''    at Microsoft.CodeAnalysis.VisualBasic.SyntaxFactory.SeparatedList[TNode](IEnumerable`1 nodes)
        '''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitArgumentList(ArgumentListSyntax node)
        '''    at Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentListSyntax.Accept[TResult](CSharpSyntaxVisitor`1 visitor)
        '''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
        '''    at ICSharpCode.CodeConverter.VB.CommentConvertingNodesVisitor.DefaultVisit(SyntaxNode node)
        '''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.VisitArgumentList(ArgumentListSyntax node)
        '''    at Microsoft.CodeAnalysis.CSharp.Syntax.ArgumentListSyntax.Accept[TResult](CSharpSyntaxVisitor`1 visitor)
        '''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitInvocationExpression(InvocationExpressionSyntax node)
        '''    at Microsoft.CodeAnalysis.CSharp.Syntax.InvocationExpressionSyntax.Accept[TResult](CSharpSyntaxVisitor`1 visitor)
        '''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
        '''    at ICSharpCode.CodeConverter.VB.CommentConvertingNodesVisitor.DefaultVisit(SyntaxNode node)
        '''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.VisitInvocationExpression(InvocationExpressionSyntax node)
        '''    at Microsoft.CodeAnalysis.CSharp.Syntax.InvocationExpressionSyntax.Accept[TResult](CSharpSyntaxVisitor`1 visitor)
        '''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitBinaryExpression(BinaryExpressionSyntax node)
        '''    at Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax.Accept[TResult](CSharpSyntaxVisitor`1 visitor)
        '''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
        '''    at ICSharpCode.CodeConverter.VB.CommentConvertingNodesVisitor.DefaultVisit(SyntaxNode node)
        '''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.VisitBinaryExpression(BinaryExpressionSyntax node)
        '''    at Microsoft.CodeAnalysis.CSharp.Syntax.BinaryExpressionSyntax.Accept[TResult](CSharpSyntaxVisitor`1 visitor)
        '''    at ICSharpCode.CodeConverter.VB.CommonConversions.ConvertTopLevelExpression(ExpressionSyntax topLevelExpression)
        '''    at ICSharpCode.CodeConverter.VB.CommonConversions.RemodelVariableDeclaration(VariableDeclarationSyntax declaration)
        '''    at ICSharpCode.CodeConverter.VB.MethodBodyVisitor.VisitLocalDeclarationStatement(LocalDeclarationStatementSyntax node)
        '''    at Microsoft.CodeAnalysis.CSharp.Syntax.LocalDeclarationStatementSyntax.Accept[TResult](CSharpSyntaxVisitor`1 visitor)
        '''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
        '''    at ICSharpCode.CodeConverter.VB.CommentConvertingMethodBodyVisitor.ConvertWithTrivia(SyntaxNode node)
        '''    at ICSharpCode.CodeConverter.VB.CommentConvertingMethodBodyVisitor.DefaultVisit(SyntaxNode node)
        ''' 
        ''' Input: 
        ''' 
        ''''''''Int count = GetPrivateProfileSectionNames(pMem, Size * SizeOf(Of Char), FileName) - 1;

        ''' 
        '''''''''''If count > 0 Then temp = Marshal.PtrToStringUni(pMem, count)
        Marshal.FreeHGlobal(pMem)
        Return temp.Split(vbNullChar)
    End Function

    '''''''Public Sub DeleteKey(ByVal Key As String, ByVal Optional Section As String = Nothing)
    ''''''Return Write(Key, Nothing, Section)
    ''''''End Sub

    Public Sub DeleteSection(ByVal Optional Section As String = Nothing)
        '''''''Return Write(Nothing, Nothing, Section)
    End Sub

    Public Function KeyExists(ByVal Key As String, ByVal Optional Section As String = Nothing) As Boolean
        Return ReadString(Key, Section).Length > 0
    End Function

    Private Class CSharpImpl
        <Obsolete("Please refactor calling code to use normal Visual Basic assignment")>
        Shared Function __Assign(Of T)(ByRef target As T, value As T) As T
            target = value
            Return value
        End Function
    End Class
End Class
