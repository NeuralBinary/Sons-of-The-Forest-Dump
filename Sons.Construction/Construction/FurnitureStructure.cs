using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x02000198 RID: 408
	[Token(Token = "0x2000198")]
	[AddComponentMenu("Sons/Construction/FurnitureStructure")]
	public class FurnitureStructure : Structure, ITargetablePlacement
	{
		// Token: 0x170002FA RID: 762
		// (get) Token: 0x06000C65 RID: 3173 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170002FA")]
		public static Counter Counter
		{
			[Token(Token = "0x6000C65")]
			[Address(RVA = "0x2EC4580", Offset = "0x2EC2B80", VA = "0x182EC4580")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x06000C66 RID: 3174 RVA: 0x00007F94 File Offset: 0x00006194
		[Token(Token = "0x170002FB")]
		public override ushort TypeID
		{
			[Token(Token = "0x6000C66")]
			[Address(RVA = "0x2EC45D0", Offset = "0x2EC2BD0", VA = "0x182EC45D0", Slot = "47")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x06000C67 RID: 3175 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170002FC")]
		public override Directions[] Supporting
		{
			[Token(Token = "0x6000C67")]
			[Address(RVA = "0x2EC45E0", Offset = "0x2EC2BE0", VA = "0x182EC45E0", Slot = "52")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000C68 RID: 3176 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000C68")]
		[Address(RVA = "0x2EC4630", Offset = "0x2EC2C30", VA = "0x182EC4630", Slot = "78")]
		public override StructureElement AddElement(StructureElement elementPrefab)
		{
			return null;
		}

		// Token: 0x06000C69 RID: 3177 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000C69")]
		[Address(RVA = "0x2EC4690", Offset = "0x2EC2C90", VA = "0x182EC4690", Slot = "79")]
		public override StructureElement AddElement(StructureElement elementPrefab, Vector3 nearPos)
		{
			return null;
		}

		// Token: 0x06000C6A RID: 3178 RVA: 0x00007FAC File Offset: 0x000061AC
		[Token(Token = "0x6000C6A")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "69")]
		public override bool IsCompleted()
		{
			return default(bool);
		}

		// Token: 0x06000C6B RID: 3179 RVA: 0x00007FC4 File Offset: 0x000061C4
		[Token(Token = "0x6000C6B")]
		[Address(RVA = "0x2EC46E0", Offset = "0x2EC2CE0", VA = "0x182EC46E0")]
		private bool TryAddElementFromPresetTemplate(StructureElement elementPrefab, out StructureElement instance)
		{
			return default(bool);
		}

		// Token: 0x06000C6C RID: 3180 RVA: 0x00007FDC File Offset: 0x000061DC
		[Token(Token = "0x6000C6C")]
		[Address(RVA = "0x2EC4C60", Offset = "0x2EC3260", VA = "0x182EC4C60")]
		private bool TryAddNearestElementFromPresetTemplate(Vector3 nearPos, out StructureElement instance)
		{
			return default(bool);
		}

		// Token: 0x06000C6D RID: 3181 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000C6D")]
		[Address(RVA = "0x2EC4F80", Offset = "0x2EC3580", VA = "0x182EC4F80")]
		private StructureElement AddElementAsReplacementForAll(StructureElement elementPrefab)
		{
			return null;
		}

		// Token: 0x06000C6E RID: 3182 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C6E")]
		[Address(RVA = "0x2EC5420", Offset = "0x2EC3A20", VA = "0x182EC5420", Slot = "106")]
		public void CalcClosestElementPlacement(StructureElement elementPrefab, Vector3 worldPos, int skip, out Vector3 position, out Quaternion rotation, out float lengthScale)
		{
		}

		// Token: 0x06000C6F RID: 3183 RVA: 0x00007FF4 File Offset: 0x000061F4
		[Token(Token = "0x6000C6F")]
		[Address(RVA = "0x2EC5460", Offset = "0x2EC3A60", VA = "0x182EC5460", Slot = "81")]
		public override bool TryGetRemoveableElement(Vector3 nearPos, out StructureElement element)
		{
			return default(bool);
		}

		// Token: 0x06000C70 RID: 3184 RVA: 0x0000800C File Offset: 0x0000620C
		[Token(Token = "0x6000C70")]
		[Address(RVA = "0x2EC5510", Offset = "0x2EC3B10", VA = "0x182EC5510")]
		private static bool HasContent(StructureElement element)
		{
			return default(bool);
		}

		// Token: 0x06000C71 RID: 3185 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C71")]
		[Address(RVA = "0x2EC5890", Offset = "0x2EC3E90", VA = "0x182EC5890")]
		public FurnitureStructure()
		{
		}

		// Token: 0x04000746 RID: 1862
		[Token(Token = "0x4000746")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Directions[] SupportingDirs;
	}
}
