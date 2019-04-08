using System.Collections.Generic;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace SyntaxAPI
{
    internal class AverageMethodCalculator : CSharpSyntaxWalker
    {
        private readonly List<int> methodsPerClass = new List<int>();
        private int currentCount = 0;
        public float Result => ((float)methodsPerClass.Sum()) / methodsPerClass.Count;

        public override void VisitClassDeclaration(ClassDeclarationSyntax node)
        {
            base.VisitClassDeclaration(node);

            methodsPerClass.Add(currentCount);
            currentCount = 0;
        }

        public override void VisitMethodDeclaration(MethodDeclarationSyntax node)
        {
            base.VisitMethodDeclaration(node);

            currentCount++;
        }
    }
}
