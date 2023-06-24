using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Sons.Events
{
	// Token: 0x02000004 RID: 4
	[Token(Token = "0x2000004")]
	public class EventRegistry
	{
		// Token: 0x06000003 RID: 3 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x2FC7A10", Offset = "0x2FC6010", VA = "0x182FC7A10")]
		public static void Register(object eventType, EventRegistry.SubscriberCallback newSubscriber)
		{
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x2FC7A90", Offset = "0x2FC6090", VA = "0x182FC7A90")]
		public static void Unregister(object eventType, EventRegistry.SubscriberCallback unsubscriber)
		{
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x2FC7B10", Offset = "0x2FC6110", VA = "0x182FC7B10")]
		public static void Invoke(object eventType, [Optional] object eventParameter)
		{
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x2FC7B90", Offset = "0x2FC6190", VA = "0x182FC7B90")]
		public void Subscribe(object eventType, EventRegistry.SubscriberCallback newSubscriber)
		{
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x2FC7D30", Offset = "0x2FC6330", VA = "0x182FC7D30")]
		public void Unsubscribe(object eventType, EventRegistry.SubscriberCallback unsubscriber)
		{
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x2FC7DE0", Offset = "0x2FC63E0", VA = "0x182FC7DE0")]
		public void Publish(object eventType, [Optional] object eventParameter)
		{
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x2FC8060", Offset = "0x2FC6660", VA = "0x182FC8060")]
		public static void Clear()
		{
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x2FC85D0", Offset = "0x2FC6BD0", VA = "0x182FC85D0")]
		public EventRegistry()
		{
		}

		// Token: 0x04000006 RID: 6
		[Token(Token = "0x4000006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly EventRegistry CoreRegistry;

		// Token: 0x04000007 RID: 7
		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly IDictionary<object, IList<EventRegistry.SubscriberCallback>> _eventSubscriptions;

		// Token: 0x04000008 RID: 8
		[Token(Token = "0x4000008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static EventRegistry System;

		// Token: 0x04000009 RID: 9
		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static EventRegistry Game;

		// Token: 0x0400000A RID: 10
		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static EventRegistry Player;

		// Token: 0x0400000B RID: 11
		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static EventRegistry Enemy;

		// Token: 0x0400000C RID: 12
		[Token(Token = "0x400000C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static object Cleared;

		// Token: 0x02000005 RID: 5
		// (Invoke) Token: 0x0600000D RID: 13
		[Token(Token = "0x2000005")]
		public delegate void SubscriberCallback(object eventParameter);
	}
}
