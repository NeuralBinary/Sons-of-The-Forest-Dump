using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x020006B6 RID: 1718
	[Token(Token = "0x20006B6")]
	public class SeasonSleepLinker : MonoBehaviour, ISleepingReceiver
	{
		// Token: 0x06002C0A RID: 11274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C0A")]
		[Address(RVA = "0x2DF24D0", Offset = "0x2DF14D0", VA = "0x182DF24D0")]
		private void OnEnable()
		{
		}

		// Token: 0x06002C0B RID: 11275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C0B")]
		[Address(RVA = "0x2DF23A0", Offset = "0x2DF13A0", VA = "0x182DF23A0")]
		private void OnDisable()
		{
		}

		// Token: 0x06002C0C RID: 11276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C0C")]
		[Address(RVA = "0x2DF2630", Offset = "0x2DF1630", VA = "0x182DF2630", Slot = "4")]
		public void OnWentToSleep()
		{
		}

		// Token: 0x06002C0D RID: 11277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C0D")]
		[Address(RVA = "0x2DF26C0", Offset = "0x2DF16C0", VA = "0x182DF26C0", Slot = "5")]
		public void OnWokeUp()
		{
		}

		// Token: 0x06002C0E RID: 11278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C0E")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public SeasonSleepLinker()
		{
		}
	}
}
