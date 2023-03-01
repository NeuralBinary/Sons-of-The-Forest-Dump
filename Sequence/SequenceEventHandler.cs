using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Sequence
{
	// Token: 0x0200052A RID: 1322
	[Token(Token = "0x200052A")]
	public abstract class SequenceEventHandler : MonoBehaviour
	{
		// Token: 0x14000014 RID: 20
		// (add) Token: 0x06002252 RID: 8786 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06002253 RID: 8787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000014")]
		internal event Action<SequenceEventHandler> _startEvent
		{
			[Token(Token = "0x6002252")]
			[Address(RVA = "0x2D68220", Offset = "0x2D67220", VA = "0x182D68220")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6002253")]
			[Address(RVA = "0x2D68380", Offset = "0x2D67380", VA = "0x182D68380")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000015 RID: 21
		// (add) Token: 0x06002254 RID: 8788 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06002255 RID: 8789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000015")]
		internal event Action<SequenceEventHandler> _endEvent
		{
			[Token(Token = "0x6002254")]
			[Address(RVA = "0x2D68170", Offset = "0x2D67170", VA = "0x182D68170")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6002255")]
			[Address(RVA = "0x2D682D0", Offset = "0x2D672D0", VA = "0x182D682D0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06002256 RID: 8790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002256")]
		[Address(RVA = "0x2D68220", Offset = "0x2D67220", VA = "0x182D68220")]
		public void RegisterStartEvent(Action<SequenceEventHandler> source)
		{
		}

		// Token: 0x06002257 RID: 8791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002257")]
		[Address(RVA = "0x2D68380", Offset = "0x2D67380", VA = "0x182D68380")]
		public void UnregisterStartEvent(Action<SequenceEventHandler> source)
		{
		}

		// Token: 0x06002258 RID: 8792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002258")]
		[Address(RVA = "0x2D68170", Offset = "0x2D67170", VA = "0x182D68170")]
		public void RegisterEndEvent(Action<SequenceEventHandler> source)
		{
		}

		// Token: 0x06002259 RID: 8793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002259")]
		[Address(RVA = "0x2D682D0", Offset = "0x2D672D0", VA = "0x182D682D0")]
		public void UnregisterEndEvent(Action<SequenceEventHandler> source)
		{
		}

		// Token: 0x0600225A RID: 8794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600225A")]
		[Address(RVA = "0xDCF680", Offset = "0xDCE680", VA = "0x180DCF680")]
		public void StartEvent(SequenceEventHandler sender)
		{
		}

		// Token: 0x0600225B RID: 8795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600225B")]
		[Address(RVA = "0x2AE2470", Offset = "0x2AE1470", VA = "0x182AE2470")]
		public void EndEvent(SequenceEventHandler sender)
		{
		}

		// Token: 0x0600225C RID: 8796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600225C")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		protected SequenceEventHandler()
		{
		}
	}
}
