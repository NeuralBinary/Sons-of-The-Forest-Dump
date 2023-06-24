using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x02000235 RID: 565
	[Token(Token = "0x2000235")]
	[AddComponentMenu("Sons/Construction/PresetTarpStructure")]
	public class PresetTarpStructure : Structure, IBreakableStructure, IStructure, IMonoBehaviour, ISuperStructureNode
	{
		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x06001124 RID: 4388 RVA: 0x0000A7E4 File Offset: 0x000089E4
		[Token(Token = "0x170003EE")]
		public override ushort TypeID
		{
			[Token(Token = "0x6001124")]
			[Address(RVA = "0xE599A0", Offset = "0xE57FA0", VA = "0x180E599A0", Slot = "47")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x06001125 RID: 4389 RVA: 0x0000A7FC File Offset: 0x000089FC
		[Token(Token = "0x170003EF")]
		public override int LinkedStructureCount
		{
			[Token(Token = "0x6001125")]
			[Address(RVA = "0xE51970", Offset = "0xE4FF70", VA = "0x180E51970", Slot = "50")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x06001126 RID: 4390 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170003F0")]
		public override Directions[] Supporting
		{
			[Token(Token = "0x6001126")]
			[Address(RVA = "0x2F1FA90", Offset = "0x2F1E090", VA = "0x182F1FA90", Slot = "52")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x06001127 RID: 4391 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170003F1")]
		public override Directions[] SupportedBy
		{
			[Token(Token = "0x6001127")]
			[Address(RVA = "0x2F1FAE0", Offset = "0x2F1E0E0", VA = "0x182F1FAE0", Slot = "53")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003F2 RID: 1010
		// (get) Token: 0x06001128 RID: 4392 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170003F2")]
		public static Counter Counter
		{
			[Token(Token = "0x6001128")]
			[Address(RVA = "0x2F1FB30", Offset = "0x2F1E130", VA = "0x182F1FB30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x06001129 RID: 4393 RVA: 0x0000A814 File Offset: 0x00008A14
		// (set) Token: 0x0600112A RID: 4394 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170003F3")]
		public static int AddingElementQuarter
		{
			[Token(Token = "0x6001129")]
			[Address(RVA = "0x2F1FB80", Offset = "0x2F1E180", VA = "0x182F1FB80")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x600112A")]
			[Address(RVA = "0x2F1FBD0", Offset = "0x2F1E1D0", VA = "0x182F1FBD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600112B RID: 4395 RVA: 0x0000A82C File Offset: 0x00008A2C
		[Token(Token = "0x600112B")]
		[Address(RVA = "0x67D850", Offset = "0x67BE50", VA = "0x18067D850", Slot = "67")]
		public override RepositionResults TryRepositionOnSupports(ElementRepositionAnimationTool repositionAnim)
		{
			return RepositionResults.Failed;
		}

		// Token: 0x0600112C RID: 4396 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600112C")]
		[Address(RVA = "0x2F1FC30", Offset = "0x2F1E230", VA = "0x182F1FC30", Slot = "78")]
		public override StructureElement AddElement(StructureElement elementPrefab)
		{
			return null;
		}

		// Token: 0x170003F4 RID: 1012
		// (get) Token: 0x0600112D RID: 4397 RVA: 0x0000A844 File Offset: 0x00008A44
		[Token(Token = "0x170003F4")]
		private bool IsReinforced
		{
			[Token(Token = "0x600112D")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "105")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600112E RID: 4398 RVA: 0x0000A85C File Offset: 0x00008A5C
		[Token(Token = "0x600112E")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "106")]
		private bool IsBreakable()
		{
			return default(bool);
		}

		// Token: 0x0600112F RID: 4399 RVA: 0x0000A874 File Offset: 0x00008A74
		[Token(Token = "0x600112F")]
		[Address(RVA = "0x2F1FD80", Offset = "0x2F1E380", VA = "0x182F1FD80", Slot = "107")]
		private float CalcBreakForce()
		{
			return 0f;
		}

		// Token: 0x06001130 RID: 4400 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001130")]
		[Address(RVA = "0x2F1FE50", Offset = "0x2F1E450", VA = "0x182F1FE50")]
		public PresetTarpStructure()
		{
		}

		// Token: 0x06001132 RID: 4402 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6001132")]
		[Address(RVA = "0x2E57220", Offset = "0x2E55820", VA = "0x182E57220", Slot = "7")]
		private string get_name()
		{
			return null;
		}

		// Token: 0x06001133 RID: 4403 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6001133")]
		[Address(RVA = "0x2DC3B50", Offset = "0x2DC2150", VA = "0x182DC3B50", Slot = "42")]
		private GameObject get_gameObject()
		{
			return null;
		}

		// Token: 0x06001134 RID: 4404 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6001134")]
		[Address(RVA = "0x6602D0", Offset = "0x65E8D0", VA = "0x1806602D0", Slot = "43")]
		private Transform get_transform()
		{
			return null;
		}

		// Token: 0x06001135 RID: 4405 RVA: 0x0000A88C File Offset: 0x00008A8C
		[Token(Token = "0x6001135")]
		private bool TryGetComponent<T>(out T comp)
		{
			return default(bool);
		}

		// Token: 0x040008CC RID: 2252
		[Token(Token = "0x40008CC")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Directions[] SupportingDirs;

		// Token: 0x040008CD RID: 2253
		[Token(Token = "0x40008CD")]
		[FieldOffset(Offset = "0x10")]
		private static readonly Directions[] SupportedByDirs;

		// Token: 0x02000236 RID: 566
		[Token(Token = "0x2000236")]
		public static class Utils
		{
			// Token: 0x06001136 RID: 4406 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6001136")]
			[Address(RVA = "0x2F200A0", Offset = "0x2F1E6A0", VA = "0x182F200A0")]
			internal static void CalcTarpPosFromPilar(PilarStructure targetPilar, out Vector3 snapPos)
			{
			}
		}
	}
}
