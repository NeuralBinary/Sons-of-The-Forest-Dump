using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Sequence
{
	// Token: 0x0200052B RID: 1323
	[Token(Token = "0x200052B")]
	public abstract class Sequencer : MonoBehaviour
	{
		// Token: 0x0600225D RID: 8797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600225D")]
		[Address(RVA = "0x2D68430", Offset = "0x2D67430", VA = "0x182D68430")]
		protected void AddHandler(SequenceEventHandler sequenceEventHandler)
		{
		}

		// Token: 0x0600225E RID: 8798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600225E")]
		[Address(RVA = "0x2D687F0", Offset = "0x2D677F0", VA = "0x182D687F0")]
		protected void RemoveHandler(SequenceEventHandler sequenceEventHandler)
		{
		}

		// Token: 0x0600225F RID: 8799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600225F")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0", Slot = "4")]
		protected virtual void EndEvent(SequenceEventHandler sender)
		{
		}

		// Token: 0x06002260 RID: 8800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002260")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0", Slot = "5")]
		protected virtual void StartEvent(SequenceEventHandler sender)
		{
		}

		// Token: 0x06002261 RID: 8801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002261")]
		public static void Register<T>(SequenceEventHandler sequenceEventHandler) where T : Sequencer
		{
		}

		// Token: 0x06002262 RID: 8802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002262")]
		public static void Unregister<T>(SequenceEventHandler sequenceEventHandler) where T : Sequencer
		{
		}

		// Token: 0x06002263 RID: 8803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002263")]
		[Address(RVA = "0x2D686C0", Offset = "0x2D676C0", VA = "0x182D686C0")]
		protected static void RegisterSequencer(Sequencer sceneSequencer)
		{
		}

		// Token: 0x06002264 RID: 8804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002264")]
		[Address(RVA = "0x2D67F80", Offset = "0x2D66F80", VA = "0x182D67F80")]
		protected static void UnregisterSequencer(Sequencer sceneSequencer)
		{
		}

		// Token: 0x06002265 RID: 8805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002265")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		protected Sequencer()
		{
		}

		// Token: 0x04001F42 RID: 8002
		[Token(Token = "0x4001F42")]
		[FieldOffset(Offset = "0x0")]
		private static List<Sequencer> _instances;

		// Token: 0x04001F43 RID: 8003
		[Token(Token = "0x4001F43")]
		[FieldOffset(Offset = "0x20")]
		private List<SequenceEventHandler> _sequenceEventHandlers;
	}
}
