using System;
using System.Runtime.CompilerServices;
using System.Xml;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020001C0 RID: 448
	[Token(Token = "0x20001C0")]
	[NullableContext(1)]
	[Nullable(0)]
	internal class XmlElementWrapper : XmlNodeWrapper, IXmlElement, IXmlNode
	{
		// Token: 0x06000F0F RID: 3855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F0F")]
		[Address(RVA = "0x25FA490", Offset = "0x25F8A90", VA = "0x1825FA490")]
		public XmlElementWrapper(XmlElement element)
		{
		}

		// Token: 0x06000F10 RID: 3856 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F10")]
		[Address(RVA = "0x25FAFD0", Offset = "0x25F95D0", VA = "0x1825FAFD0", Slot = "16")]
		public void SetAttributeNode(IXmlNode attribute)
		{
		}

		// Token: 0x06000F11 RID: 3857 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000F11")]
		[Address(RVA = "0x25FB0B0", Offset = "0x25F96B0", VA = "0x1825FB0B0", Slot = "17")]
		public string GetPrefixOfNamespace(string namespaceUri)
		{
			return null;
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x06000F12 RID: 3858 RVA: 0x00006EB8 File Offset: 0x000050B8
		[Token(Token = "0x17000255")]
		public bool IsEmpty
		{
			[Token(Token = "0x6000F12")]
			[Address(RVA = "0x25FB0E0", Offset = "0x25F96E0", VA = "0x1825FB0E0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x04000812 RID: 2066
		[Token(Token = "0x4000812")]
		[FieldOffset(Offset = "0x28")]
		private readonly XmlElement _element;
	}
}
