using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.MSBuild;
using Microsoft.CodeAnalysis.Text;

namespace SyntaxAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            var workspace = MSBuildWorkspace.Create();
            var rootPath = @"..\..\..\..\.";
            var visitor = new AverageMethodCalculator();
            foreach (var filePath in Directory.EnumerateFiles(rootPath, "*.cs", SearchOption.AllDirectories))
            {
                var programText = File.ReadAllText(filePath);
                SyntaxTree tree = CSharpSyntaxTree.ParseText(programText);
                CompilationUnitSyntax root = tree.GetCompilationUnitRoot();

                visitor.Visit(root);
            }
            Console.WriteLine($"Ratio: {visitor.Result}");
        }
    }
}
