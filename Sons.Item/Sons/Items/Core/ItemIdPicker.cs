using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Items.Core
{
	// Token: 0x02000025 RID: 37
	[Token(Token = "0x2000025")]
	public class ItemIdPicker : PropertyAttribute
	{
		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060000B1 RID: 177 RVA: 0x000027F0 File Offset: 0x000009F0
		// (set) Token: 0x060000B2 RID: 178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000049")]
		public Types Type
		{
			[Token(Token = "0x60000B1")]
			[Address(RVA = "0x66F520", Offset = "0x66DB20", VA = "0x18066F520")]
			[CompilerGenerated]
			get
			{
				return (Types)0;
			}
			[Token(Token = "0x60000B2")]
			[Address(RVA = "0x6DDE70", Offset = "0x6DC470", VA = "0x1806DDE70")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060000B3 RID: 179 RVA: 0x00002808 File Offset: 0x00000A08
		[Token(Token = "0x1700004A")]
		public bool Restricted
		{
			[Token(Token = "0x60000B3")]
			[Address(RVA = "0x150B770", Offset = "0x1509D70", VA = "0x18150B770")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060000B4 RID: 180 RVA: 0x00002820 File Offset: 0x00000A20
		[Token(Token = "0x1700004B")]
		public bool HideRestrictedType
		{
			[Token(Token = "0x60000B4")]
			[Address(RVA = "0x2B22510", Offset = "0x2B20B10", VA = "0x182B22510")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x30B0D80", Offset = "0x30AF380", VA = "0x1830B0D80")]
		public ItemIdPicker()
		{
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x30B0D90", Offset = "0x30AF390", VA = "0x1830B0D90")]
		public ItemIdPicker(bool hideRestrictedType)
		{
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x30B0DA0", Offset = "0x30AF3A0", VA = "0x1830B0DA0")]
		public ItemIdPicker(Types restrictedToType, bool hideRestrictedType = false)
		{
		}
	}
}
