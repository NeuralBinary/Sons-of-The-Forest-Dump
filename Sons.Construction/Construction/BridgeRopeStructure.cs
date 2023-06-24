using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x0200014E RID: 334
	[Token(Token = "0x200014E")]
	[AddComponentMenu("Sons/Construction/BridgeRopeStructure")]
	public class BridgeRopeStructure : Structure, IHangingBetweenSupports, IStructure, IMonoBehaviour, ISuperStructureNode
	{
		// Token: 0x17000284 RID: 644
		// (get) Token: 0x060009D5 RID: 2517 RVA: 0x0000671C File Offset: 0x0000491C
		[Token(Token = "0x17000284")]
		public override ushort TypeID
		{
			[Token(Token = "0x60009D5")]
			[Address(RVA = "0x2E88600", Offset = "0x2E86C00", VA = "0x182E88600", Slot = "47")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x060009D6 RID: 2518 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000285")]
		public override Directions[] Supporting
		{
			[Token(Token = "0x60009D6")]
			[Address(RVA = "0x2E88610", Offset = "0x2E86C10", VA = "0x182E88610", Slot = "52")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x060009D7 RID: 2519 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000286")]
		public override Directions[] SupportedBy
		{
			[Token(Token = "0x60009D7")]
			[Address(RVA = "0x2E88660", Offset = "0x2E86C60", VA = "0x182E88660", Slot = "53")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x060009D8 RID: 2520 RVA: 0x00006734 File Offset: 0x00004934
		[Token(Token = "0x17000287")]
		public override int LinkedStructureCountForSuperStructure
		{
			[Token(Token = "0x60009D8")]
			[Address(RVA = "0x67D850", Offset = "0x67BE50", VA = "0x18067D850", Slot = "51")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x060009D9 RID: 2521 RVA: 0x0000674C File Offset: 0x0000494C
		[Token(Token = "0x17000288")]
		public override bool AllowSuperStructureMerge
		{
			[Token(Token = "0x60009D9")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "55")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x060009DA RID: 2522 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000289")]
		public static Counter Counter
		{
			[Token(Token = "0x60009DA")]
			[Address(RVA = "0x2E886B0", Offset = "0x2E86CB0", VA = "0x182E886B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x060009DB RID: 2523 RVA: 0x00006764 File Offset: 0x00004964
		[Token(Token = "0x60009DB")]
		[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0", Slot = "67")]
		public override RepositionResults TryRepositionOnSupports(ElementRepositionAnimationTool repositionAnim)
		{
			return RepositionResults.Failed;
		}

		// Token: 0x060009DC RID: 2524 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009DC")]
		[Address(RVA = "0x2E88700", Offset = "0x2E86D00", VA = "0x182E88700", Slot = "90")]
		public override void SetStructureAtDir(int direction, IStructure structure)
		{
		}

		// Token: 0x060009DD RID: 2525 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009DD")]
		[Address(RVA = "0x2E88AF0", Offset = "0x2E870F0", VA = "0x182E88AF0", Slot = "58")]
		public override void SetSuperStructure(SuperStructure ss)
		{
		}

		// Token: 0x060009DE RID: 2526 RVA: 0x0000677C File Offset: 0x0000497C
		[Token(Token = "0x60009DE")]
		[Address(RVA = "0xE51970", Offset = "0xE4FF70", VA = "0x180E51970", Slot = "71")]
		public override int CalcMaxElements(StructureElement prefab)
		{
			return 0;
		}

		// Token: 0x060009DF RID: 2527 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60009DF")]
		[Address(RVA = "0x2E88BC0", Offset = "0x2E871C0", VA = "0x182E88BC0", Slot = "78")]
		public override StructureElement AddElement(StructureElement elementPrefab)
		{
			return null;
		}

		// Token: 0x060009E0 RID: 2528 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009E0")]
		[Address(RVA = "0x2E894C0", Offset = "0x2E87AC0", VA = "0x182E894C0")]
		public BridgeRopeStructure()
		{
		}

		// Token: 0x060009E2 RID: 2530 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60009E2")]
		[Address(RVA = "0x2E57220", Offset = "0x2E55820", VA = "0x182E57220", Slot = "7")]
		private string get_name()
		{
			return null;
		}

		// Token: 0x060009E3 RID: 2531 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60009E3")]
		[Address(RVA = "0x2DC3B50", Offset = "0x2DC2150", VA = "0x182DC3B50", Slot = "42")]
		private GameObject get_gameObject()
		{
			return null;
		}

		// Token: 0x060009E4 RID: 2532 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60009E4")]
		[Address(RVA = "0x6602D0", Offset = "0x65E8D0", VA = "0x1806602D0", Slot = "43")]
		private Transform get_transform()
		{
			return null;
		}

		// Token: 0x060009E5 RID: 2533 RVA: 0x00006794 File Offset: 0x00004994
		[Token(Token = "0x60009E5")]
		private bool TryGetComponent<T>(out T comp)
		{
			return default(bool);
		}

		// Token: 0x0400068F RID: 1679
		[Token(Token = "0x400068F")]
		private const int MaxElements = 2;

		// Token: 0x04000691 RID: 1681
		[Token(Token = "0x4000691")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Directions[] SupportingDirs;

		// Token: 0x04000692 RID: 1682
		[Token(Token = "0x4000692")]
		[FieldOffset(Offset = "0x10")]
		private static readonly Directions[] SupportedByDirs;
	}
}
