using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Sequence
{
	// Token: 0x02000533 RID: 1331
	[Token(Token = "0x2000533")]
	public abstract class Sequencer : MonoBehaviour
	{
		// Token: 0x0600234A RID: 9034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600234A")]
		[Address(RVA = "0x334BAA0", Offset = "0x334A0A0", VA = "0x18334BAA0")]
		protected void AddHandler(SequenceEventHandler sequenceEventHandler)
		{
		}

		// Token: 0x0600234B RID: 9035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600234B")]
		[Address(RVA = "0x334BEE0", Offset = "0x334A4E0", VA = "0x18334BEE0")]
		protected void RemoveHandler(SequenceEventHandler sequenceEventHandler)
		{
		}

		// Token: 0x0600234C RID: 9036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600234C")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
		protected virtual void EndEvent(SequenceEventHandler sender)
		{
		}

		// Token: 0x0600234D RID: 9037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600234D")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "5")]
		protected virtual void StartEvent(SequenceEventHandler sender)
		{
		}

		// Token: 0x0600234E RID: 9038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600234E")]
		public static void Register<T>(SequenceEventHandler sequenceEventHandler) where T : Sequencer
		{
		}

		// Token: 0x0600234F RID: 9039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600234F")]
		public static void Unregister<T>(SequenceEventHandler sequenceEventHandler) where T : Sequencer
		{
		}

		// Token: 0x06002350 RID: 9040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002350")]
		[Address(RVA = "0x334C2D0", Offset = "0x334A8D0", VA = "0x18334C2D0")]
		protected static void RegisterSequencer(Sequencer sceneSequencer)
		{
		}

		// Token: 0x06002351 RID: 9041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002351")]
		[Address(RVA = "0x334C430", Offset = "0x334AA30", VA = "0x18334C430")]
		protected static void UnregisterSequencer(Sequencer sceneSequencer)
		{
		}

		// Token: 0x06002352 RID: 9042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002352")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		protected Sequencer()
		{
		}

		// Token: 0x04001FF6 RID: 8182
		[Token(Token = "0x4001FF6")]
		[FieldOffset(Offset = "0x0")]
		private static List<Sequencer> _instances;

		// Token: 0x04001FF7 RID: 8183
		[Token(Token = "0x4001FF7")]
		[FieldOffset(Offset = "0x20")]
		private List<SequenceEventHandler> _sequenceEventHandlers;
	}
}
