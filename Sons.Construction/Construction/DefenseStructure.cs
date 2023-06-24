using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x020001E3 RID: 483
	[Token(Token = "0x20001E3")]
	[AddComponentMenu("Sons/Construction/DefenseStructure")]
	public class DefenseStructure : Structure, IBreakableStructure, IStructure, IMonoBehaviour, ISuperStructureNode, IReinforceableStructure, ITargetablePlacement
	{
		// Token: 0x17000355 RID: 853
		// (get) Token: 0x06000E48 RID: 3656 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000355")]
		public static Counter Counter
		{
			[Token(Token = "0x6000E48")]
			[Address(RVA = "0x2EE8F20", Offset = "0x2EE7520", VA = "0x182EE8F20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000356 RID: 854
		// (get) Token: 0x06000E49 RID: 3657 RVA: 0x00008E34 File Offset: 0x00007034
		[Token(Token = "0x17000356")]
		public override ushort TypeID
		{
			[Token(Token = "0x6000E49")]
			[Address(RVA = "0x2EE8F70", Offset = "0x2EE7570", VA = "0x182EE8F70", Slot = "47")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x06000E4A RID: 3658 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000357")]
		public override Directions[] Supporting
		{
			[Token(Token = "0x6000E4A")]
			[Address(RVA = "0x2EE8F80", Offset = "0x2EE7580", VA = "0x182EE8F80", Slot = "52")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000E4B RID: 3659 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000E4B")]
		[Address(RVA = "0x2EE8FD0", Offset = "0x2EE75D0", VA = "0x182EE8FD0", Slot = "79")]
		public override StructureElement AddElement(StructureElement elementPrefab, Vector3 position)
		{
			return null;
		}

		// Token: 0x06000E4C RID: 3660 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000E4C")]
		[Address(RVA = "0x2EE9230", Offset = "0x2EE7830", VA = "0x182EE9230", Slot = "110")]
		public void CalcClosestElementPlacement(StructureElement elementPrefab, Vector3 worldPos, int skip, out Vector3 position, out Quaternion rotation, out float lengthScale)
		{
		}

		// Token: 0x06000E4D RID: 3661 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000E4D")]
		[Address(RVA = "0x2EE9270", Offset = "0x2EE7870", VA = "0x182EE9270", Slot = "78")]
		public override StructureElement AddElement(StructureElement elementPrefab)
		{
			return null;
		}

		// Token: 0x06000E4E RID: 3662 RVA: 0x00008E4C File Offset: 0x0000704C
		[Token(Token = "0x6000E4E")]
		[Address(RVA = "0x2EE92D0", Offset = "0x2EE78D0", VA = "0x182EE92D0")]
		private bool TryAddElementFromPresetTemplate(StructureElement elementPrefab, out StructureElement instance)
		{
			return default(bool);
		}

		// Token: 0x06000E4F RID: 3663 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000E4F")]
		[Address(RVA = "0x2EE9850", Offset = "0x2EE7E50", VA = "0x182EE9850")]
		private StructureElement AddElementAsReplacementForAll(StructureElement elementPrefab)
		{
			return null;
		}

		// Token: 0x06000E50 RID: 3664 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000E50")]
		[Address(RVA = "0x2EAB350", Offset = "0x2EA9950", VA = "0x182EAB350", Slot = "108")]
		private PresetElementsTemplate GetReinforcementTemplate()
		{
			return null;
		}

		// Token: 0x06000E51 RID: 3665 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000E51")]
		[Address(RVA = "0x2EE9CF0", Offset = "0x2EE82F0", VA = "0x182EE9CF0", Slot = "63")]
		public override void OnElementsChanged()
		{
		}

		// Token: 0x06000E52 RID: 3666 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000E52")]
		[Address(RVA = "0x2EE9E50", Offset = "0x2EE8450", VA = "0x182EE9E50")]
		private void RefreshBreakableForSupportedStructures()
		{
		}

		// Token: 0x06000E53 RID: 3667 RVA: 0x00008E64 File Offset: 0x00007064
		[Token(Token = "0x6000E53")]
		[Address(RVA = "0x2EABDC0", Offset = "0x2EAA3C0", VA = "0x182EABDC0", Slot = "106")]
		private bool IsBreakable()
		{
			return default(bool);
		}

		// Token: 0x06000E54 RID: 3668 RVA: 0x00008E7C File Offset: 0x0000707C
		[Token(Token = "0x6000E54")]
		[Address(RVA = "0x2EABDE0", Offset = "0x2EAA3E0", VA = "0x182EABDE0", Slot = "107")]
		private float CalcBreakForce()
		{
			return 0f;
		}

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x06000E55 RID: 3669 RVA: 0x00008E94 File Offset: 0x00007094
		[Token(Token = "0x17000358")]
		public bool IsReinforced
		{
			[Token(Token = "0x6000E55")]
			[Address(RVA = "0x2EE9F90", Offset = "0x2EE8590", VA = "0x182EE9F90", Slot = "105")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000E56 RID: 3670 RVA: 0x00008EAC File Offset: 0x000070AC
		[Token(Token = "0x6000E56")]
		[Address(RVA = "0x2EE9FA0", Offset = "0x2EE85A0", VA = "0x182EE9FA0")]
		private bool CheckIsReinforced()
		{
			return default(bool);
		}

		// Token: 0x06000E57 RID: 3671 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000E57")]
		[Address(RVA = "0x2EEA210", Offset = "0x2EE8810", VA = "0x182EEA210")]
		public DefenseStructure()
		{
		}

		// Token: 0x06000E59 RID: 3673 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000E59")]
		[Address(RVA = "0x2E57220", Offset = "0x2E55820", VA = "0x182E57220", Slot = "7")]
		private string get_name()
		{
			return null;
		}

		// Token: 0x06000E5A RID: 3674 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000E5A")]
		[Address(RVA = "0x2DC3B50", Offset = "0x2DC2150", VA = "0x182DC3B50", Slot = "42")]
		private GameObject get_gameObject()
		{
			return null;
		}

		// Token: 0x06000E5B RID: 3675 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000E5B")]
		[Address(RVA = "0x6602D0", Offset = "0x65E8D0", VA = "0x1806602D0", Slot = "43")]
		private Transform get_transform()
		{
			return null;
		}

		// Token: 0x06000E5C RID: 3676 RVA: 0x00008EC4 File Offset: 0x000070C4
		[Token(Token = "0x6000E5C")]
		private bool TryGetComponent<T>(out T comp)
		{
			return default(bool);
		}

		// Token: 0x040007E3 RID: 2019
		[Token(Token = "0x40007E3")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Directions[] SupportingDirs;
	}
}
