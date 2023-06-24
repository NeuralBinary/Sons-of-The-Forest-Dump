using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x0200014B RID: 331
	[Token(Token = "0x200014B")]
	[AddComponentMenu("Sons/Construction/RockBeamStructure")]
	public class RockBeamStructure : BeamStructure, IRockStructure, IStructure, IMonoBehaviour, ISuperStructureNode, ITargetablePlacement
	{
		// Token: 0x1700027E RID: 638
		// (get) Token: 0x060009AD RID: 2477 RVA: 0x0000656C File Offset: 0x0000476C
		[Token(Token = "0x1700027E")]
		public override ushort TypeID
		{
			[Token(Token = "0x60009AD")]
			[Address(RVA = "0xE59A00", Offset = "0xE58000", VA = "0x180E59A00", Slot = "47")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x060009AE RID: 2478 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x1700027F")]
		public new static Counter Counter
		{
			[Token(Token = "0x60009AE")]
			[Address(RVA = "0x2E858B0", Offset = "0x2E83EB0", VA = "0x182E858B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x060009AF RID: 2479 RVA: 0x00006584 File Offset: 0x00004784
		[Token(Token = "0x60009AF")]
		[Address(RVA = "0x67D850", Offset = "0x67BE50", VA = "0x18067D850", Slot = "67")]
		public override RepositionResults TryRepositionOnSupports(ElementRepositionAnimationTool repositionAnim)
		{
			return RepositionResults.Failed;
		}

		// Token: 0x060009B0 RID: 2480 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60009B0")]
		[Address(RVA = "0x2E85900", Offset = "0x2E83F00", VA = "0x182E85900", Slot = "173")]
		public StructureElement GetElementPlacementInfo(StructureElement linePrefab, int lineNum, out Vector3 worldPos, out Quaternion worldRot, out float zScale, [Optional] Vector3 nearPos)
		{
			return null;
		}

		// Token: 0x060009B1 RID: 2481 RVA: 0x0000659C File Offset: 0x0000479C
		[Token(Token = "0x60009B1")]
		[Address(RVA = "0x2E85B50", Offset = "0x2E84150", VA = "0x182E85B50", Slot = "174")]
		private Vector3 CalcTemplateOffset(StructureElement elementInstance)
		{
			return default(Vector3);
		}

		// Token: 0x060009B2 RID: 2482 RVA: 0x000065B4 File Offset: 0x000047B4
		[Token(Token = "0x60009B2")]
		[Address(RVA = "0x2E85E90", Offset = "0x2E84490", VA = "0x182E85E90", Slot = "69")]
		public override bool IsCompleted()
		{
			return default(bool);
		}

		// Token: 0x060009B3 RID: 2483 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60009B3")]
		[Address(RVA = "0x2E85EB0", Offset = "0x2E844B0", VA = "0x182E85EB0", Slot = "78")]
		public override StructureElement AddElement(StructureElement elementPrefab)
		{
			return null;
		}

		// Token: 0x060009B4 RID: 2484 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60009B4")]
		[Address(RVA = "0x2E86000", Offset = "0x2E84600", VA = "0x182E86000", Slot = "79")]
		public override StructureElement AddElement(StructureElement elementPrefab, Vector3 worldPos)
		{
			return null;
		}

		// Token: 0x060009B5 RID: 2485 RVA: 0x000065CC File Offset: 0x000047CC
		[Token(Token = "0x60009B5")]
		[Address(RVA = "0x2E86040", Offset = "0x2E84640", VA = "0x182E86040")]
		private bool CheckBeamWasCompleted(out StructureElement addElement)
		{
			return default(bool);
		}

		// Token: 0x060009B6 RID: 2486 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009B6")]
		[Address(RVA = "0x2E863D0", Offset = "0x2E849D0", VA = "0x182E863D0")]
		public void RefreshAfterFakePilarChange()
		{
		}

		// Token: 0x060009B7 RID: 2487 RVA: 0x000065E4 File Offset: 0x000047E4
		[Token(Token = "0x60009B7")]
		[Address(RVA = "0x2E86A50", Offset = "0x2E85050", VA = "0x182E86A50", Slot = "73")]
		public override Vector3 CalcNextElementPosition(StructureElement elementPrefab)
		{
			return default(Vector3);
		}

		// Token: 0x060009B8 RID: 2488 RVA: 0x000065FC File Offset: 0x000047FC
		[Token(Token = "0x60009B8")]
		[Address(RVA = "0x2E86A50", Offset = "0x2E85050", VA = "0x182E86A50", Slot = "74")]
		public override Vector3 CalcElementPosition(StructureElement elementPrefab, int elementIndex)
		{
			return default(Vector3);
		}

		// Token: 0x060009B9 RID: 2489 RVA: 0x00006614 File Offset: 0x00004814
		[Token(Token = "0x60009B9")]
		[Address(RVA = "0x2E86AB0", Offset = "0x2E850B0", VA = "0x182E86AB0", Slot = "83")]
		public override bool TryRemoveElement(Vector3 nearPos, out ElementProfile elementProfile)
		{
			return default(bool);
		}

		// Token: 0x060009BA RID: 2490 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009BA")]
		[Address(RVA = "0x2E872B0", Offset = "0x2E858B0", VA = "0x182E872B0", Slot = "86")]
		public override void ApplyRepair(float healthAlpha)
		{
		}

		// Token: 0x060009BB RID: 2491 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009BB")]
		[Address(RVA = "0x2E872C0", Offset = "0x2E858C0", VA = "0x182E872C0", Slot = "176")]
		private void CalcClosestElementPlacement(StructureElement elementPrefab, Vector3 worldPos, int skip, out Vector3 position, out Quaternion rotation, out float lengthScale)
		{
		}

		// Token: 0x060009BC RID: 2492 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009BC")]
		[Address(RVA = "0x2E87300", Offset = "0x2E85900", VA = "0x182E87300")]
		public RockBeamStructure()
		{
		}

		// Token: 0x060009BE RID: 2494 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60009BE")]
		[Address(RVA = "0x2E57220", Offset = "0x2E55820", VA = "0x182E57220", Slot = "7")]
		private string get_name()
		{
			return null;
		}

		// Token: 0x060009BF RID: 2495 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60009BF")]
		[Address(RVA = "0x2DC3B50", Offset = "0x2DC2150", VA = "0x182DC3B50", Slot = "42")]
		private GameObject get_gameObject()
		{
			return null;
		}

		// Token: 0x060009C0 RID: 2496 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60009C0")]
		[Address(RVA = "0x6602D0", Offset = "0x65E8D0", VA = "0x1806602D0", Slot = "43")]
		private Transform get_transform()
		{
			return null;
		}

		// Token: 0x060009C1 RID: 2497 RVA: 0x0000662C File Offset: 0x0000482C
		[Token(Token = "0x60009C1")]
		private bool TryGetComponent<T>(out T comp)
		{
			return default(bool);
		}

		// Token: 0x060009C2 RID: 2498 RVA: 0x00006644 File Offset: 0x00004844
		[Token(Token = "0x60009C2")]
		[Address(RVA = "0x2E87400", Offset = "0x2E85A00", VA = "0x182E87400")]
		[CompilerGenerated]
		private bool <TryRemoveElement>g__TryCleanUpFakePilarElement|15_0(FakePilarStructure fakePilar, StructureElement removedElement, float removedElementLength)
		{
			return default(bool);
		}
	}
}
