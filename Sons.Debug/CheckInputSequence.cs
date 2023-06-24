using System;
using System.Collections.Generic;
using Endnight.Utilities.Timer;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;

namespace Sons.Debug
{
	// Token: 0x02000005 RID: 5
	[Token(Token = "0x2000005")]
	public class CheckInputSequence : MonoBehaviour
	{
		// Token: 0x06000006 RID: 6 RVA: 0x0000206C File Offset: 0x0000026C
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x2F847E0", Offset = "0x2F82DE0", VA = "0x182F847E0")]
		private static int BitShiftKeyValue(Key key, int index)
		{
			return 0;
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x2F847F0", Offset = "0x2F82DF0", VA = "0x182F847F0")]
		private void Start()
		{
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x2F84BC0", Offset = "0x2F831C0", VA = "0x182F84BC0")]
		private void Update()
		{
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x2F84DF0", Offset = "0x2F833F0", VA = "0x182F84DF0")]
		private static string ControlToKeyString(KeyControl sourceControl)
		{
			return null;
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002088 File Offset: 0x00000288
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x2F84E80", Offset = "0x2F83480", VA = "0x182F84E80")]
		private static Key StringToKey(string sourceControlDisplayName)
		{
			return Key.None;
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000020A0 File Offset: 0x000002A0
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x2F84FB0", Offset = "0x2F835B0", VA = "0x182F84FB0")]
		private bool ProcessSequenceInput(Key inputKey, int index)
		{
			return default(bool);
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x2F85100", Offset = "0x2F83700", VA = "0x182F85100")]
		private void BrokeSequence(KeyControl sourceControl)
		{
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x2F85160", Offset = "0x2F83760", VA = "0x182F85160")]
		private void SequenceComplete()
		{
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x2F85180", Offset = "0x2F83780", VA = "0x182F85180")]
		public CheckInputSequence()
		{
		}

		// Token: 0x04000008 RID: 8
		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int KeySequenceDebugKeyHash;

		// Token: 0x04000009 RID: 9
		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x20")]
		private string _generateSequenceSource;

		// Token: 0x0400000A RID: 10
		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<int> _sequence;

		// Token: 0x0400000B RID: 11
		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UnityEvent _onSequenceCompleted;

		// Token: 0x0400000C RID: 12
		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x38")]
		private int _sequenceIndex;

		// Token: 0x0400000D RID: 13
		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x40")]
		private RealtimeAutoTimer _nextKeyTimeoutTimer;

		// Token: 0x0400000E RID: 14
		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x48")]
		private float _timeout;

		// Token: 0x0400000F RID: 15
		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x4C")]
		private bool _logging;
	}
}
