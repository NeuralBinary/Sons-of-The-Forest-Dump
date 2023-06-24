using System;
using Il2CppDummyDll;
using Sons.Gameplay.GPS;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x0200079E RID: 1950
	[Token(Token = "0x200079E")]
	public class DynamicPickupGpsBeacon : MonoBehaviour
	{
		// Token: 0x0600347B RID: 13435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600347B")]
		[Address(RVA = "0x34CB440", Offset = "0x34C9A40", VA = "0x1834CB440")]
		private void OnEnable()
		{
		}

		// Token: 0x0600347C RID: 13436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600347C")]
		[Address(RVA = "0x34CB510", Offset = "0x34C9B10", VA = "0x1834CB510")]
		private void OnDisable()
		{
		}

		// Token: 0x0600347D RID: 13437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600347D")]
		[Address(RVA = "0x34CB520", Offset = "0x34C9B20", VA = "0x1834CB520")]
		public void Activate(bool activate)
		{
		}

		// Token: 0x0600347E RID: 13438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600347E")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public DynamicPickupGpsBeacon()
		{
		}

		// Token: 0x04002D41 RID: 11585
		[Token(Token = "0x4002D41")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GPSLocator _gpsLocator;
	}
}
