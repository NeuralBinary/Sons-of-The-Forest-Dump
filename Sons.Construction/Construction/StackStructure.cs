using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x0200021B RID: 539
	[Token(Token = "0x200021B")]
	[AddComponentMenu("Sons/Construction/StackStructure")]
	public class StackStructure : Structure
	{
		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x0600101F RID: 4127 RVA: 0x00009C8C File Offset: 0x00007E8C
		[Token(Token = "0x170003C0")]
		public override ushort TypeID
		{
			[Token(Token = "0x600101F")]
			[Address(RVA = "0xE599B0", Offset = "0xE57FB0", VA = "0x180E599B0", Slot = "47")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x06001020 RID: 4128 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170003C1")]
		public override Directions[] Supporting
		{
			[Token(Token = "0x6001020")]
			[Address(RVA = "0x2F0B230", Offset = "0x2F09830", VA = "0x182F0B230", Slot = "52")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x06001021 RID: 4129 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170003C2")]
		public static Counter Counter
		{
			[Token(Token = "0x6001021")]
			[Address(RVA = "0x2F0B280", Offset = "0x2F09880", VA = "0x182F0B280")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x06001022 RID: 4130 RVA: 0x00009CA4 File Offset: 0x00007EA4
		[Token(Token = "0x6001022")]
		[Address(RVA = "0x2F0B2D0", Offset = "0x2F098D0", VA = "0x182F0B2D0", Slot = "67")]
		public override RepositionResults TryRepositionOnSupports(ElementRepositionAnimationTool repositionAnim)
		{
			return RepositionResults.Failed;
		}

		// Token: 0x06001023 RID: 4131 RVA: 0x00009CBC File Offset: 0x00007EBC
		[Token(Token = "0x6001023")]
		[Address(RVA = "0x6C7320", Offset = "0x6C5920", VA = "0x1806C7320", Slot = "71")]
		public override int CalcMaxElements(StructureElement prefab)
		{
			return 0;
		}

		// Token: 0x06001024 RID: 4132 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6001024")]
		[Address(RVA = "0x2F0B940", Offset = "0x2F09F40", VA = "0x182F0B940", Slot = "78")]
		public override StructureElement AddElement(StructureElement elementPrefab)
		{
			return null;
		}

		// Token: 0x06001025 RID: 4133 RVA: 0x00009CD4 File Offset: 0x00007ED4
		[Token(Token = "0x6001025")]
		[Address(RVA = "0x2F0B970", Offset = "0x2F09F70", VA = "0x182F0B970")]
		private bool TryAddElementFromPresetTemplate(StructureElement elementPrefab, out StructureElement instance)
		{
			return default(bool);
		}

		// Token: 0x06001026 RID: 4134 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001026")]
		[Address(RVA = "0x2F0BEF0", Offset = "0x2F0A4F0", VA = "0x182F0BEF0", Slot = "86")]
		public override void ApplyRepair(float healthAlpha)
		{
		}

		// Token: 0x06001027 RID: 4135 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001027")]
		[Address(RVA = "0x2F0C3A0", Offset = "0x2F0A9A0", VA = "0x182F0C3A0")]
		public void CalcClosestElementPlacement(StructureElement elementPrefab, Vector3 worldPos, int skip, out Vector3 position, out Quaternion rotation, out float lengthScale)
		{
		}

		// Token: 0x06001028 RID: 4136 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001028")]
		[Address(RVA = "0x2F0C3E0", Offset = "0x2F0A9E0", VA = "0x182F0C3E0")]
		public StackStructure()
		{
		}

		// Token: 0x0400087D RID: 2173
		[Token(Token = "0x400087D")]
		public const int MaxElements = 50;

		// Token: 0x0400087F RID: 2175
		[Token(Token = "0x400087F")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Directions[] SupportingDirs;
	}
}
