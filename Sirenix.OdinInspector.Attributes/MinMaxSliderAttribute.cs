using System;
using System.ComponentModel;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x02000044 RID: 68
	[Token(Token = "0x2000044")]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
	[Conditional("UNITY_EDITOR")]
	public sealed class MinMaxSliderAttribute : Attribute
	{
		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000099 RID: 153 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600009A RID: 154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000021")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use the MinValueGetter member instead.", false)]
		public string MinMember
		{
			[Token(Token = "0x6000099")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			get
			{
				return null;
			}
			[Token(Token = "0x600009A")]
			[Address(RVA = "0x635680", Offset = "0x633C80", VA = "0x180635680")]
			set
			{
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600009B RID: 155 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600009C RID: 156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000022")]
		[Obsolete("Use the MaxValueGetter member instead.", false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string MaxMember
		{
			[Token(Token = "0x600009B")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
			get
			{
				return null;
			}
			[Token(Token = "0x600009C")]
			[Address(RVA = "0x5B2E10", Offset = "0x5B1410", VA = "0x1805B2E10")]
			set
			{
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600009D RID: 157 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600009E RID: 158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000023")]
		[Obsolete("Use the MinMaxValueGetter member instead.", false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string MinMaxMember
		{
			[Token(Token = "0x600009D")]
			[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
			get
			{
				return null;
			}
			[Token(Token = "0x600009E")]
			[Address(RVA = "0x5B27E0", Offset = "0x5B0DE0", VA = "0x1805B27E0")]
			set
			{
			}
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600009F")]
		[Address(RVA = "0x2A88EC0", Offset = "0x2A874C0", VA = "0x182A88EC0")]
		public MinMaxSliderAttribute(float minValue, float maxValue, bool showFields = false)
		{
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x2A88ED0", Offset = "0x2A874D0", VA = "0x182A88ED0")]
		public MinMaxSliderAttribute(string minValueGetter, float maxValue, bool showFields = false)
		{
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x2A88F30", Offset = "0x2A87530", VA = "0x182A88F30")]
		public MinMaxSliderAttribute(float minValue, string maxValueGetter, bool showFields = false)
		{
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x2A88F90", Offset = "0x2A87590", VA = "0x182A88F90")]
		public MinMaxSliderAttribute(string minValueGetter, string maxValueGetter, bool showFields = false)
		{
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x2A89060", Offset = "0x2A87660", VA = "0x182A89060")]
		public MinMaxSliderAttribute(string minMaxValueGetter, bool showFields = false)
		{
		}

		// Token: 0x0400008E RID: 142
		[Token(Token = "0x400008E")]
		[FieldOffset(Offset = "0x10")]
		public float MinValue;

		// Token: 0x0400008F RID: 143
		[Token(Token = "0x400008F")]
		[FieldOffset(Offset = "0x14")]
		public float MaxValue;

		// Token: 0x04000090 RID: 144
		[Token(Token = "0x4000090")]
		[FieldOffset(Offset = "0x18")]
		public string MinValueGetter;

		// Token: 0x04000091 RID: 145
		[Token(Token = "0x4000091")]
		[FieldOffset(Offset = "0x20")]
		public string MaxValueGetter;

		// Token: 0x04000092 RID: 146
		[Token(Token = "0x4000092")]
		[FieldOffset(Offset = "0x28")]
		public string MinMaxValueGetter;

		// Token: 0x04000093 RID: 147
		[Token(Token = "0x4000093")]
		[FieldOffset(Offset = "0x30")]
		public bool ShowFields;
	}
}
