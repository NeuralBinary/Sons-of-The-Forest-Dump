using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x02000069 RID: 105
	[Token(Token = "0x2000069")]
	[AddComponentMenu("Sons/Construction/PresetElementsTemplate")]
	public class PresetElementsTemplate : MonoBehaviour
	{
		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x060002A5 RID: 677 RVA: 0x000032B4 File Offset: 0x000014B4
		[Token(Token = "0x170000F7")]
		public PresetElementsTemplate.FillTypes FillType
		{
			[Token(Token = "0x60002A5")]
			[Address(RVA = "0x632000", Offset = "0x630600", VA = "0x180632000")]
			get
			{
				return PresetElementsTemplate.FillTypes.Linear;
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x060002A6 RID: 678 RVA: 0x000032CC File Offset: 0x000014CC
		[Token(Token = "0x170000F8")]
		public int ElementCount
		{
			[Token(Token = "0x60002A6")]
			[Address(RVA = "0x2D78910", Offset = "0x2D76F10", VA = "0x182D78910")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x060002A7 RID: 679 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170000F9")]
		private Transform ElementsRoot
		{
			[Token(Token = "0x60002A7")]
			[Address(RVA = "0x2D78930", Offset = "0x2D76F30", VA = "0x182D78930")]
			get
			{
				return null;
			}
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x000032E4 File Offset: 0x000014E4
		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x2D78A40", Offset = "0x2D77040", VA = "0x182D78A40")]
		public bool TryGetElementOverrideProfile(int elementNum, out StructureElement profile)
		{
			return default(bool);
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x000032FC File Offset: 0x000014FC
		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x2D78C20", Offset = "0x2D77220", VA = "0x182D78C20")]
		public bool TryGetPseudoRandomElementOverrideProfile(Vector3 worldPos, out StructureElement profile)
		{
			return default(bool);
		}

		// Token: 0x060002AA RID: 682 RVA: 0x00003314 File Offset: 0x00001514
		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x2D78EC0", Offset = "0x2D774C0", VA = "0x182D78EC0")]
		public bool TryGetElementLocalPos(int elementNum, out Vector3 localPos)
		{
			return default(bool);
		}

		// Token: 0x060002AB RID: 683 RVA: 0x0000332C File Offset: 0x0000152C
		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x2D78F90", Offset = "0x2D77590", VA = "0x182D78F90")]
		public bool TryGetElementWorldPos(IStructure structure, int elementNum, out Vector3 worldPos)
		{
			return default(bool);
		}

		// Token: 0x060002AC RID: 684 RVA: 0x00003344 File Offset: 0x00001544
		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x2D79130", Offset = "0x2D77730", VA = "0x182D79130")]
		public bool TryGetElementLocalRot(int elementNum, out Quaternion localRot)
		{
			return default(bool);
		}

		// Token: 0x060002AD RID: 685 RVA: 0x0000335C File Offset: 0x0000155C
		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x2D791F0", Offset = "0x2D777F0", VA = "0x182D791F0")]
		public bool TryGetElementWorldRot(IStructure structure, int elementNum, out Quaternion worldRot)
		{
			return default(bool);
		}

		// Token: 0x060002AE RID: 686 RVA: 0x00003374 File Offset: 0x00001574
		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x2D79390", Offset = "0x2D77990", VA = "0x182D79390")]
		public bool TryGetElementWorldPosRot(IStructure structure, int elementNum, out Vector3 worldPos, out Quaternion worldRot, [Optional] Vector3 offset)
		{
			return default(bool);
		}

		// Token: 0x060002AF RID: 687 RVA: 0x0000338C File Offset: 0x0000158C
		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x2D79660", Offset = "0x2D77C60", VA = "0x182D79660")]
		public bool TryGetElementLocalPosRot(int elementNum, out Vector3 localPos, out Quaternion localRot)
		{
			return default(bool);
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x000033A4 File Offset: 0x000015A4
		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x2D797B0", Offset = "0x2D77DB0", VA = "0x182D797B0")]
		public bool TryGetElementLocalTrInfo(int elementNum, out Vector3 localPos, out Quaternion localRot, out Vector3 localScale)
		{
			return default(bool);
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x000033BC File Offset: 0x000015BC
		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x2D79970", Offset = "0x2D77F70", VA = "0x182D79970")]
		public bool TryGetElementLocalTrInfo(int elementNum, out Vector3 localPos, out Quaternion localRot, out Vector3 localScale, out StructureElement elementOverride)
		{
			return default(bool);
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x000033D4 File Offset: 0x000015D4
		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x2D79C40", Offset = "0x2D78240", VA = "0x182D79C40")]
		public bool TryGetElementWorldTrInfo(IStructure structure, int elementNum, out Vector3 worldPos, out Quaternion worldRot, out Vector3 scale, out StructureElement elementOverride)
		{
			return default(bool);
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x000033EC File Offset: 0x000015EC
		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x2D7A060", Offset = "0x2D78660", VA = "0x182D7A060")]
		public bool IsElementValid(IStructure structure, int elementNum)
		{
			return default(bool);
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x00003404 File Offset: 0x00001604
		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x2D7A1B0", Offset = "0x2D787B0", VA = "0x182D7A1B0")]
		public bool IsElementValid(Structure structure, Vector3 nearPos, [Optional] Vector3 offset, bool excludeAlreadyPlaced = true)
		{
			return default(bool);
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x0000341C File Offset: 0x0000161C
		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x2D7A6C0", Offset = "0x2D78CC0", VA = "0x182D7A6C0")]
		public bool TryGetNearestElementWorldPos(Structure structure, Vector3 nearPos, out Vector3 pos, [Optional] Vector3 offset, bool excludeAlreadyPlaced = true)
		{
			return default(bool);
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x00003434 File Offset: 0x00001634
		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x2D7AD30", Offset = "0x2D79330", VA = "0x182D7AD30")]
		public bool TryGetNearestElementWorldPos(Vector3 centerPos, Quaternion rot, Vector3 nearPos, out Vector3 pos, [Optional] Structure excludeAlreadyPlacedInStructure)
		{
			return default(bool);
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x0000344C File Offset: 0x0000164C
		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x2D7AF90", Offset = "0x2D79590", VA = "0x182D7AF90")]
		public bool TryGetNearestElementTrInfo(Structure structure, Vector3 nearPos, out Vector3 pos, out Quaternion rot, out StructureElement elementOverride, [Optional] Vector3 offset, bool excludeAlreadyPlaced = true)
		{
			return default(bool);
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x00003464 File Offset: 0x00001664
		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x2D7B4C0", Offset = "0x2D79AC0", VA = "0x182D7B4C0")]
		public bool TryGetNearestElementLocalTrInfo(Structure structure, Vector3 nearPos, out Vector3 localPos, out Quaternion localRot, out StructureElement elementOverride, [Optional] Vector3 offset, bool excludeAlreadyPlaced = true)
		{
			return default(bool);
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x2D7B900", Offset = "0x2D79F00", VA = "0x182D7B900")]
		private Transform GetClosestMissingElement(Vector3 worldPos, Quaternion worldRot, Vector3 nearPos, [Optional] Transform excludeAlreadyPlacedInStructure)
		{
			return null;
		}

		// Token: 0x060002BA RID: 698 RVA: 0x0000347C File Offset: 0x0000167C
		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x2D7C750", Offset = "0x2D7AD50", VA = "0x182D7C750")]
		private int GetElementTrNum(Transform elementTr)
		{
			return 0;
		}

		// Token: 0x060002BB RID: 699 RVA: 0x00003494 File Offset: 0x00001694
		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x2D7C8D0", Offset = "0x2D7AED0", VA = "0x182D7C8D0")]
		public Vector3 GetSnapPointPos(FurnitureStructure furniture)
		{
			return default(Vector3);
		}

		// Token: 0x060002BC RID: 700 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public PresetElementsTemplate()
		{
		}

		// Token: 0x040002AC RID: 684
		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Multiline]
		[SerializeField]
		private string _setupInfo;

		// Token: 0x040002AD RID: 685
		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private PresetElementsTemplate.FillTypes _fillType;

		// Token: 0x040002AE RID: 686
		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform _elementsRoot;

		// Token: 0x040002AF RID: 687
		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform[] _elementsTr;

		// Token: 0x040002B0 RID: 688
		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private StructureElement[] _elementsOverride;

		// Token: 0x040002B1 RID: 689
		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private PresetElementsTemplateConditionBase[] _conditions;

		// Token: 0x040002B2 RID: 690
		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Vector3 _snapPointPos;

		// Token: 0x040002B3 RID: 691
		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[SerializeField]
		[Header("Placement Aiming")]
		private bool _useFirstElementRotation;

		// Token: 0x040002B4 RID: 692
		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5D")]
		[SerializeField]
		private bool _orientUpwards;

		// Token: 0x0200006A RID: 106
		[Token(Token = "0x200006A")]
		public enum FillTypes
		{
			// Token: 0x040002B6 RID: 694
			[Token(Token = "0x40002B6")]
			Linear,
			// Token: 0x040002B7 RID: 695
			[Token(Token = "0x40002B7")]
			Anywhere
		}
	}
}
