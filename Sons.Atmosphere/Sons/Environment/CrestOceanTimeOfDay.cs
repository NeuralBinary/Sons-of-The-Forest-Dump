using System;
using Crest;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Environment
{
	// Token: 0x02000008 RID: 8
	[Token(Token = "0x2000008")]
	public class CrestOceanTimeOfDay : TimeOfDayBehaviour
	{
		// Token: 0x0600000A RID: 10 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x2D2D700", Offset = "0x2D2BD00", VA = "0x182D2D700", Slot = "8")]
		public override void UpdateTime(TimeOfDay time, TimeOfDay realTime)
		{
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x2D2D7A0", Offset = "0x2D2BDA0", VA = "0x182D2D7A0")]
		private void AssignLight(Light sourceLight)
		{
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x2D2D8D0", Offset = "0x2D2BED0", VA = "0x182D2D8D0")]
		public CrestOceanTimeOfDay()
		{
		}

		// Token: 0x0400000F RID: 15
		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Light _sunLight;

		// Token: 0x04000010 RID: 16
		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Light _moonLight;

		// Token: 0x04000011 RID: 17
		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private OceanRenderer _oceanRenderer;

		// Token: 0x04000012 RID: 18
		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x50")]
		private bool _isDay;

		// Token: 0x04000013 RID: 19
		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x51")]
		private bool _isNight;
	}
}
