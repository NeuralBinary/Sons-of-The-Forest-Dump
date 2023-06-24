using System;
using Il2CppDummyDll;
using Sons.Physics;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x020007C5 RID: 1989
	[Token(Token = "0x20007C5")]
	[AddComponentMenu("Sons/Gameplay/ProximityFireFuelConsumer")]
	public class ProximityFireFuelConsumer : MonoBehaviour
	{
		// Token: 0x060035A2 RID: 13730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035A2")]
		[Address(RVA = "0x34E5C60", Offset = "0x34E4260", VA = "0x1834E5C60")]
		private void OnEnable()
		{
		}

		// Token: 0x060035A3 RID: 13731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035A3")]
		[Address(RVA = "0x34E5DA0", Offset = "0x34E43A0", VA = "0x1834E5DA0")]
		private void OnDisable()
		{
		}

		// Token: 0x060035A4 RID: 13732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035A4")]
		[Address(RVA = "0x34E5EE0", Offset = "0x34E44E0", VA = "0x1834E5EE0")]
		private void OnTriggerStay(Collider other)
		{
		}

		// Token: 0x060035A5 RID: 13733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035A5")]
		[Address(RVA = "0x34E6100", Offset = "0x34E4700", VA = "0x1834E6100")]
		public ProximityFireFuelConsumer()
		{
		}

		// Token: 0x04002E53 RID: 11859
		[Token(Token = "0x4002E53")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _fuelConsumptionRate;

		// Token: 0x04002E54 RID: 11860
		[Token(Token = "0x4002E54")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private OnTriggerProxy _triggerProxy;
	}
}
