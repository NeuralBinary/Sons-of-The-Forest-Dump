using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai.Vail.StimuliTypes
{
	// Token: 0x020001D6 RID: 470
	[Token(Token = "0x20001D6")]
	[AddComponentMenu("Sons/Stimuli/LogSledHolderStimuli")]
	public class LogSledHolderStimuli : ItemHolderStimuli
	{
		// Token: 0x06000DDC RID: 3548 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000DDC")]
		[Address(RVA = "0x2BA7BC0", Offset = "0x2BA61C0", VA = "0x182BA7BC0")]
		public new static string GetMenuId()
		{
			return null;
		}

		// Token: 0x06000DDD RID: 3549 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000DDD")]
		[Address(RVA = "0x2BA7BF0", Offset = "0x2BA61F0", VA = "0x182BA7BF0")]
		public new static string[] GetMenuIds()
		{
			return null;
		}

		// Token: 0x06000DDE RID: 3550 RVA: 0x00007E00 File Offset: 0x00006000
		[Token(Token = "0x6000DDE")]
		[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0")]
		public new static int GridType()
		{
			return 0;
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x06000DDF RID: 3551 RVA: 0x00007E18 File Offset: 0x00006018
		[Token(Token = "0x170000CB")]
		public override bool IsLogSled
		{
			[Token(Token = "0x6000DDF")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "26")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000DE0 RID: 3552 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DE0")]
		[Address(RVA = "0x1243280", Offset = "0x1241880", VA = "0x181243280")]
		public LogSledHolderStimuli()
		{
		}
	}
}
