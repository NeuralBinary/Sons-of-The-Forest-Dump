using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x0200014C RID: 332
	[Token(Token = "0x200014C")]
	[AddComponentMenu("Sons/Construction/BridgeFloorStructure")]
	public class BridgeFloorStructure : Structure, ITargetablePlacement, IFreeFormStructureLinker, IStructure, IMonoBehaviour, ISuperStructureNode
	{
		// Token: 0x17000280 RID: 640
		// (get) Token: 0x060009C3 RID: 2499 RVA: 0x0000665C File Offset: 0x0000485C
		[Token(Token = "0x17000280")]
		public override ushort TypeID
		{
			[Token(Token = "0x60009C3")]
			[Address(RVA = "0x2E87740", Offset = "0x2E85D40", VA = "0x182E87740", Slot = "47")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x060009C4 RID: 2500 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000281")]
		public override Directions[] Supporting
		{
			[Token(Token = "0x60009C4")]
			[Address(RVA = "0x2E87750", Offset = "0x2E85D50", VA = "0x182E87750", Slot = "52")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x060009C5 RID: 2501 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000282")]
		public override Directions[] SupportedBy
		{
			[Token(Token = "0x60009C5")]
			[Address(RVA = "0x2E877A0", Offset = "0x2E85DA0", VA = "0x182E877A0", Slot = "53")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x060009C6 RID: 2502 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000283")]
		public static Counter Counter
		{
			[Token(Token = "0x60009C6")]
			[Address(RVA = "0x2E877F0", Offset = "0x2E85DF0", VA = "0x182E877F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x060009C7 RID: 2503 RVA: 0x00006674 File Offset: 0x00004874
		[Token(Token = "0x60009C7")]
		[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0", Slot = "67")]
		public override RepositionResults TryRepositionOnSupports(ElementRepositionAnimationTool repositionAnim)
		{
			return RepositionResults.Failed;
		}

		// Token: 0x060009C8 RID: 2504 RVA: 0x0000668C File Offset: 0x0000488C
		[Token(Token = "0x60009C8")]
		[Address(RVA = "0x2E87840", Offset = "0x2E85E40", VA = "0x182E87840", Slot = "71")]
		public override int CalcMaxElements(StructureElement prefab)
		{
			return 0;
		}

		// Token: 0x060009C9 RID: 2505 RVA: 0x000066A4 File Offset: 0x000048A4
		[Token(Token = "0x60009C9")]
		[Address(RVA = "0x2E878F0", Offset = "0x2E85EF0", VA = "0x182E878F0", Slot = "74")]
		public override Vector3 CalcElementPosition(StructureElement elementPrefab, int elementIndex)
		{
			return default(Vector3);
		}

		// Token: 0x060009CA RID: 2506 RVA: 0x000066BC File Offset: 0x000048BC
		[Token(Token = "0x60009CA")]
		[Address(RVA = "0x2E87C60", Offset = "0x2E86260", VA = "0x182E87C60", Slot = "77")]
		public override Quaternion CalcElementRotation(StructureElement elementPrefab, int elementIndex)
		{
			return default(Quaternion);
		}

		// Token: 0x060009CB RID: 2507 RVA: 0x000066D4 File Offset: 0x000048D4
		[Token(Token = "0x60009CB")]
		[Address(RVA = "0x2E87DF0", Offset = "0x2E863F0", VA = "0x182E87DF0", Slot = "75")]
		public override Vector3 CalcElementPosition(StructureElement elementPrefab, Vector3 position)
		{
			return default(Vector3);
		}

		// Token: 0x060009CC RID: 2508 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009CC")]
		[Address(RVA = "0x2E87E70", Offset = "0x2E86470", VA = "0x182E87E70", Slot = "106")]
		public void CalcClosestElementPlacement(StructureElement elementPrefab, Vector3 worldPos, int skip, out Vector3 position, out Quaternion rotation, out float lengthScale)
		{
		}

		// Token: 0x060009CD RID: 2509 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009CD")]
		[Address(RVA = "0x2E87EB0", Offset = "0x2E864B0", VA = "0x182E87EB0", Slot = "86")]
		public override void ApplyRepair(float healthAlpha)
		{
		}

		// Token: 0x060009CE RID: 2510 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009CE")]
		[Address(RVA = "0x2E88320", Offset = "0x2E86920", VA = "0x182E88320")]
		public BridgeFloorStructure()
		{
		}

		// Token: 0x060009D0 RID: 2512 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60009D0")]
		[Address(RVA = "0x2E57220", Offset = "0x2E55820", VA = "0x182E57220", Slot = "7")]
		private string get_name()
		{
			return null;
		}

		// Token: 0x060009D1 RID: 2513 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60009D1")]
		[Address(RVA = "0x2DC3B50", Offset = "0x2DC2150", VA = "0x182DC3B50", Slot = "42")]
		private GameObject get_gameObject()
		{
			return null;
		}

		// Token: 0x060009D2 RID: 2514 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60009D2")]
		[Address(RVA = "0x6602D0", Offset = "0x65E8D0", VA = "0x1806602D0", Slot = "43")]
		private Transform get_transform()
		{
			return null;
		}

		// Token: 0x060009D3 RID: 2515 RVA: 0x000066EC File Offset: 0x000048EC
		[Token(Token = "0x60009D3")]
		private bool TryGetComponent<T>(out T comp)
		{
			return default(bool);
		}

		// Token: 0x0400068D RID: 1677
		[Token(Token = "0x400068D")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Directions[] SupportingDirs;

		// Token: 0x0400068E RID: 1678
		[Token(Token = "0x400068E")]
		[FieldOffset(Offset = "0x10")]
		private static readonly Directions[] SupportedByDirs;

		// Token: 0x0200014D RID: 333
		[Token(Token = "0x200014D")]
		public static class Utils
		{
			// Token: 0x060009D4 RID: 2516 RVA: 0x00006704 File Offset: 0x00004904
			[Token(Token = "0x60009D4")]
			[Address(RVA = "0x2E88570", Offset = "0x2E86B70", VA = "0x182E88570")]
			public static int CalcMaxElementsFromSupport(BridgeRopeStructure support, StructureElement prefab)
			{
				return 0;
			}
		}
	}
}
