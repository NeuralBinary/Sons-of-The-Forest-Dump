using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x020001A1 RID: 417
	[Token(Token = "0x20001A1")]
	[AddComponentMenu("Sons/Construction/HalfFloorStructure")]
	public class HalfFloorStructure : HalfStairsStructure
	{
		// Token: 0x17000308 RID: 776
		// (get) Token: 0x06000C9A RID: 3226 RVA: 0x00008204 File Offset: 0x00006404
		[Token(Token = "0x17000308")]
		public override ushort TypeID
		{
			[Token(Token = "0x6000C9A")]
			[Address(RVA = "0x2E9D320", Offset = "0x2E9B920", VA = "0x182E9D320", Slot = "47")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x06000C9B RID: 3227 RVA: 0x0000821C File Offset: 0x0000641C
		[Token(Token = "0x17000309")]
		public override int LinkedStructureCount
		{
			[Token(Token = "0x6000C9B")]
			[Address(RVA = "0xE51970", Offset = "0xE4FF70", VA = "0x180E51970", Slot = "50")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x06000C9C RID: 3228 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x1700030A")]
		public override Directions[] Supporting
		{
			[Token(Token = "0x6000C9C")]
			[Address(RVA = "0x2EC9450", Offset = "0x2EC7A50", VA = "0x182EC9450", Slot = "52")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x06000C9D RID: 3229 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x1700030B")]
		public override Directions[] SupportedBy
		{
			[Token(Token = "0x6000C9D")]
			[Address(RVA = "0x2EC94A0", Offset = "0x2EC7AA0", VA = "0x182EC94A0", Slot = "53")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x06000C9E RID: 3230 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x1700030C")]
		public new static Counter Counter
		{
			[Token(Token = "0x6000C9E")]
			[Address(RVA = "0x2EC94F0", Offset = "0x2EC7AF0", VA = "0x182EC94F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x06000C9F RID: 3231 RVA: 0x00008234 File Offset: 0x00006434
		[Token(Token = "0x6000C9F")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "105")]
		public override bool IsPlatformMode()
		{
			return default(bool);
		}

		// Token: 0x06000CA0 RID: 3232 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000CA0")]
		[Address(RVA = "0x2EC9540", Offset = "0x2EC7B40", VA = "0x182EC9540")]
		public HalfFloorStructure()
		{
		}

		// Token: 0x0400074B RID: 1867
		[Token(Token = "0x400074B")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Directions[] SupportingDirs;

		// Token: 0x0400074C RID: 1868
		[Token(Token = "0x400074C")]
		[FieldOffset(Offset = "0x10")]
		private static readonly Directions[] SupportedByDirs;
	}
}
