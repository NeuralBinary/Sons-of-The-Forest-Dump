using System;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020001CA RID: 458
	[Token(Token = "0x20001CA")]
	[NullableContext(2)]
	[Nullable(0)]
	internal class XDocumentTypeWrapper : XObjectWrapper, IXmlDocumentType, IXmlNode
	{
		// Token: 0x06000F58 RID: 3928 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F58")]
		[Address(RVA = "0x2392BE0", Offset = "0x23911E0", VA = "0x182392BE0")]
		[NullableContext(1)]
		public XDocumentTypeWrapper(XDocumentType documentType)
		{
		}

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x06000F59 RID: 3929 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x1700027E")]
		[Nullable(1)]
		public string Name
		{
			[Token(Token = "0x6000F59")]
			[Address(RVA = "0x25FC650", Offset = "0x25FAC50", VA = "0x1825FC650", Slot = "23")]
			[NullableContext(1)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x06000F5A RID: 3930 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x1700027F")]
		public string System
		{
			[Token(Token = "0x6000F5A")]
			[Address(RVA = "0x25FC670", Offset = "0x25FAC70", VA = "0x1825FC670", Slot = "24")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x06000F5B RID: 3931 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000280")]
		public string Public
		{
			[Token(Token = "0x6000F5B")]
			[Address(RVA = "0x25FC690", Offset = "0x25FAC90", VA = "0x1825FC690", Slot = "25")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x06000F5C RID: 3932 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000281")]
		public string InternalSubset
		{
			[Token(Token = "0x6000F5C")]
			[Address(RVA = "0x25FC6B0", Offset = "0x25FACB0", VA = "0x1825FC6B0", Slot = "26")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x06000F5D RID: 3933 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000282")]
		public override string LocalName
		{
			[Token(Token = "0x6000F5D")]
			[Address(RVA = "0x25FC6D0", Offset = "0x25FACD0", VA = "0x1825FC6D0", Slot = "15")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000819 RID: 2073
		[Token(Token = "0x4000819")]
		[FieldOffset(Offset = "0x18")]
		[Nullable(1)]
		private readonly XDocumentType _documentType;
	}
}
