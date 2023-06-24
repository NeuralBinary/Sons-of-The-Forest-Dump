using System;
using System.Runtime.CompilerServices;
using System.Xml;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020001C1 RID: 449
	[Token(Token = "0x20001C1")]
	[NullableContext(2)]
	[Nullable(0)]
	internal class XmlDeclarationWrapper : XmlNodeWrapper, IXmlDeclaration, IXmlNode
	{
		// Token: 0x06000F13 RID: 3859 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F13")]
		[Address(RVA = "0x25FA490", Offset = "0x25F8A90", VA = "0x1825FA490")]
		[NullableContext(1)]
		public XmlDeclarationWrapper(XmlDeclaration declaration)
		{
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x06000F14 RID: 3860 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000256")]
		public string Version
		{
			[Token(Token = "0x6000F14")]
			[Address(RVA = "0x1484970", Offset = "0x1482F70", VA = "0x181484970", Slot = "16")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x06000F15 RID: 3861 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x06000F16 RID: 3862 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000257")]
		public string Encoding
		{
			[Token(Token = "0x6000F15")]
			[Address(RVA = "0x7453E0", Offset = "0x7439E0", VA = "0x1807453E0", Slot = "17")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000F16")]
			[Address(RVA = "0x25FB100", Offset = "0x25F9700", VA = "0x1825FB100", Slot = "18")]
			set
			{
			}
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x06000F17 RID: 3863 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x06000F18 RID: 3864 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000258")]
		public string Standalone
		{
			[Token(Token = "0x6000F17")]
			[Address(RVA = "0x25FB1B0", Offset = "0x25F97B0", VA = "0x1825FB1B0", Slot = "19")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000F18")]
			[Address(RVA = "0x25FB1D0", Offset = "0x25F97D0", VA = "0x1825FB1D0", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x04000813 RID: 2067
		[Token(Token = "0x4000813")]
		[FieldOffset(Offset = "0x28")]
		[Nullable(1)]
		private readonly XmlDeclaration _declaration;
	}
}
