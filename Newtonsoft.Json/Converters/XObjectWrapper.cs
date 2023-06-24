using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;
using System.Xml.Linq;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020001D0 RID: 464
	[Token(Token = "0x20001D0")]
	[NullableContext(2)]
	[Nullable(0)]
	internal class XObjectWrapper : IXmlNode
	{
		// Token: 0x06000F86 RID: 3974 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F86")]
		[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
		public XObjectWrapper(XObject xmlObject)
		{
		}

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x06000F87 RID: 3975 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000294")]
		public object WrappedNode
		{
			[Token(Token = "0x6000F87")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x06000F88 RID: 3976 RVA: 0x00006F60 File Offset: 0x00005160
		[Token(Token = "0x17000295")]
		public virtual XmlNodeType NodeType
		{
			[Token(Token = "0x6000F88")]
			[Address(RVA = "0x25FF070", Offset = "0x25FD670", VA = "0x1825FF070", Slot = "14")]
			get
			{
				return XmlNodeType.None;
			}
		}

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x06000F89 RID: 3977 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000296")]
		public virtual string LocalName
		{
			[Token(Token = "0x6000F89")]
			[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0", Slot = "15")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x06000F8A RID: 3978 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000297")]
		[Nullable(1)]
		public virtual List<IXmlNode> ChildNodes
		{
			[Token(Token = "0x6000F8A")]
			[Address(RVA = "0x25FF090", Offset = "0x25FD690", VA = "0x1825FF090", Slot = "16")]
			[NullableContext(1)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x06000F8B RID: 3979 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000298")]
		[Nullable(1)]
		public virtual List<IXmlNode> Attributes
		{
			[Token(Token = "0x6000F8B")]
			[Address(RVA = "0x25FF0E0", Offset = "0x25FD6E0", VA = "0x1825FF0E0", Slot = "17")]
			[NullableContext(1)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x06000F8C RID: 3980 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000299")]
		public virtual IXmlNode ParentNode
		{
			[Token(Token = "0x6000F8C")]
			[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0", Slot = "18")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x06000F8D RID: 3981 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x06000F8E RID: 3982 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700029A")]
		public virtual string Value
		{
			[Token(Token = "0x6000F8D")]
			[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0", Slot = "19")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000F8E")]
			[Address(RVA = "0x25FF130", Offset = "0x25FD730", VA = "0x1825FF130", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06000F8F RID: 3983 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000F8F")]
		[Address(RVA = "0x25FF170", Offset = "0x25FD770", VA = "0x1825FF170", Slot = "21")]
		[NullableContext(1)]
		public virtual IXmlNode AppendChild(IXmlNode newChild)
		{
			return null;
		}

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x06000F90 RID: 3984 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x1700029B")]
		public virtual string NamespaceUri
		{
			[Token(Token = "0x6000F90")]
			[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0", Slot = "22")]
			get
			{
				return null;
			}
		}

		// Token: 0x0400081B RID: 2075
		[Token(Token = "0x400081B")]
		[FieldOffset(Offset = "0x10")]
		private readonly XObject _xmlObject;
	}
}
