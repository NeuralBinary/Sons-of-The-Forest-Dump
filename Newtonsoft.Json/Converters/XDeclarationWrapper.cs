using System;
using System.Runtime.CompilerServices;
using System.Xml;
using System.Xml.Linq;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020001C9 RID: 457
	[Token(Token = "0x20001C9")]
	[NullableContext(2)]
	[Nullable(0)]
	internal class XDeclarationWrapper : XObjectWrapper, IXmlDeclaration, IXmlNode
	{
		// Token: 0x17000279 RID: 633
		// (get) Token: 0x06000F50 RID: 3920 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000279")]
		[Nullable(1)]
		internal XDeclaration Declaration
		{
			[Token(Token = "0x6000F50")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			[CompilerGenerated]
			[NullableContext(1)]
			get
			{
				return null;
			}
		}

		// Token: 0x06000F51 RID: 3921 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F51")]
		[Address(RVA = "0x25FC4C0", Offset = "0x25FAAC0", VA = "0x1825FC4C0")]
		[NullableContext(1)]
		public XDeclarationWrapper(XDeclaration declaration)
		{
		}

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x06000F52 RID: 3922 RVA: 0x00006F18 File Offset: 0x00005118
		[Token(Token = "0x1700027A")]
		public override XmlNodeType NodeType
		{
			[Token(Token = "0x6000F52")]
			[Address(RVA = "0x25FC580", Offset = "0x25FAB80", VA = "0x1825FC580", Slot = "14")]
			get
			{
				return XmlNodeType.None;
			}
		}

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x06000F53 RID: 3923 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x1700027B")]
		public string Version
		{
			[Token(Token = "0x6000F53")]
			[Address(RVA = "0x131BF00", Offset = "0x131A500", VA = "0x18131BF00", Slot = "23")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x06000F54 RID: 3924 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x06000F55 RID: 3925 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700027C")]
		public string Encoding
		{
			[Token(Token = "0x6000F54")]
			[Address(RVA = "0x131BF20", Offset = "0x131A520", VA = "0x18131BF20", Slot = "24")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000F55")]
			[Address(RVA = "0x25FC590", Offset = "0x25FAB90", VA = "0x1825FC590", Slot = "25")]
			set
			{
			}
		}

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x06000F56 RID: 3926 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x06000F57 RID: 3927 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700027D")]
		public string Standalone
		{
			[Token(Token = "0x6000F56")]
			[Address(RVA = "0x8F2390", Offset = "0x8F0990", VA = "0x1808F2390", Slot = "26")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000F57")]
			[Address(RVA = "0x25FC5F0", Offset = "0x25FABF0", VA = "0x1825FC5F0", Slot = "27")]
			set
			{
			}
		}
	}
}
