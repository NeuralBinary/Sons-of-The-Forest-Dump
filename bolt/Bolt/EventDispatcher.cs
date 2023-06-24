using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Bolt
{
	// Token: 0x0200007A RID: 122
	[Token(Token = "0x200007A")]
	internal class EventDispatcher
	{
		// Token: 0x06000497 RID: 1175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000497")]
		[Address(RVA = "0x8E57B0", Offset = "0x8E3DB0", VA = "0x1808E57B0")]
		private void Raise(Event ev)
		{
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000498")]
		[Address(RVA = "0x8E5B00", Offset = "0x8E4100", VA = "0x1808E5B00")]
		public void Add(MonoBehaviour behaviour)
		{
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000499")]
		[Address(RVA = "0x8E5D90", Offset = "0x8E4390", VA = "0x1808E5D90")]
		public void Remove(MonoBehaviour behaviour)
		{
		}

		// Token: 0x0600049A RID: 1178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600049A")]
		[Address(RVA = "0x8E5E50", Offset = "0x8E4450", VA = "0x1808E5E50")]
		public void Clear()
		{
		}

		// Token: 0x0600049B RID: 1179 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600049B")]
		[Address(RVA = "0x8E6040", Offset = "0x8E4640", VA = "0x1808E6040")]
		public static void Enqueue(Event ev)
		{
		}

		// Token: 0x0600049C RID: 1180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600049C")]
		[Address(RVA = "0x8E60C0", Offset = "0x8E46C0", VA = "0x1808E60C0")]
		public static void Received(Event ev)
		{
		}

		// Token: 0x0600049D RID: 1181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600049D")]
		[Address(RVA = "0x8E6210", Offset = "0x8E4810", VA = "0x1808E6210")]
		public static void DispatchAllEvents()
		{
		}

		// Token: 0x0600049E RID: 1182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600049E")]
		[Address(RVA = "0x8E62D0", Offset = "0x8E48D0", VA = "0x1808E62D0")]
		private static void Dispatch(Event ev)
		{
		}

		// Token: 0x0600049F RID: 1183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600049F")]
		[Address(RVA = "0x8E6770", Offset = "0x8E4D70", VA = "0x1808E6770")]
		private static void Global_Only_Self(Event ev)
		{
		}

		// Token: 0x060004A0 RID: 1184 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x8E67F0", Offset = "0x8E4DF0", VA = "0x1808E67F0")]
		private static void Entity_Only_Self(Event ev)
		{
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x8E6870", Offset = "0x8E4E70", VA = "0x1808E6870")]
		private static void Entity_Only_Owner(Event ev)
		{
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x8E6920", Offset = "0x8E4F20", VA = "0x1808E6920")]
		private static void Entity_Only_Controller(Event ev)
		{
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x8E6A40", Offset = "0x8E5040", VA = "0x1808E6A40")]
		private static void Entity_Everyone_Except_Owner_And_Controller(Event ev)
		{
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x8E6C60", Offset = "0x8E5260", VA = "0x1808E6C60")]
		private static void Entity_Everyone_Except_Owner(Event ev)
		{
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x8E6E20", Offset = "0x8E5420", VA = "0x1808E6E20")]
		private static void Entity_Everyone_Except_Controller(Event ev)
		{
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x8E7050", Offset = "0x8E5650", VA = "0x1808E7050")]
		private static void Entity_Everyone(Event ev)
		{
		}

		// Token: 0x060004A7 RID: 1191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x8E7200", Offset = "0x8E5800", VA = "0x1808E7200")]
		private static void Global_Specific_Connection(Event ev)
		{
		}

		// Token: 0x060004A8 RID: 1192 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x8E7280", Offset = "0x8E5880", VA = "0x1808E7280")]
		private static void Global_Server(Event ev)
		{
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x8E7340", Offset = "0x8E5940", VA = "0x1808E7340")]
		private static void Global_All_Clients(Event ev)
		{
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x8E7500", Offset = "0x8E5B00", VA = "0x1808E7500")]
		private static void Global_Others(Event ev)
		{
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x8E76B0", Offset = "0x8E5CB0", VA = "0x1808E76B0")]
		private static void Global_Everyone(Event ev)
		{
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x8E7850", Offset = "0x8E5E50", VA = "0x1808E7850")]
		private static void RaiseLocal(Event ev)
		{
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x8E7940", Offset = "0x8E5F40", VA = "0x1808E7940")]
		public EventDispatcher()
		{
		}

		// Token: 0x0400020C RID: 524
		[Token(Token = "0x400020C")]
		[FieldOffset(Offset = "0x10")]
		private List<EventDispatcher.EventListener> _targets;

		// Token: 0x0400020D RID: 525
		[Token(Token = "0x400020D")]
		[FieldOffset(Offset = "0x0")]
		private static Queue<Event> _dispatchQueue;

		// Token: 0x0200007B RID: 123
		[Token(Token = "0x200007B")]
		private struct EventListener
		{
			// Token: 0x0400020E RID: 526
			[Token(Token = "0x400020E")]
			[FieldOffset(Offset = "0x0")]
			public IEventListener Listener;

			// Token: 0x0400020F RID: 527
			[Token(Token = "0x400020F")]
			[FieldOffset(Offset = "0x8")]
			public GameObject GameObject;

			// Token: 0x04000210 RID: 528
			[Token(Token = "0x4000210")]
			[FieldOffset(Offset = "0x10")]
			public MonoBehaviour Behaviour;
		}
	}
}
