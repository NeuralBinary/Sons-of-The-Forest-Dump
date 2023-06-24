using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Settings
{
	// Token: 0x02000014 RID: 20
	[Token(Token = "0x2000014")]
	[AddComponentMenu("Sons/Settings/TimeOfDaySettings")]
	public class TimeOfDaySettings : MonoBehaviour
	{
		// Token: 0x060000CF RID: 207 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x3142670", Offset = "0x3140C70", VA = "0x183142670")]
		private void OnEnable()
		{
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00002354 File Offset: 0x00000554
		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x3142790", Offset = "0x3140D90", VA = "0x183142790")]
		private float GetBaseSpeedMultiplier()
		{
			return 0f;
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public TimeOfDaySettings()
		{
		}
	}
}
