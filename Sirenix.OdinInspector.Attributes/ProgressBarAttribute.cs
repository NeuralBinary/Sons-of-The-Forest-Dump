using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Sirenix.OdinInspector
{
	// Token: 0x0200004F RID: 79
	[Token(Token = "0x200004F")]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
	[Conditional("UNITY_EDITOR")]
	public sealed class ProgressBarAttribute : Attribute
	{
		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000BD RID: 189 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060000BE RID: 190 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000027")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use the MinGetter member instead.", false)]
		public string MinMember
		{
			[Token(Token = "0x60000BD")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000BE")]
			[Address(RVA = "0x5B2E10", Offset = "0x5B1410", VA = "0x1805B2E10")]
			set
			{
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000BF RID: 191 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060000C0 RID: 192 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000028")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use the MaxGetter member instead.", false)]
		public string MaxMember
		{
			[Token(Token = "0x60000BF")]
			[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000C0")]
			[Address(RVA = "0x5B27E0", Offset = "0x5B0DE0", VA = "0x1805B27E0")]
			set
			{
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000C1 RID: 193 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060000C2 RID: 194 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000029")]
		[Obsolete("Use the ColorGetter member instead.", false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string ColorMember
		{
			[Token(Token = "0x60000C1")]
			[Address(RVA = "0x5AC7C0", Offset = "0x5AADC0", VA = "0x1805AC7C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000C2")]
			[Address(RVA = "0x5B2560", Offset = "0x5B0B60", VA = "0x1805B2560")]
			set
			{
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000C3 RID: 195 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060000C4 RID: 196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700002A")]
		[Obsolete("Use the BackgroundColorGetter member instead.", false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string BackgroundColorMember
		{
			[Token(Token = "0x60000C3")]
			[Address(RVA = "0x6710C0", Offset = "0x66F6C0", VA = "0x1806710C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000C4")]
			[Address(RVA = "0x6710D0", Offset = "0x66F6D0", VA = "0x1806710D0")]
			set
			{
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000C5 RID: 197 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060000C6 RID: 198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700002B")]
		[Obsolete("Use the CustomValueStringGetter member instead.", false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string CustomValueStringMember
		{
			[Token(Token = "0x60000C5")]
			[Address(RVA = "0x6610E0", Offset = "0x65F6E0", VA = "0x1806610E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000C6")]
			[Address(RVA = "0x6610F0", Offset = "0x65F6F0", VA = "0x1806610F0")]
			set
			{
			}
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x2A89260", Offset = "0x2A87860", VA = "0x182A89260")]
		public ProgressBarAttribute(double min, double max, float r = 0.15f, float g = 0.47f, float b = 0.74f)
		{
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x2A892B0", Offset = "0x2A878B0", VA = "0x182A892B0")]
		public ProgressBarAttribute(string minGetter, double max, float r = 0.15f, float g = 0.47f, float b = 0.74f)
		{
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x2A89340", Offset = "0x2A87940", VA = "0x182A89340")]
		public ProgressBarAttribute(double min, string maxGetter, float r = 0.15f, float g = 0.47f, float b = 0.74f)
		{
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x2A893D0", Offset = "0x2A879D0", VA = "0x182A893D0")]
		public ProgressBarAttribute(string minGetter, string maxGetter, float r = 0.15f, float g = 0.47f, float b = 0.74f)
		{
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000CB RID: 203 RVA: 0x00002298 File Offset: 0x00000498
		// (set) Token: 0x060000CC RID: 204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700002C")]
		public bool DrawValueLabel
		{
			[Token(Token = "0x60000CB")]
			[Address(RVA = "0x213CBA0", Offset = "0x213B1A0", VA = "0x18213CBA0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000CC")]
			[Address(RVA = "0x2A894C0", Offset = "0x2A87AC0", VA = "0x182A894C0")]
			set
			{
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000CD RID: 205 RVA: 0x000022B0 File Offset: 0x000004B0
		// (set) Token: 0x060000CE RID: 206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700002D")]
		public bool DrawValueLabelHasValue
		{
			[Token(Token = "0x60000CD")]
			[Address(RVA = "0x15771D0", Offset = "0x15757D0", VA = "0x1815771D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000CE")]
			[Address(RVA = "0x15771E0", Offset = "0x15757E0", VA = "0x1815771E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000CF RID: 207 RVA: 0x000022C8 File Offset: 0x000004C8
		// (set) Token: 0x060000D0 RID: 208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700002E")]
		public TextAlignment ValueLabelAlignment
		{
			[Token(Token = "0x60000CF")]
			[Address(RVA = "0x245D8C0", Offset = "0x245BEC0", VA = "0x18245D8C0")]
			get
			{
				return TextAlignment.Left;
			}
			[Token(Token = "0x60000D0")]
			[Address(RVA = "0x2A894D0", Offset = "0x2A87AD0", VA = "0x182A894D0")]
			set
			{
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x000022E0 File Offset: 0x000004E0
		// (set) Token: 0x060000D2 RID: 210 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700002F")]
		public bool ValueLabelAlignmentHasValue
		{
			[Token(Token = "0x60000D1")]
			[Address(RVA = "0x2866320", Offset = "0x2864920", VA = "0x182866320")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000D2")]
			[Address(RVA = "0x2A894E0", Offset = "0x2A87AE0", VA = "0x182A894E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000D3 RID: 211 RVA: 0x000022F8 File Offset: 0x000004F8
		[Token(Token = "0x17000030")]
		public Color Color
		{
			[Token(Token = "0x60000D3")]
			[Address(RVA = "0x2A894F0", Offset = "0x2A87AF0", VA = "0x182A894F0")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x040000A7 RID: 167
		[Token(Token = "0x40000A7")]
		[FieldOffset(Offset = "0x10")]
		public double Min;

		// Token: 0x040000A8 RID: 168
		[Token(Token = "0x40000A8")]
		[FieldOffset(Offset = "0x18")]
		public double Max;

		// Token: 0x040000A9 RID: 169
		[Token(Token = "0x40000A9")]
		[FieldOffset(Offset = "0x20")]
		public string MinGetter;

		// Token: 0x040000AA RID: 170
		[Token(Token = "0x40000AA")]
		[FieldOffset(Offset = "0x28")]
		public string MaxGetter;

		// Token: 0x040000AB RID: 171
		[Token(Token = "0x40000AB")]
		[FieldOffset(Offset = "0x30")]
		public float R;

		// Token: 0x040000AC RID: 172
		[Token(Token = "0x40000AC")]
		[FieldOffset(Offset = "0x34")]
		public float G;

		// Token: 0x040000AD RID: 173
		[Token(Token = "0x40000AD")]
		[FieldOffset(Offset = "0x38")]
		public float B;

		// Token: 0x040000AE RID: 174
		[Token(Token = "0x40000AE")]
		[FieldOffset(Offset = "0x3C")]
		public int Height;

		// Token: 0x040000AF RID: 175
		[Token(Token = "0x40000AF")]
		[FieldOffset(Offset = "0x40")]
		public string ColorGetter;

		// Token: 0x040000B0 RID: 176
		[Token(Token = "0x40000B0")]
		[FieldOffset(Offset = "0x48")]
		public string BackgroundColorGetter;

		// Token: 0x040000B1 RID: 177
		[Token(Token = "0x40000B1")]
		[FieldOffset(Offset = "0x50")]
		public bool Segmented;

		// Token: 0x040000B2 RID: 178
		[Token(Token = "0x40000B2")]
		[FieldOffset(Offset = "0x58")]
		public string CustomValueStringGetter;

		// Token: 0x040000B3 RID: 179
		[Token(Token = "0x40000B3")]
		[FieldOffset(Offset = "0x60")]
		private bool drawValueLabel;

		// Token: 0x040000B4 RID: 180
		[Token(Token = "0x40000B4")]
		[FieldOffset(Offset = "0x64")]
		private TextAlignment valueLabelAlignment;
	}
}
