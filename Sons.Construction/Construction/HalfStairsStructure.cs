using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x020001A4 RID: 420
	[Token(Token = "0x20001A4")]
	[AddComponentMenu("Sons/Construction/HalfStairsStructure")]
	public class HalfStairsStructure : Structure
	{
		// Token: 0x17000311 RID: 785
		// (get) Token: 0x06000CAB RID: 3243 RVA: 0x0000824C File Offset: 0x0000644C
		[Token(Token = "0x17000311")]
		public override ushort TypeID
		{
			[Token(Token = "0x6000CAB")]
			[Address(RVA = "0x230C2B0", Offset = "0x230A8B0", VA = "0x18230C2B0", Slot = "47")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x06000CAC RID: 3244 RVA: 0x00008264 File Offset: 0x00006464
		[Token(Token = "0x17000312")]
		public override int LinkedStructureCount
		{
			[Token(Token = "0x6000CAC")]
			[Address(RVA = "0xE51970", Offset = "0xE4FF70", VA = "0x180E51970", Slot = "50")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x06000CAD RID: 3245 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000313")]
		public override Directions[] Supporting
		{
			[Token(Token = "0x6000CAD")]
			[Address(RVA = "0x2EC9E20", Offset = "0x2EC8420", VA = "0x182EC9E20", Slot = "52")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x06000CAE RID: 3246 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000314")]
		public override Directions[] SupportedBy
		{
			[Token(Token = "0x6000CAE")]
			[Address(RVA = "0x2EC9E70", Offset = "0x2EC8470", VA = "0x182EC9E70", Slot = "53")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x06000CAF RID: 3247 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000315")]
		public static Counter Counter
		{
			[Token(Token = "0x6000CAF")]
			[Address(RVA = "0x2EC9EC0", Offset = "0x2EC84C0", VA = "0x182EC9EC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x06000CB0 RID: 3248 RVA: 0x0000827C File Offset: 0x0000647C
		[Token(Token = "0x6000CB0")]
		[Address(RVA = "0x2EC9F10", Offset = "0x2EC8510", VA = "0x182EC9F10", Slot = "71")]
		public override int CalcMaxElements(StructureElement stairsPrefab)
		{
			return 0;
		}

		// Token: 0x06000CB1 RID: 3249 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000CB1")]
		[Address(RVA = "0x2EC9F60", Offset = "0x2EC8560", VA = "0x182EC9F60", Slot = "78")]
		public override StructureElement AddElement(StructureElement elementPrefab)
		{
			return null;
		}

		// Token: 0x06000CB2 RID: 3250 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000CB2")]
		[Address(RVA = "0x2ECA050", Offset = "0x2EC8650", VA = "0x182ECA050")]
		private StructureElement AddElementFromTemplate(StructureElement elementPrefab, PresetElementsTemplate template)
		{
			return null;
		}

		// Token: 0x06000CB3 RID: 3251 RVA: 0x00008294 File Offset: 0x00006494
		[Token(Token = "0x6000CB3")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "105")]
		public virtual bool IsPlatformMode()
		{
			return default(bool);
		}

		// Token: 0x06000CB4 RID: 3252 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000CB4")]
		[Address(RVA = "0x2ECA2F0", Offset = "0x2EC88F0", VA = "0x182ECA2F0")]
		public HalfStairsStructure()
		{
		}

		// Token: 0x04000756 RID: 1878
		[Token(Token = "0x4000756")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Directions[] SupportingDirs;

		// Token: 0x04000757 RID: 1879
		[Token(Token = "0x4000757")]
		[FieldOffset(Offset = "0x10")]
		private static readonly Directions[] SupportedByDirs;

		// Token: 0x020001A5 RID: 421
		[Token(Token = "0x20001A5")]
		public static class Utils
		{
			// Token: 0x06000CB6 RID: 3254 RVA: 0x000082AC File Offset: 0x000064AC
			[Token(Token = "0x6000CB6")]
			[Address(RVA = "0x2ECA540", Offset = "0x2EC8B40", VA = "0x182ECA540")]
			public static Vector3 CalcHalfStairsSnapPosFromWall(IHalfStairsSupport support, Directions diagDir, StructureElement elementPrefab, Vector3 offsetFromSupport, bool isBottomStairs)
			{
				return default(Vector3);
			}

			// Token: 0x06000CB7 RID: 3255 RVA: 0x000082C4 File Offset: 0x000064C4
			[Token(Token = "0x6000CB7")]
			[Address(RVA = "0x2ECA680", Offset = "0x2EC8C80", VA = "0x182ECA680")]
			public static Vector3 CalcHalfStairsTopPosFromWall(IHalfStairsSupport support, Directions diagDir, StructureElement elementPrefab, Vector3 offsetFromWall, bool isBottomStairs)
			{
				return default(Vector3);
			}

			// Token: 0x06000CB8 RID: 3256 RVA: 0x000082DC File Offset: 0x000064DC
			[Token(Token = "0x6000CB8")]
			[Address(RVA = "0x2ECA940", Offset = "0x2EC8F40", VA = "0x182ECA940")]
			public static bool IsBottomStairs(HalfStairsStructure halfStairs, IHalfStairsSupport backSupport)
			{
				return default(bool);
			}

			// Token: 0x06000CB9 RID: 3257 RVA: 0x000082F4 File Offset: 0x000064F4
			[Token(Token = "0x6000CB9")]
			[Address(RVA = "0x2ECAAC0", Offset = "0x2EC90C0", VA = "0x182ECAAC0")]
			public static bool IsBottomStairs(float placeHeight, IHalfStairsSupport backSupport)
			{
				return default(bool);
			}

			// Token: 0x06000CBA RID: 3258 RVA: 0x0000830C File Offset: 0x0000650C
			[Token(Token = "0x6000CBA")]
			[Address(RVA = "0x2ECAB90", Offset = "0x2EC9190", VA = "0x182ECAB90")]
			public static Directions GetCurveDir(HalfStairsStructure halfStairs)
			{
				return Directions.LeafStructureSupport;
			}

			// Token: 0x06000CBB RID: 3259 RVA: 0x00008324 File Offset: 0x00006524
			[Token(Token = "0x6000CBB")]
			[Address(RVA = "0x2ECACE0", Offset = "0x2EC92E0", VA = "0x182ECACE0")]
			public static Directions GetCurveDir(IStructure backSupport, Vector3 halfStairsPos, Vector3 halfStairsForward)
			{
				return Directions.LeafStructureSupport;
			}
		}
	}
}
