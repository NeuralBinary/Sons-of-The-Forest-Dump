using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020001CB RID: 459
	[Token(Token = "0x20001CB")]
	[Nullable(0)]
	[NullableContext(1)]
	internal class XDocumentWrapper : XContainerWrapper, IXmlDocument, IXmlNode
	{
		// Token: 0x17000283 RID: 643
		// (get) Token: 0x06000F5E RID: 3934 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000283")]
		private XDocument Document
		{
			[Token(Token = "0x6000F5E")]
			[Address(RVA = "0x25FC700", Offset = "0x25FAD00", VA = "0x1825FC700")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000F5F RID: 3935 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F5F")]
		[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
		public XDocumentWrapper(XDocument document)
		{
		}

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x06000F60 RID: 3936 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000284")]
		public override List<IXmlNode> ChildNodes
		{
			[Token(Token = "0x6000F60")]
			[Address(RVA = "0x25FC770", Offset = "0x25FAD70", VA = "0x1825FC770", Slot = "16")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x06000F61 RID: 3937 RVA: 0x00006F30 File Offset: 0x00005130
		[Token(Token = "0x17000285")]
		protected override bool HasChildNodes
		{
			[Token(Token = "0x6000F61")]
			[Address(RVA = "0x25FC8A0", Offset = "0x25FAEA0", VA = "0x1825FC8A0", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000F62 RID: 3938 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000F62")]
		[Address(RVA = "0x25FC8F0", Offset = "0x25FAEF0", VA = "0x1825FC8F0", Slot = "24")]
		public IXmlNode CreateComment([Nullable(2)] string text)
		{
			return null;
		}

		// Token: 0x06000F63 RID: 3939 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000F63")]
		[Address(RVA = "0x25FCA50", Offset = "0x25FB050", VA = "0x1825FCA50", Slot = "25")]
		public IXmlNode CreateTextNode([Nullable(2)] string text)
		{
			return null;
		}

		// Token: 0x06000F64 RID: 3940 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000F64")]
		[Address(RVA = "0x25FCBB0", Offset = "0x25FB1B0", VA = "0x1825FCBB0", Slot = "26")]
		public IXmlNode CreateCDataSection([Nullable(2)] string data)
		{
			return null;
		}

		// Token: 0x06000F65 RID: 3941 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000F65")]
		[Address(RVA = "0x25FCD10", Offset = "0x25FB310", VA = "0x1825FCD10", Slot = "27")]
		public IXmlNode CreateWhitespace([Nullable(2)] string text)
		{
			return null;
		}

		// Token: 0x06000F66 RID: 3942 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000F66")]
		[Address(RVA = "0x25FCE70", Offset = "0x25FB470", VA = "0x1825FCE70", Slot = "28")]
		public IXmlNode CreateSignificantWhitespace([Nullable(2)] string text)
		{
			return null;
		}

		// Token: 0x06000F67 RID: 3943 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000F67")]
		[Address(RVA = "0x25FCFD0", Offset = "0x25FB5D0", VA = "0x1825FCFD0", Slot = "29")]
		public IXmlNode CreateXmlDeclaration(string version, [Nullable(2)] string encoding, [Nullable(2)] string standalone)
		{
			return null;
		}

		// Token: 0x06000F68 RID: 3944 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000F68")]
		[Address(RVA = "0x25FD150", Offset = "0x25FB750", VA = "0x1825FD150", Slot = "30")]
		[NullableContext(2)]
		public IXmlNode CreateXmlDocumentType([Nullable(1)] string name, string publicId, string systemId, string internalSubset)
		{
			return null;
		}

		// Token: 0x06000F69 RID: 3945 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000F69")]
		[Address(RVA = "0x25FD200", Offset = "0x25FB800", VA = "0x1825FD200", Slot = "31")]
		public IXmlNode CreateProcessingInstruction(string target, string data)
		{
			return null;
		}

		// Token: 0x06000F6A RID: 3946 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000F6A")]
		[Address(RVA = "0x25FD2D0", Offset = "0x25FB8D0", VA = "0x1825FD2D0", Slot = "32")]
		public IXmlElement CreateElement(string elementName)
		{
			return null;
		}

		// Token: 0x06000F6B RID: 3947 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000F6B")]
		[Address(RVA = "0x25FD450", Offset = "0x25FBA50", VA = "0x1825FD450", Slot = "33")]
		public IXmlElement CreateElement(string qualifiedName, string namespaceUri)
		{
			return null;
		}

		// Token: 0x06000F6C RID: 3948 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000F6C")]
		[Address(RVA = "0x25FD8B0", Offset = "0x25FBEB0", VA = "0x1825FD8B0", Slot = "34")]
		public IXmlNode CreateAttribute(string name, string value)
		{
			return null;
		}

		// Token: 0x06000F6D RID: 3949 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000F6D")]
		[Address(RVA = "0x25FD9A0", Offset = "0x25FBFA0", VA = "0x1825FD9A0", Slot = "35")]
		public IXmlNode CreateAttribute(string qualifiedName, string namespaceUri, string value)
		{
			return null;
		}

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x06000F6E RID: 3950 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000286")]
		[Nullable(2)]
		public IXmlElement DocumentElement
		{
			[Token(Token = "0x6000F6E")]
			[Address(RVA = "0x25FDD70", Offset = "0x25FC370", VA = "0x1825FDD70", Slot = "36")]
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x06000F6F RID: 3951 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000F6F")]
		[Address(RVA = "0x25FDEA0", Offset = "0x25FC4A0", VA = "0x1825FDEA0", Slot = "21")]
		public override IXmlNode AppendChild(IXmlNode newChild)
		{
			return null;
		}
	}
}
