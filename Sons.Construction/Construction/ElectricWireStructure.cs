using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Sons.Electricity;
using UnityEngine;

namespace Construction
{
	// Token: 0x02000171 RID: 369
	[Token(Token = "0x2000171")]
	[AddComponentMenu("Sons/Construction/ElectricWireStructure")]
	public class ElectricWireStructure : Structure, IElectricDeviceSupport, IStructure, IMonoBehaviour, ISuperStructureNode
	{
		// Token: 0x170002BE RID: 702
		// (get) Token: 0x06000AFF RID: 2815 RVA: 0x00007154 File Offset: 0x00005354
		[Token(Token = "0x170002BE")]
		public override ushort TypeID
		{
			[Token(Token = "0x6000AFF")]
			[Address(RVA = "0x6C2DD0", Offset = "0x6C13D0", VA = "0x1806C2DD0", Slot = "47")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x06000B00 RID: 2816 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170002BF")]
		public override Directions[] Supporting
		{
			[Token(Token = "0x6000B00")]
			[Address(RVA = "0x2EA57C0", Offset = "0x2EA3DC0", VA = "0x182EA57C0", Slot = "52")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x06000B01 RID: 2817 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170002C0")]
		public override Directions[] SupportedBy
		{
			[Token(Token = "0x6000B01")]
			[Address(RVA = "0x2EA5810", Offset = "0x2EA3E10", VA = "0x182EA5810", Slot = "53")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x06000B02 RID: 2818 RVA: 0x0000716C File Offset: 0x0000536C
		[Token(Token = "0x170002C1")]
		public override int LinkedStructureCount
		{
			[Token(Token = "0x6000B02")]
			[Address(RVA = "0xE51970", Offset = "0xE4FF70", VA = "0x180E51970", Slot = "50")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x06000B03 RID: 2819 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x06000B04 RID: 2820 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170002C2")]
		public Wire Wire
		{
			[Token(Token = "0x6000B03")]
			[Address(RVA = "0x5AC7C0", Offset = "0x5AADC0", VA = "0x1805AC7C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B04")]
			[Address(RVA = "0x5B2560", Offset = "0x5B0B60", VA = "0x1805B2560")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x06000B05 RID: 2821 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170002C3")]
		public static Counter Counter
		{
			[Token(Token = "0x6000B05")]
			[Address(RVA = "0x2EA5860", Offset = "0x2EA3E60", VA = "0x182EA5860")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x06000B06 RID: 2822 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B06")]
		[Address(RVA = "0x2EA58B0", Offset = "0x2EA3EB0", VA = "0x182EA58B0", Slot = "59")]
		public override void OnPostLoad()
		{
		}

		// Token: 0x06000B07 RID: 2823 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B07")]
		[Address(RVA = "0x2EA58B0", Offset = "0x2EA3EB0", VA = "0x182EA58B0", Slot = "63")]
		public override void OnElementsChanged()
		{
		}

		// Token: 0x06000B08 RID: 2824 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B08")]
		[Address(RVA = "0x2EA58B0", Offset = "0x2EA3EB0", VA = "0x182EA58B0", Slot = "64")]
		public override void OnElementsChangedClient()
		{
		}

		// Token: 0x06000B09 RID: 2825 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B09")]
		[Address(RVA = "0x2EA58C0", Offset = "0x2EA3EC0", VA = "0x182EA58C0", Slot = "61")]
		public override void OnDestroyingStructure()
		{
		}

		// Token: 0x06000B0A RID: 2826 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B0A")]
		[Address(RVA = "0x2EA58C0", Offset = "0x2EA3EC0", VA = "0x182EA58C0", Slot = "62")]
		public override void OnDestroyingStructureClient()
		{
		}

		// Token: 0x06000B0B RID: 2827 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B0B")]
		[Address(RVA = "0x2EA5930", Offset = "0x2EA3F30", VA = "0x182EA5930")]
		public void SetupElectricitySystem()
		{
		}

		// Token: 0x06000B0C RID: 2828 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B0C")]
		[Address(RVA = "0x2EA5B40", Offset = "0x2EA4140", VA = "0x182EA5B40")]
		private void ConnectWireWithSiblings()
		{
		}

		// Token: 0x06000B0D RID: 2829 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B0D")]
		[Address(RVA = "0x2EA5CA0", Offset = "0x2EA42A0", VA = "0x182EA5CA0")]
		private void ConnectWireWithSiblingsPowerSource()
		{
		}

		// Token: 0x06000B0E RID: 2830 RVA: 0x00007184 File Offset: 0x00005384
		[Token(Token = "0x6000B0E")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "69")]
		public override bool IsCompleted()
		{
			return default(bool);
		}

		// Token: 0x06000B0F RID: 2831 RVA: 0x0000719C File Offset: 0x0000539C
		[Token(Token = "0x6000B0F")]
		[Address(RVA = "0x2E8F6E0", Offset = "0x2E8DCE0", VA = "0x182E8F6E0", Slot = "73")]
		public override Vector3 CalcNextElementPosition(StructureElement elementPrefab)
		{
			return default(Vector3);
		}

		// Token: 0x06000B10 RID: 2832 RVA: 0x000071B4 File Offset: 0x000053B4
		[Token(Token = "0x6000B10")]
		[Address(RVA = "0x2EA6000", Offset = "0x2EA4600", VA = "0x182EA6000", Slot = "67")]
		public override RepositionResults TryRepositionOnSupports(ElementRepositionAnimationTool repositionAnim)
		{
			return RepositionResults.Failed;
		}

		// Token: 0x06000B11 RID: 2833 RVA: 0x000071CC File Offset: 0x000053CC
		[Token(Token = "0x6000B11")]
		[Address(RVA = "0x2EA63F0", Offset = "0x2EA49F0", VA = "0x182EA63F0", Slot = "105")]
		private bool CanHostNewElectricDevice()
		{
			return default(bool);
		}

		// Token: 0x06000B12 RID: 2834 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B12")]
		[Address(RVA = "0x2EA6590", Offset = "0x2EA4B90", VA = "0x182EA6590", Slot = "106")]
		private void GetPlaceInfo(out Vector3 pos, out Vector3 axis)
		{
		}

		// Token: 0x06000B13 RID: 2835 RVA: 0x000071E4 File Offset: 0x000053E4
		[Token(Token = "0x6000B13")]
		[Address(RVA = "0x2370A50", Offset = "0x236F050", VA = "0x182370A50", Slot = "107")]
		private Directions GetElectricDeviceDir()
		{
			return Directions.LeafStructureSupport;
		}

		// Token: 0x06000B14 RID: 2836 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B14")]
		[Address(RVA = "0x2EA6790", Offset = "0x2EA4D90", VA = "0x182EA6790", Slot = "108")]
		private void SetElectricDevice(ElectricDeviceStructure electricDevice)
		{
		}

		// Token: 0x06000B15 RID: 2837 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000B15")]
		[Address(RVA = "0x5AC7C0", Offset = "0x5AADC0", VA = "0x1805AC7C0", Slot = "109")]
		private Wire GetElectricWire()
		{
			return null;
		}

		// Token: 0x06000B16 RID: 2838 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B16")]
		[Address(RVA = "0x2EA67B0", Offset = "0x2EA4DB0", VA = "0x182EA67B0")]
		public ElectricWireStructure()
		{
		}

		// Token: 0x06000B18 RID: 2840 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000B18")]
		[Address(RVA = "0x2E57220", Offset = "0x2E55820", VA = "0x182E57220", Slot = "7")]
		private string get_name()
		{
			return null;
		}

		// Token: 0x06000B19 RID: 2841 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000B19")]
		[Address(RVA = "0x2DC3B50", Offset = "0x2DC2150", VA = "0x182DC3B50", Slot = "42")]
		private GameObject get_gameObject()
		{
			return null;
		}

		// Token: 0x06000B1A RID: 2842 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000B1A")]
		[Address(RVA = "0x6602D0", Offset = "0x65E8D0", VA = "0x1806602D0", Slot = "43")]
		private Transform get_transform()
		{
			return null;
		}

		// Token: 0x06000B1B RID: 2843 RVA: 0x000071FC File Offset: 0x000053FC
		[Token(Token = "0x6000B1B")]
		private bool TryGetComponent<T>(out T comp)
		{
			return default(bool);
		}

		// Token: 0x06000B1C RID: 2844 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B1C")]
		[Address(RVA = "0x2EA6A10", Offset = "0x2EA5010", VA = "0x182EA6A10")]
		[CompilerGenerated]
		private void <ConnectWireWithSiblings>g__LookupSupportsAndConnectWithWires|23_0(Directions[] dirs, IElectricWireSupport electricWireSupport, ref ElectricWireStructure.<>c__DisplayClass23_0 A_3)
		{
		}

		// Token: 0x06000B1D RID: 2845 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B1D")]
		[Address(RVA = "0x2EA6C90", Offset = "0x2EA5290", VA = "0x182EA6C90")]
		[CompilerGenerated]
		private void <ConnectWireWithSiblings>g__LookupAndConnectWithSupportAncestry|23_1(ref ElectricWireStructure.<>c__DisplayClass23_0 A_1)
		{
		}

		// Token: 0x040006E0 RID: 1760
		[Token(Token = "0x40006E0")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Directions[] SupportingDirs;

		// Token: 0x040006E1 RID: 1761
		[Token(Token = "0x40006E1")]
		[FieldOffset(Offset = "0x10")]
		private static readonly Directions[] SupportedByDirs;
	}
}
