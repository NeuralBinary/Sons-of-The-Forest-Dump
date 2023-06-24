using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x0200012E RID: 302
	[Token(Token = "0x200012E")]
	[AddComponentMenu("Sons/Construction/OneSidedApexStructure")]
	public class OneSidedApexStructure : ApexStructure, IBeamSupport, IStructure, IMonoBehaviour, ISuperStructureNode
	{
		// Token: 0x17000262 RID: 610
		// (get) Token: 0x06000855 RID: 2133 RVA: 0x00005564 File Offset: 0x00003764
		[Token(Token = "0x17000262")]
		public override ushort TypeID
		{
			[Token(Token = "0x6000855")]
			[Address(RVA = "0x6BC980", Offset = "0x6BAF80", VA = "0x1806BC980", Slot = "47")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x06000856 RID: 2134 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000263")]
		public override Directions[] Supporting
		{
			[Token(Token = "0x6000856")]
			[Address(RVA = "0x2E57410", Offset = "0x2E55A10", VA = "0x182E57410", Slot = "52")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x06000857 RID: 2135 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000264")]
		public override Directions[] SupportedBy
		{
			[Token(Token = "0x6000857")]
			[Address(RVA = "0x2E57460", Offset = "0x2E55A60", VA = "0x182E57460", Slot = "53")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x06000858 RID: 2136 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000265")]
		public new static Counter Counter
		{
			[Token(Token = "0x6000858")]
			[Address(RVA = "0x2E574B0", Offset = "0x2E55AB0", VA = "0x182E574B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x06000859 RID: 2137 RVA: 0x0000557C File Offset: 0x0000377C
		[Token(Token = "0x6000859")]
		[Address(RVA = "0x2E57500", Offset = "0x2E55B00", VA = "0x182E57500", Slot = "67")]
		public override RepositionResults TryRepositionOnSupports(ElementRepositionAnimationTool repositionAnim)
		{
			return RepositionResults.Failed;
		}

		// Token: 0x0600085A RID: 2138 RVA: 0x00005594 File Offset: 0x00003794
		[Token(Token = "0x600085A")]
		[Address(RVA = "0x2E57560", Offset = "0x2E55B60", VA = "0x182E57560", Slot = "73")]
		public override Vector3 CalcNextElementPosition(StructureElement elementPrefab)
		{
			return default(Vector3);
		}

		// Token: 0x0600085B RID: 2139 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600085B")]
		[Address(RVA = "0x2E57790", Offset = "0x2E55D90", VA = "0x182E57790", Slot = "78")]
		public override StructureElement AddElement(StructureElement elementPrefab)
		{
			return null;
		}

		// Token: 0x0600085C RID: 2140 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600085C")]
		[Address(RVA = "0x2E57970", Offset = "0x2E55F70", VA = "0x182E57970", Slot = "86")]
		public override void ApplyRepair(float healthAlpha)
		{
		}

		// Token: 0x0600085D RID: 2141 RVA: 0x000055AC File Offset: 0x000037AC
		[Token(Token = "0x600085D")]
		[Address(RVA = "0x2E57F00", Offset = "0x2E56500", VA = "0x182E57F00")]
		public float CalcElementLength(float elementHeight)
		{
			return 0f;
		}

		// Token: 0x0600085E RID: 2142 RVA: 0x000055C4 File Offset: 0x000037C4
		[Token(Token = "0x600085E")]
		[Address(RVA = "0x2E58120", Offset = "0x2E56720", VA = "0x182E58120", Slot = "81")]
		public override bool TryGetRemoveableElement(Vector3 nearPos, out StructureElement element)
		{
			return default(bool);
		}

		// Token: 0x0600085F RID: 2143 RVA: 0x000055DC File Offset: 0x000037DC
		[Token(Token = "0x600085F")]
		[Address(RVA = "0x2E58180", Offset = "0x2E56780", VA = "0x182E58180", Slot = "83")]
		public override bool TryRemoveElement(Vector3 nearPos, out ElementProfile elementProfile)
		{
			return default(bool);
		}

		// Token: 0x06000860 RID: 2144 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000860")]
		[Address(RVA = "0x2E58440", Offset = "0x2E56A40", VA = "0x182E58440", Slot = "109")]
		private Directions[] GetAllBeamSnapPointsDirs()
		{
			return null;
		}

		// Token: 0x06000861 RID: 2145 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000861")]
		[Address(RVA = "0x2E58490", Offset = "0x2E56A90", VA = "0x182E58490")]
		public OneSidedApexStructure()
		{
		}

		// Token: 0x06000863 RID: 2147 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000863")]
		[Address(RVA = "0x2E57220", Offset = "0x2E55820", VA = "0x182E57220", Slot = "7")]
		private string get_name()
		{
			return null;
		}

		// Token: 0x06000864 RID: 2148 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000864")]
		[Address(RVA = "0x2DC3B50", Offset = "0x2DC2150", VA = "0x182DC3B50", Slot = "42")]
		private GameObject get_gameObject()
		{
			return null;
		}

		// Token: 0x06000865 RID: 2149 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000865")]
		[Address(RVA = "0x6602D0", Offset = "0x65E8D0", VA = "0x1806602D0", Slot = "43")]
		private Transform get_transform()
		{
			return null;
		}

		// Token: 0x06000866 RID: 2150 RVA: 0x000055F4 File Offset: 0x000037F4
		[Token(Token = "0x6000866")]
		private bool TryGetComponent<T>(out T comp)
		{
			return default(bool);
		}

		// Token: 0x04000617 RID: 1559
		[Token(Token = "0x4000617")]
		public new const int MaxElements = 5;

		// Token: 0x04000619 RID: 1561
		[Token(Token = "0x4000619")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Directions[] SupportingDirs;

		// Token: 0x0400061A RID: 1562
		[Token(Token = "0x400061A")]
		[FieldOffset(Offset = "0x10")]
		private static readonly Directions[] SupportedByDirs;

		// Token: 0x0400061B RID: 1563
		[Token(Token = "0x400061B")]
		[FieldOffset(Offset = "0x18")]
		private static readonly Directions[] BeamDirs;
	}
}
