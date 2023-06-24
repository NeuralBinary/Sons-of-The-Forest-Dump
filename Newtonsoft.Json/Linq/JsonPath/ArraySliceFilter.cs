using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x02000195 RID: 405
	[Token(Token = "0x2000195")]
	internal class ArraySliceFilter : PathFilter
	{
		// Token: 0x17000238 RID: 568
		// (get) Token: 0x06000E0B RID: 3595 RVA: 0x00006A68 File Offset: 0x00004C68
		// (set) Token: 0x06000E0C RID: 3596 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000238")]
		public int? Start
		{
			[Token(Token = "0x6000E0B")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000E0C")]
			[Address(RVA = "0x754960", Offset = "0x752F60", VA = "0x180754960")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x06000E0D RID: 3597 RVA: 0x00006A80 File Offset: 0x00004C80
		// (set) Token: 0x06000E0E RID: 3598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000239")]
		public int? End
		{
			[Token(Token = "0x6000E0D")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000E0E")]
			[Address(RVA = "0x16755D0", Offset = "0x1673BD0", VA = "0x1816755D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x06000E0F RID: 3599 RVA: 0x00006A98 File Offset: 0x00004C98
		// (set) Token: 0x06000E10 RID: 3600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700023A")]
		public int? Step
		{
			[Token(Token = "0x6000E0F")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000E10")]
			[Address(RVA = "0xA7FE00", Offset = "0xA7E400", VA = "0x180A7FE00")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000E11 RID: 3601 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000E11")]
		[Address(RVA = "0x25E4320", Offset = "0x25E2920", VA = "0x1825E4320", Slot = "4")]
		[NullableContext(1)]
		public override IEnumerable<JToken> ExecuteFilter(JToken root, IEnumerable<JToken> current, [Nullable(2)] JsonSelectSettings settings)
		{
			return null;
		}

		// Token: 0x06000E12 RID: 3602 RVA: 0x00006AB0 File Offset: 0x00004CB0
		[Token(Token = "0x6000E12")]
		[Address(RVA = "0x25E4490", Offset = "0x25E2A90", VA = "0x1825E4490")]
		private bool IsValid(int index, int stopIndex, bool positiveStep)
		{
			return default(bool);
		}

		// Token: 0x06000E13 RID: 3603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E13")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public ArraySliceFilter()
		{
		}
	}
}
