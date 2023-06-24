using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x020001E1 RID: 481
	[Token(Token = "0x20001E1")]
	[AddComponentMenu("Sons/Construction/RockPilarStructure")]
	public class RockPilarStructure : PilarStructure, IRockStructure, IStructure, IMonoBehaviour, ISuperStructureNode
	{
		// Token: 0x17000350 RID: 848
		// (get) Token: 0x06000E2D RID: 3629 RVA: 0x00008CE4 File Offset: 0x00006EE4
		[Token(Token = "0x17000350")]
		public override ushort TypeID
		{
			[Token(Token = "0x6000E2D")]
			[Address(RVA = "0x2E33FC0", Offset = "0x2E325C0", VA = "0x182E33FC0", Slot = "47")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000351 RID: 849
		// (get) Token: 0x06000E2E RID: 3630 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000351")]
		public new static Counter Counter
		{
			[Token(Token = "0x6000E2E")]
			[Address(RVA = "0x2EE73A0", Offset = "0x2EE59A0", VA = "0x182EE73A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x06000E2F RID: 3631 RVA: 0x00008CFC File Offset: 0x00006EFC
		[Token(Token = "0x6000E2F")]
		[Address(RVA = "0x67D850", Offset = "0x67BE50", VA = "0x18067D850", Slot = "67")]
		public override RepositionResults TryRepositionOnSupports(ElementRepositionAnimationTool repositionAnim)
		{
			return RepositionResults.Failed;
		}

		// Token: 0x06000E30 RID: 3632 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000E30")]
		[Address(RVA = "0x2EE73F0", Offset = "0x2EE59F0", VA = "0x182EE73F0", Slot = "127")]
		private StructureElement GetElementPlacementInfo(StructureElement linePrefab, int lineNum, out Vector3 worldPos, out Quaternion worldRot, out float zScale, Vector3 nearPos)
		{
			return null;
		}

		// Token: 0x06000E31 RID: 3633 RVA: 0x00008D14 File Offset: 0x00006F14
		[Token(Token = "0x6000E31")]
		[Address(RVA = "0x2EE7610", Offset = "0x2EE5C10", VA = "0x182EE7610", Slot = "128")]
		private Vector3 CalcTemplateOffset(StructureElement elementInstance)
		{
			return default(Vector3);
		}

		// Token: 0x06000E32 RID: 3634 RVA: 0x00008D2C File Offset: 0x00006F2C
		[Token(Token = "0x6000E32")]
		[Address(RVA = "0x2EE77E0", Offset = "0x2EE5DE0", VA = "0x182EE77E0")]
		public Vector3 CalcElementPosition(StructureElement elementPrefab)
		{
			return default(Vector3);
		}

		// Token: 0x06000E33 RID: 3635 RVA: 0x00008D44 File Offset: 0x00006F44
		[Token(Token = "0x6000E33")]
		[Address(RVA = "0x2E85E90", Offset = "0x2E84490", VA = "0x182E85E90", Slot = "69")]
		public override bool IsCompleted()
		{
			return default(bool);
		}

		// Token: 0x06000E34 RID: 3636 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000E34")]
		[Address(RVA = "0x2EE7990", Offset = "0x2EE5F90", VA = "0x182EE7990", Slot = "78")]
		public override StructureElement AddElement(StructureElement elementPrefab)
		{
			return null;
		}

		// Token: 0x06000E35 RID: 3637 RVA: 0x00008D5C File Offset: 0x00006F5C
		[Token(Token = "0x6000E35")]
		[Address(RVA = "0x2E86A50", Offset = "0x2E85050", VA = "0x182E86A50", Slot = "74")]
		public override Vector3 CalcElementPosition(StructureElement elementPrefab, int elementIndex)
		{
			return default(Vector3);
		}

		// Token: 0x06000E36 RID: 3638 RVA: 0x00008D74 File Offset: 0x00006F74
		[Token(Token = "0x6000E36")]
		[Address(RVA = "0x2EE7BF0", Offset = "0x2EE61F0", VA = "0x182EE7BF0", Slot = "83")]
		public override bool TryRemoveElement(Vector3 nearPos, out ElementProfile elementProfile)
		{
			return default(bool);
		}

		// Token: 0x06000E37 RID: 3639 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000E37")]
		[Address(RVA = "0x2E872B0", Offset = "0x2E858B0", VA = "0x182E872B0", Slot = "86")]
		public override void ApplyRepair(float healthAlpha)
		{
		}

		// Token: 0x06000E38 RID: 3640 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000E38")]
		[Address(RVA = "0x2EE7EF0", Offset = "0x2EE64F0", VA = "0x182EE7EF0")]
		public RockPilarStructure()
		{
		}

		// Token: 0x06000E3A RID: 3642 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000E3A")]
		[Address(RVA = "0x2E57220", Offset = "0x2E55820", VA = "0x182E57220", Slot = "7")]
		private string get_name()
		{
			return null;
		}

		// Token: 0x06000E3B RID: 3643 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000E3B")]
		[Address(RVA = "0x2DC3B50", Offset = "0x2DC2150", VA = "0x182DC3B50", Slot = "42")]
		private GameObject get_gameObject()
		{
			return null;
		}

		// Token: 0x06000E3C RID: 3644 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000E3C")]
		[Address(RVA = "0x6602D0", Offset = "0x65E8D0", VA = "0x1806602D0", Slot = "43")]
		private Transform get_transform()
		{
			return null;
		}

		// Token: 0x06000E3D RID: 3645 RVA: 0x00008D8C File Offset: 0x00006F8C
		[Token(Token = "0x6000E3D")]
		private bool TryGetComponent<T>(out T comp)
		{
			return default(bool);
		}
	}
}
