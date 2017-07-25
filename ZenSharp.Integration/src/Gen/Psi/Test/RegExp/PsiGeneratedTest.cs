//------------------------------------------------------------------------------
// <auto-generated>
//     Generated by IntelliJ parserGen
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#pragma warning disable 0168, 0219, 0108, 0414, 0114
// ReSharper disable RedundantNameQualifier
using System;
using System.IO;
using JetBrains.ReSharper.Psi.Parsing;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
namespace JetBrains.ReSharper.Psi.RegExp.ClrRegex.Impl.Tree
{
  public partial class PsiGeneratedGetterTestUtil : PsiGetterTestUtil
  {
      internal static void TestClrConcatenationRegularExpression(int level, JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrConcatenationRegularExpression param, String caller)
    {
      if (!CanVisitFurther(param)) return;
      VisitElement (level, param, caller);
      {
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrQuantifiableRegularExpression> children = ((JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrConcatenationRegularExpression) param).QuantifiableRegularExpressions;
        foreach (JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrQuantifiableRegularExpression child in children)
        TestClrQuantifiableRegularExpression(level + 1, (JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrQuantifiableRegularExpression) child, "QuantifiableRegularExpressions");
      }
    }
      internal static void TestClrQuantifiableRegularExpression(int level, JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrQuantifiableRegularExpression param, String caller)
    {
      if (!CanVisitFurther(param)) return;
      VisitElement (level, param, caller);
      {
        JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexQuantifierOwner child = ((JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrQuantifiableRegularExpression)param).Owner;
        TestClrRegexQuantifierOwner(level + 1, (JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexQuantifierOwner)child, "Owner");
      }
      {
        JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexQuantifier child = ((JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrQuantifiableRegularExpression)param).Quantifier;
        TestClrRegexQuantifier(level + 1, (JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexQuantifier)child, "Quantifier");
      }
    }
      internal static void TestClrRegexAlternationGroup(int level, JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexAlternationGroup param, String caller)
    {
      if (!CanVisitFurther(param)) return;
      VisitElement (level, param, caller);
      {
        JetBrains.ReSharper.Psi.Tree.ITokenNode child = ((JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexAlternationGroup)param).AltLParenth;
        TestTokenNode(level + 1, (JetBrains.ReSharper.Psi.Tree.ITokenNode)child, "AltLParenth");
      }
      {
        JetBrains.ReSharper.Psi.Tree.ITokenNode child = ((JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexAlternationGroup)param).AltRParenth;
        TestTokenNode(level + 1, (JetBrains.ReSharper.Psi.Tree.ITokenNode)child, "AltRParenth");
      }
      {
        JetBrains.ReSharper.Psi.Tree.ITokenNode child = ((JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexAlternationGroup)param).LongPrefix;
        TestTokenNode(level + 1, (JetBrains.ReSharper.Psi.Tree.ITokenNode)child, "LongPrefix");
      }
      {
        JetBrains.ReSharper.Psi.Tree.ITokenNode child = ((JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexAlternationGroup)param).LParenth;
        TestTokenNode(level + 1, (JetBrains.ReSharper.Psi.Tree.ITokenNode)child, "LParenth");
      }
      {
        JetBrains.ReSharper.Psi.Tree.ITokenNode child = ((JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexAlternationGroup)param).Pipe;
        TestTokenNode(level + 1, (JetBrains.ReSharper.Psi.Tree.ITokenNode)child, "Pipe");
      }
      {
        JetBrains.ReSharper.Psi.Tree.ITokenNode child = ((JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexAlternationGroup)param).Prefix;
        TestTokenNode(level + 1, (JetBrains.ReSharper.Psi.Tree.ITokenNode)child, "Prefix");
      }
      {
        JetBrains.ReSharper.Psi.Tree.ITokenNode child = ((JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexAlternationGroup)param).QuestionSign;
        TestTokenNode(level + 1, (JetBrains.ReSharper.Psi.Tree.ITokenNode)child, "QuestionSign");
      }
      {
        JetBrains.ReSharper.Psi.Tree.ITokenNode child = ((JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexAlternationGroup)param).RParenth;
        TestTokenNode(level + 1, (JetBrains.ReSharper.Psi.Tree.ITokenNode)child, "RParenth");
      }
    }
      internal static void TestClrRegexAnchor(int level, JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexAnchor param, String caller)
    {
      if (!CanVisitFurther(param)) return;
      if (param is JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexStartAnchor) TestClrRegexStartAnchor(level, (JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexStartAnchor) param, caller);
      else if (param is JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexEndAnchor) TestClrRegexEndAnchor(level, (JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexEndAnchor) param, caller);
      else if (param is JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexBorderAnchor) TestClrRegexBorderAnchor(level, (JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexBorderAnchor) param, caller);
      else throw new System.InvalidOperationException();
    }
      internal static void TestClrRegexBorderAnchor(int level, JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexBorderAnchor param, String caller)
    {
      if (!CanVisitFurther(param)) return;
      VisitElement (level, param, caller);
    }
      internal static void TestClrRegexBracketCharacter(int level, JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexBracketCharacter param, String caller)
    {
      if (!CanVisitFurther(param)) return;
      VisitElement (level, param, caller);
    }
      internal static void TestClrRegexCharacter(int level, JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexCharacter param, String caller)
    {
      if (!CanVisitFurther(param)) return;
      if (param is JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexSymbolCharacter) TestClrRegexSymbolCharacter(level, (JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexSymbolCharacter) param, caller);
      else if (param is JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexInvalidCharacter) TestClrRegexInvalidCharacter(level, (JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexInvalidCharacter) param, caller);
      else if (param is JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexEscapeCharacter) TestClrRegexEscapeCharacter(level, (JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexEscapeCharacter) param, caller);
      else if (param is JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexRegularCharacter) TestClrRegexRegularCharacter(level, (JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexRegularCharacter) param, caller);
      else if (param is JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexBracketCharacter) TestClrRegexBracketCharacter(level, (JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexBracketCharacter) param, caller);
      else throw new System.InvalidOperationException();
    }
      internal static void TestClrRegexEndAnchor(int level, JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexEndAnchor param, String caller)
    {
      if (!CanVisitFurther(param)) return;
      VisitElement (level, param, caller);
    }
      internal static void TestClrRegexEscapeCharacter(int level, JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexEscapeCharacter param, String caller)
    {
      if (!CanVisitFurther(param)) return;
      VisitElement (level, param, caller);
    }
      internal static void TestClrRegexGroup(int level, JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexGroup param, String caller)
    {
      if (!CanVisitFurther(param)) return;
      if (param is JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexSimpleGroup) TestClrRegexSimpleGroup(level, (JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexSimpleGroup) param, caller);
      else if (param is JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexNamedGroup) TestClrRegexNamedGroup(level, (JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexNamedGroup) param, caller);
      else if (param is JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexPrefixGroup) TestClrRegexPrefixGroup(level, (JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexPrefixGroup) param, caller);
      else if (param is JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexOptionGroup) TestClrRegexOptionGroup(level, (JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexOptionGroup) param, caller);
      else if (param is JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexAlternationGroup) TestClrRegexAlternationGroup(level, (JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexAlternationGroup) param, caller);
      else throw new System.InvalidOperationException();
    }
      internal static void TestClrRegexGroupName(int level, JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexGroupName param, String caller)
    {
      if (!CanVisitFurther(param)) return;
      VisitElement (level, param, caller);
      {
        JetBrains.ReSharper.Psi.Tree.ITokenNode child = ((JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexGroupName)param).Dash;
        TestTokenNode(level + 1, (JetBrains.ReSharper.Psi.Tree.ITokenNode)child, "Dash");
      }
      {
        JetBrains.ReSharper.Psi.Tree.ITokenNode child = ((JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexGroupName)param).Gt;
        TestTokenNode(level + 1, (JetBrains.ReSharper.Psi.Tree.ITokenNode)child, "Gt");
      }
      {
        JetBrains.ReSharper.Psi.Tree.ITokenNode child = ((JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexGroupName)param).Lt;
        TestTokenNode(level + 1, (JetBrains.ReSharper.Psi.Tree.ITokenNode)child, "Lt");
      }
      {
        JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexName child = ((JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexGroupName)param).Name;
        TestClrRegexName(level + 1, (JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexName)child, "Name");
      }
      {
        JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexName child = ((JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexGroupName)param).SecondaryName;
        TestClrRegexName(level + 1, (JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexName)child, "SecondaryName");
      }
    }
      internal static void TestClrRegexGroupPrefix(int level, JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexGroupPrefix param, String caller)
    {
      if (!CanVisitFurther(param)) return;
      VisitElement (level, param, caller);
      {
        JetBrains.ReSharper.Psi.Tree.ITokenNode child = ((JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexGroupPrefix)param).LongPrefix;
        TestTokenNode(level + 1, (JetBrains.ReSharper.Psi.Tree.ITokenNode)child, "LongPrefix");
      }
      {
        JetBrains.ReSharper.Psi.Tree.ITokenNode child = ((JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexGroupPrefix)param).Lt;
        TestTokenNode(level + 1, (JetBrains.ReSharper.Psi.Tree.ITokenNode)child, "Lt");
      }
      {
        JetBrains.ReSharper.Psi.Tree.ITokenNode child = ((JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexGroupPrefix)param).Prefix;
        TestTokenNode(level + 1, (JetBrains.ReSharper.Psi.Tree.ITokenNode)child, "Prefix");
      }
    }
      internal static void TestClrRegexInvalidCharacter(int level, JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexInvalidCharacter param, String caller)
    {
      if (!CanVisitFurther(param)) return;
      VisitElement (level, param, caller);
    }
      internal static void TestClrRegexName(int level, JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexName param, String caller)
    {
      if (!CanVisitFurther(param)) return;
      VisitElement (level, param, caller);
    }
      internal static void TestClrRegexNamedBackreference(int level, JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexNamedBackreference param, String caller)
    {
      if (!CanVisitFurther(param)) return;
      VisitElement (level, param, caller);
      {
        JetBrains.ReSharper.Psi.Tree.ITokenNode child = ((JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexNamedBackreference)param).Gt;
        TestTokenNode(level + 1, (JetBrains.ReSharper.Psi.Tree.ITokenNode)child, "Gt");
      }
      {
        JetBrains.ReSharper.Psi.Tree.ITokenNode child = ((JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexNamedBackreference)param).Lt;
        TestTokenNode(level + 1, (JetBrains.ReSharper.Psi.Tree.ITokenNode)child, "Lt");
      }
      {
        JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexName child = ((JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexNamedBackreference)param).Name;
        TestClrRegexName(level + 1, (JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexName)child, "Name");
      }
      {
        JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexNumber child = ((JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexNamedBackreference)param).NAME;
        TestClrRegexNumber(level + 1, (JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexNumber)child, "NAME");
      }
    }
      internal static void TestClrRegexNamedBlock(int level, JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexNamedBlock param, String caller)
    {
      if (!CanVisitFurther(param)) return;
      VisitElement (level, param, caller);
      {
        JetBrains.ReSharper.Psi.Tree.ITokenNode child = ((JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexNamedBlock)param).LBrace;
        TestTokenNode(level + 1, (JetBrains.ReSharper.Psi.Tree.ITokenNode)child, "LBrace");
      }
      {
        JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexName child = ((JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexNamedBlock)param).Name;
        TestClrRegexName(level + 1, (JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexName)child, "Name");
      }
      {
        JetBrains.ReSharper.Psi.Tree.ITokenNode child = ((JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexNamedBlock)param).RBrace;
        TestTokenNode(level + 1, (JetBrains.ReSharper.Psi.Tree.ITokenNode)child, "RBrace");
      }
    }
      internal static void TestClrRegexNamedGroup(int level, JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexNamedGroup param, String caller)
    {
      if (!CanVisitFurther(param)) return;
      VisitElement (level, param, caller);
      {
        JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexGroupName child = ((JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexNamedGroup)param).GroupName;
        TestClrRegexGroupName(level + 1, (JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexGroupName)child, "GroupName");
      }
      {
        JetBrains.ReSharper.Psi.Tree.ITokenNode child = ((JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexNamedGroup)param).LParenth;
        TestTokenNode(level + 1, (JetBrains.ReSharper.Psi.Tree.ITokenNode)child, "LParenth");
      }
      {
        JetBrains.ReSharper.Psi.Tree.ITokenNode child = ((JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexNamedGroup)param).QuestionSign;
        TestTokenNode(level + 1, (JetBrains.ReSharper.Psi.Tree.ITokenNode)child, "QuestionSign");
      }
      {
        JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegularExpression child = ((JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexNamedGroup)param).RegularExpression;
        TestClrRegularExpression(level + 1, (JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegularExpression)child, "RegularExpression");
      }
      {
        JetBrains.ReSharper.Psi.Tree.ITokenNode child = ((JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexNamedGroup)param).RParenth;
        TestTokenNode(level + 1, (JetBrains.ReSharper.Psi.Tree.ITokenNode)child, "RParenth");
      }
    }
      internal static void TestClrRegexNestedSet(int level, JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexNestedSet param, String caller)
    {
      if (!CanVisitFurther(param)) return;
      VisitElement (level, param, caller);
      {
        JetBrains.ReSharper.Psi.Tree.ITokenNode child = ((JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexNestedSet)param).Dash;
        TestTokenNode(level + 1, (JetBrains.ReSharper.Psi.Tree.ITokenNode)child, "Dash");
      }
      {
        JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexSet child = ((JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexNestedSet)param).InnerSet;
        TestClrRegexSet(level + 1, (JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexSet)child, "InnerSet");
      }
    }
      internal static void TestClrRegexNumber(int level, JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexNumber param, String caller)
    {
      if (!CanVisitFurther(param)) return;
      VisitElement (level, param, caller);
    }
      internal static void TestClrRegexNumericQuantifier(int level, JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexNumericQuantifier param, String caller)
    {
      if (!CanVisitFurther(param)) return;
      VisitElement (level, param, caller);
      {
        JetBrains.ReSharper.Psi.Tree.ITokenNode child = ((JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexNumericQuantifier)param).Comma;
        TestTokenNode(level + 1, (JetBrains.ReSharper.Psi.Tree.ITokenNode)child, "Comma");
      }
      {
        JetBrains.ReSharper.Psi.Tree.ITokenNode child = ((JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexNumericQuantifier)param).LBrace;
        TestTokenNode(level + 1, (JetBrains.ReSharper.Psi.Tree.ITokenNode)child, "LBrace");
      }
      {
        JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexNumber child = ((JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexNumericQuantifier)param).Number;
        TestClrRegexNumber(level + 1, (JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexNumber)child, "Number");
      }
      {
        JetBrains.ReSharper.Psi.Tree.ITokenNode child = ((JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexNumericQuantifier)param).RBrace;
        TestTokenNode(level + 1, (JetBrains.ReSharper.Psi.Tree.ITokenNode)child, "RBrace");
      }
      {
        JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexNumber child = ((JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexNumericQuantifier)param).SecondaryNumber;
        TestClrRegexNumber(level + 1, (JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexNumber)child, "SecondaryNumber");
      }
    }
      internal static void TestClrRegexOptionGroup(int level, JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexOptionGroup param, String caller)
    {
      if (!CanVisitFurther(param)) return;
      VisitElement (level, param, caller);
      {
        JetBrains.ReSharper.Psi.Tree.ITokenNode child = ((JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexOptionGroup)param).Colon;
        TestTokenNode(level + 1, (JetBrains.ReSharper.Psi.Tree.ITokenNode)child, "Colon");
      }
      {
        JetBrains.ReSharper.Psi.Tree.ITokenNode child = ((JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexOptionGroup)param).Dash;
        TestTokenNode(level + 1, (JetBrains.ReSharper.Psi.Tree.ITokenNode)child, "Dash");
      }
      {
        JetBrains.ReSharper.Psi.Tree.ITokenNode child = ((JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexOptionGroup)param).LParenth;
        TestTokenNode(level + 1, (JetBrains.ReSharper.Psi.Tree.ITokenNode)child, "LParenth");
      }
      {
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.Tree.ITokenNode> children = ((JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexOptionGroup) param).Options;
        foreach (JetBrains.ReSharper.Psi.Tree.ITokenNode child in children)
        TestTokenNode(level + 1, (JetBrains.ReSharper.Psi.Tree.ITokenNode) child, "Options");
      }
      {
        JetBrains.ReSharper.Psi.Tree.ITokenNode child = ((JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexOptionGroup)param).QuestionSign;
        TestTokenNode(level + 1, (JetBrains.ReSharper.Psi.Tree.ITokenNode)child, "QuestionSign");
      }
      {
        JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegularExpression child = ((JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexOptionGroup)param).RegularExpression;
        TestClrRegularExpression(level + 1, (JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegularExpression)child, "RegularExpression");
      }
      {
        JetBrains.ReSharper.Psi.Tree.ITokenNode child = ((JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexOptionGroup)param).RParenth;
        TestTokenNode(level + 1, (JetBrains.ReSharper.Psi.Tree.ITokenNode)child, "RParenth");
      }
    }
      internal static void TestClrRegexPrefixGroup(int level, JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexPrefixGroup param, String caller)
    {
      if (!CanVisitFurther(param)) return;
      VisitElement (level, param, caller);
      {
        JetBrains.ReSharper.Psi.Tree.ITokenNode child = ((JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexPrefixGroup)param).LParenth;
        TestTokenNode(level + 1, (JetBrains.ReSharper.Psi.Tree.ITokenNode)child, "LParenth");
      }
      {
        JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexGroupPrefix child = ((JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexPrefixGroup)param).Prefix;
        TestClrRegexGroupPrefix(level + 1, (JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexGroupPrefix)child, "Prefix");
      }
      {
        JetBrains.ReSharper.Psi.Tree.ITokenNode child = ((JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexPrefixGroup)param).QuestionSign;
        TestTokenNode(level + 1, (JetBrains.ReSharper.Psi.Tree.ITokenNode)child, "QuestionSign");
      }
      {
        JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegularExpression child = ((JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexPrefixGroup)param).RegularExpression;
        TestClrRegularExpression(level + 1, (JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegularExpression)child, "RegularExpression");
      }
      {
        JetBrains.ReSharper.Psi.Tree.ITokenNode child = ((JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexPrefixGroup)param).RParenth;
        TestTokenNode(level + 1, (JetBrains.ReSharper.Psi.Tree.ITokenNode)child, "RParenth");
      }
    }
      internal static void TestClrRegexQuantifier(int level, JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexQuantifier param, String caller)
    {
      if (!CanVisitFurther(param)) return;
      VisitElement (level, param, caller);
      {
        JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexNumericQuantifier child = ((JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexQuantifier)param).Numeric;
        TestClrRegexNumericQuantifier(level + 1, (JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexNumericQuantifier)child, "Numeric");
      }
      {
        JetBrains.ReSharper.Psi.Tree.ITokenNode child = ((JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexQuantifier)param).OptionalQuestion;
        TestTokenNode(level + 1, (JetBrains.ReSharper.Psi.Tree.ITokenNode)child, "OptionalQuestion");
      }
      {
        JetBrains.ReSharper.Psi.Tree.ITokenNode child = ((JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexQuantifier)param).Plus;
        TestTokenNode(level + 1, (JetBrains.ReSharper.Psi.Tree.ITokenNode)child, "Plus");
      }
      {
        JetBrains.ReSharper.Psi.Tree.ITokenNode child = ((JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexQuantifier)param).Question;
        TestTokenNode(level + 1, (JetBrains.ReSharper.Psi.Tree.ITokenNode)child, "Question");
      }
      {
        JetBrains.ReSharper.Psi.Tree.ITokenNode child = ((JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexQuantifier)param).Star;
        TestTokenNode(level + 1, (JetBrains.ReSharper.Psi.Tree.ITokenNode)child, "Star");
      }
    }
      internal static void TestClrRegexQuantifierOwner(int level, JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexQuantifierOwner param, String caller)
    {
      if (!CanVisitFurther(param)) return;
      if (param is JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexGroup) TestClrRegexGroup(level, (JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexGroup) param, caller);
      else if (param is JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexCharacter) TestClrRegexCharacter(level, (JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexCharacter) param, caller);
      else if (param is JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexSet) TestClrRegexSet(level, (JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexSet) param, caller);
      else if (param is JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexAnchor) TestClrRegexAnchor(level, (JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexAnchor) param, caller);
      else throw new System.InvalidOperationException();
    }
      internal static void TestClrRegexRegularCharacter(int level, JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexRegularCharacter param, String caller)
    {
      if (!CanVisitFurther(param)) return;
      VisitElement (level, param, caller);
    }
      internal static void TestClrRegexSet(int level, JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexSet param, String caller)
    {
      if (!CanVisitFurther(param)) return;
      VisitElement (level, param, caller);
      {
        JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexSetBody child = ((JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexSet)param).Body;
        TestClrRegexSetBody(level + 1, (JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexSetBody)child, "Body");
      }
      {
        JetBrains.ReSharper.Psi.Tree.ITokenNode child = ((JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexSet)param).LBracket;
        TestTokenNode(level + 1, (JetBrains.ReSharper.Psi.Tree.ITokenNode)child, "LBracket");
      }
      {
        JetBrains.ReSharper.Psi.Tree.ITokenNode child = ((JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexSet)param).NegativeMark;
        TestTokenNode(level + 1, (JetBrains.ReSharper.Psi.Tree.ITokenNode)child, "NegativeMark");
      }
      {
        JetBrains.ReSharper.Psi.Tree.ITokenNode child = ((JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexSet)param).RBracket;
        TestTokenNode(level + 1, (JetBrains.ReSharper.Psi.Tree.ITokenNode)child, "RBracket");
      }
    }
      internal static void TestClrRegexSetBody(int level, JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexSetBody param, String caller)
    {
      if (!CanVisitFurther(param)) return;
      VisitElement (level, param, caller);
    }
      internal static void TestClrRegexSetBodyCharacter(int level, JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexSetBodyCharacter param, String caller)
    {
      if (!CanVisitFurther(param)) return;
      if (param is JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexSymbolCharacter) TestClrRegexSymbolCharacter(level, (JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexSymbolCharacter) param, caller);
      else if (param is JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexInvalidCharacter) TestClrRegexInvalidCharacter(level, (JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexInvalidCharacter) param, caller);
      else if (param is JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexEscapeCharacter) TestClrRegexEscapeCharacter(level, (JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexEscapeCharacter) param, caller);
      else if (param is JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexRegularCharacter) TestClrRegexRegularCharacter(level, (JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexRegularCharacter) param, caller);
      else if (param is JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexSetCharacter) TestClrRegexSetCharacter(level, (JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexSetCharacter) param, caller);
      else throw new System.InvalidOperationException();
    }
      internal static void TestClrRegexSetBodyItem(int level, JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexSetBodyItem param, String caller)
    {
      if (!CanVisitFurther(param)) return;
      if (param is JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexSetBodyCharacter) TestClrRegexSetBodyCharacter(level, (JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexSetBodyCharacter) param, caller);
      else if (param is JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexSetRange) TestClrRegexSetRange(level, (JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexSetRange) param, caller);
      else if (param is JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexNestedSet) TestClrRegexNestedSet(level, (JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexNestedSet) param, caller);
      else throw new System.InvalidOperationException();
    }
      internal static void TestClrRegexSetCharacter(int level, JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexSetCharacter param, String caller)
    {
      if (!CanVisitFurther(param)) return;
      VisitElement (level, param, caller);
    }
      internal static void TestClrRegexSetRange(int level, JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexSetRange param, String caller)
    {
      if (!CanVisitFurther(param)) return;
      VisitElement (level, param, caller);
      {
        JetBrains.ReSharper.Psi.Tree.ITokenNode child = ((JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexSetRange)param).Dash;
        TestTokenNode(level + 1, (JetBrains.ReSharper.Psi.Tree.ITokenNode)child, "Dash");
      }
      {
        JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexSetRangeItem child = ((JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexSetRange)param).Max;
        TestClrRegexSetRangeItem(level + 1, (JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexSetRangeItem)child, "Max");
      }
      {
        JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexSetRangeItem child = ((JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexSetRange)param).Min;
        TestClrRegexSetRangeItem(level + 1, (JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexSetRangeItem)child, "Min");
      }
    }
      internal static void TestClrRegexSetRangeItem(int level, JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexSetRangeItem param, String caller)
    {
      if (!CanVisitFurther(param)) return;
      VisitElement (level, param, caller);
    }
      internal static void TestClrRegexSimpleGroup(int level, JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexSimpleGroup param, String caller)
    {
      if (!CanVisitFurther(param)) return;
      VisitElement (level, param, caller);
      {
        JetBrains.ReSharper.Psi.Tree.ITokenNode child = ((JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexSimpleGroup)param).LParenth;
        TestTokenNode(level + 1, (JetBrains.ReSharper.Psi.Tree.ITokenNode)child, "LParenth");
      }
      {
        JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegularExpression child = ((JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexSimpleGroup)param).RegularExpression;
        TestClrRegularExpression(level + 1, (JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegularExpression)child, "RegularExpression");
      }
      {
        JetBrains.ReSharper.Psi.Tree.ITokenNode child = ((JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexSimpleGroup)param).RParenth;
        TestTokenNode(level + 1, (JetBrains.ReSharper.Psi.Tree.ITokenNode)child, "RParenth");
      }
    }
      internal static void TestClrRegexStartAnchor(int level, JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexStartAnchor param, String caller)
    {
      if (!CanVisitFurther(param)) return;
      VisitElement (level, param, caller);
    }
      internal static void TestClrRegexSymbolCharacter(int level, JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexSymbolCharacter param, String caller)
    {
      if (!CanVisitFurther(param)) return;
      VisitElement (level, param, caller);
    }
      internal static void TestClrRegularExpression(int level, JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegularExpression param, String caller)
    {
      if (!CanVisitFurther(param)) return;
      VisitElement (level, param, caller);
      {
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrConcatenationRegularExpression> children = ((JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegularExpression) param).ConcatenationRegularExpressions;
        foreach (JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrConcatenationRegularExpression child in children)
        TestClrConcatenationRegularExpression(level + 1, (JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrConcatenationRegularExpression) child, "ConcatenationRegularExpressions");
      }
      {
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.Tree.ITokenNode> children = ((JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegularExpression) param).Pipes;
        foreach (JetBrains.ReSharper.Psi.Tree.ITokenNode child in children)
        TestTokenNode(level + 1, (JetBrains.ReSharper.Psi.Tree.ITokenNode) child, "Pipes");
      }
    }
      internal static void TestClrRegularExpressionFile(int level, JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegularExpressionFile param, String caller)
    {
      if (!CanVisitFurther(param)) return;
      VisitElement (level, param, caller);
      {
        JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegularExpression child = ((JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegularExpressionFile)param).RegularExpression;
        TestClrRegularExpression(level + 1, (JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegularExpression)child, "RegularExpression");
      }
    }
    }
}