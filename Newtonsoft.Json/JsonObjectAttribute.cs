using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Newtonsoft.Json
{
	// Token: 0x02000024 RID: 36
	[Token(Token = "0x2000024")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface, AllowMultiple = false)]
	public sealed class JsonObjectAttribute : JsonContainerAttribute
	{
		// Token: 0x17000019 RID: 25
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x00002190 File Offset: 0x00000390
		// (set) Token: 0x060000A3 RID: 163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000019")]
		public MemberSerialization MemberSerialization
		{
			[Token(Token = "0x60000A2")]
			[Address(RVA = "0xA2FB30", Offset = "0xA2E130", VA = "0x180A2FB30")]
			get
			{
				return MemberSerialization.OptOut;
			}
			[Token(Token = "0x60000A3")]
			[Address(RVA = "0x24F1E20", Offset = "0x24F0420", VA = "0x1824F1E20")]
			set
			{
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x000021A8 File Offset: 0x000003A8
		// (set) Token: 0x060000A5 RID: 165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700001A")]
		public MissingMemberHandling MissingMemberHandling
		{
			[Token(Token = "0x60000A4")]
			[Address(RVA = "0x24F1E30", Offset = "0x24F0430", VA = "0x1824F1E30")]
			get
			{
				return MissingMemberHandling.Ignore;
			}
			[Token(Token = "0x60000A5")]
			[Address(RVA = "0x24F1E70", Offset = "0x24F0470", VA = "0x1824F1E70")]
			set
			{
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x060000A6 RID: 166 RVA: 0x000021C0 File Offset: 0x000003C0
		// (set) Token: 0x060000A7 RID: 167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700001B")]
		public NullValueHandling ItemNullValueHandling
		{
			[Token(Token = "0x60000A6")]
			[Address(RVA = "0x24F1ED0", Offset = "0x24F04D0", VA = "0x1824F1ED0")]
			get
			{
				return NullValueHandling.Include;
			}
			[Token(Token = "0x60000A7")]
			[Address(RVA = "0x24F1F10", Offset = "0x24F0510", VA = "0x1824F1F10")]
			set
			{
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x000021D8 File Offset: 0x000003D8
		// (set) Token: 0x060000A9 RID: 169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700001C")]
		public Required ItemRequired
		{
			[Token(Token = "0x60000A8")]
			[Address(RVA = "0x24F1F70", Offset = "0x24F0570", VA = "0x1824F1F70")]
			get
			{
				return Required.Default;
			}
			[Token(Token = "0x60000A9")]
			[Address(RVA = "0x24F1FB0", Offset = "0x24F05B0", VA = "0x1824F1FB0")]
			set
			{
			}
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public JsonObjectAttribute()
		{
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x24F1E20", Offset = "0x24F0420", VA = "0x1824F1E20")]
		public JsonObjectAttribute(MemberSerialization memberSerialization)
		{
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
		[NullableContext(1)]
		public JsonObjectAttribute(string id)
		{
		}

		// Token: 0x04000043 RID: 67
		[Token(Token = "0x4000043")]
		[FieldOffset(Offset = "0x68")]
		private MemberSerialization _memberSerialization;

		// Token: 0x04000044 RID: 68
		[Token(Token = "0x4000044")]
		[FieldOffset(Offset = "0x6C")]
		internal MissingMemberHandling? _missingMemberHandling;

		// Token: 0x04000045 RID: 69
		[Token(Token = "0x4000045")]
		[FieldOffset(Offset = "0x74")]
		internal Required? _itemRequired;

		// Token: 0x04000046 RID: 70
		[Token(Token = "0x4000046")]
		[FieldOffset(Offset = "0x7C")]
		internal NullValueHandling? _itemNullValueHandling;
	}
}
