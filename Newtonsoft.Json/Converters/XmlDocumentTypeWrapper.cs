using System;
using System.Runtime.CompilerServices;
using System.Xml;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020001C2 RID: 450
	[Token(Token = "0x20001C2")]
	[NullableContext(2)]
	[Nullable(0)]
	internal class XmlDocumentTypeWrapper : XmlNodeWrapper, IXmlDocumentType, IXmlNode
	{
		// Token: 0x06000F19 RID: 3865 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F19")]
		[Address(RVA = "0x25FA490", Offset = "0x25F8A90", VA = "0x1825FA490")]
		[NullableContext(1)]
		public XmlDocumentTypeWrapper(XmlDocumentType documentType)
		{
		}

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x06000F1A RID: 3866 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000259")]
		[Nullable(1)]
		public string Name
		{
			[Token(Token = "0x6000F1A")]
			[Address(RVA = "0x25FB1F0", Offset = "0x25F97F0", VA = "0x1825FB1F0", Slot = "16")]
			[NullableContext(1)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x06000F1B RID: 3867 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x1700025A")]
		public string System
		{
			[Token(Token = "0x6000F1B")]
			[Address(RVA = "0x25FB1B0", Offset = "0x25F97B0", VA = "0x1825FB1B0", Slot = "17")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x06000F1C RID: 3868 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x1700025B")]
		public string Public
		{
			[Token(Token = "0x6000F1C")]
			[Address(RVA = "0x7453E0", Offset = "0x7439E0", VA = "0x1807453E0", Slot = "18")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x06000F1D RID: 3869 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x1700025C")]
		public string InternalSubset
		{
			[Token(Token = "0x6000F1D")]
			[Address(RVA = "0x612390", Offset = "0x610990", VA = "0x180612390", Slot = "19")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x06000F1E RID: 3870 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x1700025D")]
		public override string LocalName
		{
			[Token(Token = "0x6000F1E")]
			[Address(RVA = "0x25FB220", Offset = "0x25F9820", VA = "0x1825FB220", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000814 RID: 2068
		[Token(Token = "0x4000814")]
		[FieldOffset(Offset = "0x28")]
		[Nullable(1)]
		private readonly XmlDocumentType _documentType;
	}
}
