using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020001D2 RID: 466
	[Token(Token = "0x20001D2")]
	[Nullable(0)]
	[NullableContext(1)]
	internal class XElementWrapper : XContainerWrapper, IXmlElement, IXmlNode
	{
		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x06000F98 RID: 3992 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x170002A1")]
		private XElement Element
		{
			[Token(Token = "0x6000F98")]
			[Address(RVA = "0x25FF4C0", Offset = "0x25FDAC0", VA = "0x1825FF4C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000F99 RID: 3993 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F99")]
		[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
		public XElementWrapper(XElement element)
		{
		}

		// Token: 0x06000F9A RID: 3994 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F9A")]
		[Address(RVA = "0x25FF530", Offset = "0x25FDB30", VA = "0x1825FF530", Slot = "24")]
		public void SetAttributeNode(IXmlNode attribute)
		{
		}

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x06000F9B RID: 3995 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x170002A2")]
		public override List<IXmlNode> Attributes
		{
			[Token(Token = "0x6000F9B")]
			[Address(RVA = "0x25FF630", Offset = "0x25FDC30", VA = "0x1825FF630", Slot = "17")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000F9C RID: 3996 RVA: 0x00006F78 File Offset: 0x00005178
		[Token(Token = "0x6000F9C")]
		[Address(RVA = "0x25FFB30", Offset = "0x25FE130", VA = "0x1825FFB30")]
		private bool HasImplicitNamespaceAttribute(string namespaceUri)
		{
			return default(bool);
		}

		// Token: 0x06000F9D RID: 3997 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000F9D")]
		[Address(RVA = "0x25FFE60", Offset = "0x25FE460", VA = "0x1825FFE60", Slot = "21")]
		public override IXmlNode AppendChild(IXmlNode newChild)
		{
			return null;
		}

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x06000F9E RID: 3998 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x06000F9F RID: 3999 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002A3")]
		[Nullable(2)]
		public override string Value
		{
			[Token(Token = "0x6000F9E")]
			[Address(RVA = "0x25FFED0", Offset = "0x25FE4D0", VA = "0x1825FFED0", Slot = "19")]
			[NullableContext(2)]
			get
			{
				return null;
			}
			[Token(Token = "0x6000F9F")]
			[Address(RVA = "0x25FFF00", Offset = "0x25FE500", VA = "0x1825FFF00", Slot = "20")]
			[NullableContext(2)]
			set
			{
			}
		}

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x06000FA0 RID: 4000 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x170002A4")]
		[Nullable(2)]
		public override string LocalName
		{
			[Token(Token = "0x6000FA0")]
			[Address(RVA = "0x25FFFD0", Offset = "0x25FE5D0", VA = "0x1825FFFD0", Slot = "15")]
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x06000FA1 RID: 4001 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x170002A5")]
		[Nullable(2)]
		public override string NamespaceUri
		{
			[Token(Token = "0x6000FA1")]
			[Address(RVA = "0x2600000", Offset = "0x25FE600", VA = "0x182600000", Slot = "22")]
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x06000FA2 RID: 4002 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000FA2")]
		[Address(RVA = "0x2600040", Offset = "0x25FE640", VA = "0x182600040", Slot = "25")]
		public string GetPrefixOfNamespace(string namespaceUri)
		{
			return null;
		}

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x06000FA3 RID: 4003 RVA: 0x00006F90 File Offset: 0x00005190
		[Token(Token = "0x170002A6")]
		public bool IsEmpty
		{
			[Token(Token = "0x6000FA3")]
			[Address(RVA = "0x26000A0", Offset = "0x25FE6A0", VA = "0x1826000A0", Slot = "26")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0400081C RID: 2076
		[Token(Token = "0x400081C")]
		[FieldOffset(Offset = "0x20")]
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IXmlNode> _attributes;
	}
}
