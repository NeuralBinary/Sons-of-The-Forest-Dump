using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;

namespace Newtonsoft.Json
{
	// Token: 0x02000073 RID: 115
	[Token(Token = "0x2000073")]
	[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
	public class JsonValidatingReader : JsonReader, IJsonLineInfo
	{
		// Token: 0x14000002 RID: 2
		// (add) Token: 0x0600039D RID: 925 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600039E RID: 926 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000002")]
		public event ValidationEventHandler ValidationEventHandler
		{
			[Token(Token = "0x600039D")]
			[Address(RVA = "0x25381F0", Offset = "0x25367F0", VA = "0x1825381F0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600039E")]
			[Address(RVA = "0x25382E0", Offset = "0x25368E0", VA = "0x1825382E0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x0600039F RID: 927 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x1700008A")]
		public override object Value
		{
			[Token(Token = "0x600039F")]
			[Address(RVA = "0x25383D0", Offset = "0x25369D0", VA = "0x1825383D0", Slot = "17")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x060003A0 RID: 928 RVA: 0x00002DF0 File Offset: 0x00000FF0
		[Token(Token = "0x1700008B")]
		public override int Depth
		{
			[Token(Token = "0x60003A0")]
			[Address(RVA = "0x2538400", Offset = "0x2536A00", VA = "0x182538400", Slot = "19")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x060003A1 RID: 929 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x1700008C")]
		public override string Path
		{
			[Token(Token = "0x60003A1")]
			[Address(RVA = "0x2538430", Offset = "0x2536A30", VA = "0x182538430", Slot = "20")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x060003A2 RID: 930 RVA: 0x00002E08 File Offset: 0x00001008
		// (set) Token: 0x060003A3 RID: 931 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700008D")]
		public override char QuoteChar
		{
			[Token(Token = "0x60003A2")]
			[Address(RVA = "0x2538460", Offset = "0x2536A60", VA = "0x182538460", Slot = "14")]
			get
			{
				return '\0';
			}
			[Token(Token = "0x60003A3")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "15")]
			protected internal set
			{
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x060003A4 RID: 932 RVA: 0x00002E20 File Offset: 0x00001020
		[Token(Token = "0x1700008E")]
		public override JsonToken TokenType
		{
			[Token(Token = "0x60003A4")]
			[Address(RVA = "0x2538490", Offset = "0x2536A90", VA = "0x182538490", Slot = "16")]
			get
			{
				return JsonToken.None;
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x060003A5 RID: 933 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x1700008F")]
		public override Type ValueType
		{
			[Token(Token = "0x60003A5")]
			[Address(RVA = "0x25384C0", Offset = "0x2536AC0", VA = "0x1825384C0", Slot = "18")]
			get
			{
				return null;
			}
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x25384F0", Offset = "0x2536AF0", VA = "0x1825384F0")]
		private void Push(JsonValidatingReader.SchemaScope scope)
		{
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x25385A0", Offset = "0x2536BA0", VA = "0x1825385A0")]
		private JsonValidatingReader.SchemaScope Pop()
		{
			return null;
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x060003A8 RID: 936 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000090")]
		private IList<JsonSchemaModel> CurrentSchemas
		{
			[Token(Token = "0x60003A8")]
			[Address(RVA = "0x2538690", Offset = "0x2536C90", VA = "0x182538690")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x060003A9 RID: 937 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000091")]
		private IList<JsonSchemaModel> CurrentMemberSchemas
		{
			[Token(Token = "0x60003A9")]
			[Address(RVA = "0x25386B0", Offset = "0x2536CB0", VA = "0x1825386B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060003AA RID: 938 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x25390E0", Offset = "0x25376E0", VA = "0x1825390E0")]
		private void RaiseError(string message, JsonSchemaModel schema)
		{
		}

		// Token: 0x060003AB RID: 939 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x2539480", Offset = "0x2537A80", VA = "0x182539480")]
		private void OnValidationEvent(JsonSchemaException exception)
		{
		}

		// Token: 0x060003AC RID: 940 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x2539600", Offset = "0x2537C00", VA = "0x182539600")]
		public JsonValidatingReader(JsonReader reader)
		{
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x060003AD RID: 941 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x060003AE RID: 942 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000092")]
		public JsonSchema Schema
		{
			[Token(Token = "0x60003AD")]
			[Address(RVA = "0x8DD0A0", Offset = "0x8DB6A0", VA = "0x1808DD0A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003AE")]
			[Address(RVA = "0x25397C0", Offset = "0x2537DC0", VA = "0x1825397C0")]
			set
			{
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x060003AF RID: 943 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000093")]
		public JsonReader Reader
		{
			[Token(Token = "0x60003AF")]
			[Address(RVA = "0x6306D0", Offset = "0x62ECD0", VA = "0x1806306D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x25398F0", Offset = "0x2537EF0", VA = "0x1825398F0", Slot = "31")]
		public override void Close()
		{
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x2539980", Offset = "0x2537F80", VA = "0x182539980")]
		private void ValidateNotDisallowed(JsonSchemaModel schema)
		{
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x00002E38 File Offset: 0x00001038
		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x2539C20", Offset = "0x2538220", VA = "0x182539C20")]
		private JsonSchemaType? GetCurrentNodeSchemaType()
		{
			return null;
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x00002E50 File Offset: 0x00001050
		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x2539DB0", Offset = "0x25383B0", VA = "0x182539DB0", Slot = "22")]
		public override int? ReadAsInt32()
		{
			return null;
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x2539E00", Offset = "0x2538400", VA = "0x182539E00", Slot = "24")]
		public override byte[] ReadAsBytes()
		{
			return null;
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x00002E68 File Offset: 0x00001068
		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x2539E50", Offset = "0x2538450", VA = "0x182539E50", Slot = "27")]
		public override decimal? ReadAsDecimal()
		{
			return null;
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x00002E80 File Offset: 0x00001080
		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x2539EB0", Offset = "0x25384B0", VA = "0x182539EB0", Slot = "25")]
		public override double? ReadAsDouble()
		{
			return null;
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x00002E98 File Offset: 0x00001098
		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x2539F10", Offset = "0x2538510", VA = "0x182539F10", Slot = "26")]
		public override bool? ReadAsBoolean()
		{
			return null;
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x2539F60", Offset = "0x2538560", VA = "0x182539F60", Slot = "23")]
		public override string ReadAsString()
		{
			return null;
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x00002EB0 File Offset: 0x000010B0
		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x2539FB0", Offset = "0x25385B0", VA = "0x182539FB0", Slot = "28")]
		public override DateTime? ReadAsDateTime()
		{
			return null;
		}

		// Token: 0x060003BA RID: 954 RVA: 0x00002EC8 File Offset: 0x000010C8
		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x253A010", Offset = "0x2538610", VA = "0x18253A010", Slot = "29")]
		public override DateTimeOffset? ReadAsDateTimeOffset()
		{
			return null;
		}

		// Token: 0x060003BB RID: 955 RVA: 0x00002EE0 File Offset: 0x000010E0
		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x253A070", Offset = "0x2538670", VA = "0x18253A070", Slot = "21")]
		public override bool Read()
		{
			return default(bool);
		}

		// Token: 0x060003BC RID: 956 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x253A0E0", Offset = "0x25386E0", VA = "0x18253A0E0")]
		private void ValidateCurrentToken()
		{
		}

		// Token: 0x060003BD RID: 957 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x253AEF0", Offset = "0x25394F0", VA = "0x18253AEF0")]
		private void WriteToken(IList<JsonSchemaModel> schemas)
		{
		}

		// Token: 0x060003BE RID: 958 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x253B8A0", Offset = "0x2539EA0", VA = "0x18253B8A0")]
		private void ValidateEndObject(JsonSchemaModel schema)
		{
		}

		// Token: 0x060003BF RID: 959 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x253BC50", Offset = "0x253A250", VA = "0x18253BC50")]
		private void ValidateEndArray(JsonSchemaModel schema)
		{
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x253BE50", Offset = "0x253A450", VA = "0x18253BE50")]
		private void ValidateNull(JsonSchemaModel schema)
		{
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x253BE90", Offset = "0x253A490", VA = "0x18253BE90")]
		private void ValidateBoolean(JsonSchemaModel schema)
		{
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x253BED0", Offset = "0x253A4D0", VA = "0x18253BED0")]
		private void ValidateString(JsonSchemaModel schema)
		{
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x253C290", Offset = "0x253A890", VA = "0x18253C290")]
		private void ValidateInteger(JsonSchemaModel schema)
		{
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x253C9C0", Offset = "0x253AFC0", VA = "0x18253C9C0")]
		private void ProcessValue()
		{
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x253CCB0", Offset = "0x253B2B0", VA = "0x18253CCB0")]
		private void ValidateFloat(JsonSchemaModel schema)
		{
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x00002EF8 File Offset: 0x000010F8
		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x253D220", Offset = "0x253B820", VA = "0x18253D220")]
		private static double FloatingPointRemainder(double dividend, double divisor)
		{
			return 0.0;
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x00002F10 File Offset: 0x00001110
		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x253D290", Offset = "0x253B890", VA = "0x18253D290")]
		private static bool IsZero(double value)
		{
			return default(bool);
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x253D2F0", Offset = "0x253B8F0", VA = "0x18253D2F0")]
		private void ValidatePropertyName(JsonSchemaModel schema)
		{
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x00002F28 File Offset: 0x00001128
		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x253D570", Offset = "0x253BB70", VA = "0x18253D570")]
		private bool IsPropertyDefinied(JsonSchemaModel schema, string propertyName)
		{
			return default(bool);
		}

		// Token: 0x060003CA RID: 970 RVA: 0x00002F40 File Offset: 0x00001140
		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x253D760", Offset = "0x253BD60", VA = "0x18253D760")]
		private bool ValidateArray(JsonSchemaModel schema)
		{
			return default(bool);
		}

		// Token: 0x060003CB RID: 971 RVA: 0x00002F58 File Offset: 0x00001158
		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x253D780", Offset = "0x253BD80", VA = "0x18253D780")]
		private bool ValidateObject(JsonSchemaModel schema)
		{
			return default(bool);
		}

		// Token: 0x060003CC RID: 972 RVA: 0x00002F70 File Offset: 0x00001170
		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x253D7A0", Offset = "0x253BDA0", VA = "0x18253D7A0")]
		private bool TestType(JsonSchemaModel currentSchema, JsonSchemaType currentType)
		{
			return default(bool);
		}

		// Token: 0x060003CD RID: 973 RVA: 0x00002F88 File Offset: 0x00001188
		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x253D910", Offset = "0x253BF10", VA = "0x18253D910", Slot = "32")]
		private bool HasLineInfo()
		{
			return default(bool);
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x060003CE RID: 974 RVA: 0x00002FA0 File Offset: 0x000011A0
		[Token(Token = "0x17000094")]
		private int LineNumber
		{
			[Token(Token = "0x60003CE")]
			[Address(RVA = "0x253D970", Offset = "0x253BF70", VA = "0x18253D970", Slot = "33")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x060003CF RID: 975 RVA: 0x00002FB8 File Offset: 0x000011B8
		[Token(Token = "0x17000095")]
		private int LinePosition
		{
			[Token(Token = "0x60003CF")]
			[Address(RVA = "0x253D9D0", Offset = "0x253BFD0", VA = "0x18253D9D0", Slot = "34")]
			get
			{
				return 0;
			}
		}

		// Token: 0x040002B1 RID: 689
		[Token(Token = "0x40002B1")]
		[FieldOffset(Offset = "0x78")]
		private readonly JsonReader _reader;

		// Token: 0x040002B2 RID: 690
		[Token(Token = "0x40002B2")]
		[FieldOffset(Offset = "0x80")]
		private readonly Stack<JsonValidatingReader.SchemaScope> _stack;

		// Token: 0x040002B3 RID: 691
		[Token(Token = "0x40002B3")]
		[FieldOffset(Offset = "0x88")]
		private JsonSchema _schema;

		// Token: 0x040002B4 RID: 692
		[Token(Token = "0x40002B4")]
		[FieldOffset(Offset = "0x90")]
		private JsonSchemaModel _model;

		// Token: 0x040002B5 RID: 693
		[Token(Token = "0x40002B5")]
		[FieldOffset(Offset = "0x98")]
		private JsonValidatingReader.SchemaScope _currentScope;

		// Token: 0x040002B7 RID: 695
		[Token(Token = "0x40002B7")]
		[FieldOffset(Offset = "0x0")]
		private static readonly IList<JsonSchemaModel> EmptySchemaList;

		// Token: 0x02000074 RID: 116
		[Token(Token = "0x2000074")]
		private class SchemaScope
		{
			// Token: 0x17000096 RID: 150
			// (get) Token: 0x060003D1 RID: 977 RVA: 0x00002082 File Offset: 0x00000282
			// (set) Token: 0x060003D2 RID: 978 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000096")]
			public string CurrentPropertyName
			{
				[Token(Token = "0x60003D1")]
				[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60003D2")]
				[Address(RVA = "0x5B27E0", Offset = "0x5B0DE0", VA = "0x1805B27E0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000097 RID: 151
			// (get) Token: 0x060003D3 RID: 979 RVA: 0x00002FD0 File Offset: 0x000011D0
			// (set) Token: 0x060003D4 RID: 980 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000097")]
			public int ArrayItemCount
			{
				[Token(Token = "0x60003D3")]
				[Address(RVA = "0x65D0F0", Offset = "0x65B6F0", VA = "0x18065D0F0")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[Token(Token = "0x60003D4")]
				[Address(RVA = "0x65D100", Offset = "0x65B700", VA = "0x18065D100")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000098 RID: 152
			// (get) Token: 0x060003D5 RID: 981 RVA: 0x00002FE8 File Offset: 0x000011E8
			[Token(Token = "0x17000098")]
			public bool IsUniqueArray
			{
				[Token(Token = "0x60003D5")]
				[Address(RVA = "0x2084CB0", Offset = "0x20832B0", VA = "0x182084CB0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000099 RID: 153
			// (get) Token: 0x060003D6 RID: 982 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x17000099")]
			public IList<JToken> UniqueArrayItems
			{
				[Token(Token = "0x60003D6")]
				[Address(RVA = "0x5B2EF0", Offset = "0x5B14F0", VA = "0x1805B2EF0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x1700009A RID: 154
			// (get) Token: 0x060003D7 RID: 983 RVA: 0x00002082 File Offset: 0x00000282
			// (set) Token: 0x060003D8 RID: 984 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700009A")]
			public JTokenWriter CurrentItemWriter
			{
				[Token(Token = "0x60003D7")]
				[Address(RVA = "0x5AC7C0", Offset = "0x5AADC0", VA = "0x1805AC7C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60003D8")]
				[Address(RVA = "0x5B2560", Offset = "0x5B0B60", VA = "0x1805B2560")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x1700009B RID: 155
			// (get) Token: 0x060003D9 RID: 985 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x1700009B")]
			public IList<JsonSchemaModel> Schemas
			{
				[Token(Token = "0x60003D9")]
				[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700009C RID: 156
			// (get) Token: 0x060003DA RID: 986 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x1700009C")]
			public Dictionary<string, bool> RequiredProperties
			{
				[Token(Token = "0x60003DA")]
				[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700009D RID: 157
			// (get) Token: 0x060003DB RID: 987 RVA: 0x00003000 File Offset: 0x00001200
			[Token(Token = "0x1700009D")]
			public JTokenType TokenType
			{
				[Token(Token = "0x60003DB")]
				[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420")]
				get
				{
					return JTokenType.None;
				}
			}

			// Token: 0x060003DC RID: 988 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60003DC")]
			[Address(RVA = "0x253DB00", Offset = "0x253C100", VA = "0x18253DB00")]
			public SchemaScope(JTokenType tokenType, IList<JsonSchemaModel> schemas)
			{
			}

			// Token: 0x060003DD RID: 989 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x60003DD")]
			[Address(RVA = "0x253E0E0", Offset = "0x253C6E0", VA = "0x18253E0E0")]
			private IEnumerable<string> GetRequiredProperties(JsonSchemaModel schema)
			{
				return null;
			}

			// Token: 0x040002B8 RID: 696
			[Token(Token = "0x40002B8")]
			[FieldOffset(Offset = "0x10")]
			private readonly JTokenType _tokenType;

			// Token: 0x040002B9 RID: 697
			[Token(Token = "0x40002B9")]
			[FieldOffset(Offset = "0x18")]
			private readonly IList<JsonSchemaModel> _schemas;

			// Token: 0x040002BA RID: 698
			[Token(Token = "0x40002BA")]
			[FieldOffset(Offset = "0x20")]
			private readonly Dictionary<string, bool> _requiredProperties;
		}
	}
}
