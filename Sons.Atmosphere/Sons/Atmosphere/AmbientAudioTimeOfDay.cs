using System;
using Il2CppDummyDll;
using Sons.Environment;
using UnityEngine;

namespace Sons.Atmosphere
{
	// Token: 0x02000020 RID: 32
	[Token(Token = "0x2000020")]
	[AddComponentMenu("Sons/Atmosphere/AmbientAudioTimeOfDay")]
	public class AmbientAudioTimeOfDay : TimeOfDayBehaviour
	{
		// Token: 0x060000F0 RID: 240 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x2D3A920", Offset = "0x2D38F20", VA = "0x182D3A920", Slot = "8")]
		public override void UpdateTime(TimeOfDay time, TimeOfDay realTime)
		{
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x2D2D8D0", Offset = "0x2D2BED0", VA = "0x182D2D8D0")]
		public AmbientAudioTimeOfDay()
		{
		}
	}
}
