using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Atmosphere
{
	// Token: 0x02000051 RID: 81
	[Token(Token = "0x2000051")]
	[AddComponentMenu("Sons/Atmosphere/TemperatureModifierVolume")]
	public class TemperatureModifierVolume : MonoBehaviour
	{
		// Token: 0x06000260 RID: 608 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000260")]
		[Address(RVA = "0x2D4F300", Offset = "0x2D4D900", VA = "0x182D4F300")]
		private void OnValidate()
		{
		}

		// Token: 0x06000261 RID: 609 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000261")]
		[Address(RVA = "0x2D4F3F0", Offset = "0x2D4D9F0", VA = "0x182D4F3F0")]
		private void OnEnable()
		{
		}

		// Token: 0x06000262 RID: 610 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000262")]
		[Address(RVA = "0x2D4F450", Offset = "0x2D4DA50", VA = "0x182D4F450")]
		private void OnDisable()
		{
		}

		// Token: 0x06000263 RID: 611 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000263")]
		[Address(RVA = "0x5EA830", Offset = "0x5E8E30", VA = "0x1805EA830")]
		public void SetTemperature(float temperature)
		{
		}

		// Token: 0x06000264 RID: 612 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000264")]
		[Address(RVA = "0x2D4F4B0", Offset = "0x2D4DAB0", VA = "0x182D4F4B0")]
		private void OnTriggerEnter(Collider other)
		{
		}

		// Token: 0x06000265 RID: 613 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000265")]
		[Address(RVA = "0x2D4F570", Offset = "0x2D4DB70", VA = "0x182D4F570")]
		private void Update()
		{
		}

		// Token: 0x06000266 RID: 614 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000266")]
		[Address(RVA = "0x2D4F890", Offset = "0x2D4DE90", VA = "0x182D4F890")]
		private void OnTriggerExit(Collider other)
		{
		}

		// Token: 0x06000267 RID: 615 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000267")]
		[Address(RVA = "0x2D4F950", Offset = "0x2D4DF50", VA = "0x182D4F950")]
		public TemperatureModifierVolume()
		{
		}

		// Token: 0x04000224 RID: 548
		[Token(Token = "0x4000224")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _temperature;

		// Token: 0x04000225 RID: 549
		[Token(Token = "0x4000225")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Collider _collider;

		// Token: 0x04000226 RID: 550
		[Token(Token = "0x4000226")]
		[FieldOffset(Offset = "0x30")]
		private readonly List<Collider> _activeColliders;
	}
}
