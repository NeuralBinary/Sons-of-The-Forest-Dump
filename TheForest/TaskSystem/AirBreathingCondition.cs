using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace TheForest.TaskSystem
{
	// Token: 0x02000442 RID: 1090
	[Token(Token = "0x2000442")]
	[Serializable]
	public class AirBreathingCondition : ACondition
	{
		// Token: 0x06001BE0 RID: 7136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BE0")]
		[Address(RVA = "0x2CDDC50", Offset = "0x2CDCC50", VA = "0x182CDDC50", Slot = "4")]
		public override void Init()
		{
		}

		// Token: 0x06001BE1 RID: 7137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BE1")]
		[Address(RVA = "0x2CDDC20", Offset = "0x2CDCC20", VA = "0x182CDDC20", Slot = "6")]
		public override void Clear()
		{
		}

		// Token: 0x06001BE2 RID: 7138 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BE2")]
		[Address(RVA = "0x2CDDBB0", Offset = "0x2CDCBB0", VA = "0x182CDDBB0")]
		public IEnumerator CheckProximityRoutine()
		{
			return null;
		}

		// Token: 0x06001BE3 RID: 7139 RVA: 0x00008160 File Offset: 0x00006360
		[Token(Token = "0x6001BE3")]
		[Address(RVA = "0x2CDDCD0", Offset = "0x2CDCCD0", VA = "0x182CDDCD0")]
		private bool IsAirBellowThreshold()
		{
			return default(bool);
		}

		// Token: 0x06001BE4 RID: 7140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BE4")]
		[Address(RVA = "0x665E20", Offset = "0x664E20", VA = "0x180665E20")]
		public AirBreathingCondition()
		{
		}

		// Token: 0x04001ADD RID: 6877
		[Token(Token = "0x4001ADD")]
		[FieldOffset(Offset = "0x20")]
		[Header("AirBreathing")]
		public float _threshold;

		// Token: 0x04001ADE RID: 6878
		[Token(Token = "0x4001ADE")]
		[FieldOffset(Offset = "0x28")]
		private Coroutine _routine;
	}
}
