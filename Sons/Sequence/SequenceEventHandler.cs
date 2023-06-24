using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Sequence
{
	// Token: 0x02000532 RID: 1330
	[Token(Token = "0x2000532")]
	public abstract class SequenceEventHandler : MonoBehaviour
	{
		// Token: 0x14000017 RID: 23
		// (add) Token: 0x0600233F RID: 9023 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06002340 RID: 9024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000017")]
		internal event Action<SequenceEventHandler> _startEvent
		{
			[Token(Token = "0x600233F")]
			[Address(RVA = "0x334B4E0", Offset = "0x3349AE0", VA = "0x18334B4E0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6002340")]
			[Address(RVA = "0x334B650", Offset = "0x3349C50", VA = "0x18334B650")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000018 RID: 24
		// (add) Token: 0x06002341 RID: 9025 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06002342 RID: 9026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000018")]
		internal event Action<SequenceEventHandler> _endEvent
		{
			[Token(Token = "0x6002341")]
			[Address(RVA = "0x334B7C0", Offset = "0x3349DC0", VA = "0x18334B7C0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6002342")]
			[Address(RVA = "0x334B930", Offset = "0x3349F30", VA = "0x18334B930")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06002343 RID: 9027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002343")]
		[Address(RVA = "0x334B4E0", Offset = "0x3349AE0", VA = "0x18334B4E0")]
		public void RegisterStartEvent(Action<SequenceEventHandler> source)
		{
		}

		// Token: 0x06002344 RID: 9028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002344")]
		[Address(RVA = "0x334B650", Offset = "0x3349C50", VA = "0x18334B650")]
		public void UnregisterStartEvent(Action<SequenceEventHandler> source)
		{
		}

		// Token: 0x06002345 RID: 9029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002345")]
		[Address(RVA = "0x334B7C0", Offset = "0x3349DC0", VA = "0x18334B7C0")]
		public void RegisterEndEvent(Action<SequenceEventHandler> source)
		{
		}

		// Token: 0x06002346 RID: 9030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002346")]
		[Address(RVA = "0x334B930", Offset = "0x3349F30", VA = "0x18334B930")]
		public void UnregisterEndEvent(Action<SequenceEventHandler> source)
		{
		}

		// Token: 0x06002347 RID: 9031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002347")]
		[Address(RVA = "0xFC63A0", Offset = "0xFC49A0", VA = "0x180FC63A0")]
		public void StartEvent(SequenceEventHandler sender)
		{
		}

		// Token: 0x06002348 RID: 9032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002348")]
		[Address(RVA = "0x3104960", Offset = "0x3102F60", VA = "0x183104960")]
		public void EndEvent(SequenceEventHandler sender)
		{
		}

		// Token: 0x06002349 RID: 9033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002349")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		protected SequenceEventHandler()
		{
		}
	}
}
