using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Sons.Ai.Vail.StimuliTypes;
using UnityEngine;

namespace Construction
{
	// Token: 0x02000168 RID: 360
	[Token(Token = "0x2000168")]
	[AddComponentMenu("Sons/Construction/EffigyStructure")]
	public class EffigyStructure : Structure
	{
		// Token: 0x170002AF RID: 687
		// (get) Token: 0x06000AB4 RID: 2740 RVA: 0x00006F5C File Offset: 0x0000515C
		[Token(Token = "0x170002AF")]
		public override ushort TypeID
		{
			[Token(Token = "0x6000AB4")]
			[Address(RVA = "0xE599D0", Offset = "0xE57FD0", VA = "0x180E599D0", Slot = "47")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x06000AB5 RID: 2741 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170002B0")]
		public override Directions[] Supporting
		{
			[Token(Token = "0x6000AB5")]
			[Address(RVA = "0x2EA0090", Offset = "0x2E9E690", VA = "0x182EA0090", Slot = "52")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x06000AB6 RID: 2742 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170002B1")]
		public override Directions[] SupportedBy
		{
			[Token(Token = "0x6000AB6")]
			[Address(RVA = "0x2EA00E0", Offset = "0x2E9E6E0", VA = "0x182EA00E0", Slot = "53")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x06000AB7 RID: 2743 RVA: 0x00006F74 File Offset: 0x00005174
		[Token(Token = "0x170002B2")]
		public override int LinkedStructureCount
		{
			[Token(Token = "0x6000AB7")]
			[Address(RVA = "0x67D850", Offset = "0x67BE50", VA = "0x18067D850", Slot = "50")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x06000AB8 RID: 2744 RVA: 0x00006F8C File Offset: 0x0000518C
		[Token(Token = "0x170002B3")]
		public static int MaxElements
		{
			[Token(Token = "0x6000AB8")]
			[Address(RVA = "0xE59BC0", Offset = "0xE581C0", VA = "0x180E59BC0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x06000AB9 RID: 2745 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170002B4")]
		public static Counter Counter
		{
			[Token(Token = "0x6000AB9")]
			[Address(RVA = "0x2EA0130", Offset = "0x2E9E730", VA = "0x182EA0130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x06000ABA RID: 2746 RVA: 0x00006FA4 File Offset: 0x000051A4
		[Token(Token = "0x6000ABA")]
		[Address(RVA = "0x67D850", Offset = "0x67BE50", VA = "0x18067D850", Slot = "67")]
		public override RepositionResults TryRepositionOnSupports(ElementRepositionAnimationTool repositionAnim)
		{
			return RepositionResults.Failed;
		}

		// Token: 0x06000ABB RID: 2747 RVA: 0x00006FBC File Offset: 0x000051BC
		[Token(Token = "0x6000ABB")]
		[Address(RVA = "0x2EA0180", Offset = "0x2E9E780", VA = "0x182EA0180", Slot = "71")]
		public override int CalcMaxElements(StructureElement prefab)
		{
			return 0;
		}

		// Token: 0x06000ABC RID: 2748 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000ABC")]
		[Address(RVA = "0x2EA01C0", Offset = "0x2E9E7C0", VA = "0x182EA01C0", Slot = "82")]
		public override StructureElement GetElementToRemove(Vector3 nearPos)
		{
			return null;
		}

		// Token: 0x06000ABD RID: 2749 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000ABD")]
		[Address(RVA = "0x2EA0230", Offset = "0x2E9E830", VA = "0x182EA0230")]
		public static StructureElement GetClosestElement(Structure structure, Vector3 nearPos)
		{
			return null;
		}

		// Token: 0x06000ABE RID: 2750 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000ABE")]
		[Address(RVA = "0x2EA07F0", Offset = "0x2E9EDF0", VA = "0x182EA07F0", Slot = "63")]
		public override void OnElementsChanged()
		{
		}

		// Token: 0x06000ABF RID: 2751 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000ABF")]
		[Address(RVA = "0x2EA07F0", Offset = "0x2E9EDF0", VA = "0x182EA07F0", Slot = "59")]
		public override void OnPostLoad()
		{
		}

		// Token: 0x06000AC0 RID: 2752 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AC0")]
		[Address(RVA = "0x2EA0800", Offset = "0x2E9EE00", VA = "0x182EA0800")]
		private void RefreshStimuli()
		{
		}

		// Token: 0x06000AC1 RID: 2753 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AC1")]
		[Address(RVA = "0x2EA0DA0", Offset = "0x2E9F3A0", VA = "0x182EA0DA0")]
		public EffigyStructure()
		{
		}

		// Token: 0x040006CC RID: 1740
		[Token(Token = "0x40006CC")]
		[FieldOffset(Offset = "0x40")]
		private PlayerEffigyStimuli _effigyStimuli;

		// Token: 0x040006CE RID: 1742
		[Token(Token = "0x40006CE")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Directions[] SupportingDirs;

		// Token: 0x040006CF RID: 1743
		[Token(Token = "0x40006CF")]
		[FieldOffset(Offset = "0x10")]
		private static readonly Directions[] SupportedByDirs;
	}
}
