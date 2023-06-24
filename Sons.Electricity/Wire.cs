using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Electricity
{
	// Token: 0x0200000E RID: 14
	[Token(Token = "0x200000E")]
	public class Wire : MonoBehaviour, IPowerGridWire, IMonoBehaviour
	{
		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600003B RID: 59 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x1700000F")]
		private IEnumerable<IPowerGridWire> ConnectedWires
		{
			[Token(Token = "0x600003B")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600003C RID: 60 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x17000010")]
		private IEnumerable<PowerSource> ConnectedPowerSources
		{
			[Token(Token = "0x600003C")]
			[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600003D RID: 61 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x17000011")]
		private IEnumerable<ElectricDevice> ConnectedDevices
		{
			[Token(Token = "0x600003D")]
			[Address(RVA = "0x5B2E80", Offset = "0x5B1480", VA = "0x1805B2E80", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600003E RID: 62 RVA: 0x000020AE File Offset: 0x000002AE
		// (set) Token: 0x0600003F RID: 63 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000012")]
		public PowerGrid PowerGrid
		{
			[Token(Token = "0x600003E")]
			[Address(RVA = "0x5B2EF0", Offset = "0x5B14F0", VA = "0x1805B2EF0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600003F")]
			[Address(RVA = "0x5B2F00", Offset = "0x5B1500", VA = "0x1805B2F00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000040")]
		[Address(RVA = "0x2F8C5E0", Offset = "0x2F8ABE0", VA = "0x182F8C5E0")]
		private void OnDrawGizmosSelected()
		{
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000041")]
		[Address(RVA = "0x2F8CA80", Offset = "0x2F8B080", VA = "0x182F8CA80", Slot = "4")]
		private void SetPowerGrid(PowerGrid powerGrid)
		{
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000042")]
		[Address(RVA = "0x2F8CAE0", Offset = "0x2F8B0E0", VA = "0x182F8CAE0")]
		public void AddPowerSource(PowerSource powerSource)
		{
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000043")]
		[Address(RVA = "0x2F8CCA0", Offset = "0x2F8B2A0", VA = "0x182F8CCA0")]
		public void RemovePowerSource(PowerSource powerSource)
		{
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000044")]
		[Address(RVA = "0x2F8CD60", Offset = "0x2F8B360", VA = "0x182F8CD60")]
		public void AddDevice(ElectricDevice device)
		{
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000045")]
		[Address(RVA = "0x2F8CF20", Offset = "0x2F8B520", VA = "0x182F8CF20")]
		public void RemoveDevice(ElectricDevice device)
		{
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000046")]
		[Address(RVA = "0x2F8CF90", Offset = "0x2F8B590", VA = "0x182F8CF90")]
		public void ConnectWith(Wire wire)
		{
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000047")]
		[Address(RVA = "0x2F8D100", Offset = "0x2F8B700", VA = "0x182F8D100", Slot = "5")]
		private void RemoveWire(IPowerGridWire wire)
		{
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000048")]
		[Address(RVA = "0x2F8D160", Offset = "0x2F8B760", VA = "0x182F8D160")]
		public Wire()
		{
		}

		// Token: 0x06000049 RID: 73 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000049")]
		[Address(RVA = "0x2DC3B50", Offset = "0x2DC2150", VA = "0x182DC3B50", Slot = "10")]
		private GameObject get_gameObject()
		{
			return null;
		}

		// Token: 0x0600004A RID: 74 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x600004A")]
		[Address(RVA = "0x6602D0", Offset = "0x65E8D0", VA = "0x1806602D0", Slot = "11")]
		private Transform get_transform()
		{
			return null;
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00002144 File Offset: 0x00000344
		[Token(Token = "0x600004B")]
		private bool TryGetComponent<T>(out T comp)
		{
			return default(bool);
		}

		// Token: 0x04000020 RID: 32
		[Token(Token = "0x4000020")]
		[FieldOffset(Offset = "0x20")]
		private List<IPowerGridWire> _connectedWires;

		// Token: 0x04000021 RID: 33
		[Token(Token = "0x4000021")]
		[FieldOffset(Offset = "0x28")]
		private List<PowerSource> _connectedPowerSources;

		// Token: 0x04000022 RID: 34
		[Token(Token = "0x4000022")]
		[FieldOffset(Offset = "0x30")]
		private List<ElectricDevice> _connectedDevices;
	}
}
