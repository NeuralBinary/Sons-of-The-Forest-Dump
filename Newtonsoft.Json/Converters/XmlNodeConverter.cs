using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Xml;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020001D3 RID: 467
	[Token(Token = "0x20001D3")]
	[NullableContext(1)]
	[Nullable(0)]
	public class XmlNodeConverter : JsonConverter
	{
		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x06000FA4 RID: 4004 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x06000FA5 RID: 4005 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002A7")]
		[Nullable(2)]
		public string DeserializeRootElementName
		{
			[Token(Token = "0x6000FA4")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
			[CompilerGenerated]
			[NullableContext(2)]
			get
			{
				return null;
			}
			[Token(Token = "0x6000FA5")]
			[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
			[CompilerGenerated]
			[NullableContext(2)]
			set
			{
			}
		}

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x06000FA6 RID: 4006 RVA: 0x00006FA8 File Offset: 0x000051A8
		// (set) Token: 0x06000FA7 RID: 4007 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002A8")]
		public bool WriteArrayAttribute
		{
			[Token(Token = "0x6000FA6")]
			[Address(RVA = "0x75A6A0", Offset = "0x758CA0", VA = "0x18075A6A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000FA7")]
			[Address(RVA = "0x75A6B0", Offset = "0x758CB0", VA = "0x18075A6B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x06000FA8 RID: 4008 RVA: 0x00006FC0 File Offset: 0x000051C0
		// (set) Token: 0x06000FA9 RID: 4009 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002A9")]
		public bool OmitRootObject
		{
			[Token(Token = "0x6000FA8")]
			[Address(RVA = "0x26000D0", Offset = "0x25FE6D0", VA = "0x1826000D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000FA9")]
			[Address(RVA = "0x26000E0", Offset = "0x25FE6E0", VA = "0x1826000E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x06000FAA RID: 4010 RVA: 0x00006FD8 File Offset: 0x000051D8
		// (set) Token: 0x06000FAB RID: 4011 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002AA")]
		public bool EncodeSpecialCharacters
		{
			[Token(Token = "0x6000FAA")]
			[Address(RVA = "0x26000F0", Offset = "0x25FE6F0", VA = "0x1826000F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000FAB")]
			[Address(RVA = "0x2600100", Offset = "0x25FE700", VA = "0x182600100")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000FAC RID: 4012 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FAC")]
		[Address(RVA = "0x2600110", Offset = "0x25FE710", VA = "0x182600110", Slot = "4")]
		public override void WriteJson(JsonWriter writer, [Nullable(2)] object value, JsonSerializer serializer)
		{
		}

		// Token: 0x06000FAD RID: 4013 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000FAD")]
		[Address(RVA = "0x2600260", Offset = "0x25FE860", VA = "0x182600260")]
		private IXmlNode WrapXml(object value)
		{
			return null;
		}

		// Token: 0x06000FAE RID: 4014 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FAE")]
		[Address(RVA = "0x2600550", Offset = "0x25FEB50", VA = "0x182600550")]
		private void PushParentNamespaces(IXmlNode node, XmlNamespaceManager manager)
		{
		}

		// Token: 0x06000FAF RID: 4015 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000FAF")]
		[Address(RVA = "0x2600B20", Offset = "0x25FF120", VA = "0x182600B20")]
		private string ResolveFullName(IXmlNode node, XmlNamespaceManager manager)
		{
			return null;
		}

		// Token: 0x06000FB0 RID: 4016 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000FB0")]
		[Address(RVA = "0x2600D30", Offset = "0x25FF330", VA = "0x182600D30")]
		private string GetPropertyName(IXmlNode node, XmlNamespaceManager manager)
		{
			return null;
		}

		// Token: 0x06000FB1 RID: 4017 RVA: 0x00006FF0 File Offset: 0x000051F0
		[Token(Token = "0x6000FB1")]
		[Address(RVA = "0x2601110", Offset = "0x25FF710", VA = "0x182601110")]
		private bool IsArray(IXmlNode node)
		{
			return default(bool);
		}

		// Token: 0x06000FB2 RID: 4018 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FB2")]
		[Address(RVA = "0x2601370", Offset = "0x25FF970", VA = "0x182601370")]
		private void SerializeGroupedNodes(JsonWriter writer, IXmlNode node, XmlNamespaceManager manager, bool writePropertyName)
		{
		}

		// Token: 0x06000FB3 RID: 4019 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FB3")]
		[Address(RVA = "0x2601CD0", Offset = "0x26002D0", VA = "0x182601CD0")]
		private void WriteGroupedNodes(JsonWriter writer, XmlNamespaceManager manager, bool writePropertyName, List<IXmlNode> groupedNodes, string elementNames)
		{
		}

		// Token: 0x06000FB4 RID: 4020 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FB4")]
		[Address(RVA = "0x2601E70", Offset = "0x2600470", VA = "0x182601E70")]
		private void WriteGroupedNodes(JsonWriter writer, XmlNamespaceManager manager, bool writePropertyName, IXmlNode node, string elementNames)
		{
		}

		// Token: 0x06000FB5 RID: 4021 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FB5")]
		[Address(RVA = "0x2601F50", Offset = "0x2600550", VA = "0x182601F50")]
		private void SerializeNode(JsonWriter writer, IXmlNode node, XmlNamespaceManager manager, bool writePropertyName)
		{
		}

		// Token: 0x06000FB6 RID: 4022 RVA: 0x00007008 File Offset: 0x00005208
		[Token(Token = "0x6000FB6")]
		[Address(RVA = "0x2602DE0", Offset = "0x26013E0", VA = "0x182602DE0")]
		private static bool AllSameName(IXmlNode node)
		{
			return default(bool);
		}

		// Token: 0x06000FB7 RID: 4023 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000FB7")]
		[Address(RVA = "0x2602FB0", Offset = "0x26015B0", VA = "0x182602FB0", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, [Nullable(2)] object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		// Token: 0x06000FB8 RID: 4024 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FB8")]
		[Address(RVA = "0x2603760", Offset = "0x2601D60", VA = "0x182603760")]
		private void DeserializeValue(JsonReader reader, IXmlDocument document, XmlNamespaceManager manager, string propertyName, IXmlNode currentNode)
		{
		}

		// Token: 0x06000FB9 RID: 4025 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FB9")]
		[Address(RVA = "0x2603BA0", Offset = "0x26021A0", VA = "0x182603BA0")]
		private void ReadElement(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string propertyName, XmlNamespaceManager manager)
		{
		}

		// Token: 0x06000FBA RID: 4026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FBA")]
		[Address(RVA = "0x26040A0", Offset = "0x26026A0", VA = "0x1826040A0")]
		private void CreateElement(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string elementName, XmlNamespaceManager manager, [Nullable(2)] string elementPrefix, [Nullable(new byte[]
		{
			2,
			1,
			2
		})] Dictionary<string, string> attributeNameValues)
		{
		}

		// Token: 0x06000FBB RID: 4027 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FBB")]
		[Address(RVA = "0x2604610", Offset = "0x2602C10", VA = "0x182604610")]
		private static void AddAttribute(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string propertyName, string attributeName, XmlNamespaceManager manager, [Nullable(2)] string attributePrefix)
		{
		}

		// Token: 0x06000FBC RID: 4028 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000FBC")]
		[Address(RVA = "0x2604870", Offset = "0x2602E70", VA = "0x182604870")]
		private static string ConvertTokenToXmlValue(JsonReader reader)
		{
			return null;
		}

		// Token: 0x06000FBD RID: 4029 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FBD")]
		[Address(RVA = "0x2605050", Offset = "0x2603650", VA = "0x182605050")]
		private void ReadArrayElements(JsonReader reader, IXmlDocument document, string propertyName, IXmlNode currentNode, XmlNamespaceManager manager)
		{
		}

		// Token: 0x06000FBE RID: 4030 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FBE")]
		[Address(RVA = "0x2605360", Offset = "0x2603960", VA = "0x182605360")]
		private void AddJsonArrayAttribute(IXmlElement element, IXmlDocument document)
		{
		}

		// Token: 0x06000FBF RID: 4031 RVA: 0x00007020 File Offset: 0x00005220
		[Token(Token = "0x6000FBF")]
		[Address(RVA = "0x26054D0", Offset = "0x2603AD0", VA = "0x1826054D0")]
		private bool ShouldReadInto(JsonReader reader)
		{
			return default(bool);
		}

		// Token: 0x06000FC0 RID: 4032 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000FC0")]
		[Address(RVA = "0x2605560", Offset = "0x2603B60", VA = "0x182605560")]
		private Dictionary<string, string> ReadAttributeElements(JsonReader reader, XmlNamespaceManager manager)
		{
			return null;
		}

		// Token: 0x06000FC1 RID: 4033 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FC1")]
		[Address(RVA = "0x2605CA0", Offset = "0x26042A0", VA = "0x182605CA0")]
		private void CreateInstruction(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string propertyName)
		{
		}

		// Token: 0x06000FC2 RID: 4034 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FC2")]
		[Address(RVA = "0x26060F0", Offset = "0x26046F0", VA = "0x1826060F0")]
		private void CreateDocumentType(JsonReader reader, IXmlDocument document, IXmlNode currentNode)
		{
		}

		// Token: 0x06000FC3 RID: 4035 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000FC3")]
		[Address(RVA = "0x2606560", Offset = "0x2604B60", VA = "0x182606560")]
		private IXmlElement CreateElement(string elementName, IXmlDocument document, [Nullable(2)] string elementPrefix, XmlNamespaceManager manager)
		{
			return null;
		}

		// Token: 0x06000FC4 RID: 4036 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FC4")]
		[Address(RVA = "0x2606700", Offset = "0x2604D00", VA = "0x182606700")]
		private void DeserializeNode(JsonReader reader, IXmlDocument document, XmlNamespaceManager manager, IXmlNode currentNode)
		{
		}

		// Token: 0x06000FC5 RID: 4037 RVA: 0x00007038 File Offset: 0x00005238
		[Token(Token = "0x6000FC5")]
		[Address(RVA = "0x2607070", Offset = "0x2605670", VA = "0x182607070")]
		private bool IsNamespaceAttribute(string attributeName, [Nullable(2)] [System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out string prefix)
		{
			return default(bool);
		}

		// Token: 0x06000FC6 RID: 4038 RVA: 0x00007050 File Offset: 0x00005250
		[Token(Token = "0x6000FC6")]
		[Address(RVA = "0x26072B0", Offset = "0x26058B0", VA = "0x1826072B0")]
		private bool ValueAttributes(List<IXmlNode> c)
		{
			return default(bool);
		}

		// Token: 0x06000FC7 RID: 4039 RVA: 0x00007068 File Offset: 0x00005268
		[Token(Token = "0x6000FC7")]
		[Address(RVA = "0x2607500", Offset = "0x2605B00", VA = "0x182607500", Slot = "6")]
		public override bool CanConvert(Type valueType)
		{
			return default(bool);
		}

		// Token: 0x06000FC8 RID: 4040 RVA: 0x00007080 File Offset: 0x00005280
		[Token(Token = "0x6000FC8")]
		[Address(RVA = "0x26075E0", Offset = "0x2605BE0", VA = "0x1826075E0")]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool IsXObject(Type valueType)
		{
			return default(bool);
		}

		// Token: 0x06000FC9 RID: 4041 RVA: 0x00007098 File Offset: 0x00005298
		[Token(Token = "0x6000FC9")]
		[Address(RVA = "0x26076B0", Offset = "0x2605CB0", VA = "0x1826076B0")]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool IsXmlNode(Type valueType)
		{
			return default(bool);
		}

		// Token: 0x06000FCA RID: 4042 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FCA")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public XmlNodeConverter()
		{
		}

		// Token: 0x0400081D RID: 2077
		[Token(Token = "0x400081D")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly List<IXmlNode> EmptyChildNodes;

		// Token: 0x0400081E RID: 2078
		[Token(Token = "0x400081E")]
		private const string TextName = "#text";

		// Token: 0x0400081F RID: 2079
		[Token(Token = "0x400081F")]
		private const string CommentName = "#comment";

		// Token: 0x04000820 RID: 2080
		[Token(Token = "0x4000820")]
		private const string CDataName = "#cdata-section";

		// Token: 0x04000821 RID: 2081
		[Token(Token = "0x4000821")]
		private const string WhitespaceName = "#whitespace";

		// Token: 0x04000822 RID: 2082
		[Token(Token = "0x4000822")]
		private const string SignificantWhitespaceName = "#significant-whitespace";

		// Token: 0x04000823 RID: 2083
		[Token(Token = "0x4000823")]
		private const string DeclarationName = "?xml";

		// Token: 0x04000824 RID: 2084
		[Token(Token = "0x4000824")]
		private const string JsonNamespaceUri = "http://james.newtonking.com/projects/json";
	}
}
