//------------------------------------------------------------------------------
// <auto-generated>
//     Generated by IntelliJ parserGen
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#pragma warning disable 0168, 0219, 0108, 0414, 0114
// ReSharper disable RedundantNameQualifier
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
namespace JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree
{
  public partial interface IClrRegexNumericQuantifier : JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexTreeNode
  {
    JetBrains.ReSharper.Psi.Tree.ITokenNode Comma { get; }
  
    JetBrains.ReSharper.Psi.Tree.ITokenNode LBrace { get; }
  
    JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexNumber Number { get; }
  
    JetBrains.ReSharper.Psi.Tree.ITokenNode RBrace { get; }
  
    JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexNumber SecondaryNumber { get; }
  
    JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexNumber SetNumber(JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexNumber param);
  
    JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexNumber SetSecondaryNumber(JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexNumber param);
  
  }
}