using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x0200017B RID: 379
	[Token(Token = "0x200017B")]
	[AddComponentMenu("Sons/Construction/FencePostStructure")]
	public class FencePostStructure : Structure, IDetachedPlacementStructure, IBreakableStructure, IStructure, IMonoBehaviour, ISuperStructureNode, IReinforceableStructure, ITargetablePlacement, IEffigySupport
	{
		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x06000B60 RID: 2912 RVA: 0x000073F4 File Offset: 0x000055F4
		[Token(Token = "0x170002D0")]
		public override ushort TypeID
		{
			[Token(Token = "0x6000B60")]
			[Address(RVA = "0xE59CE0", Offset = "0xE582E0", VA = "0x180E59CE0", Slot = "47")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x06000B61 RID: 2913 RVA: 0x0000740C File Offset: 0x0000560C
		[Token(Token = "0x170002D1")]
		public override bool StackedElements
		{
			[Token(Token = "0x6000B61")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "48")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x06000B62 RID: 2914 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170002D2")]
		public override Directions[] Supporting
		{
			[Token(Token = "0x6000B62")]
			[Address(RVA = "0x2EAA6A0", Offset = "0x2EA8CA0", VA = "0x182EAA6A0", Slot = "52")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x06000B63 RID: 2915 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170002D3")]
		public override Directions[] SupportedBy
		{
			[Token(Token = "0x6000B63")]
			[Address(RVA = "0x2EAA6F0", Offset = "0x2EA8CF0", VA = "0x182EAA6F0", Slot = "53")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x06000B64 RID: 2916 RVA: 0x00007424 File Offset: 0x00005624
		[Token(Token = "0x170002D4")]
		public bool IsOrientationFixed
		{
			[Token(Token = "0x6000B64")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "106")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x06000B65 RID: 2917 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170002D5")]
		public static Counter Counter
		{
			[Token(Token = "0x6000B65")]
			[Address(RVA = "0x2EAA740", Offset = "0x2EA8D40", VA = "0x182EAA740")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x06000B66 RID: 2918 RVA: 0x0000743C File Offset: 0x0000563C
		[Token(Token = "0x6000B66")]
		[Address(RVA = "0x67D850", Offset = "0x67BE50", VA = "0x18067D850", Slot = "67")]
		public override RepositionResults TryRepositionOnSupports(ElementRepositionAnimationTool repositionAnim)
		{
			return RepositionResults.Failed;
		}

		// Token: 0x06000B67 RID: 2919 RVA: 0x00007454 File Offset: 0x00005654
		[Token(Token = "0x6000B67")]
		[Address(RVA = "0x2EAA790", Offset = "0x2EA8D90", VA = "0x182EAA790", Slot = "84")]
		public override float CalcTopHeight()
		{
			return 0f;
		}

		// Token: 0x06000B68 RID: 2920 RVA: 0x0000746C File Offset: 0x0000566C
		[Token(Token = "0x6000B68")]
		[Address(RVA = "0x2EAA9B0", Offset = "0x2EA8FB0", VA = "0x182EAA9B0", Slot = "74")]
		public override Vector3 CalcElementPosition(StructureElement elementPrefab, int elementIndex)
		{
			return default(Vector3);
		}

		// Token: 0x06000B69 RID: 2921 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000B69")]
		[Address(RVA = "0x2EAAB70", Offset = "0x2EA9170", VA = "0x182EAAB70", Slot = "78")]
		public override StructureElement AddElement(StructureElement elementPrefab)
		{
			return null;
		}

		// Token: 0x06000B6A RID: 2922 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000B6A")]
		[Address(RVA = "0x2EAB0B0", Offset = "0x2EA96B0", VA = "0x182EAB0B0", Slot = "79")]
		public override StructureElement AddElement(StructureElement elementPrefab, Vector3 position)
		{
			return null;
		}

		// Token: 0x06000B6B RID: 2923 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B6B")]
		[Address(RVA = "0x2EAB310", Offset = "0x2EA9910", VA = "0x182EAB310", Slot = "114")]
		public void CalcClosestElementPlacement(StructureElement elementPrefab, Vector3 worldPos, int skip, out Vector3 position, out Quaternion rotation, out float lengthScale)
		{
		}

		// Token: 0x06000B6C RID: 2924 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000B6C")]
		[Address(RVA = "0x2EAB350", Offset = "0x2EA9950", VA = "0x182EAB350", Slot = "112")]
		private PresetElementsTemplate GetReinforcementTemplate()
		{
			return null;
		}

		// Token: 0x06000B6D RID: 2925 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B6D")]
		[Address(RVA = "0x2EAB380", Offset = "0x2EA9980", VA = "0x182EAB380")]
		public void AddSupportedFence(FenceStructure fence)
		{
		}

		// Token: 0x06000B6E RID: 2926 RVA: 0x00007484 File Offset: 0x00005684
		[Token(Token = "0x6000B6E")]
		[Address(RVA = "0x2EAB470", Offset = "0x2EA9A70", VA = "0x182EAB470", Slot = "81")]
		public override bool TryGetRemoveableElement(Vector3 nearPos, out StructureElement element)
		{
			return default(bool);
		}

		// Token: 0x06000B6F RID: 2927 RVA: 0x0000749C File Offset: 0x0000569C
		[Token(Token = "0x6000B6F")]
		[Address(RVA = "0x2EAB540", Offset = "0x2EA9B40", VA = "0x182EAB540")]
		public bool IsSupportingFenceWith(FencePostStructure fp2)
		{
			return default(bool);
		}

		// Token: 0x06000B70 RID: 2928 RVA: 0x000074B4 File Offset: 0x000056B4
		[Token(Token = "0x6000B70")]
		[Address(RVA = "0x2EAB650", Offset = "0x2EA9C50", VA = "0x182EAB650")]
		public bool CanHostNewFence()
		{
			return default(bool);
		}

		// Token: 0x06000B71 RID: 2929 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B71")]
		[Address(RVA = "0x2EAB720", Offset = "0x2EA9D20", VA = "0x182EAB720")]
		public void TrySnapPlaceAxisToFences(ref Vector3 placeAxis)
		{
		}

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x06000B72 RID: 2930 RVA: 0x000074CC File Offset: 0x000056CC
		[Token(Token = "0x170002D6")]
		public bool IsReinforced
		{
			[Token(Token = "0x6000B72")]
			[Address(RVA = "0x2EAB9C0", Offset = "0x2EA9FC0", VA = "0x182EAB9C0", Slot = "109")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000B73 RID: 2931 RVA: 0x000074E4 File Offset: 0x000056E4
		[Token(Token = "0x6000B73")]
		[Address(RVA = "0x2EAB9D0", Offset = "0x2EA9FD0", VA = "0x182EAB9D0")]
		private bool CheckIsReinforced()
		{
			return default(bool);
		}

		// Token: 0x06000B74 RID: 2932 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B74")]
		[Address(RVA = "0x2EABC40", Offset = "0x2EAA240", VA = "0x182EABC40", Slot = "63")]
		public override void OnElementsChanged()
		{
		}

		// Token: 0x06000B75 RID: 2933 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B75")]
		[Address(RVA = "0x2EABC40", Offset = "0x2EAA240", VA = "0x182EABC40", Slot = "65")]
		public override void OnLinkedStructuresChanged()
		{
		}

		// Token: 0x06000B76 RID: 2934 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B76")]
		[Address(RVA = "0x2EABC80", Offset = "0x2EAA280", VA = "0x182EABC80")]
		private void RefreshBreakableForSupportedStructures()
		{
		}

		// Token: 0x06000B77 RID: 2935 RVA: 0x000074FC File Offset: 0x000056FC
		[Token(Token = "0x6000B77")]
		[Address(RVA = "0x2EABDC0", Offset = "0x2EAA3C0", VA = "0x182EABDC0", Slot = "110")]
		private bool IsBreakable()
		{
			return default(bool);
		}

		// Token: 0x06000B78 RID: 2936 RVA: 0x00007514 File Offset: 0x00005714
		[Token(Token = "0x6000B78")]
		[Address(RVA = "0x2EABDE0", Offset = "0x2EAA3E0", VA = "0x182EABDE0", Slot = "111")]
		private float CalcBreakForce()
		{
			return 0f;
		}

		// Token: 0x06000B79 RID: 2937 RVA: 0x0000752C File Offset: 0x0000572C
		[Token(Token = "0x6000B79")]
		[Address(RVA = "0x2EABE20", Offset = "0x2EAA420", VA = "0x182EABE20")]
		public bool TryGetDecorationElement(out StructureElement element)
		{
			return default(bool);
		}

		// Token: 0x06000B7A RID: 2938 RVA: 0x00007544 File Offset: 0x00005744
		[Token(Token = "0x6000B7A")]
		[Address(RVA = "0x2EABFD0", Offset = "0x2EAA5D0", VA = "0x182EABFD0", Slot = "115")]
		private bool CanHostNewEffigy()
		{
			return default(bool);
		}

		// Token: 0x06000B7B RID: 2939 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B7B")]
		[Address(RVA = "0x2EAC030", Offset = "0x2EAA630", VA = "0x182EAC030", Slot = "116")]
		private void SetEffigy(EffigyStructure effigy)
		{
		}

		// Token: 0x06000B7C RID: 2940 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B7C")]
		[Address(RVA = "0x2EAC050", Offset = "0x2EAA650", VA = "0x182EAC050")]
		public FencePostStructure()
		{
		}

		// Token: 0x06000B7E RID: 2942 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000B7E")]
		[Address(RVA = "0x6602D0", Offset = "0x65E8D0", VA = "0x1806602D0", Slot = "107")]
		private Transform get_transform()
		{
			return null;
		}

		// Token: 0x06000B7F RID: 2943 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000B7F")]
		[Address(RVA = "0x2E57220", Offset = "0x2E55820", VA = "0x182E57220", Slot = "7")]
		private string get_name()
		{
			return null;
		}

		// Token: 0x06000B80 RID: 2944 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000B80")]
		[Address(RVA = "0x2DC3B50", Offset = "0x2DC2150", VA = "0x182DC3B50", Slot = "42")]
		private GameObject get_gameObject()
		{
			return null;
		}

		// Token: 0x06000B81 RID: 2945 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000B81")]
		[Address(RVA = "0x6602D0", Offset = "0x65E8D0", VA = "0x1806602D0", Slot = "43")]
		private Transform get_transform()
		{
			return null;
		}

		// Token: 0x06000B82 RID: 2946 RVA: 0x0000755C File Offset: 0x0000575C
		[Token(Token = "0x6000B82")]
		private bool TryGetComponent<T>(out T comp)
		{
			return default(bool);
		}

		// Token: 0x040006F6 RID: 1782
		[Token(Token = "0x40006F6")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Directions[] SupportingDirs;

		// Token: 0x040006F7 RID: 1783
		[Token(Token = "0x40006F7")]
		[FieldOffset(Offset = "0x10")]
		private static readonly Directions[] SupportedByDirs;

		// Token: 0x0200017C RID: 380
		[Token(Token = "0x200017C")]
		public class Utils
		{
			// Token: 0x06000B83 RID: 2947 RVA: 0x00007574 File Offset: 0x00005774
			[Token(Token = "0x6000B83")]
			[Address(RVA = "0x2EAC2D0", Offset = "0x2EAA8D0", VA = "0x182EAC2D0")]
			public static Vector3 CalcMainElementPosition(StructureElement elementPrefab, Vector3 fencePostPos)
			{
				return default(Vector3);
			}

			// Token: 0x06000B84 RID: 2948 RVA: 0x0000758C File Offset: 0x0000578C
			[Token(Token = "0x6000B84")]
			[Address(RVA = "0x2EAC310", Offset = "0x2EAA910", VA = "0x182EAC310")]
			public static Vector3 CalcDecorationElementPosition(FencePostStructure fencePost)
			{
				return default(Vector3);
			}

			// Token: 0x06000B85 RID: 2949 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000B85")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public Utils()
			{
			}
		}
	}
}
