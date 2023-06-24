using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020001C3 RID: 451
	[Token(Token = "0x20001C3")]
	[Nullable(0)]
	[NullableContext(2)]
	internal class XmlNodeWrapper : IXmlNode
	{
		// Token: 0x06000F1F RID: 3871 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F1F")]
		[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
		[NullableContext(1)]
		public XmlNodeWrapper(XmlNode node)
		{
		}

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x06000F20 RID: 3872 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x1700025E")]
		public object WrappedNode
		{
			[Token(Token = "0x6000F20")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x06000F21 RID: 3873 RVA: 0x00006ED0 File Offset: 0x000050D0
		[Token(Token = "0x1700025F")]
		public XmlNodeType NodeType
		{
			[Token(Token = "0x6000F21")]
			[Address(RVA = "0x21B9400", Offset = "0x21B7A00", VA = "0x1821B9400", Slot = "4")]
			get
			{
				return XmlNodeType.None;
			}
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x06000F22 RID: 3874 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000260")]
		public virtual string LocalName
		{
			[Token(Token = "0x6000F22")]
			[Address(RVA = "0x25FB250", Offset = "0x25F9850", VA = "0x1825FB250", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x06000F23 RID: 3875 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000261")]
		[Nullable(1)]
		public List<IXmlNode> ChildNodes
		{
			[Token(Token = "0x6000F23")]
			[Address(RVA = "0x25FB280", Offset = "0x25F9880", VA = "0x1825FB280", Slot = "6")]
			[NullableContext(1)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x06000F24 RID: 3876 RVA: 0x00006EE8 File Offset: 0x000050E8
		[Token(Token = "0x17000262")]
		protected virtual bool HasChildNodes
		{
			[Token(Token = "0x6000F24")]
			[Address(RVA = "0x25FB8B0", Offset = "0x25F9EB0", VA = "0x1825FB8B0", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000F25 RID: 3877 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000F25")]
		[Address(RVA = "0x25FB8E0", Offset = "0x25F9EE0", VA = "0x1825FB8E0")]
		[NullableContext(1)]
		internal static IXmlNode WrapNode(XmlNode node)
		{
			return null;
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x06000F26 RID: 3878 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000263")]
		[Nullable(1)]
		public List<IXmlNode> Attributes
		{
			[Token(Token = "0x6000F26")]
			[Address(RVA = "0x25FBAE0", Offset = "0x25FA0E0", VA = "0x1825FBAE0", Slot = "7")]
			[NullableContext(1)]
			get
			{
				return null;
			}
		}

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x06000F27 RID: 3879 RVA: 0x00006F00 File Offset: 0x00005100
		[Token(Token = "0x17000264")]
		private bool HasAttributes
		{
			[Token(Token = "0x6000F27")]
			[Address(RVA = "0x25FC180", Offset = "0x25FA780", VA = "0x1825FC180")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x06000F28 RID: 3880 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000265")]
		public IXmlNode ParentNode
		{
			[Token(Token = "0x6000F28")]
			[Address(RVA = "0x25FC240", Offset = "0x25FA840", VA = "0x1825FC240", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x06000F29 RID: 3881 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x06000F2A RID: 3882 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000266")]
		public string Value
		{
			[Token(Token = "0x6000F29")]
			[Address(RVA = "0x25FC2E0", Offset = "0x25FA8E0", VA = "0x1825FC2E0", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000F2A")]
			[Address(RVA = "0x25FC310", Offset = "0x25FA910", VA = "0x1825FC310", Slot = "10")]
			set
			{
			}
		}

		// Token: 0x06000F2B RID: 3883 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000F2B")]
		[Address(RVA = "0x25FC340", Offset = "0x25FA940", VA = "0x1825FC340", Slot = "11")]
		[NullableContext(1)]
		public IXmlNode AppendChild(IXmlNode newChild)
		{
			return null;
		}

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x06000F2C RID: 3884 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000267")]
		public string NamespaceUri
		{
			[Token(Token = "0x6000F2C")]
			[Address(RVA = "0x25FC490", Offset = "0x25FAA90", VA = "0x1825FC490", Slot = "12")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000815 RID: 2069
		[Token(Token = "0x4000815")]
		[FieldOffset(Offset = "0x10")]
		[Nullable(1)]
		private readonly XmlNode _node;

		// Token: 0x04000816 RID: 2070
		[Token(Token = "0x4000816")]
		[FieldOffset(Offset = "0x18")]
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IXmlNode> _childNodes;

		// Token: 0x04000817 RID: 2071
		[Token(Token = "0x4000817")]
		[FieldOffset(Offset = "0x20")]
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IXmlNode> _attributes;
	}
}
