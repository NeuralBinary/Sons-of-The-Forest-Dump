using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x0200015B RID: 347
	[Token(Token = "0x200015B")]
	[AddComponentMenu("Sons/Construction/DefensiveWallGateStructure")]
	public class DefensiveWallGateStructure : DefensiveWallStructure
	{
		// Token: 0x1700029E RID: 670
		// (get) Token: 0x06000A46 RID: 2630 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x1700029E")]
		public new static Counter Counter
		{
			[Token(Token = "0x6000A46")]
			[Address(RVA = "0x2E94860", Offset = "0x2E92E60", VA = "0x182E94860")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x06000A47 RID: 2631 RVA: 0x00006B24 File Offset: 0x00004D24
		[Token(Token = "0x1700029F")]
		public override ushort TypeID
		{
			[Token(Token = "0x6000A47")]
			[Address(RVA = "0x2E948B0", Offset = "0x2E92EB0", VA = "0x182E948B0", Slot = "47")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x06000A48 RID: 2632 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170002A0")]
		public override Transform ElementRoot
		{
			[Token(Token = "0x6000A48")]
			[Address(RVA = "0x6710C0", Offset = "0x66F6C0", VA = "0x1806710C0", Slot = "49")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x06000A49 RID: 2633 RVA: 0x00006B3C File Offset: 0x00004D3C
		[Token(Token = "0x170002A1")]
		protected override bool BlockSelfLinking
		{
			[Token(Token = "0x6000A49")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "87")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x06000A4A RID: 2634 RVA: 0x00006B54 File Offset: 0x00004D54
		// (set) Token: 0x06000A4B RID: 2635 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170002A2")]
		public bool IsLeft
		{
			[Token(Token = "0x6000A4A")]
			[Address(RVA = "0x674880", Offset = "0x672E80", VA = "0x180674880")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A4B")]
			[Address(RVA = "0x674890", Offset = "0x672E90", VA = "0x180674890")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000A4C RID: 2636 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A4C")]
		[Address(RVA = "0x2E948C0", Offset = "0x2E92EC0", VA = "0x182E948C0", Slot = "56")]
		protected override void Awake()
		{
		}

		// Token: 0x06000A4D RID: 2637 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000A4D")]
		[Address(RVA = "0x2E94DE0", Offset = "0x2E933E0", VA = "0x182E94DE0", Slot = "78")]
		public override StructureElement AddElement(StructureElement elementPrefab)
		{
			return null;
		}

		// Token: 0x06000A4E RID: 2638 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A4E")]
		[Address(RVA = "0x2E95250", Offset = "0x2E93850", VA = "0x182E95250")]
		private void RefreshIsLeft()
		{
		}

		// Token: 0x06000A4F RID: 2639 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000A4F")]
		[Address(RVA = "0x2E95280", Offset = "0x2E93880", VA = "0x182E95280", Slot = "80")]
		public override StructureElement AddElement(StructureElement elementPrefab, Vector3 position, Quaternion rotation)
		{
			return null;
		}

		// Token: 0x06000A50 RID: 2640 RVA: 0x00006B6C File Offset: 0x00004D6C
		[Token(Token = "0x6000A50")]
		[Address(RVA = "0x2E95420", Offset = "0x2E93A20", VA = "0x182E95420", Slot = "81")]
		public override bool TryGetRemoveableElement(Vector3 nearPos, out StructureElement element)
		{
			return default(bool);
		}

		// Token: 0x06000A51 RID: 2641 RVA: 0x00006B84 File Offset: 0x00004D84
		[Token(Token = "0x6000A51")]
		[Address(RVA = "0x2E95540", Offset = "0x2E93B40", VA = "0x182E95540", Slot = "83")]
		public override bool TryRemoveElement(Vector3 nearPos, out ElementProfile elementProfile)
		{
			return default(bool);
		}

		// Token: 0x06000A52 RID: 2642 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A52")]
		[Address(RVA = "0x2E95720", Offset = "0x2E93D20", VA = "0x182E95720", Slot = "59")]
		public override void OnPostLoad()
		{
		}

		// Token: 0x06000A53 RID: 2643 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A53")]
		[Address(RVA = "0x2E95A80", Offset = "0x2E94080", VA = "0x182E95A80")]
		public void GateToggled(bool isOpen)
		{
		}

		// Token: 0x06000A54 RID: 2644 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A54")]
		[Address(RVA = "0x2E95A90", Offset = "0x2E94090", VA = "0x182E95A90", Slot = "86")]
		public override void ApplyRepair(float healthAlpha)
		{
		}

		// Token: 0x06000A55 RID: 2645 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A55")]
		[Address(RVA = "0x2E95FE0", Offset = "0x2E945E0", VA = "0x182E95FE0")]
		public DefensiveWallGateStructure()
		{
		}

		// Token: 0x06000A57 RID: 2647 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A57")]
		[Address(RVA = "0x2E96130", Offset = "0x2E94730", VA = "0x182E96130")]
		[CompilerGenerated]
		private void <OnPostLoad>g__RestoreOpenedGateElements|20_0()
		{
		}

		// Token: 0x040006B1 RID: 1713
		[Token(Token = "0x40006B1")]
		[FieldOffset(Offset = "0x48")]
		private Transform _elementRoot;

		// Token: 0x0200015C RID: 348
		[Token(Token = "0x200015C")]
		public new static class Utils
		{
			// Token: 0x06000A58 RID: 2648 RVA: 0x00006B9C File Offset: 0x00004D9C
			[Token(Token = "0x6000A58")]
			[Address(RVA = "0x2E96580", Offset = "0x2E94B80", VA = "0x182E96580")]
			public static bool IsDefensiveWallStraight(DefensiveWallStructure dw)
			{
				return default(bool);
			}
		}
	}
}
