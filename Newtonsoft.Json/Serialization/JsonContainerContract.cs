using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000113 RID: 275
	[Token(Token = "0x2000113")]
	[NullableContext(2)]
	[Nullable(0)]
	public class JsonContainerContract : JsonContract
	{
		// Token: 0x17000102 RID: 258
		// (get) Token: 0x060007DC RID: 2012 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x060007DD RID: 2013 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000102")]
		internal JsonContract ItemContract
		{
			[Token(Token = "0x60007DC")]
			[Address(RVA = "0x5EE390", Offset = "0x5EC990", VA = "0x1805EE390")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007DD")]
			[Address(RVA = "0x2580970", Offset = "0x257EF70", VA = "0x182580970")]
			set
			{
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x060007DE RID: 2014 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000103")]
		internal JsonContract FinalItemContract
		{
			[Token(Token = "0x60007DE")]
			[Address(RVA = "0x750FA0", Offset = "0x74F5A0", VA = "0x180750FA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x060007DF RID: 2015 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x060007E0 RID: 2016 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000104")]
		public JsonConverter ItemConverter
		{
			[Token(Token = "0x60007DF")]
			[Address(RVA = "0x737420", Offset = "0x735A20", VA = "0x180737420")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60007E0")]
			[Address(RVA = "0x750FB0", Offset = "0x74F5B0", VA = "0x180750FB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x060007E1 RID: 2017 RVA: 0x000047B8 File Offset: 0x000029B8
		// (set) Token: 0x060007E2 RID: 2018 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000105")]
		public bool? ItemIsReference
		{
			[Token(Token = "0x60007E1")]
			[Address(RVA = "0x2580AE0", Offset = "0x257F0E0", VA = "0x182580AE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60007E2")]
			[Address(RVA = "0x2580AF0", Offset = "0x257F0F0", VA = "0x182580AF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x060007E3 RID: 2019 RVA: 0x000047D0 File Offset: 0x000029D0
		// (set) Token: 0x060007E4 RID: 2020 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000106")]
		public ReferenceLoopHandling? ItemReferenceLoopHandling
		{
			[Token(Token = "0x60007E3")]
			[Address(RVA = "0x2580B00", Offset = "0x257F100", VA = "0x182580B00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60007E4")]
			[Address(RVA = "0x2580B10", Offset = "0x257F110", VA = "0x182580B10")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x060007E5 RID: 2021 RVA: 0x000047E8 File Offset: 0x000029E8
		// (set) Token: 0x060007E6 RID: 2022 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000107")]
		public TypeNameHandling? ItemTypeNameHandling
		{
			[Token(Token = "0x60007E5")]
			[Address(RVA = "0x2580B20", Offset = "0x257F120", VA = "0x182580B20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60007E6")]
			[Address(RVA = "0x2580B30", Offset = "0x257F130", VA = "0x182580B30")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060007E7 RID: 2023 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007E7")]
		[Address(RVA = "0x2580B40", Offset = "0x257F140", VA = "0x182580B40")]
		[NullableContext(1)]
		internal JsonContainerContract(Type underlyingType)
		{
		}

		// Token: 0x0400051C RID: 1308
		[Token(Token = "0x400051C")]
		[FieldOffset(Offset = "0x90")]
		private JsonContract _itemContract;

		// Token: 0x0400051D RID: 1309
		[Token(Token = "0x400051D")]
		[FieldOffset(Offset = "0x98")]
		private JsonContract _finalItemContract;
	}
}
