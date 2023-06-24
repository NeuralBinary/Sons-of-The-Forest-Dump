using System;
using System.Runtime.CompilerServices;
using System.Xml;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020001BF RID: 447
	[Token(Token = "0x20001BF")]
	[NullableContext(1)]
	[Nullable(0)]
	internal class XmlDocumentWrapper : XmlNodeWrapper, IXmlDocument, IXmlNode
	{
		// Token: 0x06000F01 RID: 3841 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F01")]
		[Address(RVA = "0x25FA490", Offset = "0x25F8A90", VA = "0x1825FA490")]
		public XmlDocumentWrapper(XmlDocument document)
		{
		}

		// Token: 0x06000F02 RID: 3842 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000F02")]
		[Address(RVA = "0x25FA540", Offset = "0x25F8B40", VA = "0x1825FA540", Slot = "16")]
		public IXmlNode CreateComment([Nullable(2)] string data)
		{
			return null;
		}

		// Token: 0x06000F03 RID: 3843 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000F03")]
		[Address(RVA = "0x25FA610", Offset = "0x25F8C10", VA = "0x1825FA610", Slot = "17")]
		public IXmlNode CreateTextNode([Nullable(2)] string text)
		{
			return null;
		}

		// Token: 0x06000F04 RID: 3844 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000F04")]
		[Address(RVA = "0x25FA6E0", Offset = "0x25F8CE0", VA = "0x1825FA6E0", Slot = "18")]
		public IXmlNode CreateCDataSection([Nullable(2)] string data)
		{
			return null;
		}

		// Token: 0x06000F05 RID: 3845 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000F05")]
		[Address(RVA = "0x25FA7B0", Offset = "0x25F8DB0", VA = "0x1825FA7B0", Slot = "19")]
		public IXmlNode CreateWhitespace([Nullable(2)] string text)
		{
			return null;
		}

		// Token: 0x06000F06 RID: 3846 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000F06")]
		[Address(RVA = "0x25FA880", Offset = "0x25F8E80", VA = "0x1825FA880", Slot = "20")]
		public IXmlNode CreateSignificantWhitespace([Nullable(2)] string text)
		{
			return null;
		}

		// Token: 0x06000F07 RID: 3847 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000F07")]
		[Address(RVA = "0x25FA950", Offset = "0x25F8F50", VA = "0x1825FA950", Slot = "21")]
		public IXmlNode CreateXmlDeclaration(string version, [Nullable(2)] string encoding, [Nullable(2)] string standalone)
		{
			return null;
		}

		// Token: 0x06000F08 RID: 3848 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000F08")]
		[Address(RVA = "0x25FAA00", Offset = "0x25F9000", VA = "0x1825FAA00", Slot = "22")]
		[NullableContext(2)]
		public IXmlNode CreateXmlDocumentType([Nullable(1)] string name, string publicId, string systemId, string internalSubset)
		{
			return null;
		}

		// Token: 0x06000F09 RID: 3849 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000F09")]
		[Address(RVA = "0x25FAAB0", Offset = "0x25F90B0", VA = "0x1825FAAB0", Slot = "23")]
		public IXmlNode CreateProcessingInstruction(string target, string data)
		{
			return null;
		}

		// Token: 0x06000F0A RID: 3850 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000F0A")]
		[Address(RVA = "0x25FAB80", Offset = "0x25F9180", VA = "0x1825FAB80", Slot = "24")]
		public IXmlElement CreateElement(string elementName)
		{
			return null;
		}

		// Token: 0x06000F0B RID: 3851 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000F0B")]
		[Address(RVA = "0x25FAC00", Offset = "0x25F9200", VA = "0x1825FAC00", Slot = "25")]
		public IXmlElement CreateElement(string qualifiedName, string namespaceUri)
		{
			return null;
		}

		// Token: 0x06000F0C RID: 3852 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000F0C")]
		[Address(RVA = "0x25FAD00", Offset = "0x25F9300", VA = "0x1825FAD00", Slot = "26")]
		public IXmlNode CreateAttribute(string name, [Nullable(2)] string value)
		{
			return null;
		}

		// Token: 0x06000F0D RID: 3853 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000F0D")]
		[Address(RVA = "0x25FADF0", Offset = "0x25F93F0", VA = "0x1825FADF0", Slot = "27")]
		public IXmlNode CreateAttribute(string qualifiedName, [Nullable(2)] string namespaceUri, [Nullable(2)] string value)
		{
			return null;
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x06000F0E RID: 3854 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000254")]
		[Nullable(2)]
		public IXmlElement DocumentElement
		{
			[Token(Token = "0x6000F0E")]
			[Address(RVA = "0x25FAF40", Offset = "0x25F9540", VA = "0x1825FAF40", Slot = "28")]
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x04000811 RID: 2065
		[Token(Token = "0x4000811")]
		[FieldOffset(Offset = "0x28")]
		private readonly XmlDocument _document;
	}
}
