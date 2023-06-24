using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai.Vail.StimuliTypes
{
	// Token: 0x02000192 RID: 402
	[Token(Token = "0x2000192")]
	[AddComponentMenu("Sons/Stimuli/Dead Body Cannibal Stimuli")]
	public class DeadBodyCannibalStimuli : DeadBodyStimuli
	{
		// Token: 0x06000C7E RID: 3198 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000C7E")]
		[Address(RVA = "0x2B9C3C0", Offset = "0x2B9A9C0", VA = "0x182B9C3C0")]
		public new static string GetMenuId()
		{
			return null;
		}

		// Token: 0x06000C7F RID: 3199 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000C7F")]
		[Address(RVA = "0x2B9C3F0", Offset = "0x2B9A9F0", VA = "0x182B9C3F0")]
		public new static string[] GetMenuIds()
		{
			return null;
		}

		// Token: 0x06000C80 RID: 3200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C80")]
		[Address(RVA = "0x2B9C470", Offset = "0x2B9AA70", VA = "0x182B9C470", Slot = "9")]
		internal override void OnEnable()
		{
		}

		// Token: 0x06000C81 RID: 3201 RVA: 0x00007530 File Offset: 0x00005730
		[Token(Token = "0x6000C81")]
		[Address(RVA = "0x2B9C4D0", Offset = "0x2B9AAD0", VA = "0x182B9C4D0", Slot = "11")]
		public override bool IsValid()
		{
			return default(bool);
		}

		// Token: 0x06000C82 RID: 3202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C82")]
		[Address(RVA = "0x1243280", Offset = "0x1241880", VA = "0x181243280")]
		public DeadBodyCannibalStimuli()
		{
		}

		// Token: 0x04000865 RID: 2149
		[Token(Token = "0x4000865")]
		[FieldOffset(Offset = "0xA8")]
		private float _enableTime;
	}
}
