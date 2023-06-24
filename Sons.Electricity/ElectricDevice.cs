using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Electricity
{
	// Token: 0x02000004 RID: 4
	[Token(Token = "0x2000004")]
	public class ElectricDevice : MonoBehaviour
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000003 RID: 3 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000001")]
		public float PowerUsage
		{
			[Token(Token = "0x6000003")]
			[Address(RVA = "0x5EA820", Offset = "0x5E8E20", VA = "0x1805EA820")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000004 RID: 4 RVA: 0x00002080 File Offset: 0x00000280
		[Token(Token = "0x17000002")]
		public bool IsOn
		{
			[Token(Token = "0x6000004")]
			[Address(RVA = "0x21FA640", Offset = "0x21F8C40", VA = "0x1821FA640")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000005 RID: 5 RVA: 0x00002098 File Offset: 0x00000298
		// (set) Token: 0x06000006 RID: 6 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000003")]
		public bool HasPower
		{
			[Token(Token = "0x6000005")]
			[Address(RVA = "0x620AC0", Offset = "0x61F0C0", VA = "0x180620AC0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000006")]
			[Address(RVA = "0x620AD0", Offset = "0x61F0D0", VA = "0x180620AD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000007 RID: 7 RVA: 0x000020AE File Offset: 0x000002AE
		// (set) Token: 0x06000008 RID: 8 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000004")]
		public Wire Wire
		{
			[Token(Token = "0x6000007")]
			[Address(RVA = "0x5B2EF0", Offset = "0x5B14F0", VA = "0x1805B2EF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000008")]
			[Address(RVA = "0x5B2F00", Offset = "0x5B1500", VA = "0x1805B2F00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000009 RID: 9 RVA: 0x000020AE File Offset: 0x000002AE
		// (set) Token: 0x0600000A RID: 10 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000005")]
		public PowerGrid PowerGrid
		{
			[Token(Token = "0x6000009")]
			[Address(RVA = "0x5AC7C0", Offset = "0x5AADC0", VA = "0x1805AC7C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600000A")]
			[Address(RVA = "0x5B2560", Offset = "0x5B0B60", VA = "0x1805B2560")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000B RID: 11 RVA: 0x000020AE File Offset: 0x000002AE
		// (set) Token: 0x0600000C RID: 12 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000006")]
		public IElectricDeviceStateReceiver StateReceiver
		{
			[Token(Token = "0x600000B")]
			[Address(RVA = "0x6710C0", Offset = "0x66F6C0", VA = "0x1806710C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600000C")]
			[Address(RVA = "0x6710D0", Offset = "0x66F6D0", VA = "0x1806710D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x2F892C0", Offset = "0x2F878C0", VA = "0x182F892C0")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x5B2F00", Offset = "0x5B1500", VA = "0x1805B2F00")]
		public void SetWire(Wire wire)
		{
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x5B2560", Offset = "0x5B0B60", VA = "0x1805B2560")]
		public void SetPowerGrid(PowerGrid powerGrid)
		{
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x6710D0", Offset = "0x66F6D0", VA = "0x1806710D0")]
		public void SetStateReceiver(IElectricDeviceStateReceiver stateReceiver)
		{
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x2F893B0", Offset = "0x2F879B0", VA = "0x182F893B0")]
		public void SetHasPower(bool hasPower)
		{
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x5B27E0", Offset = "0x5B0DE0", VA = "0x1805B27E0")]
		public void SetDeviceHasPowerReceiver(IDeviceHasPowerReceiver receiver)
		{
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public ElectricDevice()
		{
		}

		// Token: 0x04000006 RID: 6
		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _powerUsage;

		// Token: 0x04000007 RID: 7
		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private bool _isOn;

		// Token: 0x04000008 RID: 8
		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x28")]
		private IDeviceHasPowerReceiver _hasPowerReceiver;
	}
}
