using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace Ashkatchap.AnimatorEvents
{
	// Token: 0x02000004 RID: 4
	[Token(Token = "0x2000004")]
	[RequireComponent(typeof(Animator))]
	[ExecuteInEditMode]
	public class AnimatorEvent : MonoBehaviour
	{
		// Token: 0x06000003 RID: 3 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x5BCAF0", Offset = "0x5BB0F0", VA = "0x1805BCAF0")]
		private void Awake()
		{
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x5BCC80", Offset = "0x5BB280", VA = "0x1805BCC80")]
		private void OnEnable()
		{
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x5BD050", Offset = "0x5BB650", VA = "0x1805BD050")]
		private void OnDisable()
		{
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x5BD250", Offset = "0x5BB850", VA = "0x1805BD250")]
		public static List<AnimatorEvent> Get(Animator animator)
		{
			return null;
		}

		// Token: 0x06000007 RID: 7 RVA: 0x0000206C File Offset: 0x0000026C
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x5BD320", Offset = "0x5BB920", VA = "0x1805BD320")]
		public bool CallEvent(int id)
		{
			return default(bool);
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x5BD490", Offset = "0x5BBA90", VA = "0x1805BD490")]
		public AnimatorEvent.EventElement AddEventForEditor()
		{
			return null;
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x5BD750", Offset = "0x5BBD50", VA = "0x1805BD750")]
		public AnimatorEvent()
		{
		}

		// Token: 0x04000006 RID: 6
		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<Animator, List<AnimatorEvent>> ByAnimator;

		// Token: 0x04000007 RID: 7
		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Stack<List<AnimatorEvent>> Pool;

		// Token: 0x04000008 RID: 8
		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x20")]
		public readonly Dictionary<int, AnimatorEvent.EventElement> eventsById;

		// Token: 0x04000009 RID: 9
		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x28")]
		public List<AnimatorEvent.EventElement> events;

		// Token: 0x0400000A RID: 10
		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x30")]
		public bool _disableMissingEventErrors;

		// Token: 0x0400000B RID: 11
		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x38")]
		private Animator animator;

		// Token: 0x0400000C RID: 12
		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x10")]
		private static readonly List<AnimatorEvent> Dummy;

		// Token: 0x02000005 RID: 5
		[Token(Token = "0x2000005")]
		[Serializable]
		public class EventElement
		{
			// Token: 0x0600000B RID: 11 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600000B")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public EventElement()
			{
			}

			// Token: 0x0400000D RID: 13
			[Token(Token = "0x400000D")]
			[FieldOffset(Offset = "0x10")]
			public string name;

			// Token: 0x0400000E RID: 14
			[Token(Token = "0x400000E")]
			[FieldOffset(Offset = "0x18")]
			public int id;

			// Token: 0x0400000F RID: 15
			[Token(Token = "0x400000F")]
			[FieldOffset(Offset = "0x20")]
			public UnityEvent action;
		}
	}
}
