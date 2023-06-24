using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x020001A2 RID: 418
	[Token(Token = "0x20001A2")]
	[CreateAssetMenu(menuName = "Sons/Construction/HalfStairsElementProfile")]
	public class HalfStairsElementProfile : ElementProfile
	{
		// Token: 0x06000CA2 RID: 3234 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000CA2")]
		[Address(RVA = "0x2EC97C0", Offset = "0x2EC7DC0", VA = "0x182EC97C0", Slot = "4")]
		public override PresetElementsTemplate GetElementTemplate(IStructure structure)
		{
			return null;
		}

		// Token: 0x06000CA3 RID: 3235 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000CA3")]
		[Address(RVA = "0x2EC9A20", Offset = "0x2EC8020", VA = "0x182EC9A20", Slot = "5")]
		public override PresetElementsTemplate GetElementTemplate(TargetInfo targetInfo, StructureElement prefab)
		{
			return null;
		}

		// Token: 0x06000CA4 RID: 3236 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000CA4")]
		[Address(RVA = "0x2EC9D20", Offset = "0x2EC8320", VA = "0x182EC9D20")]
		private PresetElementsTemplate GetTemplate(bool isClockwise, bool isBottomStairs, bool isCurved, bool isPlatform)
		{
			return null;
		}

		// Token: 0x06000CA5 RID: 3237 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000CA5")]
		[Address(RVA = "0x2EC9DA0", Offset = "0x2EC83A0", VA = "0x182EC9DA0")]
		public HalfStairsElementProfile()
		{
		}

		// Token: 0x0400074D RID: 1869
		[Token(Token = "0x400074D")]
		[FieldOffset(Offset = "0x138")]
		[Header("Half Stairs")]
		[SerializeField]
		private HalfStairsElementProfile.ElementTemplateGroup _clockwiseBottom;

		// Token: 0x0400074E RID: 1870
		[Token(Token = "0x400074E")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		private HalfStairsElementProfile.ElementTemplateGroup _clockwiseTop;

		// Token: 0x0400074F RID: 1871
		[Token(Token = "0x400074F")]
		[FieldOffset(Offset = "0x148")]
		[SerializeField]
		private HalfStairsElementProfile.ElementTemplateGroup _counterClockwiseBottom;

		// Token: 0x04000750 RID: 1872
		[Token(Token = "0x4000750")]
		[FieldOffset(Offset = "0x150")]
		[SerializeField]
		private HalfStairsElementProfile.ElementTemplateGroup _counterClockwiseTop;

		// Token: 0x020001A3 RID: 419
		[Token(Token = "0x20001A3")]
		[Serializable]
		public class ElementTemplateGroup
		{
			// Token: 0x1700030D RID: 781
			// (get) Token: 0x06000CA6 RID: 3238 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x1700030D")]
			public PresetElementsTemplate Straight
			{
				[Token(Token = "0x6000CA6")]
				[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700030E RID: 782
			// (get) Token: 0x06000CA7 RID: 3239 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x1700030E")]
			public PresetElementsTemplate Curved
			{
				[Token(Token = "0x6000CA7")]
				[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700030F RID: 783
			// (get) Token: 0x06000CA8 RID: 3240 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x1700030F")]
			public PresetElementsTemplate Platform
			{
				[Token(Token = "0x6000CA8")]
				[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000310 RID: 784
			// (get) Token: 0x06000CA9 RID: 3241 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x17000310")]
			public PresetElementsTemplate CurvedPlatform
			{
				[Token(Token = "0x6000CA9")]
				[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000CAA RID: 3242 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000CAA")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public ElementTemplateGroup()
			{
			}

			// Token: 0x04000751 RID: 1873
			[Token(Token = "0x4000751")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private PresetElementsTemplate _straight;

			// Token: 0x04000752 RID: 1874
			[Token(Token = "0x4000752")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private PresetElementsTemplate _curved;

			// Token: 0x04000753 RID: 1875
			[Token(Token = "0x4000753")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private PresetElementsTemplate _platform;

			// Token: 0x04000754 RID: 1876
			[Token(Token = "0x4000754")]
			[FieldOffset(Offset = "0x28")]
			[SerializeField]
			private PresetElementsTemplate _curvedPlatform;
		}
	}
}
