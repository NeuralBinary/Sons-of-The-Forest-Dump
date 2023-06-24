using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Sons.Electricity;
using UnityEngine;

namespace Construction
{
	// Token: 0x02000179 RID: 377
	[Token(Token = "0x2000179")]
	[AddComponentMenu("Sons/Construction/SolarPanelStructure")]
	public class SolarPanelStructure : Structure
	{
		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x06000B42 RID: 2882 RVA: 0x00007304 File Offset: 0x00005504
		[Token(Token = "0x170002C8")]
		public override ushort TypeID
		{
			[Token(Token = "0x6000B42")]
			[Address(RVA = "0x2EA8790", Offset = "0x2EA6D90", VA = "0x182EA8790", Slot = "47")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x06000B43 RID: 2883 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170002C9")]
		public override Directions[] SupportedBy
		{
			[Token(Token = "0x6000B43")]
			[Address(RVA = "0x2EA87A0", Offset = "0x2EA6DA0", VA = "0x182EA87A0", Slot = "53")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x06000B44 RID: 2884 RVA: 0x0000731C File Offset: 0x0000551C
		[Token(Token = "0x170002CA")]
		public override int LinkedStructureCount
		{
			[Token(Token = "0x6000B44")]
			[Address(RVA = "0x67D850", Offset = "0x67BE50", VA = "0x18067D850", Slot = "50")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x06000B45 RID: 2885 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x06000B46 RID: 2886 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170002CB")]
		public Wire Wire
		{
			[Token(Token = "0x6000B45")]
			[Address(RVA = "0x5AC7C0", Offset = "0x5AADC0", VA = "0x1805AC7C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B46")]
			[Address(RVA = "0x5B2560", Offset = "0x5B0B60", VA = "0x1805B2560")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x06000B47 RID: 2887 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x06000B48 RID: 2888 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170002CC")]
		public PowerSource PowerSource
		{
			[Token(Token = "0x6000B47")]
			[Address(RVA = "0x6710C0", Offset = "0x66F6C0", VA = "0x1806710C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B48")]
			[Address(RVA = "0x6710D0", Offset = "0x66F6D0", VA = "0x1806710D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x06000B49 RID: 2889 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170002CD")]
		public static Counter Counter
		{
			[Token(Token = "0x6000B49")]
			[Address(RVA = "0x2EA87F0", Offset = "0x2EA6DF0", VA = "0x182EA87F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x06000B4A RID: 2890 RVA: 0x00007334 File Offset: 0x00005534
		[Token(Token = "0x6000B4A")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "69")]
		public override bool IsCompleted()
		{
			return default(bool);
		}

		// Token: 0x06000B4B RID: 2891 RVA: 0x0000734C File Offset: 0x0000554C
		[Token(Token = "0x6000B4B")]
		[Address(RVA = "0x2E8F6E0", Offset = "0x2E8DCE0", VA = "0x182E8F6E0", Slot = "73")]
		public override Vector3 CalcNextElementPosition(StructureElement elementPrefab)
		{
			return default(Vector3);
		}

		// Token: 0x06000B4C RID: 2892 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B4C")]
		[Address(RVA = "0x2EA8840", Offset = "0x2EA6E40", VA = "0x182EA8840", Slot = "59")]
		public override void OnPostLoad()
		{
		}

		// Token: 0x06000B4D RID: 2893 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B4D")]
		[Address(RVA = "0x2EA8840", Offset = "0x2EA6E40", VA = "0x182EA8840", Slot = "63")]
		public override void OnElementsChanged()
		{
		}

		// Token: 0x06000B4E RID: 2894 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B4E")]
		[Address(RVA = "0x2EA8840", Offset = "0x2EA6E40", VA = "0x182EA8840", Slot = "64")]
		public override void OnElementsChangedClient()
		{
		}

		// Token: 0x06000B4F RID: 2895 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B4F")]
		[Address(RVA = "0x2EA58C0", Offset = "0x2EA3EC0", VA = "0x182EA58C0", Slot = "61")]
		public override void OnDestroyingStructure()
		{
		}

		// Token: 0x06000B50 RID: 2896 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B50")]
		[Address(RVA = "0x2EA58C0", Offset = "0x2EA3EC0", VA = "0x182EA58C0", Slot = "62")]
		public override void OnDestroyingStructureClient()
		{
		}

		// Token: 0x06000B51 RID: 2897 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B51")]
		[Address(RVA = "0x2EA8850", Offset = "0x2EA6E50", VA = "0x182EA8850")]
		public void SetupElectricitySystem()
		{
		}

		// Token: 0x06000B52 RID: 2898 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B52")]
		[Address(RVA = "0x2EA8A80", Offset = "0x2EA7080", VA = "0x182EA8A80")]
		private void ConnectWireWithSiblings()
		{
		}

		// Token: 0x06000B53 RID: 2899 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B53")]
		[Address(RVA = "0x2EA8D50", Offset = "0x2EA7350", VA = "0x182EA8D50")]
		public SolarPanelStructure()
		{
		}

		// Token: 0x06000B55 RID: 2901 RVA: 0x00007364 File Offset: 0x00005564
		[Token(Token = "0x6000B55")]
		[Address(RVA = "0x2EA8F00", Offset = "0x2EA7500", VA = "0x182EA8F00")]
		[CompilerGenerated]
		private bool <SetupElectricitySystem>g__IsPowerSourceOnRoof|25_0()
		{
			return default(bool);
		}

		// Token: 0x040006F2 RID: 1778
		[Token(Token = "0x40006F2")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Directions[] SupportedByDirs;
	}
}
