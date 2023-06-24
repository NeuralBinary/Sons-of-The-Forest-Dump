using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Sons.Electricity;
using UnityEngine;

namespace Construction
{
	// Token: 0x0200016B RID: 363
	[Token(Token = "0x200016B")]
	[AddComponentMenu("Sons/Construction/ElectricWireStructure")]
	public class ElectricDeviceStructure : Structure, IElectricDeviceStateReceiver
	{
		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x06000ACD RID: 2765 RVA: 0x0000704C File Offset: 0x0000524C
		[Token(Token = "0x170002B6")]
		public override ushort TypeID
		{
			[Token(Token = "0x6000ACD")]
			[Address(RVA = "0x2EA3200", Offset = "0x2EA1800", VA = "0x182EA3200", Slot = "47")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x06000ACE RID: 2766 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170002B7")]
		public override Directions[] SupportedBy
		{
			[Token(Token = "0x6000ACE")]
			[Address(RVA = "0x2EA3210", Offset = "0x2EA1810", VA = "0x182EA3210", Slot = "53")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x06000ACF RID: 2767 RVA: 0x00007064 File Offset: 0x00005264
		[Token(Token = "0x170002B8")]
		public override int LinkedStructureCount
		{
			[Token(Token = "0x6000ACF")]
			[Address(RVA = "0x67D850", Offset = "0x67BE50", VA = "0x18067D850", Slot = "50")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x06000AD0 RID: 2768 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x06000AD1 RID: 2769 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170002B9")]
		public Wire ConnectedWire
		{
			[Token(Token = "0x6000AD0")]
			[Address(RVA = "0x5AC7C0", Offset = "0x5AADC0", VA = "0x1805AC7C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AD1")]
			[Address(RVA = "0x5B2560", Offset = "0x5B0B60", VA = "0x1805B2560")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x06000AD2 RID: 2770 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x06000AD3 RID: 2771 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170002BA")]
		public ElectricDevice Device
		{
			[Token(Token = "0x6000AD2")]
			[Address(RVA = "0x6710C0", Offset = "0x66F6C0", VA = "0x1806710C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AD3")]
			[Address(RVA = "0x6710D0", Offset = "0x66F6D0", VA = "0x1806710D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x06000AD4 RID: 2772 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170002BB")]
		public static Counter Counter
		{
			[Token(Token = "0x6000AD4")]
			[Address(RVA = "0x2EA3260", Offset = "0x2EA1860", VA = "0x182EA3260")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x06000AD5 RID: 2773 RVA: 0x0000707C File Offset: 0x0000527C
		[Token(Token = "0x6000AD5")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "69")]
		public override bool IsCompleted()
		{
			return default(bool);
		}

		// Token: 0x06000AD6 RID: 2774 RVA: 0x00007094 File Offset: 0x00005294
		[Token(Token = "0x6000AD6")]
		[Address(RVA = "0x2E8F6E0", Offset = "0x2E8DCE0", VA = "0x182E8F6E0", Slot = "73")]
		public override Vector3 CalcNextElementPosition(StructureElement elementPrefab)
		{
			return default(Vector3);
		}

		// Token: 0x06000AD7 RID: 2775 RVA: 0x000070AC File Offset: 0x000052AC
		[Token(Token = "0x6000AD7")]
		[Address(RVA = "0x2EA32B0", Offset = "0x2EA18B0", VA = "0x182EA32B0", Slot = "67")]
		public override RepositionResults TryRepositionOnSupports(ElementRepositionAnimationTool repositionAnim)
		{
			return RepositionResults.Failed;
		}

		// Token: 0x06000AD8 RID: 2776 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AD8")]
		[Address(RVA = "0x2EA36A0", Offset = "0x2EA1CA0", VA = "0x182EA36A0", Slot = "59")]
		public override void OnPostLoad()
		{
		}

		// Token: 0x06000AD9 RID: 2777 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AD9")]
		[Address(RVA = "0x2EA36B0", Offset = "0x2EA1CB0", VA = "0x182EA36B0", Slot = "63")]
		public override void OnElementsChanged()
		{
		}

		// Token: 0x06000ADA RID: 2778 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000ADA")]
		[Address(RVA = "0x2EA36B0", Offset = "0x2EA1CB0", VA = "0x182EA36B0", Slot = "64")]
		public override void OnElementsChangedClient()
		{
		}

		// Token: 0x06000ADB RID: 2779 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000ADB")]
		[Address(RVA = "0x2EA36D0", Offset = "0x2EA1CD0", VA = "0x182EA36D0", Slot = "61")]
		public override void OnDestroyingStructure()
		{
		}

		// Token: 0x06000ADC RID: 2780 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000ADC")]
		[Address(RVA = "0x2EA36D0", Offset = "0x2EA1CD0", VA = "0x182EA36D0", Slot = "62")]
		public override void OnDestroyingStructureClient()
		{
		}

		// Token: 0x06000ADD RID: 2781 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000ADD")]
		[Address(RVA = "0x2EA36E0", Offset = "0x2EA1CE0", VA = "0x182EA36E0")]
		public void SetupElectricitySystem()
		{
		}

		// Token: 0x06000ADE RID: 2782 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000ADE")]
		[Address(RVA = "0x2EA3A10", Offset = "0x2EA2010", VA = "0x182EA3A10")]
		private void CleanupElectricitySystem()
		{
		}

		// Token: 0x06000ADF RID: 2783 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000ADF")]
		[Address(RVA = "0x2EA3C00", Offset = "0x2EA2200", VA = "0x182EA3C00", Slot = "105")]
		private void OnStateChanged(bool isOn)
		{
		}

		// Token: 0x06000AE0 RID: 2784 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AE0")]
		[Address(RVA = "0x2EA3D60", Offset = "0x2EA2360", VA = "0x182EA3D60", Slot = "106")]
		private void OnGridPowerChanged(bool hasPower)
		{
		}

		// Token: 0x06000AE1 RID: 2785 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AE1")]
		[Address(RVA = "0x2EA3DE0", Offset = "0x2EA23E0", VA = "0x182EA3DE0")]
		public ElectricDeviceStructure()
		{
		}

		// Token: 0x06000AE3 RID: 2787 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AE3")]
		[Address(RVA = "0x2EA3F90", Offset = "0x2EA2590", VA = "0x182EA3F90")]
		[CompilerGenerated]
		private void <Sons.Electricity.IElectricDeviceStateReceiver.OnStateChanged>g__CheckSwitchToProfile|28_0(ref ElectricDeviceStructure.<>c__DisplayClass28_0 A_1)
		{
		}

		// Token: 0x06000AE4 RID: 2788 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AE4")]
		[Address(RVA = "0x2EA3D60", Offset = "0x2EA2360", VA = "0x182EA3D60")]
		[CompilerGenerated]
		private void <Sons.Electricity.IElectricDeviceStateReceiver.OnStateChanged>g__SetHasPowerStatus|28_1(ref ElectricDeviceStructure.<>c__DisplayClass28_0 A_1)
		{
		}

		// Token: 0x040006D3 RID: 1747
		[Token(Token = "0x40006D3")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Directions[] SupportedByDirs;
	}
}
