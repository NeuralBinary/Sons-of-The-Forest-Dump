using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x020001F2 RID: 498
	[Token(Token = "0x20001F2")]
	[AddComponentMenu("Sons/Construction/FireStructure")]
	public class FireStructure : Structure, IReinforceableStructure, IStructure, IMonoBehaviour, ISuperStructureNode, ITargetablePlacement
	{
		// Token: 0x17000373 RID: 883
		// (get) Token: 0x06000EF8 RID: 3832 RVA: 0x0000917C File Offset: 0x0000737C
		[Token(Token = "0x17000373")]
		public override ushort TypeID
		{
			[Token(Token = "0x6000EF8")]
			[Address(RVA = "0x8F2830", Offset = "0x8F0E30", VA = "0x1808F2830", Slot = "47")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x06000EF9 RID: 3833 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000374")]
		public override Directions[] Supporting
		{
			[Token(Token = "0x6000EF9")]
			[Address(RVA = "0x2EF6940", Offset = "0x2EF4F40", VA = "0x182EF6940", Slot = "52")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x06000EFA RID: 3834 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000375")]
		public override Directions[] SupportedBy
		{
			[Token(Token = "0x6000EFA")]
			[Address(RVA = "0x2EF6990", Offset = "0x2EF4F90", VA = "0x182EF6990", Slot = "53")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000376 RID: 886
		// (get) Token: 0x06000EFB RID: 3835 RVA: 0x00009194 File Offset: 0x00007394
		[Token(Token = "0x17000376")]
		public new virtual int LinkedStructureCount
		{
			[Token(Token = "0x6000EFB")]
			[Address(RVA = "0x67D850", Offset = "0x67BE50", VA = "0x18067D850", Slot = "108")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000377 RID: 887
		// (get) Token: 0x06000EFC RID: 3836 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000377")]
		public static Counter Counter
		{
			[Token(Token = "0x6000EFC")]
			[Address(RVA = "0x2EF69E0", Offset = "0x2EF4FE0", VA = "0x182EF69E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x06000EFD RID: 3837 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000EFD")]
		[Address(RVA = "0x2EF6A30", Offset = "0x2EF5030", VA = "0x182EF6A30", Slot = "57")]
		public override void SetInstanceID(uint id)
		{
		}

		// Token: 0x06000EFE RID: 3838 RVA: 0x000091AC File Offset: 0x000073AC
		[Token(Token = "0x6000EFE")]
		[Address(RVA = "0x2EF6B20", Offset = "0x2EF5120", VA = "0x182EF6B20", Slot = "69")]
		public override bool IsCompleted()
		{
			return default(bool);
		}

		// Token: 0x06000EFF RID: 3839 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000EFF")]
		[Address(RVA = "0x2EF6B80", Offset = "0x2EF5180", VA = "0x182EF6B80", Slot = "79")]
		public override StructureElement AddElement(StructureElement elementPrefab, Vector3 position)
		{
			return null;
		}

		// Token: 0x06000F00 RID: 3840 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F00")]
		[Address(RVA = "0x2EF6DE0", Offset = "0x2EF53E0", VA = "0x182EF6DE0", Slot = "107")]
		public void CalcClosestElementPlacement(StructureElement elementPrefab, Vector3 worldPos, int skip, out Vector3 position, out Quaternion rotation, out float lengthScale)
		{
		}

		// Token: 0x06000F01 RID: 3841 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000F01")]
		[Address(RVA = "0x2EF6E20", Offset = "0x2EF5420", VA = "0x182EF6E20", Slot = "78")]
		public override StructureElement AddElement(StructureElement elementPrefab)
		{
			return null;
		}

		// Token: 0x06000F02 RID: 3842 RVA: 0x000091C4 File Offset: 0x000073C4
		[Token(Token = "0x6000F02")]
		[Address(RVA = "0x2EF6E90", Offset = "0x2EF5490", VA = "0x182EF6E90")]
		private bool TryAddElementFromPresetTemplate(StructureElement elementPrefab, out StructureElement instance)
		{
			return default(bool);
		}

		// Token: 0x06000F03 RID: 3843 RVA: 0x000091DC File Offset: 0x000073DC
		[Token(Token = "0x6000F03")]
		[Address(RVA = "0x2EF7410", Offset = "0x2EF5A10", VA = "0x182EF7410")]
		private bool TryAddElementFromFuelTemplate(StructureElement elementPrefab, out StructureElement instance)
		{
			return default(bool);
		}

		// Token: 0x06000F04 RID: 3844 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000F04")]
		[Address(RVA = "0x2EF7980", Offset = "0x2EF5F80", VA = "0x182EF7980")]
		private StructureElement AddElementAsReplacementForAll(StructureElement elementPrefab)
		{
			return null;
		}

		// Token: 0x06000F05 RID: 3845 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000F05")]
		[Address(RVA = "0x2EAB350", Offset = "0x2EA9950", VA = "0x182EAB350", Slot = "105")]
		private PresetElementsTemplate GetReinforcementTemplate()
		{
			return null;
		}

		// Token: 0x06000F06 RID: 3846 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F06")]
		[Address(RVA = "0x2EF7E20", Offset = "0x2EF6420", VA = "0x182EF7E20", Slot = "63")]
		public override void OnElementsChanged()
		{
		}

		// Token: 0x06000F07 RID: 3847 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F07")]
		[Address(RVA = "0x2EF7E20", Offset = "0x2EF6420", VA = "0x182EF7E20", Slot = "64")]
		public override void OnElementsChangedClient()
		{
		}

		// Token: 0x06000F08 RID: 3848 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F08")]
		[Address(RVA = "0x2EF7E20", Offset = "0x2EF6420", VA = "0x182EF7E20", Slot = "65")]
		public override void OnLinkedStructuresChanged()
		{
		}

		// Token: 0x06000F09 RID: 3849 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F09")]
		[Address(RVA = "0x2EF7E30", Offset = "0x2EF6430", VA = "0x182EF7E30")]
		private void RefreshBurnRatio()
		{
		}

		// Token: 0x06000F0A RID: 3850 RVA: 0x000091F4 File Offset: 0x000073F4
		[Token(Token = "0x6000F0A")]
		[Address(RVA = "0x2EF7FE0", Offset = "0x2EF65E0", VA = "0x182EF7FE0")]
		public int CountFuelElements()
		{
			return 0;
		}

		// Token: 0x06000F0B RID: 3851 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F0B")]
		[Address(RVA = "0x2EF8270", Offset = "0x2EF6870", VA = "0x182EF8270")]
		public void CalcElementCounts(out int totalElements, out int fuelElements, out int reinforcementElements)
		{
		}

		// Token: 0x06000F0C RID: 3852 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F0C")]
		[Address(RVA = "0x2EF8510", Offset = "0x2EF6B10", VA = "0x182EF8510")]
		public FireStructure()
		{
		}

		// Token: 0x06000F0E RID: 3854 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000F0E")]
		[Address(RVA = "0x2E57220", Offset = "0x2E55820", VA = "0x182E57220", Slot = "7")]
		private string get_name()
		{
			return null;
		}

		// Token: 0x06000F0F RID: 3855 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000F0F")]
		[Address(RVA = "0x2DC3B50", Offset = "0x2DC2150", VA = "0x182DC3B50", Slot = "42")]
		private GameObject get_gameObject()
		{
			return null;
		}

		// Token: 0x06000F10 RID: 3856 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000F10")]
		[Address(RVA = "0x6602D0", Offset = "0x65E8D0", VA = "0x1806602D0", Slot = "43")]
		private Transform get_transform()
		{
			return null;
		}

		// Token: 0x06000F11 RID: 3857 RVA: 0x0000920C File Offset: 0x0000740C
		[Token(Token = "0x6000F11")]
		private bool TryGetComponent<T>(out T comp)
		{
			return default(bool);
		}

		// Token: 0x0400081E RID: 2078
		[Token(Token = "0x400081E")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Directions[] SupportingDirs;

		// Token: 0x0400081F RID: 2079
		[Token(Token = "0x400081F")]
		[FieldOffset(Offset = "0x10")]
		private static readonly Directions[] SupportedByDirs;
	}
}
