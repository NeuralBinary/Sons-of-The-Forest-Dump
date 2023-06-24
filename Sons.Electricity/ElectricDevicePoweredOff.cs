using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Electricity
{
	// Token: 0x02000005 RID: 5
	[Token(Token = "0x2000005")]
	public class ElectricDevicePoweredOff : MonoBehaviour, IDeviceHasPowerReceiver
	{
		// Token: 0x06000014 RID: 20 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x2F89410", Offset = "0x2F87A10", VA = "0x182F89410")]
		private void Awake()
		{
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x2F89510", Offset = "0x2F87B10", VA = "0x182F89510")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x2F89580", Offset = "0x2F87B80", VA = "0x182F89580", Slot = "4")]
		private void SetDeviceHasPower(bool hasPower)
		{
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public ElectricDevicePoweredOff()
		{
		}

		// Token: 0x0400000D RID: 13
		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ElectricDevicePoweredOff.MaterialSwapData[] _materialSwapData;

		// Token: 0x0400000E RID: 14
		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject[] _poweredOnObjects;

		// Token: 0x0400000F RID: 15
		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x30")]
		private ElectricDevice _electricDevice;

		// Token: 0x02000006 RID: 6
		[Token(Token = "0x2000006")]
		[Serializable]
		public class MaterialSwapData
		{
			// Token: 0x06000018 RID: 24 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000018")]
			[Address(RVA = "0x2F89700", Offset = "0x2F87D00", VA = "0x182F89700")]
			public void SetHasPower(bool poweredOn)
			{
			}

			// Token: 0x06000019 RID: 25 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000019")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public MaterialSwapData()
			{
			}

			// Token: 0x04000010 RID: 16
			[Token(Token = "0x4000010")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private Renderer _renderer;

			// Token: 0x04000011 RID: 17
			[Token(Token = "0x4000011")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Material _poweredOnMaterial;

			// Token: 0x04000012 RID: 18
			[Token(Token = "0x4000012")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private Material _poweredOffMaterial;
		}
	}
}
