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
using JetBrains.ReSharper.Psi.Tree;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree;
using JetBrains.ReSharper.Psi.RegExp.ClrRegex.Gen;
namespace JetBrains.ReSharper.Psi.RegExp.ClrRegex.Impl.Tree
{
  internal partial class ClrRegexNamedBlock : JetBrains.ReSharper.Psi.RegExp.ClrRegex.Impl.Tree.ClrRegexCompositeElement, JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexNamedBlock
  {
    public const short REGEXP_LBRACE = ChildRole.REGEXP_LBRACE;
    public const short REGEXP_NAME = ChildRole.REGEXP_NAME;
    public const short REGEXP_RBRACE = ChildRole.REGEXP_RBRACE;
    internal ClrRegexNamedBlock() : base() { }
    public override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType NodeType
    {
      get { return JetBrains.ReSharper.Psi.RegExp.ClrRegex.Impl.Tree.ElementType.CLR_REGEX_NAMED_BLOCK; }
    }
    public  void Accept(JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.TreeNodeVisitor visitor)
    {
      visitor.VisitClrRegexNamedBlock(this);
    }
    public  void Accept<TContext>(JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.TreeNodeVisitor<TContext> visitor, TContext context)
    {
      visitor.VisitClrRegexNamedBlock(this, context);
    }
    public  TReturn Accept<TContext, TReturn>(JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.TreeNodeVisitor<TContext, TReturn> visitor, TContext context)
    {
      return visitor.VisitClrRegexNamedBlock(this, context);
    }
    public override short GetChildRole(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.TreeElement child)
    {
      switch (child.NodeType.Index)
      {
        case JetBrains.ReSharper.Psi.RegExp.ClrRegex.Parsing.ClrRegexTokenTypes.LBRACE_NODE_TYPE_INDEX:
        return REGEXP_LBRACE;
        case JetBrains.ReSharper.Psi.RegExp.ClrRegex.Impl.Tree.ElementType.CLR_REGEX_NAME_NODE_TYPE_INDEX:
        return REGEXP_NAME;
        case JetBrains.ReSharper.Psi.RegExp.ClrRegex.Parsing.ClrRegexTokenTypes.RBRACE_NODE_TYPE_INDEX:
        return REGEXP_RBRACE;
      }
      return 0;
    }
    public virtual JetBrains.ReSharper.Psi.Tree.ITokenNode LBrace
    {
      get { return (JetBrains.ReSharper.Psi.Tree.ITokenNode) FindChildByRole(REGEXP_LBRACE); }
    }
    public virtual JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexName Name
    {
      get { return (JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexName) FindChildByRole(REGEXP_NAME); }
    }
    public virtual JetBrains.ReSharper.Psi.Tree.ITokenNode RBrace
    {
      get { return (JetBrains.ReSharper.Psi.Tree.ITokenNode) FindChildByRole(REGEXP_RBRACE); }
    }
    public virtual JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexName SetName(JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexName param)
    {
      using (JetBrains.ReSharper.Resources.Shell.WriteLockCookie.Create(this.IsPhysical()))
      {
        JetBrains.ReSharper.Psi.Tree.ITreeNode current = null, next = GetNextFilteredChild(current);
        JetBrains.ReSharper.Psi.RegExp.ClrRegex.Tree.IClrRegexName result = null;
        next = GetNextFilteredChild(current);
        if (next.NodeType == JetBrains.ReSharper.Psi.RegExp.ClrRegex.Parsing.ClrRegexTokenTypes.UNICODE_NAMED_BLOCK)
        {
          next = GetNextFilteredChild(current);
          if (next != null && next.NodeType == JetBrains.ReSharper.Psi.RegExp.ClrRegex.Parsing.ClrRegexTokenTypes.UNICODE_NAMED_BLOCK)
          {
            current = next;
          }
          else
          {
            return result;
          }
        }
        else if (next.NodeType == JetBrains.ReSharper.Psi.RegExp.ClrRegex.Parsing.ClrRegexTokenTypes.NONUNICODE_NAMED_BLOCK)
        {
          next = GetNextFilteredChild(current);
          if (next != null && next.NodeType == JetBrains.ReSharper.Psi.RegExp.ClrRegex.Parsing.ClrRegexTokenTypes.NONUNICODE_NAMED_BLOCK)
          {
            current = next;
          }
          else
          {
            return result;
          }
        }
        else
        {
          return null;
        }
        next = GetNextFilteredChild(current);
        if (next != null && next.NodeType == JetBrains.ReSharper.Psi.RegExp.ClrRegex.Parsing.ClrRegexTokenTypes.LBRACE)
        {
          current = next;
        }
        else
        {
          return result;
        }
        next = GetNextFilteredChild(current);
        if (next == null)
        {
          if (param == null) return null;
          current = result = JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ModificationUtil.AddChildAfter(this, current, param);
        }
        else if (next.NodeType == JetBrains.ReSharper.Psi.RegExp.ClrRegex.Impl.Tree.ElementType.CLR_REGEX_NAME)
        {
          if (param != null)
          {
            current = result = JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ModificationUtil.ReplaceChild(next, param);
          }
          else
          {
            current = GetNextFilteredChild(next);
            JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ModificationUtil.DeleteChild(next);
          }
        }
        else
        {
          if (param == null) return null;
          result = JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ModificationUtil.AddChildBefore(next, param);
          current = next;
        }
        return result;
      }
    }
    public override string ToString()
    {
      return "IClrRegexNamedBlock";
    }
  }
}