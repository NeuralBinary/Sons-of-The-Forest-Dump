using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai.Vail.StimuliTypes
{
	// Token: 0x020001A7 RID: 423
	[Token(Token = "0x20001A7")]
	[AddComponentMenu("Sons/Stimuli/Event/Melee Attack Stimuli")]
	public class MeleeAttack : EventStimuli
	{
		// Token: 0x06000CEF RID: 3311 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000CEF")]
		[Address(RVA = "0x2BA0290", Offset = "0x2B9E890", VA = "0x182BA0290")]
		public static string GetMenuId()
		{
			return null;
		}

		// Token: 0x06000CF0 RID: 3312 RVA: 0x00007878 File Offset: 0x00005A78
		[Token(Token = "0x6000CF0")]
		[Address(RVA = "0x9FA5F0", Offset = "0x9F8BF0", VA = "0x1809FA5F0")]
		public static int GridType()
		{
			return 0;
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x06000CF1 RID: 3313 RVA: 0x00007890 File Offset: 0x00005A90
		[Token(Token = "0x170000C7")]
		public bool IsHeavyAttack
		{
			[Token(Token = "0x6000CF1")]
			[Address(RVA = "0xA03DD0", Offset = "0xA023D0", VA = "0x180A03DD0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000CF2 RID: 3314 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CF2")]
		[Address(RVA = "0x2962930", Offset = "0x2960F30", VA = "0x182962930")]
		public void SetIsHeavyAttack(bool value)
		{
		}

		// Token: 0x06000CF3 RID: 3315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CF3")]
		[Address(RVA = "0x2B9CE20", Offset = "0x2B9B420", VA = "0x182B9CE20")]
		public MeleeAttack()
		{
		}

		// Token: 0x04000897 RID: 2199
		[Token(Token = "0x4000897")]
		[FieldOffset(Offset = "0xE0")]
		private bool _isHeavyAttack;
	}
}
