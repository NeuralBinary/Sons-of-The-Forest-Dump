using System;
using Il2CppDummyDll;
using Sons.Physics;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x02000694 RID: 1684
	[Token(Token = "0x2000694")]
	[AddComponentMenu("Sons/Gameplay/ProximityFireFuelConsumer")]
	public class ProximityFireFuelConsumer : MonoBehaviour
	{
		// Token: 0x06002B18 RID: 11032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B18")]
		[Address(RVA = "0x2DE3E30", Offset = "0x2DE2E30", VA = "0x182DE3E30")]
		private void OnEnable()
		{
		}

		// Token: 0x06002B19 RID: 11033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B19")]
		[Address(RVA = "0x2DE3D30", Offset = "0x2DE2D30", VA = "0x182DE3D30")]
		private void OnDisable()
		{
		}

		// Token: 0x06002B1A RID: 11034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B1A")]
		[Address(RVA = "0x2DE3F30", Offset = "0x2DE2F30", VA = "0x182DE3F30")]
		private void OnTriggerStay(Collider other)
		{
		}

		// Token: 0x06002B1B RID: 11035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B1B")]
		[Address(RVA = "0x2DE4020", Offset = "0x2DE3020", VA = "0x182DE4020")]
		public ProximityFireFuelConsumer()
		{
		}

		// Token: 0x040026A2 RID: 9890
		[Token(Token = "0x40026A2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _fuelConsumptionRate;

		// Token: 0x040026A3 RID: 9891
		[Token(Token = "0x40026A3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private OnTriggerProxy _triggerProxy;
	}
}
