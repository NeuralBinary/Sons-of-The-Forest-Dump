using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x02000163 RID: 355
	[Token(Token = "0x2000163")]
	[AddComponentMenu("Sons/Construction/DoorStructure")]
	public class DoorStructure : Structure
	{
		// Token: 0x170002AA RID: 682
		// (get) Token: 0x06000A97 RID: 2711 RVA: 0x00006E6C File Offset: 0x0000506C
		[Token(Token = "0x170002AA")]
		public override ushort TypeID
		{
			[Token(Token = "0x6000A97")]
			[Address(RVA = "0xE51960", Offset = "0xE4FF60", VA = "0x180E51960", Slot = "47")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x06000A98 RID: 2712 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170002AB")]
		public override Directions[] SupportedBy
		{
			[Token(Token = "0x6000A98")]
			[Address(RVA = "0x2E9C9B0", Offset = "0x2E9AFB0", VA = "0x182E9C9B0", Slot = "53")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002AC RID: 684
		// (get) Token: 0x06000A99 RID: 2713 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170002AC")]
		public static Counter Counter
		{
			[Token(Token = "0x6000A99")]
			[Address(RVA = "0x2E9CA00", Offset = "0x2E9B000", VA = "0x182E9CA00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x06000A9A RID: 2714 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A9A")]
		[Address(RVA = "0x2E9CA50", Offset = "0x2E9B050", VA = "0x182E9CA50", Slot = "59")]
		public override void OnPostLoad()
		{
		}

		// Token: 0x06000A9B RID: 2715 RVA: 0x00006E84 File Offset: 0x00005084
		[Token(Token = "0x6000A9B")]
		[Address(RVA = "0x2E9CA60", Offset = "0x2E9B060", VA = "0x182E9CA60", Slot = "69")]
		public override bool IsCompleted()
		{
			return default(bool);
		}

		// Token: 0x06000A9C RID: 2716 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000A9C")]
		[Address(RVA = "0x2E9CB10", Offset = "0x2E9B110", VA = "0x182E9CB10", Slot = "78")]
		public override StructureElement AddElement(StructureElement elementPrefab)
		{
			return null;
		}

		// Token: 0x06000A9D RID: 2717 RVA: 0x00006E9C File Offset: 0x0000509C
		[Token(Token = "0x6000A9D")]
		[Address(RVA = "0x2E8F6E0", Offset = "0x2E8DCE0", VA = "0x182E8F6E0", Slot = "73")]
		public override Vector3 CalcNextElementPosition(StructureElement elementPrefab)
		{
			return default(Vector3);
		}

		// Token: 0x06000A9E RID: 2718 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A9E")]
		[Address(RVA = "0x2E9CA50", Offset = "0x2E9B050", VA = "0x182E9CA50", Slot = "63")]
		public override void OnElementsChanged()
		{
		}

		// Token: 0x06000A9F RID: 2719 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A9F")]
		[Address(RVA = "0x2E9CCD0", Offset = "0x2E9B2D0", VA = "0x182E9CCD0")]
		private void UpdateStimuli()
		{
		}

		// Token: 0x06000AA0 RID: 2720 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AA0")]
		[Address(RVA = "0x2E9D150", Offset = "0x2E9B750", VA = "0x182E9D150")]
		public DoorStructure()
		{
		}

		// Token: 0x040006BA RID: 1722
		[Token(Token = "0x40006BA")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Directions[] SupportedByDirs;
	}
}
