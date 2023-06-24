using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x0200017D RID: 381
	[Token(Token = "0x200017D")]
	[AddComponentMenu("Sons/Construction/FenceStructure")]
	public class FenceStructure : Structure, IDetachedPlacementStructure, IBreakableStructure, IStructure, IMonoBehaviour, ISuperStructureNode
	{
		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x06000B86 RID: 2950 RVA: 0x000075A4 File Offset: 0x000057A4
		[Token(Token = "0x170002D7")]
		public override ushort TypeID
		{
			[Token(Token = "0x6000B86")]
			[Address(RVA = "0xE599E0", Offset = "0xE57FE0", VA = "0x180E599E0", Slot = "47")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x06000B87 RID: 2951 RVA: 0x000075BC File Offset: 0x000057BC
		[Token(Token = "0x170002D8")]
		public bool IsOrientationFixed
		{
			[Token(Token = "0x6000B87")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "106")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x06000B88 RID: 2952 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170002D9")]
		public override Directions[] Supporting
		{
			[Token(Token = "0x6000B88")]
			[Address(RVA = "0x2EAC3F0", Offset = "0x2EAA9F0", VA = "0x182EAC3F0", Slot = "52")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x06000B89 RID: 2953 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170002DA")]
		public override Directions[] SupportedBy
		{
			[Token(Token = "0x6000B89")]
			[Address(RVA = "0x2EAC440", Offset = "0x2EAAA40", VA = "0x182EAC440", Slot = "53")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x06000B8A RID: 2954 RVA: 0x000075D4 File Offset: 0x000057D4
		[Token(Token = "0x170002DB")]
		public bool IsReinforced
		{
			[Token(Token = "0x6000B8A")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "109")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x06000B8B RID: 2955 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170002DC")]
		public static Counter Counter
		{
			[Token(Token = "0x6000B8B")]
			[Address(RVA = "0x2EAC490", Offset = "0x2EAAA90", VA = "0x182EAC490")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x06000B8C RID: 2956 RVA: 0x000075EC File Offset: 0x000057EC
		[Token(Token = "0x6000B8C")]
		[Address(RVA = "0x67D850", Offset = "0x67BE50", VA = "0x18067D850", Slot = "67")]
		public override RepositionResults TryRepositionOnSupports(ElementRepositionAnimationTool repositionAnim)
		{
			return RepositionResults.Failed;
		}

		// Token: 0x06000B8D RID: 2957 RVA: 0x00007604 File Offset: 0x00005804
		[Token(Token = "0x6000B8D")]
		[Address(RVA = "0x2EAC4E0", Offset = "0x2EAAAE0", VA = "0x182EAC4E0")]
		public bool HasStructureAtDir(FenceDirections dir)
		{
			return default(bool);
		}

		// Token: 0x06000B8E RID: 2958 RVA: 0x0000761C File Offset: 0x0000581C
		[Token(Token = "0x6000B8E")]
		[Address(RVA = "0x2EAC540", Offset = "0x2EAAB40", VA = "0x182EAC540", Slot = "71")]
		public override int CalcMaxElements(StructureElement prefab)
		{
			return 0;
		}

		// Token: 0x06000B8F RID: 2959 RVA: 0x00007634 File Offset: 0x00005834
		[Token(Token = "0x6000B8F")]
		[Address(RVA = "0x2EAC580", Offset = "0x2EAAB80", VA = "0x182EAC580", Slot = "74")]
		public override Vector3 CalcElementPosition(StructureElement elementPrefab, int elementIndex)
		{
			return default(Vector3);
		}

		// Token: 0x06000B90 RID: 2960 RVA: 0x0000764C File Offset: 0x0000584C
		[Token(Token = "0x6000B90")]
		[Address(RVA = "0x2EAC750", Offset = "0x2EAAD50", VA = "0x182EAC750", Slot = "77")]
		public override Quaternion CalcElementRotation(StructureElement elementPrefab, int elementIndex)
		{
			return default(Quaternion);
		}

		// Token: 0x06000B91 RID: 2961 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000B91")]
		[Address(RVA = "0x2EACAE0", Offset = "0x2EAB0E0", VA = "0x182EACAE0", Slot = "78")]
		public override StructureElement AddElement(StructureElement elementPrefab)
		{
			return null;
		}

		// Token: 0x06000B92 RID: 2962 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B92")]
		[Address(RVA = "0x2EAD2D0", Offset = "0x2EAB8D0", VA = "0x182EAD2D0", Slot = "63")]
		public override void OnElementsChanged()
		{
		}

		// Token: 0x06000B93 RID: 2963 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B93")]
		[Address(RVA = "0x2EAD2D0", Offset = "0x2EAB8D0", VA = "0x182EAD2D0", Slot = "65")]
		public override void OnLinkedStructuresChanged()
		{
		}

		// Token: 0x06000B94 RID: 2964 RVA: 0x00007664 File Offset: 0x00005864
		[Token(Token = "0x6000B94")]
		[Address(RVA = "0x2EAD2F0", Offset = "0x2EAB8F0", VA = "0x182EAD2F0", Slot = "110")]
		private bool IsBreakable()
		{
			return default(bool);
		}

		// Token: 0x06000B95 RID: 2965 RVA: 0x0000767C File Offset: 0x0000587C
		[Token(Token = "0x6000B95")]
		[Address(RVA = "0x2EAD470", Offset = "0x2EABA70", VA = "0x182EAD470", Slot = "111")]
		private float CalcBreakForce()
		{
			return 0f;
		}

		// Token: 0x06000B96 RID: 2966 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B96")]
		[Address(RVA = "0x2EAD6A0", Offset = "0x2EABCA0", VA = "0x182EAD6A0")]
		public void SetChainingWithStructureAtDir(Directions dir, FenceStructure support1Fence)
		{
		}

		// Token: 0x06000B97 RID: 2967 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B97")]
		[Address(RVA = "0x2EAD740", Offset = "0x2EABD40", VA = "0x182EAD740")]
		public FenceStructure()
		{
		}

		// Token: 0x06000B99 RID: 2969 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000B99")]
		[Address(RVA = "0x6602D0", Offset = "0x65E8D0", VA = "0x1806602D0", Slot = "107")]
		private Transform get_transform()
		{
			return null;
		}

		// Token: 0x06000B9A RID: 2970 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000B9A")]
		[Address(RVA = "0x2E57220", Offset = "0x2E55820", VA = "0x182E57220", Slot = "7")]
		private string get_name()
		{
			return null;
		}

		// Token: 0x06000B9B RID: 2971 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000B9B")]
		[Address(RVA = "0x2DC3B50", Offset = "0x2DC2150", VA = "0x182DC3B50", Slot = "42")]
		private GameObject get_gameObject()
		{
			return null;
		}

		// Token: 0x06000B9C RID: 2972 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000B9C")]
		[Address(RVA = "0x6602D0", Offset = "0x65E8D0", VA = "0x1806602D0", Slot = "43")]
		private Transform get_transform()
		{
			return null;
		}

		// Token: 0x06000B9D RID: 2973 RVA: 0x00007694 File Offset: 0x00005894
		[Token(Token = "0x6000B9D")]
		private bool TryGetComponent<T>(out T comp)
		{
			return default(bool);
		}

		// Token: 0x040006F9 RID: 1785
		[Token(Token = "0x40006F9")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Directions[] SupportingDirs;

		// Token: 0x040006FA RID: 1786
		[Token(Token = "0x40006FA")]
		[FieldOffset(Offset = "0x10")]
		private static readonly Directions[] SupportedByDirs;

		// Token: 0x040006FB RID: 1787
		[Token(Token = "0x40006FB")]
		[FieldOffset(Offset = "0x18")]
		private static readonly FenceDirections[] BackDirs;

		// Token: 0x040006FC RID: 1788
		[Token(Token = "0x40006FC")]
		[FieldOffset(Offset = "0x20")]
		private static readonly FenceDirections[] ForwardDirs;

		// Token: 0x040006FD RID: 1789
		[Token(Token = "0x40006FD")]
		[FieldOffset(Offset = "0x40")]
		private IBreakableStructure _breakableStructureImplementation;
	}
}
